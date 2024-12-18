using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration register = new Registration();
            register.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationVendor register = new registrationVendor();
            register.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin register = new AdminLogin();
            register.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
