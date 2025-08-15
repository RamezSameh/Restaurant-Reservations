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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.OpenForms["form10"].Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 s = new Form14();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form18 s = new Form18();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form19 s = new Form19();
            s.Show();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }
    }
}
