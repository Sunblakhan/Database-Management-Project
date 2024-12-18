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
    public partial class VendorProfile : Form
    {
        public VendorProfile()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void VendorProfile_Load(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            SqlCommand ID = new SqlCommand("select Id from vendor", Conn);
            SqlCommand Name = new SqlCommand("select Name from vendor", Conn);
            SqlCommand Email = new SqlCommand("select email from vendor", Conn);
            SqlCommand Phone = new SqlCommand("select phone from vendor", Conn);
            SqlCommand Address = new SqlCommand("select address from vendor", Conn);
            Conn.Open();
            SqlDataReader DR1 = ID.ExecuteReader();
            if (DR1.Read())
            {
                textBox1.Text = DR1.GetValue(0).ToString();
            }
            DR1.Close();
            SqlDataReader DR2 = Name.ExecuteReader();
            if (DR2.Read())
            {
                textBox2.Text = DR2.GetValue(0).ToString();
            }
            DR2.Close();
            SqlDataReader DR3 = Email.ExecuteReader();
            if (DR3.Read())
            {
                textBox3.Text = DR3.GetValue(0).ToString();
            }
            DR3.Close();
            SqlDataReader DR4 = Phone.ExecuteReader();
            if (DR4.Read())
            {
                textBox4.Text = DR4.GetValue(0).ToString();
            }
            DR4.Close();
            SqlDataReader DR5 = Address.ExecuteReader();
            if (DR5.Read())
            {
                textBox5.Text = DR5.GetValue(0).ToString();
            }
            DR2.Close();

            Conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // STEP 01 - CONNECT
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ecommerce;Integrated Security=True");
            con.Open();

            // STEP 02 - QUERY RUN
            SqlCommand query = new SqlCommand("update vendor set Name = '" + textBox2.Text + "', Email = '" + textBox3.Text+ "', Phone = '" + textBox4.Text+ "', Address = '" + textBox5.Text+"' where ID = "+textBox1.Text, con);
            query.ExecuteNonQuery();
            MessageBox.Show("Information Udpated ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            con.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            vendordashboard back = new vendordashboard();
            back.ShowDialog();
        }
    }
}
