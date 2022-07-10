using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IViews;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace ESProMeter.Views.Boq
{
	public partial class BoQFrm : Form,IBoq
	{
        private List<long> itemsList;
        private DateTime _createdAt = DateTime.Now;
        private DateTime _updatedAt = DateTime.Now;
        bool _toggle = false;
        private byte _isDelete = 0;
        private double _boqNumber = 0;
		public BoQFrm()
		{
			InitializeComponent();
			
        }

        public long BOQID { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public DateTime CreatedTime { 
            get => _createdAt; 
            set => _createdAt=value; 
        }
        public DateTime ModifiedTime { 
            get => _updatedAt; 
            set => _updatedAt=value; 
        }
        public int EditSequense { 
            get => lblEditSequense.AsNumber<int>(); 
            set => lblEditSequense.SetText(value); 
        }
        public double BOQNumber { 
            get => _boqNumber; 
            set => _boqNumber=value; 
        }
        public long CustRefID { 
            get => cmbCustomerID.AsNumber<long>(true); 
            set => cmbCustomerID.SelectedValue=value; 
        }
        public DateTime Date { 
            get => dtpBoqDate.Value; 
            set => dtpBoqDate.Value=value; 
        }
        public string RefNumber { 
            get => textBoqNumber.Text.Trim(); 
            set => textBoqNumber.SetText(value); 
        }
        public bool IsActive { 
            get => !chkIsInActive.Checked;
            set => chkIsInActive.Checked = value; 
        }
        public long SiteRefListID { 
            get => cmbSite.AsNumber<long>(true); 
            set => cmbSite.SelectedValue=value; 
        }
        public long DivRefListID { 
            get => cmbDivision.AsNumber<long>(true); 
            set => cmbDivision.SelectedValue=value; 
        }
        public DateTime ValidDate {
            get => dtpValidDate.Value; 
            set => dtpValidDate.Value=value; 
        }
        public string TermsCondition { 
            get => textTerm.Text.Trim(); 
            set => textTerm.SetText(value); 
        }
        public byte IsDelete { 
            get => _isDelete; 
            set => _isDelete=value; 
        }
        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
  
        
        

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Views.Boq.BoqItemFrm form = new BoqItemFrm();
            form.TopLevel = false;
            form.TopMost = true;
           
            ((Panel)this.Parent).Controls.Add(form);
            this.Close();
            form.Show();

        }
    }
}
