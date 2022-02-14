namespace abstraindo_rpg_entrega.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType {get; set;}
        public int HP { get; set; }
        public int Life  { get; set; }

        //Construtor
        public Hero(string Nome, int Level, string HeroType, int HP, int Life)
        {
            this.Name = Nome;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.Life = Life;
        }
        public Hero(){

        }
        public override string ToString(){
            return $"Name: {this.Name}, Lvl: {this.Level}, HeroType: {this.HeroType}, HP: {this.HP}, Life: {this.Life}.";
        }

        public virtual string Attack(){
            return $"{this.Name} atacou com sua espada.";
        }
    }
}