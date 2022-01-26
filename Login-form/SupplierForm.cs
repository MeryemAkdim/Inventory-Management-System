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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");

        void GetSupplier()
        {
            try
            {
                SqlCommand c = new SqlCommand("EXEC ListSup", con);
                SqlDataAdapter sd = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridViewSup.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Listing");

            }
        }
        private void addbtnSup_Click(object sender, EventArgs e)
        {
            AddSup AS = new AddSup();
            AS.Show();
        }

        private void panelSupplier_Paint(object sender, PaintEventArgs e)
        {
            GetSupplier();
        }

        private void dataGridViewSup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdatbtnSup_Click(object sender, EventArgs e)
        {
            UpdateSupcs US = new UpdateSupcs();
            US.Show();
        }

        private void dataGridViewSup_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("SELECT * FROM Suppliers WHERE id_supplier like '" + textBox3.Text + "%' or name_supplier like '" + textBox3.Text + "%' or lastname_supplier like '" + textBox3.Text + "%' " +
                    "or id_cat like '" + textBox3.Text + "%'", con);
                // cmd = new SqlCommand("SELECT * FROM Suppliers WHERE name_supplier like '" + textBox3.Text + "%'", con);

                con.Open();
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridViewSup.DataSource = dt;
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Error Searching");

            }
        }

        private void DeletebtnSup_Click(object sender, EventArgs e)
        {
            DeleteSup DS = new DeleteSup();
            DS.Show();
        }
    }
}
