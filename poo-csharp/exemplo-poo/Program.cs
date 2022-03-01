using System;
using exemplo_poo.Models;

namespace exemplo_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Objeto do tipo Pessoa
            Pessoa p1 = new Pessoa();
            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Apresentar();*/

            /*//Aula - Encapsulamento
            //Valores válidos
            Retangulo r = new Retangulo();
            r.DefinirMedidas(14.5, 2.5);
            double area = r.ObterArea();
            System.Console.WriteLine($"A área deste retângulo é {area}.");
            //Valores inválidos
            System.Console.WriteLine("---------------------");
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0, 2.5);
            double area2 = r2.ObterArea();
            System.Console.WriteLine($"A área deste retângulo é {area2}.");*/

            /*//Aula - Herança
            Aluno a1 = new Aluno();
            a1.Idade = 50;
            a1.Nome = "Alex";
            a1.Nota = 8;
            a1.Apresentar();
            Professor p1 = new Professor();
            p1.Salario = 5.788;*/

            /*//Aula - Polimorfismo
            Aluno a1 = new Aluno();
            a1.Idade = 50;
            a1.Nome = "Alex";
            a1.Nota = 8;
            a1.Apresentar();
            Professor p1 = new Professor();
            p1.Salario = 3.455;
            p1.Nome = "Amanda";
            p1.Apresentar();*/

            /*Aula - Polimorfismo em tempo de compilação
            Calculadora c1 = new Calculadora();
            System.Console.WriteLine($"Resultado primeira soma: {c1.Somar(1, 2)}.");
            System.Console.WriteLine($"Resultado primeira soma: {c1.Somar(1, 2, 3)}.");*/

            Corrente c = new Corrente();
            c.Creditar(100);
            c.ExibirSaldo();
        }
    }
}
