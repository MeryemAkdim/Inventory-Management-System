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
    public partial class UpdateOrder : Form
    {
        public UpdateOrder()
        {
            InitializeComponent();
        }

        private void UpdateOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventory_ManagementDataSet3.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.inventory_ManagementDataSet3.Customers);
            // TODO: This line of code loads data into the 'inventory_ManagementDataSet2.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.inventory_ManagementDataSet2.Orders);
            // TODO: This line of code loads data into the 'inventory_ManagementDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.inventory_ManagementDataSet1.Products);

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdBtn_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UpdatetOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_order", comboBox4.Text);
                cmd.Parameters.AddWithValue("@id_prod", comboBox6.Text);
                cmd.Parameters.AddWithValue("@id_cust", comboBox5.Text);
                cmd.Parameters.AddWithValue("@quantity_order", textBox6.Text);
                cmd.Parameters.AddWithValue("@date_order", textBox5.Text);
                cmd.Parameters.AddWithValue("@uprice", textBox4.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}


