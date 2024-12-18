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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Login
        {
            this.Hide();
            Signin login = new Signin();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) // Registration
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("exec dbo.registercustomer '" + textBox4.Text + "', '" + textBox3.Text + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox5.Text + "'", con);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
