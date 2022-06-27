
using System;
using System.Collections.Generic;
using System.Linq;
using A3.Interfaces;
using Environment = A3.Enums.Environment;

namespace A3.Classes
{
    public class GameBoard<_Type> where  _Type : IAnimal
    {
        public GameBoard(IEnumerable<IAnimal> animals)
        {
            Animal = animals.ToList();
        }

        public List<IAnimal> Animal { get; set; }

        public Environment[] b = new Environment[3]{A3.Enums.Environment.Air,A3.Enums.Environment.Land,A3.Enums.Environment.Watery};
        public List<string> c = new List<string>{};
        public string[] MoveAnimals()
        {
            foreach(IAnimal a in Animal)
            {
                for(int j = 0 ; j < b.Length ; j++)
                {
                    c.Add(a.Move(b[j]));
                }
            }
            return c.ToArray();
        }
        
    }
}

