using PokemonBattleV2.PokemonLists;
using PokemonBattleV2.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace PokemonBattleV2
{
    public partial class Form1 : Form
    {

        public  List<Pokemon> PokemonList = new List<Pokemon>();

        public Form1()
        {
            InitializeComponent();
            //PokemonList.Add(new Mewtwo());
            //PokemonList.Add(new Pikachu());
            //PokemonList.Add(new Lapras());
            //PokemonList.Add(new Caterpie());
            this.mediaPlayer.URL = "bgmm.wav";
            this.mediaPlayer.settings.playCount= 9999;
            this.mediaPlayer.Visible = false;
            this.mediaPlayer.Ctlcontrols.play();
           
        }

        public static bool mousedown;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SelectedSound(object sender, EventArgs e)
        {
            // SoundPlayer selectedHover = new SoundPlayer(Properties.Resources.selectedpokemon1);
            // selectedHover.Play();
        }


        int slotPokemon = 0;


        private void SelectedPokemon(object sender, EventArgs e)
        {
            SoundPlayer selectedClick = new SoundPlayer(Properties.Resources.game_start_61041);
            selectedClick.Play();

            PictureBox pictureBox = (PictureBox)sender;

            if (slotPokemon == 0)
            {

                if (pictureBox.Name == "pictureBox1")
                {
                    Bulbasaur bulbasaur = new Bulbasaur();
                    SelectedPicture1.Image = bulbasaur.getImage();
                    PokemonList.Add(bulbasaur);
                }

                if (pictureBox.Name == "pictureBox2")
                {
                    Charmeleon charmeleon = new Charmeleon();
                    SelectedPicture1.Image = charmeleon.getImage();
                    PokemonList.Add(charmeleon);
                }

                if (pictureBox.Name == "pictureBox3")
                {
                    Squirtle squirtle = new Squirtle();
                    SelectedPicture1.Image = squirtle.getImage();
                    PokemonList.Add(squirtle);
                }

                if (pictureBox.Name == "pictureBox4")
                {
                    Caterpie caterpie = new Caterpie();
                    SelectedPicture1.Image = caterpie.getImage();
                    PokemonList.Add(caterpie);
                }

                if (pictureBox.Name == "pictureBox5")
                {
                    Weedle weedle = new Weedle();
                    SelectedPicture1.Image = weedle.getImage();
                    PokemonList.Add(weedle);
                }
                if (pictureBox.Name == "pictureBox6")
                {
                    Pidgey pidgey = new Pidgey();
                    SelectedPicture1.Image = pidgey.getImage();
                    PokemonList.Add(pidgey);
                }
                if (pictureBox.Name == "pictureBox7")
                {
                    Kakuna kakuna = new Kakuna();
                    SelectedPicture1.Image = kakuna.getImage();
                    PokemonList.Add(kakuna);
                }
                if (pictureBox.Name == "pictureBox8")
                {
                    Beedrill beedrill = new Beedrill();
                    SelectedPicture1.Image = beedrill.getImage();
                    PokemonList.Add(beedrill);
                }
                if (pictureBox.Name == "pictureBox9")
                {
                    Rattata rattata = new Rattata();
                    SelectedPicture1.Image = rattata.getImage();
                    PokemonList.Add(rattata);
                }
                if (pictureBox.Name == "pictureBox10")
                {
                    Fearow fearow = new Fearow();
                    SelectedPicture1.Image = fearow.getImage();
                    PokemonList.Add(fearow);
                }
                if (pictureBox.Name == "pictureBox11")
                {
                    Pikachu pikachu = new Pikachu();
                    SelectedPicture1.Image = pikachu.getImage();
                    PokemonList.Add(pikachu);
                }
                if (pictureBox.Name == "pictureBox12")
                {
                    Magmar magmar = new Magmar();
                    SelectedPicture1.Image = magmar.getImage();
                    PokemonList.Add(magmar);
                }
                if (pictureBox.Name == "pictureBox13")
                {
                    Poliwhirl poliwhirl = new Poliwhirl();
                    SelectedPicture1.Image = poliwhirl.getImage();
                    PokemonList.Add(poliwhirl);
                }
                if (pictureBox.Name == "pictureBox14")
                {
                    Grimer grimer = new Grimer();
                    SelectedPicture1.Image = grimer.getImage();
                    PokemonList.Add(grimer);
                }
                if (pictureBox.Name == "pictureBox15")
                {
                    Mewtwo mewtwo = new Mewtwo();
                    SelectedPicture1.Image = mewtwo.getImage();
                    PokemonList.Add(mewtwo);
                }
                if (pictureBox.Name == "pictureBox16")
                {
                    MrMime mrmime = new MrMime();
                    SelectedPicture1.Image = mrmime.getImage();
                    PokemonList.Add(mrmime);
                }
                if (pictureBox.Name == "pictureBox17")
                {
                    Lapras lapras = new Lapras();
                    SelectedPicture1.Image = lapras.getImage();
                    PokemonList.Add(lapras);
                }
                if (pictureBox.Name == "pictureBox18")
                {
                    Jynx jynx = new Jynx();
                    SelectedPicture1.Image = jynx.getImage();
                    PokemonList.Add(jynx);
                }
            }

            if (slotPokemon == 1)
            {
                if (pictureBox.Name == "pictureBox1")
                {
                    Bulbasaur bulbasaur = new Bulbasaur();
                    SelectedPicture2.Image = bulbasaur.getImage();
                    PokemonList.Add(bulbasaur);

                }

                if (pictureBox.Name == "pictureBox2")
                {
                    Charmeleon charmeleon = new Charmeleon();
                    SelectedPicture2.Image = charmeleon.getImage();
                    PokemonList.Add(charmeleon);

                }

                if (pictureBox.Name == "pictureBox3")
                {
                    Squirtle squirtle = new Squirtle();
                    SelectedPicture2.Image = squirtle.getImage();
                    PokemonList.Add(squirtle);

                }

                if (pictureBox.Name == "pictureBox4")
                {
                    Caterpie caterpie = new Caterpie();
                    SelectedPicture2.Image = caterpie.getImage();
                    PokemonList.Add(caterpie);

                }

                if (pictureBox.Name == "pictureBox5")
                {
                    Weedle weedle = new Weedle();
                    SelectedPicture2.Image = weedle.getImage();
                    PokemonList.Add(weedle);

                }
                if (pictureBox.Name == "pictureBox6")
                {
                    Pidgey pidgey = new Pidgey();
                    SelectedPicture2.Image = pidgey.getImage();
                    PokemonList.Add(pidgey);

                }
                if (pictureBox.Name == "pictureBox7")
                {
                    Kakuna kakuna = new Kakuna();
                    SelectedPicture2.Image = kakuna.getImage();
                    PokemonList.Add(kakuna);

                }
                if (pictureBox.Name == "pictureBox8")
                {
                    Beedrill beedrill = new Beedrill();
                    SelectedPicture2.Image = beedrill.getImage();
                    PokemonList.Add(beedrill);

                }
                if (pictureBox.Name == "pictureBox9")
                {
                    Rattata rattata = new Rattata();
                    SelectedPicture2.Image = rattata.getImage();
                    PokemonList.Add(rattata);

                }
                if (pictureBox.Name == "pictureBox10")
                {
                    Fearow fearow = new Fearow();
                    SelectedPicture2.Image = fearow.getImage();
                    PokemonList.Add(fearow);

                }
                if (pictureBox.Name == "pictureBox11")
                {
                    Pikachu pikachu = new Pikachu();
                    SelectedPicture2.Image = pikachu.getImage();
                    PokemonList.Add(pikachu);

                }
                if (pictureBox.Name == "pictureBox12")
                {
                    Magmar magmar = new Magmar();
                    SelectedPicture2.Image = magmar.getImage();
                    PokemonList.Add(magmar);

                }
                if (pictureBox.Name == "pictureBox13")
                {
                    Poliwhirl poliwhirl = new Poliwhirl();
                    SelectedPicture2.Image = poliwhirl.getImage();
                    PokemonList.Add(poliwhirl);

                }
                if (pictureBox.Name == "pictureBox14")
                {
                    Grimer grimer = new Grimer();
                    SelectedPicture2.Image = grimer.getImage();
                    PokemonList.Add(grimer);

                }

                if (pictureBox.Name == "pictureBox15")
                {
                    Mewtwo mewtwo = new Mewtwo();
                    SelectedPicture2.Image = mewtwo.getImage();
                    PokemonList.Add(mewtwo);

                }
                if (pictureBox.Name == "pictureBox16")
                {
                    MrMime mrmime = new MrMime();
                    SelectedPicture2.Image = mrmime.getImage();
                    PokemonList.Add(mrmime);

                }
                if (pictureBox.Name == "pictureBox17")
                {
                    Lapras lapras = new Lapras();
                    SelectedPicture2.Image = lapras.getImage();
                    PokemonList.Add(lapras);

                }
                if (pictureBox.Name == "pictureBox18")
                {
                    Jynx jynx = new Jynx();
                    SelectedPicture2.Image = jynx.getImage();
                    PokemonList.Add(jynx);

                }

            }

            if (slotPokemon == 2)
            {
                if (pictureBox.Name == "pictureBox1")
                {
                    Bulbasaur bulbasaur = new Bulbasaur();
                    SelectedPicture3.Image = bulbasaur.getImage();
                    PokemonList.Add(bulbasaur);

                }

                if (pictureBox.Name == "pictureBox2")
                {
                    Charmeleon charmeleon = new Charmeleon();
                    SelectedPicture3.Image = charmeleon.getImage();
                    PokemonList.Add(charmeleon);

                }

                if (pictureBox.Name == "pictureBox3")
                {
                    Squirtle squirtle = new Squirtle();
                    SelectedPicture3.Image = squirtle.getImage();
                    PokemonList.Add(squirtle);

                }

                if (pictureBox.Name == "pictureBox4")
                {
                    Caterpie caterpie = new Caterpie();
                    SelectedPicture3.Image = caterpie.getImage();
                    PokemonList.Add(caterpie);

                }

                if (pictureBox.Name == "pictureBox5")
                {
                    Weedle weedle = new Weedle();
                    SelectedPicture3.Image = weedle.getImage();
                    PokemonList.Add(weedle);

                }
                if (pictureBox.Name == "pictureBox6")
                {
                    Pidgey pidgey = new Pidgey();
                    SelectedPicture3.Image = pidgey.getImage();
                    PokemonList.Add(pidgey);

                }
                if (pictureBox.Name == "pictureBox7")
                {
                    Kakuna kakuna = new Kakuna();
                    SelectedPicture3.Image = kakuna.getImage();
                    PokemonList.Add(kakuna);

                }
                if (pictureBox.Name == "pictureBox8")
                {
                    Beedrill beedrill = new Beedrill();
                    SelectedPicture3.Image = beedrill.getImage();
                    PokemonList.Add(beedrill);

                }
                if (pictureBox.Name == "pictureBox9")
                {
                    Rattata rattata = new Rattata();
                    SelectedPicture3.Image = rattata.getImage();
                    PokemonList.Add(rattata);

                }
                if (pictureBox.Name == "pictureBox10")
                {
                    Fearow fearow = new Fearow();
                    SelectedPicture3.Image = fearow.getImage();
                    PokemonList.Add(fearow);

                }
                if (pictureBox.Name == "pictureBox11")
                {
                    Pikachu pikachu = new Pikachu();
                    SelectedPicture3.Image = pikachu.getImage();
                    PokemonList.Add(pikachu);

                }
                if (pictureBox.Name == "pictureBox12")
                {
                    Magmar magmar = new Magmar();
                    SelectedPicture3.Image = magmar.getImage();
                    PokemonList.Add(magmar);

                }
                if (pictureBox.Name == "pictureBox13")
                {
                    Poliwhirl poliwhirl = new Poliwhirl();
                    SelectedPicture3.Image = poliwhirl.getImage();
                    PokemonList.Add(poliwhirl);

                }

                if (pictureBox.Name == "pictureBox14")
                {
                    Grimer grimer = new Grimer();
                    SelectedPicture3.Image = grimer.getImage();
                    PokemonList.Add(grimer);

                }
                if (pictureBox.Name == "pictureBox15")
                {
                    Mewtwo mewtwo = new Mewtwo();
                    SelectedPicture3.Image = mewtwo.getImage();
                    PokemonList.Add(mewtwo);

                }
                if (pictureBox.Name == "pictureBox16")
                {
                    MrMime mrmime = new MrMime();
                    SelectedPicture3.Image = mrmime.getImage();
                    PokemonList.Add(mrmime);

                }
                if (pictureBox.Name == "pictureBox17")
                {
                    Lapras lapras = new Lapras();
                    SelectedPicture3.Image = lapras.getImage();
                    PokemonList.Add(lapras);

                }
                if (pictureBox.Name == "pictureBox18")
                {
                    Jynx jynx = new Jynx();
                    SelectedPicture3.Image = jynx.getImage();
                    PokemonList.Add(jynx);

                }
            }

            if (slotPokemon == 3)
            {
                if (pictureBox.Name == "pictureBox1")
                {
                    Bulbasaur bulbasaur = new Bulbasaur();
                    SelectedPicture4.Image = bulbasaur.getImage();
                    PokemonList.Add(bulbasaur);

                }

                if (pictureBox.Name == "pictureBox2")
                {
                    Charmeleon charmeleon = new Charmeleon();
                    SelectedPicture4.Image = charmeleon.getImage();
                    PokemonList.Add(charmeleon);

                }

                if (pictureBox.Name == "pictureBox3")
                {
                    Squirtle squirtle = new Squirtle();
                    SelectedPicture4.Image = squirtle.getImage();
                    PokemonList.Add(squirtle);

                }

                if (pictureBox.Name == "pictureBox4")
                {
                    Caterpie caterpie = new Caterpie();
                    SelectedPicture4.Image = caterpie.getImage();
                    PokemonList.Add(caterpie);
                }

                if (pictureBox.Name == "pictureBox5")
                {
                    Weedle weedle = new Weedle();
                    SelectedPicture4.Image = weedle.getImage();
                    PokemonList.Add(weedle);

                }
                if (pictureBox.Name == "pictureBox6")
                {
                    Pidgey pidgey = new Pidgey();
                    SelectedPicture4.Image = pidgey.getImage();
                    PokemonList.Add(pidgey);

                }
                if (pictureBox.Name == "pictureBox7")
                {
                    Kakuna kakuna = new Kakuna();
                    SelectedPicture4.Image = kakuna.getImage();
                    PokemonList.Add(kakuna);

                }
                if (pictureBox.Name == "pictureBox8")
                {
                    Beedrill beedrill = new Beedrill();
                    SelectedPicture4.Image = beedrill.getImage();
                    PokemonList.Add(beedrill);

                }
                if (pictureBox.Name == "pictureBox9")
                {
                    Rattata rattata = new Rattata();
                    SelectedPicture4.Image = rattata.getImage();
                    PokemonList.Add(rattata);
                }
                if (pictureBox.Name == "pictureBox10")
                {
                    Fearow fearow = new Fearow();
                    SelectedPicture4.Image = fearow.getImage();
                    PokemonList.Add(fearow);

                }
                if (pictureBox.Name == "pictureBox11")
                {
                    Pikachu pikachu = new Pikachu();
                    SelectedPicture4.Image = pikachu.getImage();
                    PokemonList.Add(pikachu);

                }
                if (pictureBox.Name == "pictureBox12")
                {
                    Magmar magmar = new Magmar();
                    SelectedPicture4.Image = magmar.getImage();
                    PokemonList.Add(magmar);

                }
                if (pictureBox.Name == "pictureBox13")
                {
                    Poliwhirl poliwhirl = new Poliwhirl();
                    SelectedPicture4.Image = poliwhirl.getImage();
                    PokemonList.Add(poliwhirl);

                }
                if (pictureBox.Name == "pictureBox14")
                {
                    Grimer grimer = new Grimer();
                    SelectedPicture4.Image = grimer.getImage();
                    PokemonList.Add(grimer);

                }

                if (pictureBox.Name == "pictureBox15")
                {
                    Mewtwo mewtwo = new Mewtwo();
                    SelectedPicture4.Image = mewtwo.getImage();
                    PokemonList.Add(mewtwo);

                }
                if (pictureBox.Name == "pictureBox16")
                {
                    MrMime mrmime = new MrMime();
                    SelectedPicture4.Image = mrmime.getImage();
                    PokemonList.Add(mrmime);

                }
                if (pictureBox.Name == "pictureBox17")
                {
                    Lapras lapras = new Lapras();
                    SelectedPicture4.Image = lapras.getImage();
                    PokemonList.Add(lapras);

                }
                if (pictureBox.Name == "pictureBox18")
                {
                    Jynx jynx = new Jynx();
                    SelectedPicture4.Image = jynx.getImage();
                    PokemonList.Add(jynx);

                }
            }
            slotPokemon += 1;
            if (slotPokemon == 4)
            {
                this.button3.BackColor = Color.FromArgb(25, 135, 84);
                this.button3.Text = "Ready To Fight!";
                this.button3.Enabled = true;
            }
            if (slotPokemon == 1) {
                this.button2.Enabled = true;
            }
        }

        new SoundPlayer clearSound = new SoundPlayer(Properties.Resources.cartoon_jump_6462);

        private void button2_Click(object sender, EventArgs e)
        {
            clearSound.Play();
            this.slotPokemon = 0;
            this.button3.BackColor = Color.FromArgb(248, 249, 250);
            this.button3.Enabled = false;
            this.button3.Text = string.Empty;
            this.PokemonList.Clear();
            this.SelectedPicture1.Image = null;
            this.SelectedPicture2.Image = null;
            this.SelectedPicture3.Image = null;
            this.SelectedPicture4.Image = null;
            this.button2.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game game = new Game(PokemonList);
            game.Show();
            this.Hide();
        }
    }
}
