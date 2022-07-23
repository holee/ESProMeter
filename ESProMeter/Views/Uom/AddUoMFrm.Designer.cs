
namespace ESProMeter.Views.UnitOfMeasures
{
	partial class AddUoMFrm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.txtUoM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkInactive = new System.Windows.Forms.CheckBox();
            this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
            this.mbtSave = new FontAwesome.Sharp.Material.MaterialButton();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUomID = new System.Windows.Forms.Label();
            this.lblEditSequense = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "UOM Name";
            // 
            // txtUoM
            // 
            this.txtUoM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUoM.Location = new System.Drawing.Point(115, 54);
            this.txtUoM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUoM.Name = "txtUoM";
            this.txtUoM.Size = new System.Drawing.Size(354, 23);
            this.txtUoM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Abbreviation";
            // 
            // chkInactive
            // 
            this.chkInactive.AutoSize = true;
            this.chkInactive.Location = new System.Drawing.Point(374, 25);
            this.chkInactive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkInactive.Name = "chkInactive";
            this.chkInactive.Size = new System.Drawing.Size(107, 19);
            this.chkInactive.TabIndex = 3;
            this.chkInactive.Text = "UoM is inactive";
            this.chkInactive.UseVisualStyleBackColor = true;
            // 
            // mbtCancel
            // 
            this.mbtCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mbtCancel.ForeColor = System.Drawing.Color.White;
            this.mbtCancel.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.mbtCancel.IconColor = System.Drawing.Color.White;
            this.mbtCancel.IconSize = 32;
            this.mbtCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mbtCancel.Location = new System.Drawing.Point(390, 114);
            this.mbtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtCancel.Name = "mbtCancel";
            this.mbtCancel.Size = new System.Drawing.Size(99, 42);
            this.mbtCancel.TabIndex = 5;
            this.mbtCancel.Text = "Cancel";
            this.mbtCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mbtCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mbtCancel.UseVisualStyleBackColor = false;
            this.mbtCancel.Click += new System.EventHandler(this.mbtCancel_Click);
            // 
            // mbtSave
            // 
            this.mbtSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(70)))), ((int)(((byte)(118)))));
            this.mbtSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtSave.ForeColor = System.Drawing.Color.White;
            this.mbtSave.IconChar = FontAwesome.Sharp.MaterialIcons.PenPlus;
            this.mbtSave.IconColor = System.Drawing.Color.White;
            this.mbtSave.IconSize = 27;
            this.mbtSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mbtSave.Location = new System.Drawing.Point(274, 113);
            this.mbtSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtSave.Name = "mbtSave";
            this.mbtSave.Size = new System.Drawing.Size(108, 42);
            this.mbtSave.TabIndex = 4;
            this.mbtSave.Text = "Save";
            this.mbtSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mbtSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mbtSave.UseVisualStyleBackColor = false;
            this.mbtSave.Click += new System.EventHandler(this.mbtSave_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(115, 21);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(230, 23);
            this.cmbType.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "UOM Type";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(115, 84);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.MaxLength = 5;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(75, 23);
            this.txtDescription.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(472, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(195, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(350, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "*";
            // 
            // lblUomID
            // 
            this.lblUomID.AutoSize = true;
            this.lblUomID.Location = new System.Drawing.Point(22, 128);
            this.lblUomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUomID.Name = "lblUomID";
            this.lblUomID.Size = new System.Drawing.Size(13, 15);
            this.lblUomID.TabIndex = 7;
            this.lblUomID.Text = "0";
            // 
            // lblEditSequense
            // 
            this.lblEditSequense.AutoSize = true;
            this.lblEditSequense.Location = new System.Drawing.Point(140, 128);
            this.lblEditSequense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditSequense.Name = "lblEditSequense";
            this.lblEditSequense.Size = new System.Drawing.Size(13, 15);
            this.lblEditSequense.TabIndex = 8;
            this.lblEditSequense.Text = "0";
            // 
            // AddUoMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 172);
            this.Controls.Add(this.lblEditSequense);
            this.Controls.Add(this.lblUomID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.mbtCancel);
            this.Controls.Add(this.mbtSave);
            this.Controls.Add(this.chkInactive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtUoM);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "AddUoMFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Unit of Measure";
            this.Load += new System.EventHandler(this.AddUoMFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUoM;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chkInactive;
		private FontAwesome.Sharp.Material.MaterialButton mbtCancel;
		private FontAwesome.Sharp.Material.MaterialButton mbtSave;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUomID;
        private System.Windows.Forms.Label lblEditSequense;
    }
}