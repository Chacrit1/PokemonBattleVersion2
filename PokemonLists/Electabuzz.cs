using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class Electabuzz : Pokemon
    {
        public Electabuzz() 
        { 
            Random random = new Random();
            this.name = "Electabuzz";
            this.hp = random.Next(240, 334) * 3;
            this.attack = random.Next(153, 291)*50;
            this.image = Properties.Resources.electabuzz;
        }
    }
}
