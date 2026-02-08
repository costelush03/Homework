using System;

namespace Homework.Exceptions
{
    public class NumeUtilizatorGolException : Exception
    {
        public NumeUtilizatorGolException() : base("Numele de utilizator este gol.") { }
    }
}

