using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAME;
using lvl_2;
using moving_car___C__project;


namespace GAME
{
    public partial class ChooseLevel : Form
    {
        public ChooseLevel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sound("button.wav");
           Level1 l1=new Level1();
            l1.Show();
            this.Visible = false;
        }
        public void Sound(string s)
        {
            SoundPlayer player = new SoundPlayer(@s);
            //player.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            level2 level2 = new level2();
            level2.Show();
            this.Visible = false;
            Sound("button.wav");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Level3 l3 = new Level3();
            l3.Show();
            this.Visible = false;
            Sound("button.wav");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NGAME ngame = new NGAME();
            ngame.Show();
            this.Visible = false;
        }

        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fname fname=new Fname();
            fname.Show();
            this.Visible=false;
        }

        private void currentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //History c=new History();
            //c.Show();
            //this.Visible=false;
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Visible = false;
        }
    }
}
