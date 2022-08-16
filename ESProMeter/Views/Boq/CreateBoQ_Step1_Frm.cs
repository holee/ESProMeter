using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IViews;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ESProMeter.Views.Boq
{
    public partial class CreateBoQ_Step1_Frm : Form, ITBOQ
    {
        #region private
        private DateTime _createdAt = DateTime.UtcNow;
        private DateTime _updatedAt = DateTime.UtcNow;
        private byte _isActive = 1;
        private long _divId = 0;
        private string _refnumber = string.Empty;
        private int _edit = 0;
        private long _id = 0;
        private int _status = 1;
        private long _uid = 0;
        private decimal _loe; 
        private decimal _op;
        private decimal _over;
        private decimal _safty;
        private decimal _tran;
        private decimal _margin;
        private decimal _inflation;
        #endregion
        #region properties
        public long ID
        {
            get => _id;
            set => _id = value;
        }
        public DateTime CDT
        {
            get => _createdAt;
            set => _createdAt = value;
        }
        public DateTime MDT
        {
            get => _updatedAt;
            set => _updatedAt = value;
        }
        public int EDSEQ
        {
            get => _edit;
            set => _edit = value;
        }
        public string REFNUMBER
        {
            get => _refnumber;
            set => _refnumber = value;
        }
        public string BOQTITLE
        {
            get => txtBOQTitle.Text.Trim();
            set => txtBOQTitle.SetText(value);
        }
        public string BOQDESC
        {
            get => txtBOQDesc.Text.Trim();
            set => txtBOQDesc.SetText(value);
        }
        public long CUSTOMERID
        {
            get => cboCustomerName.AsNumber<long>(true);
            set => cboCustomerName.SelectedValue = value;
        }
        public DateTime BOQDATE
        {
            get => dtpDate.Value;
            set => dtpDate.Value = value;
        }
        public DateTime VALIDDATE
        {
            get => dtpValidDate.Value;
            set => dtpValidDate.Value = value;
        }
        public byte ISACTIVE
        {
            get => _isActive;
            set => _isActive = value;
        }
        public long SITEID
        {
            get => cboSite.AsNumber<long>(true);
            set => cboSite.SelectedValue = value;
        }
        public long DIVID
        {
            get => _divId;
            set => _divId = value;
        }
        public string TERMSCONDITION
        {
            get => txtTermsCondition.Text.Trim();
            set => txtTermsCondition.SetText(value);
        }
        public int STATUS
        {
            get => _status;
            set => _status = value;
        }
        public long UID
        {
            get => _uid;
            set => _uid = value;
        }
        public decimal LOSSOFEFFECIENCYRATE {
            get 
            {
                return dtgBOQCostSetting.GetValue<decimal>(0, "Column4");
            }
            set => _loe=value; 
        }
        public decimal OPERATIONRATE {
            get
            {
                return dtgBOQCostSetting.GetValue<decimal>(1, "Column4");
            }
            set => _op=value; 
        }
        public decimal OVERHEADRATE {
            get
            {
                return dtgBOQCostSetting.GetValue<decimal>(2, "Column4");
            }
            set => _over=value; 
        }
        public decimal SAFETYRATE {
            get
            {
                return dtgBOQCostSetting.GetValue<decimal>(3, "Column4");
            }
            set => _safty=value; 
        }
        public decimal TRANSPORTATIONRATE {
            get
            {
                return dtgBOQCostSetting.GetValue<decimal>(4, "Column4");
            }
            set => _tran = value;
        }
        public decimal MARGINRATE {
            get
            {
                return dtgBOQCostSetting.GetValue<decimal>(5, "Column4");
            }
            set => _margin=value; 
        }
        public decimal INFlATIONRATE {
            get
            {
                return dtgBOQCostSetting.GetValue<decimal>(6, "Column4");
            }
            set => _inflation=value; 
        }

        #endregion
        public CreateBoQ_Step1_Frm()
        {
            InitializeComponent();
            cboCustomerName.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
            cboCustomerName.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.FillCustomerCmb(cboCustomerName);
            this.GetAdditionalCost(this.dtgBOQCostSetting);
            this.cboCustomerName.LostFocus += (s, e) =>
            {
                if (cboCustomerName.SelectedValue == null && cboCustomerName.Text.Length > 0)
                {
                    if (MessageBox.Show("there is not any customer in system.", "Bill Of Qauntity", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Views.Customers.CustomerCreateFrm form = new Views.Customers.CustomerCreateFrm();
                        form.NAME = cboCustomerName.Text;
                        if (this.CustomerCreate(form, out var id))
                        {
                            this.FillCustomerCmb(cboCustomerName);
                            this.cboCustomerName.SelectedValue = id;
                        }
                        else
                        {
                            this.FillCustomerCmb(cboCustomerName);
                        }
                    }
                    else return;
                }
            };

            this.cboCustomerName.SelectedValueChanged += (s, e) =>
            {
                if (cboCustomerName.SelectedValue == null) return;
                if (cboCustomerName.SelectedValue != null && cboCustomerName.Text.Length > 0)
                {
                    var id = cboCustomerName.AsNumber<long>(true);
                    this.FillSitesCmbByCustomer(id, cboSite);

                }
            };

            this.cboSite.LostFocus += (s, e) =>
            {
                if (cboSite.SelectedValue == null && cboSite.Text.Length > 0)
                {
                    if (MessageBox.Show("there is not any Site in system.", "Bill Of Qauntity", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Sites.AddSiteFrm form = new Sites.AddSiteFrm();
                        if (cboCustomerName.SelectedValue != null)
                        {
                            form.SITENAME = cboSite.Text;
                            form.CUSTOMERID = cboCustomerName.AsNumber<long>(true);
                            if (this.SiteCreateNewOrUpdate(form, out var id))
                            {
                                this.FillSitesCmbByCustomer(cboCustomerName.AsNumber<long>(true), cboSite);
                                this.cboSite.SelectedValue = id;
                            }
                        }

                    }
                    else return;
                }
            };
        }


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
                form.MdiParent = MainFrm.ActiveForm;
                form.StartPosition = FormStartPosition.CenterParent;
                form.Show();
            }
            else
            {
                return;
            }

        }
        public CreateBoQ_Step1_Frm(long cust_id)
        {
            InitializeComponent();
            cboCustomerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboCustomerName.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.FillCustomerCmb(cboCustomerName);
            cboCustomerName.SelectedValue = cust_id;
            this.GetAdditionalCost(this.dtgBOQCostSetting);
            this.cboCustomerName.LostFocus += (s, e) =>
            {
                if (cboCustomerName.SelectedValue == null && cboCustomerName.Text.Length > 0)
                {
                    if (MessageBox.Show("there is not any customer in system.", "Bill Of Qauntity", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Views.Customers.CustomerCreateFrm form = new Views.Customers.CustomerCreateFrm();
                        form.NAME = cboCustomerName.Text;
                        if (this.CustomerCreate(form, out var id))
                        {
                            this.FillCustomerCmb(cboCustomerName);
                            this.cboCustomerName.SelectedValue = id;
                        }
                        else
                        {
                            this.FillCustomerCmb(cboCustomerName);
                        }
                    }
                    else return;
                }
            };
            this.cboCustomerName.SelectedValueChanged += (s, e) =>
            {
                if (cboCustomerName.SelectedValue == null) return;
                if (cboCustomerName.SelectedValue != null && cboCustomerName.Text.Length > 0)
                {
                    var id = cboCustomerName.AsNumber<long>(true);
                    this.FillSitesCmbByCustomer(id, cboSite);
                }
            };
            this.cboSite.LostFocus += (s, e) =>
            {
                if (cboSite.SelectedValue == null && cboSite.Text.Length > 0)
                {
                    if (MessageBox.Show("there is not any Site in system.", "Bill Of Qauntity", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Sites.AddSiteFrm form = new Sites.AddSiteFrm();
                        if (cboCustomerName.SelectedValue != null)
                        {
                            form.SITENAME = cboSite.Text;
                            form.CUSTOMERID = cboCustomerName.AsNumber<long>(true);
                            if (this.SiteCreateNewOrUpdate(form, out var id))
                            {
                                this.FillSitesCmbByCustomer(cboCustomerName.AsNumber<long>(true), cboSite);
                                this.cboSite.SelectedValue = id;
                            }
                        }

                    }
                    else return;
                }
            };
        }
        //Key Press event
        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dtgBOQCostSettingEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgBOQCostSetting.Columns["Column4"].Name == "Column4"
                && dtgBOQCostSetting.Columns["Column4"] is DataGridViewTextBoxColumn)
            {
                TextBox qauntityTextBox = e.Control as TextBox;
                qauntityTextBox.KeyPress += TextBoxKeyPress;
            }
        }
        private void mbtNext_Click(object sender, EventArgs e) 
        {
            //CreateBoQ_Step2_Frm form = new CreateBoQ_Step2_Frm();
            //form.TopLevel = false;
            //form.TopMost = true;
            //form.FormBorderStyle = FormBorderStyle.None;
            //form.WindowState = FormWindowState.Maximized;
            //form.Dock = DockStyle.Fill;
            //MainFrm.MainF.panel2.Controls.Clear();
            //MainFrm.MainF.panel2.Controls.Add(form);
            //form.Show();
            //this.Close();

            if (cboCustomerName.SelectedValue != null
                && cboSite.SelectedValue != null)
            {
                if (this.BoqCreate(this, out var id))
                {
                    CreateBoQ_Step2_Frm form = new CreateBoQ_Step2_Frm(id,Enums.ActionType.CREATE);
                    form.WindowState = FormWindowState.Maximized;
                    CanOpenForm(form);
                    this.Close();
                }
            }
            else
            {
                if (cboCustomerName.SelectedValue == null)
                {
                    MessageBox.Show("Please select customer name and site name.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboCustomerName.Focus();
                    return;
                }
                if (cboSite.SelectedValue == null)
                {
                    MessageBox.Show("Please select site name and site name.", "Information",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboSite.Focus();
                    return;
                }

            }
        }

        private void mbtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbtAddCustomer_Click(object sender, EventArgs e)
        {
            
            Views.Customers.CustomerCreateFrm form = new Customers.CustomerCreateFrm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.CustomerCreate(form, out var id);
                this.FillCustomerCmb(cboCustomerName);
                this.cboCustomerName.SelectedValue = id;
            }

        }

        private void mbtAddSite_Click(object sender, EventArgs e)
        {
            if (cboCustomerName.SelectedValue == null)
            {
                MessageBox.Show( "Please select customer.","BOQ",MessageBoxButtons.OK);
                return;
            }
            var customerId = cboCustomerName.SelectedValue;
            Views.Sites.AddSiteFrm form = new Sites.AddSiteFrm(customerId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.SiteCreateNewOrUpdate(form, form, Enums.ActionType.CREATE);
                this.FillSitesCmbByCustomer(cboCustomerName.AsNumber<long>(true),cboSite);
            }
        }
        
    }
}

//if (cboCustomerName.Text.Length > 0)
//{
//    var txtsearch = ((ComboBox)sender).Text.Trim();
//    this.FillCustomerCmb(cboCustomerName, txtsearch);
//    cboCustomerName.DroppedDown = true;
//    cboCustomerName.Cursor = Cursor.Current;
//    //cboCustomerName.SelectionStart = cboCustomerName.Text.Length + 1;
//}
//else
//{
//    this.cboCustomerName.DroppedDown = false;
//    ((System.Data.DataTable)cboCustomerName.DataSource)?.Rows?.Clear();

//}


//if (cboCustomerName.SelectedValue == null && cboCustomerName.Text.Length > 0)
//{
//    Views.Customers.CustomerCreateFrm form = new Views.Customers.CustomerCreateFrm();
//    form.NAME = cboCustomerName.Text;
//    if (this.CustomerCreateOrUpdate(form, out var id))
//    {
//        this.FillCustomerCmb(cboCustomerName);
//        this.cboCustomerName.SelectedValue = id;
//    }
//    else
//    {
//        this.FillCustomerCmb(cboCustomerName);
//    }
//}
//else
//{
//    MessageBox.Show("Please provide customer name, to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    cboCustomerName.Focus();
//    return;
//}

//if (cboSite.SelectedValue == null && cboSite.Text.Length > 0)
//{
//    Sites.AddSiteFrm form = new Sites.AddSiteFrm();
//    form.SITENAME = cboSite.Text;
//    form.CUSTOMERID = cboCustomerName.AsNumber<long>(true);
//    if (this.SiteCreateNewOrUpdate(form, out var id))
//    {
//        this.FillSitesCmb(cboSite);
//        this.cboSite.SelectedValue = id;
//    }
//    else
//    {
//        this.FillSitesCmb(cboSite);
//    }
//}
//else
//{
//    MessageBox.Show("Please provide site name, to proceed.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
//    cboSite.Focus();
//    return;
//}