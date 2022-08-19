using ESProMeter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESProMeter.Views.ReportFrm
{
    public partial class RptBOQLineFrm : Form
    {
        public RptBOQLineFrm()
        {
            InitializeComponent();
        }
        public RptBOQLineFrm(long boq_id)
        {
            InitializeComponent();
            AppService.GetReportInstance.BoqListReport(boq_id, out var source);
            ReportSevice.GenerateReport(reportViewer1, panel2, "ESProMeter.Reports.RptBOQLine.rdlc", source);
        }
    }
}
