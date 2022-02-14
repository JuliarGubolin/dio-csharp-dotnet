using System;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int x = 1, i;
            do{
                x = int.Parse(Console.ReadLine());
                if(x != 0){
                    if(x % 2 == 0){
                        soma = x;
                    }else{
                        soma = x + 1;
                        x = x + 1;
                    }
                    for(i = 0; i < 4; i++){
                        x = x + 2;
                        soma = soma + (x);
                    }
                    Console.WriteLine(soma);
                }
          }while(x != 0);
        }
    }
}
