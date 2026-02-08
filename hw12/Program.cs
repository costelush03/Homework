using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("=== HW12 ===");

        // ==============================
        // Ex1: Citire asincronă de fișiere
        // ==============================
        Console.WriteLine("\nEx1: Citire asincronă de fișiere\n");

        // Folosim calea sigură a folderului Data din bin/
        string folderPath = Path.Combine(AppContext.BaseDirectory, "Data");

        if (!Directory.Exists(folderPath))
        {
            Console.WriteLine($"Folderul nu există: {folderPath}");
            return;
        }

        var files = Directory.GetFiles(folderPath, "*.txt");

        var readTasks = files
            .Select(file => ReadLinesAsync(file))
            .ToList();

        var results = await Task.WhenAll(readTasks);

        Console.WriteLine("Rezultatele citirii:");
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine($"{Path.GetFileName(files[i])}: {results[i]} linii");
        }

        // ==============================
        // Ex2: Procesare comenzi asincron
        // ==============================
        Console.WriteLine("\n-------------------------------------\n");
        Console.WriteLine("Ex2: Procesare comenzi asincron (simulare I/O)\n");

        var processor = new OrderProcessor();

        var orderTasks = Enumerable.Range(1, 5)
            .Select(id => processor.ProcessOrderAsync(id))
            .ToList();

        await Task.WhenAll(orderTasks);

        Console.WriteLine("Toate comenzile au fost procesate.");
    }

    static async Task<int> ReadLinesAsync(string filePath)
    {
        int count = 0;

        using var stream = new FileStream(
            filePath,
            FileMode.Open,
            FileAccess.Read,
            FileShare.Read,
            bufferSize: 4096,
            useAsync: true);

        using var reader = new StreamReader(stream);

        while (await reader.ReadLineAsync() is not null)
        {
            count++;
        }

        return count;
    }
}






