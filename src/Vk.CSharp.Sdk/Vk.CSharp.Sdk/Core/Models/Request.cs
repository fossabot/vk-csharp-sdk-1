namespace Vk.CSharp.Sdk.Core.Models
{
    internal class Request
    {
        public string Value { get; set; }

        public string MethodName { get; set; }

        public Request(string value, string methodName)
        {
            Value = value;
            MethodName = methodName;
        }
    }
}