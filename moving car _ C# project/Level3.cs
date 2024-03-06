using GAME;
using lvl_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static moving_car___C__project.Level1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace moving_car___C__project
{
    public partial class Level3 : Form
    {
        public Level3()
        {
            InitializeComponent();
        }
        string w;
        Player_Play p1= new Player_Play();
        Player_Play p2 = new Player_Play();
        playerinfo pi1 = new playerinfo();
        playerinfo pi2 = new playerinfo();
        int collectioncoins1 = 0, collectioncoins2 = 0;//Counter For Coins
        int score1 = 0, score2 = 0;
        int speed1 = 35, speed2 = 35;
        int ttikc1, ttick2, btick, btick2, ctick, ctick2, barriertick1, barriertick2;

        private void level3cs_Load(object sender, EventArgs e)

        {
           
            Program.Sounds("bs.mp3", 0);
            Program.change_Image(Program.obj, Y_Car, Y_CarL, Y_CarU, Y_CarD, R_Car, R_CarL, R_CarU, R_CarD);
            
        }

        private void Start_Again_Click(object sender, EventArgs e)
        {
            playerinfo.p1coins3 = 0;
            playerinfo.p1scores3 = 0;
            playerinfo.p2coins3 = 0;
            playerinfo.p2scores3 = 0;
            Time_label.Visible = true;
            label1.Text = "P1 Coins:0";
            label2.Text = "P1 Score:0";
            label3.Text = "P1 Speed:0";
            label4.Text = "P2 Coins:0";
            label5.Text = "P2 Score:0";
            label6.Text = "P2 Speed:0"; 
            Program.Sounds("start.mp3", 100);
            Program.s1 = 0;
            Program.s2 = 0;
            Program.w1 = 0;
            Program.w2 = 0;
            Program.L = 0;
            Program.S = 0;
            Program.M = 0;
            if (Program.S >= 3)
            {
                ////////////////////////////////////////////////////// copmuter plying
                if (Program.Computer_playing)
                    computer.Enabled = true;
                else
                    timer1.Enabled = true;
                ////////////////////////////////////////////////////////
                timer2.Enabled = true;
            }
            winner.Enabled = true;
            timer_level3.Enabled = true;
            Program.Change_location(trick1.Location.X, trick1.Location.Y, Y_Car, Y_CarL, Y_CarU, Y_CarD);
            Program.Change_location(trick2.Location.X, trick2.Location.Y, R_Car, R_CarL, R_CarU, R_CarD);
        }

        private void Y_CarU_Click(object sender, EventArgs e)
        {

        }
        public void moving1(Player_Play P,PictureBox R,PictureBox L,PictureBox U,PictureBox D)
        {
            if(R.Bounds.IntersectsWith(HiddenFinish.Bounds))
            {
               
                Program.Change_location(trick1.Location.X, trick1.Location.Y, R, L, U, D);
            }
            if (P.PlayerMoving_right && !R.Bounds.IntersectsWith(pictureBox11.Bounds) && !R.Bounds.IntersectsWith(pictureBox9.Bounds) && !R.Bounds.IntersectsWith(pictureBox13.Bounds) && !R.Bounds.IntersectsWith(pictureBox15.Bounds) && !R.Bounds.IntersectsWith(street3.Bounds) && !R.Bounds.IntersectsWith(street7.Bounds)&&!R.Bounds.IntersectsWith(Left.Bounds))//Moving Right
            {
                R.Visible = true;
                L.Visible = false;
                U.Visible = false;
                D.Visible = false;
                R.Left += Program.speed1;
                L.Left += Program.speed1;
                D.Left += Program.speed1;
                U.Left += Program.speed1;
                pi1.sumscorep1level3(Y_CarL, label2);
                label3.Text = "Speed : " + Program.speed1;
            }
            if (P.PlayerMoving_left && !L.Bounds.IntersectsWith(pictureBox10.Bounds) && !L.Bounds.IntersectsWith(pictureBox12.Bounds) && !L.Bounds.IntersectsWith(pictureBox14.Bounds) && !L.Bounds.IntersectsWith(pictureBox11.Bounds) && !L.Bounds.IntersectsWith(street1.Bounds) && !L.Bounds.IntersectsWith(street9.Bounds) && !L.Bounds.IntersectsWith(street5.Bounds)&&!L.Bounds.IntersectsWith(Right.Bounds))// Moving Left
            {
                R.Visible = false;
                L.Visible = true;
                U.Visible = false;
                D.Visible = false;
                R.Left -= Program.speed1;
                L.Left -= Program.speed1;
                D.Left -= Program.speed1;
                U.Left -= Program.speed1;
                pi1.sumscorep1level3(Y_CarL, label2);
                label3.Text = "Speed : " + Program.speed1;
            }
            if (P.PlayerMoving_up && !U.Bounds.IntersectsWith(pictureBox7.Bounds) && !U.Bounds.IntersectsWith(pictureBox2.Bounds) && !U.Bounds.IntersectsWith(pictureBox1.Bounds) && !U.Bounds.IntersectsWith(pictureBox5.Bounds) && !U.Bounds.IntersectsWith(street8.Bounds) && !U.Bounds.IntersectsWith(street6.Bounds))// Moving up
            {
                R.Visible = false;
                L.Visible = false;
                U.Visible = true;
                D.Visible = false;
                R.Top -= Program.speed1;
                L.Top -= Program.speed1;
                D.Top -= Program.speed1;
                U.Top -= Program.speed1;
                pi1.sumscorep1level3(Y_CarL, label2);
                label3.Text = "Speed : " + Program.speed1;
            }
            if (P.PlayerMoving_down && !D.Bounds.IntersectsWith(pictureBox8.Bounds) && !D.Bounds.IntersectsWith(pictureBox6.Bounds) && !D.Bounds.IntersectsWith(pictureBox3.Bounds) && !D.Bounds.IntersectsWith(pictureBox4.Bounds) && !D.Bounds.IntersectsWith(street2.Bounds) && !D.Bounds.IntersectsWith(street4.Bounds))// Moving down
            {
                R.Visible = false;
                L.Visible = false;
                U.Visible = false;
                D.Visible = true;
                R.Top += Program.speed1;
                L.Top += Program.speed1;
                D.Top += Program.speed1;
                U.Top += Program.speed1;
                pi1.sumscorep1level3(Y_CarL, label2);
                label3.Text = "Speed : " + speed1;
            }
        }
        public void moving2(Player_Play P, PictureBox R, PictureBox L, PictureBox U, PictureBox D)
        {
            if (R.Bounds.IntersectsWith(HiddenFinish.Bounds))
            {

                Program.Change_location(trick2.Location.X, trick2.Location.Y, R, L, U, D);
            }
            if (P.PlayerMoving_right && !R.Bounds.IntersectsWith(pictureBox11.Bounds) && !R.Bounds.IntersectsWith(pictureBox9.Bounds) && !R.Bounds.IntersectsWith(pictureBox13.Bounds) && !R.Bounds.IntersectsWith(pictureBox15.Bounds) && !R.Bounds.IntersectsWith(street3.Bounds) && !R.Bounds.IntersectsWith(street7.Bounds) && !R.Bounds.IntersectsWith(Left.Bounds))//Moving Right
            {
                R.Visible = true;
                L.Visible = false;
                U.Visible = false;
                D.Visible = false;
                R.Left += Program.speed2;
                L.Left += Program.speed2;
                D.Left += Program.speed2;
                U.Left += Program.speed2;
                pi2.sumscorep2level2(R_CarL, label5);
                label6.Text = "Speed : " + Program.speed2;
            }
            if (P.PlayerMoving_left && !L.Bounds.IntersectsWith(pictureBox10.Bounds) && !L.Bounds.IntersectsWith(pictureBox12.Bounds) && !L.Bounds.IntersectsWith(pictureBox14.Bounds) && !L.Bounds.IntersectsWith(pictureBox11.Bounds) && !L.Bounds.IntersectsWith(street1.Bounds) && !L.Bounds.IntersectsWith(street9.Bounds) && !L.Bounds.IntersectsWith(street5.Bounds) && !L.Bounds.IntersectsWith(Right.Bounds))// Moving Left
            {
                R.Visible = false;
                L.Visible = true;
                U.Visible = false;
                D.Visible = false;
                R.Left -= Program.speed2;
                L.Left -= Program.speed2;
                D.Left -= Program.speed2;
                U.Left -= Program.speed2;
                pi2.sumscorep2level2(R_CarL, label5);
                label6.Text = "Speed : " + Program.speed2;
            }
            if (P.PlayerMoving_up && !U.Bounds.IntersectsWith(pictureBox7.Bounds) && !U.Bounds.IntersectsWith(pictureBox2.Bounds) && !U.Bounds.IntersectsWith(pictureBox1.Bounds) && !U.Bounds.IntersectsWith(pictureBox5.Bounds) && !U.Bounds.IntersectsWith(street8.Bounds) && !U.Bounds.IntersectsWith(street6.Bounds))// Moving up
            {
                R.Visible = false;
                L.Visible = false;
                U.Visible = true;
                D.Visible = false;
                R.Top -= Program.speed2;
                L.Top -= Program.speed2;
                D.Top -= Program.speed2;
                U.Top -= Program.speed2;
                pi2.sumscorep2level2(R_CarL, label5);
                label6.Text = "Speed : " + Program.speed2;
            }
            if (P.PlayerMoving_down && !D.Bounds.IntersectsWith(pictureBox8.Bounds) && !D.Bounds.IntersectsWith(pictureBox6.Bounds) && !D.Bounds.IntersectsWith(pictureBox3.Bounds) && !D.Bounds.IntersectsWith(pictureBox4.Bounds) && !D.Bounds.IntersectsWith(street2.Bounds) && !D.Bounds.IntersectsWith(street4.Bounds))// Moving down
            {
                R.Visible = false;
                L.Visible = false;
                U.Visible = false;
                D.Visible = true;
                R.Top += Program.speed2;
                L.Top += Program.speed2;
                D.Top += Program.speed2;
                U.Top += Program.speed2;
                pi2.sumscorep2level2(R_CarL, label5);
                label6.Text = "Speed : " + Program.speed2;
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Program.Sounds("click.mp3", 50);
            ChooseLevel ch = new ChooseLevel();
            ch.Show();
            this.Visible = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Program.Sounds("click.mp3", 50);
            Application.Exit();
        }

        private void street1_Click(object sender, EventArgs e)
        {

        }

        private void computer_Tick(object sender, EventArgs e)
        {
            p1.d_moving3(Y_Car,Y_CarL,Y_CarU,Y_CarD);
            collectcoin1();
            turbcom();
            banancom();
            Carcollision();//For CarCollision Y_Car
                          barrier();//For Barrier Y_Car &&R_Car
        }

        private void picturBox7_Click(object sender, EventArgs e)
        {

        }

        private void timer_level3_Tick(object sender, EventArgs e)
        {
            Program.L++;
            if (Program.L == 99)
            {
                Program.L = 0;
                Program.S++;
            }
            if (Program.S == 60)
            {
                Program.S = 0;
                Program.M++;
            }
            Time_label.Text = $"{Program.M}: {Program.S}: {Program.L}";
            // when the timer = 3
            if (Program.S >= 3)
            {
                //////////////////////////////////////////////////////// copmuter plying
                if (Program.Computer_playing)
                    computer.Enabled = true;
                else
                   timer1.Enabled = true;
                ////////////////////////////////////////////////////////
                timer2.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                computer.Enabled = false;
            }
        }

        private void Timer_Click(object sender, EventArgs e)
        {

        }

        private void R_CarL_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void winner_Tick(object sender, EventArgs e)
        {
            w = $"So far the winner is😎\n {Program.The_Winner_Is(Y_CarD, R_CarD, Finish3)}";
            Result.Text = w;
            if (w != "not yet" && w != null)
            {
                if (w == "Plyer#1")
                    Program.w1++;
                else if (w == "Player#2")
                    Program.w2++;
            }
            if (Program.S == 35)
            {
                winner.Stop();
                timer_level3.Stop();
                timer1.Stop();
                timer2.Stop();
                computer.Stop();
                Program.Sounds( "Breaktime.mp3");
                Time_label.Visible = false;
                if (Program.w1 > Program.w2)
                    w = "The winner is\nPlyer#1 🎉🎊";
                else if (Program.w1 < Program.w2)
                    w = "The winner is\n Plyer#2 🎉🎊";
                else w = "✌️Draw✌️";

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moving1(p1, Y_Car,Y_CarL,Y_CarU,Y_CarD);  //Y_player 1
            collectcoin1();//For Collect Coin Y_Car
            turbo1();// For Turbo Y_Car
            banana01();//For Turbo Y_Car
            Carcollision();//For CarCollision Y_Car
          barrier();//For Barrier Y_Car &&R_Car
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Level3_KeyDown(object sender, KeyEventArgs e)
        {
            Program.Key_Down(p1, p2, e);
        }

        private void Level3_KeyUp(object sender, KeyEventArgs e)
        {
            Program.Key_Up(p1, p2, e);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            moving2(p2,R_Car,R_CarL,R_CarU,R_CarD);//R_Player 2
            collectcoin2();//For Collect Coins Y_Car
            turbo2();// Turbo For R_Car
            banana02();//Banana FOr R_Car
            Carcollision();
           // barrier();//For Barrier Y_Car &&R_Car
        }
        void Carcollision()
        {
            if (Y_Car.Bounds.IntersectsWith(R_CarL.Bounds))
            {
              Program.speed1 = 35;
                Program.speed2 = 35;

                carcollisiontimer.Enabled = true;
                Program.speed1 = 35;
                Program.speed2 = 35;
            }
            if (R_Car.Bounds.IntersectsWith(Y_Car.Bounds))
            {
                Program.speed1 = 35;
                Program.speed2 = 35;
                carcollisiontimer2.Enabled = true;
                Program.speed1 = 35;
                Program.speed2 = 35;
            }
        }
        Random r2 = new Random();

        //bananaaaaaaaaaaaaaaaa
        int x2, y2;

        private void turbotimer2_Tick(object sender, EventArgs e)
        {
            ttick2++;

            if (ttick2 != 20)
            {
                while (Program.speed2 < 60)
                {
                    Program.speed2++;
                }
            }
            else
            {
                ttick2 = 0;
                turbotimer2.Stop();
            }
        }

        private void barriertimer_Tick(object sender, EventArgs e)
        {
            barriertick1++;
            if (barriertick1 != 10)
            {
                while (Program.speed1 > 27)
                {
                    Program.speed1--;

                }
            }
            else
            {
                barriertimer.Stop();

                barriertick1 = 0;
            }

        }

        private void barriertimer2_Tick(object sender, EventArgs e)
        {
            barriertick2++;
            if (barriertick2 != 10)
            {
                while (Program.speed2 > 27)
                {
                    Program.speed2--;

                }
            }
            else
            {
                barriertimer2.Stop();

                barriertick2 = 0;
            }
        }

        private void bananatimer_Tick(object sender, EventArgs e)
        {
            btick++;
            if (btick != 20)
            {
                while (Program.speed1 > 20)
                {
                    Program.speed1--;

                }
            }
            else
            {
                btick = 0;
                bananatimer.Stop();
            }

        }

        private void bananatimer2_Tick(object sender, EventArgs e)
        {
            btick2++;
            if (btick2 != 20)
            {
                while (Program.speed2 > 20)
                {
                    Program.speed2--;

                }
            }
            else
            {
                bananatimer2.Stop();

                btick2 = 0;
            }
        }

        private void carcollisiontimer_Tick(object sender, EventArgs e)
        {
            ctick++;
            if (ctick != 10)
            {
                while (Program.speed2 > 27 && speed1 > 27)
                {
                    Program.speed1--;
                    Program.speed2--;

                }
            }
            else
            {
                Program.speed1 = 35;
                Program.speed2 = 35;
                ctick = 0;
                carcollisiontimer.Stop();
            }
        }

        private void carcollisiontimer2_Tick(object sender, EventArgs e)
        {
            ctick2++;
            if (ctick2 != 27)
            {
                while (Program.speed2 > 27 && speed1 > 27)
                {
                    Program.speed1--;
                    Program.speed2--;

                }
            }
            else
            {
                Program.speed1 = 35;
                Program.speed2 = 35;
                ctick2 = 0;
                carcollisiontimer2.Stop();
            }
        }

        private void coin8_Click(object sender, EventArgs e)
        {

        }

        private void turbotimer1_Tick(object sender, EventArgs e)
        {
            ttikc1++;

            if (ttikc1 != 20)
            {
                while (Program.speed1< 60)

                {
                Program.speed1++;
                }
            }
            else
            {
                ttikc1 = 0;
                turbotimer1.Stop();
            }

        }
        void turbcom()
        {
            Program.speed = 35;
            if (Y_Car.Bounds.IntersectsWith(turbo01.Bounds))
            {
                bananacom.Enabled = false;
                x1 = r1.Next(600, 650);
                turbo01.Location = new Point(x1, 300);
                turbocom.Enabled = true;
            }
            int t1x1 = turbo01.Location.X;
            int t1y1 = turbo01.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(turbo01.Bounds) && t1x1 == turbo01.Location.X && t1y1 == turbo01.Location.Y)
            {
                bananacom.Enabled = false;
                turbo01.Location = new Point(310, 450);
                turbocom.Enabled = true;

            }
            if (Y_Car.Bounds.IntersectsWith(turbo02.Bounds))
            {
                bananacom.Enabled = false;
                x1 = r1.Next(100, 130);
                turbo02.Location = new Point(x1, 200);
                turbocom.Enabled = true;
            }
            int t1x2 = turbo02.Location.X;
            int t1y2 = turbo02.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(turbo02.Bounds) && t1x2 == turbo02.Location.X && t1y2 == turbo02.Location.Y)
            {
                bananacom.Enabled = false;
                turbo02.Location = new Point(450, 45);
                turbocom.Enabled = true;


            }
        }
        private void turbocom_Tick(object sender, EventArgs e)
        {
            ttikc1++;

            if (ttikc1 != 20)
            {
                while (Program.speed1 < 60)

                {
                    Program.speed1++;
                }
            }
            else
            {
                ttikc1 = 0;
                turbotimer1.Stop();
            }
        }
        void banancom()
        {
            if (Y_Car.Bounds.IntersectsWith(banana1.Bounds))
            {
                turbocom.Enabled = false;
                Program.speed = 35;
                //    y2 = r2.Next(300, 320);
                banana1.Location = new Point(700, 39);
                bananacom.Enabled = true;

            }
            int b1x1 = banana1.Location.X;
            int b1y1 = banana1.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(banana1.Bounds) && banana1.Location.X == b1x1 && banana1.Location.Y == b1y1)
            {
                turbocom.Enabled = false;
                Program.speed = 35;
                x2 = r2.Next(200, 310);
                banana1.Location = new Point(x2, 110);
                bananacom.Enabled = true;
            }
            if (Y_Car.Bounds.IntersectsWith(banana2.Bounds))
            {
                turbocom.Enabled = false;
                Program.speed = 35;
                x2 = r2.Next(225, 250);
                banana2.Location = new Point(x2, 470);
                bananacom.Enabled = true;

            }
            int b1x2 = banana2.Location.X;
            int b1y2 = banana2.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(banana2.Bounds) && banana2.Location.X == b1x2 && banana2.Location.Y == b1y2)
            {
                turbocom.Enabled = false;
                Program.speed = 35;
                x2 = r2.Next(650, 750);
                banana2.Location = new Point(x2, 300);
                bananacom.Enabled = true;

            }
        }
        private void bananacom_Tick(object sender, EventArgs e)
        {
            btick++;
            if (btick != 20)
            {
                while (Program.speed > 20)
                {
                    Program.speed--;

                }
            }
            else
            {
                btick = 0;
                bananatimer.Stop();
            }
        }

        void barrier()
        {
            if (Y_Car.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                Program.speed1 = 35;
                barriertimer.Enabled = true;
                Program.speed1 = 35;

            }
            if (Y_Car.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                Program.speed1 = 35;
                barriertimer.Enabled = true;
                Program.speed1 = 35;


            }
            if (Y_Car.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                Program.speed1 = 35;
                barriertimer.Enabled = true;
                Program.speed1 = 35;


            }
            if (Y_Car.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                Program.speed1 = 35;
                barriertimer.Enabled = true;
                Program.speed1 = 35;


            }
            if (Y_Car.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                Program.speed1 = 35;
                barriertimer.Enabled = true;
                Program.speed1 = 35;


            }
            if (Y_Car.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                Program.speed1 = 35;
                barriertimer.Enabled = true;
                Program.speed1 = 35;


            }
            if (Y_Car.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                Program.speed1 = 35;
                barriertimer.Enabled = true;
                Program.speed1 = 35;


            }
            if (R_Car.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                Program.speed2 = 35;
                barriertimer2.Enabled = true;
                Program.speed2 = 35;

            }
            if (R_Car.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                Program.speed2 = 35;
                barriertimer2.Enabled = true;
                Program.speed2 = 35;

            }
            if (R_Car.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                Program.speed2 = 35;
                barriertimer2.Enabled = true;
                Program.speed2 = 35;

            }
            if (R_Car.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                Program.speed2 = 35;
                barriertimer2.Enabled = true;
                Program.speed2 = 35;

            }
            if (R_Car.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                Program.speed2 = 35;
                barriertimer2.Enabled = true;
                Program.speed2 = 35;

            }
            if (R_Car.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                Program.speed2 = 35;
                barriertimer2.Enabled = true;
                Program.speed2 = 35;

            }
            if (R_Car.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                Program.speed2 = 35;
                barriertimer2.Enabled = true;
                Program.speed2 = 35;

            }
        }
        void banana01()//Banana Function For Y_Car 
        {
            if (Y_Car.Bounds.IntersectsWith(banana1.Bounds))
            {
                turbotimer1.Enabled = false;
                Program.speed1 = 35;
                //    y2 = r2.Next(300, 320);
                banana1.Location = new Point(700, 39);
                bananatimer.Enabled = true;

            }
            int b1x1 = banana1.Location.X;
            int b1y1 = banana1.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(banana1.Bounds) && banana1.Location.X == b1x1 && banana1.Location.Y == b1y1)
            {
                turbotimer1.Enabled = false;
                Program.speed1 = 35;
                x2 = r2.Next(200, 310);
                banana1.Location = new Point(x2, 110);
                bananatimer.Enabled = true;
            }
            if (Y_Car.Bounds.IntersectsWith(banana2.Bounds))
            {
                turbotimer1.Enabled = false;
                Program.speed1 = 35;
                x2 = r2.Next(225, 250);
                banana2.Location = new Point(x2, 470);
                bananatimer.Enabled = true;

            }
            int b1x2 = banana2.Location.X;
            int b1y2 = banana2.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(banana2.Bounds) && banana2.Location.X == b1x2 && banana2.Location.Y == b1y2)
            {
                turbotimer1.Enabled = false;
                Program.speed1 = 35;
                x2 = r2.Next(650, 750);
                banana2.Location = new Point(x2, 300);
                bananatimer.Enabled = true;

            }
        }
        void banana02()//Banana Function For R_Car 
        {
            if (R_Car.Bounds.IntersectsWith(banana1.Bounds))
            {
                turbotimer2.Enabled = false;
                Program.speed2 = 35;
                //y2 = r2.Next(300, 320);
                banana1.Location = new Point(700, 39);
                bananatimer2.Enabled = true;

            }
            int b2x1 = banana1.Location.X;
            int b2y1 = banana1.Location.Y;
            if (R_Car.Bounds.IntersectsWith(banana1.Bounds) && banana1.Location.X == b2x1 && banana1.Location.Y == b2y1)
            {
                turbotimer2.Enabled = false;
                Program.speed2 = 35;
                x2 = r2.Next(200, 310);
                banana1.Location = new Point(x2, 110);
                bananatimer2.Enabled = true;
            }
            if (R_Car.Bounds.IntersectsWith(banana2.Bounds))
            {
                turbotimer2.Enabled = false;
                Program.speed2 = 35;
                x2 = r2.Next(225, 250);
                banana2.Location = new Point(x2, 470);
                bananatimer2.Enabled = true;

            }
            int b2x2 = banana2.Location.X;
            int b2y2 = banana2.Location.Y;
            if (R_Car.Bounds.IntersectsWith(banana2.Bounds) && banana2.Location.X == b2x2 && banana2.Location.Y == b2y2)
            {
                turbotimer2.Enabled = false;
                Program.speed2 = 35;
                x2 = r2.Next(650, 750);
                banana2.Location = new Point(x2, 300);
                bananatimer2.Enabled = true;
            }

        }

        int x1, y1;//For Turbo Functions
        Random r1 = new Random();
        void turbo1()//Turbo For Y_Car 
        {
            Program.speed1 = 35;
            if (Y_Car.Bounds.IntersectsWith(turbo01.Bounds))
            {
                bananatimer.Enabled = false;
                x1 = r1.Next(600, 650);
                turbo01.Location = new Point(x1, 300);
                turbotimer1.Enabled = true;
            }
            int t1x1 = turbo01.Location.X;
            int t1y1 = turbo01.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(turbo01.Bounds) && t1x1 == turbo01.Location.X && t1y1 == turbo01.Location.Y)
            {
                bananatimer.Enabled = false;
                turbo01.Location = new Point(310, 450);
                turbotimer1.Enabled = true;

            }
            if (Y_Car.Bounds.IntersectsWith(turbo02.Bounds))
            {
                bananatimer.Enabled = false;
                x1 = r1.Next(100, 130);
                turbo02.Location = new Point(x1, 200);
                turbotimer1.Enabled = true;
            }
            int t1x2 = turbo02.Location.X;
            int t1y2 = turbo02.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(turbo02.Bounds) && t1x2 == turbo02.Location.X && t1y2 == turbo02.Location.Y)
            {
                bananatimer.Enabled = false;
                turbo02.Location = new Point(450, 45);
                turbotimer1.Enabled = true;

            }
        }
        void turbo2()//Turbo For R_Car
        {
            Program.speed2 = 35;
            if (R_Car.Bounds.IntersectsWith(turbo01.Bounds))
            {
                bananatimer2.Enabled = false;
                x1 = r1.Next(600, 650);
                turbo01.Location = new Point(x1, 300);
                turbotimer2.Enabled = true;
            }
            int t2x1 = turbo01.Location.X;
            int t2y1 = turbo01.Location.Y;
            if (R_Car.Bounds.IntersectsWith(turbo01.Bounds) && t2x1 == turbo01.Location.X && t2y1 == turbo01.Location.Y)
            {
                bananatimer2.Enabled = false;
                turbo01.Location = new Point(310, 450);
                turbotimer2.Enabled = true;

            }
            if (R_Car.Bounds.IntersectsWith(turbo02.Bounds))
            {
                bananatimer2.Enabled = false;
                x1 = r1.Next(100, 130);
                turbo02.Location = new Point(x1, 200);
                turbotimer2.Enabled = true;
            }
            int t2x2 = turbo02.Location.X;
            int t2y2 = turbo02.Location.Y;
            if (R_Car.Bounds.IntersectsWith(turbo02.Bounds) && t2x2 == turbo02.Location.X && t2y2 == turbo02.Location.Y)
            {
                bananatimer2.Enabled = false;
                turbo02.Location = new Point(450, 45);
                turbotimer2.Enabled = true;

            }
        }
        // For CollctCoin Function
        int x, y;
        Random r = new Random();

        void collectcoin2() // Collect Coin Function For R_Car
        {

            if (R_Car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectioncoins1++;
                pi2.sumcoinp2level3(R_Car, coin1, label4);
                x = r.Next(350, 420);
                coin1.Location = new Point(x, 60);
            }
            int pxcoin1 = coin1.Location.X;
            int pycoin1 = coin1.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin1.Bounds) && coin1.Location.X == pxcoin1 && coin1.Location.Y == pycoin1)
            {
                collectioncoins1++;
                x = r.Next(700, 750);
                y = r.Next(300, 350);
                coin1.Location = new Point(x, y);
                pi2.sumcoinp2level3(R_Car, coin1, label4);
            }

            if (R_Car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectioncoins1++;
                pi2.sumcoinp2level3(R_Car, coin2, label4);

                x = r.Next(400, 450);
                y = r.Next(60, 120);
                coin2.Location = new Point(x, y);
            }
            int pxcoin2 = coin2.Location.X;
            int pycoin2 = coin2.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin2.Bounds) && coin2.Location.X == pxcoin2 && coin2.Location.Y == pycoin2)
            {
                collectioncoins1++;
                coin2.Location = new Point(500, 350);
                pi2.sumcoinp2level3(R_Car, coin2, label4);
            }
            if (R_Car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectioncoins1++;
                pi2.sumcoinp2level3(R_Car, coin3, label4);
                x = r.Next(650, 700);
                y = r.Next(21, 120);
                coin3.Location = new Point(x, y);
            }
            int pxcoin3 = coin3.Location.X;
            int pycoin3 = coin3.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin3.Bounds) && coin3.Location.X == pxcoin3 && coin3.Location.Y == pycoin3)
            {
                collectioncoins1++;
                coin3.Location = new Point(651, 540);
                pi2.sumcoinp2level3(R_Car, coin3, label4);
            }

            if (R_Car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectioncoins1++;
                pi2.sumcoinp2level3(R_Car, coin4, label4);
                x = r.Next(310, 319);
                y = r.Next(60, 97);
                coin4.Location = new Point(x, y);
            }
            int pxcoin4 = coin4.Location.X;
            int pycoin4 = coin4.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin4.Bounds) && coin4.Location.X == pxcoin4 && coin4.Location.Y == pycoin4)
            {
                collectioncoins1++;
                coin4.Location = new Point(350, 450);
                pi2.sumcoinp2level3(R_Car, coin4, label4);

            }
            if (R_Car.Bounds.IntersectsWith(coin5.Bounds))
            {
                collectioncoins1++;
                pi2.sumcoinp2level3(R_Car, coin5, label4);
                x = r.Next(700, 750);
                y = r.Next(500, 530);
                coin5.Location = new Point(x, y);
            }
            int pxcoin5 = coin5.Location.X;
            int pycoin5 = coin5.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin5.Bounds) && coin5.Location.X == pxcoin5 && coin5.Location.Y == pycoin5)
            {
                collectioncoins1++;
                coin5.Location = new Point(700, 300);
                pi2.sumcoinp2level3(R_Car, coin5, label4);
            }

            if (R_Car.Bounds.IntersectsWith(coin6.Bounds))
            {
                x = r.Next(80, 100);
                y = r.Next(200, 250);
                coin6.Location = new Point(48, y);
                collectioncoins1++;
                pi2.sumcoinp2level3(R_Car, coin6, label4);
            }
            int pxcoin6 = coin6.Location.X;
            int pycoin6 = coin6.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin6.Bounds) && coin6.Location.X == pxcoin6 && coin6.Location.Y == pycoin6)
            {
                collectioncoins1++;
                coin6.Location = new Point(700, 235);
                pi2.sumcoinp2level3(R_Car, coin6, label4);
            }

            if (R_Car.Bounds.IntersectsWith(coin7.Bounds))
            {
                x = r.Next(175, 200);
                y = r.Next(375, 400);
                coin7.Location = new Point(800, 350);
                collectioncoins1++;
                pi2.sumcoinp2level3(R_Car, coin7, label4);
            }
            int pxcoin7 = coin7.Location.X;
            int pycoin7 = coin7.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin7.Bounds) && coin7.Location.X == pxcoin7 && coin7.Location.Y == pycoin7)
            {
                collectioncoins1++;
                coin7.Location = new Point(600, 100);
                pi2.sumcoinp2level3(R_Car, coin7, label4);
            }


            if (R_Car.Bounds.IntersectsWith(coin8.Bounds))
            {
                x = r.Next(125, 150);
                y = r.Next(500, 550);
                coin8.Location = new Point(x, y);

                collectioncoins1++;
                pi2.sumcoinp2level3(R_Car, coin8, label4);
            }
            int pxcoin8 = coin8.Location.X;
            int pycoin8 = coin8.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin8.Bounds) && coin8.Location.X == pxcoin8 && coin8.Location.Y == pycoin8)
            {
                collectioncoins1++;
                coin8.Location = new Point(210, 40);
                pi2.sumcoinp2level3(R_Car, coin8, label4);
            }
        }
        void collectcoin1()//Collect Coin Function For Y_Car
        {
            if (Y_Car.Bounds.IntersectsWith(coin1.Bounds))
            {

                collectioncoins2++;
                x = r.Next(350, 400);
                coin1.Location = new Point(x, 60);
                pi1.sumcoinp1level3(Y_Car, coin1, label1);
            }
            int pxcoin1 = coin1.Location.X;
            int pycoin1 = coin1.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin1.Bounds) && coin1.Location.X == pxcoin1 && coin1.Location.Y == pycoin1)
            {
                collectioncoins2++;
                x = r.Next(700, 750);
                y = r.Next(300, 350);
                coin1.Location = new Point(x, y);
                pi1.sumcoinp1level3(Y_Car, coin1, label1);
            }
            if (Y_Car.Bounds.IntersectsWith(coin2.Bounds))
            {

                collectioncoins2++;
                pi1.sumcoinp1level3(Y_Car, coin2, label1);
                x = r.Next(400, 450);
                y = r.Next(60, 120);
                coin2.Location = new Point(x, y);
            }
            int pxcoin2 = coin2.Location.X;
            int pycoin2 = coin2.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin2.Bounds) && coin2.Location.X == pxcoin2 && coin2.Location.Y == pycoin2)
            {
                collectioncoins2++;
                coin2.Location = new Point(500, 350);
                pi2.sumcoinp2level2(Y_CarD, coin2, label4);

            }
            if (Y_Car.Bounds.IntersectsWith(coin3.Bounds))
            {

                collectioncoins2++;
                pi1.sumcoinp1level3(Y_Car, coin3, label1);
                x = r.Next(650, 700);
                y = r.Next(50, 100);
                coin3.Location = new Point(x, y);
            }
            int pxcoin3 = coin3.Location.X;
            int pycoin3 = coin3.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin3.Bounds) && coin3.Location.X == pxcoin3 && coin3.Location.Y == pycoin3)
            {
                collectioncoins2++;
                coin3.Location = new Point(651, 540);
                pi1.sumcoinp1level3(Y_Car, coin3, label1);
            }

            if (Y_Car.Bounds.IntersectsWith(coin4.Bounds))
            {

                collectioncoins2++;
                pi1.sumcoinp1level3(Y_Car, coin4, label1);
                x = r.Next(310, 319);
                y = r.Next(60, 97);
                coin4.Location = new Point(x, y);
            }
            int pxcoin4 = coin4.Location.X;
            int pycoin4 = coin4.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin4.Bounds) && coin4.Location.X == pxcoin4 && coin4.Location.Y == pycoin4)
            {
                collectioncoins2++;
                coin4.Location = new Point(350, 450);
                pi1.sumcoinp1level3(Y_Car, coin4, label1);
            }
            if (Y_Car.Bounds.IntersectsWith(coin5.Bounds))
            {

                collectioncoins2++;
                pi1.sumcoinp1level3(Y_Car, coin5, label1);
                x = r.Next(700, 750);
                y = r.Next(500, 530);
                coin5.Location = new Point(x, y);
            }
            int pxcoin5 = coin5.Location.X;
            int pycoin5 = coin5.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin5.Bounds) && coin5.Location.X == pxcoin5 && coin5.Location.Y == pycoin5)
            {
                collectioncoins2++;
                coin5.Location = new Point(640, 250);
                pi1.sumcoinp1level3(Y_Car, coin5, label1);
            }
            if (Y_Car.Bounds.IntersectsWith(coin6.Bounds))
            {

                collectioncoins2++;
                pi1.sumcoinp1level3(Y_Car, coin6, label1);
                x = r.Next(80, 100);
                y = r.Next(200, 250);
                coin6.Location = new Point(x, y);
            }
            int pxcoin6 = coin6.Location.X;
            int pycoin6 = coin6.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin6.Bounds) && coin6.Location.X == pxcoin6 && coin6.Location.Y == pycoin6)
            {
                collectioncoins2++;
                coin6.Location = new Point(700, 235);
                pi1.sumcoinp1level3(Y_Car, coin6, label1);
            }
            if (Y_Car.Bounds.IntersectsWith(coin7.Bounds))
            {
                x = r.Next(175, 200);
                y = r.Next(375, 400);
                coin7.Location = new Point(800, 350);

                collectioncoins2++;
                pi1.sumcoinp1level3(Y_Car, coin7, label1);
            }
            int pxcoin7 = coin7.Location.X;
            int pycoin7 = coin7.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin7.Bounds) && coin7.Location.X == pxcoin7 && coin7.Location.Y == pycoin7)
            {
                collectioncoins2++;
                coin7.Location = new Point(600, 100);
                pi1.sumcoinp1level3(Y_Car, coin7, label1);
            }

            if (Y_Car.Bounds.IntersectsWith(coin8.Bounds))
            {
                x = r.Next(125, 150);
                y = r.Next(500, 550);
                coin8.Location = new Point(x, y);

                collectioncoins2++;
                pi1.sumcoinp1level3(Y_Car, coin8, label1);
            }
            int pxcoin8 = coin8.Location.X;
            int pycoin8 = coin8.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin8.Bounds) && coin8.Location.X == pxcoin8 && coin8.Location.Y == pycoin8)
            {
                collectioncoins2++;
                coin8.Location = new Point(210, 40);
                pi1.sumcoinp1level3(Y_Car, coin8, label1);
            }
        }

    }
}
