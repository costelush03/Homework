using System;
using WorkersApp.Interfaces;

namespace WorkersApp.Workers
{
    public class RobotWorker : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot working...");
        }
    }
}
