using ESProMeter.Properties;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ESProMeter.Extensions;
using static ESProMeter.Servers.ServerRegistration;
using ESProMeter.Views.UnitOfMeasures;
using ESProMeter.Views.Customers;
namespace ESProMeter
{
    public partial class Main : Form
    {
        
        private int childFormNumber = 0;
        private int mnuMaxSize = 150;  

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd,int wMsg,int wParam,int lParam);
        public Main()
        {
            InitializeComponent();
            panelMenu.Width = Settings.Default.menuSide;
            if (panelMenu.Width >=mnuMaxSize)
            {
                btnMenu.IconChar = IconChar.AngleLeft;
                btnMenu.IconColor = Color.White;
                foreach (Button menuItem in panelMenu.Controls.OfType<Button>())
                {
                    menuItem.Text = menuItem.Tag.ToString();
                    menuItem.Padding = new Padding(0, 0, 0, 0);
                }
            }
            else
            {
                btnMenu.IconChar = IconChar.AngleRight;
                btnMenu.IconColor = Color.White;
                btnMenu.FlatStyle = FlatStyle.Flat;
                foreach (Button menuItem in panelMenu.Controls.OfType<Button>())
                {
                    menuItem.Text = "";
                    menuItem.ImageAlign = ContentAlignment.MiddleCenter;
                    menuItem.Padding = new Padding(0);
                }
            }

        }


        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        
        private DataGridViewComboBoxColumn CreateComboCell()
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.FlatStyle = FlatStyle.Flat;
            combo.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            //combo.DataSource = DAL.Item.getAllItems("");
            combo.DisplayMember = "ItemName";
            combo.ValueMember = "Id";

