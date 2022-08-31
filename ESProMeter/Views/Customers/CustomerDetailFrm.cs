using ESProMeter.Extensions;
using ESProMeter.IVews;
using System;
using System.Windows.Forms;

namespace ESProMeter.Views.Customers
{
    public partial class CustomerDetailFrm : Form,ITName,ITAddressInfo
    {
        public CustomerDetailFrm()
        {
            InitializeComponent();
        }
        #region private fields
        private DateTime _createdAt = DateTime.UtcNow;
        private DateTime _updatedAt = DateTime.UtcNow;
        private string _customer = "Customer";
        private string _province = string.Empty;
        private string _country = string.Empty;
        private long _id =0;
        private string _firstName=string.Empty;
        private string _lastName = string.Empty;
        private long _addressId = 0;
        private string _address = string.Empty;
        private string _salutation = string.Empty;
        private string _middleName = string.Empty;
        private string _fax;
        private int _ed;
        private decimal _textCreditLimit;
        private long _lblAddrID;
        private byte _isActive;
        #endregion
        #region properties
        public string ADDRESS
        {
            get => _address;
            set => _address =value;
        }
        public string PROVINCE
        {
            get => _province;
            set => _province=value;
        }
        public string COUNTRY
        {
            get => _country;
            set => _country=value;
        }
        public long ID
        {
            get => _id;
            set => _id=value;
        }
        long ITAddressInfo.ID
        {
            get => _addressId;
            set => _addressId=value;
        }
        public string FIRSTNAME
        {
            get => _firstName;
            set => _firstName=value;
        }
        public string MiddleName
        {
            get => _middleName;
            set => _middleName=value;
        }
        public string LASTNAME
        {
            get => _lastName;
            set => _lastName=value;
        }
        public string NAMETYPE
        {
            get => _customer;
            set => _customer = value;
        }
        public long ADDRESSID
        {
            get => _addressId;
            set => _addressId=value;
        }
        public string SALUTATION
        {
            get => _salutation;
            set => _salutation=value;
        }
        public string JOBTITLE
        {
            get => txtJobTitle.Text.Trim();
            set => txtJobTitle.SetText(value);
        }
        public string EMAIL
        {
            get => txtEmail.Text.Trim();
            set => txtEmail.SetText(value);
        }
        public string MAINPHONE
        {
            get => txtMainPhone.Text.Trim();
            set => txtMainPhone.SetText(value);
        }
        public string ALTPHONE
        {
            get => txtAltPhone.Text.Trim();
            set => txtAltPhone.SetText(value);
        }
        public string FAX
        {
            get => _fax;
            set => _fax=value;
        }
        public string WEBSITE
        {
            get => txtWebSite.Text.Trim();
            set => txtWebSite.SetText(value);
        }
        public int EDSEQ
        {
            get => _ed;
            set => _ed=value;
        }
        public decimal CREDITLIMIT
        {
            get => _textCreditLimit;
            set => _textCreditLimit=value;
        }
        public byte ISACTIVE
        {
            get => _isActive;
            set => _isActive=value;
        }
        public long AddrID
        {
            get => _lblAddrID;
            set => _lblAddrID=value;
        }
        public string CustomerName
        {
            get => txtName.Text.Trim();
            set => txtName.SetText(value);
        }
        public DateTime CDT { get => _createdAt; set => _createdAt = DateTime.UtcNow; }
        public DateTime MDT { get => _updatedAt; set => _updatedAt = DateTime.UtcNow; }
        public string NAME { get => txtName.Text.Trim(); set => txtName.SetText(value); }

		#endregion

		private void CustomerDetailFrm_Load(object sender, EventArgs e)
		{
            txtContactFullName.SetText(_salutation + " " + _firstName + " " + _lastName);

            txtFullAddress.SetText(_address + System.Environment.NewLine + _country + System.Environment.NewLine + _province);
		}

	}
}
