using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_13
{
    class Program
    {
        static void Main(string[] args)
        {
            WoWHeroes[] wowHeroes = new WoWHeroes[5];
            wowHeroes[0] = new Wizard ( "Jaina Proudmoore", 9001,  18, 1500, 1 );
            wowHeroes[1] = new Wizard ( "Archmage Alturus", 1700, 3, 1355, 7 );
            wowHeroes[2] = new Wizard ( "Conjurer Weinhaus",  6708,6, 1725, 55 );
            wowHeroes[3] = new Warrior ("Cairne Bloodhoof", 2,2954,"Totem Pole" );
            wowHeroes[4] = new Warrior ("Magni Bronzebeard", 45, 2245, "Ashebringer" );
           
            foreach (WoWHeroes character in wowHeroes)
            {
                character.Play();
             }
        }
    }
}
















