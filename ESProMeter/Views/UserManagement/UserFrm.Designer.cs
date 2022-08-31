
namespace ESProMeter.Views.UserManagement
{
	partial class UserFrm
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
			this.mbtSave = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtClose = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtHelp = new FontAwesome.Sharp.Material.MaterialButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkIsInActive = new System.Windows.Forms.CheckBox();
			this.lblEditSequense = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.txtConfirm = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.mbtAddNewEmployee = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtViewDetails = new FontAwesome.Sharp.Material.MaterialButton();
			this.cboEmployeeName = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.assignedroleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.assignedrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgAssignedRoleList = new System.Windows.Forms.DataGridView();
			this.roleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mbtAssignedRole = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtRemoveRole = new FontAwesome.Sharp.Material.MaterialButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgAssignedRoleList)).BeginInit();
			this.SuspendLayout();
			// 
			// mbtSave
			// 
			this.mbtSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.mbtSave.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
			this.mbtSave.FlatAppearance.BorderSize = 2;
			this.mbtSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
			this.mbtSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtSave.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.mbtSave.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtSave.IconColor = System.Drawing.Color.White;
			this.mbtSave.IconSize = 1;
			this.mbtSave.Location = new System.Drawing.Point(474, 477);
			this.mbtSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtSave.Name = "mbtSave";
			this.mbtSave.Size = new System.Drawing.Size(126, 30);
			this.mbtSave.TabIndex = 10;
			this.mbtSave.Text = "Save";
			this.mbtSave.UseVisualStyleBackColor = false;
			this.mbtSave.Click += new System.EventHandler(this.mbtSave_Click);
			// 
			// mbtClose
			// 
			this.mbtClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mbtClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtClose.ForeColor = System.Drawing.Color.White;
			this.mbtClose.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtClose.IconColor = System.Drawing.Color.White;
			this.mbtClose.IconSize = 1;
			this.mbtClose.Location = new System.Drawing.Point(608, 477);
			this.mbtClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtClose.Name = "mbtClose";
			this.mbtClose.Size = new System.Drawing.Size(126, 30);
			this.mbtClose.TabIndex = 11;
			this.mbtClose.Text = "Close";
			this.mbtClose.UseVisualStyleBackColor = false;
			this.mbtClose.Click += new System.EventHandler(this.mbtClose_Click);
			// 
			// mbtHelp
			// 
			this.mbtHelp.BackColor = System.Drawing.Color.Transparent;
			this.mbtHelp.Enabled = false;
			this.mbtHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtHelp.ForeColor = System.Drawing.Color.Black;
			this.mbtHelp.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtHelp.IconColor = System.Drawing.Color.White;
			this.mbtHelp.IconSize = 1;
			this.mbtHelp.Location = new System.Drawing.Point(742, 477);
			this.mbtHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtHelp.Name = "mbtHelp";
			this.mbtHelp.Size = new System.Drawing.Size(126, 30);
			this.mbtHelp.TabIndex = 12;
			this.mbtHelp.Text = "Help";
			this.mbtHelp.UseVisualStyleBackColor = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkIsInActive);
			this.groupBox1.Controls.Add(this.lblEditSequense);
			this.groupBox1.Controls.Add(this.lblID);
			this.groupBox1.Controls.Add(this.txtConfirm);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.txtUserName);
			this.groupBox1.Controls.Add(this.mbtAddNewEmployee);
			this.groupBox1.Controls.Add(this.mbtViewDetails);
			this.groupBox1.Controls.Add(this.cboEmployeeName);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(855, 131);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "USER INFORMATION";
			// 
			// chkIsInActive
			// 
			this.chkIsInActive.AutoSize = true;
			this.chkIsInActive.Location = new System.Drawing.Point(443, 33);
			this.chkIsInActive.Name = "chkIsInActive";
			this.chkIsInActive.Size = new System.Drawing.Size(104, 19);
			this.chkIsInActive.TabIndex = 7;
			this.chkIsInActive.Text = "User is inactive";
			this.chkIsInActive.UseVisualStyleBackColor = true;
			// 
			// lblEditSequense
			// 
			this.lblEditSequense.AutoSize = true;
			this.lblEditSequense.Location = new System.Drawing.Point(443, 94);
			this.lblEditSequense.Name = "lblEditSequense";
			this.lblEditSequense.Size = new System.Drawing.Size(13, 15);
			this.lblEditSequense.TabIndex = 6;
			this.lblEditSequense.Text = "0";
			this.lblEditSequense.Visible = false;
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(408, 94);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(13, 15);
			this.lblID.TabIndex = 6;
			this.lblID.Text = "0";
			this.lblID.Visible = false;
			// 
			// txtConfirm
			// 
			this.txtConfirm.Location = new System.Drawing.Point(122, 94);
			this.txtConfirm.Name = "txtConfirm";
			this.txtConfirm.PasswordChar = '*';
			this.txtConfirm.Size = new System.Drawing.Size(280, 23);
			this.txtConfirm.TabIndex = 2;
			this.txtConfirm.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(122, 61);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(280, 23);
			this.txtPassword.TabIndex = 1;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(122, 29);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(280, 23);
			this.txtUserName.TabIndex = 0;
			// 
			// mbtAddNewEmployee
			// 
			this.mbtAddNewEmployee.BackColor = System.Drawing.Color.Transparent;
			this.mbtAddNewEmployee.Enabled = false;
			this.mbtAddNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtAddNewEmployee.ForeColor = System.Drawing.Color.Black;
			this.mbtAddNewEmployee.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtAddNewEmployee.IconColor = System.Drawing.Color.White;
			this.mbtAddNewEmployee.IconSize = 1;
			this.mbtAddNewEmployee.Location = new System.Drawing.Point(583, 94);
			this.mbtAddNewEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtAddNewEmployee.Name = "mbtAddNewEmployee";
			this.mbtAddNewEmployee.Size = new System.Drawing.Size(126, 30);
			this.mbtAddNewEmployee.TabIndex = 4;
			this.mbtAddNewEmployee.Text = "Add New Employee";
			this.mbtAddNewEmployee.UseVisualStyleBackColor = false;
			// 
			// mbtViewDetails
			// 
			this.mbtViewDetails.BackColor = System.Drawing.Color.Transparent;
			this.mbtViewDetails.Enabled = false;
			this.mbtViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtViewDetails.ForeColor = System.Drawing.Color.Black;
			this.mbtViewDetails.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtViewDetails.IconColor = System.Drawing.Color.White;
			this.mbtViewDetails.IconSize = 1;
			this.mbtViewDetails.Location = new System.Drawing.Point(717, 94);
			this.mbtViewDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtViewDetails.Name = "mbtViewDetails";
			this.mbtViewDetails.Size = new System.Drawing.Size(126, 30);
			this.mbtViewDetails.TabIndex = 5;
			this.mbtViewDetails.Text = "View Details";
			this.mbtViewDetails.UseVisualStyleBackColor = false;
			// 
			// cboEmployeeName
			// 
			this.cboEmployeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboEmployeeName.Enabled = false;
			this.cboEmployeeName.FormattingEnabled = true;
			this.cboEmployeeName.Location = new System.Drawing.Point(563, 65);
			this.cboEmployeeName.Name = "cboEmployeeName";
			this.cboEmployeeName.Size = new System.Drawing.Size(280, 23);
			this.cboEmployeeName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Confirm Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Enabled = false;
			this.label4.Location = new System.Drawing.Point(443, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "Employee Reference";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "User Name";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Controls.Add(this.dtgAssignedRoleList);
			this.groupBox2.Controls.Add(this.mbtAssignedRole);
			this.groupBox2.Controls.Add(this.mbtRemoveRole);
			this.groupBox2.Enabled = false;
			this.groupBox2.Location = new System.Drawing.Point(13, 162);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(855, 293);
			this.groupBox2.TabIndex = 30;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "ROLE LIST";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assignedroleid,
            this.assignedrole});
			this.dataGridView1.Enabled = false;
			this.dataGridView1.Location = new System.Drawing.Point(510, 22);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(332, 265);
			this.dataGridView1.TabIndex = 9;
			// 
			// assignedroleid
			// 
			this.assignedroleid.HeaderText = "ASSIGNEDROLEID";
			this.assignedroleid.Name = "assignedroleid";
			this.assignedroleid.ReadOnly = true;
			this.assignedroleid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.assignedroleid.Visible = false;
			// 
			// assignedrole
			// 
			this.assignedrole.FillWeight = 45F;
			this.assignedrole.HeaderText = "ASSIGNED ROLE";
			this.assignedrole.Name = "assignedrole";
			this.assignedrole.ReadOnly = true;
			// 
			// dtgAssignedRoleList
			// 
			this.dtgAssignedRoleList.AllowUserToAddRows = false;
			this.dtgAssignedRoleList.AllowUserToDeleteRows = false;
			this.dtgAssignedRoleList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dtgAssignedRoleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgAssignedRoleList.BackgroundColor = System.Drawing.Color.White;
			this.dtgAssignedRoleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgAssignedRoleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleid,
            this.role});
			this.dtgAssignedRoleList.Enabled = false;
			this.dtgAssignedRoleList.Location = new System.Drawing.Point(12, 22);
			this.dtgAssignedRoleList.Name = "dtgAssignedRoleList";
			this.dtgAssignedRoleList.ReadOnly = true;
			this.dtgAssignedRoleList.RowHeadersVisible = false;
			this.dtgAssignedRoleList.RowTemplate.Height = 25;
			this.dtgAssignedRoleList.Size = new System.Drawing.Size(332, 265);
			this.dtgAssignedRoleList.TabIndex = 6;
			// 
			// roleid
			// 
			this.roleid.HeaderText = "ROLEID";
			this.roleid.Name = "roleid";
			this.roleid.ReadOnly = true;
			this.roleid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.roleid.Visible = false;
			// 
			// role
			// 
			this.role.FillWeight = 45F;
			this.role.HeaderText = "ROLE";
			this.role.Name = "role";
			this.role.ReadOnly = true;
			// 
			// mbtAssignedRole
			// 
			this.mbtAssignedRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.mbtAssignedRole.Enabled = false;
			this.mbtAssignedRole.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
			this.mbtAssignedRole.FlatAppearance.BorderSize = 2;
			this.mbtAssignedRole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
			this.mbtAssignedRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtAssignedRole.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.mbtAssignedRole.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtAssignedRole.IconColor = System.Drawing.Color.White;
			this.mbtAssignedRole.IconSize = 1;
			this.mbtAssignedRole.Location = new System.Drawing.Point(366, 22);
			this.mbtAssignedRole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtAssignedRole.Name = "mbtAssignedRole";
			this.mbtAssignedRole.Size = new System.Drawing.Size(126, 30);
			this.mbtAssignedRole.TabIndex = 7;
			this.mbtAssignedRole.Text = "Assign";
			this.mbtAssignedRole.UseVisualStyleBackColor = false;
			// 
			// mbtRemoveRole
			// 
			this.mbtRemoveRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mbtRemoveRole.Enabled = false;
			this.mbtRemoveRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtRemoveRole.ForeColor = System.Drawing.Color.White;
			this.mbtRemoveRole.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtRemoveRole.IconColor = System.Drawing.Color.White;
			this.mbtRemoveRole.IconSize = 1;
			this.mbtRemoveRole.Location = new System.Drawing.Point(366, 58);
			this.mbtRemoveRole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtRemoveRole.Name = "mbtRemoveRole";
			this.mbtRemoveRole.Size = new System.Drawing.Size(126, 30);
			this.mbtRemoveRole.TabIndex = 8;
			this.mbtRemoveRole.Text = "Remove";
			this.mbtRemoveRole.UseVisualStyleBackColor = false;
			// 
			// UserFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 519);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.mbtSave);
			this.Controls.Add(this.mbtClose);
			this.Controls.Add(this.mbtHelp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserFrm";
			this.Text = "UserFrm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgAssignedRoleList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private FontAwesome.Sharp.Material.MaterialButton mbtSave;
		private FontAwesome.Sharp.Material.MaterialButton mbtClose;
		private FontAwesome.Sharp.Material.MaterialButton mbtHelp;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtConfirm;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUserName;
		private FontAwesome.Sharp.Material.MaterialButton mbtViewDetails;
		private System.Windows.Forms.ComboBox cboEmployeeName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private FontAwesome.Sharp.Material.MaterialButton mbtAddNewEmployee;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dtgAssignedRoleList;
		private System.Windows.Forms.DataGridViewTextBoxColumn roleid;
		private System.Windows.Forms.DataGridViewTextBoxColumn role;
		private FontAwesome.Sharp.Material.MaterialButton mbtAssignedRole;
		private FontAwesome.Sharp.Material.MaterialButton mbtRemoveRole;
		private System.Windows.Forms.DataGridViewTextBoxColumn assignedroleid;
		private System.Windows.Forms.DataGridViewTextBoxColumn assignedrole;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label lblEditSequense;
		private System.Windows.Forms.CheckBox chkIsInActive;
	}
}