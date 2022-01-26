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
    public partial class UpdateSupcs : Form
    {
        public UpdateSupcs()
        {
            InitializeComponent();
        }

        private void savebtnSup_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateSupcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventory_ManagementDataSet7.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.inventory_ManagementDataSet7.Category);
            // TODO: This line of code loads data into the 'inventory_ManagementDataSet6.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.inventory_ManagementDataSet6.Suppliers);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                  SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                  SqlCommand cmd = new SqlCommand("UpdateSupp", con);
                  cmd.CommandType = CommandType.StoredProcedure;
                  
                  cmd.Parameters.AddWithValue("@id_supplier", comboBox1.Text);
                  cmd.Parameters.AddWithValue("@id_cat", comboBox3.Text);
                  cmd.Parameters.AddWithValue("@name_supplier", textBox7.Text);
                  cmd.Parameters.AddWithValue("@lastname_supplier", textBox8.Text);
                  cmd.Parameters.AddWithValue("@address_supplier", textBox9.Text);
                  cmd.Parameters.AddWithValue("@phone_supplier", textBox6.Text);
                  //cmd.Parameters.AddWithValue("@quantity_commanded", textBox3.Text);
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
            MessageBox.Show("Error inserting data (Check data you inserted)");
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