            return combo;
        }

        private void Main_Load(object sender, EventArgs e)
        {
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
            catch
            {


            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > -1 && e.ColumnIndex==0)
            //{
            //    DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            //    dataGridView1[e.ColumnIndex, e.RowIndex] = cell;
            //    cell.DataSource = DAL.Item.getAllItems("");
            //    cell.DisplayMember = "ItemName";
            //    cell.ValueMember = "Id";
               
            //}
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //try
            //{ 
            //    var columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            //    var rowIndex=dataGridView1.CurrentCell.RowIndex;

            //    if (dataGridView1.CurrentCell.ColumnIndex == 0)
            //    {
            //        ComboBox com = e.Control as ComboBox;
            //        com.DropDownStyle = ComboBoxStyle.DropDown;
            //        com.SelectedValueChanged += (s, o)=>
            //        {
            //            //if (com.SelectedValue == null) return;
            //            //ComboBox c = (ComboBox)s;
            //            //MessageBox.Show(c.SelectedValue.ToString());
            //        };

            //    }
            //    if (dataGridView1.CurrentCell.ColumnIndex == 1)
            //    {
            //        TextBox txtbox=e.Control as TextBox;

            //        //txtbox.KeyUp += Txtbox_KeyUp;
            //        txtbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //        txtbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //        AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            //        AddItem(col);
            //        txtbox.AutoCompleteCustomSource = col;


            //    }

            //}
            //catch
            //{

              
            //}
           
        }

        //private void Txtbox_KeyUp(object sender, KeyEventArgs e)
        //{
        //        ((TextBox)sender).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //        ((TextBox)sender).AutoCompleteSource = AutoCompleteSource.CustomSource;
        //        ((TextBox)sender).AutoCompleteCustomSource = col;
        //}
        private void AddItem(AutoCompleteStringCollection collection)
        {
            //DataTable data = DAL.Item.getAllItems("");
            //foreach (DataRow item in data.Rows)
            //{
            //    collection.Add(item.ItemArray[1].ToString());
            //}
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            var x = ((Button)sender).Size.Width;
            contextEmployee.Show(x, Cursor.Position.Y);
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Views.Employees.Create());
            //TabPage tabPage = new TabPage();
            //tabPage.Text = $"{tabControl1.TabPages.Count}";
            //tabControl1.TabPages.Add(tabPage);
            //Form login = new Views.FormLogin();
            //login.Dock=DockStyle.Fill;
            //login.TopLevel = false;
            //tabPage.Controls.Add(login);
            //login.Show();
            //tabPage.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ////OpenChildForm(new Views.FormLogin());
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {

           
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
                    menuItem.Text =String.Empty;
                    menuItem.ImageAlign = ContentAlignment.MiddleCenter;
                    menuItem.Padding = new Padding(0);
                }
            }
        }

        private void buttonShowCustomer(object sender, EventArgs e)
        {
            //OpenChildForm(new Views.Customers.CustomerCenterFrm());
            Form form = new Views.Customers.CustomerCenterFrm();
            CanOpenForm(form);


        }

        private bool HasChildFormOpen(string formName)
        {
            if (Main.ActiveForm.ActiveMdiChild != null)
            {
                foreach (var item in MdiChildren)
                {
                    if (item.Name == formName)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private bool HasChildFormOpen(Form form)
        {
            if (MdiChildren.Any(frm=>frm.Name==form.Name))
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
                form.StartPosition=FormStartPosition.CenterParent;
                form.Show();
            }
            else
            {
                return;
            }

        }
       

        private void buttonShowItemList(object sender, EventArgs e)
        {
            CanOpenForm(new Views.Items.ItemListFrm());
        }

        private void buttonExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void btnHome_Click(object sender, EventArgs e)
		{
            //CanOpenForm(new Views.Home.HomeFrm());
        }

		private void buttonBOQ_Click(object sender, EventArgs e)
		{
           // CanOpenForm(new Views.BOQ.BoQFrm());
		}

		private void buttonSetting_Click(object sender, EventArgs e)
		{
            //Form form = new Views.Pref_Settings.SettingsFrm();
            //form.ShowDialog();
		}

		private void siteListToolStripMenuItem_Click(object sender, EventArgs e)
		{
            CanOpenForm(new Views.Sites.SiteFrm());
		}

		private void itemToolStripMenuItem_Click(object sender, EventArgs e)
		{
            CanOpenForm(new Views.Items.ItemListFrm());
        }

		private void myCompanyToolStripMenuItem_Click(object sender, EventArgs e)
		{
            CanOpenForm(new Views.Companies.CompanyInfoFrm());
		}

		private void dBConnectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form form = new Views.Servers.FormRegister();
            Views.Servers.FormRegister.isCnnChecking = true;
            form.ShowDialog();
        }

        private void uomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form uomFrm = new UoMFrm();
            CanOpenForm(uomFrm);
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

  
		private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
		{
            //CanOpenForm(new Views.Divisions.DivisionListFrm());
		}

        private void uomToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form uomFrm = new UoMFrm();
            CanOpenForm(uomFrm);
        }

		private void customerCenterToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form custFrm = new CustomerCenterFrm();
            CanOpenForm(custFrm);
        }

		private void createBOQToolStripMenuItem_Click(object sender, EventArgs e)
		{
            //Form BoQFrm = new Views.BOQ.BoQFrm();
            //CanOpenForm(BoQFrm);
        }

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Application.Exit();
		}

		private void settingToolStripMenuItem_Click(object sender, EventArgs e)
		{
            //Form form = new Views.Pref_Settings.SettingsFrm();
            //form.ShowDialog();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddAccountFrm addCoount = new AddAccountFrm();
            //addCoount.ShowDialog();
            //AccountModel model = new AccountModel(addCoount);
            //MessageBox.Show(model.UserName);
        }

     
    }
}

//private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
//{
//    if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
//    dragRow = e.RowIndex;
//    if (dragLabel == null) dragLabel = new Label();
//    dragLabel.Text = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
//    dragLabel.Parent = dataGridView1;
//    dragLabel.Location = e.Location;
//}
//private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
//{
//    if (e.Button == MouseButtons.Left && dragLabel != null)
//    {
//        dragLabel.Location = e.Location;
//        dataGridView1.ClearSelection();
//    }
//}

