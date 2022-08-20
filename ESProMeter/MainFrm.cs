using System;
using System.Windows.Forms;
using ESProMeter.Views.UnitOfMeasures;
using ESProMeter.Views.Items;
using ESProMeter.Controllers;
using System.Drawing;
using ESProMeter.Enums;
using System.Linq;
using FontAwesome.Sharp;
using ESProMeter.Properties;
using ESProMeter.Views.Boq;

namespace ESProMeter
{
    public partial class MainFrm : Form
    {
        public static MainFrm MainF; //Mainform
        public static Views.FileAndLogin.FileSelectionFrm FSNF; // File Selection Form
        public static Views.FileAndLogin.UserLoginFrm ULNF; //User Login Form
        private bool HasChildFormOpen(Form form)
        {
            if (MdiChildren.Any(frm => frm.Name == form.Name))
            {
                return true;
            }
            return false;
        }

        private void CanOpenForm(Form form)
        {
            if (!HasChildFormOpen(form))
            {
                form.MdiParent = this;
                form.StartPosition = FormStartPosition.CenterParent;
                form.Show();
            }
            else
            {
                return;
            }

        }
        public MainFrm()
        {
            InitializeComponent();
            Properties.Settings.Default.curLoggedUID = 0;
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
            catch 
            {
                
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemListFrm frmItem = new ItemListFrm();
            frmItem.WindowState= FormWindowState.Maximized;
            CanOpenForm(frmItem);
        }

        private void uomItemList_Click(object sender, EventArgs e)
        {
            UoMFrm frm = new UoMFrm();
            frm.WindowState=FormWindowState.Maximized;
            CanOpenForm(frm);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

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
            frm.Show();
            
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            
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
            Views.UserManagement.ChangePasswordFrm form = new Views.UserManagement.ChangePasswordFrm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                //Change the password
                this.ChangePassword(form);
            }
		}

		private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form form = new Views.UserManagement.UserManagementFrm();
            form.WindowState = FormWindowState.Maximized;
            CanOpenForm(form);
        }

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (Properties.Settings.Default.curLoggedUID == 0) { Application.Exit(); return; }
            this.userLogStateUpdate(Properties.Settings.Default.curLoggedUID, 1);
            Application.Exit();
		}

		private void openCompanyFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
            FSNF.mbtOpen_Click(sender ,e);

        }

		private void bToolStripMenuItem_Click(object sender, EventArgs e)
		{
            BOQListFrm form = new BOQListFrm();
            form.WindowState = FormWindowState.Maximized;
            CanOpenForm(form);
        }

		private void billOfQuantityListToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form form = new Views.Boq.CreateBoQ_Step1_Frm();
            CanOpenForm(form);
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
            //Add new BOQ Item
            //Set item type as 'Bill of Quanity' then show form
            Views.Items.AddItemFrm form = new Views.Items.AddItemFrm(0,Enums.ItemsType.Boq,Enums.ActionType.CREATE);
            //form.cmbType.text = 'Bill of Quantity';
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.ItemCreate(form, ItemsType.Boq);
            }
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
            Views.Sites.AddSiteFrm form = new Views.Sites.AddSiteFrm();
            form.ShowDialog();
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
            form.WindowState = FormWindowState.Maximized;
            CanOpenForm(form);
            
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Views.Customers.CustomerCenterFrm();
            form.WindowState = FormWindowState.Maximized;
            CanOpenForm(form);
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
            form.Show();
        }

        private void myCompanyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Views.Companies.CompanyInfoFrm();
            CanOpenForm(form);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 40)
            {
                btnMenu.IconChar = IconChar.AngleLeft;
                btnMenu.IconColor = Color.White;
                btnMenu.FlatStyle = FlatStyle.Flat;
                btnMenu.FlatAppearance.BorderSize = 0;
                panelMenu.Width = 150;
                Settings.Default.menuSide = 150;
                Settings.Default.Save();
                foreach (Button menuItem in panelMenu.Controls.OfType<Button>())
                {
                    menuItem.Text = menuItem.Tag.ToString();
                    menuItem.ImageAlign = ContentAlignment.MiddleLeft;
                    menuItem.Padding = new Padding(0, 0, 0, 0);
                }
            }
            else
            {
                panelMenu.Width = 40;
                Settings.Default.menuSide = 40;
                Settings.Default.Save();
                btnMenu.IconChar = IconChar.AngleRight;
                btnMenu.IconColor = Color.White;
                btnMenu.FlatStyle = FlatStyle.Flat;
                foreach (Button menuItem in panelMenu.Controls.OfType<Button>())
                {
                    menuItem.Text = String.Empty;
                    menuItem.ImageAlign = ContentAlignment.MiddleCenter;
                    menuItem.Padding = new Padding(0);
                }
            }
        }
        private void siteListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Sites.SiteFrm formSiteList = new Views.Sites.SiteFrm();
            formSiteList.WindowState = FormWindowState.Maximized;
            CanOpenForm(formSiteList);
        }

		private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
		{
            exitToolStripMenuItem_Click(sender, e);
		}

		private void tmrAlive_Tick(object sender, EventArgs e)
		{
            this.userLogStateUpdate(Properties.Settings.Default.curLoggedUID, 0);
        }

		private void buttonClose_Click(object sender, EventArgs e)
		{
            exitToolStripMenuItem_Click(sender, e);
        }

		private void buttonCustomer_Click(object sender, EventArgs e)
		{
            customerListToolStripMenuItem_Click(sender, e);
		}

		private void buttonItems_Click(object sender, EventArgs e)
		{
            itemListToolStripMenuItem_Click(sender, e);
		}

		private void buttonBOQ_Click(object sender, EventArgs e)
		{
            bToolStripMenuItem_Click(sender, e);

        }

        private void backupCompanyFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Backup for testonly
            if (this.CreateCompanyFileBackup())
            {
                MessageBox.Show("Backup completed.", "Backup company file");
            }
            
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
            //Test only; Need to create a dialog for selecting backup file and retore to db name
            //this.RestoreCompanyFile();
		}
	}
}