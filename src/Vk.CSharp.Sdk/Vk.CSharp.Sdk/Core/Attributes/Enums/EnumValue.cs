using System;

namespace Vk.CSharp.Sdk.Core.Attributes.Enums
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class EnumValue : Attribute
    {
        public object Value { get; set; }

        public EnumValue(object value)
        {
            Value = value;
        }
    }
}