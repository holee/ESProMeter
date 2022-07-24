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
            if (UomService.GetInstance.GetAllUOMTypes(out var table))
            {
                cmbType.DataSource = table;
                cmbType.ValueMember = "ID";
                cmbType.DisplayMember = "TYPENAME";
            }
		}

		public AddUoMFrm(long id)
		{
			InitializeComponent();
            if (UomService.GetInstance.GetAllUOMTypes(out var table))
            {
                cmbType.DataSource = table;
                cmbType.ValueMember = "ID";
                cmbType.DisplayMember = "TYPENAME";
            }
            UomService.GetInstance.ShowUomFormForUpdate(this, id);
            if (lblUomID.AsNumber<long>() > 0)
            {
                mbtSave.Text = "Update";
            }
        }
		private void mbtSave_Click(object sender, EventArgs e)
		{
            if (!this.IsValid(txtUoM, txtDescription))
            {
                MessageBox.Show("Please enter rquired (*) fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lblUomID.AsNumber<long>() == 0)
            {
                if (!this.CheckUomExist(txtUoM.Text.Trim()))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Unit Of Measure already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                if (!this.CheckUomExistWithSame(txtUoM.Text.Trim(),lblUomID.AsNumber<long>()))
                {
                    if (this.UpdateUom())
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Unit Of Measure already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void AddUoMFrm_Load(object sender, EventArgs e)
		{
			//this.ShowUomForm();
		}

        private void btnSaveAndCLose_Click(object sender, EventArgs e)
        {
			this.DialogResult = DialogResult.OK;
		}

        private void mbtCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
