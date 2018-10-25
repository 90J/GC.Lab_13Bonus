using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_13
{
    class Wizard : MagicUsingCharacter
    {
        //public int SpellNumber { get; set; }
        string Name;

        int Strength;
        int Intelligence;
        int Mana;
        int SpellNumber;

        public Wizard(string name, int strength, int intelligence, int mana, int spellNumber) : base(name, strength, intelligence, mana)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;

            Mana = mana;
            SpellNumber = spellNumber;
        }


        public override void Play()
        {
            Console.WriteLine("Name: {0} Strength: {1} Intelligence: {2} Magical Energy: {3} Spell Number: {4}", Name, Strength, Intelligence, Mana, SpellNumber);
        }
    }
}
