namespace DBMS
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecommerceDataSet8 = new DBMS.ecommerceDataSet8();
            this.invoiceTableAdapter = new DBMS.ecommerceDataSet8TableAdapters.invoiceTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ecommerceDataSet11 = new DBMS.ecommerceDataSet11();
            this.viewinvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_invoiceTableAdapter = new DBMS.ecommerceDataSet11TableAdapters.view_invoiceTableAdapter();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecommerceDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecommerceDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.ecommerceDataSet8;
            // 
            // ecommerceDataSet8
            // 
            this.ecommerceDataSet8.DataSetName = "ecommerceDataSet8";
            this.ecommerceDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewinvoiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(699, 234);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ecommerceDataSet11
            // 
            this.ecommerceDataSet11.DataSetName = "ecommerceDataSet11";
            this.ecommerceDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewinvoiceBindingSource
            // 
            this.viewinvoiceBindingSource.DataMember = "view_invoice";
            this.viewinvoiceBindingSource.DataSource = this.ecommerceDataSet11;
            // 
            // view_invoiceTableAdapter
            // 
            this.view_invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "Total Price";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total Price";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "Purchase Date";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "Purchase Date";
            this.purchaseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 55);
            this.button2.TabIndex = 25;
            this.button2.Text = "<<  Back to Dashboard";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Javanese Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(190, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 114);
            this.label8.TabIndex = 30;
            this.label8.Text = "Checkout   ";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 445);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecommerceDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecommerceDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ecommerceDataSet8 ecommerceDataSet8;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private ecommerceDataSet8TableAdapters.invoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ecommerceDataSet11 ecommerceDataSet11;
        private System.Windows.Forms.BindingSource viewinvoiceBindingSource;
        private ecommerceDataSet11TableAdapters.view_invoiceTableAdapter view_invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
    }
}