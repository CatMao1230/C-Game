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
    public partial class Finish4 : Form
    {
        public Finish4()
        {
            InitializeComponent();
        }

        private void Finish4_Load(object sender, EventArgs e)
        {

        }

        private void Finish4_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.FormClosed += new FormClosedEventHandler(view_FormClosed); //當pianoview關閉時，返回主畫面
            form1.Show();
            this.Hide();
        }

        private void view_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
