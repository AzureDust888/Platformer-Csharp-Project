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
        bool goDown = true;
        Random random = new Random();
        int queue = 0;
        public int score = 0;
        
        Form2 f2 = new Form2();
        public static Form1 form = null;
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
            timer1.Start();
            form = this;
        }
        private void MainGameEvent(object sender, EventArgs e)
        {
            queue++;
            if (pictureBox1.Bounds.IntersectsWith(Lb.Bounds))
                goLeft = false;
            if(pictureBox1.Bounds.IntersectsWith(Rb.Bounds))
                goRight = false;
            if(goLeft)
                pictureBox1.Location = new Point(pictureBox1.Location.X-10, pictureBox1.Location.Y);
            if(goRight)
                pictureBox1.Location = new Point(pictureBox1.Location.X+10, pictureBox1.Location.Y);
            if (pictureBox1.Bounds.IntersectsWith(enemy.Bounds))
            {
                isGameOver = true;
            } 
            if(goDown)
            {
                enemy.Location = new Point(enemy.Location.X, enemy.Location.Y + random.Next(10,15));
                if(queue>25)
                {
                    enemy1.Location = new Point(enemy1.Location.X, enemy1.Location.Y + random.Next(3,12));
                }
                if(queue>40)
                {
                    friendly1.Location = new Point(friendly1.Location.X, friendly1.Location.Y + random.Next(3, 12));
                }
                if(queue>75)
                {
                    enemy2.Location = new Point(enemy2.Location.X, enemy2.Location.Y + random.Next(10,15));
                }
                if(queue>80)
                {
                    friendly2.Location=new Point(friendly2.Location.X, friendly2.Location.Y + random.Next(3, 12));
                }
                if(queue>95)
                {
                    enemy3.Location = new Point(enemy3.Location.X, enemy3.Location.Y + random.Next(3, 12));
                }
                if(queue>120)
                {
                    friendly3.Location = new Point(friendly3.Location.X, friendly3.Location.Y + random.Next(3, 12));
                }
            }
            if (enemy.Location.Y>(Size.Height+enemy.Height))
            {
                enemy.Location = new Point(random.Next(0, 530), 0);
            }
            if (enemy1.Location.Y > (Size.Height + enemy1.Height))
            {
                enemy1.Location = new Point(random.Next(0, 530), 0);
            }
            if (enemy2.Location.Y > (Size.Height + enemy2.Height))
            {
                enemy2.Location = new Point(random.Next(0, 530), 0);
            }
            if (enemy3.Location.Y > (Size.Height + enemy3.Height))
            {
                enemy3.Location = new Point(random.Next(0, 530), 0);
            }
            if(friendly1.Location.Y> (Size.Height + friendly1.Height))
            {
                friendly1.Location = new Point(random.Next(0, 540), 0);
            }
            if (friendly2.Location.Y > (Size.Height + friendly2.Height))
            {
                friendly2.Location = new Point(random.Next(0, 540), 0);
            }
            if (friendly3.Location.Y > (Size.Height + friendly3.Height))
            {
                friendly3.Location = new Point(random.Next(0, 540), 0);
            }
            if (pictureBox1.Bounds.IntersectsWith(friendly1.Bounds))
            {
                score++;
                friendly1.Location = new Point(random.Next(0, 540), 0);
            }
            if (pictureBox1.Bounds.IntersectsWith(friendly2.Bounds))
            {
                score++;
                friendly2.Location = new Point(random.Next(0, 540), 0);
            }
            if (pictureBox1.Bounds.IntersectsWith(friendly3.Bounds))
            {
                score++;
                friendly3.Location = new Point(random.Next(0, 540), 0);
            }
            if(pictureBox1.Bounds.IntersectsWith(enemy.Bounds))
            {
                isGameOver = true;
                enemy.Location = new Point(random.Next(0, 530), 0);
            }
            if (pictureBox1.Bounds.IntersectsWith(enemy1.Bounds))
            {
                isGameOver = true;
                enemy1.Location = new Point(random.Next(0, 530), 0);
            }
            if (pictureBox1.Bounds.IntersectsWith(enemy2.Bounds))
            {
                isGameOver = true;
                enemy2.Location = new Point(random.Next(0, 530), 0);
            }
            if (pictureBox1.Bounds.IntersectsWith(enemy3.Bounds))
            {
                isGameOver = true;
                enemy3.Location = new Point(random.Next(0, 530), 0);
            }
            lb_score.Text = "Score: " + score.ToString();
            if(isGameOver)
            {
                f2.Show();
                Class1.score = score;
                timer1.Stop();
            }
        }
    }
}