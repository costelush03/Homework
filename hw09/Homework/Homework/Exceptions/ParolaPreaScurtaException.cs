using System;

namespace Homework.Exceptions
{
    public class ParolaPreaScurtaException : Exception
    {
        public ParolaPreaScurtaException() : base("Parola prea scurta (minim 6).") { }
    }
}

