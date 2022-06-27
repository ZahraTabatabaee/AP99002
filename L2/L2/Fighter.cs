using System ;
 
namespace L2
{
    public class Fighter
    {
        public string Name ;
        public int Health ;
        public event Action<Fighter,Fighter> GameOver ;
        public Fighter(string name , int Health)
        {
            Name = name ;
            this.Health = Health ;
        }
        public void attack(Fighter f)
        {
            Random random = new Random();
            int defence = random.Next(0,1);
            if(defence == 0)
            {
                int reduce = random.Next(1,10);
                Health -= reduce;
            }
            if(Health<=0)
            {
                GameOver(f,this);
                Environment.Exit(0);
            }
        }
        
    }
}