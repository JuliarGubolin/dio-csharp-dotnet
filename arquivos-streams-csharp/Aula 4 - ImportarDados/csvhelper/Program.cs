using System;
using System.IO;

namespace Projetocsvhelper
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory,"Entrada","produtos.csv");
            var fi = new FileInfo(path);
            if(!fi.Exists){
                throw new FileNotFoundException("Arquivo não existe!");
            }
            using var sr = new StreamReader(fi.FullName);
            var csvConfig = new Csv
        }
    }
}
