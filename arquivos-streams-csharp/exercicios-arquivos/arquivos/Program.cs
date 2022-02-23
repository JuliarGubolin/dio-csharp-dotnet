using System;
using System.IO;
using System.Text;

namespace arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter sobrescreve o arquivo
            var caminho = Path.Combine(Environment.CurrentDirectory, "meutexto.txt");
            using var sw = new StreamWriter(caminho);
            sw.WriteLine("Testando escrita em arquivos texto.");
            sw.WriteLine("Jaja vamos ler");
            sw.Close();

            using var sr = new StreamReader(caminho);
            string dados;
            while ((dados = sr.ReadLine()) != null)
            {
                Console.WriteLine(dados);
            }
            sr.Close();
            // using var sw = File.AppendText(caminho);
            // sw.WriteLine("Linha nova");
            // System.Diagnostics.Process.Start("notepad.exe", caminho);
        }
    }
}
