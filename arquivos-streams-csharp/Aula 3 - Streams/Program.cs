using System;
using System.IO;
//StringBuilder
using System.Text;

namespace Aula_3___Streams
{
    /*
    Aprender a manipular arquivos e pastas
    Como navegar pela estrutura de pastas
    Modificar, criar e salvar arquivos
    Importação de dados e arquivos CSV
    - FileInfo: mover, criar, deletar, renomear, copiar e abrir. Podemos alterar permissões
    - DirectoryInfo: mover, criar, deletar, renomear, copiar e abrir. Podemos alterar permissões e temos também algumas propriedades
    */
    class Program
    {
        static void Main(string[] args)
        {
            //Escrita em arquivos
            var sb = new StringBuilder();
            sb.AppendLine("Caracteres na primeira linha para ler");
            sb.AppendLine("e a segunda linha");
            sb.AppendLine("e fim");

            //Leitura em arquivos
            using var sr = new StringReader(sb.ToString());
            //Leitura do texto inteiro
            //var texto = sr.ReadToEnd();
            //Leitura de um paragrafo
            //var texto = sr.ReadLine();
            //var texto = sr.Read();
            //10 caracteres do texto
            var buffer = new char[10];
            var tamanho = 0;
            do{
                buffer = new char[10];
                tamanho = sr.Read(buffer);
                Console.WriteLine($"{string.Join("", buffer)}");
            }while(tamanho >= buffer.Length);
            do{
                Console.WriteLine(sr.ReadLine());
            }while(sr.Peek() >= 0);
            Console.WriteLine($"aperte enter para finalizar");
            Console.ReadLine();
        }
    }
}
