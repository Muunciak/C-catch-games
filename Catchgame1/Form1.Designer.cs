namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bohater = new System.Windows.Forms.PictureBox();
            this.nerf = new System.Windows.Forms.PictureBox();
            this.nerf1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.punkty2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bohater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nerf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nerf1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(769, 322);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bohater
            // 
            this.bohater.Image = ((System.Drawing.Image)(resources.GetObject("bohater.Image")));
            this.bohater.Location = new System.Drawing.Point(303, 140);
            this.bohater.Name = "bohater";
            this.bohater.Size = new System.Drawing.Size(145, 182);
            this.bohater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bohater.TabIndex = 1;
            this.bohater.TabStop = false;
            this.bohater.Click += new System.EventHandler(this.bohater_Click);
            // 
            // nerf
            // 
            this.nerf.Image = ((System.Drawing.Image)(resources.GetObject("nerf.Image")));
            this.nerf.Location = new System.Drawing.Point(143, 107);
            this.nerf.Name = "nerf";
            this.nerf.Size = new System.Drawing.Size(90, 50);
            this.nerf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nerf.TabIndex = 2;
            this.nerf.TabStop = false;
            // 
            // nerf1
            // 
            this.nerf1.Image = ((System.Drawing.Image)(resources.GetObject("nerf1.Image")));
            this.nerf1.Location = new System.Drawing.Point(474, 68);
            this.nerf1.Name = "nerf1";
            this.nerf1.Size = new System.Drawing.Size(90, 50);
            this.nerf1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nerf1.TabIndex = 3;
            this.nerf1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // punkty2
            // 
            this.punkty2.AutoSize = true;
            this.punkty2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punkty2.Location = new System.Drawing.Point(358, 37);
            this.punkty2.Name = "punkty2";
            this.punkty2.Size = new System.Drawing.Size(0, 22);
            this.punkty2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(318, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "label1";
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(690, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 346);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.punkty2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nerf1);
            this.Controls.Add(this.nerf);
            this.Controls.Add(this.bohater);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bohater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nerf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nerf1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox bohater;
        private System.Windows.Forms.PictureBox nerf;
        private System.Windows.Forms.PictureBox nerf1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label punkty2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label3;
    }
}

