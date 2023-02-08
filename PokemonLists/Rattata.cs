using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class Rattata : Pokemon
    {
        public Rattata() 
        { 
            Random random = new Random();
            this.name = "Rattata";
            this.hp = random.Next(170, 264);
            this.attack = random.Next(105, 232);
            this.image = Properties.Resources.rattata_f;
        }
    }
}
