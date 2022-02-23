namespace exemplo_construtores.Models
{
    public class Aluno : Pessoa
    {
        //Passando os parâmetros da classe filha para a classe mãe
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
        {
            System.Console.WriteLine("Contrutor classe Aluno.");
        }
    }
}