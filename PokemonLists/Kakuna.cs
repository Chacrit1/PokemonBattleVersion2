using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.PokemonLists
{
    internal class Kakuna : Pokemon
    {
        public Kakuna() 
        { 
            Random random = new Random();
            this.name = "Kakuna";
            this.hp = random.Next(200, 294);
            this.attack = random.Next(49, 193);
            this.image = Properties.Resources.kakuna;
        }
    }
}
