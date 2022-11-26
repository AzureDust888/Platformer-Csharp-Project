using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer_Csharp_Project
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, isGameOver;



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
        }

        private void Rb_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            
            timer1.Enabled = true;
            timer1.Interval = 1;
        }

        private void MainGameEvent(object sender, EventArgs e)
        {
            if(pictureBox1.Bounds.IntersectsWith(Lb.Bounds))
                goLeft = false;
            if(pictureBox1.Bounds.IntersectsWith(Rb.Bounds))
                goRight = false;
            if(goLeft)
                pictureBox1.Location = new Point(pictureBox1.Location.X-10, pictureBox1.Location.Y);
            if(goRight)
                pictureBox1.Location = new Point(pictureBox1.Location.X+10, pictureBox1.Location.Y);
        }
    }
}
