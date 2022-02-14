using System;

//If, else e switch
namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando condicional IF ELSE
            int idade;
            Console.WriteLine("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade < 18)
            {
                Console.WriteLine("Você é menor de idade.");
            }else if(idade >= 18 && idade <= 59)
            {
                Console.WriteLine("Você é maior de idade."); 
            }else{
                Console.WriteLine("Você é idoso");
            }
            //Utilizando condicional SWITCH
            int mes;
            Console.WriteLine("Digite um número do mês: ");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }
        }
    }
}
