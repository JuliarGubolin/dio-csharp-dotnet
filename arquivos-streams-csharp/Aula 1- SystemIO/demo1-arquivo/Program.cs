using System.IO;
using System;

//AULA SOBRE FILE E FILEINFO
namespace demo1_arquivo
{
    class Program
    {
        //AULA1 - VIDEO 2
        static void CriarArquivo(string path){
            try
            {
              var sw = File.CreateText(path);
                sw.WriteLine("Esta é a linha 1 do novo arquivo.");
                sw.WriteLine("Esta é a linha 1 do novo arquivo.");
                sw.WriteLine("Esta é a linha 1 do novo arquivo.");
                sw.Flush();  
            }
            catch 
            {  
                Console.WriteLine("O nome do arquivo é inválido!");
            }
        }
        static string LimparNome(string nome){
            foreach (var caracter in Path.GetInvalidFileNameChars())
            {
                nome = nome.Replace(caracter, '-');
            }
            return nome;
        }
        // --------------------------
        static void Main(string[] args)
        {
            //AULA1 - VIDEO 1 ------------------
            //O caminho do novo arquivo será o diretório atual e seu nome será teste
            //var path = Path.Combine(Environment.CurrentDirectory, "Teste.txt");
            //Configuração opcional: implicit using enable 
            //File.Create(path);
            //var sw = File.CreateText(path);
            //sw.WriteLine("Esta é a linha 1 do novo arquivo.");
            //sw.WriteLine("Esta é a linha 1 do novo arquivo.");
            //sw.WriteLine("Esta é a linha 1 do novo arquivo.");
            //Descarrega o conteúdo (as linhas acima) que está em memória
            //Posso dar este Flush por linha, assim elas serão escritas uma por ves, e não todas juntas
            //sw.Flush();
            //Caso não queria usar o Flush, podemos usar: 
            //using var sw2 = File.CreateText(path);
            // -----------------------

            //AULA1 - VIDEO 2
            Console.WriteLine("Digite o nome do arquivo: ");
            var nome = Console.ReadLine();
            //Para retirar os caracteres inválidos que o usuário pode digitar
            var nomeNovo = LimparNome(nome);
            var path = Path.Combine(Environment.CurrentDirectory, $"{nomeNovo}.txt");
            CriarArquivo(path);
            Console.WriteLine("Digite ENTER para finalizar...");
            Console.ReadLine();
            // -----------------------
            
        }
    }
}
