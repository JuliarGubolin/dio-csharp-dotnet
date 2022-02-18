using System;
using System.IO;

namespace demo3_directoryInfo
{
    class Program
    {
        static void LerArquivos(string path){
            // '*.doc'
            var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (var arquivo in arquivos)
            {
                var fileInfo = new FileInfo(arquivo);
                Console.WriteLine($"[Nome]: {fileInfo.Name}");
                Console.WriteLine($"[Tamanho]: {fileInfo.Length}");
                Console.WriteLine($"[Último acesso]: {fileInfo.LastAccessTime}");
                Console.WriteLine($"[Pasta]: {fileInfo.DirectoryName}");
                Console.WriteLine($"---------------");
            }
        }
        static void LerDiretorios(string path){
            if(Directory.Exists(path)){
                // '*' indica que quero tudo. Se eu quiser só o que começa com p, escrevo 'p*'
                var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
                foreach (var dir in diretorios)
                {
                    //DirectoryInfo me trás as informações sobre o diretório
                    var dirInfo = new DirectoryInfo(dir);
                    Console.WriteLine($"[Nome]: {dirInfo.Name}");
                    Console.WriteLine($"[Raiz]: {dirInfo.Root}");
                    //? na classe indica que ela pode ser nula
                    if(dirInfo.Parent != null){
                        Console.WriteLine($"[Pai]: {dirInfo.Parent.Name}");
                    }
                    Console.WriteLine($"-------------------");
                }
            }else{
                Console.WriteLine($"{path} não existe.");
            }
            
        }
        static void Main(string[] args)
        {
            // O @ serve para que o C# aceite \
            var path = @"D:\workspace\dio-csharp-dotnet\arquivos-streams-csharp\Aula 1- SystemIO\demo2-directory\Globo";
            //var path = Path.Combine(Environment.CurrentDirectory,"Globo");
            //LerDiretorios(path);
            LerArquivos(path);
            Console.WriteLine("Digite enter para finalizar....");
            Console.ReadLine();
            
        }
    }
}
