using System;
using System.IO;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;
using System.Collections.Generic;

namespace Projetocsvhelper
{
    class Program
    {
        static void EscreverCSV(){
            var path = Path.Combine(Environment.CurrentDirectory, "Saida");
            var di = new DirectoryInfo(path);
            if (!di.Exists)
            {
                di.Create();
            }
            path = Path.Combine(path, "usuarios.csv");

            var pessoas = new List<Pessoa>(){
                new Pessoa(){
                    Nome = "José Silva",
                    Email = "js@gmail.com",
                    Telefone = 123456,
                },
                new Pessoa(){
                    Nome = "Julia Ana",
                    Email = "ja@gmail.com",
                    Telefone = 19874324,
                }
            };
            using var sw = new StreamWriter(path);
            var csvConfig = new CsvConfiguration(CultureInfo.InstalledUICulture){
                Delimiter = "|"
            };
            using var csvWriter = new CsvWriter(sw,csvConfig);
            csvWriter.WriteRecords(pessoas);
        }
        static void LerCSVComOutroDelimitador(){
            var path = Path.Combine(Environment.CurrentDirectory, "Entrada","livros.csv");
            var fi = new FileInfo(path);
            if (!fi.Exists)
            {
                throw new FileNotFoundException($"O arquivo {path} não existe!");
            }
            using var sr = new StreamReader(fi.FullName);
            //CultureUI
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture){
                Delimiter = ";"
            };
            using var csvReader = new CsvReader(sr,csvConfig);
            //Formatação dos arquivos
            csvReader.Context.RegisterClassMap<LivroMap>();
            //Recebe todos os registros
            var registros = csvReader.GetRecords<Livro>();
            foreach (var registro in registros)
            {
                Console.WriteLine($"Nome: {registro.Titulo}");
                Console.WriteLine($"Marca: {registro.Preco}");
                Console.WriteLine($"Preço: {registro.Autor}");
                Console.WriteLine($"Lançamento: {registro.Lancamento}");
                Console.WriteLine($"-------------------");
            }
        }
        static void LerCSVcomClasse(){
            var path = Path.Combine(Environment.CurrentDirectory, "Entrada","novos-usuarios.csv");
            var fi = new FileInfo(path);
            if (!fi.Exists)
            {
                throw new FileNotFoundException($"O arquivo {path} não existe!");
            }
            using var sr = new StreamReader(fi.FullName);
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
            using var csvReader = new CsvReader(sr,csvConfig);

            //Recebe todos os registros
            var registros = csvReader.GetRecords<Usuario>();
            foreach (var registro in registros)
            {
                Console.WriteLine($"Nome: {registro.Nome}");
                Console.WriteLine($"Marca: {registro.Email}");
                Console.WriteLine($"Preço: {registro.Telefone}");
                Console.WriteLine($"-------------------");
            }
        }
        static void LerCSVDynamic(){
            var path = Path.Combine(Environment.CurrentDirectory, "Entrada","produtos.csv");
            var fi = new FileInfo(path);
            if (!fi.Exists)
            {
                throw new FileNotFoundException($"O arquivo {path} não existe!");
            }
            using var sr = new StreamReader(fi.FullName);
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
            using var csvReader = new CsvReader(sr,csvConfig);

            //Recebe todos os registros
            var registros = csvReader.GetRecords<dynamic>();
            foreach (var registro in registros)
            {
                Console.WriteLine($"Nome: {registro.produto}");
                Console.WriteLine($"Marca: {registro.marca}");
                Console.WriteLine($"Preço: {registro.preco}");
                Console.WriteLine($"-------------------");
            }
        }
        static void Main(string[] args)
        {
            //LerCSVcomClasse();
            //LerCSVComOutroDelimitador();
            EscreverCSV();
        }
    }
}
