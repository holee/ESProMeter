using ESProMeter.Controllers;
using ESProMeter.Extensions;
using System;
using System.Linq;
using System.Windows.Forms;
namespace ESProMeter.Views.Customers
{
    public partial class CustomerCenterFrm : Form
    {
        public CustomerCenterFrm()
        {
            InitializeComponent();
            gridCustomer.ClearSelection();
        }

        private void tlsNew_Click(object sender, EventArgs e)
        {
            CustomerCreateFrm frm = new CustomerCreateFrm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                if (this.CustomerCreateOrUpdate(frm, Enums.ActionType.CREATE))
                {
                    MessageBox.Show("success");
                    this.ShowCustomerCenter();
                }
                else
                {
                    MessageBox.Show("failed");
                }
                //this.CreateOrUpdateCustomer(frm);
            }
            //this.ShowCustomerCenter();

        }
        private bool HasChildFormOpen(Form form)
        {
            if (MdiChildren.Any(frm => frm.Name == form.Name))
            {
                return true;
            }
            return false;
        }

        private void CanOpenForm(Form form)
        {
            if (!HasChildFormOpen(form))
            {
               form.Show();
            }
            else
            {
                return;
            }

        }

        private void CustomerCenterFrm_Load(object sender, EventArgs e)
        {

            this.ShowCustomerCenter();
        }

        private void tlsCustomerEdit_Click(object sender, EventArgs e)
        {
            if (gridCustomer.SelectedRows.Count>0)
            {
                var selectedRow = gridCustomer.SelectedRows[0];
                var custID = selectedRow.GetValue<long>("ID");
                CustomerCreateFrm frm = new CustomerCreateFrm(custID);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (this.CustomerCreateOrUpdate(frm, Enums.ActionType.EDIT))
                    {
                        MessageBox.Show("success");
                        this.ShowCustomerCenter();
                    }
                    else
                    {
                        MessageBox.Show("failed");
                    }
                }
            }
        }

        private void tlsRefreshClick(object sender, EventArgs e)
        {
            this.ShowCustomerCenter();
        }

        private void tlsDeleteClick(object sender, EventArgs e)
        {
            if (gridCustomer.Rows.Count > 0)
            {
                var selectedRow = gridCustomer.SelectedRows[0];
                var custID = selectedRow.GetValue<long>("ID");
                var addressID = selectedRow.GetValue<long>("ADDRESSID");
                if (MessageBox.Show("Do you want to delete customer?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    if (this.DeleteCustomer(custID, addressID)){
                        gridCustomer.Rows.Remove(selectedRow);
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete customer.");
                    }

                }
            }
            
        }

        private void textSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //this.ShowCustomerCenter(textSearch.Text.Trim());
        }

        private void gridCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (gridCustomer.SelectedRows.Count > 0)
            {
                var row = gridCustomer.SelectedRows[0];
                var id = row.GetValue<long>("ID");
                CustomerDetailFrm form = new CustomerDetailFrm();
                form.TopLevel = false;
                form.TopMost = true;
                form.FormBorderStyle = FormBorderStyle.None;
                this.GetCustomerDetails(form, id);
                this.pnlDetails.Controls?.Clear();
                this.pnlDetails.Controls.Add(form);
                form.Show();

            }
        }
    }
}
