using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBMS
{
    public partial class loginVendor : Form
    {
        public loginVendor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationVendor register = new registrationVendor();
            register.ShowDialog();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {

                SqlCommand cmd = new SqlCommand("exec dbo.loginvendor '" + textBox1.Text + "','" + textBox2.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    vendordashboard home = new vendordashboard();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
