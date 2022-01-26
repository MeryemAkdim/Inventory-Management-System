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
    public partial class CategMan : Form
    {
        public CategMan()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
        
        void GetCategory()
        {
            try
            {
                SqlCommand c = new SqlCommand("EXEC ListCateg", con);
                SqlDataAdapter sd = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridViewCat.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error In Listing Data");

            }
        }

        private void addbtn_Click(object sender, EventArgs e)

        {
            AddCateg AC = new AddCateg();
            AC.Show();
        }

        private void CategMan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_ManagementDataSet14.Category' table. You can move, or remove it, as needed.
           // //this.categoryTableAdapter.Fill(this.stock_ManagementDataSet14.Category);
            
            GetCategory();
        }

        private void dataGridViewCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //textUsername.Text = dataGridViewCat.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void UpdatbtnCat_Click(object sender, EventArgs e)
        {
            UpdateCateg UC = new UpdateCateg();
            UC.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("SELECT * FROM Category WHERE id_cat like '" + textBox3.Text + "%' or name_cat like '" + textBox3.Text + "%'", con);
                // cmd = new SqlCommand("SELECT * FROM Suppliers WHERE name_supplier like '" + textBox3.Text + "%'", con);

                con.Open();
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridViewCat.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Searching");

            }
        }

        private void DeletebtnCat_Click(object sender, EventArgs e)
        {
            DeleteCat DC = new DeleteCat();
            DC.Show();
        }
    }
}
