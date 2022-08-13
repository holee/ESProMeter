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
    public partial class BOQLINEFrm : Form
    {
        public BOQLINEFrm()
        {
            InitializeComponent();
        }

        private void mbtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
