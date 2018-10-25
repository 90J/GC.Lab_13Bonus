using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_13
{
    class MagicUsingCharacter : WoWHeroes
    {
        //public int Mana { get; set; }
        string Name;

        int Strength;
        int Intelligence;
        int Mana;
        

        public MagicUsingCharacter(string name, int strength, int intelligence, int mana) : base(name, strength, intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
;
            Mana = mana;
        }


        public override void Play()
        {
            Console.WriteLine("Name: {0} Strength: {1} Intelligence: {2} Magical Energy: {3}", Name, Strength, Intelligence, Mana);
        }
    }
}
