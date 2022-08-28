
namespace ESProMeter.Views.FileAndLogin
{
	partial class ConnectNewCompanyFileFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectNewCompanyFileFrm));
			this.label2 = new System.Windows.Forms.Label();
			this.mbtClose = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtHelp = new FontAwesome.Sharp.Material.MaterialButton();
			this.txtCompanyName = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtLegalCompanyName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.mbtTestCnn = new FontAwesome.Sharp.Material.MaterialButton();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtLoginName = new System.Windows.Forms.TextBox();
			this.lblMsg = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDBName = new System.Windows.Forms.TextBox();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.mbtConnect = new FontAwesome.Sharp.Material.MaterialButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(139, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(320, 30);
			this.label2.TabIndex = 0;
			this.label2.Text = "Connect to existing Company file";
			// 
			// mbtClose
			// 
			this.mbtClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mbtClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtClose.ForeColor = System.Drawing.Color.White;
			this.mbtClose.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtClose.IconColor = System.Drawing.Color.White;
			this.mbtClose.IconSize = 1;
			this.mbtClose.Location = new System.Drawing.Point(326, 393);
			this.mbtClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtClose.Name = "mbtClose";
			this.mbtClose.Size = new System.Drawing.Size(126, 30);
			this.mbtClose.TabIndex = 8;
			this.mbtClose.Text = "Close";
			this.mbtClose.UseVisualStyleBackColor = false;
			this.mbtClose.Click += new System.EventHandler(this.mbtClose_Click);
			// 
			// mbtHelp
			// 
			this.mbtHelp.BackColor = System.Drawing.Color.Transparent;
			this.mbtHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtHelp.ForeColor = System.Drawing.Color.Black;
			this.mbtHelp.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtHelp.IconColor = System.Drawing.Color.White;
			this.mbtHelp.IconSize = 1;
			this.mbtHelp.Location = new System.Drawing.Point(460, 393);
			this.mbtHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtHelp.Name = "mbtHelp";
			this.mbtHelp.Size = new System.Drawing.Size(126, 30);
			this.mbtHelp.TabIndex = 9;
			this.mbtHelp.Text = "Help";
			this.mbtHelp.UseVisualStyleBackColor = false;
			// 
			// txtCompanyName
			// 
			this.txtCompanyName.Location = new System.Drawing.Point(178, 22);
			this.txtCompanyName.Name = "txtCompanyName";
			this.txtCompanyName.ReadOnly = true;
			this.txtCompanyName.Size = new System.Drawing.Size(389, 23);
			this.txtCompanyName.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtLegalCompanyName);
			this.groupBox1.Controls.Add(this.txtCompanyName);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(11, 239);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(575, 148);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "COMPANY INFORMATION DETECTED";
			// 
			// txtLegalCompanyName
			// 
			this.txtLegalCompanyName.Location = new System.Drawing.Point(179, 51);
			this.txtLegalCompanyName.Name = "txtLegalCompanyName";
			this.txtLegalCompanyName.ReadOnly = true;
			this.txtLegalCompanyName.Size = new System.Drawing.Size(389, 23);
			this.txtLegalCompanyName.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(178, 77);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(389, 62);
			this.label7.TabIndex = 27;
			this.label7.Text = resources.GetString("label7.Text");
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 54);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(142, 15);
			this.label6.TabIndex = 27;
			this.label6.Text = "LEGAL COMPANY NAME:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 15);
			this.label5.TabIndex = 27;
			this.label5.Text = "COMPANY NAME:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.mbtTestCnn);
			this.groupBox2.Controls.Add(this.txtPassword);
			this.groupBox2.Controls.Add(this.txtLoginName);
			this.groupBox2.Controls.Add(this.lblMsg);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtDBName);
			this.groupBox2.Controls.Add(this.txtServer);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(12, 52);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(574, 163);
			this.groupBox2.TabIndex = 30;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "CONNECTION INFORMATION";
			// 
			// mbtTestCnn
			// 
			this.mbtTestCnn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.mbtTestCnn.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
			this.mbtTestCnn.FlatAppearance.BorderSize = 2;
			this.mbtTestCnn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
			this.mbtTestCnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtTestCnn.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.mbtTestCnn.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtTestCnn.IconColor = System.Drawing.Color.White;
			this.mbtTestCnn.IconSize = 1;
			this.mbtTestCnn.Location = new System.Drawing.Point(409, 57);
			this.mbtTestCnn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtTestCnn.Name = "mbtTestCnn";
			this.mbtTestCnn.Size = new System.Drawing.Size(159, 30);
			this.mbtTestCnn.TabIndex = 4;
			this.mbtTestCnn.Text = "Test Connection";
			this.mbtTestCnn.UseVisualStyleBackColor = false;
			this.mbtTestCnn.Click += new System.EventHandler(this.mbtTestCnn_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(137, 125);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(263, 23);
			this.txtPassword.TabIndex = 3;
			// 
			// txtLoginName
			// 
			this.txtLoginName.Location = new System.Drawing.Point(137, 94);
			this.txtLoginName.Name = "txtLoginName";
			this.txtLoginName.Size = new System.Drawing.Size(263, 23);
			this.txtLoginName.TabIndex = 2;
			// 
			// lblMsg
			// 
			this.lblMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.lblMsg.Location = new System.Drawing.Point(409, 88);
			this.lblMsg.Name = "lblMsg";
			this.lblMsg.Size = new System.Drawing.Size(157, 62);
			this.lblMsg.TabIndex = 27;
			this.lblMsg.Text = "The company file you are trying to connect is already connected and you cannot co" +
    "nnect again. ";
			this.lblMsg.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 15);
			this.label4.TabIndex = 27;
			this.label4.Text = "PASSWORD:";
			// 
			// txtDBName
			// 
			this.txtDBName.Location = new System.Drawing.Point(139, 61);
			this.txtDBName.Name = "txtDBName";
			this.txtDBName.Size = new System.Drawing.Size(261, 23);
			this.txtDBName.TabIndex = 1;
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(139, 28);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(429, 23);
			this.txtServer.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(102, 15);
			this.label8.TabIndex = 29;
			this.label8.Text = "DATABASE NAME:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 15);
			this.label3.TabIndex = 28;
			this.label3.Text = "LOGGIN NAME:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 15);
			this.label1.TabIndex = 29;
			this.label1.Text = "SERVER NAME or IP:";
			// 
			// mbtConnect
			// 
			this.mbtConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.mbtConnect.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
			this.mbtConnect.FlatAppearance.BorderSize = 2;
			this.mbtConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
			this.mbtConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtConnect.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.mbtConnect.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtConnect.IconColor = System.Drawing.Color.White;
			this.mbtConnect.IconSize = 1;
			this.mbtConnect.Location = new System.Drawing.Point(192, 393);
			this.mbtConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtConnect.Name = "mbtConnect";
			this.mbtConnect.Size = new System.Drawing.Size(126, 30);
			this.mbtConnect.TabIndex = 7;
			this.mbtConnect.Text = "Connect";
			this.mbtConnect.UseVisualStyleBackColor = false;
			this.mbtConnect.Click += new System.EventHandler(this.mbtConnect_Click);
			// 
			// ConnectNewCompanyFileFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 428);
			this.Controls.Add(this.mbtConnect);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.mbtClose);
			this.Controls.Add(this.mbtHelp);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConnectNewCompanyFileFrm";
			this.Text = "Open File Connection";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private FontAwesome.Sharp.Material.MaterialButton mbtClose;
		private FontAwesome.Sharp.Material.MaterialButton mbtHelp;
		private System.Windows.Forms.TextBox txtCompanyName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtLegalCompanyName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private FontAwesome.Sharp.Material.MaterialButton mbtTestCnn;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtLoginName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private FontAwesome.Sharp.Material.MaterialButton mbtConnect;
		private System.Windows.Forms.Label lblMsg;
		private System.Windows.Forms.TextBox txtDBName;
		private System.Windows.Forms.Label label8;
	}
}