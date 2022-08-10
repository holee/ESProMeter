using ESProMeter.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESProMeter.Views.Boq
{
    public partial class SectionFrm : Form
    {
        public string SectionText
        {
            get { return txtBoqSection.Text.Trim(); }
            set { txtBoqSection.SetText(value); }
        }

        public SectionFrm()
        {
            InitializeComponent();
        }

        private void mbtNext_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
        }
    }
}
