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
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Score: " + Class1.score.ToString();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
