using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class Beedrill : Pokemon
    {
        public Beedrill() 
        { 
            Random random = new Random();
            this.name = "Beedrill";
            this.hp = random.Next(220, 334);
            this.attack = random.Next(166, 306);
            this.image = Properties.Resources.beedrill;
        }
    }
}
