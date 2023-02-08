using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class Jynx : Pokemon
    {
        public Jynx() 
        { 
            Random random = new Random();
            this.name = "Jynx";
            this.hp = random.Next(240, 384);
            this.attack = random.Next(94, 218);
            this.image = Properties.Resources.jynx;
        }
    }
}
