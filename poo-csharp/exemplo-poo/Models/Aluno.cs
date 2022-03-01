using System;
namespace exemplo_poo.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, sou aluno com nota {Nota}.");
        }
    }
}