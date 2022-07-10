using ESProMeter.Extensions;
using ESProMeter.IViews;
using System;
using System.Windows.Forms;
using static ESProMeter.Controllers.CustomerController;
namespace ESProMeter.Views.Customers
{
    public partial class CustomerCreateFrm : Form,ICustomer
    {

        //properties
        public string Address
        {
            get => textAddress.Text.Trim();
            set => textAddress.SetText(value);
        }
        public int AddressEditSequense
        {
            get => AddrEditSequense.AsNumber<int>();
            set => AddrEditSequense.SetText(value);
        }
        public string City
        {
            get => textProvince.Text.Trim();
            set => textProvince.SetText(value);
        }
        public string Province
        {
            get => textProvince.Text.Trim();
            set => textProvince.SetText(value);
        }
        public string Country
        {
            get => textCountry.Text.Trim();
            set => textCountry.SetText(value);
        }
        public long CustID { 
            get => lblCustID.AsNumber<long>(); 
            set => lblCustID.SetText(value); 
        }
        public string FirstName { 
            get => textFirstName.Text.Trim(); 
            set => textFirstName.SetText(value); 
        }
        public string MiddleName { 
            get => textMiddleName.Text.Trim(); 
            set => textMiddleName.SetText(value); 
        }
        public string LastName { 
            get => textLastName.Text.Trim();
            set => textLastName.SetText(value); 
        }
        public string TypeRefId { 
            get => "Customer"; 
            set => throw new NotImplementedException(); 
        }
        public int AddressRefId { 
            get => lblAddrID.AsNumber<int>(); 
            set => lblAddrID.SetText(value); 
        }
        public string Salutation { 
            get => textSalutation.Text.Trim(); 
            set => textSalutation.SetText(value); 
        }
        public string JobTitle { 
            get => textJobTitle.Text.Trim(); 
            set => textJobTitle.SetText(value); 
        }
        public string Email { 
            get => textEmail.Text.Trim(); 
            set => textEmail.SetText(value); 
        }
        public string MainPhone { 
            get => textMainPhone.Text.Trim(); 
            set => textMainPhone.SetText(value); 
        }
        public string AltPhone { 
            get => textAltPhone.Text.Trim(); 
            set => textAltPhone.SetText(value); 
        }
        public string Fax { 
            get => textFax.Text.Trim(); 
            set => textFax.SetText(value); 
        }
        public string WebSite { 
            get => textWebsite.Text.Trim(); 
            set => textWebsite.SetText(value);
        }
        public int EditSequense { 
            get => lblEditSequense.AsNumber<int>(); 
            set => lblEditSequense.SetText(value); 
        }
        public decimal CreditLimit { 
            get => textCreditLimit.AsNumber<decimal>(); 
            set => textCreditLimit.SetText(value); }
        public bool IsActive { 
            get => !checkInActive.Checked; 
            set => checkInActive.Checked=value; 
        }
        public long AddrID { 
            get => lblAddrID.AsNumber<long>(); 
            set => lblAddrID.SetValue(value); 
        }
        public string CustomerName { 
            get => textName.Text.Trim(); 
            set => textName.SetText(value); 
        }
     
        //methods
        public CustomerCreateFrm()
        {
            InitializeComponent();
            if (CustID == 0)
            {
                materialButton1.Text = "Save";
            }
        }
        public CustomerCreateFrm(long id)
        {
            InitializeComponent();
            this.ShowCustomer(this, id);
            if (CustID == 0)
            {
                materialButton1.Text = "Save";
            }
            else
            {
                materialButton1.Text = "Update";
            }
            
        }
        private void btnNewCustomerClick(object sender, EventArgs e)
        {
            if (this.IsValid(textName,textCountry,textProvince,textAddress,textMainPhone))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		private void CustomerCreateFrm_Load(object sender, EventArgs e)
		{
            toolTip1.SetToolTip(this.textSalutation, "Salutation");
            toolTip1.SetToolTip(this.textFirstName, "First Name");
            toolTip1.SetToolTip(this.textMiddleName, "Middle Name");
            toolTip1.SetToolTip(this.textLastName, "Last Name");
		}
	}
}
