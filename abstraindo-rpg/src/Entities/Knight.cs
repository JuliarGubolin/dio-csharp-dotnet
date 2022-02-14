namespace abstraindo_rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Nome, int Level, string HeroType)
        {
            this.Nome = Nome;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}