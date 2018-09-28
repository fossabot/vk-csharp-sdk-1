using System;

namespace Vk.CSharp.Sdk.Exceptions
{
    public class AccessTokenException : Exception
    {
        public AccessTokenException() { }

        public AccessTokenException(string message)
            : base(message) { }

        public AccessTokenException(string message, Exception inner)
            : base(message, inner) { }
    }
}