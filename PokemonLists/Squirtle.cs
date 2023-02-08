using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class Squirtle : Pokemon
    {
        public Squirtle() 
        { 
            Random random = new Random();
            this.name = "Squirtle";
            this.hp = random.Next(198, 292);
            this.attack = random.Next(90, 214);
            this.image = Properties.Resources.squirtle;
        }
    }
}
