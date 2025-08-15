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
    public partial class Form11 : Form
    {
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-B7U3SRO\SQLEXPRESS;initial catalog=resturant;integrated security=true;");
        SqlCommand ramez;
        SqlDataReader dr;
        public Form11()
        {
            InitializeComponent();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["form10"].Show();
            this.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            ramez = new SqlCommand("select*from customer", con);
            con.Open();
            dr = ramez.ExecuteReader();
            while(dr.Read())
            {
                listBox1.Items.Add(dr["name"].ToString());
                listBox2.Items.Add(dr["phone"].ToString());
                listBox3.Items.Add(dr["time"].ToString());
                listBox4.Items.Add(dr["table"].ToString());

            }
            dr.Close();
            con.Close();
        }
    }
}
