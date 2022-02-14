namespace abstraindo_rpg.src.Entities
{
    public abstract class Hero
    {
        //Propriedades
        public string Nome { get; set; }
        public int Level { get; set; }
        public string HeroType {get; set;}

        //Construtor
        public Hero(string Nome, int Level, string HeroType)
        {
            this.Nome = Nome;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Hero(){

        }
        public override string ToString(){
            return $"Nome: {this.Nome}, Lvl: {this.Level}, HeroType: {this.HeroType}";
        }

        public virtual string Attack(){
            return $"{this.Nome} atacou com sua espada.";
        }
    }
}