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
    public partial class Form13 : Form
    {
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-B7U3SRO\SQLEXPRESS;initial catalog=resturant;integrated security=true;");
        SqlCommand majid;
        public Form13()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms["form10"].Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            majid = new SqlCommand("delete from customer where phone=" + textBox1.Text + "", con);
            con.Open();
           int i= majid.ExecuteNonQuery();
           if(i>0)
               MessageBox.Show("deleted successfully", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
           else
           { MessageBox.Show("enter the  date"); }
            con.Close();
        }
    }
}
