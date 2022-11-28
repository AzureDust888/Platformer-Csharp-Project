using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
namespace Platformer_Csharp_Project
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, isGameOver;
        bool goDown = true;
        Random random = new Random();
        DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
        int queue = 0;
        public int score = 0;
        Form2 f2 = new Form2();
        public static Form1 form = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Class1.loadScore();
            }
            catch { }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            enemy1.Visible = false;
            enemy2.Visible = false;
            enemy3.Visible = false;
            friendly1.Visible = false;
            friendly2.Visible = false;
            friendly3.Visible = false;
            timer1.Enabled = true;
            timer1.Interval = 1;
            lb_score.Parent = pictureBox2;
            Lb.Parent = pictureBox2;
            Rb.Parent = pictureBox2;
            speed[0] = random.Next(7,7);
            speed[1] = random.Next(4,4);
            dir = dir.Parent.Parent;
            pictureBox1.Parent = pictureBox2;
            pictureBox1.BackgroundImage = Image.FromFile(dir.FullName + "\\Resources\\w1.png");
            timer1.Start();
            form = this;
        }
        int[] speed = new int[2];
        int speed_up = 0;
        int count_step_left = 0;
        int count_step_right = 0;
        private void MainGameEvent(object sender, EventArgs e)
        {
            queue++;
            speed_up++;
            if(speed_up % 500 == 0 && speed_up <= 6500)
            {
                speed[0]++;
                speed[1]++;
            }
            if (pictureBox1.Bounds.IntersectsWith(Lb.Bounds))
                goLeft = false;
            if(pictureBox1.Bounds.IntersectsWith(Rb.Bounds))
                goRight = false;
            if(goLeft)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
                if(count_step_left<4)
                {
                    count_step_left++;
                    pictureBox1.BackgroundImage = Image.FromFile(dir.FullName + "\\Resources\\m-w"+count_step_left+".png");
                }
                else
                {
                    count_step_left = 0;
                }
            }
               
            if(goRight)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
                if (count_step_right < 4)
                {
                    count_step_right++;
                    pictureBox1.BackgroundImage = Image.FromFile(dir.FullName + "\\Resources\\w" + count_step_right + ".png");
                }
                else
                {
                   count_step_right = 0;
                }
            }
                
            if (pictureBox1.Bounds.IntersectsWith(enemy.Bounds))
            {
                isGameOver = true;
            } 
            if(goDown)
            {
                enemy.Location = new Point(enemy.Location.X, enemy.Location.Y + speed[0]);
                if(queue>25)
                {
                    if(!enemy1.Visible)
                        enemy1.Visible = true;
                    enemy1.Location = new Point(enemy1.Location.X, enemy1.Location.Y + speed[1]);
                }
                if(queue>40)
                {
                    if (!friendly1.Visible)
                        friendly1.Visible = true;
                    friendly1.Location = new Point(friendly1.Location.X, friendly1.Location.Y + speed[1]);
                }
                if(queue>75)
                {
                    if (!enemy2.Visible)
                        enemy2.Visible = true;
                    enemy2.Location = new Point(enemy2.Location.X, enemy2.Location.Y + speed[0]);
                }
                if(queue>80)
                {
                    if (!friendly2.Visible)
                        friendly2.Visible = true;
                    friendly2.Location=new Point(friendly2.Location.X, friendly2.Location.Y + speed[1]);
                }
                if(queue>95)
                {
                    if (!enemy3.Visible)
                        enemy3.Visible = true;
                    enemy3.Location = new Point(enemy3.Location.X, enemy3.Location.Y + speed[1]);
                }
                if(queue>120)
                {
                    if (!friendly3.Visible)
                        friendly3.Visible = true;
                    friendly3.Location = new Point(friendly3.Location.X, friendly3.Location.Y + speed[1]);
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
            }
            if (pictureBox1.Bounds.IntersectsWith(enemy1.Bounds))
            {
                isGameOver = true;
            }
            if (pictureBox1.Bounds.IntersectsWith(enemy2.Bounds))
            {
                isGameOver = true;
            }
            if (pictureBox1.Bounds.IntersectsWith(enemy3.Bounds))
            {
                isGameOver = true;
            }
            lb_score.Text = "Score: " + score.ToString();
            if (isGameOver)
            {
                pictureBox1.BackgroundImage = Image.FromFile(dir.FullName + "\\Resources\\f4.png");
                Class1.score = score;
                if (score>Class1.max_score)
                {
                    Class1.max_score = score;
                    Class1.saveScore(score);;
                }
                f2.Show();
                timer1.Stop();
            }
        }
    }
}