using System;
using System.Collections.Generic;
using System.Linq;
using Homework.Exceptions;

namespace Homework
{
    public static class Ex1CalculatorMedie
    {
        public static void Run()
        {
            try
            {
                List<double> note = new List<double>();

                Console.WriteLine("Introdu 4 note intre 0 si 10:");

                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"Nota {i + 1}: ");
                    string input = Console.ReadLine();

                    if (!double.TryParse(input, out double nota))
                        throw new NotaInvalidaException("Valoarea introdusa nu este numerica.");

                    if (nota < 0 || nota > 10)
                        throw new NotaInvalidaException("Nota trebuie sa fie intre 0 si 10.");

                    note.Add(nota);
                }

                double media = note.Average();
                Console.WriteLine($"Media notelor este: {media:F2}");
            }
            catch (NotaInvalidaException ex)
            {
                Console.WriteLine("Eroare: " + ex.Message);
            }
        }
    }
}

