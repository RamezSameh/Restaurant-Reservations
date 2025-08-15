using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.OpenForms["form1"].Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            a.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 s = new Form6();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 s = new Form7();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 s = new Form8();
            s.Show();
        }
    }
}
