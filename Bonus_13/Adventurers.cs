using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_13
{
    class WoWHeroes
    {
        string Name;
        int Strength;
        int Intelligence;

        public WoWHeroes(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        //public string Name { get; set; }
        //public int Strength { get; set; }
        //public int Intelligence { get; set; }

        public virtual void Play()
        {
            Console.WriteLine("Name: {0} Strength: {1} Intelligence: {2}", Name, Strength, Intelligence);
        }
    }
}
