using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1032002
{
    public partial class Ball : Form
    {
        int counter = 0;
        int Vx = 10;
        int Vy = 10;
        bool btip = true;

        public Ball()
        {
            InitializeComponent();
        }

        private void Ball_Load(object sender, EventArgs e)
        {

        }

        private void tip_Click(object sender, EventArgs e)
        {
            btip = !btip;
            if (btip)//Show出Tip
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                label1.Visible = true;
                tipShow.Visible = false;
                tipClose.Visible = true;
                picTip.Visible = true;
            }
            else//關閉Tip;
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                label1.Visible = false;
                tipShow.Visible = true;
                tipClose.Visible = false;
                picTip.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball1.Left += Vx;
            ball1.Top += Vy;
            if (ball1.Left < 0)
            {
                Vx = -Vx;
            }
            if (ball1.Right > this.Width)
            {
                Vx = -Vx;
            }
            if (ball1.Top < 0)
            {
                Vy = -Vy;
            }
            if (ball1.Bottom > picbar.Top)
            {
                int c = (ball1.Left + ball1.Right) / 2;
                if (c >= picbar.Left && c <= picbar.Right)
                {
                    Vy = -Vy;
                }
                else
                {
                    if (ball1.Bottom > this.ClientSize.Height)//失敗
                    {
                        timer1.Stop();
                        timer2.Stop();
                        Oops oops = new Oops();
                        oops.FormClosed += new FormClosedEventHandler(view_FormClosed);
                        oops.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void Ball_MouseMove(object sender, MouseEventArgs e)
        {
            picbar.Left = e.X - 75;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter++;
            lblTimer.Text = counter.ToString();
            if (counter == 5)
            {
                timer1.Interval = 30;
            }
            if (counter == 10)
            {
                timer1.Interval = 18;
            }
            if (counter == 15)//過關
            {
                timer1.Stop();
                timer2.Stop();
                Finish finish = new Finish();
                finish.BackGround(1);
                finish.FormClosed += new FormClosedEventHandler(view_FormClosed);
                finish.Show();
                this.Hide();
            }
        }

        private void view_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
