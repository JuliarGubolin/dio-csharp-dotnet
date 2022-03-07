using System;
using tratamento_exceçoes.Models;

namespace tratamento_exceçoes
{
    class Program
    {
        static double Dividir(int x, int y){
            if(y == 0){
                //throw new DivideByZeroException();
                throw new MyClassException("Minha mensagem customizada de erro!");
            }
            return x/y;
        }
        static void Main(string[] args)
        {
            int a=100, b=0;
            double resultado = 0;
            try
            {
                resultado = Dividir(a, b);
            }
            catch(DivideByZeroException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                throw;
            }
            finally{
                System.Console.WriteLine($"Dividindo {a}/{b} = {resultado}."); 
            }
        }
    }
    
}
