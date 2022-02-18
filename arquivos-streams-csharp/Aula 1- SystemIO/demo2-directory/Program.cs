using System;
using System.IO;

namespace demo2_directory
{
    class Program
    {
        
        static void CopiarArquivo(string pathOrigem, string pathDestino){
            if(!File.Exists(pathOrigem)){
                Console.WriteLine("Arquivo de origem não existe.");
                return;
            }
            if(!File.Exists(pathDestino)){
                Console.WriteLine("Arquivo já existe no destino.");
                return;
            }
            File.Copy(pathOrigem, pathDestino);
        }
        //Movendo o arquivo Brasil do diretório atual para dentro da pasta da América do Sul
        static void MoverArquivo(string pathOrigem, string pathDestino){
            if(!File.Exists(pathOrigem)){
                Console.WriteLine("Arquivo de origem não existe.");
                return;
            }
            if(File.Exists(pathDestino)){
                Console.WriteLine("Arquivo já existe no destino.");
                return;
            }
            File.Move(pathOrigem, pathDestino);
        }
        static void CriarArquivo(){
            var path = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
            if(!File.Exists(path)){
                using var sw =  File.CreateText(path);
                sw.WriteLine("População: 213MM");
                sw.WriteLine("IDH: 0.95");
                sw.WriteLine("Dados atualizados em: 20/04/0218");
            }
        }
        static void CriarDirGlobo(){
            //Criando o caminho
            var path = Path.Combine(Environment.CurrentDirectory, "Globo");
            if(!Directory.Exists(path)){
                //Criando o diretório Globo no caminho indicado
                var dirGlobo = Directory.CreateDirectory(path);
                //Criando pastas neste novo diretório
                var dirAN = dirGlobo.CreateSubdirectory("América-do-Norte");
                var dirAC = dirGlobo.CreateSubdirectory("América-Central");
                var dirAS = dirGlobo.CreateSubdirectory("América-do-Sul");

                //Criando pastas nos subdiretórios do Diretório Globo
                dirAN.CreateSubdirectory("USA");
                dirAN.CreateSubdirectory("MEX");
                dirAN.CreateSubdirectory("CAN");

                dirAC.CreateSubdirectory("CostaRica");
                dirAC.CreateSubdirectory("Panamá");

                dirAS.CreateSubdirectory("Brasil");
                dirAS.CreateSubdirectory("Argentina");
                dirAS.CreateSubdirectory("Paraguai");
            }
            
        }
        static void Main(string[] args)
        {
            CriarDirGlobo();
            CriarArquivo();
            var origem = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
            var destino = Path.Combine(Environment.CurrentDirectory, "Globo", "América-do-Sul", "Brasil","Brasil.txt");
            //MoverArquivo(origem, destino);
            CopiarArquivo(origem, destino);
            
        }
    }
}
