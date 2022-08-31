using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ESProMeter.Services
{
    internal class ReportSevice
    {
        public static void GenerateReport(ReportViewer report, Panel container, string path, DataSet dataSources)
        {
            ReportDataSource dataSource = new ReportDataSource("ESPRO", dataSources.Tables[0]);
            report.ProcessingMode = ProcessingMode.Local;
            report.LocalReport.ReportEmbeddedResource = path;
            report.LocalReport.DataSources.Clear();
            report.LocalReport.DataSources.Add(dataSource);
            report.LocalReport.Refresh();
            report.RefreshReport();
            report.Dock = DockStyle.Fill;
            container.Controls.Add(report);
        }
        public static void GenerateReport(ReportViewer report, Panel container, string path, DataTable dataSources)
        {
            ReportDataSource dataSource = new ReportDataSource("ESPRO", dataSources);
            report.ProcessingMode = ProcessingMode.Local;
            report.LocalReport.ReportEmbeddedResource = path;
            report.LocalReport.DataSources.Clear();
            report.LocalReport.DataSources.Add(dataSource);
            report.LocalReport.Refresh();
            report.RefreshReport();
            report.Dock = DockStyle.Fill;
            container.Controls.Add(report);
        }
        public static void GenerateReport(ReportViewer report, Panel container, string path, DataTable dataSources, Dictionary<string, string> paras)
        {
            ReportDataSource dataSource = new ReportDataSource("ESPRO", dataSources);
            report.ProcessingMode = ProcessingMode.Local;
            report.LocalReport.ReportEmbeddedResource = path;
            report.LocalReport.DataSources.Clear();
            report.LocalReport.DataSources.Add(dataSource);
            List<ReportParameter> parameters = new List<ReportParameter>();
            foreach (KeyValuePair<string, string> keyvalue in paras)
            {
                parameters.Add(new ReportParameter(keyvalue.Key, keyvalue.Value));
            }
            report.LocalReport.SetParameters(parameters);
            report.LocalReport.Refresh();
            report.RefreshReport();
            report.Dock = DockStyle.Fill;
            container.Controls.Add(report);
        }
    }
}
