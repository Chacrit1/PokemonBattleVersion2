using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class Grimer : Pokemon
    {
        public Grimer() 
        { 
            Random random = new Random();
            this.name = "Grimer";
            this.hp = random.Next(270, 364);
            this.attack = random.Next(148, 284);
            this.image = Properties.Resources.grimer;
        }
    }
}
