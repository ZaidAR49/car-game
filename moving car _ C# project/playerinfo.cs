using lvl_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moving_car___C__project
{
    internal class playerinfo
    {
      static public int p1coins1 = 0;
        static public int p1coins2 = 0;
        static public int p1coins3 = 0;
        static public  int p1coins=p1coins1+p1coins2+p1coins3;
        static public int p2coins1 = 0;
        static public int p2coins2 = 0;
        static public int p2coins3 = 0;
        static public int p2coins=p2coins1+p2coins2+p2coins3;
        static public int p1scores1 = 0;
        static public  int p1scores2 = 0;
        static public  int p1scores3 = 0;
        static public int p1scores=p1scores1+p1scores2+p1scores3;
        static public int p2scores1 = 0;
        static public int p2scores2 = 0;
        static public int p2scores3 = 0;
        static public int p2scores=p2coins1+p2coins2+p2coins3;

        public string thewinner = "";
        public  void sumcoinp1level1(PictureBox ycar,PictureBox c,Label l=null) 
        
        { 
            Level1 l1 = new Level1();
        if (ycar.Bounds.IntersectsWith(c.Bounds))
            {
                
                l.Text = "P1 Coins :"+p1coins1++;
            
            }
        
        }
        public  void sumcoinp1level2(PictureBox ycar, PictureBox c, Label l)
        {
            Label l1 = new Label();
            level2 l2 = new level2();
            if (ycar.Bounds.IntersectsWith(c.Bounds))
            {

                l.Text = "P1 Coins :" + p1coins2++;
            }

        }
        public  void sumcoinp1level3(PictureBox ycar, PictureBox c, Label l = null)

        {
            Level3 l3 = new Level3();
            if (ycar.Bounds.IntersectsWith(c.Bounds))
            {

                l.Text = "P1 Coins :" + p1coins3++;
            }

        }
        public  void sumcoinp2level1(PictureBox rcar, PictureBox c, Label l=null)

        {
            Level1 l1 = new Level1();
            if (rcar.Bounds.IntersectsWith(c.Bounds))
            { 
            l.Text="P2 Coins :"+p2coins1++;    
            }

        }
        public  void sumcoinp2level2(PictureBox rcar, PictureBox c, Label l = null)

        {
            level2 l2 = new level2();
            if (rcar.Bounds.IntersectsWith(c.Bounds))
            {
                l.Text = "P2 Coins :" + p2coins2++;
            }

        }
        public  void sumcoinp2level3(PictureBox rcar, PictureBox c, Label l = null)

        {
            Level3 l3 = new Level3();
            if (rcar.Bounds.IntersectsWith(c.Bounds))
            {
                l.Text = "P2 Coins :" + p2coins3++;
            }

        }
        public  void sumscorep1level1(PictureBox ycar,Label l=null) 
        {
        Level1 l1= new Level1();
            if (ycar.Bounds.IntersectsWith(l1.streetD.Bounds))
            {
                l.Text = "score :" + p1scores1++;            
            }
            if (ycar.Bounds.IntersectsWith(l1.streetR.Bounds))
            {
                l.Text = "score :" + p1scores1++;
            }

            if (ycar.Bounds.IntersectsWith(l1.streetU.Bounds))
            {
                l.Text = "score :" + p1scores1++;
            }
            if (ycar.Bounds.IntersectsWith(l1.streetL.Bounds))
            {
                l.Text = "score :" + p1scores1++;
            }
        }
        public  void sumscorep1level2(PictureBox ycar, Label l)
        { 
        level2 l2 = new level2();
            if (ycar.Bounds.IntersectsWith(l2.StreetD.Bounds)) {
                l.Text = "score :" + p1scores2++;
            }
            if (ycar.Bounds.IntersectsWith(l2.StreetR.Bounds))
            {
                l.Text = "score :" + p1scores2++;
            }
            if (ycar.Bounds.IntersectsWith(l2.StreetL1.Bounds))
            {
                l.Text = "score :" + p1scores2++;
            }
            if (ycar.Bounds.IntersectsWith(l2.StreetL2.Bounds))
            {
                l.Text = "score :" + p1scores2++;
            }
            if (ycar.Bounds.IntersectsWith(l2.StreetU1.Bounds))
            {
                l.Text = "score :" + p1scores2++;
            }
            if (ycar.Bounds.IntersectsWith(l2.StreetU2.Bounds))
            {
                l.Text = "score :" + p1scores2++;
            }
        }
        public  void sumscorep1level3(PictureBox ycar,Label l=null) {
            Level3 l3 = new Level3();
            if (ycar.Bounds.IntersectsWith(l3.street1.Bounds))
            {
                l.Text="score :"+p1scores3++;    

            }
            if (ycar.Bounds.IntersectsWith(l3.street2.Bounds))
            {
                l.Text = "score :" + p1scores3++;

            }
            if (ycar.Bounds.IntersectsWith(l3.street3.Bounds))
            {
                l.Text = "score :" + p1scores3++;

            }
            if (ycar.Bounds.IntersectsWith(l3.street4.Bounds))
            {
                l.Text = "score :" + p1scores3++;

            }
            if (ycar.Bounds.IntersectsWith(l3.street5.Bounds))
            {
                l.Text = "score :" + p1scores3++;

            }
            if (ycar.Bounds.IntersectsWith(l3.street6.Bounds))
            {
                l.Text = "score :" + p1scores3++;

            }
            if (ycar.Bounds.IntersectsWith(l3.street7.Bounds))
            {
                l.Text = "score :" + p1scores3++;

            }
            if (ycar.Bounds.IntersectsWith(l3.street8.Bounds))
            {
                l.Text = "score :" + p1scores3++;

            }
            if (ycar.Bounds.IntersectsWith(l3.street9.Bounds))
            {
                l.Text = "score :" + p1scores3++;

            }
        }
        public  void sumscorep2level1(PictureBox rcar, Label l = null)

        {
            Level1 l1 = new Level1();
            if (rcar.Bounds.IntersectsWith(l1.streetD.Bounds))
            {
                l.Text = "score :" + p2scores1++;
            }
            if (rcar.Bounds.IntersectsWith(l1.streetR.Bounds))
            {
                l.Text = "score :" + p2scores1++;
            }

            if (rcar.Bounds.IntersectsWith(l1.streetU.Bounds))
            {
                l.Text = "score :" + p2scores1++;
            }
            if (rcar.Bounds.IntersectsWith(l1.streetL.Bounds))
            {
                l.Text = "score :" + p2scores1++;
            }
        }
        public  void sumscorep2level2(PictureBox rcar, Label l)
        {
            level2 l2 = new level2();
            if (rcar.Bounds.IntersectsWith(l2.StreetD.Bounds))
            {
                l.Text = "score :" + p2scores2++;
            }
            if (rcar.Bounds.IntersectsWith(l2.StreetR.Bounds))
            {
                l.Text = "score :" + p2scores2++;
            }
            if (rcar.Bounds.IntersectsWith(l2.StreetL1.Bounds))
            {
                l.Text = "score :" + p2scores2++;
            }
            if (rcar.Bounds.IntersectsWith(l2.StreetL2.Bounds))
            {
                l.Text = "score :" + p2scores2++;
            }
            if (rcar.Bounds.IntersectsWith(l2.StreetU1.Bounds))
            {
                l.Text = "score :" + p2scores2++;
            }
            if (rcar.Bounds.IntersectsWith(l2.StreetU2.Bounds))
            {
                l.Text = "score :" + p2scores2++;
            }
        }
        public  void sumscorep2level3(PictureBox rcar, Label l = null)
        {
            Level3 l3 = new Level3();
            if (rcar.Bounds.IntersectsWith(l3.street1.Bounds))
            {
                l.Text = "score :" + p2scores3++;

            }
            if (rcar.Bounds.IntersectsWith(l3.street2.Bounds))
            {
                l.Text = "score :" + p2scores3++;

            }
            if (rcar.Bounds.IntersectsWith(l3.street3.Bounds))
            {
                l.Text = "score :" + p2scores3++;

            }
            if (rcar.Bounds.IntersectsWith(l3.street4.Bounds))
            {
                l.Text = "score :" + p2scores3++;

            }
            if (rcar.Bounds.IntersectsWith(l3.street5.Bounds))
            {
                l.Text = "score :" + p2scores3++;

            }
            if (rcar.Bounds.IntersectsWith(l3.street6.Bounds))
            {
                l.Text = "score :" + p2scores3++;

            }
            if (rcar.Bounds.IntersectsWith(l3.street7.Bounds))
            {
                l.Text = "score :" + p2scores3++;

            }
            if (rcar.Bounds.IntersectsWith(l3.street8.Bounds))
            {
                l.Text = "score :" + p2scores3++;

            }
            if (rcar.Bounds.IntersectsWith(l3.street9.Bounds))
            {
                l.Text = "score :" + p2scores3++;

            }
        }    
     
    }

}
