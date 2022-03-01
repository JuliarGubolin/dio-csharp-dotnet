using System;
using exemplo_construtores.Models;

namespace exemplo_construtores
{
    class Program
    {
        //Declarando Delegate
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            //Aula 1
            // Pessoa p1 = new Pessoa("Julia", "Gubolin");
            // p1.Apresentar();
            //Construtor padrão é o contrutor SEM parâmetros
            //Quando você cria um construtor com parâmetros, o construtor padrão não irá valer mais
            // Pessoa p2 = new Pessoa();
            // p2.Apresentar();

            //Aula 2 - construtor privado
            //Construtor privado é comum em projetos
            //Singleton: posso instanciar uma classe UMA UNICA vez, para não prejudicar o projeto
            //Log log = Log.GetInstance();
            //log.PropriedadeLog = "Teste instância";
            //Log log2 = Log.GetInstance();
            //Retorna "Teste instância", já que ela só pode ser instanciada uma vez
            //System.Console.WriteLine(log2.PropriedadeLog);

            //Aula 3
            //Aluno a1 = new Aluno("Julia", "Gubolin", "Matemática");
            //a1.Apresentar();

            //Aula 4 - Get e Set
            //Data data = new Data();
            //data.SetMes(44);
            //data.aleatoria = 4;
            //System.Console.WriteLine(data.mes);
            //data.ApresentarMes();

            //Aula constantes e readonly
            //const double pi = 3.14;
            //System.Console.WriteLine(pi);
            //Erro: pi é uma constante
            //pi=0;

            //Aula Delegates
            //Operacao op = Calculadora.somar;
            //Operacao op = new Operacao(Calculadora.somar);
            //2 maneiras de chamar o somar pelo Delegate
            //op.Invoke(10,10);
            //op(10,10);

            //Multicast Delegate (Para chamada dos métodos, ele segue a regra FIFO)
            //op += Calculadora.subtrair;
            //op.Invoke(10,10);

            //Aula Eventos
            Matematica m = new Matematica(10,20);
            m.Somar();
        }
    }
}
