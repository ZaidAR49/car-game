using moving_car___C__project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME

{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        public void change_Style_forDataGV()
        {
            dataGridView1.BackgroundColor = Color.FromArgb(0x07, 0x66, 0xAD);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(0x29, 0xAD, 0xB2);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0xED, 0x9E, 0xD6);//here
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0xC5, 0xE8, 0x98);
            dataGridView1.EnableHeadersVisualStyles = false;// to allows me to edit
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Slackey", 16, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.IndianRed;
            dataGridView1.RowTemplate.Height = 50;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void currentprofile_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = Program.stdList;
            change_Style_forDataGV();
            Fname fname = new Fname();
            dataGridView1.Rows.Add(Program.p1,Program.age1 , Program.g1);
            if (Program.Computer_playing=false)
            dataGridView1.Rows.Add(Program.p2, Program.age2, Program.g2);
        }
        
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void currentprofile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            { 
                Application.Exit();
            }
        }

        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NGAME ngame = new NGAME();
            ngame.Show();
            this.Visible = false;
        }

        private void newProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fname f = new Fname();
            f.Show();
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
