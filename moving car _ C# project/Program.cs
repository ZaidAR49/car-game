using GAME;
using lvl_2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIGAME;
using WMPLib;
using static moving_car___C__project.Level1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace moving_car___C__project
{
    internal static class Program 
    {
        public static List<profclass> stdList = new List<profclass>();
        
        public static bool Computer_playing = false;
        public static  string obj="",p1,p2,g1="fmale", g2="fmale";
        public static int L, S, M, s1, s2, w1, w2,age1,age2;
        
        public static void change_Image(string o, PictureBox YR, PictureBox YL, PictureBox YU, PictureBox YD, PictureBox RR, PictureBox RL, PictureBox RU, PictureBox RD)
        {
            if (o == "ball")
            {
                Image i1 = (Image)Properties.Resources.ball;
                Image i2 = (Image)Properties.Resources.ball2;
                YR.Image = i1;
                YR.Size = new Size(30, 30);
                YL.Image = i1;
                YL.Size = new Size(30, 30);
                YU.Image = i1;
                YU.Size = new Size(30, 30);
                YD.Image = i1;
                YD.Size = new Size(30, 30);
                ////////////////////////////////////////// player2
                RR.Image = i2;
                RR.Size = new Size(30, 30);
                RL.Image = i2;
                RL.Size = new Size(30, 30);
                RU.Image = i2;
                RU.Size = new Size(30, 30);
                RD.Image = i2;
                RD.Size = new Size(30, 30);
            }
            if (o == "Rat")
            {
                /////////////////player 1
                Image R1 = (Image)Properties.Resources.Rat_R;
                Image L1 = (Image)Properties.Resources.Rat_L;
                Image U1 = (Image)Properties.Resources.Rat_U;
                Image D1 = (Image)Properties.Resources.Rat_D;

                YR.Image = L1;
                YL.Image = R1;
                YU.Image = U1;
                YD.Image = D1;
                /////////////////////////////////player2

                Image R2 = (Image)Properties.Resources.Rat2_R;
                Image L2 = (Image)Properties.Resources.Rat2_L;
                Image U2 = (Image)Properties.Resources.Rat2_U;
                Image D2 = (Image)Properties.Resources.Rat2_D;

                RR.Image = R2;
                RL.Image = L2;
                RU.Image = U2;
                RD.Image = D2;

            }

        }
        public static string The_Winner_Is(PictureBox p1, PictureBox p2,PictureBox finsh)
        {
           
            if (p1.Bounds.IntersectsWith(finsh.Bounds))
            {
                s1 = Program.S;
            }
            if (p2.Bounds.IntersectsWith(finsh.Bounds))
            {
                s2 = Program.S;
            }
            /////the winner is 
            if (s1 > s2)
                return Program.p1;
            else if (s2 > s1)
                return Program.p2;
            else
                return "Draw";
        }
        public static  int speed1 = 35;
        public static int speed2 = 35; 
        public static int speed = 35;
        public static void Key_Up(Player_Play pp1,Player_Play pp2,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                pp1.PlayerMoving_right = false;
            if (e.KeyCode == Keys.Left)
                pp1.PlayerMoving_left = false;
            if (e.KeyCode == Keys.Up)
                pp1.PlayerMoving_up = false;
            if (e.KeyCode == Keys.Down)
                pp1.PlayerMoving_down = false;
            ////////////////////////////////////player2/////////////
            if (e.KeyCode == Keys.D)
                pp2.PlayerMoving_right = false;
            if (e.KeyCode == Keys.A)
                pp2.PlayerMoving_left = false;
            if (e.KeyCode == Keys.W)
                pp2.PlayerMoving_up = false;
            if (e.KeyCode == Keys.S)
                pp2.PlayerMoving_down = false;
        }



        public static void  Key_Down(Player_Play pp1,Player_Play pp2,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
            /////////////////////////////////////////player#1
            if (e.KeyCode == Keys.Right)
                pp1.PlayerMoving_right = true;
            if (e.KeyCode == Keys.Left)
                pp1.PlayerMoving_left = true;
            if (e.KeyCode == Keys.Up)
                pp1.PlayerMoving_up = true;
            if (e.KeyCode == Keys.Down)
                pp1.PlayerMoving_down = true;
            //////////////////////////////////////player#2

            if (e.KeyCode == Keys.D)
                pp2.PlayerMoving_right = true;
            if (e.KeyCode == Keys.A)
                pp2.PlayerMoving_left = true;
            if (e.KeyCode == Keys.W)
                pp2.PlayerMoving_up = true;
            if (e.KeyCode == Keys.S)
                pp2.PlayerMoving_down = true;
        }
        public static void Coinsc() {
       
        
        
        }
        
        public static  void Sounds(string s, int v=50)
        {
            WindowsMediaPlayer Sound = new WindowsMediaPlayer();
            Sound.URL = s;
            Sound.settings.volume = v;
            Sound.controls.play();
        }
        public static  void Change_location(int x, int y, PictureBox R, PictureBox L, PictureBox U, PictureBox D)
        {
            R.Location = new Point(x, y);
            L.Location = new Point(x, y);
            U.Location = new Point(x, y);
            D.Location = new Point(x, y);


        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HOME());
        }
    }
}
