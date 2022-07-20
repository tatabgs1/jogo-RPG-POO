namespace jogo_RPG_POO.src.Entities
{
    public class Knight : Hero
    {
            public Knight(string Name, int Level, string HeroType, int HP, int MP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

    public override string Attack(){
            return this.Name + " Atacou com sua Espada";
        }

        public string Attack(int Bonus){

            if (Bonus>3 && Bonus<=5){
            return this.Name + " Atacou com a Espada com bonus de " + Bonus;
            }else if(Bonus>=1 && Bonus<=3){
                return this.Name + " Atacou com a Espada com força fraca com bonus de " + Bonus;
            }else{
                return this.Name + " Atacou com a Espada Poderosa com bonus de " + Bonus;
            }
        }
    }
}