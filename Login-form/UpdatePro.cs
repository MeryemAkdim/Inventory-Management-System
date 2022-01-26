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
    public partial class UpdatePro : Form
    {
        public UpdatePro()
        {
            InitializeComponent();
        }

        private void UpdatePro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventory_ManagementDataSet5.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.inventory_ManagementDataSet5.Category);
            // TODO: This line of code loads data into the 'inventory_ManagementDataSet4.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.inventory_ManagementDataSet4.Products);
           
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
           
            try
            {

                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UpdatePro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_prod", comboBox2.Text);
                cmd.Parameters.AddWithValue("@id_cat", comboBox1.Text);
                cmd.Parameters.AddWithValue("@name_prod", textBox3.Text);
                cmd.Parameters.AddWithValue("@price_prod", textBox2.Text);
                cmd.Parameters.AddWithValue("@quantity_prod", textBox1.Text);
                cmd.Parameters.AddWithValue("@desc_prod", textBox5.Text);
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

        private void panelUPpro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /*private void dataGridViewPro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox2.Text = dataGridViewPro.SelectedRows[0].Cells[1].Value.ToString();
        }*/
    }
}
