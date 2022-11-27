namespace Platformer_Csharp_Project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lb = new System.Windows.Forms.PictureBox();
            this.Rb = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.friendly1 = new System.Windows.Forms.PictureBox();
            this.friendly2 = new System.Windows.Forms.PictureBox();
            this.friendly3 = new System.Windows.Forms.PictureBox();
            this.lb_score = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendly1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendly2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendly3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.MainGameEvent);
            // 
            // Lb
            // 
            this.Lb.BackColor = System.Drawing.Color.Transparent;
            this.Lb.Location = new System.Drawing.Point(0, -14);
            this.Lb.Name = "Lb";
            this.Lb.Size = new System.Drawing.Size(10, 776);
            this.Lb.TabIndex = 1;
            this.Lb.TabStop = false;
            // 
            // Rb
            // 
            this.Rb.BackColor = System.Drawing.Color.Transparent;
            this.Rb.Location = new System.Drawing.Point(580, -14);
            this.Rb.Name = "Rb";
            this.Rb.Size = new System.Drawing.Size(16, 776);
            this.Rb.TabIndex = 2;
            this.Rb.TabStop = false;
            this.Rb.Click += new System.EventHandler(this.Rb_Click);
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.Red;
            this.enemy.Location = new System.Drawing.Point(40, 22);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(23, 22);
            this.enemy.TabIndex = 3;
            this.enemy.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Red;
            this.enemy1.Location = new System.Drawing.Point(181, 12);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(39, 34);
            this.enemy1.TabIndex = 4;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Red;
            this.enemy2.Location = new System.Drawing.Point(358, 12);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(23, 22);
            this.enemy2.TabIndex = 5;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Red;
            this.enemy3.Location = new System.Drawing.Point(518, 12);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(56, 50);
            this.enemy3.TabIndex = 6;
            this.enemy3.TabStop = false;
            // 
            // friendly1
            // 
            this.friendly1.BackColor = System.Drawing.Color.Chartreuse;
            this.friendly1.Location = new System.Drawing.Point(98, 12);
            this.friendly1.Name = "friendly1";
            this.friendly1.Size = new System.Drawing.Size(39, 34);
            this.friendly1.TabIndex = 7;
            this.friendly1.TabStop = false;
            // 
            // friendly2
            // 
            this.friendly2.BackColor = System.Drawing.Color.Chartreuse;
            this.friendly2.Location = new System.Drawing.Point(263, 12);
            this.friendly2.Name = "friendly2";
            this.friendly2.Size = new System.Drawing.Size(39, 34);
            this.friendly2.TabIndex = 8;
            this.friendly2.TabStop = false;
            // 
            // friendly3
            // 
            this.friendly3.BackColor = System.Drawing.Color.Chartreuse;
            this.friendly3.Location = new System.Drawing.Point(434, 12);
            this.friendly3.Name = "friendly3";
            this.friendly3.Size = new System.Drawing.Size(39, 34);
            this.friendly3.TabIndex = 9;
            this.friendly3.TabStop = false;
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.BackColor = System.Drawing.Color.Transparent;
            this.lb_score.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_score.Location = new System.Drawing.Point(465, 0);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(67, 25);
            this.lb_score.TabIndex = 10;
            this.lb_score.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(596, 663);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox1.Location = new System.Drawing.Point(263, 589);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 661);
            this.Controls.Add(this.lb_score);
            this.Controls.Add(this.friendly3);
            this.Controls.Add(this.friendly2);
            this.Controls.Add(this.friendly1);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.Rb);
            this.Controls.Add(this.Lb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Lb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendly1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendly2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendly3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Lb;
        private System.Windows.Forms.PictureBox Rb;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox friendly1;
        private System.Windows.Forms.PictureBox friendly2;
        private System.Windows.Forms.PictureBox friendly3;
        private System.Windows.Forms.Label lb_score;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

