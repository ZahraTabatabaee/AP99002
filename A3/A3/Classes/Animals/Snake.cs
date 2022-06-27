using System;
using A3.Interfaces;
using Environment = A3.Enums.Environment;

namespace A3.Classes.Animals
{
    public class Snake : IAnimal, ICrawlable
    {
        public string name;
        public int age;
        public double health;
        public double speedRate;
        public Snake(string name, int age, double health, double speedRate)
        {}

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Health { get => health; set => health = value; }
        public double SpeedRate { get => speedRate; set => speedRate = value; }

        public string Crawl()
        {
            return $"{Name} is a {typeof(Snake).Name} and is crawling";
        }

        public string EatFood()
        {
            return $"{Name} is a {typeof(Snake).Name} and is eating";
        }

        public string Move(Environment e)
        {
            if(e!=Environment.Land)
                return $"{Name} is a {typeof(Snake).Name} and can't move in {Enum.GetName(typeof(A3.Enums.Environment), e)} environment";
            else
                return $"{Name} is a {typeof(Snake).Name} and is crawling";
        }

        public string Reproduction(IAnimal i)
        {
            return $"{i.Name} is a {typeof(Snake).Name} and reproductive with {i.Name}";
        }
    }
}