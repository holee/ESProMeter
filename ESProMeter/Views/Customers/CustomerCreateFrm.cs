using ESProMeter.Extensions;
using ESProMeter.IVews;
using System;
using System.Windows.Forms;
using static ESProMeter.Controllers.NameController;
namespace ESProMeter.Views.Customers
{
    public partial class CustomerCreateFrm : Form,ITName,ITAddressInfo
    {
        private DateTime _createdAt = DateTime.UtcNow;
        private DateTime _updatedAt = DateTime.UtcNow;
        private string _customer = "Customer";
        //properties
        public string ADDRESS 
        {
            get => textAddress.Text.Trim();
            set => textAddress.SetText(value);
        }
        public string PROVINCE
        {
            get => textProvince.Text.Trim();
            set => textProvince.SetText(value);
        }
        public string COUNTRY
        {
            get => textCountry.Text.Trim();
            set => textCountry.SetText(value);
        }
        public long ID { 
            get => lblCustID.AsNumber<long>(); 
            set => lblCustID.SetText(value); 
        }
        long ITAddressInfo.ID
        {
            get => lblCustID.AsNumber<long>();
            set => lblCustID.SetText(value);
        }
        public string FIRSTNAME
        { 
            get => textFirstName.Text.Trim(); 
            set => textFirstName.SetText(value); 
        }
        public string MiddleName { 
            get => textMiddleName.Text.Trim(); 
            set => textMiddleName.SetText(value); 
        }
        public string LASTNAME
        { 
            get => textLastName.Text.Trim();
            set => textLastName.SetText(value); 
        }
        public string NAMETYPE
        { 
            get => _customer; 
            set => _customer=value; 
        }
        public long ADDRESSID
        { 
            get => lblAddrID.AsNumber<int>(); 
            set => lblAddrID.SetText(value); 
        }
        public string SALUTATION
        { 
            get => textSalutation.Text.Trim(); 
            set => textSalutation.SetText(value); 
        }
        public string JOBTITLE
        { 
            get => textJobTitle.Text.Trim(); 
            set => textJobTitle.SetText(value); 
        }
        public string EMAIL
        { 
            get => textEmail.Text.Trim(); 
            set => textEmail.SetText(value); 
        }
        public string MAINPHONE
        { 
            get => textMainPhone.Text.Trim(); 
            set => textMainPhone.SetText(value); 
        }
        public string ALTPHONE
        { 
            get => textAltPhone.Text.Trim(); 
            set => textAltPhone.SetText(value); 
        }
        public string FAX
        { 
            get => textFax.Text.Trim(); 
            set => textFax.SetText(value); 
        }
        public string WEBSITE
        { 
            get => textWebsite.Text.Trim(); 
            set => textWebsite.SetText(value);
        }
        public int EDSEQ
        { 
            get => lblEditSequense.AsNumber<int>(); 
            set => lblEditSequense.SetText(value); 
        }
        public decimal CREDITLIMIT
        { 
            get => textCreditLimit.AsNumber<decimal>(); 
            set => textCreditLimit.SetText(value); }
        public byte ISACTIVE
        { 
            get => checkInActive.Checked?(byte)0:(byte)1; 
            set => checkInActive.Checked=value==0?true:false; 
        }
        public long AddrID { 
            get => lblAddrID.AsNumber<long>(); 
            set => lblAddrID.SetValue(value); 
        }
        public string CustomerName { 
            get => textName.Text.Trim(); 
            set => textName.SetText(value); 
        }
        public DateTime CDT { get => _createdAt; set => _createdAt=DateTime.UtcNow; }
        public DateTime MDT { get => _updatedAt; set => _updatedAt=DateTime.UtcNow; }
        public string NAME { get => textName.Text.Trim(); set => textName.SetText(value); }
     

        //methods
        public CustomerCreateFrm()
        {
            InitializeComponent();
            materialButton1.Text = "Save";
        }
        public CustomerCreateFrm(long id)
        {
            InitializeComponent();
             this.ShowCustomerById(this, id);
             materialButton1.Text = "Update";
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
