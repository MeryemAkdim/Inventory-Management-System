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
    public partial class Prod : Form
    {
        public Prod()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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

       /* private void addbtn_Click(object sender, EventArgs e)
        {
            new AddProForm().Show();
            this.Hide();
        }*/

        private void panelProd_Paint(object sender, PaintEventArgs e)
        {

        }

        /*private void addbtn_Click_1(object sender, EventArgs e)
        {
            new AddProd().Show();
            this.Hide();

        }*/

        private void Prod_Load(object sender, EventArgs e)
        {
            GetProduct();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            AddProd AP = new AddProd();
            AP.Show();
            
        }

        private void Updatbtn_Click(object sender, EventArgs e)
        {
            UpdatePro UP = new UpdatePro();
            UP.Show();
        }

        private void dataGridViewPro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           // UpdatePro.comboBox2.Text = dataGridViewPro.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void dataGridViewPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           /* SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products WHERE id_prod = @id_prod ", con);
            cmd.Parameters.AddWithValue("@id_prod", textBox3.Text);
            //GetOrder();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridViewPro.DataSource = dt;*/
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("SELECT * FROM Products WHERE id_prod like '" + textBox3.Text + "%' or name_prod like '" + textBox3.Text + "%' or price_prod like '" + textBox3.Text + "%' " +
                    "or id_cat like '" + textBox3.Text + "%'", con);

                con.Open();
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridViewPro.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Searching");

            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DeletePro DP = new DeletePro();
            DP.Show();
            GetProduct();

        }

        private void dataGridViewPro_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridViewPro_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
