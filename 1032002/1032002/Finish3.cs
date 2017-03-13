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
    public partial class Finish3 : Form
    {
        public Finish3()
        {
            InitializeComponent();
        }

        private void Finish3_MouseClick(object sender, MouseEventArgs e)
        {
            CardView cardview = new CardView();
            cardview.FormClosed += new FormClosedEventHandler(view_FormClosed); //當pianoview關閉時，返回主畫面
            cardview.Show();
            this.Hide();
        }

        private void view_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Finish3_Load(object sender, EventArgs e)
        {

        }
        
    }
}
