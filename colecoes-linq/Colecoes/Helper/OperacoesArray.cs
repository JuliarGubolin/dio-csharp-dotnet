using System;

namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        public string[] ConverterParaArrayString(int[] array){
            return Array.ConvertAll(array, elemento => elemento.ToString());
        } 
        public void RedimensionarArray(ref int[] array, int novoTam){
            Array.Resize(ref array, novoTam);
        }
        public int ObterIndice(int[] array, int valor){
            return Array.IndexOf(array, valor);
        }
        public int ObterValor(int[] array, int valor){
            return Array.Find(array, element => element == valor);
        }
        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }
        public bool Existe(int[] array, int valor){
            //Posso trocar o == por >=
            return Array.Exists(array, elemento => elemento >= valor);
        }
        public void Copiar(ref int[] array, ref int[] arrayDestino){
                                            //Indica que quero copiar todo o conteúdo
            Array.Copy(array, arrayDestino, array.Length);
        }
        public void Ordenar(ref int[] array){
            Array.Sort(array);
        }
        public void OrdenarBubbleSort(ref int[] array){
            int temp=0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if(array[j] > array[j+1]){
                        temp = array[j+1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array){
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
            }
        }
    }
}