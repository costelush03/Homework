using System;

namespace Homework.Exceptions
{
    public class NotaInvalidaException : Exception
    {
        public NotaInvalidaException(string message) : base(message) { }
    }
}

