using System;
using abstraindo_rpg_entrega.src.Entities;
using static System.Console;

namespace abstraindo_rpg_entrega
{
    class Program
    {
        static void Main(string[] args)
        {
            //Knight
            Knight knight = new Knight("Elora", 12, "Knight", 34, 66);
            WriteLine(knight.ToString());
            WriteLine(knight.Attack());
            //Warrior
            Warrior warrior = new Warrior("Camilo", 56, "Ladrão", 55, 12);
            WriteLine(warrior.ToString());
            WriteLine(warrior.Attack());
            //Sorcerer
            Sorcerer sorcerer = new Sorcerer("Compiuter", 55, "Amiguinho", 77, 9);
            WriteLine(sorcerer.ToString());
            WriteLine(sorcerer.Attack());
            WriteLine(sorcerer.Attack(19));
        }
    }
}
