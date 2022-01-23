namespace DioRpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name,int Level,string CharactresType)
        {
            this.Name = Name;
            this.Level = Level;
            this.CharactresType = CharactresType;
        }
        
        public override string Power(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + ": attacked with full force. " + "Attack force: " + Bonus;
            }
            else if(Bonus < 4)
            {
                return this.Name + ": no effcet attack. " + "Attack force: " + Bonus;    
            }
            else
            {
                return this.Name + ": Attack failed. " + "Attack force: " + Bonus;
            }
           
        }
    }     
}    
