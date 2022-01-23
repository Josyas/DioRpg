namespace DioRpg.src.Entities
{
    public  class Hero
    {
        public Hero(string Name,int Level,string CharactresType)
        {
            this.Name = Name;
            this.Level = Level;
            this.CharactresType = CharactresType;
        }
        public Hero()
        {
        }
        
        public string Name;
        public int Level;
        public string  CharactresType;

        public override string ToString()
        {
            return this.Name + " "  +                  
                   this.Level + " " +
                   this.CharactresType + " ";
        }

        public virtual string Power(int v)
        {
            return this.Name + " attacked with his arrow.";
        }
    }
}