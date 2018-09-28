using System;

namespace Vk.CSharp.Sdk.Exceptions
{
    public class ResponseException : Exception
    {
        public ResponseException() { }

        public ResponseException(string message)
            : base(message) { }

        public ResponseException(string message, Exception inner)
            : base(message, inner) { }
    }
}