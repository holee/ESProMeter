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

        #region private fields

        private DateTime _createdAt=DateTime.UtcNow;
        private DateTime _updatedAt=DateTime.UtcNow;

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
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }
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
    }
}
