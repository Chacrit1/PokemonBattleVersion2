using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class Magmar : Pokemon
    {
        public Magmar() 
        { 
            Random random = new Random();
            this.name = "Magmar";
            this.hp = random.Next(240, 334);
            this.attack = random.Next(175, 317);
            this.image = Properties.Resources.magmar;
        }
    }
}
