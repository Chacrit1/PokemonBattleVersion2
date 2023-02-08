namespace PokemonBattleV2
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panelMosnter = new System.Windows.Forms.Panel();
            this.monstertakedamage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monstername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monsterattack = new System.Windows.Forms.Label();
            this.monsterhp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pokemontakedamage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pokemonname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pokemonattack = new System.Windows.Forms.Label();
            this.pokemonhp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Picture1 = new System.Windows.Forms.PictureBox();
            this.Picture5 = new System.Windows.Forms.PictureBox();
            this.Picture3 = new System.Windows.Forms.PictureBox();
            this.Picture4 = new System.Windows.Forms.PictureBox();
            this.Picture2 = new System.Windows.Forms.PictureBox();
            this.monsterpicture = new System.Windows.Forms.PictureBox();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelMosnter.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Icon);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 40);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PokemonBattle";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.panelMosnter);
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 670);
            this.panel4.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(14, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(412, 200);
            this.button3.TabIndex = 21;
            this.button3.Text = "Attack";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panelMosnter
            // 
            this.panelMosnter.BackColor = System.Drawing.Color.White;
            this.panelMosnter.Controls.Add(this.monstertakedamage);
            this.panelMosnter.Controls.Add(this.label6);
            this.panelMosnter.Controls.Add(this.monstername);
            this.panelMosnter.Controls.Add(this.label2);
            this.panelMosnter.Controls.Add(this.monsterattack);
            this.panelMosnter.Controls.Add(this.monsterhp);
            this.panelMosnter.Controls.Add(this.label3);
            this.panelMosnter.Controls.Add(this.monsterpicture);
            this.panelMosnter.Location = new System.Drawing.Point(14, 274);
            this.panelMosnter.Name = "panelMosnter";
            this.panelMosnter.Size = new System.Drawing.Size(412, 386);
            this.panelMosnter.TabIndex = 15;
            // 
            // monstertakedamage
            // 
            this.monstertakedamage.AutoSize = true;
            this.monstertakedamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monstertakedamage.ForeColor = System.Drawing.Color.Red;
            this.monstertakedamage.Location = new System.Drawing.Point(135, 72);
            this.monstertakedamage.Name = "monstertakedamage";
            this.monstertakedamage.Size = new System.Drawing.Size(0, 25);
            this.monstertakedamage.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Name :";
            // 
            // monstername
            // 
            this.monstername.AutoSize = true;
            this.monstername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monstername.ForeColor = System.Drawing.Color.Fuchsia;
            this.monstername.Location = new System.Drawing.Point(116, 29);
            this.monstername.Name = "monstername";
            this.monstername.Size = new System.Drawing.Size(0, 29);
            this.monstername.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hp :";
            // 
            // monsterattack
            // 
            this.monsterattack.AutoSize = true;
            this.monsterattack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterattack.ForeColor = System.Drawing.Color.DarkOrange;
            this.monsterattack.Location = new System.Drawing.Point(109, 109);
            this.monsterattack.Name = "monsterattack";
            this.monsterattack.Size = new System.Drawing.Size(0, 29);
            this.monsterattack.TabIndex = 11;
            // 
            // monsterhp
            // 
            this.monsterhp.AutoSize = true;
            this.monsterhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterhp.ForeColor = System.Drawing.Color.Red;
            this.monsterhp.Location = new System.Drawing.Point(78, 69);
            this.monsterhp.Name = "monsterhp";
            this.monsterhp.Size = new System.Drawing.Size(0, 29);
            this.monsterhp.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Attack :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(454, 314);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(306, 115);
            this.panel5.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Choose Your Character";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "State";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.Picture5);
            this.panel6.Controls.Add(this.Picture3);
            this.panel6.Controls.Add(this.Picture4);
            this.panel6.Controls.Add(this.Picture2);
            this.panel6.Location = new System.Drawing.Point(766, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(430, 670);
            this.panel6.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(22, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(389, 167);
            this.button2.TabIndex = 20;
            this.button2.Text = "Attack";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pokemontakedamage);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pokemonname);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pokemonattack);
            this.panel3.Controls.Add(this.pokemonhp);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.Picture1);
            this.panel3.Location = new System.Drawing.Point(22, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 363);
            this.panel3.TabIndex = 19;
            // 
            // pokemontakedamage
            // 
            this.pokemontakedamage.AutoSize = true;
            this.pokemontakedamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemontakedamage.ForeColor = System.Drawing.Color.Red;
            this.pokemontakedamage.Location = new System.Drawing.Point(165, 71);
            this.pokemontakedamage.Name = "pokemontakedamage";
            this.pokemontakedamage.Size = new System.Drawing.Size(0, 25);
            this.pokemontakedamage.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name :";
            // 
            // pokemonname
            // 
            this.pokemonname.AutoSize = true;
            this.pokemonname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemonname.ForeColor = System.Drawing.Color.Fuchsia;
            this.pokemonname.Location = new System.Drawing.Point(116, 29);
            this.pokemonname.Name = "pokemonname";
            this.pokemonname.Size = new System.Drawing.Size(0, 29);
            this.pokemonname.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hp :";
            // 
            // pokemonattack
            // 
            this.pokemonattack.AutoSize = true;
            this.pokemonattack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemonattack.ForeColor = System.Drawing.Color.DarkOrange;
            this.pokemonattack.Location = new System.Drawing.Point(103, 110);
            this.pokemonattack.Name = "pokemonattack";
            this.pokemonattack.Size = new System.Drawing.Size(0, 29);
            this.pokemonattack.TabIndex = 11;
            // 
            // pokemonhp
            // 
            this.pokemonhp.AutoSize = true;
            this.pokemonhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemonhp.ForeColor = System.Drawing.Color.Red;
            this.pokemonhp.Location = new System.Drawing.Point(78, 69);
            this.pokemonhp.Name = "pokemonhp";
            this.pokemonhp.Size = new System.Drawing.Size(0, 29);
            this.pokemonhp.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(18, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "Attack :";
            // 
            // Picture1
            // 
            this.Picture1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Picture1.Location = new System.Drawing.Point(62, 149);
            this.Picture1.Name = "Picture1";
            this.Picture1.Size = new System.Drawing.Size(281, 199);
            this.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture1.TabIndex = 3;
            this.Picture1.TabStop = false;
            // 
            // Picture5
            // 
            this.Picture5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Picture5.Location = new System.Drawing.Point(121, 389);
            this.Picture5.Name = "Picture5";
            this.Picture5.Size = new System.Drawing.Size(94, 79);
            this.Picture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture5.TabIndex = 18;
            this.Picture5.TabStop = false;
            this.Picture5.Click += new System.EventHandler(this.selectCharacter);
            // 
            // Picture3
            // 
            this.Picture3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Picture3.Location = new System.Drawing.Point(22, 389);
            this.Picture3.Name = "Picture3";
            this.Picture3.Size = new System.Drawing.Size(90, 79);
            this.Picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture3.TabIndex = 17;
            this.Picture3.TabStop = false;
            this.Picture3.Click += new System.EventHandler(this.selectCharacter);
            // 
            // Picture4
            // 
            this.Picture4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Picture4.Location = new System.Drawing.Point(221, 388);
            this.Picture4.Name = "Picture4";
            this.Picture4.Size = new System.Drawing.Size(90, 80);
            this.Picture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture4.TabIndex = 16;
            this.Picture4.TabStop = false;
            this.Picture4.Click += new System.EventHandler(this.selectCharacter);
            // 
            // Picture2
            // 
            this.Picture2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Picture2.Location = new System.Drawing.Point(317, 389);
            this.Picture2.Name = "Picture2";
            this.Picture2.Size = new System.Drawing.Size(94, 79);
            this.Picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture2.TabIndex = 15;
            this.Picture2.TabStop = false;
            this.Picture2.Click += new System.EventHandler(this.selectCharacter);
            // 
            // monsterpicture
            // 
            this.monsterpicture.Image = global::PokemonBattleV2.Properties.Resources.electabuzz;
            this.monsterpicture.Location = new System.Drawing.Point(33, 142);
            this.monsterpicture.Name = "monsterpicture";
            this.monsterpicture.Size = new System.Drawing.Size(330, 234);
            this.monsterpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.monsterpicture.TabIndex = 2;
            this.monsterpicture.TabStop = false;
            // 
            // Icon
            // 
            this.Icon.Image = global::PokemonBattleV2.Properties.Resources.icon;
            this.Icon.Location = new System.Drawing.Point(5, 2);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(46, 35);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon.TabIndex = 1;
            this.Icon.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::PokemonBattleV2.Properties.Resources.close__1_1;
            this.button1.Location = new System.Drawing.Point(1145, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1196, 706);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panelMosnter.ResumeLayout(false);
            this.panelMosnter.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Icon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelMosnter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label monstername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label monsterattack;
        private System.Windows.Forms.Label monsterhp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox monsterpicture;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pokemonname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label pokemonattack;
        private System.Windows.Forms.Label pokemonhp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox Picture1;
        private System.Windows.Forms.PictureBox Picture5;
        private System.Windows.Forms.PictureBox Picture3;
        private System.Windows.Forms.PictureBox Picture4;
        private System.Windows.Forms.PictureBox Picture2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label monstertakedamage;
        private System.Windows.Forms.Label pokemontakedamage;
    }
}