﻿using System;
using A3.Interfaces;
using Environment = A3.Enums.Environment;

namespace A3.Classes.Animals
{
    public class Crow : IAnimal, IFlyable
    {
        public string name;
        public int age;
        public double health;
        public double speedRate;
        public Crow(string name, int age, double health, double speedRate)
        {
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Health { get => health; set => health = value; }
        public double SpeedRate { get => speedRate; set => speedRate = value; }


        public string EatFood()
        {
            return $"{Name} is a Crow and is eating";
        }

        public string Fly()
        {
            return $"{Name} is a {typeof(Crow).Name} and is flying";
        }

        public string Move(Environment e)
        {
            if(e == Environment.Air)
                return $"{Name} is a {typeof(Crow).Name} and is flying";
            else
                return $"{Name} is a {typeof(Crow).Name} and can't move in {Enum.GetName(typeof(Environment), e)} environment";
        }

        public string Reproduction(IAnimal i)
        {
            return $"{i.Name} is a {typeof(Crow).Name} and reproductive with {i.Name}";
        }
    }
}