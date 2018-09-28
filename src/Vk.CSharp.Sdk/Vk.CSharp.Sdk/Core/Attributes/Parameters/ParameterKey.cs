using System;

namespace Vk.CSharp.Sdk.Core.Attributes.Parameters
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class ParameterKey : Attribute
    {
        public string Key { get; set; }

        public ParameterKey(string key)
        {
            Key = key;
        }
    }
}