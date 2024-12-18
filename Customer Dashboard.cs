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
    public partial class Customer_Dashboard : Form
    {
        public Customer_Dashboard()
        {
            InitializeComponent();
        }

        private void Customer_Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ecommerceDataSet12.order_' table. You can move, or remove it, as needed.
            this.order_TableAdapter1.Fill(this.ecommerceDataSet12.order_);
            // TODO: This line of code loads data into the 'ecommerceDataSet9.order_' table. You can move, or remove it, as needed.
            //this.order_TableAdapter.Fill(this.ecommerceDataSet9.order_);
            // TODO: This line of code loads data into the 'ecommerceDataSet1.cart' table. You can move, or remove it, as needed.
            //this.cartTableAdapter.Fill(this.ecommerceDataSet1.cart);
            // TODO: This line of code loads data into the 'ecommerceDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.ecommerceDataSet.Product);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("SELECT * FROM Product WHERE NAME like '%" + textBox1.Text + "%'", con);
            query.ExecuteNonQuery();

            DataTable tab = new DataTable();
            SqlDataAdapter tab1 = new SqlDataAdapter(query);
            tab1.Fill(tab);
            dataGridView1.DataSource = tab;

            // STEP 03 - RESPONSE TO USER

            con.Close();
            this.productTableAdapter.Fill(this.ecommerceDataSet.Product);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("SELECT * FROM Product WHERE Id = " + textBox2.Text, con);
            query.ExecuteNonQuery();

            DataTable tab = new DataTable();
            SqlDataAdapter tab1 = new SqlDataAdapter(query);
            tab1.Fill(tab);
            dataGridView1.DataSource = tab;

            // STEP 03 - RESPONSE TO USER

            con.Close();
            this.productTableAdapter.Fill(this.ecommerceDataSet.Product);

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("insert into order_ values ("+textBox7.Text+","+textBox3.Text+ ", (select price *" +textBox3.Text+ " from product where Id = " + textBox4.Text + "), " + textBox4.Text + " )", con);
            query.ExecuteNonQuery();


            /*DataTable tab = new DataTable();
            SqlDataAdapter tab1 = new SqlDataAdapter(query);
            tab1.Fill(tab);
            dataGridView2.DataSource = tab; */


            // STEP 03 - RESPONSE TO USER

            con.Close();
            this.order_TableAdapter1.Fill(this.ecommerceDataSet12.order_);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("exec update_order_qty  " + textBox5.Text + "," + textBox6.Text , con);
            query.ExecuteNonQuery();

           /* DataTable tab = new DataTable();
            SqlDataAdapter tab1 = new SqlDataAdapter(query);
            tab1.Fill(tab);
            dataGridView2.DataSource = tab; */

            // STEP 03 - RESPONSE TO USER

            con.Close();
            this.order_TableAdapter1.Fill(this.ecommerceDataSet12.order_);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("exec delete_order " + textBox5.Text, con);
            query.ExecuteNonQuery();
           

            /* DataTable tab = new DataTable();
             SqlDataAdapter tab1 = new SqlDataAdapter(query);
             tab1.Fill(tab);
             dataGridView2.DataSource = tab; */

            // STEP 03 - RESPONSE TO USER

            con.Close();
            this.order_TableAdapter1.Fill(this.ecommerceDataSet12.order_);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerProfile profile = new CustomerProfile();
            profile.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Invoice profile = new Invoice();
            profile.ShowDialog();

        }


        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
