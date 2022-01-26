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
    public partial class AddSup : Form
    {
        public AddSup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddSup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_ManagementDataSet7.Category' table. You can move, or remove it, as needed.
             

        }

        private void SupPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void savebtnSup_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("InsertSup", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_cat", textBox3.Text);
                cmd.Parameters.AddWithValue("@name_supplier", textUsername.Text);
                cmd.Parameters.AddWithValue("@lastname_supplier", textBox2.Text);
                cmd.Parameters.AddWithValue("@address_supplier", textBox1.Text);
                cmd.Parameters.AddWithValue("@phone_supplier", textBox4.Text);
                cmd.Parameters.AddWithValue("@quantity_commanded", textBox5.Text);
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
                MessageBox.Show("Error inserting data (Check data you inserted)");
            }
        }

        private void ExtbrnSup_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
