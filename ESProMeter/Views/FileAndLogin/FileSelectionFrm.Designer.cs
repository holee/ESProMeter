
namespace ESProMeter.Views.FileAndLogin
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
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DBName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mbtConnectToExistingCompanyFile = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtRestoreCompanyFile = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtCreateNewCompanyFile = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtHelp = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtClose = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtOpen = new FontAwesome.Sharp.Material.MaterialButton();
			((System.ComponentModel.ISupportInitialize)(this.dtgCompanyList)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(267, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select a company from below list and click Open.";
			// 
			// dtgCompanyList
			// 
			this.dtgCompanyList.AllowUserToAddRows = false;
			this.dtgCompanyList.AllowUserToDeleteRows = false;
			this.dtgCompanyList.AllowUserToResizeColumns = false;
			this.dtgCompanyList.AllowUserToResizeRows = false;
			this.dtgCompanyList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgCompanyList.BackgroundColor = System.Drawing.Color.Snow;
			this.dtgCompanyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgCompanyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CDT,
            this.CompanyName,
            this.ServerName,
            this.DBName,
            this.UName,
            this.Password,
            this.isActive});
			this.dtgCompanyList.Location = new System.Drawing.Point(12, 27);
			this.dtgCompanyList.Name = "dtgCompanyList";
			this.dtgCompanyList.ReadOnly = true;
			this.dtgCompanyList.RowHeadersVisible = false;
			this.dtgCompanyList.RowTemplate.Height = 25;
			this.dtgCompanyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgCompanyList.Size = new System.Drawing.Size(591, 261);
			this.dtgCompanyList.TabIndex = 1;
			// 
			// Id
			// 
			this.Id.HeaderText = "ID";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Id.Visible = false;
			// 
			// CDT
			// 
			this.CDT.HeaderText = "CDT";
			this.CDT.Name = "CDT";
			this.CDT.ReadOnly = true;
			this.CDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.CDT.Visible = false;
			// 
			// CompanyName
			// 
			this.CompanyName.HeaderText = "COMPANY NAME";
			this.CompanyName.Name = "CompanyName";
			this.CompanyName.ReadOnly = true;
			this.CompanyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// ServerName
			// 
			this.ServerName.HeaderText = "SERVER NAME";
			this.ServerName.Name = "ServerName";
			this.ServerName.ReadOnly = true;
			this.ServerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.ServerName.Visible = false;
			// 
			// DBName
			// 
			this.DBName.HeaderText = "DATABASE NAME";
			this.DBName.Name = "DBName";
			this.DBName.ReadOnly = true;
			this.DBName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.DBName.Visible = false;
			// 
			// UName
			// 
			this.UName.HeaderText = "USER NAME";
			this.UName.Name = "UName";
			this.UName.ReadOnly = true;
			this.UName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.UName.Visible = false;
			// 
			// Password
			// 
			this.Password.HeaderText = "PASSWORD";
			this.Password.Name = "Password";
			this.Password.ReadOnly = true;
			this.Password.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Password.Visible = false;
			// 
			// isActive
			// 
			this.isActive.HeaderText = "isActive";
			this.isActive.Name = "isActive";
			this.isActive.ReadOnly = true;
			this.isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.isActive.Visible = false;
			// 
			// mbtConnectToExistingCompanyFile
			// 
			this.mbtConnectToExistingCompanyFile.BackColor = System.Drawing.Color.Transparent;
			this.mbtConnectToExistingCompanyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtConnectToExistingCompanyFile.ForeColor = System.Drawing.Color.Black;
			this.mbtConnectToExistingCompanyFile.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtConnectToExistingCompanyFile.IconColor = System.Drawing.Color.White;
			this.mbtConnectToExistingCompanyFile.IconSize = 1;
			this.mbtConnectToExistingCompanyFile.Location = new System.Drawing.Point(611, 203);
			this.mbtConnectToExistingCompanyFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtConnectToExistingCompanyFile.Name = "mbtConnectToExistingCompanyFile";
			this.mbtConnectToExistingCompanyFile.Size = new System.Drawing.Size(126, 43);
			this.mbtConnectToExistingCompanyFile.TabIndex = 25;
			this.mbtConnectToExistingCompanyFile.Text = "Connect to Existing Company File";
			this.mbtConnectToExistingCompanyFile.UseVisualStyleBackColor = false;
			this.mbtConnectToExistingCompanyFile.Click += new System.EventHandler(this.mbtConnectToExistingCompanyFile_Click);
			// 
			// mbtRestoreCompanyFile
			// 
			this.mbtRestoreCompanyFile.BackColor = System.Drawing.Color.Transparent;
			this.mbtRestoreCompanyFile.Enabled = false;
			this.mbtRestoreCompanyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtRestoreCompanyFile.ForeColor = System.Drawing.Color.Black;
			this.mbtRestoreCompanyFile.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtRestoreCompanyFile.IconColor = System.Drawing.Color.White;
			this.mbtRestoreCompanyFile.IconSize = 1;
			this.mbtRestoreCompanyFile.Location = new System.Drawing.Point(611, 245);
			this.mbtRestoreCompanyFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtRestoreCompanyFile.Name = "mbtRestoreCompanyFile";
			this.mbtRestoreCompanyFile.Size = new System.Drawing.Size(126, 43);
			this.mbtRestoreCompanyFile.TabIndex = 25;
			this.mbtRestoreCompanyFile.Text = "Restore Company File";
			this.mbtRestoreCompanyFile.UseVisualStyleBackColor = false;
			// 
			// mbtCreateNewCompanyFile
			// 
			this.mbtCreateNewCompanyFile.BackColor = System.Drawing.Color.Transparent;
			this.mbtCreateNewCompanyFile.Enabled = false;
			this.mbtCreateNewCompanyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtCreateNewCompanyFile.ForeColor = System.Drawing.Color.Black;
			this.mbtCreateNewCompanyFile.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtCreateNewCompanyFile.IconColor = System.Drawing.Color.White;
			this.mbtCreateNewCompanyFile.IconSize = 1;
			this.mbtCreateNewCompanyFile.Location = new System.Drawing.Point(611, 161);
			this.mbtCreateNewCompanyFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtCreateNewCompanyFile.Name = "mbtCreateNewCompanyFile";
			this.mbtCreateNewCompanyFile.Size = new System.Drawing.Size(126, 43);
			this.mbtCreateNewCompanyFile.TabIndex = 25;
			this.mbtCreateNewCompanyFile.Text = "Create New Company File";
			this.mbtCreateNewCompanyFile.UseVisualStyleBackColor = false;
			// 
			// mbtHelp
			// 
			this.mbtHelp.BackColor = System.Drawing.Color.Transparent;
			this.mbtHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtHelp.ForeColor = System.Drawing.Color.Black;
			this.mbtHelp.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtHelp.IconColor = System.Drawing.Color.White;
			this.mbtHelp.IconSize = 1;
			this.mbtHelp.Location = new System.Drawing.Point(611, 86);
			this.mbtHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtHelp.Name = "mbtHelp";
			this.mbtHelp.Size = new System.Drawing.Size(126, 30);
			this.mbtHelp.TabIndex = 25;
			this.mbtHelp.Text = "Help";
			this.mbtHelp.UseVisualStyleBackColor = false;
			// 
			// mbtClose
			// 
			this.mbtClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mbtClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtClose.ForeColor = System.Drawing.Color.White;
			this.mbtClose.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtClose.IconColor = System.Drawing.Color.White;
			this.mbtClose.IconSize = 1;
			this.mbtClose.Location = new System.Drawing.Point(611, 57);
			this.mbtClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtClose.Name = "mbtClose";
			this.mbtClose.Size = new System.Drawing.Size(126, 30);
			this.mbtClose.TabIndex = 25;
			this.mbtClose.Text = "Close";
			this.mbtClose.UseVisualStyleBackColor = false;
			this.mbtClose.Click += new System.EventHandler(this.mbtClose_Click);
			// 
			// mbtOpen
			// 
			this.mbtOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.mbtOpen.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
			this.mbtOpen.FlatAppearance.BorderSize = 2;
			this.mbtOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
			this.mbtOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtOpen.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.mbtOpen.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtOpen.IconColor = System.Drawing.Color.White;
			this.mbtOpen.IconSize = 1;
			this.mbtOpen.Location = new System.Drawing.Point(611, 27);
			this.mbtOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtOpen.Name = "mbtOpen";
			this.mbtOpen.Size = new System.Drawing.Size(126, 30);
			this.mbtOpen.TabIndex = 25;
			this.mbtOpen.Text = "Open";
			this.mbtOpen.UseVisualStyleBackColor = false;
			this.mbtOpen.Click += new System.EventHandler(this.mbtOpen_Click);
			// 
			// FileSelectionFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(742, 294);
			this.ControlBox = false;
			this.Controls.Add(this.mbtRestoreCompanyFile);
			this.Controls.Add(this.mbtOpen);
			this.Controls.Add(this.mbtClose);
			this.Controls.Add(this.mbtHelp);
			this.Controls.Add(this.mbtCreateNewCompanyFile);
			this.Controls.Add(this.mbtConnectToExistingCompanyFile);
			this.Controls.Add(this.dtgCompanyList);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FileSelectionFrm";
			this.Text = "Open Company File";
			this.Load += new System.EventHandler(this.FileSelectionFrm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgCompanyList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dtgCompanyList;
		private FontAwesome.Sharp.Material.MaterialButton mbtConnectToExistingCompanyFile;
		private FontAwesome.Sharp.Material.MaterialButton mbtRestoreCompanyFile;
		private FontAwesome.Sharp.Material.MaterialButton mbtCreateNewCompanyFile;
		private FontAwesome.Sharp.Material.MaterialButton mbtHelp;
		private FontAwesome.Sharp.Material.MaterialButton mbtClose;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn CDT;
		private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DBName;
		private System.Windows.Forms.DataGridViewTextBoxColumn UName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Password;
		private System.Windows.Forms.DataGridViewTextBoxColumn isActive;
		private FontAwesome.Sharp.Material.MaterialButton mbtOpen;
	}
}