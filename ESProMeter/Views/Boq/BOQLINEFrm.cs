using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IVews;
using System;
using System.Windows.Forms;

namespace ESProMeter.Views.Boq
{
    public partial class BOQLINEFrm : Form,IADDITIONALCOST
    {
        public BOQLINEFrm(long itemId,IADDITIONALCOST aCost)
        {
            InitializeComponent();
            this.GetItemForUpdate(itemId);
            this.LOSSOFEFFECIENCYRATE = aCost.LOSSOFEFFECIENCYRATE;
            this.OPERATIONRATE = aCost.OPERATIONRATE;
            this.OVERHEADRATE = aCost.OVERHEADRATE;
            this.TRANSPORTATIONRATE = aCost.TRANSPORTATIONRATE;
            this.SAFETYRATE = aCost.SAFETYRATE;
            this.MARGINRATE = aCost.MARGINRATE;
            this.INFlATIONRATE = aCost.INFlATIONRATE;
            ////
            txtLoseEffecency.LostFocus -= TxtLostFocus;
            txtOperation.LostFocus -= TxtLostFocus;
            txtOverhead.LostFocus -= TxtLostFocus;
            txtSafty.LostFocus -= TxtLostFocus;
            txtMargin.LostFocus -= TxtLostFocus;
            txtInflation.LostFocus += TxtLostFocus;
            txtTransportation.LostFocus -= TxtLostFocus;
            ////
            txtLoseEffecency.LostFocus += TxtLostFocus;
            txtOperation.LostFocus += TxtLostFocus;
            txtOverhead.LostFocus += TxtLostFocus;
            txtSafty.LostFocus += TxtLostFocus;
            txtMargin.LostFocus += TxtLostFocus;
            txtInflation.LostFocus += TxtLostFocus;
            txtTransportation.LostFocus += TxtLostFocus;
            ///
            txtLoseEffecency.GotFocus -= TxtGotFocus;
            txtOperation.GotFocus -= TxtGotFocus;
            txtOverhead.GotFocus -= TxtGotFocus;
            txtSafty.GotFocus -= TxtGotFocus;
            txtMargin.GotFocus -= TxtGotFocus;
            txtInflation.GotFocus -= TxtGotFocus;
            txtTransportation.GotFocus -= TxtGotFocus;
            //-------------------------------
            txtLoseEffecency.GotFocus += TxtGotFocus;
            txtOperation.GotFocus += TxtGotFocus;
            txtOverhead.GotFocus += TxtGotFocus;
            txtSafty.GotFocus += TxtGotFocus;
            txtMargin.GotFocus += TxtGotFocus;
            txtInflation.GotFocus += TxtGotFocus;
            txtTransportation.GotFocus += TxtGotFocus;
        }

        private void TxtGotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender)?.BeginInvoke(new Action(((TextBox)sender).SelectAll));
        }

        private void TxtLostFocus(object sender, EventArgs e)
        {
            var textValue = ((TextBox)sender).AsNumber<decimal>();
            if (textValue >= 100)
            {
                MessageBox.Show("The value must not greater than 100.","Additinal Cost",MessageBoxButtons.OK);
                ((TextBox)sender).Focus();
                ((TextBox)sender).SelectAll();
                return;
            }
            ((TextBox)sender).Text=Utility.NumberString(textValue, "N3");
        }

        #region properties
        public decimal LOSSOFEFFECIENCYRATE 
        { 
            get => txtLoseEffecency.AsNumber<decimal>(); 
            set => txtLoseEffecency.SetText(value); 
        }
        public decimal OPERATIONRATE 
        { get => txtOperation.AsNumber<decimal>(); 
            set => txtOperation.SetText(value); 
        }
        public decimal OVERHEADRATE 
        { get => txtOverhead.AsNumber<decimal>(); 
            set => txtOverhead.SetText(value); 
        }
        public decimal SAFETYRATE 
        { get => txtSafty.AsNumber<decimal>(); 
            set => txtSafty.SetText(value); 
        }
        public decimal TRANSPORTATIONRATE 
        { get => txtTransportation.AsNumber<decimal>(); 
            set => txtTransportation.SetText(value); 
        }
        public decimal MARGINRATE 
        { get => txtMargin.AsNumber<decimal>(); 
            set => txtMargin.SetText(value); 
        }
        public decimal INFlATIONRATE 
        { 
            get => txtInflation.AsNumber<decimal>(); 
            set => txtInflation.SetText(value); 
        }
        #endregion
        private void mbtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbtNext_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
