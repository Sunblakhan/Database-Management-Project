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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ecommerceDataSet13.view_invoice' table. You can move, or remove it, as needed.
            this.view_invoiceTableAdapter.Fill(this.ecommerceDataSet13.view_invoice);
            // TODO: This line of code loads data into the 'ecommerceDataSet6.vendor' table. You can move, or remove it, as needed.
            this.vendorTableAdapter.Fill(this.ecommerceDataSet6.vendor);
            // TODO: This line of code loads data into the 'ecommerceDataSet5.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.ecommerceDataSet5.customer);
            // TODO: This line of code loads data into the 'ecommerceDataSet4.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.ecommerceDataSet4.Product);
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
           
            SqlCommand Customer = new SqlCommand("select count(*) from customer", Conn);
            SqlCommand Vendor = new SqlCommand("select count(*) from vendor", Conn);
            SqlCommand Product = new SqlCommand("select count(*) from product", Conn);
            Conn.Open();
            
           
            SqlDataReader DR2 = Customer.ExecuteReader();
            if (DR2.Read())
            {
                textBox3.Text = DR2.GetValue(0).ToString();
            }
            DR2.Close();
            SqlDataReader DR3 = Vendor.ExecuteReader();
            if (DR3.Read())
            {
                textBox4.Text = DR3.GetValue(0).ToString();
            }
            DR3.Close();
            SqlDataReader DR4 = Product.ExecuteReader();
            if (DR4.Read())
            {
                textBox6.Text = DR4.GetValue(0).ToString();
            }
            DR4.Close();
           

            Conn.Close();

        }


        private void button4_Click(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("SELECT * FROM vendor WHERE Id = " + textBox5.Text, con);
            query.ExecuteNonQuery();

            DataTable tab = new DataTable();
            SqlDataAdapter tab1 = new SqlDataAdapter(query);
            tab1.Fill(tab);
            dataGridView2.DataSource = tab;

            // STEP 03 - RESPONSE TO USER

            con.Close();
            this.vendorTableAdapter.Fill(this.ecommerceDataSet6.vendor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("SELECT * FROM customer WHERE Id = " + textBox7.Text, con);
            query.ExecuteNonQuery();

            DataTable tab = new DataTable();
            SqlDataAdapter tab1 = new SqlDataAdapter(query);
            tab1.Fill(tab);
            dataGridView1.DataSource = tab;

            // STEP 03 - RESPONSE TO USER

            con.Close();
            this.customerTableAdapter.Fill(this.ecommerceDataSet5.customer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("SELECT * FROM product WHERE Id = " + textBox8.Text, con);
            query.ExecuteNonQuery();

            DataTable tab = new DataTable();
            SqlDataAdapter tab1 = new SqlDataAdapter(query);
            tab1.Fill(tab);
            dataGridView4.DataSource = tab;

            // STEP 03 - RESPONSE TO USER

            con.Close();
            this.productTableAdapter.Fill(this.ecommerceDataSet4.Product);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
