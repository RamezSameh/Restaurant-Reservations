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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 d = new Form6();
            d.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 d = new Form7();
            d.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 d = new Form8();
            d.Show();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 d = new Form9();
            d.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 m= new Form3();
            m.Show();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

      
    }
}
