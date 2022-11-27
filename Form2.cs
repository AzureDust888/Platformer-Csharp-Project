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
    public partial class Form2 : Form
    {
        Form1 f = Form1.form;
        public Form2()
        {
            InitializeComponent();
            FormClosed += Form2_FormClosed;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Score: " + Class1.score.ToString();
            label2.Text = "Best: " + Class1.max_score.ToString();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }


    }
}
