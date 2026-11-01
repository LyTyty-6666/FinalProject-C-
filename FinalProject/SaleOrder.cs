using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SaleOrder : Form
    {
        public string status = "";

        public SaleOrder()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string fruitName = this.txtFruitName.Text.Trim();
            string quantity = this.txtQuanity.Text.Trim();
            string unitPrice = this.txtUnitPrice.Text.Trim();

            if (string.IsNullOrWhiteSpace(fruitName) &&
                string.IsNullOrWhiteSpace(quantity) &&
                string.IsNullOrWhiteSpace(unitPrice))
            {
                MessageBox.Show("Please enter Fruit Name, Quantity, and Unit Price.", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            int countRow = this.dgvSaleOrderList.RowCount + 1;
            string[] rowAdd = new string[4];
            rowAdd[0] = countRow.ToString();
            rowAdd[1] = fruitName;
            rowAdd[2] = quantity;
            rowAdd[3] = unitPrice;

            this.dgvSaleOrderList.Rows.Add(rowAdd);
            CalculatePrice();
            FillText();
        }

        public void CalculatePrice()
        {
            double totalPrice = 0.0;
            foreach (DataGridViewRow row in this.dgvSaleOrderList.Rows)
            {
                if (!row.IsNewRow)
                {
                    int.TryParse(row.Cells[2].Value?.ToString()?.Trim(), out int qty);
                    double.TryParse(row.Cells[3].Value?.ToString()?.Trim(), out double up);
                    totalPrice += (qty * up);
                }
            }
            this.txtTotalprice.Text = totalPrice.ToString("0.00");
        }

        private void FillText()
        {
            this.txtFruitName.Clear();
            this.txtQuanity.Clear();
            this.txtUnitPrice.Clear();
            this.txtFruitName.Focus();
        }

        public void RefreshID()
        {
            int startID = 1;
            foreach (DataGridViewRow row in this.dgvSaleOrderList.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells[0].Value = startID.ToString();
                    startID++;
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (this.dgvSaleOrderList.SelectedRows.Count > 0)
            {
                string fruitName = this.txtFruitName.Text.Trim();
                string quantity = this.txtQuanity.Text.Trim();
                string unitPrice = this.txtUnitPrice.Text.Trim();

                if (string.IsNullOrWhiteSpace(fruitName) &&
                    string.IsNullOrWhiteSpace(quantity) &&
                    string.IsNullOrWhiteSpace(unitPrice))
                {
                    MessageBox.Show("Please enter Fruit Name, Quantity, and Unit Price.", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                foreach (DataGridViewRow editRow in this.dgvSaleOrderList.SelectedRows)
                {
                    editRow.Cells[1].Value = fruitName;
                    editRow.Cells[2].Value = quantity;
                    editRow.Cells[3].Value = unitPrice;
                }

                CalculatePrice();
                FillText();
            }
            else
            {
                MessageBox.Show("Please select an item in the list to edit.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (this.dgvSaleOrderList.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow removeRow in this.dgvSaleOrderList.SelectedRows)
                {
                    this.dgvSaleOrderList.Rows.Remove(removeRow);
                }
                this.RefreshID();
                this.CalculatePrice();
                this.FillText();
            }
            else
            {
                MessageBox.Show("Please select an item in the list to remove.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvSaleOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSaleOrderList.Rows.Count)
            {
                DataGridViewRow row = dgvSaleOrderList.Rows[e.RowIndex];
                txtFruitName.Text = row.Cells[1].Value?.ToString();
                txtQuanity.Text = row.Cells[2].Value?.ToString();
                txtUnitPrice.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void txtQuanity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { return; }
            if (char.IsDigit(e.KeyChar)) { return; }
            e.Handled = true;
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) { return; }
            if (char.IsDigit(e.KeyChar)) { return; }
            if (e.KeyChar == '.' && !this.txtUnitPrice.Text.Contains('.')) { return; }
            e.Handled = true;
        }

        public void SetViewMode()
        {
            this.status = "View";
            this.txtInNo.ReadOnly = true;
            this.txtCustomerName.ReadOnly = true;
            this.txtphone.ReadOnly = true;
            this.txtTotalprice.ReadOnly = true;
            this.notedatetime.Enabled = false;
            this.cboCurrency.Enabled = false;
            this.txtFruitName.ReadOnly = true;
            this.txtQuanity.ReadOnly = true;
            this.txtUnitPrice.ReadOnly = true;
            this.btnadd.Enabled = false;
            this.btnedit.Enabled = false;
            this.btnremove.Enabled = false;
            this.btnAddToList.Text = "Close";
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (this.status == "View")
            {
                this.Close();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInNo.Text))
            {
                MessageBox.Show("Please enter an Invoice No.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtInNo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter a Customer Name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtCustomerName.Focus();
                return;
            }

            if (dgvSaleOrderList.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one item to the order.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
