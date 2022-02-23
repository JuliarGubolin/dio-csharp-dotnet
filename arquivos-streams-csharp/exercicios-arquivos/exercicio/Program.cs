using System;
using System.IO;
using System.Collections.Generic;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mes> meses = new List<Mes>();
            var pathEntrada = Path.Combine(Environment.CurrentDirectory, "temps.dat");
            //var pathSaida = Path.Combine(Environment.CurrentDirectory, "medias.dat");
            if(!File.Exists(pathEntrada)){
                Console.WriteLine("Arquivo de entrada temps.dat não existe!");
            }else{
                var sr = new StreamReader(pathEntrada);
                string arquivo = sr.ReadToEnd();
                sr.Close();
                var BooksFromCsv = from row in File.ReadLines(pathEntrada).Where(arg => !string.IsNullOrWhiteSpace(arg) && arg.Length > 0).AsEnumerable()
                   let column = row.Split(';')
                   select new Book
                   {
                      Name = column[0],
                      Pages = column[1],
                      AuthorName = column[2],
                   };
            }

        }
    }
}
