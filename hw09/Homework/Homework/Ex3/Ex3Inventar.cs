using System;
using System.Collections.Generic;

namespace Homework
{
    public static class Ex3Inventar
    {
        public static void Run()
        {
            List<Produs> inventar = new List<Produs>();

            Console.Write("Numar produse: ");
            int nr = int.Parse(Console.ReadLine());

            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine($"\nProdus #{i + 1}");

                Produs p = new Produs();

                Console.Write("Nume: ");
                p.Nume = Console.ReadLine();

                Console.Write("Pret: ");
                p.Pret = double.Parse(Console.ReadLine());

                Console.Write("Cantitate: ");
                p.Cantitate = int.Parse(Console.ReadLine());

                inventar.Add(p);
            }

            Console.WriteLine("\n=== INVENTAR ===");
            foreach (var p in inventar)
                Console.WriteLine($"{p.Nume} - {p.Pret} lei - {p.Cantitate} buc");
        }
    }
}

