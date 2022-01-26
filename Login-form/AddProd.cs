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
    public partial class AddProd : Form
    {
        public AddProd()
        {
            InitializeComponent();
        }

       
   

        private void savebtn_Click(object sender, EventArgs e)
        {
            try { 
                 SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                 SqlCommand cmd = new SqlCommand("InsertPro", con);
                 cmd.CommandType = CommandType.StoredProcedure;
                 //cmd.Parameters.AddWithValue("@id_cat", textBox4.Text);
                 cmd.Parameters.AddWithValue("@id_cat", comboBox1.Text);
                 cmd.Parameters.AddWithValue("@name_prod", textBox3.Text);
                 cmd.Parameters.AddWithValue("@price_prod", textBox2.Text);
                 cmd.Parameters.AddWithValue("@quantity_prod", textBox1.Text);
                 cmd.Parameters.AddWithValue("@desc_prod", textBox5.Text);
                 con.Open();
                
                 int i = cmd.ExecuteNonQuery();
                
                if(i != 0)
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

        private void button1_Click(object sender, EventArgs e)
        {
            // AddProd().Exit();
            this.Hide();
        }

        private void AddProdPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxCP_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void AddProd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventory_ManagementDataSet10.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.inventory_ManagementDataSet10.Category);
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
