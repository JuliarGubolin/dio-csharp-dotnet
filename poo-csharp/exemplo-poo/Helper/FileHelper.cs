using System.Collections.Generic;
using System.IO;

namespace exemplo_poo.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            //Busca todos os diretórios dentro do raíz
            var retornoCaminho = Directory.GetDirectories(caminho, "*",SearchOption.AllDirectories);
            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void ListarArquivosDiretorios(string caminho){
            //"*" - Filtro que significa que queremos trazer tudo
            //"*.txt" - Todos os arquivos do tipo .txt apenas
            //"*2.txt" - Todos os arquivos do tipo .txt e que possuiem 2 ao final do nome
            //"*2*" - Todos os arquivos  que tem um 2 no nome, não importando o que vem antes ou depois
            var retornoArquivos = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories);
            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void CriarDiretorio(string caminho){
            DirectoryInfo di = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(di.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivos){
            //Não é possível apagar diretórios com arquivos, apenas se adicionar o booleano a função
            Directory.Delete(caminho, apagarArquivos);
        }
        //WriteAllText: Sobrescreve o que está no arquivo
        public void CriarArquivoTexto(string conteudo, string caminho){
            if(!File.Exists(caminho)){
                File.WriteAllText(caminho, conteudo);
            }
        }
        //Stream não escreve tudo de uma vez
        public void CriarArquivoTextoStream(string caminho, List<string> conteudo){
            //Using: garante que arquivo seja liberado
            using(var stream = File.CreateText(caminho)){
                foreach (var linha in conteudo)
                {
                    //Stream é bom para arquivos maiores
                    stream.WriteLine(linha);
                }
            }
        }
        //Adiciona texto sem stream
        public void AdicionarTexto(string caminho, string conteudo){
            File.AppendAllText(caminho, conteudo);
        }
        //Adiciona texto com stream
        public void AdicionarTextoStream(string caminho, List<string> conteudo){
            //Using: garante que arquivo seja liberado
            using(var stream = File.AppendText(caminho)){
                foreach (var linha in conteudo)
                {
                    //Stream é bom para arquivos maiores
                    stream.WriteLine(linha);
                }
            }
        }

        public void LerArquivo(string caminho){
            //ReadAllLines retorna um array de strings com o conteúdo lido
            var conteudo = File.ReadAllLines(caminho);
            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }
        public void LerArquivoStream(string caminho){
            string linha = string.Empty;
            using(var stream = File.OpenText(caminho)){
                while ((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }

        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever){
            File.Move(caminho,  novoCaminho, sobrescrever);
        }

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever){
            //Se o novo local já possuir um arquivo com este mesmo nome, ele não irá sobrescrever
            //A não ser que você coloque "true" como terceiro parâmetro
            File.Copy(caminho, novoCaminho, sobrescrever);
        }

        public void DeletarArquivo(string caminho){
            File.Delete(caminho);
        }
    }
}