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
    public partial class Form12 : Form
    {
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-B7U3SRO\SQLEXPRESS;initial catalog=resturant;integrated security=true;");
        SqlCommand majid;
        SqlDataReader dr;
        public Form12()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                majid = new SqlCommand("select name from foods where phone=" + textBox1.Text + "", con);
                con.Open();
                dr = majid.ExecuteReader();
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["name"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch
            { MessageBox.Show("enter the all date"); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms["form10"].Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                majid = new SqlCommand("select name from drinks where phone=" + textBox1.Text + "", con);
                con.Open();
                dr = majid.ExecuteReader();
                while (dr.Read())
                {
                    listBox2.Items.Add(dr["name"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch
            { MessageBox.Show("enter the all date"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                majid = new SqlCommand("select name from desserts where phone=" + textBox1.Text + "", con);
                con.Open();
                dr = majid.ExecuteReader();
                while (dr.Read())
                {
                    listBox3.Items.Add(dr["name"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch
            { MessageBox.Show("enter the all date"); }
        }
    }
}
