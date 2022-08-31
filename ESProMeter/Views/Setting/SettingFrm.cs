using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESProMeter.Extensions;

namespace ESProMeter.Views.Setting
{
    public partial class SettingFrm : Form
    {
        public SettingFrm()
        {
            InitializeComponent();

            //Test only
            updateQuoteFormat();
        }

		private void txtPrefix_KeyUp(object sender, KeyEventArgs e)
		{
            updateQuoteFormat();
        }

        private void updateQuoteFormat()
        {
            int rn = 1;
            txtSampleFormat.SetText(txtPrefix.Text.Trim() + DateTime.Now.ToString(txtDateFormat.Text.Trim()) + "-" + rn.ToString(txtRunningNumberFormat.Text.Trim()));
        }

		private void txtDateFormat_KeyUp(object sender, KeyEventArgs e)
		{
            updateQuoteFormat();
        }

		private void txtRunningNumberFormat_KeyUp(object sender, KeyEventArgs e)
		{
            updateQuoteFormat();
        }

		private void mbtClose_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void mbtSave_Click(object sender, EventArgs e)
		{
            if (tabControl1.SelectedTab.Name == "tabBOQQuote")
            {
               
            }
		}
	}
}
