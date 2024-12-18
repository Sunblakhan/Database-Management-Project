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
    public partial class registrationVendor : Form
    {
        public registrationVendor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginVendor login = new loginVendor();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("exec dbo.registervendor '" + textBox4.Text + "', '" + textBox3.Text + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox5.Text + "'", con);
            int i = query.ExecuteNonQuery();

            // STEP 03 - RESPONSE TO USER
            if (i == 1)
            {
                MessageBox.Show("Account Created");
            }
            else
            {
                MessageBox.Show("Error!!");
            }

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
