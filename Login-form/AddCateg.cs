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
    public partial class AddCateg : Form
    {
        public AddCateg()
        {
            InitializeComponent();
        }

        private void ExitBtnCat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void savebtnCat_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("InsertCateg", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_cat", textBox4.Text);
                cmd.Parameters.AddWithValue("@id_cat", textUsername.Text);
                cmd.Parameters.AddWithValue("@name_cat", textBox1.Text);
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
                MessageBox.Show("Error updating data (Check data you inserted)");

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
