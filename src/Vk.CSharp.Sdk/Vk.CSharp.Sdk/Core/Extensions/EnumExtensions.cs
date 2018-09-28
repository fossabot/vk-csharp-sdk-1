using System;
using System.Reflection;
using Vk.CSharp.Sdk.Core.Attributes.Enums;

namespace Vk.CSharp.Sdk.Core.Extensions
{
    internal static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            return value
               .GetType()
               .GetRuntimeField(value.ToString())
               .GetCustomAttribute<EnumDescription>()?
               .Description?.TrimEnd('.') ?? string.Empty;
        }

        public static object GetObjectValue(this Enum value)
        {
            return value
                .GetType()
                .GetRuntimeField(value.ToString())
                .GetCustomAttribute<EnumValue>()?
                .Value;
        }

        public static string GetStringValue(this Enum value)
        {
            return value
               .GetType()
               .GetRuntimeField(value.ToString())
               .GetCustomAttribute<EnumValue>()?
               .Value as string ?? string.Empty;
        }
    }
}