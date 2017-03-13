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
    public partial class Finish2 : Form
    {
        public Finish2()
        {
            InitializeComponent();
        }

        private void Finish2_MouseClick(object sender, MouseEventArgs e)
        {
            NumberView numberview = new NumberView();
            numberview.FormClosed += new FormClosedEventHandler(view_FormClosed); //當pianoview關閉時，返回主畫面
            numberview.Show();
            this.Hide();
        }

        private void view_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Finish2_Load(object sender, EventArgs e)
        {

        }

    }
}
