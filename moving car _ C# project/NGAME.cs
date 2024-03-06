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
using UNIGAME;
using GAME;
using System.Runtime.InteropServices;




namespace GAME
{
    public partial class NGAME : Form
    {
        public NGAME()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // الزر exit ليطلع من البرنامج
        private void button2_Click(object sender, EventArgs e)
        {
            Sound("button.wav");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            Sound("button.wav");
           Fname prof= new Fname();
            prof.Show();
            this.Visible = false;


        }

        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {
           
        }
        public void Sound(string m)
        {
            SoundPlayer player = new SoundPlayer(@m);
            player.Play();
        }

        private void button2_MouseCaptureChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Sound("yes.wav");

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Sound("No.wav");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void currentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //History c=new History();
           // c.Show();
           // this.Visible=false;
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NGAME ngame = new NGAME();
            ngame.Show();
            this.Visible = false;
        }

        private void newProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fname fname = new Fname();
            fname.Show();
            this.Visible = false;
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Visible = false;
        }
    }
}
