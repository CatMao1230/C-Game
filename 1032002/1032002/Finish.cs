using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _1032002.Resources;

namespace _1032002
{
    public partial class Finish : Form
    {
        int number = 0;

        public Finish()
        {
            InitializeComponent();
        }

        public void BackGround(int n)
        {
            number = n;
            switch (n)
            {
                case 0:
                    pictureBox1.Visible = true;
                    break;
                case 1:
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    break;
                case 2:
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    break;
                case 3:
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    break;

            }
        }

        private void Finish_Load(object sender, EventArgs e)
        {

        }

        private void Finish_MouseClick(object sender, MouseEventArgs e)
        {
            switch(number){
                case 0:
                case 4:
                    Ball ball = new Ball();
                    ball.FormClosed += new FormClosedEventHandler(view_FormClosed);
                    ball.Show();
                    this.Hide();
                    break;

                case 1:
                    NumberView numberview = new NumberView();
                    numberview.FormClosed += new FormClosedEventHandler(view_FormClosed);
                    numberview.Show();
                    this.Hide();
                    break;

                case 2:
                    CardView cardview = new CardView();
                    cardview.FormClosed += new FormClosedEventHandler(view_FormClosed);
                    cardview.Show();
                    this.Hide();
                    break;

                case 3:
                    Form1 form1 = new Form1();
                    form1.FormClosed += new FormClosedEventHandler(view_FormClosed); //當pianoview關閉時，返回主畫面
                    form1.Show();
                    this.Hide();
                    break;

                default:
                    break;
            }
        }

        private void view_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
