using System;

namespace demos_4
{
    class Program
    {
        class Numero{
            public int numero { get; set; }

            public Numero(int numero){
                this.numero = numero;
            }
        }
        static void Main(string[] args)
        {
            int a = 2, b = 2;
            Numero c = new Numero(2);
            Numero d = new Numero(2);
            if(a==b){
                Console.WriteLine("A e B são iguais");
            }else{
                Console.WriteLine("A e B não são iguais");
            }
            if(c.numero==d.numero){
                Console.WriteLine("C e D são iguais");
            }else{
                Console.WriteLine("C e D não são iguais");
            }
        }
    }
}
