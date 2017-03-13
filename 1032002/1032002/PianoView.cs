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
    public partial class PianoView : Form
    {
        int[] sound = { 261, 293, 329, 349, 392, 440, 494 };
        string bee = "644533234566664453324662";
        int count = 0;//24over
        char press = '0';//現在按哪個音 0~9
        bool btip = true;

        public PianoView()
        {
            InitializeComponent();
        }

        private void PianoView_Load(object sender, EventArgs e)
        {

        }

        private void PianoView_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'A':
                case 'a':
                    press = '0';
                    System.Console.Beep(sound[5] / 2, 200);
                    break;

                case 'S':
                case 's':
                    press = '1';
                    System.Console.Beep(sound[6] / 2, 200);
                    break;

                case 'D':
                case 'd':
                    press = '2';
                    System.Console.Beep(sound[0], 200);
                    break;

                case 'F':
                case 'f':
                    press = '3';
                    System.Console.Beep(sound[1], 200);
                    break;

                case 'G':
                case 'g':
                    press = '4';
                    System.Console.Beep(sound[2], 200);
                    break;

                case 'H':
                case 'h':
                    press = '5';
                    System.Console.Beep(sound[3], 200);
                    break;

                case 'J':
                case 'j':
                    press = '6';
                    System.Console.Beep(sound[4], 200);
                    break;

                case 'K':
                case 'k':
                    press = '7';
                    System.Console.Beep(sound[5], 200);
                    break;

                case 'L':
                case 'l':
                    press = '8';
                    System.Console.Beep(sound[6], 200);
                    break;

                case ';':
                case ':':
                    press = '9';
                    System.Console.Beep(sound[0] * 2, 200);
                    break;

                default:
                    break;
            }

            if (press == bee[count])
            {
                count++;
                if (count == 24)
                {
                    //遊戲結束
                    Finish finish = new Finish();
                    finish.BackGround(0);
                    finish.FormClosed += new FormClosedEventHandler(view_FormClosed); //當pianoview關閉時，返回主畫面
                    finish.Show();
                    this.Hide();
                }
            }
            else
            {
                count = 0;
            }
            
        }

        private void view_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            System.Console.Beep(sound[5] / 2, 200);
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            System.Console.Beep(sound[6] / 2, 200);
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            System.Console.Beep(sound[0], 200);
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            System.Console.Beep(sound[1], 200);
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            System.Console.Beep(sound[2], 200);
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            System.Console.Beep(sound[3], 200);
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            System.Console.Beep(sound[4], 200);
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            System.Console.Beep(sound[5], 200);
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            System.Console.Beep(sound[6], 200);
        }

        private void pic10_Click(object sender, EventArgs e)
        {
            System.Console.Beep(sound[0] * 2, 200);
        }

        private void tip_Click(object sender, EventArgs e)
        {
            btip = !btip;
            if (btip)//Show出Tip
            {
                label1.Visible = false;
                label2.Visible = true;
                tipShow.Visible = false;
                tipClose.Visible = true;
                picTip.Visible = true;
            }
            else//關閉Tip;
            {
                label1.Visible = true;
                label2.Visible = false;
                tipShow.Visible = true;
                tipClose.Visible = false;
                picTip.Visible = false;
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
