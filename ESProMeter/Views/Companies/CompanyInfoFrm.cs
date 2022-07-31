using System;
using System.Drawing;
using System.Windows.Forms;
using ESProMeter.Extensions;
namespace ESProMeter.Views.Companies
{
    public partial class CompanyInfoFrm : Form
    {
        public CompanyInfoFrm()
        {
            InitializeComponent();
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
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
            if (this.IsValid(Address, Country, Province,CompanyName))
            {
                
                //this.UpdateCompany();
                this.Reset(Address,Country,Province,CompanyName);   
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
