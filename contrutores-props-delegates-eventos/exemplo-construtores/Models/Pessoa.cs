namespace exemplo_construtores.Models
{
    public class Pessoa
    {
        //Propriedades
        // private string nome;
        // private string sobrenome;

        private readonly string nome = "Julia";
        private readonly string sobrenome;

        //Construtores  
        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Contrutor classe Pessoa.");
        }
        public void Apresentar(){
            //Não é válido pois é readonly
            //this.nome = "Teste";
            System.Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}.");
        }
    }
}