namespace ESProMeter.Views.Activies
{
    partial class ActivityCreateFrm
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
			this.txtActionName = new System.Windows.Forms.TextBox();
			this.txtBOQID = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.chkInActive = new System.Windows.Forms.CheckBox();
			this.btnSaveAndNew = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
			this.lblActionID = new System.Windows.Forms.Label();
			this.lblEdit = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtActionName
			// 
			this.txtActionName.Location = new System.Drawing.Point(131, 57);
			this.txtActionName.Multiline = true;
			this.txtActionName.Name = "txtActionName";
			this.txtActionName.Size = new System.Drawing.Size(395, 38);
			this.txtActionName.TabIndex = 33;
			// 
			// txtBOQID
			// 
			this.txtBOQID.Location = new System.Drawing.Point(131, 28);
			this.txtBOQID.Name = "txtBOQID";
			this.txtBOQID.ReadOnly = true;
			this.txtBOQID.Size = new System.Drawing.Size(161, 23);
			this.txtBOQID.TabIndex = 30;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(131, 101);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(395, 214);
			this.txtDescription.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(38, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 15);
			this.label5.TabIndex = 36;
			this.label5.Text = "ACTION NAME";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(93, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 15);
			this.label3.TabIndex = 37;
			this.label3.Text = "BOQ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 15);
			this.label1.TabIndex = 37;
			this.label1.Text = "DESCRIPTION";
			// 
			// chkInActive
			// 
			this.chkInActive.AutoSize = true;
			this.chkInActive.Location = new System.Drawing.Point(312, 30);
			this.chkInActive.Name = "chkInActive";
			this.chkInActive.Size = new System.Drawing.Size(79, 19);
			this.chkInActive.TabIndex = 38;
			this.chkInActive.Text = "IN ACTIVE";
			this.chkInActive.UseVisualStyleBackColor = true;
			// 
			// btnSaveAndNew
			// 
			this.btnSaveAndNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveAndNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.btnSaveAndNew.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
			this.btnSaveAndNew.FlatAppearance.BorderSize = 2;
			this.btnSaveAndNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
			this.btnSaveAndNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSaveAndNew.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnSaveAndNew.IconChar = FontAwesome.Sharp.MaterialIcons.Floppy;
			this.btnSaveAndNew.IconColor = System.Drawing.Color.White;
			this.btnSaveAndNew.IconSize = 20;
			this.btnSaveAndNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSaveAndNew.Location = new System.Drawing.Point(359, 330);
			this.btnSaveAndNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnSaveAndNew.Name = "btnSaveAndNew";
			this.btnSaveAndNew.Size = new System.Drawing.Size(73, 30);
			this.btnSaveAndNew.TabIndex = 40;
			this.btnSaveAndNew.Text = "Save";
			this.btnSaveAndNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSaveAndNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSaveAndNew.UseVisualStyleBackColor = false;
			this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
			// 
			// mbtCancel
			// 
			this.mbtCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mbtCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mbtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtCancel.ForeColor = System.Drawing.Color.White;
			this.mbtCancel.IconChar = FontAwesome.Sharp.MaterialIcons.Close;
			this.mbtCancel.IconColor = System.Drawing.Color.White;
			this.mbtCancel.IconSize = 20;
			this.mbtCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mbtCancel.Location = new System.Drawing.Point(456, 330);
			this.mbtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtCancel.Name = "mbtCancel";
			this.mbtCancel.Size = new System.Drawing.Size(70, 30);
			this.mbtCancel.TabIndex = 41;
			this.mbtCancel.Text = "Cancel";
			this.mbtCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.mbtCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mbtCancel.UseVisualStyleBackColor = false;
			this.mbtCancel.Click += new System.EventHandler(this.mbtCancel_Click);
			// 
			// lblActionID
			// 
			this.lblActionID.AutoSize = true;
			this.lblActionID.Location = new System.Drawing.Point(416, 30);
			this.lblActionID.Name = "lblActionID";
			this.lblActionID.Size = new System.Drawing.Size(13, 15);
			this.lblActionID.TabIndex = 42;
			this.lblActionID.Text = "0";
			this.lblActionID.Visible = false;
			// 
			// lblEdit
			// 
			this.lblEdit.AutoSize = true;
			this.lblEdit.Location = new System.Drawing.Point(496, 31);
			this.lblEdit.Name = "lblEdit";
			this.lblEdit.Size = new System.Drawing.Size(13, 15);
			this.lblEdit.TabIndex = 43;
			this.lblEdit.Text = "0";
			this.lblEdit.Visible = false;
			// 
			// ActivityCreateFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 372);
			this.Controls.Add(this.lblEdit);
			this.Controls.Add(this.lblActionID);
			this.Controls.Add(this.btnSaveAndNew);
			this.Controls.Add(this.mbtCancel);
			this.Controls.Add(this.chkInActive);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtActionName);
			this.Controls.Add(this.txtBOQID);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Name = "ActivityCreateFrm";
			this.Text = "ActivityCreateFrm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActionName;
        private System.Windows.Forms.TextBox txtBOQID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkInActive;
        private FontAwesome.Sharp.Material.MaterialButton btnSaveAndNew;
        private FontAwesome.Sharp.Material.MaterialButton mbtCancel;
        private System.Windows.Forms.Label lblActionID;
        private System.Windows.Forms.Label lblEdit;
    }
}