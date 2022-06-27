using System;
using A3.Interfaces;
using Environment = A3.Enums.Environment;

namespace A3.Classes.Animals
{
    public class Partridge : IAnimal, IWalkable, IFlyable
    {
        public Partridge(string name, int age, double speedRate, double health)
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
            return $"{Name} is a {typeof(Partridge).Name} and is eating";
        }

        public string Move(Environment e)
        {
            if(e==Environment.Air)
                return $"{Name} is a {typeof(Partridge).Name} and is flying";
            if(e==Environment.Land)
                return $"{Name} is a {typeof(Partridge).Name} and is walking";
            else
                return $"{Name} is a {typeof(Partridge).Name} and can't move in {Enum.GetName(typeof(A3.Enums.Environment), e)} environment";
        }

        public string Reproduction(IAnimal i)
        {
            return $"{Name} is a {typeof(Partridge).Name} and reproductive with {Name}";
        }


        public string Walk()
        {
            return $"{Name} is a {typeof(Partridge).Name} and is walking";
        }

        public string Fly()
        {
            return $"{Name} is a {typeof(Partridge).Name} and is flying";
        }
    }
}