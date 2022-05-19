using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bohater.BackColor = Color.Transparent;
            bohater.Parent = pictureBox1;

            nerf.BackColor = Color.Transparent;
            nerf.Parent = pictureBox1;

            nerf1.BackColor = Color.Transparent;
            nerf1.Parent = pictureBox1;

            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;

            label2.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nerf.Top = nerf.Top + 20;



            if (nerf.Top > Form.ActiveForm.Height)
            {
                nerf.Top = -100;
                Random rnd = new Random();
                nerf.Left = rnd.Next(1, Form1.ActiveForm.Width);





                //punkty
                int punkty = Int32.Parse(label1.Text);
                punkty = punkty + 10;
                label1.Text = punkty.ToString();

            }
            int punkty2 = Int32.Parse(label1.Text);
            label2.Text = timer1.Interval.ToString();
            if (punkty2 % 100 == 0)
                timer2.Enabled = true;
        
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //blokada interwal
            timer1.Interval--;
            if (timer1.Interval == 1)
            {
                timer1.Interval = 2;
            }
            timer2.Enabled = false;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            nerf1.Top = nerf1.Top + 20;



            if (nerf1.Top > Form.ActiveForm.Height)
            {
                nerf1.Top = -100;
                Random rnd = new Random();
                nerf1.Left = rnd.Next(1, Form1.ActiveForm.Width);

                //punkty
                int punkty = Int32.Parse(label1.Text);
                punkty = punkty + 10;
                label1.Text = punkty.ToString();

            }
        }
        private void bohater_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                bohater.ImageLocation = @"C:\Users\MariO\Desktop\Programowanie apk\Syndra.png";
                bohater.Left = bohater.Left - 10;
                if (bohater.Left + bohater.Width < 0)
                {
                    bohater.Left = Form1.ActiveForm.Width;
                }

            }
            if (e.KeyCode == Keys.Right)
            {
                bohater.ImageLocation = @"C:\Users\MariO\Desktop\Programowanie apk\Tahm2.png";
                bohater.Left = bohater.Left + 10;
                if (bohater.Left > Form1.ActiveForm.Width)
                {
                    bohater.Left = 0 - bohater.Width;
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if ((nerf.Left > bohater.Left) && (nerf.Left < bohater.Left + bohater.Width) && (nerf.Top > nerf.Top))
            {
                label3.Text = "Kolizja";
            }
            else
                label3.Text = "0";
        }

    }
}
