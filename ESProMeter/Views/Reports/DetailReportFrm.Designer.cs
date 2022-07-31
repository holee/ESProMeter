
namespace ESProMeter.Views.Reports
{
	partial class DetailReportFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailReportFrm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCompanyName = new System.Windows.Forms.TextBox();
			this.txtReportTitle = new System.Windows.Forms.TextBox();
			this.dtgReport = new System.Windows.Forms.DataGridView();
			this.panReportHeader = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panReportFooter = new System.Windows.Forms.Panel();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgReport)).BeginInit();
			this.panReportHeader.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(91, 22);
			this.toolStripButton1.Text = "Report Filter";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
			this.toolStripButton2.Text = "Print";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(54, 22);
			this.toolStripButton3.Text = "Excel";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(66, 22);
			this.toolStripButton4.Text = "Refresh";
			// 
			// dtpTo
			// 
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpTo.Location = new System.Drawing.Point(217, 28);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(116, 23);
			this.dtpTo.TabIndex = 1;
			// 
			// dtpFrom
			// 
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFrom.Location = new System.Drawing.Point(53, 28);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(116, 23);
			this.dtpFrom.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "From";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(192, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(19, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "To";
			// 
			// txtCompanyName
			// 
			this.txtCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCompanyName.BackColor = System.Drawing.Color.White;
			this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCompanyName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.txtCompanyName.ForeColor = System.Drawing.Color.Navy;
			this.txtCompanyName.Location = new System.Drawing.Point(6, 5);
			this.txtCompanyName.Name = "txtCompanyName";
			this.txtCompanyName.ReadOnly = true;
			this.txtCompanyName.Size = new System.Drawing.Size(788, 20);
			this.txtCompanyName.TabIndex = 3;
			this.txtCompanyName.Text = "<Company Name>";
			this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtReportTitle
			// 
			this.txtReportTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtReportTitle.BackColor = System.Drawing.Color.White;
			this.txtReportTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtReportTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.txtReportTitle.ForeColor = System.Drawing.Color.Navy;
			this.txtReportTitle.Location = new System.Drawing.Point(6, 31);
			this.txtReportTitle.Name = "txtReportTitle";
			this.txtReportTitle.ReadOnly = true;
			this.txtReportTitle.Size = new System.Drawing.Size(788, 20);
			this.txtReportTitle.TabIndex = 3;
			this.txtReportTitle.Text = "<Report Title>";
			this.txtReportTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dtgReport
			// 
			this.dtgReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgReport.BackgroundColor = System.Drawing.Color.White;
			this.dtgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgReport.Location = new System.Drawing.Point(5, 3);
			this.dtgReport.Name = "dtgReport";
			this.dtgReport.RowTemplate.Height = 25;
			this.dtgReport.Size = new System.Drawing.Size(791, 226);
			this.dtgReport.TabIndex = 4;
			// 
			// panReportHeader
			// 
			this.panReportHeader.Controls.Add(this.txtCompanyName);
			this.panReportHeader.Controls.Add(this.txtReportTitle);
			this.panReportHeader.Location = new System.Drawing.Point(0, 52);
			this.panReportHeader.Name = "panReportHeader";
			this.panReportHeader.Size = new System.Drawing.Size(800, 79);
			this.panReportHeader.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.dtgReport);
			this.panel1.Location = new System.Drawing.Point(0, 132);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 232);
			this.panel1.TabIndex = 5;
			// 
			// panReportFooter
			// 
			this.panReportFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panReportFooter.Location = new System.Drawing.Point(0, 370);
			this.panReportFooter.Name = "panReportFooter";
			this.panReportFooter.Size = new System.Drawing.Size(800, 78);
			this.panReportFooter.TabIndex = 6;
			// 
			// DetailReportFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panReportFooter);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panReportHeader);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpFrom);
			this.Controls.Add(this.dtpTo);
			this.Controls.Add(this.toolStrip1);
			this.Name = "DetailReportFrm";
			this.Text = "DetailReportFrm";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgReport)).EndInit();
			this.panReportHeader.ResumeLayout(false);
			this.panReportHeader.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCompanyName;
		private System.Windows.Forms.TextBox txtReportTitle;
		private System.Windows.Forms.DataGridView dtgReport;
		private System.Windows.Forms.Panel panReportHeader;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panReportFooter;
	}
}