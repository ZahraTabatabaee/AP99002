using A3.Enums;

namespace A3.Interfaces
{
    public interface IAnimal
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public double Health {get; set;}
        public string EatFood();
        public string Reproduction(IAnimal i);
        public string Move(Environment e);
        
    }
}