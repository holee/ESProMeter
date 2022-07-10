using System;
using System.Windows.Forms;
using ESProMeter.Controllers;
using ESProMeter.Extensions;

namespace ESProMeter.Views.UnitOfMeasures
{
	public partial class AddUoMFrm : Form
	{
		public AddUoMFrm()
		{
			InitializeComponent();
            if (lblUomID.AsNumber<long>() == 0)
            {
				mbtSave.Text = "Save";
            }
            else
            {
				mbtSave.Text = "Update";
            }
			this.ShowUomForm();
		}

		public AddUoMFrm(long id)
		{
			InitializeComponent();
			if (lblUomID.AsNumber<long>() == 0)
			{
				mbtSave.Text = "Save";
			}
			else
			{
				mbtSave.Text = "Update";
			}
			this.ShowUomForm();
			this.ShowUomForm(id);

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
                    this.AddNewUom();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Unit Of Measure already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
			this.AddNewUom();
			this.DialogResult = DialogResult.OK;
		}

        private void mbtCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
