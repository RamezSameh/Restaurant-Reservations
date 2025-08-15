using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace restaurant
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-B7U3SRO\SQLEXPRESS;initial catalog=resturant;integrated security=true;");
        SqlCommand majid;
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 i = new Form5();
            i.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            majid = new SqlCommand("update customer set name='" + textBox1.Text + "',phone=" + textBox2.Text + " ,time='" + dateTimePicker1.Value + "',[table]='" + comboBox1.Text + "'  where phone=" + textBox3.Text + "", con);
            con.Open();
          int i=  majid.ExecuteNonQuery();
         if(i>0)
            MessageBox.Show("done", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
             MessageBox.Show("enter the all date");
            con.Close();
           
        }

       
    }
}
