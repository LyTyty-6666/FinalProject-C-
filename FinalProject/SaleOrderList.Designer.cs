namespace FinalProject
{
    partial class SaleOrderList
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
            groupBox1 = new GroupBox();
            dgvOrderList = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            btnView = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            btnNew = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dgvOrderList);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(9, 8);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(543, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dgvOrderList
            // 
            dgvOrderList.AllowUserToAddRows = false;
            dgvOrderList.AllowUserToDeleteRows = false;
            dgvOrderList.AllowUserToResizeColumns = false;
            dgvOrderList.AllowUserToResizeRows = false;
            dgvOrderList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvOrderList.Location = new Point(2, 16);
            dgvOrderList.Margin = new Padding(2);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.RowHeadersVisible = false;
            dgvOrderList.RowHeadersWidth = 62;
            dgvOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderList.ShowCellErrors = false;
            dgvOrderList.ShowCellToolTips = false;
            dgvOrderList.ShowEditingIcon = false;
            dgvOrderList.ShowRowErrors = false;
            dgvOrderList.Size = new Size(539, 267);
            dgvOrderList.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "InVoice No";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "InVoice Date";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Total Price";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Customer";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Phone Number";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Currency";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 21);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(5, 4);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnView);
            groupBox2.Controls.Add(btnRemove);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnNew);
            groupBox2.Location = new Point(10, 297);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(539, 43);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnView
            // 
            btnView.Location = new Point(423, 18);
            btnView.Margin = new Padding(2);
            btnView.Name = "btnView";
            btnView.Size = new Size(100, 20);
            btnView.TabIndex = 0;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(287, 18);
            btnRemove.Margin = new Padding(2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(100, 20);
            btnRemove.TabIndex = 0;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(160, 18);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 20);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(31, 18);
            btnNew.Margin = new Padding(2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(100, 20);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // SaleOrderList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 344);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "SaleOrderList";
            Text = "SaleOrder";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button btnView;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnNew;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        public DataGridView dgvOrderList;
    }
}