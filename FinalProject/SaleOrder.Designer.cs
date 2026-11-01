namespace FinalProject
{
    partial class SaleOrder
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            cboCurrency = new ComboBox();
            notedatetime = new DateTimePicker();
            txtTotalprice = new TextBox();
            txtphone = new TextBox();
            txtCustomerName = new TextBox();
            txtInNo = new TextBox();
            groupBox2 = new GroupBox();
            dgvSaleOrderList = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnAddToList = new Button();
            btnremove = new Button();
            btnedit = new Button();
            btnadd = new Button();
            label8 = new Label();
            label10 = new Label();
            label12 = new Label();
            txtUnitPrice = new TextBox();
            txtQuanity = new TextBox();
            txtFruitName = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSaleOrderList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboCurrency);
            groupBox1.Controls.Add(notedatetime);
            groupBox1.Controls.Add(txtTotalprice);
            groupBox1.Controls.Add(txtphone);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(txtInNo);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(546, 122);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 96);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 3;
            label6.Text = "Currency";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 96);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 3;
            label3.Text = "Total Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 57);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 3;
            label5.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 57);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "In Voice Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 22);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 3;
            label4.Text = "Customer Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "InVoice NO";
            // 
            // cboCurrency
            // 
            cboCurrency.AutoCompleteCustomSource.AddRange(new string[] { "Khmer ៛", "Dollar $", "Yuan ￥" });
            cboCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCurrency.FormattingEnabled = true;
            cboCurrency.Items.AddRange(new object[] { "USA Dollar", "Khmer RIEL", "Chinese YUAN" });
            cboCurrency.Location = new Point(397, 91);
            cboCurrency.Margin = new Padding(2, 2, 2, 2);
            cboCurrency.Name = "cboCurrency";
            cboCurrency.Size = new Size(125, 23);
            cboCurrency.TabIndex = 2;
            // 
            // notedatetime
            // 
            notedatetime.Format = DateTimePickerFormat.Short;
            notedatetime.Location = new Point(107, 54);
            notedatetime.Margin = new Padding(2, 2, 2, 2);
            notedatetime.Name = "notedatetime";
            notedatetime.Size = new Size(124, 23);
            notedatetime.TabIndex = 1;
            // 
            // txtTotalprice
            // 
            txtTotalprice.BackColor = SystemColors.ActiveCaption;
            txtTotalprice.Location = new Point(106, 92);
            txtTotalprice.Margin = new Padding(2, 2, 2, 2);
            txtTotalprice.Name = "txtTotalprice";
            txtTotalprice.ReadOnly = true;
            txtTotalprice.Size = new Size(125, 23);
            txtTotalprice.TabIndex = 0;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(397, 56);
            txtphone.Margin = new Padding(2, 2, 2, 2);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(125, 23);
            txtphone.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(397, 18);
            txtCustomerName.Margin = new Padding(2, 2, 2, 2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(125, 23);
            txtCustomerName.TabIndex = 0;
            // 
            // txtInNo
            // 
            txtInNo.Location = new Point(106, 18);
            txtInNo.Margin = new Padding(2, 2, 2, 2);
            txtInNo.Name = "txtInNo";
            txtInNo.Size = new Size(125, 23);
            txtInNo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dgvSaleOrderList);
            groupBox2.Controls.Add(btnAddToList);
            groupBox2.Controls.Add(btnremove);
            groupBox2.Controls.Add(btnedit);
            groupBox2.Controls.Add(btnadd);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtUnitPrice);
            groupBox2.Controls.Add(txtQuanity);
            groupBox2.Controls.Add(txtFruitName);
            groupBox2.Location = new Point(6, 140);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(546, 236);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // dgvSaleOrderList
            // 
            dgvSaleOrderList.AllowUserToAddRows = false;
            dgvSaleOrderList.AllowUserToDeleteRows = false;
            dgvSaleOrderList.AllowUserToResizeColumns = false;
            dgvSaleOrderList.AllowUserToResizeRows = false;
            dgvSaleOrderList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSaleOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaleOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleOrderList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvSaleOrderList.Location = new Point(9, 115);
            dgvSaleOrderList.Margin = new Padding(2, 2, 2, 2);
            dgvSaleOrderList.MultiSelect = false;
            dgvSaleOrderList.Name = "dgvSaleOrderList";
            dgvSaleOrderList.ReadOnly = true;
            dgvSaleOrderList.RowHeadersVisible = false;
            dgvSaleOrderList.RowHeadersWidth = 62;
            dgvSaleOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaleOrderList.ShowCellErrors = false;
            dgvSaleOrderList.ShowCellToolTips = false;
            dgvSaleOrderList.ShowEditingIcon = false;
            dgvSaleOrderList.ShowRowErrors = false;
            dgvSaleOrderList.Size = new Size(532, 116);
            dgvSaleOrderList.TabIndex = 5;
            dgvSaleOrderList.CellClick += dgvSaleOrderList_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "NAME";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "QUANITY";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "UNIT PRICE";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // btnAddToList
            // 
            btnAddToList.Location = new Point(383, 67);
            btnAddToList.Margin = new Padding(2, 2, 2, 2);
            btnAddToList.Name = "btnAddToList";
            btnAddToList.Size = new Size(88, 28);
            btnAddToList.TabIndex = 4;
            btnAddToList.Text = "Add To List";
            btnAddToList.UseVisualStyleBackColor = true;
            btnAddToList.Click += btnAddToList_Click;
            // 
            // btnremove
            // 
            btnremove.Location = new Point(383, 29);
            btnremove.Margin = new Padding(2, 2, 2, 2);
            btnremove.Name = "btnremove";
            btnremove.Size = new Size(88, 28);
            btnremove.TabIndex = 4;
            btnremove.Text = "REMOVE";
            btnremove.UseVisualStyleBackColor = true;
            btnremove.Click += btnremove_Click;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(265, 67);
            btnedit.Margin = new Padding(2, 2, 2, 2);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(88, 28);
            btnedit.TabIndex = 4;
            btnedit.Text = "EDIT";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(265, 29);
            btnadd.Margin = new Padding(2, 2, 2, 2);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(88, 28);
            btnadd.TabIndex = 4;
            btnadd.Text = "ADD";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 87);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 3;
            label8.Text = "Unit Price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 57);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 3;
            label10.Text = "Quanity";
            label10.UseMnemonic = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(4, 22);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 3;
            label12.Text = "FruitName";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(107, 85);
            txtUnitPrice.Margin = new Padding(2, 2, 2, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(125, 23);
            txtUnitPrice.TabIndex = 0;
            txtUnitPrice.KeyPress += txtUnitPrice_KeyPress;
            // 
            // txtQuanity
            // 
            txtQuanity.Location = new Point(106, 53);
            txtQuanity.Margin = new Padding(2, 2, 2, 2);
            txtQuanity.Name = "txtQuanity";
            txtQuanity.Size = new Size(125, 23);
            txtQuanity.TabIndex = 0;
            txtQuanity.KeyPress += txtQuanity_KeyPress;
            // 
            // txtFruitName
            // 
            txtFruitName.Location = new Point(106, 18);
            txtFruitName.Margin = new Padding(2, 2, 2, 2);
            txtFruitName.Name = "txtFruitName";
            txtFruitName.Size = new Size(125, 23);
            txtFruitName.TabIndex = 0;
            // 
            // SaleOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 384);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "SaleOrder";
            Text = "SaleOrderList";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSaleOrderList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label1;
        private GroupBox groupBox2;
        private Label label8;
        private Label label10;
        private Label label12;
        private TextBox txtUnitPrice;
        private TextBox txtQuanity;
        private TextBox txtFruitName;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        public Button btnAddToList;
        public Button btnremove;
        public Button btnedit;
        public Button btnadd;
        public ComboBox cboCurrency;
        public DateTimePicker notedatetime;
        public TextBox txtTotalprice;
        public TextBox txtphone;
        public TextBox txtCustomerName;
        public TextBox txtInNo;
        public DataGridView dgvSaleOrderList;
    }
}