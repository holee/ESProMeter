
namespace ESProMeter.Views.UserManagement
{
	partial class UserManagementFrm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtgRolePermission = new System.Windows.Forms.DataGridView();
			this.permissionid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.permission = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgAssignedRoleList = new System.Windows.Forms.DataGridView();
			this.roleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.mbtNew = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtEdit = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtDelete = new FontAwesome.Sharp.Material.MaterialButton();
			this.dtgUserList = new System.Windows.Forms.DataGridView();
			this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgRolePermission)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgAssignedRoleList)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgUserList)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.dtgRolePermission);
			this.groupBox1.Controls.Add(this.dtgAssignedRoleList);
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(440, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(565, 476);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ASSIGNED ROLES && PERMISSION";
			// 
			// dtgRolePermission
			// 
			this.dtgRolePermission.AllowUserToAddRows = false;
			this.dtgRolePermission.AllowUserToDeleteRows = false;
			this.dtgRolePermission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgRolePermission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgRolePermission.BackgroundColor = System.Drawing.Color.White;
			this.dtgRolePermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgRolePermission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.permissionid,
            this.permission});
			this.dtgRolePermission.Enabled = false;
			this.dtgRolePermission.Location = new System.Drawing.Point(283, 22);
			this.dtgRolePermission.Name = "dtgRolePermission";
			this.dtgRolePermission.ReadOnly = true;
			this.dtgRolePermission.RowHeadersVisible = false;
			this.dtgRolePermission.RowTemplate.Height = 25;
			this.dtgRolePermission.Size = new System.Drawing.Size(271, 448);
			this.dtgRolePermission.TabIndex = 28;
			// 
			// permissionid
			// 
			this.permissionid.HeaderText = "PERMISSIONID";
			this.permissionid.Name = "permissionid";
			this.permissionid.ReadOnly = true;
			this.permissionid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.permissionid.Visible = false;
			// 
			// permission
			// 
			this.permission.FillWeight = 45F;
			this.permission.HeaderText = "PERMISSION";
			this.permission.Name = "permission";
			this.permission.ReadOnly = true;
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
			this.dtgAssignedRoleList.Location = new System.Drawing.Point(6, 22);
			this.dtgAssignedRoleList.Name = "dtgAssignedRoleList";
			this.dtgAssignedRoleList.ReadOnly = true;
			this.dtgAssignedRoleList.RowHeadersVisible = false;
			this.dtgAssignedRoleList.RowTemplate.Height = 25;
			this.dtgAssignedRoleList.Size = new System.Drawing.Size(271, 448);
			this.dtgAssignedRoleList.TabIndex = 3;
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
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.Controls.Add(this.mbtNew);
			this.groupBox2.Controls.Add(this.mbtEdit);
			this.groupBox2.Controls.Add(this.mbtDelete);
			this.groupBox2.Controls.Add(this.dtgUserList);
			this.groupBox2.Location = new System.Drawing.Point(12, 21);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(407, 476);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "USER LIST";
			// 
			// mbtNew
			// 
			this.mbtNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.mbtNew.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
			this.mbtNew.FlatAppearance.BorderSize = 2;
			this.mbtNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
			this.mbtNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtNew.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.mbtNew.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtNew.IconColor = System.Drawing.Color.White;
			this.mbtNew.IconSize = 1;
			this.mbtNew.Location = new System.Drawing.Point(7, 440);
			this.mbtNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtNew.Name = "mbtNew";
			this.mbtNew.Size = new System.Drawing.Size(126, 30);
			this.mbtNew.TabIndex = 26;
			this.mbtNew.Text = "New";
			this.mbtNew.UseVisualStyleBackColor = false;
			this.mbtNew.Click += new System.EventHandler(this.mbtNew_Click);
			// 
			// mbtEdit
			// 
			this.mbtEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtEdit.BackColor = System.Drawing.Color.Transparent;
			this.mbtEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtEdit.ForeColor = System.Drawing.Color.Black;
			this.mbtEdit.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtEdit.IconColor = System.Drawing.Color.White;
			this.mbtEdit.IconSize = 1;
			this.mbtEdit.Location = new System.Drawing.Point(140, 440);
			this.mbtEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtEdit.Name = "mbtEdit";
			this.mbtEdit.Size = new System.Drawing.Size(126, 30);
			this.mbtEdit.TabIndex = 28;
			this.mbtEdit.Text = "Edit";
			this.mbtEdit.UseVisualStyleBackColor = false;
			this.mbtEdit.Click += new System.EventHandler(this.mbtEdit_Click);
			// 
			// mbtDelete
			// 
			this.mbtDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mbtDelete.BackColor = System.Drawing.Color.Transparent;
			this.mbtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtDelete.ForeColor = System.Drawing.Color.Black;
			this.mbtDelete.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtDelete.IconColor = System.Drawing.Color.White;
			this.mbtDelete.IconSize = 1;
			this.mbtDelete.Location = new System.Drawing.Point(274, 440);
			this.mbtDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtDelete.Name = "mbtDelete";
			this.mbtDelete.Size = new System.Drawing.Size(126, 30);
			this.mbtDelete.TabIndex = 28;
			this.mbtDelete.Text = "Delete";
			this.mbtDelete.UseVisualStyleBackColor = false;
			// 
			// dtgUserList
			// 
			this.dtgUserList.AllowUserToAddRows = false;
			this.dtgUserList.AllowUserToDeleteRows = false;
			this.dtgUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgUserList.BackgroundColor = System.Drawing.Color.White;
			this.dtgUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.user,
            this.status});
			this.dtgUserList.Location = new System.Drawing.Point(6, 22);
			this.dtgUserList.Name = "dtgUserList";
			this.dtgUserList.ReadOnly = true;
			this.dtgUserList.RowHeadersVisible = false;
			this.dtgUserList.RowTemplate.Height = 25;
			this.dtgUserList.Size = new System.Drawing.Size(394, 412);
			this.dtgUserList.TabIndex = 1;
			// 
			// userid
			// 
			this.userid.HeaderText = "USERID";
			this.userid.Name = "userid";
			this.userid.ReadOnly = true;
			this.userid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.userid.Visible = false;
			// 
			// user
			// 
			this.user.FillWeight = 70F;
			this.user.HeaderText = "USER";
			this.user.Name = "user";
			this.user.ReadOnly = true;
			// 
			// status
			// 
			this.status.FillWeight = 30F;
			this.status.HeaderText = "STATUS";
			this.status.Name = "status";
			this.status.ReadOnly = true;
			// 
			// UserManagementFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1010, 509);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "UserManagementFrm";
			this.Text = "UserManagementFrm";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgRolePermission)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgAssignedRoleList)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgUserList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dtgAssignedRoleList;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dtgUserList;
		private System.Windows.Forms.DataGridView dtgRolePermission;
		private FontAwesome.Sharp.Material.MaterialButton mbtNew;
		private FontAwesome.Sharp.Material.MaterialButton mbtEdit;
		private FontAwesome.Sharp.Material.MaterialButton mbtDelete;
		private System.Windows.Forms.DataGridViewTextBoxColumn permissionid;
		private System.Windows.Forms.DataGridViewTextBoxColumn permission;
		private System.Windows.Forms.DataGridViewTextBoxColumn roleid;
		private System.Windows.Forms.DataGridViewTextBoxColumn role;
		private System.Windows.Forms.DataGridViewTextBoxColumn userid;
		private System.Windows.Forms.DataGridViewTextBoxColumn user;
		private System.Windows.Forms.DataGridViewTextBoxColumn status;
	}
}