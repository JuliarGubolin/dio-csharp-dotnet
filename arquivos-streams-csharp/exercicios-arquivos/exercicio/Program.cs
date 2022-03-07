using System;
using System.IO;
using exercicio.Model;

namespace exercicio
{
    class Program
    {
       static void AdicionarTextoStream(MesDados[] conteudo)
       {
           var pathSaida = Path.Combine(Environment.CurrentDirectory, "medias.dat");
            if(!File.Exists(pathSaida)){
                File.Create(pathSaida).Dispose();
            }
            using(var stream = new StreamWriter(pathSaida)){
                for (int i = 0; i < conteudo.Length; i++)
                {
                    stream.WriteLine($"{conteudo[i].mes} {conteudo[i].minima} () {conteudo[i].media} () {conteudo[i].maxima}");
                }
            }
         }

        static int ObterIdade(string datanascimento)
        {
            var data = datanascimento.Split('/');
            DateTime hoje = DateTime.Today;

            var dataHoje = hoje.ToString("d").Split('/');
            System.Console.WriteLine($"{dataHoje.ToString()}");

            int anoNasc = int.Parse(data[2]);
            int anoAtual = int.Parse(dataHoje[2]);
            System.Console.WriteLine($"{anoNasc}, {anoAtual}, {dataHoje[1]}, {data[1]},");
            int ano = anoAtual-anoNasc;
            if(int.Parse(dataHoje[1]) >= int.Parse(data[1])){
                if(int.Parse(dataHoje[0]) >= int.Parse(data[0])){
                    ano = ano+1;
                }
            }else{
                ano = ano-1;
            }
            return ano;
        }
        static void Main(string[] args)
        {

            int idade = ObterIdade("30/08/1970");
            System.Console.WriteLine(idade);
            /*int mes=0, qtd=0, i;
            double minima=0.0, media=0.0, maxima=0.0;
            MesDados[] meses = new MesDados[12];
            var pathEntrada = Path.Combine(Environment.CurrentDirectory, "temps.dat");
            if(!File.Exists(pathEntrada)){
                Console.WriteLine("Arquivo de entrada temps.dat não existe!");
            }else{
                using var sr = new StreamReader(pathEntrada);
                var registro = sr.ReadLine()?.Split(' ');
                while ((registro) != null)
                {
                    mes = Convert.ToInt32(registro[1]);
                    minima = Convert.ToDouble(registro[2]);
                    media = Convert.ToDouble(registro[3]);
                    maxima = double.Parse(registro[4]);
                    MesDados aux = new MesDados(mes, minima, media, maxima, qtd);
                    meses[mes-1] = aux;
                    meses[mes-1].qtdVezes = meses[mes-1].qtdVezes + 1;
                    System.Console.WriteLine(meses[mes-1].qtdVezes);
                    meses[mes-1].media = meses[mes-1].media + media;
                    meses[mes-1].maxima = meses[mes-1].maxima + maxima;
                    meses[mes-1].minima = meses[mes-1].minima + minima;
                    registro = sr.ReadLine()?.Split(' ');
                }
                for (i=0; i<meses.Length; i++)
                {
                    meses[i].maxima = (meses[i].maxima)/meses[i].qtdVezes;
                    meses[i].minima = (meses[i].minima)/meses[i].qtdVezes;
                    meses[i].media = (meses[i].media)/meses[i].qtdVezes;
                }
                AdicionarTextoStream(meses);*/
            }
        }
}
