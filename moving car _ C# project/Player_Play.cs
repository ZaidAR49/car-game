using lvl_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace moving_car___C__project
{
    public class Player_Play
    {

        public bool PlayerMoving_right;
        public bool PlayerMoving_left;
        public bool PlayerMoving_down;
        public bool PlayerMoving_up;
        playerinfo p = new playerinfo();

        public void d_moving1(PictureBox R, PictureBox L, PictureBox U, PictureBox D)
        {
          
            Level1 l1 = new Level1();
           
            if (R.Bounds.IntersectsWith(l1.streetD.Bounds))//Movig Right
            {
                R.Visible = true;
                L.Visible = false;
                U.Visible = false;
                D.Visible = false;
                R.Left += Program.speed;
                L.Left += Program.speed;
                D.Left += Program.speed;
                U.Left += Program.speed;
                p.sumscorep1level1(l1.Y_Car, l1.label5);
                l1.label7.Text = "Speed : " + Program.speed;
            }
            if (R.Bounds.IntersectsWith(l1.streetU.Bounds))// Moving Left
            {
                R.Visible = false;
                L.Visible = true;
                U.Visible = false;
                D.Visible = false;
                R.Left -= Program.speed;
                L.Left -= Program.speed;
                D.Left -= Program.speed;
                U.Left -= Program.speed;
   p.sumscorep1level1(l1.Y_Car, l1.label5);
                l1.label7.Text = "Speed : " + Program.speed;
            }
            if (R.Bounds.IntersectsWith(l1.streetR.Bounds))// Moving up
            {
                R.Visible = false;
                L.Visible = false;
                U.Visible = true;
                D.Visible = false;
                R.Top -= Program.speed;
                L.Top -= Program.speed;
                D.Top -= Program.speed;
                U.Top -= Program.speed;
                p.sumscorep1level1(l1.Y_Car, l1.label5);
                l1.label7.Text = "Speed : " + Program.speed;
            }
            if (R.Bounds.IntersectsWith(l1.streetL.Bounds)&&! R.Bounds.IntersectsWith(l1.somth.Bounds))// Moving down
            {
                R.Visible = false;
                L.Visible = false;
                U.Visible = false;
                D.Visible = true;
                R.Top += Program.speed;
                L.Top += Program.speed;
                D.Top += Program.speed;
                U.Top += Program.speed;
                p.sumscorep1level1(l1.Y_Car, l1.label5);
                l1.label7.Text = "Speed : " + Program.speed;
            }

        }
        public void d_moving2(PictureBox R, PictureBox L, PictureBox U, PictureBox D,Label l1=null, Label l3=null)
        {
    
            level2 l2 = new level2();
            if (D.Bounds.IntersectsWith(l2.HFinsh.Bounds))
            {
                Program.Change_location(43, 425, R, L, U,D);
               
            }
            if (R.Bounds.IntersectsWith(l2.StreetD.Bounds) || R.Bounds.IntersectsWith(l2.StreetU1.Bounds))//Movig Right
            {
               
                R.Visible = true;
                L.Visible = false;
                U.Visible = false;
                D.Visible = false;
                R.Left += Program.speed;
                L.Left += Program.speed;
                D.Left += Program.speed;
                U.Left += Program.speed;
                p.sumscorep2level2(l2.Y_CarR, l2.label5);
                l2.label6.Text = "Speed : " + Program.speed;
            }
            if (R.Bounds.IntersectsWith(l2.StreetU2.Bounds))// Moving Left
            {
                R.Visible = false;
                L.Visible = true;
                U.Visible = false;
                D.Visible = false;
                R.Left -= Program.speed;
                L.Left -= Program.speed;
                D.Left -= Program.speed;
                U.Left -= Program.speed;
                p.sumscorep2level2(l2.Y_CarR, l2.label5);
                l2.label6.Text = "Speed : " + Program.speed;
            }
            if (R.Bounds.IntersectsWith(l2.StreetL2.Bounds) || R.Bounds.IntersectsWith(l2.StreetL1.Bounds))// Moving up
            {
                R.Visible = false;
                L.Visible = false;
                U.Visible = true;
                D.Visible = false;
                R.Top -= Program.speed;
                L.Top -= Program.speed;
                D.Top -= Program.speed;
                U.Top -= Program.speed;
                p.sumscorep2level2(l2.Y_CarR, l2.label5);
                l2.label6.Text = "Speed : " + Program.speed;
            }
            if (R.Bounds.IntersectsWith(l2.StreetR.Bounds))// Moving down
            {
                R.Visible = false;
                L.Visible = false;
                U.Visible = false;
                D.Visible = true;
                R.Top += Program.speed;
                L.Top += Program.speed;
                D.Top += Program.speed;
                U.Top += Program.speed; p.sumscorep2level2(l2.Y_CarR, l2.label5);
                l2.label6.Text = "Speed : " + Program.speed;
            }

        }
        public void d_moving3(PictureBox R, PictureBox L, PictureBox U, PictureBox D)
        {
            Level3 l3 = new Level3();
            if (R.Bounds.IntersectsWith(l3.HiddenFinish.Bounds))
            {
                Program.Change_location(l3.trick1.Location.X, l3.trick1.Location.Y, R, L, U, D);
            }
            if (R.Bounds.IntersectsWith(l3.street1.Bounds) || R.Bounds.IntersectsWith(l3.street5.Bounds) || R.Bounds.IntersectsWith(l3.street9.Bounds))//Movig Right
            {
                R.Visible = true;
                L.Visible = false;
                U.Visible = false;
                D.Visible = false;
                R.Left += Program.speed;
                L.Left += Program.speed;
                D.Left += Program.speed;
                U.Left += Program.speed;
                p.sumscorep1level3(l3.Y_CarL, l3.label2);
                l3.label3.Text = "Speed : " + Program.speed;

            }
            if (R.Bounds.IntersectsWith(l3.street3.Bounds) || R.Bounds.IntersectsWith(l3.street7.Bounds))// Moving Left
            {
                R.Visible = false;
                L.Visible = true;
                U.Visible = false;
                D.Visible = false;
                R.Left -= Program.speed;
                L.Left -= Program.speed;
                D.Left -= Program.speed;
                U.Left -= Program.speed;
                p.sumscorep1level3(l3.Y_CarL, l3.label2);
                l3.label3.Text = "Speed : " + Program.speed;
            }
            if (R.Bounds.IntersectsWith(l3.street2.Bounds) || R.Bounds.IntersectsWith(l3.street4.Bounds))// Moving up
            {
                R.Visible = false;
                L.Visible = false;
                U.Visible = true;
                D.Visible = false;
                R.Top -= Program.speed;
                L.Top -= Program.speed;
                D.Top -= Program.speed;
                U.Top -= Program.speed;
                p.sumscorep1level3(l3.Y_CarL, l3.label2);
                l3.label3.Text = "Speed : " + Program.speed;
            }
            if (R.Bounds.IntersectsWith(l3.street6.Bounds) || R.Bounds.IntersectsWith(l3.street8.Bounds))// Moving down
            {
                R.Visible = false;
                L.Visible = false;
                U.Visible = false;
                D.Visible = true;
                R.Top += Program.speed;
                L.Top += Program.speed;
                D.Top += Program.speed;
                U.Top += Program.speed;
                p.sumscorep1level3(l3.Y_CarL, l3.label2);
                l3.label3.Text = "Speed : " + Program.speed;
            }
        }
    }
}