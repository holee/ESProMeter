
namespace ESProMeter.Views.Reports
{
	partial class ReportFilterFrm
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
			this.mbtOK = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtHelp = new FontAwesome.Sharp.Material.MaterialButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.field = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.values = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.wherecondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mbtRemoveFilter = new FontAwesome.Sharp.Material.MaterialButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// mbtOK
			// 
			this.mbtOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.mbtOK.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
			this.mbtOK.FlatAppearance.BorderSize = 2;
			this.mbtOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
			this.mbtOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtOK.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.mbtOK.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtOK.IconColor = System.Drawing.Color.White;
			this.mbtOK.IconSize = 1;
			this.mbtOK.Location = new System.Drawing.Point(187, 324);
			this.mbtOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtOK.Name = "mbtOK";
			this.mbtOK.Size = new System.Drawing.Size(126, 30);
			this.mbtOK.TabIndex = 26;
			this.mbtOK.Text = "OK";
			this.mbtOK.UseVisualStyleBackColor = false;
			this.mbtOK.Click += new System.EventHandler(this.mbtOK_Click);
			// 
			// mbtCancel
			// 
			this.mbtCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mbtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtCancel.ForeColor = System.Drawing.Color.White;
			this.mbtCancel.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtCancel.IconColor = System.Drawing.Color.White;
			this.mbtCancel.IconSize = 1;
			this.mbtCancel.Location = new System.Drawing.Point(321, 324);
			this.mbtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtCancel.Name = "mbtCancel";
			this.mbtCancel.Size = new System.Drawing.Size(126, 30);
			this.mbtCancel.TabIndex = 27;
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
			this.mbtHelp.Location = new System.Drawing.Point(455, 324);
			this.mbtHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtHelp.Name = "mbtHelp";
			this.mbtHelp.Size = new System.Drawing.Size(126, 30);
			this.mbtHelp.TabIndex = 28;
			this.mbtHelp.Text = "Help";
			this.mbtHelp.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(192, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(19, 15);
			this.label2.TabIndex = 32;
			this.label2.Text = "To";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 15);
			this.label3.TabIndex = 33;
			this.label3.Text = "From";
			// 
			// dtpFrom
			// 
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFrom.Location = new System.Drawing.Point(53, 22);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(116, 23);
			this.dtpFrom.TabIndex = 30;
			// 
			// dtpTo
			// 
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpTo.Location = new System.Drawing.Point(217, 22);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(116, 23);
			this.dtpTo.TabIndex = 31;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(12, 61);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(125, 199);
			this.listBox1.TabIndex = 34;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.field,
            this.values,
            this.wherecondition});
			this.dataGridView1.Location = new System.Drawing.Point(311, 61);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(271, 161);
			this.dataGridView1.TabIndex = 35;
			// 
			// field
			// 
			this.field.HeaderText = "FIELD";
			this.field.Name = "field";
			this.field.ReadOnly = true;
			// 
			// values
			// 
			this.values.HeaderText = "VALUES";
			this.values.Name = "values";
			this.values.ReadOnly = true;
			// 
			// wherecondition
			// 
			this.wherecondition.HeaderText = "WHERECONDITION";
			this.wherecondition.Name = "wherecondition";
			this.wherecondition.ReadOnly = true;
			this.wherecondition.Visible = false;
			// 
			// mbtRemoveFilter
			// 
			this.mbtRemoveFilter.BackColor = System.Drawing.Color.Transparent;
			this.mbtRemoveFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtRemoveFilter.ForeColor = System.Drawing.Color.Black;
			this.mbtRemoveFilter.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtRemoveFilter.IconColor = System.Drawing.Color.White;
			this.mbtRemoveFilter.IconSize = 1;
			this.mbtRemoveFilter.Location = new System.Drawing.Point(455, 228);
			this.mbtRemoveFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtRemoveFilter.Name = "mbtRemoveFilter";
			this.mbtRemoveFilter.Size = new System.Drawing.Size(126, 30);
			this.mbtRemoveFilter.TabIndex = 28;
			this.mbtRemoveFilter.Text = "Remove Filter";
			this.mbtRemoveFilter.UseVisualStyleBackColor = false;
			// 
			// ReportFilterFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 366);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtpFrom);
			this.Controls.Add(this.dtpTo);
			this.Controls.Add(this.mbtOK);
			this.Controls.Add(this.mbtCancel);
			this.Controls.Add(this.mbtRemoveFilter);
			this.Controls.Add(this.mbtHelp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ReportFilterFrm";
			this.Text = "Report Filter";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.Material.MaterialButton mbtOK;
		private FontAwesome.Sharp.Material.MaterialButton mbtCancel;
		private FontAwesome.Sharp.Material.MaterialButton mbtHelp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn field;
		private System.Windows.Forms.DataGridViewTextBoxColumn values;
		private System.Windows.Forms.DataGridViewTextBoxColumn wherecondition;
		private FontAwesome.Sharp.Material.MaterialButton mbtRemoveFilter;
	}
}