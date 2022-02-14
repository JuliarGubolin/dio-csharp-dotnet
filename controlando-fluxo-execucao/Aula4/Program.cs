using System;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean condicao = true;
            int valor;
            do{
                Console.WriteLine("Digite um valor, 0 para sair: ");
                valor = int.Parse(Console.ReadLine());
                if(valor == 0){
                    Console.WriteLine("Você saiu da aplicação");
                    break;
                }else{
                    Console.WriteLine("Continue");
                    continue;
                }
            }while(condicao == true);
        }
    }
}
