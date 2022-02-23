using System;
using System.IO;
using System.Text;

namespace string_writer
{
    class Program
    {
        /*Função do projeto: remover os enters do texto original e depois colocá-los denovo.*/
        static void Main(string[] args)
        {
            string textReaderText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque id magna leo. Nam dictum eros id est mollis aliquam. Mauris id leo accumsan mi ultrices luctus "+
            
             "Pellentesque non nisl vitae justo scelerisque dignissim. Vivamus a nunc elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit.\n\n"+

             "Donec sit amet turpis et enim maximus accumsan ac eget lacus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia "+ 

             "curae; Quisque fermentum tortor elit, et finibus sem pulvinar mattis. Praesent facilisis semper nisi, vel lacinia magna fermentum nec. In pretium iaculis orci, at iaculis justo sollicitudin tincidunt.\n\n";

            Console.WriteLine("Texto original: "+ textReaderText);
            string linha, paragrafo = null;
            var sr = new StringReader(textReaderText);
            while(true){
                //Leio uma linha
                linha = sr.ReadLine();
                //Se eu conseguir lê-la sem problemas
                if(linha != null){
                    //Eu concateno elas em parágrafos
                    paragrafo += linha + " ";
                }else{
                    //Se eu não conseguir, eu finalizo o parágrafo
                    paragrafo += '\n';
                    break;
                }
            }
            Console.Write($"texto modificado: {paragrafo}");
            int caractereLido;
            char caracterConvertido;
            var sw = new StringWriter();
            sr = new StringReader(paragrafo);
            while (true)
            {
                //Recebe um decimal da tabela ASC (0 a 255)
                caractereLido = sr.Read();
                //Indica fim da string lida (fim de arquivo)
                if(caractereLido == -1){
                    break;
                }
                //Interpreta o decimal e converte ele para um caractere correspondente na tabela ASC
                caracterConvertido = Convert.ToChar(caractereLido);
                if(caracterConvertido == '.'){
                    sw.Write("\n\n");
                    sr.Read();
                    sr.Read();
                //Se o caractere lido não foi um '.'
                }else{
                    sw.Write(caracterConvertido);
                }
            }
            Console.WriteLine($"Texto armazenado no StringWriter: {sw.ToString()}");
            Console.WriteLine($"Digite [ENTER] para finalizar....");
            Console.ReadLine();
        }
    }
}
