using System;
using System.IO;

namespace Homework.Ex2
{
    public static class FileMover
    {
        public static void Run()
        {
            string source = "SourceFolder";
            string backup = "BackupFolder";

            if (!Directory.Exists(source))
                Directory.CreateDirectory(source);

            if (Directory.GetFiles(source).Length == 0)
            {
                File.WriteAllText(Path.Combine(source, "a.txt"), "File A");
                File.WriteAllText(Path.Combine(source, "b.txt"), "File B");
            }

            if (!Directory.Exists(backup))
                Directory.CreateDirectory(backup);

            foreach (var file in Directory.GetFiles(source))
            {
                string destination = Path.Combine(backup, Path.GetFileName(file));
                File.Move(file, destination, true);
            }

            Console.WriteLine("Files moved to BackupFolder:");
            foreach (var file in Directory.GetFiles(backup))
                Console.WriteLine("- " + Path.GetFileName(file));
        }
    }
}


