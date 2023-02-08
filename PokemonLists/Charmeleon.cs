using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class Charmeleon : Pokemon
    {
        public Charmeleon() 
        { 
            Random random = new Random();
            this.name = "Charmeleon";
            this.hp = random.Next(226, 320);
            this.attack = random.Next(119, 249);
            this.image = Properties.Resources.charmeleon;
        }
    }
}
