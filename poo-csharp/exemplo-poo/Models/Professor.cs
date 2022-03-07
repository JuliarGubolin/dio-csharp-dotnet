using System;
namespace exemplo_poo.Models
{
    public /*sealed*/ class Professor : Pessoa
    {
        public double Salario { get; set; }

        public /*sealed*/ override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, sou professor com um salário de {Salario} reais.");
        }
    }
}