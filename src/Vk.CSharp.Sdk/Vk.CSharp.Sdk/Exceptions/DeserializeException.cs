﻿using System;

namespace Vk.CSharp.Sdk.Exceptions
{
    public class DeserializeException : Exception
    {
        public DeserializeException() { }

        public DeserializeException(string message)
            : base(message) { }

        public DeserializeException(string message, Exception inner)
            : base(message, inner) { }
    }
}