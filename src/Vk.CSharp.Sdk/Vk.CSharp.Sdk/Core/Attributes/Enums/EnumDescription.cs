using System;

namespace Vk.CSharp.Sdk.Core.Attributes.Enums
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class EnumDescription : Attribute
    {
        public string Description { get; set; }

        public EnumDescription(string description)
        {
            Description = description;
        }
    }
}