using System;
//Para não precisar escrever 'console'
using static System.Console;

namespace demos_2
{
    class Program
    {
        static void Demo2Ref(){
            var nomes = new string[]{"Ana", "José", "Maria", "Alice", "Pedro"};
            WriteLine($"A lista de nomes atuais é: {string.Join(", \n", nomes)}");
            WriteLine("Qual nome deseja trocar?: ");
            var nome = ReadLine();
            WriteLine("Qual o nome novo?: ");
            var nomeNovo = ReadLine();
            AlterarNome(nomes, nome, nomeNovo);
            WriteLine($"A lista de nomes alterada é: {string.Join(", \n", nomes)}");
        }
        //Uso do ref no primeiro caso (Demo1)
        static void Demo1Ref(){
            int a=5;
            Adicionar20(ref a);
            WriteLine($"O valor de a é: {a}.");
        }
        static void Adicionar20(ref int a){
            a +=20;
        }
        //Com um reference type, podemos usar "==", senão temos que usar .Equals()
        static void AlterarNome(string[] nomes, string nomeAtual, string nomeNovo){
            for (int i = 0; i < nomes.Length; i++)
            {
                if(nomes[i] == nomeAtual){
                    nomes[i] = nomeNovo;
                }
            }
        }
        // static int LocalizarNome(string[] nomes, string nome){
        //     for (int i = 0; i < nomes.Length; i++)
        //     {
        //         if(nomes[i] == nome){
        //             return i;
        //         }
        //     }
        //     return -1;
        // }
        static ref string LocalizarNome(string[] nomes, string nome){
            for (int i = 0; i < nomes.Length; i++)
            {
                if(nomes[i] == nome){
                    return ref nomes[i];
                }
            }
            throw new Exception("Nome não encontrado");
        }
        static void Main(string[] args)
        {
            var nomes = new string[]{"Ana", "José", "Maria", "Alice", "Pedro"};
            WriteLine($"A lista de nomes atuais é: {string.Join(", \n", nomes)}");

            WriteLine("Qual nome deseja trocar?: ");
            var nome = ReadLine();
            WriteLine("Qual o nome novo?: ");
            var nomeNovo = ReadLine();
            // int indice = LocalizarNome(nomes, nome);
            ref var nomeAchado = ref LocalizarNome(nomes, nome);

            if(!string.IsNullOrWhiteSpace(nomeAchado)){
                nomeAchado = nomeNovo;
                WriteLine($"A lista de nomes alterada é: {string.Join(", \n", nomes)}");
            }else{
                WriteLine("Nome não encontrado.");
            }
        }
    }
}
