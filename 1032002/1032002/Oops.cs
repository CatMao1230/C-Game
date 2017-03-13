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
    public partial class Oops : Form
    {
        public Oops()
        {
            InitializeComponent();
        }

        private void Oops_DoubleClick(object sender, EventArgs e)
        {
            Ball ball = new Ball();
            ball.FormClosed += new FormClosedEventHandler(view_FormClosed); //當pianoview關閉時，返回主畫面
            ball.Show();
            this.Hide();
        }

        private void view_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Oops_Load(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
