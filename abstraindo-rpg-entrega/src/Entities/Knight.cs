namespace abstraindo_rpg_entrega.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Nome, int Level, string HeroType, int HP, int Life)
        {
            this.Name = Nome;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.Life = Life;
        }

        public override string Attack(){
            return $"{this.Name} atacou com sua espada e passou por cima do inimigo com seu cavalo!";
        }
    }
}