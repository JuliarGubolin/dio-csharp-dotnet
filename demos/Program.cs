using System;
using static System.Console;

namespace demos{
    public class Program
    {
        static void Demo2(){
             Pessoa p1= new Pessoa();
            p1.Nome = "Julia";
            p1.Idade = 20;
            p1.Documento = "1234";

            //*Neste caso, P1 e P2 serão José, já que são referências
            //Independente desta ação estar na frente da chamada da função
            Pessoa p2 = p1;

            //Para resolver este problema*: 
            Pessoa p3 = new Pessoa();
            // //Para copiar neste caso como referencia
            //Função em Pessoa para reduzir este código
            Pessoa p4 = p1.Clone();
            // p3.Documento = p1.Documento;
            // p3.Nome = p1.Nome;
            // p3.Idade = p1.Idade;

            TrocarNome(p1, "Roberta");
            
            WriteLine($@"
            O nome de P1 é: {p1.Nome}.
            O nome de P2 é: {p2.Nome}.
            O nome de P3 é: {p3.Nome}.
            ");
        }
        //------------------------------------------
        //Percebemos que, se não retornarmos 'a' da função, não receberemos ele na main
        //pois ele é um tipo valor
        static int Adicionar20(int a){
            return a + 20;
            // static void Adicionar20(int a){
            //     a = a + 20;
            // }
        }
        static void Demo1(){
            int a = 2;
            a = Adicionar20(a);
            //Com o using acima, conseguimos printar sem digitar console
            WriteLine($"O valor da variável a é: {a}.");
        }
        //------------------------------------------
        //Neste caso, ocorre uma cópia da referência para a função TrocaNome()
        //Com isso, ocorre a mudança direta do dado do nome, já que a Classe é um 'reference type'
        //Garabage Colector: mata os dados da heap quando não há referência a ela na Stack
        static void TrocarNome(Pessoa p1, string nome){
            p1.Nome = nome;
        }
        static void TrocarNome(StructPessoa p1, string nome){
            p1.Nome = nome;
        }
        public static void Main(){

            //Como struct não é por referencia, não preciso usar o new
           StructPessoa p1 = new StructPessoa(){
               Documento = "1234",
               Idade = 30,
               Nome = "Ricardo"
           };

           var p2 = p1;

           TrocarNome(p1, "João");
            //Neste caso não muda pq struct não é por referencia
            //Então a função deveria retornar p1
           WriteLine($"Nome p1: {p1.Nome} Nome p2: {p2.Nome}");
        }
    }
}
