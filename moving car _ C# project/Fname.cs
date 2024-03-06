using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAME;
using moving_car___C__project;

namespace GAME

{
    public partial class Fname : Form
    {
        public Fname()
        {
            InitializeComponent();
        }
        public void vaildation()
        {

            ////////////////////////////validation name
            if (nametextbox.Text != "" && nametextbox.Text.Length >= 3 && nametextbox.Text.Length <= 15 && (textBox2.Text != "" && textBox2.Text.Length >= 3 && textBox2.Text.Length <= 15) || Program.Computer_playing)
            {
                v1 = true;
                Program.p1 = nametextbox.Text;
            }

            else MessageBox.Show("your nikname lenght is too short or long");
            ///////////////////////////////////////////////////////////// validation age
            int age;
            int age2 ;
            bool va = int.TryParse(agetextbox.Text, out age);
            bool va2 = int.TryParse(textBox1.Text, out age2);
            if (agetextbox.Text != "" && age > 0 && age < 100 && (age2 > 0 && age2 < 100) || Program.Computer_playing)
                if (va == true && va2 == true || Program.Computer_playing)
                {
                    v2 = true;
                    Program.age1 = age;
                    Program.age2 = age;
                }
                else
                    MessageBox.Show("Age should be number");
            else
                MessageBox.Show("Enter your age correctly");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void currintProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form current = new History();
            //current.Show();
            //this.Visible = false;
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        double age;
        private void button1_Click(object sender, EventArgs e)
        {
            Sound("button.wav");
            vaildation();
            if (v1 && v2)
            { 
                profclass std = new profclass();
                std.Fname = nametextbox.Text;

                double.TryParse(agetextbox.Text, out age);

                if (radioButton9.Checked == true)
                {
                    std.Sex = "Famle";

                }
                else
                {
                    std.Sex = "Male";
                }
                std.Age = age;
                Program.stdList.Add(std);
                MessageBox.Show("insertion Done successfuly");
            }
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sound("button.wav");

            Application.Exit();
        }
        public void Sound(string s)
        {
            SoundPlayer player = new SoundPlayer(@s);
            //player.Play();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Sound("button.wav");
            ChooseLevel choos =new ChooseLevel();
          
            choos.Show();
            this.Visible = false;

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                Program.Computer_playing = true;
                groupBox2.Visible= false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                Program.obj = "Rat";


            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true) {

                Program.obj = "ball";
            }
        }

        private void nEWGameToolStripMenuItem_Click(object sender, EventArgs e)
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
            Fname fname = new Fname();
            fname.Show();
            this.Visible = false;
            
           
        }

        private void radioButton7_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Sound("button.wav");
            Form current = new History();
            current.Show();
            this.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor=Color.Red;
        }

        bool v1= false,v2=false;
        private void nametextbox_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void reportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
     

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Program.g1 = "male";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            Program.g2 = "Fmale";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            Program.g2 = "male";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (nametextbox.Text != "")
            {
                v2 = true;
                Program.p2 = textBox2.Text;
            }

            else MessageBox.Show("Empty text box is not vaild");

        }

        private void agetextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Visible = false;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Program.g1 = "Fmale";
        }
    }
}
