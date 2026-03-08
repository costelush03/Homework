using System;
using WorkersApp.Interfaces;

namespace WorkersApp.Workers
{
    public class HumanWorker : IWorkable, IEatable
    {
        public void Work()
        {
            Console.WriteLine("Human working...");
        }

        public void Eat()
        {
            Console.WriteLine("Human eating...");
        }
    }
}
