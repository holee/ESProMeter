using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.IViews;
using System;
using System.Windows.Forms;

namespace ESProMeter.Views.Sites
{
	public partial class AddSiteFrm : Form,ITSite
	{
        //fields
        //properties
        private DateTime _createdAt = DateTime.Now;
        private DateTime _updatedAt=DateTime.Now;   
        public long ID { 
            get => longSiteID.AsNumber<int>(); 
            set => longSiteID.SetText(value); 
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
       

        public string Address { 
            get => textAddress.Text.Trim(); 
            set => textAddress.SetText(value); 
        }
        public int EDSEQ
        { 
            get => intEditSequense.AsNumber<int>(); 
            set => intEditSequense.SetText(value); 
        }
        public string City { 
            get => textCity.Text.Trim(); 
            set => textCity.SetText(value); 
        }
        public string Province { 
            get => textCity.Text.Trim(); 
            set => textCity.SetText(value);
        }
        public string Country { 
            get => textCountry.Text.Trim(); 
            set => textCountry.SetText(value); 
        }
        public string SiteName { 
            get => textName.Text.Trim(); 
            set => textName.SetText(value); 
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
            this.ShowCustomerForUpdate();
        }
        public AddSiteFrm(long siteId)
        {
            InitializeComponent();
            //this.ShowFormSiteUpdate(this,siteId);
        }

        //events
        private void AddSiteFrm_Load(object sender, EventArgs e)
        {
			if(longAddrRefId.AsNumber<long>()== 0 && longSiteID.AsNumber<long>() == 0)
            {
                btnSave.Text = "Save";
            }
            else
            {
                btnSave.Text = "Update";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.IsValid(textName, textDescription))
            {
                if (btnSave.Text == "Save")
                {
                    if (this.IsSiteExist(textName.Text.Trim()))
                    {
                        MessageBox.Show("Site Name Already Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (btnSave.Text == "Update")
                {
                    if (this.IsSiteExistsame(textName.Text.Trim(),longSiteID.AsNumber<long>()))
                    {
                        MessageBox.Show("Site Name Already Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                //this.SiteCreateNewOrUdate();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textName_KeyUp(object sender, KeyEventArgs e)
        {
            var text=((TextBox)sender).Text.Trim();
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
                if (this.IsSiteExistsame(text,ID))
                {
                    MessageBox.Show("Site Name already exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((TextBox)sender).Select(0, ((TextBox)sender).Text.Length);
                    return;
                }
            }
        }
    }
}
