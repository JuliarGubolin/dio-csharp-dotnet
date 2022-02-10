using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();
            while(opcaoUsuario.ToUpper() != "X"){
                switch(opcaoUsuario){
                    case "1":
                        //TODO: adicionar aluno
                        Console.Write("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.Write("Informe a nota do aluno: ");
                        //Como nota é uam variável numérica, precisamos verificar se
                        //A string recebida pode ser convertida para decimal
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.Nota = nota;
                        }else{
                            throw new ArgumentException("O valor da noa deve ser decimal");
                        }
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;
                    case "2":
                        //TODO: listar alunos
                        foreach(var i in alunos){
                            if(!string.IsNullOrEmpty(i.Nome)){
                                Console.WriteLine($"Aluno: {i.Nome} Nota: {i.Nota}");
                            }
                        }
                        break;
                    case "3":
                        //TODO: calcular média geral
                        decimal media = 0;
                        var nrAlunos = 0;
                        // for(int i=0;i<indiceAluno;i++){
                        //     media = media + alunos[i].Nota;
                        // }
                        // media = media/indiceAluno;
                        for(int i=0;i<alunos.Length;i++){
                            if(!string.IsNullOrEmpty(alunos[i].Nome)){
                                media = media + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }
                        media = media / nrAlunos;
                        ConceitoEnum conceitoGeral;
                        if(media > 0 || media < 2){
                            conceitoGeral = ConceitoEnum.E;
                        }else if(media < 4){
                            conceitoGeral = ConceitoEnum.D;
                        }else if(media < 6){
                            conceitoGeral = ConceitoEnum.C;
                        }else if(media < 6){
                            conceitoGeral = ConceitoEnum.B;
                        }else{
                            conceitoGeral = ConceitoEnum.A;
                        }

                        Console.WriteLine($"Media: {media}, com conceito {conceitoGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }
        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
