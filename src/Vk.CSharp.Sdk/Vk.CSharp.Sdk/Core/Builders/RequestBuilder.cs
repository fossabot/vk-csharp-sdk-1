using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Vk.CSharp.Sdk.Core.Attributes.Parameters;
using Vk.CSharp.Sdk.Core.Builders.Interfaces;
using Vk.CSharp.Sdk.Core.Extensions;
using Vk.CSharp.Sdk.Core.Models;

namespace Vk.CSharp.Sdk.Core.Builders
{
    internal class RequestBuilder<TModule> : IRequestBuilder<TModule>
         where TModule : class
    {
        protected string MethodName { get; set; }

        protected string AccessToken { get; set; }

        protected string Version { get; set; } =
            VkSdkProvider
                .GetCurrentVkApiVersion()
                .GetStringValue();

        protected StringBuilder Request { get; set; } = new StringBuilder();

        public IRequestBuilder<TModule> Initialize<TParameters>(RequestData<TParameters> data)
            where TParameters : class
        {
            MethodName = data.MethodName;
            AccessToken = data.AccessToken;

            Request.Clear();
            Request.Append("https://api.vk.com/method/");

            return this;
        }

        public IRequestBuilder<TModule> BuildModuleAndMethod()
        {
            Request.Append(GetModuleName());
            Request.Append(GetDot());
            Request.Append(GetMethodName());

            return this;
        }

        public IRequestBuilder<TModule> BuildQuestionMark()
        {
            Request.Append("?");

            return this;
        }

        public IRequestBuilder<TModule> BuildParameters<TParameters>(RequestData<TParameters> data)
            where TParameters : class
        {
            var properties = typeof(TParameters)
                .GetRuntimeProperties()
                .ToList();

            string GetKey(MemberInfo memberInfo) =>
                memberInfo.GetCustomAttribute<ParameterKey>().Key;

            object GetValue(PropertyInfo memberInfo) =>
                memberInfo.GetValue(data.Parameters);

            var dictionary = properties
                .Where(p => p.GetCustomAttribute<IgnoreParameter>() == null ||
                    IsNotDefaultValue(p.GetValue(data.Parameters)))
                .ToDictionary(GetKey, GetValue);

            AppendParameters(dictionary);

            return this;
        }

        public IRequestBuilder<TModule> BuildDuty()
        {
            Request.Append($"access_token={AccessToken}&v={Version}");

            return this;
        }

        public Request GetRequest<TParameters>(RequestData<TParameters> data)
            where TParameters : class
        {
            return new Request(Request.ToString(), MethodName);
        }

        protected string GetModuleName()
        {
            var moduleName = typeof(TModule).Name;

            return char.ToLowerInvariant(moduleName.First()) + moduleName.Substring(1);
        }

        protected static string GetDot() => ".";

        protected string GetMethodName()
        {
            return char.ToLowerInvariant(MethodName.First()) + MethodName.Substring(1);
        }

        protected void AppendParameters(Dictionary<string, object> dictionary)
        {
            foreach (var item in dictionary)
            {
                Request.Append(item.Key);
                Request.Append("=");

                switch (item.Value)
                {
                    case bool _:
                        AppendBoolValue(item.Value);
                        break;
                    case IEnumerable<byte> _:
                        AppendEnumerableValue<byte>(item.Value);
                        break;
                    case IEnumerable<int> _:
                        AppendEnumerableValue<int>(item.Value);
                        break;
                    case IEnumerable<long> _:
                        AppendEnumerableValue<long>(item.Value);
                        break;
                    case IEnumerable<string> _:
                        AppendEnumerableValue<string>(item.Value);
                        break;
                    case IEnumerable<Enum> _:
                        AppendEnumerableValue(item.Value as IEnumerable<Enum>);
                        break;
                    case Enum _:
                        AppendEnumValue(item.Value as Enum);
                        break;
                    default:
                        AppendDefault(item.Value);
                        break;
                }

                Request.Append("&");
            }
        }

        private void AppendDefault(object value)
        {
            Request.Append(value);
        }

        private void AppendBoolValue(object value)
        {
            Request.Append(ConvertToBool(value) ? 1 : 0);
        }

        private void AppendEnumerableValue<T>(object value)
        {
            Request.Append(string.Join(",", ToEnumerable<T>(value)));
        }

        private void AppendEnumerableValue(IEnumerable<Enum> value)
        {
            Request.Append(string.Join(",", value.Select(GetEnumValue)));
        }

        private static string GetEnumValue(Enum value)
        {
            var stringValue = value?.GetStringValue();

            return string.IsNullOrWhiteSpace(stringValue)
                ? ConvertToInt(value).ToString()
                : stringValue;
        }

        private void AppendEnumValue(Enum value)
        {
            Request.Append(GetEnumValue(value));
        }

        private static bool ConvertToBool(object value) => (bool)value;

        private static int ConvertToInt(object value) => (int)value;

        private static IEnumerable<T> ToEnumerable<T>(object value) => (IEnumerable<T>)value;

        private static bool IsDefaultValue(object value)
        {
            switch (value)
            {
                case bool _:
                    return (bool)value == default(bool);
                case byte _:
                    return (byte)value == default(byte);
                case int _:
                    return (int)value == default(int);
                case long _:
                    return (long)value == default(long);
                case string _:
                    return string.IsNullOrWhiteSpace(value as string);
                default:
                    return false;
            }
        }

        private static bool IsNotDefaultValue(object value) =>
            !IsDefaultValue(value);
    }
}