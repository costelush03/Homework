using Homework.Ex1;
using Homework.Ex2;


class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== HW10 MENU ===");
            Console.WriteLine("1. Ex1 - Compare Files");
            Console.WriteLine("2. Ex2 - Move Files");
            Console.WriteLine("0. Exit");
            Console.Write("Choose: ");

            string option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1":
                    FileComparer.Run();
                    break;

                case "2":
                    FileMover.Run();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}



