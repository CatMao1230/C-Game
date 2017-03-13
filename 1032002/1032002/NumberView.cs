using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1032002.Resources
{
    public partial class NumberView : Form
    {
        bool btip = true;
        string n, ans;//玩家輸入, 答案
        int a, b;

        private void tip_Click(object sender, EventArgs e)
        {
            btip = !btip;
            if (btip)//Show出Tip
            {
                label2.Visible = true;
                tipShow.Visible = false;
                tipClose.Visible = true;
                picTip.Visible = true;
            }
            else//關閉Tip;
            {
                label2.Visible = false;
                tipShow.Visible = true;
                tipClose.Visible = false;
                picTip.Visible = false;
            }
        }

        public NumberView()
        {
            InitializeComponent();
        }

        private void tbxNum_TextChanged(object sender, EventArgs e)
        {
            n = tbxNum.Text;
        }

        private void NumberView_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            int[] x = new int[10];
 
            for(int i = 0;i < 10;i++)
            {
	            x[i]=i;
            }

            for (int i = 0; i < 20; i++) //洗牌法 取前四
            {
                int n1 = random.Next(10);
                int n2 = random.Next(10);
                int temp = x[n1];
                x[n1] = x[n2];
                x[n2] = temp;
            }
            ans = x[0].ToString() + x[1].ToString() + x[2].ToString() + x[3].ToString();
            label1.Text = ans;
        }


        private void picCheck_Click(object sender, EventArgs e)
        {
            n = tbxNum.Text;
            a = 0;
            b = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (n[i] == ans[j])
                    {
                        if (i == j)
                            a++;
                        else
                            b++;
                    }
                }
            }
            lblAns.Text = a.ToString() + " A " + b.ToString() + " B";

            if (a == 4)
            {
                //過關
                Finish finish = new Finish();
                finish.BackGround(2);
                finish.FormClosed += new FormClosedEventHandler(view_FormClosed); //當pianoview關閉時，返回主畫面
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
