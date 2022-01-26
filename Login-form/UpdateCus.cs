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
    public partial class UpdateCus : Form
    {
        public UpdateCus()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UpdateCus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventory_ManagementDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.inventory_ManagementDataSet.Customers);
            

        }

        private void savebtnSup_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UpdateCusts", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_cust", comboBox3.Text);
                cmd.Parameters.AddWithValue("@name_cust", textUsername.Text);
                cmd.Parameters.AddWithValue("@lastname_cust", textBox2.Text);
                cmd.Parameters.AddWithValue("@address_cust", textBox1.Text);
                cmd.Parameters.AddWithValue("@phone_cust", textBox4.Text);
                con.Open();

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Successfully Updated");
                }



                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Updating Check the data inserted");

            }

        }

        private void panelUpCus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExtbrnSup_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
