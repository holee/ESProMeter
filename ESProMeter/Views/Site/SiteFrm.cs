using ESProMeter.Controllers;
using ESProMeter.Extensions;
using System;
using System.Windows.Forms;

namespace ESProMeter.Views.Sites
{
	public partial class SiteFrm : Form
	{
		public SiteFrm()
		{
			InitializeComponent();
		}

		private void tsbNewSite_Click(object sender, EventArgs e)
		{
			AddSiteFrm form = new AddSiteFrm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				this.SiteCreateNewOrUpdate(form);
				this.ShowSiteOnDataGridView(chkInlcudeInActive.Checked);
			}
		}

        private void SiteFrm_Load(object sender, EventArgs e)
        {
            if (chkInlcudeInActive.Checked)
            {
				this.ShowSiteOnDataGridView(true);
			}
            else
            {
				this.ShowSiteOnDataGridView(false);
			}
			
			siteDataGrid.ClearSelection();

		}

        private void tlsDelete_Click(object sender, EventArgs e)
        {
			if (this.siteDataGrid.Rows.Count <= 0) return;
			if(MessageBox.Show("Do you want to delete this data?", "Confirm?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
				var id=this.siteDataGrid.AsNumber<long>("Column1");
				this.DeleteSite(id);
            }
        }

        private void tslSiteEditClick(object sender, EventArgs e)
        {
			if (this.siteDataGrid.Rows.Count == 0) return;
			var id = this.siteDataGrid.AsNumber<long>("Column1");
			AddSiteFrm addSiteFrm = new AddSiteFrm(id);
			if(addSiteFrm.ShowDialog() == DialogResult.OK)
            {
				this.SiteCreateNewOrUpdate(addSiteFrm);
				this.ShowSiteOnDataGridView(chkInlcudeInActive.Checked);
			}
		}

        private void tlsRefreshClick(object sender, EventArgs e)
        {
			this.ShowSiteOnDataGridView(chkInlcudeInActive.Checked);
		}

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
			if (siteDataGrid.Rows.Count > 0)
			{
				var index = siteDataGrid.CurrentCell.RowIndex;
				var id = this.AsLong("siteDataGrid", index, "Column1");
				var IsActive = this.siteDataGrid.AsNumber<int>("Column7");
				this.MakeSiteActiveOrInactive(id);
				stbMakInactive.Text = IsActive == 0 ? "Make Active" : "Make in Active";

			}
		}
		private void SiteGridSelectionChanged(object sender, EventArgs e)  
		{
			foreach (DataGridViewRow row in ((DataGridView)sender).Rows)
			{
				if (row.Selected)
				{
					if (row.Cells["Column7"].Value.ToString() == "0")
					{
						stbMakInactive.Text = "Make Active";
					}
					else
					{
						stbMakInactive.Text = "Make In Active";

					}
				}
			}
		}

        private void siteDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkInlcudeInActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInlcudeInActive.Checked)
            {
				this.ShowSiteOnDataGridView(true);
				return;
            }
			this.ShowSiteOnDataGridView(false);
        }
    }
}
