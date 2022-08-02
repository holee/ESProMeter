using System;
using System.Windows.Forms;
using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.Services;

namespace ESProMeter.Views.UnitOfMeasures
{
	public partial class AddUoMFrm : Form, ITUom
    {
        private DateTime _createdAt = DateTime.UtcNow;
        private DateTime _updatedAt = DateTime.UtcNow;
        public long ID { 
            get => lblUomID.AsNumber<long>(); 
            set => lblUomID.SetText(value); 
        }
        public DateTime CDT { 
            get => _createdAt; 
            set => _createdAt=value; 
        }
        public DateTime MDT { 
            get => _updatedAt; 
            set => _updatedAt=value; 
        }
        public int EDSEQ {
            get => lblEditSequense.AsNumber<int>();
            set => lblEditSequense.SetText(value);
        }
        public string UOMNAME {
            get => txtUoM.Text.Trim();
            set => txtUoM.SetText(value);
        }
        public string ABBREVIATION {
            get => txtDescription.Text.Trim();
            set => txtDescription.SetText(value);
        }
        public byte ISACTIVE { 
            get => chkInactive.Checked==true?(byte)0:(byte)1;
            set => chkInactive.Checked=value==1?false:true;  
        }
        public string TYPE {
            get => cmbType.GetText();
            set => cmbType.SetText(value);
        }

        public AddUoMFrm()
		{
			InitializeComponent();
            if (AppService.UomGetInstance.GetAllUOMTypes(out var table))
            {
                cmbType.DataSource = table;
                cmbType.ValueMember = "ID";
                cmbType.DisplayMember = "TYPENAME";
            }
		}

		public AddUoMFrm(long id)
		{
			InitializeComponent();
            if (AppService.UomGetInstance.GetAllUOMTypes(out var table))
            {
                cmbType.DataSource = table;
                cmbType.ValueMember = "ID";
                cmbType.DisplayMember = "TYPENAME";
            }
            AppService.UomGetInstance.ShowUomFormForUpdate(this, id);
            if (lblUomID.AsNumber<long>() > 0)
            {
                mbtSave.Text = "Update";
            }
        }
		
        private void btnSaveAndCLose_Click(object sender, EventArgs e)
        {
			this.DialogResult = DialogResult.OK;
		}

        private void mbtCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void mbtSave_Click(object sender, EventArgs e)
        {
            if (this.IsValid(txtDescription, txtUoM))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
