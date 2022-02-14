namespace abstraindo_rpg_entrega.src.Entities
{
    public class Warrior : Hero
    {
        public Warrior(string Nome, int Level, string HeroType, int HP, int Life)
        {
            this.Name = Nome;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.Life = Life;
        }
        public override string Attack(){
            return $"{this.Name} atacou com sua espada e defendeu com seu escudo!";
        }
    }
}