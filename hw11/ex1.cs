using System;
using System.Threading;
using System.Threading.Tasks;

public static class Ex1
{
    static SemaphoreSlim dbSemaphore = new SemaphoreSlim(3);

    public static void Run()
    {
        var tasks = new Task[10];

        for (int i = 0; i < 10; i++)
        {
            int id = i;
            tasks[i] = Task.Run(() => AccessDatabaseAsync(id));
        }

        Task.WaitAll(tasks);
    }

    static async Task AccessDatabaseAsync(int id)
    {
        Console.WriteLine($"Thread {id} asteapta acces la DB...");

        await dbSemaphore.WaitAsync();

        try
        {
            Console.WriteLine($"Thread {id} a intrat in baza de date.");
            await Task.Delay(1000);
        }
        finally
        {
            Console.WriteLine($"Thread {id} a eliberat conexiunea.");
            dbSemaphore.Release();
        }
    }
}




