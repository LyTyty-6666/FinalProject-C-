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
    public partial class SaleOrderList : Form
    {
        public SaleOrderList()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SaleOrder openForm = new SaleOrder();
            openForm.status = "New";

            DialogResult result = openForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string[] row = new string[6];
                row[0] = openForm.txtInNo.Text.Trim();
                row[1] = openForm.notedatetime.Text.Trim();
                row[2] = openForm.txtTotalprice.Text.Trim();
                row[3] = openForm.txtCustomerName.Text.Trim();
                row[4] = openForm.txtphone.Text.Trim();        
                row[5] = openForm.cboCurrency.Text.Trim();     

                List<string[]> items = new List<string[]>();
                foreach (DataGridViewRow itemRow in openForm.dgvSaleOrderList.Rows)
                {
                    if (!itemRow.IsNewRow)
                    {
                        items.Add(new string[]
                        {
                            itemRow.Cells[0].Value?.ToString() ?? "",
                            itemRow.Cells[1].Value?.ToString() ?? "",
                            itemRow.Cells[2].Value?.ToString() ?? "",
                            itemRow.Cells[3].Value?.ToString() ?? ""
                        });
                    }
                }

                int newRowIndex = this.dgvOrderList.Rows.Add(row);
                this.dgvOrderList.Rows[newRowIndex].Tag = items;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvOrderList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = this.dgvOrderList.SelectedRows[0];

                SaleOrder openForm = new SaleOrder();
                openForm.status = "Edit";

                // Pre-fill header fields
                openForm.txtInNo.Text = selectedRow.Cells[0].Value?.ToString();
                if (DateTime.TryParse(selectedRow.Cells[1].Value?.ToString(), out DateTime invDate))
                {
                    openForm.notedatetime.Value = invDate;
                }
                openForm.txtTotalprice.Text = selectedRow.Cells[2].Value?.ToString();
                openForm.txtCustomerName.Text = selectedRow.Cells[3].Value?.ToString();
                openForm.txtphone.Text = selectedRow.Cells[4].Value?.ToString();        
                openForm.cboCurrency.Text = selectedRow.Cells[5].Value?.ToString();    

                if (selectedRow.Tag is List<string[]> items)
                {
                    foreach (string[] item in items)
                    {
                        openForm.dgvSaleOrderList.Rows.Add(item[0], item[1], item[2], item[3]);
                    }
                }

                DialogResult result = openForm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    // Update header in the grid
                    selectedRow.Cells[0].Value = openForm.txtInNo.Text.Trim();
                    selectedRow.Cells[1].Value = openForm.notedatetime.Text.Trim();
                    selectedRow.Cells[2].Value = openForm.txtTotalprice.Text.Trim();
                    selectedRow.Cells[3].Value = openForm.txtCustomerName.Text.Trim();
                    selectedRow.Cells[4].Value = openForm.txtphone.Text.Trim();         
                    selectedRow.Cells[5].Value = openForm.cboCurrency.Text.Trim();      

                    // Update saved line items
                    List<string[]> updatedItems = new List<string[]>();
                    foreach (DataGridViewRow itemRow in openForm.dgvSaleOrderList.Rows)
                    {
                        if (!itemRow.IsNewRow)
                        {
                            updatedItems.Add(new string[]
                            {
                                itemRow.Cells[0].Value?.ToString() ?? "",
                                itemRow.Cells[1].Value?.ToString() ?? "",
                                itemRow.Cells[2].Value?.ToString() ?? "",
                                itemRow.Cells[3].Value?.ToString() ?? ""
                            });
                        }
                    }
                    selectedRow.Tag = updatedItems;
                }
            }
            else
            {
                MessageBox.Show("Please select an order from the list to edit.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.dgvOrderList.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to remove the selected order?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    this.dgvOrderList.Rows.Remove(this.dgvOrderList.SelectedRows[0]);
                }
            }
            else
            {
                MessageBox.Show("Please select an order from the list to remove.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (this.dgvOrderList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = this.dgvOrderList.SelectedRows[0];

                SaleOrder openForm = new SaleOrder();

                // Pre-fill header fields
                openForm.txtInNo.Text = selectedRow.Cells[0].Value?.ToString();
                if (DateTime.TryParse(selectedRow.Cells[1].Value?.ToString(), out DateTime invDate))
                {
                    openForm.notedatetime.Value = invDate;
                }
                openForm.txtTotalprice.Text = selectedRow.Cells[2].Value?.ToString();
                openForm.txtCustomerName.Text = selectedRow.Cells[3].Value?.ToString();
                openForm.txtphone.Text = selectedRow.Cells[4].Value?.ToString();        
                openForm.cboCurrency.Text = selectedRow.Cells[5].Value?.ToString();     

                // Restore line items
                if (selectedRow.Tag is List<string[]> items)
                {
                    foreach (string[] item in items)
                    {
                        openForm.dgvSaleOrderList.Rows.Add(item[0], item[1], item[2], item[3]);
                    }
                }

                // Put form in View (Read-Only) mode
                openForm.SetViewMode();
                openForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Please select an order from the list to view.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
