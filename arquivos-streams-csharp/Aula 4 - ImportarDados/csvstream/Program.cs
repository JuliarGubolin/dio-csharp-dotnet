using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace csvstream
{
    /*Projeto para leitura e carregamento dos dados de um arquivo CSV*/
    class Program
    {
        static void CriarCSV(){
            var path = Path.Combine(Environment.CurrentDirectory, "Saida");
            var pessoas = new List<Pessoa>(){
                new Pessoa(){
                    Nome = "José Silva",
                    Email = "js@gmail.com",
                    Telefone = 123456,
                    Nascimento = "14/02/1970"
                },
                new Pessoa(){
                    Nome = "Julia Ana",
                    Email = "ja@gmail.com",
                    Telefone = 19874324,
                    Nascimento = "22/08/1967"
                }
            };
            var di = new DirectoryInfo(path);
            if(!di.Exists){
                di.Create();
                path = Path.Combine(path, "usuarios.csv");
            }
            using var sw = new StreamWriter(path);
            sw.WriteLine("nome,email,telefone,nascimento");
            foreach (var pessoa in pessoas)
            {
                var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
                sw.WriteLine(linha);
            }
            //sw.Flush();
        }
        static void LerCSV(){
            var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "usuarios-exportacao.csv");
            if(File.Exists(path)){
                using var sr = new StreamReader(path);
                //Se sr.ReadLine() for nullo, ele irá ignorar o Split(',')
                //Irá transformar a linha 1 em um array
                var cabecalho = sr.ReadLine()?.Split(',');
                while (true)
                {
                    var registro = sr.ReadLine()?.Split(','); 
                    if (registro == null)
                    {
                        break;
                    }
                    //Para verificar problemas de vírgulas a mais, por exemplo
                    if(cabecalho.Length != registro.Length){
                        Console.WriteLine($"Arquivo fora do padrão.");
                        break;
                    }
                    for (int i = 0; i < registro.Length; i++)
                    {
                        Console.WriteLine($"{cabecalho?[i]}: {registro[i]}");
                    }
                    Console.WriteLine("-----------------");
                }
            }else{
                Console.WriteLine($"{path} não existe!");
            }
        }
        static void Main(string[] args)
        {
            CriarCSV();
            Console.WriteLine("[ENTER] para sair....");
            Console.ReadLine();
        }
        class Pessoa{
            public string Nome {get;set;}
            public string Email {get;set;}
            public int Telefone {get;set;}
            public string Nascimento {get;set;}
        }
    }
}
