using System;
using System.Drawing;
using System.Windows.Forms;
using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IVews;

namespace ESProMeter.Views.Companies
{
    public partial class CompanyInfoFrm : Form, ITCOMPANYINFO, ITAddressInfo
    {

        #region private
        private DateTime _createdAt = DateTime.UtcNow;
        private DateTime _updatedAt = DateTime.UtcNow;


        #endregion

        #region properties
        public int ID { 
            get => lblCompanyID.AsNumber<int>(); 
            set => lblCompanyID.SetText(value); 
        }
        public int EDSEQ { 
            get => lblcomEditSequese.AsNumber<int>(); 
            set => lblcomEditSequese.SetText(value); 
        }
        public string COMPANYNAME { 
            get => txtCompanyName.Text.Trim(); 
            set => txtCompanyName.SetText(value); 
        }
        public string LEGALCOMPANYNAME { 
            get => txtLegalCompanyName.Text.Trim(); 
            set => txtLegalCompanyName.SetText(value); 
        }
        public string ALTLEGALCOMPANYNAME { 
            get => txtAltLegalCompanyName.Text.Trim(); 
            set => txtAltLegalCompanyName.SetText(value); 
        }
        public long CONTADDRESSID { 
            get => lblContactAddressId.AsNumber<long>(); 
            set => lblContactAddressId.SetText(value); 
        }
        public long LEGALADDRESSID { 
            get => lblLegalAddressId.AsNumber<long>(); 
            set => lblLegalAddressId.SetText(value); 
        }
        public string MAINPHONE { 
            get => txtMainPhone.Text.Trim(); 
            set => txtMainPhone.SetText(value); 
        }
        public string ALTPHONE { 
            get => txtAltPhone.Text.Trim(); 
            set => txtAltPhone.SetText(value); 
        }
        public string FAX { 
            get => txtFax.Text.Trim(); 
            set => txtFax.SetText(value); 
        }
        public string EMAIL { 
            get => txtEmail.Text.Trim(); 
            set => txtEmail.SetText(value); 
        }
        public string WEBSITE { 
            get => txtWebSite.Text.Trim(); 
            set => txtWebSite.SetText(value); 
        }
        public string LOGOFILEPATH { 
            get => txtLoginPath.Text.Trim(); 
            set => txtLoginPath.SetText(value); 
        }
        public DateTime CDT { 
            get => _createdAt; 
            set => _createdAt=value; 
        }
        public DateTime MDT { 
            get => _updatedAt; 
            set => _updatedAt=value; 
        }
        long ITAddressInfo.ID { 
            get => lblContactAddressId.AsNumber<int>(); 
            set => lblContactAddressId.SetText(value); }
        //company address
        public string ADDRESS { 
            get => txtAddress.Text.Trim(); 
            set => txtAddress.SetText(value); 
        }
        public string PROVINCE
        {
            get => txtProvince.Text.Trim();
            set => txtProvince.SetText(value);
        }
        public string COUNTRY { 
            get => txtCountry.Text.Trim(); 
            set => txtCountry.SetText(value); 
        }
        //Legal Company address
        public string LEGALADDRESS { 
            get => txtLegalAddress.Text.Trim(); 
            set => txtLegalAddress.SetText(value); 
        }
        public string LEGALPROVINCE { 
            get => txtLegalProvince.Text.Trim();
            set => txtLegalProvince.SetText(value); 
        }
        public string LEGALCOUNTRY { 
            get => txtLegalCountry.Text.Trim(); 
            set => txtLegalCountry.SetText(value); 
        }


        #endregion
        public CompanyInfoFrm()
        {
            InitializeComponent();
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            this.ShowCompanyInformation(this);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                tabControl1.SelectedIndex = 1;
                tabPage2.Select();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                tabControl1.SelectedIndex = 0;
                tabPage2.Select();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (this.IsValid(txtAddress, txtCountry, txtProvince,txtCompanyName))
            {
                this.UpdateCompany(this);
                this.Reset(txtAddress,txtCountry,txtProvince,txtCompanyName);   
            }
        }

        private void CompanInfoFrm_Load(object sender, EventArgs e)
        {
            this.rbtContactInformation.Checked=true;
            //this.ShowCompanyInformation();
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
