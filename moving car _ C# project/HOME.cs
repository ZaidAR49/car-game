using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using GAME;
namespace UNIGAME
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // الخروج من البرنامج
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();  
            
            
        }
          //عمل فنكشين يستدعي مكتبة soundplayerحتى نضيف صوت 
        public void Sound(string s)
        {
            SoundPlayer player = new SoundPlayer(@s);
            player.Play();
        }
        //استدعاءالفنشكين اللي عملناه لحتى ينضاف صوت بس نعمل كليك ع الزر
        private void button1_Click(object sender, EventArgs e)
        {
            Sound("button.wav");
           NGAME ngame=new NGAME();
             ngame.Show();
            this.Visible = false;
        }

        private void currentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ChooseLevel c=new ChooseLevel();
            //c.Show();
            //this.Visible = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           NGAME ngame=new NGAME();
            ngame.Show();
            this.Visible = false;
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fname f=new Fname();
            f.Show();
            this.Visible = false;
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void historyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Visible = false;
        }
    }
}
