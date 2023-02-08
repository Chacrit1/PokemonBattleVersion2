using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleV2.Resources
{
    public class Pokemon
    {
        protected string name { get; set; }
        protected int hp { get; set; }
        protected int attack { get; set; }
        protected Bitmap image { get; set; }
        public string getName() { return name; }
        public int getHp() { return hp; }
        public int getAttack() { return attack; }
        public Bitmap getImage() { return image; }

        public void takeDamage(int damage)
        {
            this.hp = this.hp - damage;
        }
        public void setImage()
        {
            this.image = null;
        }
      
    }
}
