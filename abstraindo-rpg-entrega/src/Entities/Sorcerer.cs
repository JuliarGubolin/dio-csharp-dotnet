namespace abstraindo_rpg_entrega.src.Entities
{
    public class Sorcerer : Hero
    {
        public Sorcerer(string Nome, int Level, string HeroType, int HP, int Life)
        {
            this.Name = Nome;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.Life = Life;
        }
        public override string Attack(){
            return $"{this.Name} lançou magia!";
        }
        public string Attack(int bonus){
            if(bonus > 10){
                return $"{this.Name} lançou magia com bônus alto!";
            }else if(bonus > 5 && bonus < 10){
                return $"{this.Name} lançou magia com bônus médio!";
            }else{
                return $"{this.Name} lançou magia com bônus leve!";
            }
            
        }
    }
}