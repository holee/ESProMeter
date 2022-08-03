using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IVews;
using System;
using System.Windows.Forms;

namespace ESProMeter.Views.Sites
{
	public partial class AddSiteFrm : Form,ITSite,ITAddressInfo
	{
        //fields
        private DateTime _createdAt = DateTime.Now;
        private DateTime _updatedAt=DateTime.Now;
        //properties
        public long ID
        { 
            get => longSiteID.AsNumber<long>(); 
            set => longSiteID.SetText(value); 
        }
        long ITAddressInfo.ID
        {
            get => longAddrRefId.AsNumber<long>();
            set => longAddrRefId.SetText(value);
        }
        public string DESCRIPTION
        { 
            get => textDescription.Text; 
            set => textDescription.SetText(value); 
        }
        public long ADDRESSID
        { 
            get => longAddrRefId.AsNumber<long>(); 
            set => longAddrRefId.SetText(value); 
        }
        public long CUSTOMERID
        { 
            get => textCustomerID.AsNumber<long>(true); 
            set => textCustomerID.SelectedValue=value; 
        }
        public byte ISACTIVE
        { 
            get => checkInactive.Checked?(byte)0:(byte)1; 
            set => checkInactive.Checked=value==0?true:false; 
        }
       

        public string ADDRESS
        { 
            get => textAddress.Text.Trim(); 
            set => textAddress.SetText(value); 
        }
        public int EDSEQ
        { 
            get => intEditSequense.AsNumber<int>(); 
            set => intEditSequense.SetText(value); 
        }
        public string PROVINCE
        { 
            get => textCity.Text.Trim(); 
            set => textCity.SetText(value);
        }
        public string COUNTRY
        { 
            get => textCountry.Text.Trim(); 
            set => textCountry.SetText(value); 
        }
        public DateTime CDT { 
            get => _createdAt;
            set => _createdAt = value;
        }
        public DateTime MDT { 
            get => _updatedAt; 
            set => _updatedAt=value; 
        }
        public string SITENAME { 
            get => textName.Text.Trim(); 
            set => textName.SetText(value); 
        }

        //constructor
        public AddSiteFrm()
		{
			InitializeComponent();
            btnSave.Text = "Save";
            this.checkInactive.Enabled = false;
            // this.ShowCustomerForUpdate();
            this.FillCustomerCmb();
        }
        public AddSiteFrm(long siteId)
        {
            InitializeComponent();
            btnSave.Text = "Update";
            this.Text = "Update site information";
            //this.ShowFormSiteUpdate(this,siteId);
            this.FillCustomerCmb();
            this.ShowFormSiteUpdate(this, this, siteId);
        }

        //events
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.IsValid(textName))
            {
                //if (btnSave.Text == "Save")
                //{
                //    if (this.IsSiteExist(textName.Text.Trim()))
                //    {
                //        MessageBox.Show("Site Name Already Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        return;
                //    }
                //}
                //if (btnSave.Text == "Update")
                //{
                //    if (this.IsSiteExistsame(textName.Text.Trim(),longSiteID.AsNumber<long>()))
                //    {
                //        MessageBox.Show("Site Name Already Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        return;
                //    }
                //}
                //this.SiteCreateNewOrUdate();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbtAddCustomer_Click(object sender, EventArgs e)
		{
            Form form = new Views.Customers.CustomerCreateFrm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.FillCustomerCmb();
            }
		}

		private void textName_Leave(object sender, EventArgs e)
		{
            var text = ((TextBox)sender).Text.Trim();
            if (text.Length == 0) return;
            if (ID == 0)
            {
                if (this.IsSiteExist(text))
                {
                    MessageBox.Show("Site Name already exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((TextBox)sender).Select(0, ((TextBox)sender).Text.Length);
                    return;
                }
            }
            else
            {
                if (this.IsSiteExistsame(text, ID))
                {
                    MessageBox.Show("Site Name already exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((TextBox)sender).Select(0, ((TextBox)sender).Text.Length);
                    return;
                }
            }
        }

		private void textCustomerID_Leave(object sender, EventArgs e)
		{
           
		}
	}
}
