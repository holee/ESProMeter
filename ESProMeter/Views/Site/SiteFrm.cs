using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IVews;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESProMeter.Views.Sites
{
	public partial class SiteFrm : Form
	{
		public SiteFrm()
		{
			InitializeComponent();
			siteDataGrid.AutoGenerateColumns = false;
			tlsRows.SelectedIndex = 0;
			ShowAllSites();
		}

		private void tsbNewSite_Click(object sender, EventArgs e)
		{
			AddSiteFrm form = new AddSiteFrm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				this.SiteCreateNewOrUpdate(form,form);
				ShowAllSites();
			}
		}
		private void ShowAllSites()
        {
            if (chkInlcudeInActive.Checked)
            {
				if(int.TryParse(tlsRows.Text,out var row))
                {
					this.GetAllSites(0,row);
                }
            }
            else
            {
				if (int.TryParse(tlsRows.Text, out var row))
				{
					this.GetAllSites(1, row);
				}
			}
			siteDataGrid.ClearSelection();
		}
		


        private void SiteFrm_Load(object sender, EventArgs e)
        {
			siteDataGrid.ClearSelection();

		}

        private void tlsDelete_Click(object sender, EventArgs e)
        {
			if (this.siteDataGrid.Rows.Count <= 0) return;
            if (siteDataGrid.SelectedRows.Count > 0) {
				var selectedRow = siteDataGrid.SelectedRows[0];
				var id = selectedRow.GetValue<long>("ID");
				if (MessageBox.Show("Do you want to delete this data?", "Confirm?", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
                    if (this.DeleteSite(id))
                    {
						siteDataGrid.Rows.Remove(selectedRow);
					}
				}
			}
			
        }

        private void tslSiteEditClick(object sender, EventArgs e)
        {
			if (this.siteDataGrid.Rows.Count == 0) return;
			if (siteDataGrid.SelectedRows.Count > 0)
			{
				var selectedRow = siteDataGrid.SelectedRows[0];
				var id=selectedRow.GetValue<long>("ID");	
				AddSiteFrm form = new AddSiteFrm(id);
				if (form.ShowDialog() == DialogResult.OK)
				{
					if (!this.IsSiteExistsame(form.SITENAME, id))
					{
						this.SiteCreateNewOrUpdate(form, form, Enums.ActionType.EDIT);
						ShowAllSites();
                    }
                    else
                    {
						MessageBox.Show("Site Name Already exist.");
                    }
				}
			}
		}

        private void tlsRefreshClick(object sender, EventArgs e)
        {
			ShowAllSites();
		}
		private void SiteGridSelectionChanged(object sender, EventArgs e)  
		{
			if (siteDataGrid.SelectedRows.Count > 0) { 
				var selectedRow = siteDataGrid.SelectedRows[0];
				if (selectedRow.Selected)
				{
					if (selectedRow.GetValue<int>("IsActive")== 0)
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
        private void chkInlcudeInActive_CheckedChanged(object sender, EventArgs e)
        {
			ShowAllSites();
		}

        private void tlsRows_SelectedIndexChanged(object sender, EventArgs e)
        {
			ShowAllSites();

		}

        private void stbMakInactive_Click(object sender, EventArgs e)
        {
            if (siteDataGrid.SelectedRows.Count > 0)
            {
				var selectedRow = siteDataGrid.SelectedRows[0];
				if (selectedRow.Selected)
				{
					var id = selectedRow.GetValue<long>("ID");
					var active = selectedRow.GetValue<byte>("IsActive")==0?1:0;
                    if (this.MakeSiteActiveOrInactive(id, (byte)active))
                    {
						selectedRow.Cells["IsActive"].Value = active;

						if (active ==0 && chkInlcudeInActive.Checked==false)
						{
							siteDataGrid.Rows.RemoveAt(selectedRow.Index);
						}
                    }
				}
			}
        }

		private void excelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//open and excel file and pass the grid data to excel then open excel application

			var data = ((DataTable)siteDataGrid.DataSource);
			var path = @"D:/test.xlsx";
            if (!System.IO.File.Exists(path))
            {
				System.IO.File.Create(path);
            }
			data.Print(path,10);

		}
	}
}
