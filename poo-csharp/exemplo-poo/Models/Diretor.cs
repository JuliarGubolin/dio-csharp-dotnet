using System;
namespace exemplo_poo.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar(){
            Console.WriteLine($"Olá, sou diretor.");
        }
    }
}