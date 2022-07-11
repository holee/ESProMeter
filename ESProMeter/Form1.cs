using ESProMeter.Properties;
using Microsoft.Reporting.WinForms;
using static ESProMeter.Services.ServerRegistration;
using System;
using System.Windows.Forms;
using ESProMeter.Views.UnitOfMeasures;
using ESProMeter.Views.Items;
using System.Drawing;

namespace ESProMeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //reportViewer1.LocalReport.ReportEmbeddedResource = "ESProMeter.Reports.Report1.rdlc";
            //reportViewer1.ProcessingMode = ProcessingMode.Local;
            //ReportDataSource reportData = new ReportDataSource("Book","");
            //reportViewer1.LocalReport.DataSources.Add(reportData);
            //reportViewer1.LocalReport.Refresh();
            //reportViewer1.RefreshReport();
            //reportViewer1.Dock = DockStyle.Fill;
            //this.Controls.Add(reportViewer1);

            try
            {
                if (Settings.Default.isLDB)
                {

                    if (!ChekedServerRegistrationInfo())
                    {
                        this.WindowState = FormWindowState.Maximized;
                        this.Hide();
                        Form form1 = new Views.Servers.FormRegister();
                        if (form1.ShowDialog(this) == DialogResult.OK)
                        {
                            this.StartPosition = FormStartPosition.CenterScreen;
                            this.Show();
                        }
                    }
                }
                else
                {
                    if (!ChekedServerRegistrationInfo(false))
                    {
                        this.WindowState = FormWindowState.Maximized;
                        this.Hide();
                        Form form1 = new Views.Servers.FormRegister();
                        if (form1.ShowDialog(this) == DialogResult.OK)
                        {
                            this.StartPosition = FormStartPosition.CenterScreen;
                            this.Show();
                        }
                    }
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(this.splitContainer1.SplitterDistance == 60)
            {
                this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
                this.splitContainer1.SplitterDistance = 180;
            }
            else
            {
                this.splitContainer1.SplitterDistance = 60;
                this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            }
        }

        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemListFrm frmItem = new ItemListFrm();
            frmItem.TopLevel = false;
            frmItem.TopMost = true;
            frmItem.FormBorderStyle = FormBorderStyle.None;
            frmItem.WindowState= FormWindowState.Maximized;
            panel2.Controls.Clear();
            panel2.Controls.Add(frmItem);
            frmItem.Show();
            frmItem.Dock = DockStyle.Fill;
        }

        private void uomItemList_Click(object sender, EventArgs e)
        {
            UoMFrm frm = new UoMFrm();
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState=FormWindowState.Maximized;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            var p = panel2.Controls.Find("ItemListFrm", true);
            if (p.Length>0)
            {
                ((Form)p[0]).Size = new Size(panel2.Height, panel2.Width);
            }
            //frmItem.TopLevel = false;
            //frmItem.TopMost = true;
            //frmItem.Width = panel2.Width;
            //frmItem.Height = panel2.Height;
            //frmItem.FormBorderStyle = FormBorderStyle.None;
            //frmItem.WindowState = FormWindowState.Maximized;
            //panel2.Controls.Clear();
            //panel2.Controls.Add(frmItem);
            //frmItem.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Views.Setting.Form1 frm = new Views.Setting.Form1();
            frm.TopLevel = false;
            frm.TopMost = true;
            //frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = PointToScreen(new Point(e.X, e.Y));
            panel2.Controls.Add(frm);
            frm.Show();
            var p=panel2.Controls.Find(frm.Name, true)[0];
            MessageBox.Show(p.Name);
        }

        private void createBoqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Boq.BoQFrm form = new Views.Boq.BoQFrm();
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle= FormBorderStyle.None;
            panel2.Controls.Add(form);
            form.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.Clear();
                return;
            }
        }
    }
}