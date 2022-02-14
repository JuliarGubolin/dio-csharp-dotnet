using System;
using abstraindo_rpg.src.Entities;

namespace abstraindo_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hero hero = new Hero("Arus", 12, "Knight");
            // Console.WriteLine(hero.ToString());

            Knight oponnent = new Knight("Maleficus", 99, "Devil");
            Feiticeiro wizard = new Feiticeiro("Jennica", 12, "White Wizard");

            Console.WriteLine(wizard.Attack(1));
        }
    }
}
