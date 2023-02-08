using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class Poliwhirl : Pokemon
    {
        public Poliwhirl() 
        { 
            Random random = new Random();
            this.name = "Poliwhirl";
            this.hp = random.Next(240, 334);
            this.attack = random.Next(121, 251);
            this.image = Properties.Resources.poliwhirl;
        }
    }
}
