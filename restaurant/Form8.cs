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
    public partial class Form8 : Form
    {
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-B7U3SRO\SQLEXPRESS;initial catalog=resturant;integrated security=true;");
        SqlCommand majid;
        SqlDataReader dr;
        public Form8()
        {
            InitializeComponent();
        }

     

        private void Form8_Load(object sender, EventArgs e)
        {
            majid = new SqlCommand("select * from mdessert ", con);
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
            majid = new SqlCommand("insert into desserts (name,price,phone) values ('" + checkedListBox1.Text + "','" + checkedListBox2.Text + "'," + textBox1.Text + ")", con);
            con.Open();
          int i=  majid.ExecuteNonQuery();
           if(i>0)
            MessageBox.Show("done", "insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
           else
               MessageBox.Show("enter the all date");
            con.Close();
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

       
    }
}
