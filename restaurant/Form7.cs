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
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-B7U3SRO\SQLEXPRESS;initial catalog=resturant;integrated security=true;");
        SqlCommand majid;
        SqlDataReader dr;
        public Form7()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void Form7_Load(object sender, EventArgs e)
        {
            majid = new SqlCommand("select * from mdrink ", con);
            con.Open();
            dr = majid.ExecuteReader();
            while(dr.Read())
            {
                checkedListBox1.Items.Add(dr["name"].ToString());
                checkedListBox2.Items.Add(dr["price"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            majid = new SqlCommand("insert into drinks (name,price,phone) values  ('" + checkedListBox1.Text + "','" + checkedListBox2.Text + "'," + textBox1.Text + ")", con);
            con.Open();
        int i=    majid.ExecuteNonQuery();
        if (i > 0)
            MessageBox.Show("done", "insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        else
            MessageBox.Show("enter the all date");

            con.Close();
           
        }

        

   
    }
}
