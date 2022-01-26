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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventory_ManagementDataSet17.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.inventory_ManagementDataSet17.Customers);
            // TODO: This line of code loads data into the 'inventory_ManagementDataSet16.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.inventory_ManagementDataSet16.Products);
           
     
           
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("InsertOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@id_order", comboBox4.Text);
                cmd.Parameters.AddWithValue("@id_prod", comboBox1.Text);
                cmd.Parameters.AddWithValue("@id_cust", comboBox2.Text);
                cmd.Parameters.AddWithValue("@quantity_order", textBox1.Text);
                cmd.Parameters.AddWithValue("@date_order", textBox3.Text);
                cmd.Parameters.AddWithValue("@uprice", textBox2.Text);
                con.Open();

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Successfully ");
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Inserting \n\t Check if there is enough quantity");
            }

        }
  
    }
}
