using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.IViews;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace ESProMeter.Views.Boq
{
	public partial class Form1_Frm : Form,ITBoq
	{
        private List<long> itemsList;
        private DateTime _createdAt = DateTime.Now;
        private DateTime _updatedAt = DateTime.Now;
        bool _toggle = false;
        private byte _isDelete = 0;
        private double _boqNumber = 0;
		public Form1_Frm()
		{
			InitializeComponent();
			
        }
        public long ID { 
            get => 1; 
            set => throw new NotImplementedException(); 
        }
        public DateTime CDT { 
            get => _createdAt; 
            set => _createdAt=DateTime.UtcNow; 
        }
        public DateTime MDT { 
            get => _updatedAt; 
            set => _updatedAt=DateTime.UtcNow; 
        }
        public int EDSEQ { 
            get => lblEditSequense.AsNumber<int>(); 
            set => lblEditSequense.SetText(value); 
        }
        public string REFNUMBER { 
            get => textBoqNumber.Text.Trim(); 
            set =>textBoqNumber.SetText(value); 
        }
        public string BOQTITLE { 
            get => textBoqTitle.Text.Trim(); 
            set => textBoqTitle.SetText(value); 
        }
        public string BOQDESC { 
            get => textDescription.Text.Trim(); 
            set => textDescription.SetText(value); 
        }
        public long CUSTOMERID { 
            get => cmbCustomerID.AsNumber<long>(true);
            set => cmbCustomerID.SelectedValue=value; 
        }
        public DateTime BOQDATE { 
            get => dtpBoqDate.Value; 
            set => dtpBoqDate.Value=value; 
        }
        public DateTime VALIDDATE { 
            get => dtpValidDate.Value;
            set => dtpValidDate.Value = value;
        }
        public bool ISACTIVE {
            get => !chkIsInActive.Checked; 
            set => chkIsInActive.Checked =!value; 
        }
        public long SITEID { 
            get => cmbSite.AsNumber<long>(isValueFromSelectItem:true);
            set => cmbSite.SelectedValue = value; 
        }
        public long DIVID { 
            get => cmbDivision.AsNumber<long>(true); 
            set => cmbDivision.SelectedValue=value; 
        }
        public string TERMSCONDITION { 
            get => textTerm.Text.Trim(); 
            set => textTerm.SetText(value); 
        }
        public int STATUS { 
            get => 1; 
            set => throw new NotImplementedException(); 
        }
        public long UID { 
            get => 1; 
            set => throw new NotImplementedException(); 
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
            Views.Boq.Form2_frm form = new Form2_frm();
            form.TopLevel = false;
            form.TopMost = true;
           
            ((Panel)this.Parent).Controls.Add(form);
            this.Close();
            form.Show();

        }
    }
}
