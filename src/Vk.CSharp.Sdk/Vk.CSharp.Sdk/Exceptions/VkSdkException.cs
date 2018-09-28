using System;

namespace Vk.CSharp.Sdk.Exceptions
{
    public class VkSdkException : Exception
    {
        public VkSdkException() { }

        public VkSdkException(string message)
            : base(message) { }

        public VkSdkException(string message, Exception inner)
            : base(message, inner) { }
    }
}