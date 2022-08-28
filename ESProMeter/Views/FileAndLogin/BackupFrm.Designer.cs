
namespace ESProMeter.Views.FileAndLogin
{
	partial class BackupFrm
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
			this.mbtBackup = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtHelp = new FontAwesome.Sharp.Material.MaterialButton();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFilePath = new System.Windows.Forms.TextBox();
			this.mbtBrowse = new FontAwesome.Sharp.Material.MaterialButton();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.chkOverwrite = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// mbtBackup
			// 
			this.mbtBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.mbtBackup.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
			this.mbtBackup.FlatAppearance.BorderSize = 2;
			this.mbtBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
			this.mbtBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtBackup.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.mbtBackup.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtBackup.IconColor = System.Drawing.Color.White;
			this.mbtBackup.IconSize = 1;
			this.mbtBackup.Location = new System.Drawing.Point(221, 127);
			this.mbtBackup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtBackup.Name = "mbtBackup";
			this.mbtBackup.Size = new System.Drawing.Size(126, 30);
			this.mbtBackup.TabIndex = 37;
			this.mbtBackup.Text = "Backup";
			this.mbtBackup.UseVisualStyleBackColor = false;
			this.mbtBackup.Click += new System.EventHandler(this.mbtBackup_Click);
			// 
			// mbtCancel
			// 
			this.mbtCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mbtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtCancel.ForeColor = System.Drawing.Color.White;
			this.mbtCancel.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtCancel.IconColor = System.Drawing.Color.White;
			this.mbtCancel.IconSize = 1;
			this.mbtCancel.Location = new System.Drawing.Point(355, 127);
			this.mbtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtCancel.Name = "mbtCancel";
			this.mbtCancel.Size = new System.Drawing.Size(126, 30);
			this.mbtCancel.TabIndex = 35;
			this.mbtCancel.Text = "Cancel";
			this.mbtCancel.UseVisualStyleBackColor = false;
			this.mbtCancel.Click += new System.EventHandler(this.mbtCancel_Click);
			// 
			// mbtHelp
			// 
			this.mbtHelp.BackColor = System.Drawing.Color.Transparent;
			this.mbtHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtHelp.ForeColor = System.Drawing.Color.Black;
			this.mbtHelp.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtHelp.IconColor = System.Drawing.Color.White;
			this.mbtHelp.IconSize = 1;
			this.mbtHelp.Location = new System.Drawing.Point(489, 127);
			this.mbtHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtHelp.Name = "mbtHelp";
			this.mbtHelp.Size = new System.Drawing.Size(126, 30);
			this.mbtHelp.TabIndex = 36;
			this.mbtHelp.Text = "Help";
			this.mbtHelp.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(310, 15);
			this.label1.TabIndex = 38;
			this.label1.Text = "Choose directory where you wish to save your backup file";
			// 
			// txtFilePath
			// 
			this.txtFilePath.Location = new System.Drawing.Point(12, 39);
			this.txtFilePath.Name = "txtFilePath";
			this.txtFilePath.ReadOnly = true;
			this.txtFilePath.Size = new System.Drawing.Size(505, 23);
			this.txtFilePath.TabIndex = 39;
			// 
			// mbtBrowse
			// 
			this.mbtBrowse.BackColor = System.Drawing.Color.Transparent;
			this.mbtBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtBrowse.ForeColor = System.Drawing.Color.Black;
			this.mbtBrowse.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtBrowse.IconColor = System.Drawing.Color.White;
			this.mbtBrowse.IconSize = 1;
			this.mbtBrowse.Location = new System.Drawing.Point(524, 39);
			this.mbtBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtBrowse.Name = "mbtBrowse";
			this.mbtBrowse.Size = new System.Drawing.Size(91, 23);
			this.mbtBrowse.TabIndex = 36;
			this.mbtBrowse.Text = "Browse";
			this.mbtBrowse.UseVisualStyleBackColor = false;
			this.mbtBrowse.Click += new System.EventHandler(this.mbtBrowse_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(274, 15);
			this.label2.TabIndex = 38;
			this.label2.Text = "Name your backup file or choose default file name";
			// 
			// txtFileName
			// 
			this.txtFileName.Location = new System.Drawing.Point(12, 95);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(392, 23);
			this.txtFileName.TabIndex = 39;
			this.txtFileName.Leave += new System.EventHandler(this.txtFileName_Leave);
			// 
			// chkOverwrite
			// 
			this.chkOverwrite.AutoSize = true;
			this.chkOverwrite.Location = new System.Drawing.Point(410, 97);
			this.chkOverwrite.Name = "chkOverwrite";
			this.chkOverwrite.Size = new System.Drawing.Size(143, 19);
			this.chkOverwrite.TabIndex = 40;
			this.chkOverwrite.Text = "Overwrite existing file.";
			this.chkOverwrite.UseVisualStyleBackColor = true;
			// 
			// BackupFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 165);
			this.Controls.Add(this.chkOverwrite);
			this.Controls.Add(this.txtFileName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtFilePath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mbtBackup);
			this.Controls.Add(this.mbtCancel);
			this.Controls.Add(this.mbtBrowse);
			this.Controls.Add(this.mbtHelp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BackupFrm";
			this.Text = "Backup company file";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.Material.MaterialButton mbtBackup;
		private FontAwesome.Sharp.Material.MaterialButton mbtCancel;
		private FontAwesome.Sharp.Material.MaterialButton mbtHelp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFilePath;
		private FontAwesome.Sharp.Material.MaterialButton mbtBrowse;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.CheckBox chkOverwrite;
	}
}