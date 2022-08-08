using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IViews;
using System;
using System.Windows.Forms;

namespace ESProMeter.Views.Boq
{
	public partial class CreateBoQ_Step2_Frm : Form,ITBOQ
	{
		#region private
		private DateTime _createdAt = DateTime.UtcNow;
		private DateTime _updatedAt = DateTime.UtcNow;
		private byte _isActive = 1;
		private long _divId = 0;
		private string _refnumber = string.Empty;
		private int _edit = 0;
		private int _status = 1;
		private long _uid = 0;
		#endregion
		#region properties
		public long ID
		{
			get => lblID.AsNumber<long>();
			set => lblID.SetText(value);
		}
		public DateTime CDT
		{
			get => _createdAt;
			set => _createdAt = value;
		}
		public DateTime MDT
		{
			get => _updatedAt;
			set => _updatedAt = value;
		}
		public int EDSEQ
		{
			get => _edit;
			set => _edit = value;
		}
		public string REFNUMBER
		{
			get => _refnumber;
			set => _refnumber = value;
		}
		public string BOQTITLE
		{
			get => txtBOQTitle.Text.Trim();
			set => txtBOQTitle.SetText(value);
		}
		public string BOQDESC
		{
			get => txtBOQDesc.Text.Trim();
			set => txtBOQDesc.SetText(value);
		}
		public long CUSTOMERID
		{
			get => cboCustomerName.AsNumber<long>();
			set => cboCustomerName.SelectedValue = value;
		}
		public DateTime BOQDATE
		{
			get => dtpDate.Value;
			set => dtpDate.Value = value;
		}
		public DateTime VALIDDATE
		{
			get => dtpValidDate.Value;
			set => dtpValidDate.Value = value;
		}
		public byte ISACTIVE
		{
			get => _isActive;
			set => _isActive = value;
		}
		public long SITEID
		{
			get => cboSite.AsNumber<long>();
			set => cboSite.SelectedValue = value;
		}
		public long DIVID
		{
			get => _divId;
			set => _divId = value;
		}
		public string TERMSCONDITION
		{
			get => txtTermsCondition.Text.Trim();
			set => txtTermsCondition.SetText(value);
		}
		public int STATUS
		{
			get => _status;
			set => _status = value;
		}
		public long UID
		{
			get => _uid;
			set => _uid = value;
		}
		#endregion



		public CreateBoQ_Step2_Frm()
		{
			InitializeComponent();
		
		}
		public CreateBoQ_Step2_Frm(long id)
		{
			InitializeComponent();
			this.FillCustomerCmb(cboCustomerName);
			this.FillSitesCmb(cboSite);
			this.BoqGetById(id,this);

		}
		private void txtBOQDesc_Enter(object sender, EventArgs e)
		{
			txtBOQDesc.BringToFront();
			txtBOQDesc.Height = 97;
		}

		private void txtBOQDesc_Leave(object sender, EventArgs e)
		{
			txtBOQDesc.Height = 23;
		}

		private void txtTermsCondition_Leave(object sender, EventArgs e)
		{
			txtTermsCondition.Height = 23;
			txtTermsCondition.Top = this.Height - 49;
		}

		private void txtTermsCondition_Enter(object sender, EventArgs e)
		{
			txtTermsCondition.BringToFront();
			txtTermsCondition.Height = 127;
			txtTermsCondition.Top = this.Height - 153;
		}

		private void CreateBoQ_Step2_Frm_Activated(object sender, EventArgs e)
		{
			//this.txtTermsCondition.Top = this.Height - 50;
		}

		private void mbtCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void cboCustomerName_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
