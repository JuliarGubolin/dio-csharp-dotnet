using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nota, quociente, resto;
            int[] notas = new int[6];

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            resto = n;

            nota = 100;
            quociente = resto / 100;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % 100;
            Console.WriteLine(resto);
        }
    }
}
