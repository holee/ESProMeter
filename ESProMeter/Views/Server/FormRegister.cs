using System;
using System.Windows.Forms;
using ESProMeter.Extensions;
using ESProMeter.Servers;
using ESProMeter.Properties;
namespace ESProMeter.Views.Servers
{
    public partial class FormRegister : Form
    {
        public static Boolean isCnnChecking;

        public FormRegister()
        {
            InitializeComponent();
        }

        private void mbtCancel_Click(object sender, EventArgs e)
        {
                if (!this.IsDisposed)
                {
                    this.Dispose(true);
                if (isCnnChecking)
                {
                    this.Close();
                }
                else
                {
                    Application.Exit();
                }
                }
                else
                {
                   Application.Exit();
                }
 

        }

        private void mbtRegister_Click(object sender, EventArgs e)
        {
            if (rbtLDB.Checked)
            {
                if (this.IsValid(txtDBFilePath))
                {
                    if (ServerRegistration.SetRegisterKey(txtDBFilePath.Text))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }else
            {
                if (this.IsValid(txtServer, txtDatabase, txtUserID, txtPassword))
                {
                    if (ServerRegistration.SetRegisterKey(txtServer.Text, txtDatabase.Text
                        , txtUserID.Text, txtPassword.Text))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void rbtLDB_CheckedChanged(object sender, EventArgs e)
        {
            Boolean chkState = rbtLDB.Checked;
            label6.Enabled = chkState;
            txtDBFilePath.Enabled = chkState;
        }

        private void rbtSQLDB_CheckedChanged(object sender, EventArgs e)
        {
            Boolean chkState = rbtSQLDB.Checked;
            label1.Enabled = chkState;
            label2.Enabled = chkState;
            label3.Enabled = chkState;
            label4.Enabled = chkState;
            txtServer.Enabled = chkState;
            txtDatabase.Enabled = chkState;
            txtUserID.Enabled = chkState;
            txtPassword.Enabled = chkState;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.MDF)|*.MDF";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtDBFilePath.Text = openFileDialog.FileName;
            }
        }

        private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!this.IsDisposed)
                {
                    this.Dispose(true);
                    if (isCnnChecking)
                    {
                        this.Close();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        private void mbtTestCnn_Click(object sender, EventArgs e)
        {
            if (rbtLDB.Checked)
            {
                //Create connection to localDB
                //At least database file path is needed
                if (this.IsValid(txtDBFilePath))
                {
                    if (ServerRegistration.TestConnection(txtDBFilePath.Text))
                    {
                        MessageBox.Show("You have successfully connected to the database.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your database file path correctly then try again.", "Check file path");
                }
            }
            else
            {
                //Create connection to SQL Server
                //At least database server information is needed
                if (this.IsValid(txtServer, txtDatabase, txtUserID, txtPassword))
                {
                    if (ServerRegistration.TestConnection(txtServer.Text, txtDatabase.Text, txtUserID.Text, txtPassword.Text))
                    {
                        MessageBox.Show("You have successfully connected to the database.");
                    }
                    //else
                    //{
                    //    MessageBox.Show("Cannot connect to the database, please verify your database server information and try again.");
                    //}

                }
                else
                {
                    MessageBox.Show("Please verify your database server information and try again.", "Check Database Information");
                }
            }
        }
		private void FormRegister_Load(object sender, EventArgs e)
		{
            if (Settings.Default.isLDB)
            {
                txtDBFilePath.Text = ESProMeter.Properties.Settings.Default.DBFilePath;
                rbtLDB.Checked = true;
                rbtSQLDB.Checked = false;
            }
            else
            {
                rbtLDB.Checked = false;
                rbtSQLDB.Checked = true;
                txtServer.Text = Settings.Default.serverName;
                txtDatabase.Text =Settings.Default.database;
                txtUserID.Text = Settings.Default.userID;
                txtPassword.Text =Settings.Default.Password;
            }
        }
	}
}