using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class MrMime : Pokemon
    {
        public MrMime() 
        { 
            Random random = new Random();
            this.name = "MrMime";
            this.hp = random.Next(190, 284);
            this.attack = random.Next(85, 207);
            this.image = Properties.Resources.mr_mime;
        }
    }
}
