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
    public partial class CardView : Form
    {
        bool btip = true;
        Random random = new Random();
        int count = 0;
        int anscount = 0;
        int ans = 0; //選了幾個卡片
        int[] x = new int[10];//0 ~ 9
        int[] B = new int[3];//題目
        int[] temp = new int[3];

        private void tip_Click(object sender, EventArgs e)
        {
            btip = !btip;
            if (btip)//Show出Tip
            {
                timer1.Enabled = false;
                label2.Visible = true;
                tipShow.Visible = false;
                tipClose.Visible = true;
                picTip.Visible = true;
            }
            else//關閉Tip;
            {
                timer1.Enabled = true;
                label2.Visible = false;
                tipShow.Visible = true;
                tipClose.Visible = false;
                picTip.Visible = false;
            }
        }

        public CardView()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 4)//覆蓋題目 並掀開作答區
            {
                timer1.Stop();
                count = 0;
                picB0.Image = imageList1.Images[10];//10為卡背
                picB1.Image = imageList1.Images[10];
                picB2.Image = imageList1.Images[10];

                picA0.Image = imageList1.Images[x[0]];
                picA1.Image = imageList1.Images[x[1]];
                picA2.Image = imageList1.Images[x[2]];
                picA3.Image = imageList1.Images[x[3]];
                picA4.Image = imageList1.Images[x[4]];
                picA0.Enabled = true;
                picA1.Enabled = true;
                picA2.Enabled = true;
                picA3.Enabled = true;
                picA4.Enabled = true;
            }
        }

        private void CardView_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                x[i] = i;
            }
            SetBCard();
        }

        private void SetACard()//作答區
        {
            for (int i = 0; i < 10; i++) //洗牌法 取前三 作為題目 前五則為作答區
            {
                int n1 = random.Next(5);//只會換到0~4 前五個
                int n2 = random.Next(5);//只會換到0~4 前五個
                int temp = x[n1];
                x[n1] = x[n2];
                x[n2] = temp;
            }
        }

        private void SetBCard()//題目區
        {
            ans = 0;
            picA0.Image = imageList1.Images[10];
            picA1.Image = imageList1.Images[10];
            picA2.Image = imageList1.Images[10];
            picA3.Image = imageList1.Images[10];
            picA4.Image = imageList1.Images[10];

            timer1.Enabled = true;

            for (int i = 0; i < 20; i++) //洗牌法 取前三 作為題目 前五則為作答區
            {
                int n1 = random.Next(10);
                int n2 = random.Next(10);
                int temp = x[n1];
                x[n1] = x[n2];
                x[n2] = temp;
            }
            picB0.Image = imageList1.Images[x[0]];
            picB1.Image = imageList1.Images[x[1]];
            picB2.Image = imageList1.Images[x[2]];
            for (int i = 0; i < 3; i++)
            {
                B[i] = x[i];
            }
                SetACard();
        }

        private void Check(int n)
        {
            temp[ans] = x[n];
            ans++;

            if (ans == 3)
            {
                if (temp[0] == B[0] && temp[1] == B[1] && temp[2] == B[2])
                {
                    //答對！
                    MessageBox.Show("答對了！");
                    anscount++;
                    label1.Text = "答對題數：" + anscount.ToString();
                    if (anscount == 3)
                    {
                        //過關
                        Finish finish = new Finish();
                        finish.BackGround(3);
                        finish.FormClosed += new FormClosedEventHandler(view_FormClosed); //當pianoview關閉時，返回主畫面
                        finish.Show();
                        this.Hide();
                    }
                    else
                    {
                        SetBCard();
                    }
                }
                else
                {
                    //答錯！
                    MessageBox.Show("答錯了！");
                }
                ans = 0;
            }
        }

        private void picA0_Click(object sender, EventArgs e)
        {
            Check(0);
        }

        private void picA1_Click(object sender, EventArgs e)
        {
            Check(1);
        }

        private void picA2_Click(object sender, EventArgs e)
        {
            Check(2);
        }

        private void picA3_Click(object sender, EventArgs e)
        {
            Check(3);
        }

        private void picA4_Click(object sender, EventArgs e)
        {
            Check(4);
        }

        private void view_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count = 0;
            SetBCard();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
