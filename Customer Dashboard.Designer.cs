namespace DBMS
{
    partial class Customer_Dashboard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.venIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecommerceDataSet = new DBMS.ecommerceDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecommerceDataSet9 = new DBMS.ecommerceDataSet9();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecommerceDataSet1 = new DBMS.ecommerceDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.productTableAdapter = new DBMS.ecommerceDataSetTableAdapters.ProductTableAdapter();
            this.cartTableAdapter = new DBMS.ecommerceDataSet1TableAdapters.cartTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.order_TableAdapter = new DBMS.ecommerceDataSet9TableAdapters.order_TableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ecommerceDataSet12 = new DBMS.ecommerceDataSet12();
            this.order_TableAdapter1 = new DBMS.ecommerceDataSet12TableAdapters.order_TableAdapter();
            this.button8 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecommerceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecommerceDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecommerceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecommerceDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.venIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // venIDDataGridViewTextBoxColumn
            // 
            this.venIDDataGridViewTextBoxColumn.DataPropertyName = "ven_ID";
            this.venIDDataGridViewTextBoxColumn.HeaderText = "ven_ID";
            this.venIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venIDDataGridViewTextBoxColumn.Name = "venIDDataGridViewTextBoxColumn";
            this.venIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.ecommerceDataSet;
            // 
            // ecommerceDataSet
            // 
            this.ecommerceDataSet.DataSetName = "ecommerceDataSet";
            this.ecommerceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(436, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "search by title";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(177, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "search by ID";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order_";
            this.orderBindingSource.DataSource = this.ecommerceDataSet9;
            // 
            // ecommerceDataSet9
            // 
            this.ecommerceDataSet9.DataSetName = "ecommerceDataSet9";
            this.ecommerceDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "cart";
            this.cartBindingSource.DataSource = this.ecommerceDataSet1;
            // 
            // ecommerceDataSet1
            // 
            this.ecommerceDataSet1.DataSetName = "ecommerceDataSet1";
            this.ecommerceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cart";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(211, 537);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 27);
            this.textBox3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantity";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(211, 471);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 27);
            this.textBox4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Product ID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(134, 601);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 54);
            this.button3.TabIndex = 14;
            this.button3.Text = "Add to Cart";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1169, 679);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 48);
            this.button4.TabIndex = 15;
            this.button4.Text = "Checkout   >>";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(871, 423);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 28);
            this.textBox5.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(788, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "ID   :";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(871, 484);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 28);
            this.textBox6.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(753, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quantity   :";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1030, 484);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 57);
            this.button6.TabIndex = 19;
            this.button6.Text = "Update Quantity";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(1199, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 42);
            this.button7.TabIndex = 22;
            this.button7.Text = "Profile";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1026, 410);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 57);
            this.button5.TabIndex = 24;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(211, 407);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 27);
            this.textBox7.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "USER ID";
            // 
            // order_TableAdapter
            // 
            this.order_TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.cusIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn1,
            this.totalpriceDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(628, 175);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(687, 207);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cusIDDataGridViewTextBoxColumn
            // 
            this.cusIDDataGridViewTextBoxColumn.DataPropertyName = "cus_ID";
            this.cusIDDataGridViewTextBoxColumn.HeaderText = "cus_ID";
            this.cusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusIDDataGridViewTextBoxColumn.Name = "cusIDDataGridViewTextBoxColumn";
            this.cusIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "product_ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataMember = "order_";
            this.orderBindingSource1.DataSource = this.ecommerceDataSet12;
            // 
            // ecommerceDataSet12
            // 
            this.ecommerceDataSet12.DataSetName = "ecommerceDataSet12";
            this.ecommerceDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_TableAdapter1
            // 
            this.order_TableAdapter1.ClearBeforeFill = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(-1, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(214, 61);
            this.button8.TabIndex = 28;
            this.button8.Text = "<<  Back to Home";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Javanese Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(451, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(502, 114);
            this.label8.TabIndex = 29;
            this.label8.Text = "Customer Dashboard";
            // 
            // Customer_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1336, 749);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customer_Dashboard";
            this.Text = "Customer_Dashboard";
            this.Load += new System.EventHandler(this.Customer_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecommerceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecommerceDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecommerceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecommerceDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private ecommerceDataSet ecommerceDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ecommerceDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn venIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private ecommerceDataSet1 ecommerceDataSet1;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private ecommerceDataSet1TableAdapters.cartTableAdapter cartTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label3;
        private ecommerceDataSet9 ecommerceDataSet9;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private ecommerceDataSet9TableAdapters.order_TableAdapter order_TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ecommerceDataSet12 ecommerceDataSet12;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private ecommerceDataSet12TableAdapters.order_TableAdapter order_TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label8;
    }
}