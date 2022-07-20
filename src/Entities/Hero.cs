namespace jogo_RPG_POO.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }


        public Hero(string Name, int Level, string HeroType, int HP, int MP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public Hero (){

        }

        // public string Name;
        // public int Level;
        // public string HeroType;
        

        public override string ToString(){
                return this.Name + " "+ this.Level + " " + this.HeroType + " " + this.HP + " " + this.MP;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada";
        }

    }
}