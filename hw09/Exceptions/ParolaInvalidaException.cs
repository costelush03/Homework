using System;

namespace Homework.Exceptions
{
    public class ParolaInvalidaException : Exception
    {
        public ParolaInvalidaException() : base("Parola trebuie sa contina litera mare, litera mica si cifra.") { }
    }
}

