using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class Caterpie : Pokemon
    {
        public Caterpie() 
        { 
            Random random = new Random();
            this.name = "Caterpie";
            this.hp = random.Next(200, 294);
            this.attack = random.Next(58, 174);
            this.image = Properties.Resources.caterpie;
        }
    }
}
