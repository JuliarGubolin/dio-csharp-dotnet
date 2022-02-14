using System;
using static System.Console;

namespace demos_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Ricardo";
            p1.Idade = 30;
            // Endereco end = new Endereco();
            // end.CEP = "13045-789";
            // end.Cidade = "SP";
            // end.Logradouro = "Rua XYZ";
            // end.Numero = 6;
            // p1.endereco = end;
            p1.endereco = new Endereco(){
                Logradouro = "Rua teste",
                CEP = "00000",
                Numero = 400,
                Cidade = "São Paulo"
            };
            WriteLine("FIM");
        }
    }
}
