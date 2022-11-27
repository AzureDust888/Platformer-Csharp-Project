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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lb = new System.Windows.Forms.PictureBox();
            this.Rb = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            this.SuspendLayout();
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.enemy.Location = new System.Drawing.Point(253, 12);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(56, 50);
            this.enemy.TabIndex = 3;
            this.enemy.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 661);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.Rb);
            this.Controls.Add(this.Lb);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Lb;
        private System.Windows.Forms.PictureBox Rb;
        private System.Windows.Forms.PictureBox enemy;
    }
}

