using System;
using System.IO;

namespace Aula_2___FileSystemWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\workspace\dio-csharp-dotnet\arquivos-streams-csharp\Aula 1- SystemIO\demo2-directory\Globo";
            //FileSystemWatcher é IDisposable
            using var fsw = new FileSystemWatcher(path);
            fsw.Created += OnCreated;
            fsw.Deleted += onDeleted;
            fsw.Renamed += onRenamed;
            fsw.EnableRaisingEvents = true;
            fsw.IncludeSubdirectories = true;
            Console.WriteLine($"Monitorando eventos na pasta {path}");
            Console.WriteLine($"Pressione enter para finalizar....");
            Console.ReadLine();
        }

        private static void onRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Foi criado o arquivo {e.Name}");
        }

        private static void onDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Foi deletado o arquivo {e.Name}");
        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Foi renomeado o arquivo {e.Name}");
        }
    }
}
