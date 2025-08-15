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
    public partial class Form18 : Form
    {
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-B7U3SRO\SQLEXPRESS;initial catalog=resturant;integrated security=true;");
        SqlCommand majid;
        public Form18()
        {
            InitializeComponent();
        }

       

        private void Form18_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            majid = new SqlCommand("delete from mdrink where code=" + textBox1.Text + "", con);
            con.Open();
          int i=  majid.ExecuteNonQuery();
           if(i>0)
            MessageBox.Show("deleted successfully", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
           else
           { MessageBox.Show("enter the  date"); }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            majid = new SqlCommand("update mdrink set name='" + textBox3.Text + "',price=" + textBox2.Text + " where code=" + textBox4.Text + "", con);
            con.Open();
        int i=    majid.ExecuteNonQuery();
           if(i>0)
            MessageBox.Show("update successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
           else
           { MessageBox.Show("enter the all date"); }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            majid = new SqlCommand("insert into mdrink (name,price,code) values ('" + textBox5.Text + "'," + textBox6.Text + ","+textBox7.Text+")", con);
            con.Open();
         int i=   majid.ExecuteNonQuery();
         if(i>0)
            MessageBox.Show("added successfully", "insert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
         { MessageBox.Show("enter the all date"); }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.OpenForms["form15"].Show();
            this.Close();
        }
    }
}
