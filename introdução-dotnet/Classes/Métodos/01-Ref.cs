using System;

namespace Classes.Métodos
{
    public class Ref
    {
        //Parecido com os ponteiros
        static void Inverter(int x, int y){
            int temp=x;
            x=y;
            y=temp;
        }
        public static void Inverter(){
            int i=1, j=2;
            Inverter(i, j);
            System.Console.WriteLine($"{i} {j}");
        }
    }
}
