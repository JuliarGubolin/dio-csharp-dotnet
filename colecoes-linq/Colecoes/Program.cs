using System;
using System.Linq;
using Colecoes.Helper;
using System.Collections.Generic;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LINQ
                int[] arrayNumeros = new int[5] {4, 5, 1, 7, 8};
                int[] arrayNumeros2 = new int[10] {4, 5, 1, 7, 8, 100, 34, 19, 4, 100};

                var minimo = arrayNumeros2.Min();
                var maximo = arrayNumeros2.Max();
                var medio = arrayNumeros2.Average();
                var soma = arrayNumeros2.Sum();
                var arrayUnico = arrayNumeros2.Distinct().ToArray();
                System.Console.WriteLine($"Mínimo: {minimo}.\nMédia: {medio}.\nMáximo: {maximo}.\nSoma: {soma}.\nArray Original: {string.Join(", ", arrayNumeros2)}\nArray Distinto: {string.Join(", ", arrayUnico)}");
                /*var numerosParesQuery = 
                    from numero in arrayNumeros
                    where numero % 2 == 0
                    orderby numero
                    select numero;
                //Mesca coisa da query de cima
                var numerosParesMetodo = arrayNumeros.Where(x => x%2==0).OrderBy(x=>x).ToList();

                System.Console.WriteLine("Números pares query: " + string.Join(", ",numerosParesQuery));
                System.Console.WriteLine("Números pares método: " + string.Join(", ",numerosParesMetodo));*/
            #endregion
            #region Dicionários
            // DICIONÁRIOS ---------------------------------------------------------------------
            /*Dictionary<string,string> estados = new Dictionary<string,string>();
            //Não se pode duplicar a chave (SP, MG...)
            estados.Add("SP", "São Paulo");
            estados.Add("MG", "Minas Gerais");
            estados.Add("BA", "Bahia");

            foreach (KeyValuePair<string, string> item in estados)
            {
                System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            //Acessar valor
            string valorProcurado = "SC";
            System.Console.WriteLine(estados[valorProcurado]);

            //Atualizar valor
            System.Console.WriteLine($"Valor original");
            System.Console.WriteLine(estados[valorProcurado]);
            estados[valorProcurado] = "SP - Teste atualização";
            System.Console.WriteLine($"Valor atualizado");
            System.Console.WriteLine(estados[valorProcurado]);

            //Remover um valor
            System.Console.WriteLine($"Removendo o valor {valorProcurado}");
            estados.Remove(valorProcurado);
            foreach (KeyValuePair<string, string> item in estados)
            {
                System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }
            if(estados.TryGetValue(valorProcurado, out string estadoEncontrado)){
                System.Console.WriteLine(estadoEncontrado);
            }else{
                System.Console.WriteLine("Não existe.");
            }*/

            // DICIONÁRIOS ---------------------------------------------------------------------
            #endregion
            #region Pilha
            // PILHA ---------------------------------------------------------------------------
            /*Stack<string> pilhaLivros = new Stack<string>();
            pilhaLivros.Push(".NET");
            pilhaLivros.Push("DDD");
            pilhaLivros.Push("Java");
            pilhaLivros.Push("C++");

            System.Console.WriteLine($"Livros para leitura {pilhaLivros.Count}.");
            while (pilhaLivros.Count>0)
            {
                System.Console.WriteLine($"Próximo livro para leitura {pilhaLivros.Peek()}");
                System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso.");
            }
            System.Console.WriteLine($"Livros para leitura {pilhaLivros.Count}.");*/
            // PILHA --------------------------------------------------------------------------
            #endregion
            #region Fila
            // FILA ---------------------------------------------------------------------------
            /*Queue<string> fila = new Queue<string>();

            //Adiciona um elemento no fim da fila
            fila.Enqueue("Julia");
            fila.Enqueue("Ana");
            fila.Enqueue("Eduardo");

            //Remove o primeiro valor da fila
            //fila.Dequeue();
            System.Console.WriteLine($"Pessoas na fila: {fila.Count}.");
            while (fila.Count > 0)
            {
                //Peek() mostra o próximo da fila (pimeira posição)
                System.Console.WriteLine($"Vez de: {fila.Peek()}");
                System.Console.WriteLine($"{fila.Dequeue()} atendido.");
            }
            System.Console.WriteLine($"Pessoas na fila: {fila.Count}.");*/
            // FILA ---------------------------------------------------------------------------
            #endregion
            #region Lista
            // LISTA---------------------------------------------------------------------------
            /*OperacoesLista opL = new OperacoesLista();
            List<string> estados = new List<string>{"SP", "MG", "BA"};
            string[] estadosArray = new string[2] {"SC", "MT"};

            System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            opL.ImprimirListaString(estados);
            System.Console.WriteLine("------------------");

            //Adiciona um novo elemento em um índice específico
            estados.Insert(1, "RJ");

            //Adiciona os novos elementos da coleção na coleção existente
            //estados.AddRange(estadosArray);
            opL.ImprimirListaString(estados);

            System.Console.WriteLine($"Removendo elemento.");
            estados.Remove("MG");
            opL.ImprimirListaString(estados);
            System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");*/
            // LISTA---------------------------------------------------------------------------
            #endregion
            #region Arrays
            // ARRAY---------------------------------------------------------------------------
            /*OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] {6, 3, 8, 1, 9};
            int[] arrayCopia = new int[10];
            string[] arrayString = op.ConverterParaArrayString(array);

            //int valorProcurado = 2;

            System.Console.WriteLine($"Capacidade atual: {array.Length}");
            op.RedimensionarArray(ref array, array.Length+2);
            System.Console.WriteLine($"Capacidade nova: {array.Length}");


            int indice = op.ObterIndice(array, valorProcurado);
            if(indice == -1){
                System.Console.WriteLine($"Não encontrou.");
            }else{
                System.Console.WriteLine($"Encontrou, {valorProcurado} na posição {indice}.");
            }

            int valorAchado = op.ObterValor(array, valorProcurado);
            if(valorAchado == 0){
                System.Console.WriteLine($"Não encontrou.");
            }else{
                System.Console.WriteLine($"Encontrou.");
            }
            
            bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);
            if(todosMaiorQue){
                System.Console.WriteLine($"Todos os valores são maior que {valorProcurado}.");
            }else{
                System.Console.WriteLine($"Nem todos são maiores que o valor especificado.");
            }
            

            bool existe = op.Existe(array, valorProcurado);
            if(existe){
                System.Console.WriteLine($"Encontrei o valor {valorProcurado}");
            }else{
                System.Console.WriteLine("Não encontrei.");
            }

            //System.Console.WriteLine("Array original: ");
            //op.ImprimirArray(array);

            //System.Console.WriteLine("Array ordenado: ");
            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);

            System.Console.WriteLine("Array antes da cópia: ");
            op.ImprimirArray(arrayCopia);
            op.Copiar(ref array, ref arrayCopia);
            System.Console.WriteLine("Array após a cópia: ");
            op.ImprimirArray(arrayCopia);

            int[] arrayInteiros = new int[3];

            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = int.Parse("30");
            //arrayInteiros[3] = 40;

            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                System.Console.WriteLine($"{i}: {arrayInteiros[i]}.");
            }
            foreach (var i in arrayInteiros)
            {
                System.Console.WriteLine($"{i}.");
            }

            int[,] matriz = new int[4,2]{
                {8,8},
                {10,20},
                {50,100},
                {50, 400}
            };
            //matriz[0,0] = 34;
            //Linha
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                //Coluna
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    System.Console.WriteLine(matriz[i,j]);
                }
            }*/
            // ARRAY---------------------------------------------------------------------------
            #endregion
        }
    }
}
