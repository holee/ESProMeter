
namespace ESProMeter.Views.FileAndLogin
{
	partial class UserLoginFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginFrm));
			this.label1 = new System.Windows.Forms.Label();
			this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtOK = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtHelp = new FontAwesome.Sharp.Material.MaterialButton();
			this.lblSelectedCompany = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(463, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter user name and password to log in to the selected company file";
			// 
			// mbtCancel
			// 
			this.mbtCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mbtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtCancel.ForeColor = System.Drawing.Color.White;
			this.mbtCancel.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
			this.mbtCancel.IconColor = System.Drawing.Color.White;
			this.mbtCancel.IconSize = 32;
			this.mbtCancel.Location = new System.Drawing.Point(211, 166);
			this.mbtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtCancel.Name = "mbtCancel";
			this.mbtCancel.Size = new System.Drawing.Size(126, 33);
			this.mbtCancel.TabIndex = 22;
			this.mbtCancel.Text = "CANCEL";
			this.mbtCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.mbtCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mbtCancel.UseVisualStyleBackColor = false;
			this.mbtCancel.Click += new System.EventHandler(this.mbtCancel_Click);
			// 
			// mbtOK
			// 
			this.mbtOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(70)))), ((int)(((byte)(118)))));
			this.mbtOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtOK.ForeColor = System.Drawing.Color.White;
			this.mbtOK.IconChar = FontAwesome.Sharp.MaterialIcons.Login;
			this.mbtOK.IconColor = System.Drawing.Color.White;
			this.mbtOK.IconSize = 27;
			this.mbtOK.Location = new System.Drawing.Point(79, 166);
			this.mbtOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtOK.Name = "mbtOK";
			this.mbtOK.Size = new System.Drawing.Size(126, 33);
			this.mbtOK.TabIndex = 23;
			this.mbtOK.Text = "OK";
			this.mbtOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.mbtOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mbtOK.UseVisualStyleBackColor = false;
			// 
			// mbtHelp
			// 
			this.mbtHelp.BackColor = System.Drawing.Color.DimGray;
			this.mbtHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtHelp.ForeColor = System.Drawing.Color.White;
			this.mbtHelp.IconChar = FontAwesome.Sharp.MaterialIcons.HelpCircle;
			this.mbtHelp.IconColor = System.Drawing.Color.White;
			this.mbtHelp.IconSize = 32;
			this.mbtHelp.Location = new System.Drawing.Point(345, 166);
			this.mbtHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtHelp.Name = "mbtHelp";
			this.mbtHelp.Size = new System.Drawing.Size(126, 33);
			this.mbtHelp.TabIndex = 22;
			this.mbtHelp.Text = "HELP";
			this.mbtHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.mbtHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mbtHelp.UseVisualStyleBackColor = false;
			// 
			// lblSelectedCompany
			// 
			this.lblSelectedCompany.AutoSize = true;
			this.lblSelectedCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblSelectedCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblSelectedCompany.Location = new System.Drawing.Point(160, 40);
			this.lblSelectedCompany.Name = "lblSelectedCompany";
			this.lblSelectedCompany.Size = new System.Drawing.Size(155, 21);
			this.lblSelectedCompany.TabIndex = 24;
			this.lblSelectedCompany.Text = "<Company Name>";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label2.Location = new System.Drawing.Point(12, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 15);
			this.label2.TabIndex = 25;
			this.label2.Text = "USER NAME:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label3.Location = new System.Drawing.Point(12, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 15);
			this.label3.TabIndex = 25;
			this.label3.Text = "PASSWORD:";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(92, 75);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(311, 23);
			this.txtUserName.TabIndex = 26;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(92, 112);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(311, 23);
			this.txtPassword.TabIndex = 26;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label4.Location = new System.Drawing.Point(92, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(153, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "Password are case sensitive.";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.checkBox1.Location = new System.Drawing.Point(409, 116);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(137, 19);
			this.checkBox1.TabIndex = 27;
			this.checkBox1.Text = "Remember password";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// UserLoginFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 211);
			this.ControlBox = false;
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblSelectedCompany);
			this.Controls.Add(this.mbtHelp);
			this.Controls.Add(this.mbtCancel);
			this.Controls.Add(this.mbtOK);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UserLoginFrm";
			this.Text = "Login...";
			this.Load += new System.EventHandler(this.UserLoginFrm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private FontAwesome.Sharp.Material.MaterialButton mbtCancel;
		private FontAwesome.Sharp.Material.MaterialButton mbtOK;
		private FontAwesome.Sharp.Material.MaterialButton mbtHelp;
		private System.Windows.Forms.Label lblSelectedCompany;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}