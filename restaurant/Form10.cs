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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 d = new Form11();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f = new Form12();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form15 a = new Form15();
            a.Show();
        }
    }
}
