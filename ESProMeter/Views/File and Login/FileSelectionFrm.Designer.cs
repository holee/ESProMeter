
namespace ESProMeter.Views.LogIn
{
	partial class FileSelectionFrm
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
			this.dtgCompanyList = new System.Windows.Forms.DataGridView();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnCreateNewCompanyFile = new System.Windows.Forms.Button();
			this.btnOpenOrRestoreCompanyFile = new System.Windows.Forms.Button();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DBName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dtgCompanyList)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(267, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select a company from below list and click Open.";
			// 
			// dtgCompanyList
			// 
			this.dtgCompanyList.AllowUserToAddRows = false;
			this.dtgCompanyList.AllowUserToDeleteRows = false;
			this.dtgCompanyList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgCompanyList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dtgCompanyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgCompanyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CDT,
            this.CompanyName,
            this.ServerName,
            this.DBName,
            this.UName,
            this.Password,
            this.isActive,
            this.Action});
			this.dtgCompanyList.Location = new System.Drawing.Point(12, 27);
			this.dtgCompanyList.Name = "dtgCompanyList";
			this.dtgCompanyList.ReadOnly = true;
			this.dtgCompanyList.RowHeadersVisible = false;
			this.dtgCompanyList.RowTemplate.Height = 25;
			this.dtgCompanyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgCompanyList.Size = new System.Drawing.Size(591, 261);
			this.dtgCompanyList.TabIndex = 1;
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(609, 27);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(128, 23);
			this.btnOpen.TabIndex = 2;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(609, 56);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(128, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnHelp
			// 
			this.btnHelp.Location = new System.Drawing.Point(609, 85);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(128, 23);
			this.btnHelp.TabIndex = 2;
			this.btnHelp.Text = "Help";
			this.btnHelp.UseVisualStyleBackColor = true;
			// 
			// btnCreateNewCompanyFile
			// 
			this.btnCreateNewCompanyFile.Location = new System.Drawing.Point(609, 192);
			this.btnCreateNewCompanyFile.Name = "btnCreateNewCompanyFile";
			this.btnCreateNewCompanyFile.Size = new System.Drawing.Size(128, 45);
			this.btnCreateNewCompanyFile.TabIndex = 2;
			this.btnCreateNewCompanyFile.Text = "Create New Company File";
			this.btnCreateNewCompanyFile.UseVisualStyleBackColor = true;
			// 
			// btnOpenOrRestoreCompanyFile
			// 
			this.btnOpenOrRestoreCompanyFile.Location = new System.Drawing.Point(609, 243);
			this.btnOpenOrRestoreCompanyFile.Name = "btnOpenOrRestoreCompanyFile";
			this.btnOpenOrRestoreCompanyFile.Size = new System.Drawing.Size(128, 45);
			this.btnOpenOrRestoreCompanyFile.TabIndex = 2;
			this.btnOpenOrRestoreCompanyFile.Text = "Open or Restore Company File";
			this.btnOpenOrRestoreCompanyFile.UseVisualStyleBackColor = true;
			// 
			// Id
			// 
			this.Id.HeaderText = "ID";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// CDT
			// 
			this.CDT.HeaderText = "CDT";
			this.CDT.Name = "CDT";
			this.CDT.ReadOnly = true;
			this.CDT.Visible = false;
			// 
			// CompanyName
			// 
			this.CompanyName.HeaderText = "COMPANY NAME";
			this.CompanyName.Name = "CompanyName";
			this.CompanyName.ReadOnly = true;
			// 
			// ServerName
			// 
			this.ServerName.HeaderText = "SERVER NAME";
			this.ServerName.Name = "ServerName";
			this.ServerName.ReadOnly = true;
			this.ServerName.Visible = false;
			// 
			// DBName
			// 
			this.DBName.HeaderText = "DATABASE NAME";
			this.DBName.Name = "DBName";
			this.DBName.ReadOnly = true;
			this.DBName.Visible = false;
			// 
			// UName
			// 
			this.UName.HeaderText = "USER NAME";
			this.UName.Name = "UName";
			this.UName.ReadOnly = true;
			this.UName.Visible = false;
			// 
			// Password
			// 
			this.Password.HeaderText = "PASSWORD";
			this.Password.Name = "Password";
			this.Password.ReadOnly = true;
			this.Password.Visible = false;
			// 
			// isActive
			// 
			this.isActive.HeaderText = "isActive";
			this.isActive.Name = "isActive";
			this.isActive.ReadOnly = true;
			this.isActive.Visible = false;
			// 
			// Action
			// 
			this.Action.FillWeight = 15F;
			this.Action.HeaderText = "ACTION";
			this.Action.Name = "Action";
			this.Action.ReadOnly = true;
			this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// FileSelectionFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 294);
			this.ControlBox = false;
			this.Controls.Add(this.btnOpenOrRestoreCompanyFile);
			this.Controls.Add(this.btnCreateNewCompanyFile);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.dtgCompanyList);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FileSelectionFrm";
			this.Text = "Open Company File";
			((System.ComponentModel.ISupportInitialize)(this.dtgCompanyList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dtgCompanyList;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.Button btnCreateNewCompanyFile;
		private System.Windows.Forms.Button btnOpenOrRestoreCompanyFile;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn CDT;
		private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DBName;
		private System.Windows.Forms.DataGridViewTextBoxColumn UName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Password;
		private System.Windows.Forms.DataGridViewTextBoxColumn isActive;
		private System.Windows.Forms.DataGridViewButtonColumn Action;
	}
}