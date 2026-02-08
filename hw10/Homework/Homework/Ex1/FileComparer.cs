using System;
using System.IO;

namespace Homework.Ex1
{
    public static class FileComparer
    {
        public static void Run()
        {
            string file1 = "file1.txt";
            string file2 = "file2.txt";

            if (!File.Exists(file1))
                File.WriteAllText(file1, "Text in file 1");

            if (!File.Exists(file2))
                File.WriteAllText(file2, "Text in file 2");

            string content1 = File.ReadAllText(file1);
            string content2 = File.ReadAllText(file2);

            if (content1 == content2)
                Console.WriteLine("The files are identical.");
            else
                Console.WriteLine("The files are different.");
        }
    }
}


