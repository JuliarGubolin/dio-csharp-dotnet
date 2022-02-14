namespace abstraindo_rpg.src.Entities
{
    public class Feiticeiro : Hero
    {
        public Feiticeiro(string Nome, int Level, string HeroType)
        {
            this.Nome = Nome;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return $"{this.Nome} lançou magia.";
        }

        public string Attack(int Bonus){
            if(Bonus > 6){
                return $"{this.Nome} lançou magia super efetiva com bonus de ataque {Bonus}.";
            }else{
                return $"{this.Nome} lançou magia com bonus de ataque {Bonus}.";
            }
        }
    }
}