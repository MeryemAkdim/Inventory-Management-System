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
    public partial class AddCus : Form
    {
        public AddCus()
        {
            InitializeComponent();
        }

        private void ExtbrnSup_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void savebtnSup_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("InsertCust", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_cat", textBox4.Text);
                // cmd.Parameters.AddWithValue("@name_cust", textBox3.Text);
                cmd.Parameters.AddWithValue("@name_cust", textUsername.Text);
                cmd.Parameters.AddWithValue("@lastname_cust", textBox2.Text);
                cmd.Parameters.AddWithValue("@address_cust", textBox1.Text);
                cmd.Parameters.AddWithValue("@phone_cust", textBox4.Text);
                con.Open();

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Successfully Inserted");
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Inserting Check the data inserted");
            }

        }

        private void AddCus_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
