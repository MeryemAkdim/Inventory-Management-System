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
    public partial class SellBill : Form
    {
        public SellBill()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");


        void GetProduct()
        {
            try
            {
                SqlCommand c = new SqlCommand("EXEC ListProd", con);
                SqlDataAdapter sd = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridViewPro.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Listing");

            }
        }

        void GetBill()
        {
            try
            {
                SqlCommand c = new SqlCommand("SELECT * FROM Bill", con);
                SqlDataAdapter sd = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridViewBill.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Listing");

            }
        }

        private void SellBill_Load(object sender, EventArgs e)
        {
            GetProduct();
            GetBill();

        }

        private void AddBillbtn_Click(object sender, EventArgs e)
        {
            try
            {
                 SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                 SqlCommand cmd = new SqlCommand("InsertBill", con);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@id_prod", textBox4.Text);
                 cmd.Parameters.AddWithValue("@name_prod", textBox3.Text);
                 cmd.Parameters.AddWithValue("@price_prod", textBox2.Text);
                 cmd.Parameters.AddWithValue("@quantity_prod", textBox1.Text);
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
                 MessageBox.Show("Error Inserting Check the data inserted");
             }

            SqlDataAdapter sd = new SqlDataAdapter("SELECT SUM(total) From Bill ", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            labelRs.Text = dt.Rows[0][0].ToString();

        }

        private void dataGridViewPro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridViewPro.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridViewPro.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridViewPro.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
