using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Listas(){

        }
        static void Main(string[] args)
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
            string[] linhas = new string[totalDeCasosDeTeste];
            string[] aux = new string[10000];
            List<string> lista1 = new List<String>();
            
            for (int i = 0; i < linhas.Length; i++)
            {
                linhas[i] = Console.ReadLine();
            }
            for (int i = 0; i < linhas.Length; i++)
            {
                lista1 = linhas[i].Split(' ').ToList();
                List<string> listaSemDuplicados = lista1.Distinct().ToList();
                listaSemDuplicados.Sort();
                foreach (string item in listaSemDuplicados) {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
                lista1.Clear();
            }
            
        }
    }
}
