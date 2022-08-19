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
        public string NameText
        {
            get { return lblName.Text.Trim(); }
            set { lblName.SetText(value); }
        }
        public string DescriptionText
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
            if (this.IsValid(lblName, txtBoqSection))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
