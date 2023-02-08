using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class Mewtwo : Pokemon
    {
        public Mewtwo() 
        { 
            Random random = new Random();
            this.name = "Mewtwo";
            this.hp = random.Next(332, 416);
            this.attack = random.Next(202, 350);
            this.image = Properties.Resources.mewtwo;
        }
    }
}
