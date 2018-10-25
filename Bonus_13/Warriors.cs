using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_13
{
    class Warrior : WoWHeroes
    {
        //public string WeaponType { get; set; }
        string WeaponType;
        string Name;
        int Strength;
        int Intelligence;

        public Warrior(string name, int strength, int intelligence, string weaponType) : base(name, strength, intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            WeaponType = weaponType;

        }



        public override void Play()
        {
            Console.WriteLine("Name: {0} Strength: {1} Intelligence: {2} Weapon Type: {3}", Name, Strength, Intelligence, WeaponType);
        }
    }
}
