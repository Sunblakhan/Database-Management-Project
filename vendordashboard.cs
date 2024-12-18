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
    public partial class vendordashboard : Form
    {
        public vendordashboard()
        {
            InitializeComponent();
        }

        private void vendordashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ecommerceDataSet2.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.ecommerceDataSet2.Product);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("insert into product values (" + textBox9.Text + ",'" + textBox8.Text+ "', '" + textBox7.Text + "' ," + textBox6.Text + "," + textBox5.Text+ ")", con);
            int i = query.ExecuteNonQuery();

            // STEP 03 - RESPONSE TO USER
            if (i == 1)
            {
                MessageBox.Show("Product Added");
            }
            else
            {
                MessageBox.Show("Error!!");
            }

            /* DataTable tab = new DataTable();
             SqlDataAdapter tab1 = new SqlDataAdapter(query);
             tab1.Fill(tab);
             dataGridView2.DataSource = tab; */

            // STEP 03 - RESPONSE TO USER

            con.Close();
            this.productTableAdapter.Fill(this.ecommerceDataSet2.Product);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
          SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("update product set quantity = " + textBox1.Text + " WHERE ID = " + textBox4.Text, con);
            query.ExecuteNonQuery();

            /* DataTable tab = new DataTable();
             SqlDataAdapter tab1 = new SqlDataAdapter(query);
             tab1.Fill(tab);
             dataGridView2.DataSource = tab; */

            // STEP 03 - RESPONSE TO USER

            con.Close();
            this.productTableAdapter.Fill(this.ecommerceDataSet2.Product);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("update product set price = " + textBox2.Text + " WHERE ID = " + textBox4.Text, con);
            query.ExecuteNonQuery();

            /* DataTable tab = new DataTable();
             SqlDataAdapter tab1 = new SqlDataAdapter(query);
             tab1.Fill(tab);
             dataGridView2.DataSource = tab; */

            // STEP 03 - RESPONSE TO USER

            con.Close();
            this.productTableAdapter.Fill(this.ecommerceDataSet2.Product);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("update product set Name = '" + textBox3.Text + "' WHERE ID = " + textBox4.Text, con);
            query.ExecuteNonQuery();

            /* DataTable tab = new DataTable();
             SqlDataAdapter tab1 = new SqlDataAdapter(query);
             tab1.Fill(tab);
             dataGridView2.DataSource = tab; */

            // STEP 03 - RESPONSE TO USER

            con.Close();
            this.productTableAdapter.Fill(this.ecommerceDataSet2.Product);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("delete from product WHERE ID = " + textBox4.Text, con);
            query.ExecuteNonQuery();

            /* DataTable tab = new DataTable();
             SqlDataAdapter tab1 = new SqlDataAdapter(query);
             tab1.Fill(tab);
             dataGridView2.DataSource = tab; */

            // STEP 03 - RESPONSE TO USER

            con.Close();
            this.productTableAdapter.Fill(this.ecommerceDataSet2.Product);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            VendorProfile profile = new VendorProfile();
            profile.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home profile = new Home();
            profile.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
