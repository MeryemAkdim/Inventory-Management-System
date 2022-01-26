using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_form
{
    public partial class Homeform : Form
    {
        public Homeform()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");


        private void label1_Click(object sender, EventArgs e)
        {
            
            /*SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            label1.DataSource = dt;*/


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            //IDataReader reader = c.ExecuteReader();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
            SqlCommand c = new SqlCommand("SELECT count(*) FROM Orders Group by id_order", con);
            var value = (String)c.ExecuteScalar();
            label1.Text = value;*/
            
            
        }

        private void Homeform_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("SELECT count(*) From Orders ", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            label1.Text = dt.Rows[0][0].ToString();
            con.Close();

         
            SqlDataAdapter sd2 = new SqlDataAdapter("SELECT count(*) From Customers ", con);
            DataTable dt2 = new DataTable();
            sd2.Fill(dt2);
            label3.Text = dt2.Rows[0][0].ToString();
            con.Close();


            SqlDataAdapter sd3 = new SqlDataAdapter("SELECT count(*) From Products ", con);
            DataTable dt3 = new DataTable();
            sd3.Fill(dt3);
            label5.Text = dt3.Rows[0][0].ToString();
            con.Close();

            SqlDataAdapter sd4 = new SqlDataAdapter("SELECT count(*) From Suppliers ", con);
            DataTable dt4 = new DataTable();
            sd4.Fill(dt4);
            label7.Text = dt4.Rows[0][0].ToString();

            con.Close();


        }
    }
}
