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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ecommerceDataSet11.view_invoice' table. You can move, or remove it, as needed.
            this.view_invoiceTableAdapter.Fill(this.ecommerceDataSet11.view_invoice);
            // TODO: This line of code loads data into the 'ecommerceDataSet8.invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.ecommerceDataSet8.invoice);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Dashboard profile = new Customer_Dashboard();
            profile.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
