using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IViews;
using ESProMeter.Services;
using ESProMeter.Sessions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static ESProMeter.Extensions.FormExtension;
namespace ESProMeter.Views.Boq
{
    public partial class BoqDetailsFrm : Form
    {
        public BoqDetailsFrm(long boqId)
        {
            InitializeComponent();
            SetDoubleBuffer(dgvBoqList, true);
            this.FillCustomerCmb(cboCustomerName);
            if (this.BoqGetById(boqId, out var boq)){
                txtBOQTitle.SetText(boq.BOQTITLE);
                txtBOQDesc.SetText(boq.BOQDESC);
                dtpDate.Value = boq.BOQDATE;
                dtpValidDate.Value = boq.VALIDDATE;
                this.cboCustomerName.SelectedValue = boq.CUSTOMERID;
                this.FillSitesCmbByCustomer(boq.CUSTOMERID, cboSite);
                this.cboSite.SelectedValue = boq.SITEID; 
            }
            this.BoqLineGetById(boqId, this.dgvBoqList);        
        }

        private void mbtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BoqDetailsFrm_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvBoqList.Rows)
            {
                if (item.GetValue<int>("BOQITEMID") == 0)
                {
                    item.Visible = false;
                }
            }
        }
    }
}

