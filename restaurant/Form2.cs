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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-B7U3SRO\SQLEXPRESS;initial catalog=resturant;integrated security=true;");
        SqlCommand majid;
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                majid = new SqlCommand("insert into customer(name,phone,time,[table]) values ('" + textBox1.Text + "'," + textBox2.Text + ",'" + dateTimePicker1.Value + "','" + comboBox1.Text + "')", con);
                con.Open();
                 majid.ExecuteNonQuery();
               
                    con.Close();


                    Form3 a = new Form3();
                    a.Show(); this.Close();
               
               
            }
            catch
            { MessageBox.Show("you must fill in the date"); }
            
               
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms["form1"].Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
