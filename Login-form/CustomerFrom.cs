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
    public partial class CustomerFrom : Form
    {
        public CustomerFrom()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");

        void GetCustomers()
        {
            try
            {
                SqlCommand c = new SqlCommand("EXEC ListCust", con);
                SqlDataAdapter sd = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridViewCust.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Listing");

            }
        }

        private void addbtnCus_Click(object sender, EventArgs e)
        {
            AddCus AC = new AddCus();
            AC.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            GetCustomers();
        }

        private void dataGridViewCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdatbtnCus_Click(object sender, EventArgs e)
        {
            UpdateCus UC = new UpdateCus();
            UC.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("SELECT * FROM Customers WHERE id_cust like '" + textBox3.Text + "%' or name_cust like '" + textBox3.Text + "%' or lastname_cust like '" + textBox3.Text + "%' ", con);
                // cmd = new SqlCommand("SELECT * FROM Suppliers WHERE name_supplier like '" + textBox3.Text + "%'", con);

                con.Open();
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridViewCust.DataSource = dt;
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Error Searching");

            }
        }

        private void DeletebtnCus_Click(object sender, EventArgs e)
        {
            DeleteCust DS = new DeleteCust();
            DS.Show();
        }
    }
}
