using System;
// using EstruturaPrograma.Exemplos;
namespace EstruturaPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Em outro namespace: OutroNmespace.Pilha() ou biblioteca acima
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}
