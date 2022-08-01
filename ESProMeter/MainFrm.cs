using System;
using System.Windows.Forms;
using ESProMeter.Views.UnitOfMeasures;
using ESProMeter.Views.Items;
using ESProMeter.Controllers;
using System.Drawing;

namespace ESProMeter
{
    public partial class MainFrm : Form
    {
        public static MainFrm MainF; //Mainform
        public static Views.FileAndLogin.FileSelectionFrm FSNF; // File Selection Form
        public static Views.FileAndLogin.UserLoginFrm ULNF; //User Login Form

        public MainFrm()
        {
            InitializeComponent();
            MainF = this;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                if (FSNF == null || FSNF.Visible == false) FSNF = new Views.FileAndLogin.FileSelectionFrm();
                FSNF.MdiParent = this;
                FSNF.StartPosition = FormStartPosition.CenterScreen;
                FSNF.Show();
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
        private void DisplayFormInPanel(Form form,Panel container)
        {
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Normal;
            container?.Controls?.Clear();
            container?.Controls.Add(form);
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }

		private void changeMyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form form = new Views.UserManagement.ChangePasswordFrm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                //Change the password
            }
		}

		private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form form = new Views.UserManagement.UserManagementFrm();
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            panel2.Controls.Clear();
            panel2.Controls.Add(form);
            form.Show();
            form.Dock = DockStyle.Fill;
        }

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Application.Exit();
		}

		private void openCompanyFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
            FSNF.mbtOpen_Click(sender ,e);

        }

		private void bToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form form = new Views.Boq.BOQListFrm();
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.WindowState = FormWindowState.Maximized;
            panel2.Controls.Clear();
            panel2.Controls.Add(form);
            form.Show();
            form.Dock = DockStyle.Fill;
        }

		private void billOfQuantityListToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form form = new Views.Boq.CreateBoQ_Step1_Frm();
            form.ShowDialog();
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
            //Add new BOQ Item
            //Set item type as 'Bill of Quanity' then show form
            Form form = new Views.Items.AddItemFrm();
            //form.cmbType.text = 'Bill of Quantity';
            form.ShowDialog();
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
            
		}

		private void boqToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form form = new Views.Boq.CreateBoQ_Step1_Frm();
            form.ShowDialog();
		}

		private void closeCompanyToolStripMenuItem_Click(object sender, EventArgs e)
		{
            //Close the company connection and start company file selection again.
            MainController.closeCompanyFile();
		}

        private void siteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Views.Sites.SiteFrm();
            form.TopLevel = false;
            //form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.WindowState = FormWindowState.Normal;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            form.Show();
            
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Views.Customers.CustomerCenterFrm();
            form.TopLevel = false;
            //form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Normal;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            form.Show();

        }

		private void openBillOfQuantityToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form form = new Views.Reports.SummaryReportFrm();
            form.Text = "Open boq summary";
            form.TopLevel = false;
            //form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.WindowState = FormWindowState.Normal;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            form.Show();
        }

		private void openBOQDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form form = new Views.Reports.DetailReportFrm();
            form.TopLevel = false;
            //form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.WindowState = FormWindowState.Normal;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            form.Show();
        }

        private void myCompanyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Views.Companies.CompanyInfoFrm();
            //form.TopLevel = false;
            ////form.TopMost = true;
            //form.FormBorderStyle = FormBorderStyle.Fixed3D;
            //form.WindowState = FormWindowState.Normal;
            //form.Dock = DockStyle.Fill;
            //panel2.Controls.Add(form);
            form.Show();
        }
    }
}