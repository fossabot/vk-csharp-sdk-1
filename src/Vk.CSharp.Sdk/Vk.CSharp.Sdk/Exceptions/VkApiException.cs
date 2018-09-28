using System;

namespace Vk.CSharp.Sdk.Exceptions
{
    public class VkApiException : Exception
    {
        public int ErrorCode { get; set; }

        public VkApiException(string message) : base(message) { }

        public VkApiException(int errorCode)
        {
            ErrorCode = errorCode;
        }

        public VkApiException(string message, int errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        public VkApiException(string message, int errorCode, Exception inner) : base(message, inner)
        {
            ErrorCode = errorCode;
        }
    }
}