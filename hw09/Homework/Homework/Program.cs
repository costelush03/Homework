using System;

namespace Homework
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n=== MENIU EXERCITII ===");
                Console.WriteLine("1. Ex1 – Calcularea mediei notelor");
                Console.WriteLine("2. Ex2 – Validarea autentificarii");
                Console.WriteLine("3. Ex3 – Gestionarea inventarului");
                Console.WriteLine("0. Iesire");
                Console.Write("Alege optiunea: ");

                string opt = Console.ReadLine();
                Console.Clear();

                switch (opt)
                {
                    case "1":
                        Ex1CalculatorMedie.Run();
                        break;

                    case "2":
                        Ex2Autentificare.Run();
                        break;

                    case "3":
                        Ex3Inventar.Run();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Optiune invalida.");
                        break;
                }
            }
        }
    }
}



