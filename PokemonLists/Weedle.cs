using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class Weedle : Pokemon
    {
        public Weedle() 
        { 
            Random random = new Random();
            this.name = "Weedle";
            this.hp = random.Next(190, 284);
            this.attack = random.Next(67, 185);
            this.image = Properties.Resources.weedle;
        }
    }
}
