using ESProMeter.Extensions;
using ESProMeter.IVews;
using System;
using System.Windows.Forms;

namespace ESProMeter.Views.Activies
{
    public partial class ActivityCreateFrm : Form,ITACTIVITY
    {
        public ActivityCreateFrm()
        {
            InitializeComponent();
        }
        public ActivityCreateFrm(long boq_id)
        {
            InitializeComponent();
            this.BOQID = boq_id;
        }
        #region private fields

        private DateTime _createdAt=DateTime.UtcNow;
        private DateTime _updatedAt=DateTime.UtcNow;
        private int _status=0;

        #endregion
        #region properties
        public long ID { 
            get => lblActionID.AsNumber<long>(); 
            set => lblActionID.SetText(value); 
        }
        public int EDSEQ { 
            get => lblEdit.AsNumber<int>(); 
            set => lblEdit.SetText(value); 
        }
        public long BOQID { 
            get => txtBOQID.AsNumber<long>(); 
            set => txtBOQID.SetText(value); 
        }
        public string ACTNAME { 
            get => txtActionName.Text.Trim(); 
            set => txtActionName.SetText(value); 
        }
        public string DESCRIPTION { 
            get => txtDescription.Text.Trim();
            set => txtDescription.SetText(value);
                }
        public int STATUS { 
            get => _status; 
            set => _status=value; }
        public byte ISACTIVE { 
            get => chkInActive.Checked?(byte)0:(byte)1; 
            set => chkInActive.Checked= value == 1 ?false:true; 
        }
        public DateTime CDT { 
            get => _createdAt; 
            set => _createdAt=value; 
        }
        public DateTime MDT { 
            get => _updatedAt; 
            set => _updatedAt=value; 
        }
        #endregion

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if (this.IsValid(txtActionName))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void mbtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
