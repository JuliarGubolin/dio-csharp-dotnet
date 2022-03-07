using System;
using System.Collections.Generic;
using System.IO;
using exemplo_poo.Helper;
using exemplo_poo.Interfaces;
using exemplo_poo.Models;

namespace exemplo_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Objeto do tipo Pessoa
            Pessoa p1 = new Pessoa();
            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Apresentar();*/

            /*//Aula - Encapsulamento
            //Valores válidos
            Retangulo r = new Retangulo();
            r.DefinirMedidas(14.5, 2.5);
            double area = r.ObterArea();
            System.Console.WriteLine($"A área deste retângulo é {area}.");
            //Valores inválidos
            System.Console.WriteLine("---------------------");
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0, 2.5);
            double area2 = r2.ObterArea();
            System.Console.WriteLine($"A área deste retângulo é {area2}.");*/

            /*//Aula - Herança
            Aluno a1 = new Aluno();
            a1.Idade = 50;
            a1.Nome = "Alex";
            a1.Nota = 8;
            a1.Apresentar();
            Professor p1 = new Professor();
            p1.Salario = 5.788;*/

            /*//Aula - Polimorfismo
            Aluno a1 = new Aluno();
            a1.Idade = 50;
            a1.Nome = "Alex";
            a1.Nota = 8;
            a1.Apresentar();
            Professor p1 = new Professor();
            p1.Salario = 3.455;
            p1.Nome = "Amanda";
            p1.Apresentar();*/

            /*Aula - Polimorfismo em tempo de compilação
            Calculadora c1 = new Calculadora();
            System.Console.WriteLine($"Resultado primeira soma: {c1.Somar(1, 2)}.");
            System.Console.WriteLine($"Resultado primeira soma: {c1.Somar(1, 2, 3)}.");*/

            /*Corrente c = new Corrente();
            c.Creditar(100);
            c.ExibirSaldo();*/

            /*// Aula Herança System.Object
            Computador pc = new Computador();
            System.Console.WriteLine(pc.ToString());*/

            /*Interface*/
            //Não podemos fazer: ICalculadora calc = new ICalculadora();
            //Podemos também: Calculadora calc = new Calculadora();
            //ICalculadora calc = new Calculadora();
            //System.Console.WriteLine(calc.Somar(3, 4));

            //-----------------------------------
            //Arquivos
            //Caminhos para manipular arquivos/diretórios
            var path = @"C:\Users\gisla\Desktop\trabalhando-arquivos";
            var pathCombine = Path.Combine(path, "pasta-teste-3", "subpasta-teste-3");
            var pathCombineAux = Path.Combine(path, "pasta-teste-1");
            var novoPathArquivo = Path.Combine(path, "pasta-teste-2", "arquivo-teste-stream.txt");
            var pathArquivo = Path.Combine(path, "arquivo-teste-stream.txt");
            var pathArquivoTeste = Path.Combine(path, "arquivo-teste.txt");
            var pathArquivoTesteCopia = Path.Combine(path, "arquivo-teste-backup.txt");
            var listaString = new List<string>{"linha1", "linha2", "linha3"};
            var listaString2 = new List<string>{"linha4", "linha5", "linha6"};

            FileHelper helper = new FileHelper();

            //Como listar diretórios
            //helper.ListarDiretorios(path);

            //Como listar arquivos
            //helper.ListarArquivosDiretorios(path);

            //Como criar diretórios
            //System.Console.WriteLine($"Criando diretório: {pathCombine}");
            //helper.CriarDiretorio(pathCombine);

            //Como deletar diretórios (não vão para a lixeira!!)
            //helper.ApagarDiretorio(pathCombineAux, true);

            //Criar arquivo texto
            //helper.CriarArquivoTexto("Teste de escrita de arquivo", pathArquivo);

            //helper.CriarArquivoTextoStream(pathArquivo, listaString);
            //helper.AdicionarTextoStream(pathArquivo, listaString2);
            //helper.AdicionarTexto(pathArquivo, "Linha 7");

            //helper.LerArquivoStream(pathArquivo);

            //helper.MoverArquivo(pathArquivo, novoPathArquivo, false);

            //helper.CopiarArquivo(pathArquivoTeste, pathArquivoTesteCopia, false);

            helper.DeletarArquivo(pathArquivoTesteCopia);
        }
    }
}
