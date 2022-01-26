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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");

        void GetOrder()
        {
            try
            {
                SqlCommand c = new SqlCommand("EXEC ListOr", con);
                SqlDataAdapter sd = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridViewOrd.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Successfully Inserted");

            }
        }

        private void addbtnOrder_Click(object sender, EventArgs e)
        {
            AddOrder AO = new AddOrder();
            AO.Show();
        }

        private void Order_panel_Paint(object sender, PaintEventArgs e)
        {
             GetOrder();
        }

        private void UpdatbtnOrder_Click(object sender, EventArgs e)
        {
            UpdateOrder UP = new UpdateOrder();
            UP.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*(dataGridViewOrd.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("id_order like '%" + textBox3.Text + "%'");*/
            /*SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders WHERE id_order = @id_order ", con);
            cmd.Parameters.AddWithValue("@id_order", textBox3.Text);
            //GetOrder();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridViewOrd.DataSource = dt;*/

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("SELECT * FROM Orders WHERE id_order like '" + textBox3.Text + "%' or id_prod like '" + textBox3.Text + "%' or id_cust like '" + textBox3.Text + "%' ", con);

                con.Open();
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridViewOrd.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Searching");

            }


        }

        private void DeletebtnOrder_Click(object sender, EventArgs e)
        {
            DeleteOrd DO = new DeleteOrd();
            DO.Show();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
