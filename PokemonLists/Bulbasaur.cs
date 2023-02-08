using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class Bulbasaur:Pokemon
    {
        public Bulbasaur() 
        { 
            Random random = new Random();
            this.name = "Bulbasaur";
            this.hp = random.Next(200, 294);
            this.attack = random.Next(92, 216);
            this.image = Properties.Resources.bulbasaur;
        }
    }
}
