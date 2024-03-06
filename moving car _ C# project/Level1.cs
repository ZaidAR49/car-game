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
using WMPLib;

namespace moving_car___C__project
{

    public partial class Level1 : Form
    {
        
        int sec1, sec2;
        string w;
       
        int collectioncoins1 = 0, collectioncoins2 = 0;//Counter For Coins
        int score1 = 0, score2 = 0;
        int speed1 = 35, speed2 = 35;
        int ttikc1, ttick2, btick, btick2, ctick, ctick2, barriertick1, barriertick2;
        int ttickcom;

        playerinfo pi1=new playerinfo();//R_CAR
        playerinfo pi2=new playerinfo();    //Y_CAR
        Player_Play pp1 = new Player_Play();
        Player_Play pp2 = new Player_Play();
          

        public void moving1(Player_Play p, PictureBox R, PictureBox L, PictureBox U, PictureBox D)
        {
            if (p.PlayerMoving_right && R.Left < 670 && !R.Bounds.IntersectsWith(TirL_I.Bounds) && !R.Bounds.IntersectsWith(streetU.Bounds))//Movig Right
            {
                R.Visible = true;
                L.Visible = false;
                U.Visible = false;
                D.Visible = false;
                R.Left += Program.speed1;
                L.Left += Program.speed1;
                D.Left += Program.speed1;
                U.Left += Program.speed1;
                pi2.sumscorep1level1(Y_CarL, label5);
                label7.Text = "Speed : " + Program.speed1;
            }

            if (p.PlayerMoving_left && R.Left > 37 && !L.Bounds.IntersectsWith(TirR_I.Bounds) && !L.Bounds.IntersectsWith(streetD.Bounds))// Moving Left
            {
                R.Visible = false;
                L.Visible = true;
                U.Visible = false;
                D.Visible = false;
                R.Left -= Program.speed1;
                L.Left -= Program.speed1;
                D.Left -= Program.speed1;
                U.Left -= Program.speed1;
                Level1 l1 = new Level1();
                pi2.sumscorep1level1(Y_CarL, label5);
                label7.Text = "Speed : " + Program.speed1;
            }

            if (p.PlayerMoving_up && U.Top > 50 && !U.Bounds.IntersectsWith(TirD_I.Bounds) && !U.Bounds.IntersectsWith(streetL.Bounds))// Moving up
            {
                R.Visible = false;
                L.Visible = false;
                U.Visible = true;
                D.Visible = false;
                R.Top -= Program.speed1;
                L.Top -= Program.speed1;
                D.Top -= Program.speed1;
                U.Top -= Program.speed1;
                pi2.sumscorep2level1(Y_CarL,label5);
                label7.Text = "Speed : " + Program.speed1;
            }
            if (p.PlayerMoving_down && D.Top < 450 && !D.Bounds.IntersectsWith(TirU_I.Bounds) && !U.Bounds.IntersectsWith(streetR.Bounds))// Moving down
            {
                R.Visible = false;
                L.Visible = false;
                U.Visible = false;
                D.Visible = true;
                R.Top += Program.speed1;
                L.Top += Program.speed1;
                D.Top += Program.speed1;
                U.Top += Program.speed1;
                pi2.sumscorep2level1(Y_CarL, label5);
                label7.Text = "Speed : " + Program.speed1;
            }
        }
        public void moving2(Player_Play p, PictureBox R, PictureBox L, PictureBox U, PictureBox D)
        {
            if (p.PlayerMoving_right && R.Left < 670 && !R.Bounds.IntersectsWith(TirL_I.Bounds) && !R.Bounds.IntersectsWith(streetU.Bounds))//Movig Right
            {
                R.Visible = true;
                L.Visible = false;
                U.Visible = false;
                D.Visible = false;
                R.Left += Program.speed2;
                L.Left += Program.speed2;
                D.Left += Program.speed2;
                U.Left += Program.speed2;
                pi1.sumscorep2level1(R_CarL, label4);
                label6.Text = "Speed :" + Program.speed2;
            }

            if (p.PlayerMoving_left && R.Left > 37 && !L.Bounds.IntersectsWith(TirR_I.Bounds) && !L.Bounds.IntersectsWith(streetD.Bounds))// Moving Left
            {
                R.Visible = false;
                L.Visible = true;
                U.Visible = false;
                D.Visible = false;
                R.Left -= Program.speed2;
                L.Left -= Program.speed2;
                D.Left -= Program.speed2;
                U.Left -= Program.speed2;
                pi1.sumscorep2level1(R_CarL, label4);
                label6.Text = "Speed :" + Program.speed2;
            }

            if (p.PlayerMoving_up && U.Top > 50 && !U.Bounds.IntersectsWith(TirD_I.Bounds) && !U.Bounds.IntersectsWith(streetL.Bounds))// Moving up
            {
                R.Visible = false;
                L.Visible = false;
                U.Visible = true;
                D.Visible = false;
                R.Top -= Program.speed2;
                L.Top -= Program.speed2;
                D.Top -= Program.speed2;
                U.Top -= Program.speed2;
                pi1.sumscorep2level1(R_CarL, label4);
                label6.Text = "Speed :" + Program.speed2;

            }
            if (p.PlayerMoving_down && D.Top < 450 && !D.Bounds.IntersectsWith(TirU_I.Bounds) && !U.Bounds.IntersectsWith(streetR.Bounds))// Moving down
            {
                R.Visible = false;
                L.Visible = false;
                U.Visible = false;
                D.Visible = true;
                R.Top += Program.speed2;
                L.Top += Program.speed2;
                D.Top += Program.speed2;
                U.Top += Program.speed2;
                pi1.sumscorep2level1(R_CarL, label4);
                label6.Text = "Speed :" + Program.speed2;
            }

        }



