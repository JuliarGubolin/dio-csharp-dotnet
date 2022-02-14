using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            Boolean condicao = true;
            int valor;
            while(condicao){
                Console.WriteLine("Digite um valor, 0 para sair: ");
                valor = int.Parse(Console.ReadLine());
                if(valor == 0){
                    Console.WriteLine("Você saiu da aplicação");
                    condicao = false;
                }
            }
            //DO WHILE
            condicao = true;
            do{
                Console.WriteLine("Digite um valor, 0 para sair: ");
                valor = int.Parse(Console.ReadLine());
                if(valor == 0){
                    Console.WriteLine("Você saiu da aplicação");
                    condicao = false;
                }
            }while(condicao);
           //FOR 
            Console.WriteLine("Digite um valor: ");
            valor = int.Parse(Console.ReadLine());
            for(int i=valor;i <= 10; i++){
                Console.WriteLine(i);
            }
            //FOREACH
            int[] lista = {1, 2, 3, 4, 5};
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
