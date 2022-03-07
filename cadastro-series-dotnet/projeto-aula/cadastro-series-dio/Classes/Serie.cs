using System;
namespace cadastro_series_dio
{
    public class Serie : EntidadeBase
    {
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private string Diretor {get; set;}
        private bool Excluido { get; set;}
        public Serie(int Id, Genero genero, string titulo, string Descricao, int ano, string Diretor)
        {
           this.Id = Id;
           this.Genero = genero;
           this.Titulo = titulo;
           this.Descricao = Descricao;
           this.Ano = ano;
           this.Diretor =  Diretor;
           this.Excluido = false;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: "+ this.Genero + Environment.NewLine;
            retorno += "Título: "+ this.Titulo+ Environment.NewLine;
            retorno += "Descrição: "+ this.Descricao+ Environment.NewLine;
            retorno += "Ano: "+ this.Ano+ Environment.NewLine;
            retorno += "Diretor: "+ this.Diretor+ Environment.NewLine;
            if(this.Excluido){
                retorno += "Excluído: "+ this.Excluido+ Environment.NewLine;
            }
            return retorno;
        }
        public string RetornaTitulo(){
            return this.Titulo;
        }
        public int RetornaId(){
            return this.Id;
        }
        public int RetornaAno(){
            return this.Ano;
        }
        public bool RetornaExcluido(){
            return this.Excluido;
        }
        public void Excluir(){
            this.Excluido = true;
        }
    }
}