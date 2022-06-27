using System;
using A3.Interfaces;
using Environment = A3.Enums.Environment;

namespace A3.Classes.Animals
{
    public class Frog : IAnimal, IWalkable, ISwimable
    {
        public Frog(string name, int age, double health, double speedRate)
        {}
        public string name;
        public int age;
        public double health;
        public double speedRate;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Health { get => health; set => health = value; }
        public double SpeedRate { get => speedRate; set => speedRate = value; }

        public string EatFood()
        {
            return $"{Name} is a {typeof(Frog).Name} and is eating";
        }

        public string Move(Environment e)
        {
            if(e==Environment.Air)
                return $"{Name} is a {typeof(Frog).Name} and can't move in {Enum.GetName(typeof(A3.Enums.Environment), e)} environment";
            if(e==Environment.Land)
                return $"{Name} is a {typeof(Frog).Name} and is walking";
            else
                return $"{Name} is a {typeof(Frog).Name} and is swimming";
        }

        public string Reproduction(IAnimal i)
        {
            return $"{Name} is a {typeof(Frog).Name} and reproductive with {Name}";
        }

        public string Swim()
        {
            return $"{Name} is a {typeof(Frog).Name} and is swimming";
        }

        public string Walk()
        {
            return $"{Name} is a {typeof(Frog).Name} and is walking";
        }
    }
}