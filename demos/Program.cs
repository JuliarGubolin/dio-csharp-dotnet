using System;
using static System.Console;
using System.Collections.Generic;

namespace demos{
    public class Program
    {
        static void Demo6(){
            int[] numeros = new int[]{0, 2, 4, 6, 8};
            Write($"Digite o número que gostaria de encontrar: ");
            var numero = int.Parse(ReadLine());
            var idxEncontrado = EncontrarNumero(numeros, numero);
            if (idxEncontrado > 0)
            {
                Write($"O número digitado está na posição {idxEncontrado}");
            }else{
                Write($"O número digitado não foi encontrado");
            }
        }
        static void Demo5(){
            int[] pares = new int[]{0, 42, 4, 6, 8};
            MudarParaImpar(pares);
            //O array, por ser reference type, altera seus valores sem precisar de retorno
            WriteLine($"Os ímpares {string.Join(",", pares)}");
        }
        static void Demo4(){
            //String é um Reference Type, mas ela atua como Value Type neste caso
            string nome = "Julia";
            TrocarNome(nome, "Roberto");
            WriteLine($"O novo nome é: {nome}");
        }
        static void Demo3(){
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
        static void TrocarNome(string nome, string nomeNovo){
            nome = nomeNovo;
        }
        //Como um vetor age sendo um reference type
        static void MudarParaImpar(int[] pares){
            for(int i=0;i<pares.Length;i++){
                pares[i] = pares[i]+1;
            }
        }
        static int EncontrarNumero(int[] numeros, int numero){
            int i;
            for (i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] == numero){
                    return i;
                }
            }
            return -1;
        }
        static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa){
            foreach (var item in pessoas)
            {
                //Classes ele compara referencias
                 if(item.Nome == pessoa.Nome){
                    return true;
                 }
            }
            return false;
        }
        static bool EncontrarPessoa(List<StructPessoa> spessoas, StructPessoa pessoa){
            foreach (var item in spessoas)
            {
                 if(item.Equals(pessoa)){
                    return true;
                 }
            }
            return false;
        }
        public static void Main(){
            // List<Pessoa> pessoas = new List<Pessoa>(){
            //     new Pessoa(){Nome = "Ricardo"},
            //     new Pessoa(){Nome = "Ana"},
            //     new Pessoa(){Nome = "Hanna"},
            //     new Pessoa(){Nome = "Marcio"},
            //     new Pessoa(){Nome = "José"}
            // };
            // WriteLine("Digite a pessoa para localizar: ");
            // var nome = ReadLine();
            // var pessoa = new Pessoa(){Nome = nome};
            // var encontrado = EncontrarPessoa(pessoas, pessoa);
            // if(encontrado){
            //     WriteLine("Achou");
            // }else{
            //     WriteLine("Não achou");
            // }
            List<StructPessoa> spessoas = new List<StructPessoa>(){
                new StructPessoa(){Nome = "Ricardo"},
                new StructPessoa(){Nome = "Ana"},
                new StructPessoa(){Nome = "Hanna"},
                new StructPessoa(){Nome = "Marcio"},
                new StructPessoa(){Nome = "José"}
            };
            WriteLine("Digite a pessoa para localizar: ");
            var nome = ReadLine();
            var pessoa = new StructPessoa(){Nome = nome};
            var encontrado = EncontrarPessoa(spessoas, pessoa);
            if(encontrado){
                WriteLine("Achou");
            }else{
                 WriteLine("Não achou");
            }

        }
    }
}