//private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
//{
//    var hit = dataGridView1.HitTest(e.X, e.Y);
//    int dropRow = -1;
//    if (hit.Type != DataGridViewHitTestType.None)
//    {
//        dropRow = hit.RowIndex;
//        if (dragRow >= 0)
//        {
//            int tgtRow = dropRow + (dragRow > dropRow ? 1 : 0);
//            if (tgtRow != dragRow)
//            {
//                DataGridViewRow row = dataGridView1.Rows[dragRow];
//                dataGridView1.Rows.Remove(row);
//                dataGridView1.Rows.Insert(tgtRow, row);

//                dataGridView1.ClearSelection();
//                row.Selected = true;
//            }
//        }
//    }
//    else { dataGridView1.Rows[dragRow].Selected = true; }

//    if (dragLabel != null)
//    {
//        dragLabel.Dispose();
//        dragLabel = null;
//    }
//}
//        if (tgtRow != dragRow)
//{
//    DataRow dtRow = DT.Rows[dragRow];
//        DataRow newRow = DT.NewRow();
//        newRow.ItemArray = DT.Rows[dragRow].ItemArray; // we need to clone the values

//    DT.Rows.Remove(dtRow);
//    DT.Rows.InsertAt(newRow, tgtRow);
//    dataGridView1.Refresh();
//    dataGridView1.Rows[tgtRow].Selected = true;
//}
//private void OpenChildForm(Form form)
//{
//    try
//    {
//        bool found = false;
//        if (Main.ActiveForm.ActiveMdiChild == null)
//        {
//            found = false;
//        }
//        else
//        {
//            foreach (var item in MdiChildren)
//            {
//                if (item.Name == form.Name)
//                {
//                    found = true;
//                }
//            }

//        }
//        if (!found)
//        {
//            form.MdiParent = this;
//            form.Show();
//        }
//    }
//    catch
//    {


//    }

//}



//private void OpenChildForm(Form childForm, DockStyle dockStyle)
//{
//    if (activeForm != null)
//        activeForm.Close();
//    activeForm = childForm;
//    activeForm.TopLevel = false;
//    childForm.FormBorderStyle = FormBorderStyle.None;
//    childForm.Dock = dockStyle;
//    panel1.Controls.Add(childForm);
//    panelMenu.Tag = childForm;
//    childForm.BringToFront();
//    //childForm.StartPosition = FormStartPosition.CenterScreen;
//    childForm.Show();

//}
//private void OpenChildForm(Form childForm)
//{
//    if (activeForm != null)
//    {
//        return;
//    }
//    activeForm = childForm;
//    if (!HasChildFormOpen(activeForm.Name))
//    {
//        activeForm.MdiParent = this;
//        activeForm.Show();
//    }

//}
//private void OpenChildForm(Form form)
//{
//    try
//    {
//        bool found = false;
//        if (Main.ActiveForm.ActiveMdiChild == null)
//        {
//            found = false;
//        }
//        else
//        {
//            foreach (var item in MdiChildren)
//            {
//                if (item.Name == form.Name)
//                {
//                    found = true;
//                }
//            }

//        }
//        if (!found)
//        {
//            form.MdiParent = this;
//            form.Show();
//        }
//    }
//    catch
//    {


//    }

//}



//private void OpenChildForm(Form childForm, DockStyle dockStyle)
//{
//    if (activeForm != null)
//        activeForm.Close();
//    activeForm = childForm;
//    activeForm.TopLevel = false;
//    childForm.FormBorderStyle = FormBorderStyle.None;
//    childForm.Dock = dockStyle;
//    panel1.Controls.Add(childForm);
//    panelMenu.Tag = childForm;
//    childForm.BringToFront();
//    //childForm.StartPosition = FormStartPosition.CenterScreen;
//    childForm.Show();

//}
//private void OpenChildForm(Form childForm)
//{
//    if (activeForm != null)
//    {
//        return;
//    }
//    activeForm = childForm;
//    if (!HasChildFormOpen(activeForm.Name))
//    {
//        activeForm.MdiParent = this;
//        activeForm.Show();
//    }