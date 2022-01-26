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
    public partial class DeleteOrd : Form
    {
        public DeleteOrd()
        {
            InitializeComponent();
        }

        private void DeleteOrd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventory_ManagementDataSet14.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.inventory_ManagementDataSet14.Orders);

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delet?", "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("DELETE Orders WHERE id_order = '" + this.comboBox3.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Make sure that you deleted all orders of this customer");
                }
            }
        }
    }
    
}
