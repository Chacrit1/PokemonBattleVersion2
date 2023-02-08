using PokemonBattleV2.PokemonLists;
using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonBattleV2
{
    public partial class Game : Form
    {
        List<Pokemon> PokemonList;
        List<Pokemon> PokemonMonsterList = new List<Pokemon>();
        Pokemon selectPokemon;
        Pokemon selectMonster;
        int selectSlot;
        bool yourTurn = false;
        bool enemyTurn = false;
        int heart = 4;
        public Game(List<Pokemon> pokemonlist)
        {
            InitializeComponent();
            this.PokemonList = pokemonlist;
            PokemonMonsterList.Add(new Electabuzz());
            PokemonMonsterList.Add(new Mewtwo());
            selectMonster = PokemonMonsterList[0];
            this.monstername.Text =  selectMonster.getName();
            this.monsterhp.Text =  selectMonster.getHp().ToString();
            this.monsterattack.Text =  selectMonster.getAttack().ToString();
            this.monsterpicture.Image = selectMonster.getImage();
            this.panelMosnter.Enabled = false;
            this.panelMosnter.BackColor = Color.GhostWhite;
            this.pokemontakedamage.Hide();
            this.monstertakedamage.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        bool mousedown;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mouseX = MousePosition.X - 500;
                int mouseY = MousePosition.Y - 20;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.Picture2.Image = PokemonList[1].getImage();
            this.Picture3.Image = PokemonList[2].getImage();
            this.Picture4.Image = PokemonList[3].getImage();
            this.Picture5.Image = PokemonList[0].getImage();
        }
        private void selectCharacter(object sender, EventArgs e)
        {
            SoundPlayer selectedClick = new SoundPlayer(Properties.Resources.game_start_61041);
            selectedClick.Play();
            PictureBox Picture = (PictureBox)sender;
            yourTurn = true;
            if (yourTurn)
            {
                this.panel5.BackColor= Color.FromArgb(25, 135, 84);
                this.textBox1.Text = "Your Turn";
                this.button2.Enabled = true;
            }
            if (Picture.Name == "Picture5")
            {
                selectSlot = 1;
                selectPokemon = PokemonList[0];
                this.Picture1.Image = selectPokemon.getImage();
                this.pokemonname.Text = selectPokemon.getName();
                this.pokemonhp.Text  = selectPokemon.getHp().ToString();
                this.pokemonattack.Text  = selectPokemon.getAttack().ToString();
                this.Picture5.Image = null;
                this.Picture2.Image = PokemonList[1].getImage();
                this.Picture3.Image = PokemonList[2].getImage();
                this.Picture4.Image = PokemonList[3].getImage();
            }
            if (Picture.Name == "Picture2")
            {
                selectSlot = 2;
                selectPokemon = PokemonList[1];
                this.Picture1.Image = selectPokemon.getImage();
                this.Picture1.Image = selectPokemon.getImage();
                this.pokemonname.Text = selectPokemon.getName();
                this.pokemonhp.Text = selectPokemon.getHp().ToString();
                this.pokemonattack.Text = selectPokemon.getAttack().ToString();
                this.Picture2.Image = null;
                this.Picture5.Image = PokemonList[0].getImage();
                this.Picture3.Image = PokemonList[2].getImage();
                this.Picture4.Image = PokemonList[3].getImage();
            }
            if (Picture.Name == "Picture3")
            {
                selectSlot = 3;
                selectPokemon = PokemonList[2];
                this.Picture1.Image = selectPokemon.getImage();
                this.Picture1.Image = selectPokemon.getImage();
                this.pokemonname.Text = selectPokemon.getName();
                this.pokemonhp.Text = selectPokemon.getHp().ToString();
                this.pokemonattack.Text = selectPokemon.getAttack().ToString();
                this.Picture3.Image = null;
                this.Picture2.Image = PokemonList[1].getImage();
                this.Picture5.Image = PokemonList[0].getImage();
                this.Picture4.Image = PokemonList[3].getImage();
            }
            if (Picture.Name == "Picture4")
            {
                selectSlot = 4;
                selectPokemon = PokemonList[3];
                this.Picture1.Image = selectPokemon.getImage();
                this.Picture1.Image = selectPokemon.getImage();
                this.pokemonname.Text = selectPokemon.getName();
                this.pokemonhp.Text = selectPokemon.getHp().ToString();
                this.pokemonattack.Text = selectPokemon.getAttack().ToString();
                this.Picture4.Image = null;
                this.Picture2.Image = PokemonList[1].getImage();
                this.Picture3.Image = PokemonList[2].getImage();
                this.Picture5.Image = PokemonList[0].getImage();
            }
        }

        SoundPlayer attackSound = new SoundPlayer(Properties.Resources.swinging_staff_whoosh_strong_08_44658);
        SoundPlayer victorySound = new SoundPlayer(Properties.Resources.success_fanfare_trumpets_6185);
        SoundPlayer deadSound = new SoundPlayer(Properties.Resources.dead_8bit_41400);
        SoundPlayer lostSound = new SoundPlayer(Properties.Resources.AGFAT7X_8_bit_game_lose);

        private async void button2_Click(object sender, EventArgs e)
        {
            this.button2.Enabled= false;
            this.Picture5.Enabled= false;
            this.Picture2.Enabled= false;
            this.Picture3.Enabled= false;
            this.Picture4.Enabled= false;
            this.panelMosnter.Enabled = true;
            this.textBox1.Text = "You Choose Attack";
            await Task.Delay(500);
            attackSound.Play();
            selectMonster.takeDamage(selectPokemon.getAttack());
            this.monsterhp.Text = selectMonster.getHp().ToString();
            this.monstertakedamage.Text = "- "+selectPokemon.getAttack().ToString();
            this.monstertakedamage.Show();
            if (selectMonster.getHp() <= 0 ) {
                victorySound.Play();
                this.monsterhp.Text = 0.ToString();
                MessageBox.Show("You Win!");
                this.monstertakedamage.Hide();
                return;
            }
            await Task.Delay(1500);
            this.monstertakedamage.Hide();
            this.panel5.BackColor = Color.FromArgb(220, 53, 69);
            this.textBox1.Text = "Enemy Turn";
            await Task.Delay(1500);
            this.panel6.Enabled = true;
            this.panel3.Enabled = true;
            this.textBox1.Text = "Enemy Choose Attack";
            await Task.Delay(1000);
            attackSound.Play();
            this.selectPokemon.takeDamage(selectMonster.getAttack());
            this.pokemonhp.Text = selectPokemon.getHp().ToString();
            this.pokemontakedamage.Text = "- " + selectMonster.getAttack().ToString();
            this.pokemontakedamage.Show();
            await Task.Delay(1500);
            if (selectPokemon.getHp() <= 0)
            {
                deadSound.Play();
                this.Picture5.Enabled= true;
                this.Picture2.Enabled = true;
                this.Picture3.Enabled = true;
                this.Picture4.Enabled = true;
                this.Picture1.Image = null;
                this.pokemonname.Text = "";
                this.pokemonhp.Text = "";
                this.pokemonattack.Text = "";
                this.selectPokemon.setImage();
                this.panel5.BackColor = Color.FromArgb(255, 193, 7);
                this.textBox1.Text = "Choose Your Characters";
                this.pokemontakedamage.Hide();
                this.heart -= 1;
                if (selectSlot == 1)
                {
                    this.Picture5.Enabled = false;
                    this.Picture5.Image = null;
                }
                if (selectSlot == 2)
                {
                    this.Picture2.Enabled = false;
                    this.Picture2.Image = null;
                }
                if (selectSlot == 3)
                {
                    this.Picture3.Enabled = false;
                    this.Picture3.Image = null;
                }
                if (selectSlot == 4)
                {
                    this.Picture4.Enabled = false;
                    this.Picture4.Image = null;
                }
                if (heart == 0)
                {
                    this.pokemontakedamage.Hide();
                    lostSound.Play();
                    MessageBox.Show("You Lose!");
                }
                return;
            }
            await Task.Delay(2000);
            this.Picture5.Enabled = true;
            this.Picture2.Enabled = true;
            this.Picture3.Enabled = true;
            this.Picture4.Enabled = true;
            this.pokemontakedamage.Hide();
            this.panel5.BackColor = Color.FromArgb(25, 135, 84);
            this.textBox1.Text = "Your Turn";
        }
    }
}
