using System;

namespace cadastro_series_dio
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcao = MenuOpcoes();
            while(opcao.ToUpper() != "X"){
                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        ListarSeries();
                        break;
                    case "2":
                        Console.Clear();
                        InserirSerie();
                        break;
                    case "3":
                        Console.Clear();
                        AtualizarSerie();
                        break;
                    case "4":
                        Console.Clear();
                        ExcluirSerie();
                        break;
                    case "5":
                        Console.Clear();
                        VisualizarSerie();
                        break;
                    case "X":
                        Console.Clear();
                        System.Console.WriteLine("Aplicação finalizada.");
                        break;
                    default:
                        Console.Clear();
                        throw new ArgumentOutOfRangeException("Indique um valor válido!");
                }
                opcao = MenuOpcoes();
            }
        }

        private static void VisualizarSerie(){
            Console.WriteLine("Opção 5 - Visualizar série");
            Console.Write("Digite o id da série a ser visualizada: ");
			int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.RetornarPorId(indiceSerie);  
            Console.WriteLine(serie);
        }

        private static void ExcluirSerie(){
            Console.WriteLine("Opção 4 - Excluir série");
            Console.Write("Digite o id da série a ser excluída: ");
			int indiceSerie = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tem certeza que deseja excluir a série de índice {indiceSerie} <S><N>?");
            string opcao = Console.ReadLine().ToUpper();
                switch (opcao)
                {
                    case "S":
                        Console.Write("Série excluída.");
                        repositorio.Exclui(indiceSerie);
                        break;
                    case "N":
                        break;
                    default:
                        Console.Clear();
                        throw new ArgumentOutOfRangeException("Indique um valor válido!");
                }
        }

        private static void AtualizarSerie(){
            Console.WriteLine("Opção 3 - Atualzar série");
            Console.Write("Digite o id da série a ser atualizada: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			Console.Write("Digite o gênero entre as opções abaixo: ");
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("-> ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

            Console.Write("Digite o nome do Diretor da Série: ");
			string entradaDiretor = Console.ReadLine();

			Serie atualizaSerie = new Serie(Id: indiceSerie, genero: (Genero)entradaGenero,
				titulo: entradaTitulo, Descricao: entradaDescricao, ano: entradaAno, Diretor: entradaDiretor);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
        }
        private static void InserirSerie(){
            Console.WriteLine("Opção 2 - Inserir série");

            Console.Write("Digite o gênero entre as opções abaixo: ");
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("-> ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

            Console.Write("Digite o nome do Diretor da Série: ");
			string entradaDiretor = Console.ReadLine();

			Serie novaSerie = new Serie(Id: repositorio.ProximoId(), genero: (Genero)entradaGenero,
				titulo: entradaTitulo, Descricao: entradaDescricao, ano: entradaAno, Diretor: entradaDiretor);

			repositorio.Insere(novaSerie);
        }
        private static void ListarSeries(){
            Console.WriteLine("Opção 1 - Listar séries");
            var lista = repositorio.Lista();
            if(lista.Count == 0){
                System.Console.WriteLine("Não existem séries na lista!");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.RetornaExcluido();
                if(!excluido){
                    System.Console.WriteLine($"{serie.RetornaId()} - {serie.RetornaTitulo()}, {serie.RetornaAno()}.");
                }else{
                    System.Console.WriteLine($"EXCLUÍDA: {serie.RetornaId()} - {serie.RetornaTitulo()}, {serie.RetornaAno()}.");
                }
            }
        }
        private static string MenuOpcoes(){
            Console.WriteLine();
            Console.WriteLine("Bem-vindo(a) ao prograna lista de séries!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1) Listar séries");
            Console.WriteLine("2) Inserir série");
            Console.WriteLine("3) Atualizar série");
            Console.WriteLine("4) Excluir série");
            Console.WriteLine("5) Visualizar série");
            Console.WriteLine("X) Sair");
            Console.WriteLine("-----------------------------");
            Console.Write("-> ");
            string opcao = Console.ReadLine().ToUpper();
            return opcao;
        }
    }
}
