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

            //Nota de 100
            nota = 100;
            quociente = resto / 100;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");

            //Nota de 50
            nota = 50;
            resto = resto % 100;
            quociente = resto / 50;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            
            //Nota de 20
            nota = 20;
            resto = resto % 50;
            quociente = resto / 20;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            
            //Nota de 10
            nota = 10;
            resto = resto % 20;
            quociente = resto / 10;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");

            //Nota de 5
            nota = 5;
            resto = resto % 10;
            quociente = resto / 5;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");

            //Nota de 2
            nota = 2;
            resto = resto % 5;
            quociente = resto / 2;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");

            //Nota de 1
            nota = 1;
            resto = resto % 2;
            Console.WriteLine($"{resto} nota(s) de R$ {nota},00");
        }
    }
}
