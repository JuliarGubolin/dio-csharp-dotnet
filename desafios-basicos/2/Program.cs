using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, area;
            string[] valor = Console.ReadLine().Split();
            a = double.Parse(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);
            System.Console.WriteLine(a);
            if(((Math.Abs(b-c) < a) && (a < (b + c))) && ((Math.Abs(a-c) < b) && (b < (a+c))) && ((Math.Abs(a-b) < c)&& (c < (a+b))))
            {
                area = a+b+c;
                System.Console.WriteLine($"Perimetro = {area}");
            }else{
                area = ((a+b)*c)/2;
                System.Console.WriteLine($"Area = {area}");
            }
            
        }
    }
}
