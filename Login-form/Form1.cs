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
    public partial class Form1 : Form
    {
        SqlConnection con;
        //SqlCommand cmd;
        //SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.;Initial Catalog=Inventory_Management;Integrated Security=True");

        }

        /*public void loadform(object Form)
        {
            if(this.mainpanel.Controls.Count > 0)
        } */

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textUsename_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            //if(textPassword.Checked == )
        }

        private void Logbtn_Click(object sender, EventArgs e)
        {

            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM User_Man WHERE user_name = '" + 
                textUsername.Text + "'AND user_password = '" + textPassword.Text + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                ManageUsers MU = new ManageUsers();
                MU.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password \n Please try again");
            }
            
            con.Close();

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void textUsername_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
