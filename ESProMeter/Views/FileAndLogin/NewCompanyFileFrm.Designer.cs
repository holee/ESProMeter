
namespace ESProMeter.Views.FileAndLogin
{
	partial class NewCompanyFileFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCompanyFileFrm));
			this.mbtOK = new FontAwesome.Sharp.Material.MaterialButton();
			this.materialButton1 = new FontAwesome.Sharp.Material.MaterialButton();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mbtOK
			// 
			this.mbtOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(70)))), ((int)(((byte)(118)))));
			this.mbtOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtOK.ForeColor = System.Drawing.Color.White;
			this.mbtOK.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtOK.IconColor = System.Drawing.Color.White;
			this.mbtOK.IconSize = 27;
			this.mbtOK.Location = new System.Drawing.Point(773, 465);
			this.mbtOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtOK.Name = "mbtOK";
			this.mbtOK.Size = new System.Drawing.Size(126, 30);
			this.mbtOK.TabIndex = 24;
			this.mbtOK.Text = "NEXT";
			this.mbtOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.mbtOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mbtOK.UseVisualStyleBackColor = false;
			// 
			// materialButton1
			// 
			this.materialButton1.BackColor = System.Drawing.Color.DimGray;
			this.materialButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.materialButton1.ForeColor = System.Drawing.Color.White;
			this.materialButton1.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.materialButton1.IconColor = System.Drawing.Color.White;
			this.materialButton1.IconSize = 27;
			this.materialButton1.Location = new System.Drawing.Point(639, 465);
			this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.materialButton1.Name = "materialButton1";
			this.materialButton1.Size = new System.Drawing.Size(126, 30);
			this.materialButton1.TabIndex = 24;
			this.materialButton1.Text = "BACK";
			this.materialButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.materialButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.materialButton1.UseVisualStyleBackColor = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(1, 36);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(899, 423);
			this.tabControl1.TabIndex = 25;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(891, 395);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(891, 395);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// NewCompanyFileFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(904, 501);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.materialButton1);
			this.Controls.Add(this.mbtOK);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewCompanyFileFrm";
			this.Text = "Create New Company File";
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private FontAwesome.Sharp.Material.MaterialButton mbtOK;
		private FontAwesome.Sharp.Material.MaterialButton materialButton1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
	}
}