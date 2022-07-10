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
            this.gridCustomer.AutoGenerateColumns = false;
        }

        private void tlsNew_Click(object sender, EventArgs e)
        {
            CustomerCreateFrm frm = new CustomerCreateFrm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                this.CreateOrUpdateCustomer(frm);
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
            //    form.MdiParent =Main.ActiveForm;
            //    form.StartPosition = FormStartPosition.CenterParent;
            //    form.Show();
            }
            else
            {
                return;
            }

        }

        private void CustomerCenterFrm_Load(object sender, EventArgs e)
        {
            
            this.ShowCustomerCenter(null);
        }

        private void tlsCustomerEdit_Click(object sender, EventArgs e)
        {
            if (gridCustomer.Rows.Count > 0)
            {
                var custID = gridCustomer.AsNumber<long>("custID");
                CustomerCreateFrm frm = new CustomerCreateFrm(custID);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.CreateOrUpdateCustomer(frm);
                    
                }
                //this.ShowCustomerCenter();
            }
        }

        private void tlsRefreshClick(object sender, EventArgs e)
        {
            //this.ShowCustomerCenter();
        }

        private void tlsDeleteClick(object sender, EventArgs e)
        {
            if (gridCustomer.Rows.Count > 0)
            {
                var custID = gridCustomer.AsNumber<long>("custID");
                var index = gridCustomer.CurrentCell.RowIndex;
                if (MessageBox.Show("Do you want to delete customer?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    if (this.DeleteCustomer(custID)){
                        gridCustomer.Rows.RemoveAt(index); 
                    }

                }
            }
            
        }

        private void textSearch_KeyUp(object sender, KeyEventArgs e)
        {
            this.ShowCustomerCenter(textSearch.Text.Trim());
        }
    }
}
