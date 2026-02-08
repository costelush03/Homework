using System;
using System.Collections.Generic;
using System.Linq;
using Homework.Exceptions;

namespace Homework
{
    public static class Ex2Autentificare
    {
        public static void Run()
        {
            var db = new Dictionary<string, string>
            {
                { "admin", "Admin123" },
                { "test", "Test123" }
            };

            try
            {
                Console.Write("Nume utilizator: ");
                string user = Console.ReadLine();

                Console.Write("Parola: ");
                string pass = Console.ReadLine();

                Validare(user, pass);
                VerificaCredentiale(db, user, pass);

                Console.WriteLine("Autentificare reusita!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare: " + ex.Message);
            }
        }

        private static void Validare(string user, string pass)
        {
            if (string.IsNullOrWhiteSpace(user))
                throw new NumeUtilizatorGolException();

            if (pass.Length < 6)
                throw new ParolaPreaScurtaException();

            bool upper = pass.Any(char.IsUpper);
            bool lower = pass.Any(char.IsLower);
            bool digit = pass.Any(char.IsDigit);

            if (!upper || !lower || !digit)
                throw new ParolaInvalidaException();
        }

        private static void VerificaCredentiale(Dictionary<string, string> db, string user, string pass)
        {
            if (!db.ContainsKey(user) || db[user] != pass)
                throw new CredentialeInvalideException();
        }
    }
}