        //Ununderstandable 

        private void timer2_Tick(object sender, EventArgs e)
        {
            moving2(pp2, R_Car, R_CarL, R_CarU, R_CarD);

            collectcoin2();//For Collect Coins Y_Car
            turbo2();// Turbo For R_Car
            banana02();//Banana FOr R_Car
            Carcollision();
            barrier();//For Barrier Y_Car &&R_Car


        }//Player#2 Related to moving 

        public  void Y_CarL_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moving1(pp1, Y_Car, Y_CarL, Y_CarU, Y_CarD);

            collectcoin1();//For Collect Coin R_Car
            turbo1();// For Turbo Y_Car
            banana01();//For Turbo Y_Car
            Carcollision();//For CarCollision Y_Car
            barrier();//For Barrier Y_Car &&R_Car
        }// Player#1 Related to moving 

        private void coin1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int speed = 35;
        public Level1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.Sounds("bs.mp3",0);
           /* Program.Slow_down(R_Car, R_CarU);*///ununderstandable
            Program.change_Image(Program.obj,Y_Car,Y_CarL,Y_CarU,Y_CarD,R_Car,R_CarL,R_CarU,R_CarD);
           
        }//almost Done

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void coin7_Click(object sender, EventArgs e)
        {

        }

        private void coin10_Click(object sender, EventArgs e)
        {

        }
       
        private void Form1_KeyDown(object sender, KeyEventArgs e){
            
            Program.Key_Down(pp1, pp2, e);

        }//Done

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
            Program.Key_Up(pp1, pp2, e);

        }//Done

        private void TirL_I_Click(object sender, EventArgs e)//ununderstandable
        {
            //TirL_I.BackColor = Color.FromArgb(0x7092BE);
        }

        private void Screen_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//ununderstandable
        {
            //Application.Exit();
        }

        private void turbo02_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)//Done
        {
            Program.Sounds("click.mp3", 50);
            Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)//Done
        {
            Program.Sounds("click.mp3", 50);
        ChooseLevel ch=new ChooseLevel();
            ch.Show();
            this.Visible = false;
          
        }
        private void Time_label_Click(object sender, EventArgs e)
        {
            
        }

        public void TirU_I_Click(object sender, EventArgs e)
        {

        }

        public void TirR_I_Paint(object sender, PaintEventArgs e)
        {

        }

        public void TirL_I_Paint(object sender, PaintEventArgs e)
        {

        }

        public  void Y_CarD_Click(object sender, EventArgs e)
        {

        }

        public  void Y_Car_Click(object sender, EventArgs e)
        {

        }

        public  void Y_CarU_Click(object sender, EventArgs e)
        {

        }

        public  void R_CarD_Click(object sender, EventArgs e)
        {

        }

        public void R_CarU_Click(object sender, EventArgs e)
        {

        }

        public void R_Car_Click(object sender, EventArgs e)
        {

        }

        public void R_CarL_Click(object sender, EventArgs e)
        {

        }



        private void minute_Tick(object sender, EventArgs e)//this is not a method 
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
                ////////////////////////////////////////////////////// copmuter plying
                if (Program.Computer_playing)
                    computer.Enabled = true;
                else
                    timer1.Enabled = true;
                //////////////////////////////////////////////////////
                timer2.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                computer.Enabled = false;   
            }
        }

   

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            playerinfo.p1coins1 = 0;
            playerinfo.p1scores1 = 0;
            playerinfo.p2coins1 = 0;
            playerinfo.p2scores1 = 0;
            Time_label.Visible = true;
            label2.Text = "P1 Coins:0";
            label4.Text = "P1 Score:0";
            label6.Text = "P1 Speed:0";
            label3.Text = "P2 Coins:0";
            label5.Text = "P2 Score:0";
            label7.Text = "P2 Speed:0"; 
            Program.Sounds("start.mp3",100);

            Program.L = 0;
            Program.S = 0;
            Program.M = 0;
            Program.s1 = 0;
            Program.s2 = 0;
            Program.w1 = 0;
            Program.w2 = 0;

            winner.Enabled = true;
            timer_level1.Enabled = true;
            Program.Change_location(43, 416,Y_Car,Y_CarL,Y_CarU,Y_CarD);
           Program.Change_location(43, 470, R_Car, R_CarL, R_CarU, R_CarD);
       
        }

   

        void barrier()
        {
            if (Y_Car.Bounds.IntersectsWith(Screen.Bounds))
            {
                Program.speed1 = 35;
                barriertimer.Enabled = true;
                Program.speed1 = 35;

            }
            if (Y_Car.Bounds.IntersectsWith(TirD.Bounds))
            {
                Program.speed1 = 35;
                barriertimer.Enabled = true;
                Program.speed1 = 35;


            }
            if (Y_Car.Bounds.IntersectsWith(TirR.Bounds))
            {
                Program.speed1 = 35;
                barriertimer.Enabled = true;
                Program.speed1 = 35;


            }
            if (Y_Car.Bounds.IntersectsWith(TirU.Bounds))
            {
                Program.speed1 = 35;
                barriertimer.Enabled = true;
                Program.speed1 = 35;


            }
            if (Y_Car.Bounds.IntersectsWith(TirL.Bounds))
            {
                Program.speed1 = 35;
                barriertimer.Enabled = true;
                Program.speed1 = 35;


            }
            if (R_Car.Bounds.IntersectsWith(Screen.Bounds))
            {
                Program.speed2 = 35;
                barriertimer2.Enabled = true;
                Program.speed2 = 35;

            }
            if (R_Car.Bounds.IntersectsWith(TirR.Bounds))
            {
                Program.speed2 = 35;
                barriertimer2.Enabled = true;
                Program.speed2 = 35;

            }
            if (R_Car.Bounds.IntersectsWith(TirL.Bounds))
            {
                Program.speed2 = 35;
                barriertimer2.Enabled = true;
                Program.speed2 = 35;

            }
            if (R_Car.Bounds.IntersectsWith(TirD.Bounds))
            {
                Program.speed2 = 35;
                barriertimer2.Enabled = true;
                Program.speed2 = 35;

            }
            if (R_Car.Bounds.IntersectsWith(TirU.Bounds))
            {
                Program.speed2 = 35;
                barriertimer2.Enabled = true;
                Program.speed2 = 35;

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

        private void carcollisiontimer2_Tick(object sender, EventArgs e)
        {
            ctick2++;
            if (ctick2 != 27)
            {
                while (Program.speed2 > 27 && Program.speed1 > 27)
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

        void Carcollision()
        {
            if (Y_Car.Bounds.IntersectsWith(R_Car.Bounds))
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
        private void carcollisiontimer_Tick(object sender, EventArgs e)
        {
            ctick++;
            if (ctick != 10)
            {
                while (Program.speed2 > 27 && Program.speed1 > 27)
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


        int x2, y2;

      

        Random r2 = new Random();

    
        void banana01()//Banana Function For Y_Car 
        {
            if (Y_Car.Bounds.IntersectsWith(banana1.Bounds))
            {
                turbotimer1.Enabled = false;
                Program.speed1 = 35;
                y2 = r2.Next(300, 320);
                banana1.Location = new Point(25, y2);
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
                //     x2 = r2.Next(900, 950);
                banana2.Location = new Point(678, 200);
                bananatimer.Enabled = true;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void winner_Tick(object sender, EventArgs e)
        {
            w = $"So far the winner is😎\n {Program.The_Winner_Is(Y_CarD, R_CarD,finsh1)}";
            Result.Text = w;
            if (w != "not yet" && w != null)
            {
                if (w == "Plyer#1")
                    Program.w1++;
                else if (w == "Player#2")
                    Program.w2++;
            }
            if (Program.S == 20)
            {

                winner.Stop();
                timer_level1.Stop();
                timer1.Stop();
                timer2.Stop();
                computer.Stop();
                Program.Sounds("Breaktime.mp3");
                Time_label.Visible = false;
                if (Program.w1 > Program.w2)
                    w = "The winner is\nPlyer#1 🎉🎊";
                else if (Program.w1 < Program.w2)
                    w = "The winner is\n Plyer#2 🎉🎊";
                else w = "✌️Draw✌️";

            }
        }

        private void computer_Tick(object sender, EventArgs e)
        {
            pp1.d_moving1(Y_Car, Y_CarL, Y_CarU, Y_CarD);
           collectcoin2();
      //      turbo1();// For Turbo Y_Car
            turb0scom();
            bananascom();
            //banana01();//For Turbo Y_Car
            Carcollision();//For CarCollision Y_Car
            barrier();//For Barrier Y_Car &&R_Car
        }

        void banana02()//Banana Function For R_Car 
        {
            if (R_Car.Bounds.IntersectsWith(banana1.Bounds))
            {
                turbotimer2.Enabled = false;
                Program.speed2 = 35;
                y2 = r2.Next(300, 320);
                banana1.Location = new Point(25, y2);
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

                banana2.Location = new Point(678, 200);
                bananatimer2.Enabled = true;
            }

        }
        int x1co, y1co;//For Turbo Functions
        Random r1co = new Random();
        void turb0scom() {
                Program.speed = 35;
                if (Y_Car.Bounds.IntersectsWith(turbo01.Bounds))
                {
                    bananacom.Enabled = false;
                    x1co = r1co.Next(110, 120);
                    turbo01.Location = new Point(x1co, 310);
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
                    x1co = r1co.Next(610, 640);
                    turbo02.Location = new Point(x1co, 310);
                    turbocom.Enabled = true;
                }
                int t1x2 = turbo02.Location.X;
                int t1y2 = turbo02.Location.Y;
                if (Y_Car.Bounds.IntersectsWith(turbo02.Bounds) && t1x2 == turbo02.Location.X && t1y2 == turbo02.Location.Y)
                {
                    bananacom.Enabled = false;
                    turbo02.Location = new Point(250, 45);
                    turbocom.Enabled = true;

                }
            }
        
        private void turbocom_Tick(object sender, EventArgs e)
        {
            ttickcom++;

            if (ttickcom != 20)
            {
                while (Program.speed < 40)
                {
                    Program.speed++;
                }
            }
            else
            {
                ttickcom = 0;
                turbocom.Stop();
            }
        }
        void bananascom()//Banana Function For Y_Car 
        {
            if (Y_Car.Bounds.IntersectsWith(banana1.Bounds))
            {
                turbocom.Enabled = false;
                Program.speed1 = 35;
                y2 = r2.Next(300, 320);
                banana1.Location = new Point(25, y2);
                bananacom.Enabled = true;

            }
            int b1x1 = banana1.Location.X;
            int b1y1 = banana1.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(banana1.Bounds) && banana1.Location.X == b1x1 && banana1.Location.Y == b1y1)
            {
                turbocom.Enabled = false;
                Program.speed1 = 35;
                x2 = r2.Next(200, 310);
                banana1.Location = new Point(x2, 110);
                bananacom.Enabled = true;
            }
            if (Y_Car.Bounds.IntersectsWith(banana2.Bounds))
            {
                turbocom.Enabled = false;
                Program.speed1 = 35;
                x2 = r2.Next(225, 250);
                banana2.Location = new Point(x2, 470);
                bananacom.Enabled = true;

            }
            int b1x2 = banana2.Location.X;
            int b1y2 = banana2.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(banana2.Bounds) && banana2.Location.X == b1x2 && banana2.Location.Y == b1y2)
            {
                turbocom.Enabled = false;
                Program.speed1 = 35;
                //     x2 = r2.Next(900, 950);
                banana2.Location = new Point(678, 200);
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
                bananacom.Stop();
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
        int x1, y1;//For Turbo Functions
        Random r1 = new Random();
        void turbo1()//Turbo For Y_Car 
        {
            Program.speed1 = 35;
            if (Y_Car.Bounds.IntersectsWith(turbo01.Bounds))
            {
                bananatimer.Enabled = false;
                x1 = r1.Next(110, 120);
                turbo01.Location = new Point(x1, 310);
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
                x1 = r1.Next(610, 640);
                turbo02.Location = new Point(x1, 310);
                turbotimer1.Enabled = true;
            }
            int t1x2 = turbo02.Location.X;
            int t1y2 = turbo02.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(turbo02.Bounds) && t1x2 == turbo02.Location.X && t1y2 == turbo02.Location.Y)
            {
                bananatimer.Enabled = false;
                turbo02.Location = new Point(250, 45);
                turbotimer1.Enabled = true;

            }
        }
        void turbo2()//Turbo For R_Car
        {
            Program.speed2 = 35;
            if (R_Car.Bounds.IntersectsWith(turbo01.Bounds))
            {
                bananatimer2.Enabled = false;
                x1 = r1.Next(110, 120);
                turbo01.Location = new Point(x1, 310);
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
                x1 = r1.Next(610, 640);
                turbo02.Location = new Point(x1, 310);
                turbotimer2.Enabled = true;
            }
            int t2x2 = turbo02.Location.X;
            int t2y2 = turbo02.Location.Y;
            if (R_Car.Bounds.IntersectsWith(turbo02.Bounds) && t2x2 == turbo02.Location.X && t2y2 == turbo02.Location.Y)
            {
                bananatimer2.Enabled = false;
                turbo02.Location = new Point(250, 45);
                turbotimer2.Enabled = true;

            }
        }
        private void turbotimer1_Tick(object sender, EventArgs e)
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

        // For CollctCoin Function
        int x, y;
        Random r = new Random();

        void collectcoin2() // Collect Coin Function For R_Car
        {

            if (R_Car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectioncoins1++;
                pi1.sumcoinp2level1(R_CarD,coin1,label2);
                x = r.Next(350, 520);
                coin1.Location = new Point(x, 0);
            }
            int pxcoin1 = coin1.Location.X;
            int pycoin1 = coin1.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin1.Bounds) && coin1.Location.X == pxcoin1 && coin1.Location.Y == pycoin1)
            {
                collectioncoins1++;
                coin1.Location = new Point(557, 500);
                pi1.sumcoinp2level1(R_CarD, coin1, label2);

            }

            if (R_Car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectioncoins1++;
                pi1.sumcoinp2level1(R_CarD, coin2, label2);


                x = r.Next(400, 450);
                y = r.Next(60, 120);
                coin2.Location = new Point(x, y);
            }
            int pxcoin2 = coin2.Location.X;
            int pycoin2 = coin2.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin2.Bounds) && coin2.Location.X == pxcoin2 && coin2.Location.Y == pycoin2)
            {
                collectioncoins1++;
                coin2.Location = new Point(714, 425);
                pi1.sumcoinp2level1(R_CarD, coin2, label2);

            }
            if (R_Car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectioncoins1++;
                pi1.sumcoinp2level1(R_CarD, coin3, label2);
                x = r.Next(650, 700);
                y = r.Next(21, 120);
                coin3.Location = new Point(x, y);
            }
            int pxcoin3 = coin3.Location.X;
            int pycoin3 = coin3.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin3.Bounds) && coin3.Location.X == pxcoin3 && coin3.Location.Y == pycoin3)
            {
                collectioncoins1++;
                coin3.Location = new Point(275, 435);
                pi1.sumcoinp2level1(R_CarD, coin3, label2);
            }

            if (R_Car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectioncoins1++;
                pi1.sumcoinp2level1(R_CarD, coin4, label2);
                x = r.Next(310, 319);
                y = r.Next(60, 97);
                coin4.Location = new Point(x, y);
            }
            int pxcoin4 = coin4.Location.X;
            int pycoin4 = coin4.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin4.Bounds) && coin4.Location.X == pxcoin4 && coin4.Location.Y == pycoin4)
            {
                collectioncoins1++;
                coin4.Location = new Point(300, 475);
                pi1.sumcoinp2level1(R_CarD, coin4, label2);
                    
            }
            if (R_Car.Bounds.IntersectsWith(coin5.Bounds))
            {
                collectioncoins1++;
                pi1.sumcoinp2level1(R_CarD, coin5, label2);
                x = r.Next(10, 20);
                y = r.Next(320, 330);
                coin5.Location = new Point(x, y);
            }
            int pxcoin5 = coin5.Location.X;
            int pycoin5 = coin5.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin5.Bounds) && coin5.Location.X == pxcoin5 && coin5.Location.Y == pycoin5)
            {
                collectioncoins1++;
                coin5.Location = new Point(640, 250);
                pi1.sumcoinp2level1(R_CarD, coin5, label2);

            }

            if (R_Car.Bounds.IntersectsWith(coin6.Bounds))
            {
                x = r.Next(80, 100);
                y = r.Next(200, 250);
                coin6.Location = new Point(x, y);
                collectioncoins1++;
                pi1.sumcoinp2level1(R_CarD, coin6, label2);
            }
            int pxcoin6 = coin6.Location.X;
            int pycoin6 = coin6.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin6.Bounds) && coin6.Location.X == pxcoin6 && coin6.Location.Y == pycoin6)
            {
                collectioncoins1++;
                coin6.Location = new Point(700, 235);
                pi1.sumcoinp2level1(R_CarD, coin6, label2);

            }

            if (R_Car.Bounds.IntersectsWith(coin7.Bounds))
            {
                x = r.Next(400, 500);
                y = r.Next(440, 450);
                coin7.Location = new Point(x, y);
                collectioncoins1++;
                pi1.sumcoinp2level1(R_CarD, coin7, label2);
            }
            int pxcoin7 = coin7.Location.X;
            int pycoin7 = coin7.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin7.Bounds) && coin7.Location.X == pxcoin7 && coin7.Location.Y == pycoin7)
            {
                collectioncoins1++;
                coin7.Location = new Point(600, 100);
                pi1.sumcoinp2level1(R_CarD, coin7, label2);

            }


            if (R_Car.Bounds.IntersectsWith(coin8.Bounds))
            {
                x = r.Next(125, 150);
                y = r.Next(450, 475);
                coin8.Location = new Point(x, y);

                collectioncoins1++;
                pi1.sumcoinp2level1(R_CarD, coin8, label2);
            }
            int pxcoin8 = coin8.Location.X;
            int pycoin8 = coin8.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin8.Bounds) && coin8.Location.X == pxcoin8 && coin8.Location.Y == pycoin8)
            {
                collectioncoins1++;
                coin8.Location = new Point(210, 40);
                pi1.sumcoinp2level1(R_CarD, coin8, label2);

            }
            if (R_Car.Bounds.IntersectsWith(coin9.Bounds))
            {
                x = r.Next(700, 720);
                y = r.Next(320, 360);
                coin9.Location = new Point(x, y);
                collectioncoins1++;
                pi1.sumcoinp2level1(R_CarD, coin9, label2);
            }
            int pxcoin9 = coin9.Location.X;
            int pycoin9 = coin9.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin9.Bounds) && coin9.Location.X == pxcoin9 && coin9.Location.Y == pycoin9)
            {
                collectioncoins1++;
                coin9.Location = new Point(25, 267);
                pi1.sumcoinp2level1(R_CarD, coin9, label2);

            }

            if (R_Car.Bounds.IntersectsWith(coin10.Bounds))

            {
                x = r.Next(630, 665);
                y = r.Next(360, 380);
                coin10.Location = new Point(x, y);
                collectioncoins1++;
                pi1.sumcoinp2level1(R_CarD, coin10, label2);
            }
            int pxcoin10 = coin10.Location.X;
            int pycoin10 = coin10.Location.Y;
            if (R_Car.Bounds.IntersectsWith(coin10.Bounds) && coin10.Location.X == pxcoin10 && coin10.Location.Y == pycoin10)
            {
                collectioncoins1++;
                coin10.Location = new Point(120, 300);
                pi1.sumcoinp2level1(R_CarD, coin10, label2);

            }
        }
        void collectcoin1()//Collect Coin Function For Y_Car
        {
            if (Y_Car.Bounds.IntersectsWith(coin1.Bounds))
            {

                collectioncoins2++;
                x = r.Next(350, 520);
                coin1.Location = new Point(x, 0);
                pi2.sumcoinp1level1(Y_CarD, coin1, label3);
            }
            int pxcoin1 = coin1.Location.X;
            int pycoin1 = coin1.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin1.Bounds) && coin1.Location.X == pxcoin1 && coin1.Location.Y == pycoin1)
            {
                collectioncoins2++;
                coin1.Location = new Point(557, 500);
                pi2.sumcoinp1level1(Y_CarD, coin1, label3);

            }
            if (Y_Car.Bounds.IntersectsWith(coin2.Bounds))
            {

                collectioncoins2++;
                pi2.sumcoinp1level1(Y_CarD, coin2, label3);
                x = r.Next(400, 450);
                y = r.Next(60, 120);
                coin2.Location = new Point(x, y);
            }
            int pxcoin2 = coin2.Location.X;
            int pycoin2 = coin2.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin2.Bounds) && coin2.Location.X == pxcoin2 && coin2.Location.Y == pycoin2)
            {
                collectioncoins2++;
                coin2.Location = new Point(714, 425);
                pi2.sumcoinp1level1(Y_CarD, coin2, label3);

            }
            if (Y_Car.Bounds.IntersectsWith(coin3.Bounds))
            {

                collectioncoins2++;
                pi2.sumcoinp1level1(Y_CarD, coin3, label3);
                x = r.Next(650, 700);
                y = r.Next(21, 120);
                coin3.Location = new Point(x, y);
            }
            int pxcoin3 = coin3.Location.X;
            int pycoin3 = coin3.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin3.Bounds) && coin3.Location.X == pxcoin3 && coin3.Location.Y == pycoin3)
            {
                collectioncoins2++;
                coin3.Location = new Point(275, 435);
                pi2.sumcoinp1level1(Y_CarD, coin3, label3);

            }

            if (Y_Car.Bounds.IntersectsWith(coin4.Bounds))
            {

                collectioncoins2++;
                pi2.sumcoinp1level1(Y_CarD, coin4, label3);

                x = r.Next(310, 319);
                y = r.Next(60, 97);
                coin4.Location = new Point(x, y);
            }
            int pxcoin4 = coin4.Location.X;
            int pycoin4 = coin4.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin4.Bounds) && coin4.Location.X == pxcoin4 && coin4.Location.Y == pycoin4)
            {
                collectioncoins2++;
                coin4.Location = new Point(300, 475);
                pi2.sumcoinp1level1(Y_CarD, coin4, label3);
            }
            if (Y_Car.Bounds.IntersectsWith(coin5.Bounds))
            {

                collectioncoins2++;
                pi2.sumcoinp1level1(Y_CarD, coin5, label3);
                x = r.Next(10, 20);
                y = r.Next(320, 330);
                coin5.Location = new Point(x, y);
            }
            int pxcoin5 = coin5.Location.X;
            int pycoin5 = coin5.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin5.Bounds) && coin5.Location.X == pxcoin5 && coin5.Location.Y == pycoin5)
            {
                collectioncoins2++;
                coin5.Location = new Point(640, 250);
                pi2.sumcoinp1level1(Y_CarD, coin5, label3);

            }
            if (Y_Car.Bounds.IntersectsWith(coin6.Bounds))
            {

                collectioncoins2++;
                pi2.sumcoinp1level1(Y_CarD, coin6, label3);
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
                pi2.sumcoinp1level1(Y_CarD, coin6, label3);
            }
            if (Y_Car.Bounds.IntersectsWith(coin7.Bounds))
            {
                x = r.Next(400, 500);
                y = r.Next(440, 450);
                coin7.Location = new Point(x, y);

                collectioncoins2++;
                pi2.sumcoinp1level1(Y_CarD, coin7, label3);
            }
            int pxcoin7 = coin7.Location.X;
            int pycoin7 = coin7.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin7.Bounds) && coin7.Location.X == pxcoin7 && coin7.Location.Y == pycoin7)
            {
                collectioncoins2++;
                coin7.Location = new Point(600, 100);
                pi2.sumcoinp1level1(Y_CarD, coin7, label3);

            }

            if (Y_Car.Bounds.IntersectsWith(coin8.Bounds))
            {
                x = r.Next(125, 150);
                y = r.Next(450, 475);
                coin8.Location = new Point(x, y);

                collectioncoins2++;
                pi2.sumcoinp1level1(Y_CarD, coin8, label3);
            }
            int pxcoin8 = coin8.Location.X;
            int pycoin8 = coin8.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin8.Bounds) && coin8.Location.X == pxcoin8 && coin8.Location.Y == pycoin8)
            {
                collectioncoins2++;
                coin8.Location = new Point(210, 40);
                pi2.sumcoinp1level1(Y_CarD, coin8, label3);

            }
            if (Y_Car.Bounds.IntersectsWith(coin9.Bounds))
            {
                x = r.Next(700, 720);
                y = r.Next(320, 360);
                coin9.Location = new Point(x, y);
                collectioncoins2++;
                pi2.sumcoinp1level1(Y_CarD, coin9, label3);
            }
            int pxcoin9 = coin9.Location.X;
            int pycoin9 = coin9.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin9.Bounds) && coin9.Location.X == pxcoin9 && coin9.Location.Y == pycoin9)
            {
                collectioncoins2++;
                coin9.Location = new Point(25, 267);
                pi2.sumcoinp1level1(Y_CarD, coin9, label3);

            }
            if (Y_Car.Bounds.IntersectsWith(coin10.Bounds))
            {
                x = r.Next(630, 665);
                y = r.Next(360, 380);
                coin10.Location = new Point(x, y);
                collectioncoins2++;
                pi2.sumcoinp1level1(Y_CarD, coin10, label3);
            }
            int pxcoin10 = coin10.Location.X;
            int pycoin10 = coin10.Location.Y;
            if (Y_Car.Bounds.IntersectsWith(coin10.Bounds) && coin10.Location.X == pxcoin10 && coin10.Location.Y == pycoin10)
            {
                collectioncoins2++;
                coin10.Location = new Point(120, 300);
                pi2.sumcoinp1level1(Y_CarD, coin10, label3);

            }
        }
    
    }
    }
