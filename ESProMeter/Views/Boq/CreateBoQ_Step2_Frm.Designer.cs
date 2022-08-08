
namespace ESProMeter.Views.Boq
{
	partial class CreateBoQ_Step2_Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mbtAddSite = new FontAwesome.Sharp.Material.MaterialButton();
            this.mbtAddCustomer = new FontAwesome.Sharp.Material.MaterialButton();
            this.cboSite = new System.Windows.Forms.ComboBox();
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpValidDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtBOQDesc = new System.Windows.Forms.TextBox();
            this.txtBOQTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTermsCondition = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boqdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbtNext = new FontAwesome.Sharp.Material.MaterialButton();
            this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
            this.materialButton1 = new FontAwesome.Sharp.Material.MaterialButton();
            this.lblID = new System.Windows.Forms.Label();
            this.materialButton2 = new FontAwesome.Sharp.Material.MaterialButton();
            this.materialButton3 = new FontAwesome.Sharp.Material.MaterialButton();
            this.materialButton4 = new FontAwesome.Sharp.Material.MaterialButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.mbtAddSite);
            this.panel1.Controls.Add(this.mbtAddCustomer);
            this.panel1.Controls.Add(this.cboSite);
            this.panel1.Controls.Add(this.cboCustomerName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 37);
            this.panel1.TabIndex = 1;
            // 
            // mbtAddSite
            // 
            this.mbtAddSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.mbtAddSite.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.mbtAddSite.FlatAppearance.BorderSize = 2;
            this.mbtAddSite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.mbtAddSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mbtAddSite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mbtAddSite.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.mbtAddSite.IconColor = System.Drawing.Color.White;
            this.mbtAddSite.IconSize = 1;
            this.mbtAddSite.Location = new System.Drawing.Point(822, 6);
            this.mbtAddSite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtAddSite.Name = "mbtAddSite";
            this.mbtAddSite.Size = new System.Drawing.Size(26, 27);
            this.mbtAddSite.TabIndex = 3;
            this.mbtAddSite.Text = "+";
            this.mbtAddSite.UseVisualStyleBackColor = false;
            // 
            // mbtAddCustomer
            // 
            this.mbtAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.mbtAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.mbtAddCustomer.FlatAppearance.BorderSize = 2;
            this.mbtAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.mbtAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mbtAddCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mbtAddCustomer.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.mbtAddCustomer.IconColor = System.Drawing.Color.White;
            this.mbtAddCustomer.IconSize = 1;
            this.mbtAddCustomer.Location = new System.Drawing.Point(486, 5);
            this.mbtAddCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtAddCustomer.Name = "mbtAddCustomer";
            this.mbtAddCustomer.Size = new System.Drawing.Size(26, 27);
            this.mbtAddCustomer.TabIndex = 1;
            this.mbtAddCustomer.Text = "+";
            this.mbtAddCustomer.UseVisualStyleBackColor = false;
            // 
            // cboSite
            // 
            this.cboSite.FormattingEnabled = true;
            this.cboSite.Location = new System.Drawing.Point(589, 8);
            this.cboSite.Name = "cboSite";
            this.cboSite.Size = new System.Drawing.Size(234, 23);
            this.cboSite.TabIndex = 2;
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.Location = new System.Drawing.Point(124, 7);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(363, 23);
            this.cboCustomerName.TabIndex = 0;
            this.cboCustomerName.SelectionChangeCommitted += new System.EventHandler(this.cboCustomerName_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "SITE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER NAME:";
            // 
            // dtpValidDate
            // 
            this.dtpValidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidDate.Location = new System.Drawing.Point(750, 44);
            this.dtpValidDate.Name = "dtpValidDate";
            this.dtpValidDate.Size = new System.Drawing.Size(109, 23);
            this.dtpValidDate.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(549, 44);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(109, 23);
            this.dtpDate.TabIndex = 5;
            // 
            // txtBOQDesc
            // 
            this.txtBOQDesc.Location = new System.Drawing.Point(125, 73);
            this.txtBOQDesc.Multiline = true;
            this.txtBOQDesc.Name = "txtBOQDesc";
            this.txtBOQDesc.Size = new System.Drawing.Size(469, 23);
            this.txtBOQDesc.TabIndex = 7;
            this.txtBOQDesc.Enter += new System.EventHandler(this.txtBOQDesc_Enter);
            this.txtBOQDesc.Leave += new System.EventHandler(this.txtBOQDesc_Leave);
            // 
            // txtBOQTitle
            // 
            this.txtBOQTitle.Location = new System.Drawing.Point(125, 44);
            this.txtBOQTitle.Name = "txtBOQTitle";
            this.txtBOQTitle.Size = new System.Drawing.Size(363, 23);
            this.txtBOQTitle.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "VALID DATE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "DATE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "BOQ DESCRIPTION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "BOQ TITLE:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "TERMS && CONDITION";
            // 
            // txtTermsCondition
            // 
            this.txtTermsCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTermsCondition.Location = new System.Drawing.Point(140, 401);
            this.txtTermsCondition.Multiline = true;
            this.txtTermsCondition.Name = "txtTermsCondition";
            this.txtTermsCondition.Size = new System.Drawing.Size(454, 23);
            this.txtTermsCondition.TabIndex = 32;
            this.txtTermsCondition.Enter += new System.EventHandler(this.txtTermsCondition_Enter);
            this.txtTermsCondition.Leave += new System.EventHandler(this.txtTermsCondition_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.itemname,
            this.boqdescription,
            this.quantity,
            this.uom,
            this.remarks,
            this.action});
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 284);
            this.dataGridView1.TabIndex = 37;
            // 
            // no
            // 
            this.no.FillWeight = 5F;
            this.no.HeaderText = "NO";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // itemname
            // 
            this.itemname.FillWeight = 20F;
            this.itemname.HeaderText = "ITEM NAME";
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            // 
            // boqdescription
            // 
            this.boqdescription.FillWeight = 25F;
            this.boqdescription.HeaderText = "BOQ DESCRIPTION";
            this.boqdescription.Name = "boqdescription";
            this.boqdescription.ReadOnly = true;
            // 
            // quantity
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.quantity.FillWeight = 8F;
            this.quantity.HeaderText = "QUANTITY";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // uom
            // 
            this.uom.FillWeight = 7F;
            this.uom.HeaderText = "UOM";
            this.uom.Name = "uom";
            this.uom.ReadOnly = true;
            // 
            // remarks
            // 
            this.remarks.FillWeight = 27F;
            this.remarks.HeaderText = "REMARKS";
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            // 
            // action
            // 
            this.action.FillWeight = 8F;
            this.action.HeaderText = "ACTION";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            // 
            // mbtNext
            // 
            this.mbtNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.mbtNext.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.mbtNext.FlatAppearance.BorderSize = 2;
            this.mbtNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.mbtNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mbtNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mbtNext.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.mbtNext.IconColor = System.Drawing.Color.White;
            this.mbtNext.IconSize = 1;
            this.mbtNext.Location = new System.Drawing.Point(752, 401);
            this.mbtNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtNext.Name = "mbtNext";
            this.mbtNext.Size = new System.Drawing.Size(126, 30);
            this.mbtNext.TabIndex = 38;
            this.mbtNext.Text = "Save && New";
            this.mbtNext.UseVisualStyleBackColor = false;
            // 
            // mbtCancel
            // 
            this.mbtCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mbtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtCancel.ForeColor = System.Drawing.Color.White;
            this.mbtCancel.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.mbtCancel.IconColor = System.Drawing.Color.White;
            this.mbtCancel.IconSize = 1;
            this.mbtCancel.Location = new System.Drawing.Point(886, 401);
            this.mbtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtCancel.Name = "mbtCancel";
            this.mbtCancel.Size = new System.Drawing.Size(126, 30);
            this.mbtCancel.TabIndex = 39;
            this.mbtCancel.Text = "Cancel";
            this.mbtCancel.UseVisualStyleBackColor = false;
            this.mbtCancel.Click += new System.EventHandler(this.mbtCancel_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.materialButton1.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.materialButton1.FlatAppearance.BorderSize = 2;
            this.materialButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.materialButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.materialButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.materialButton1.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.materialButton1.IconColor = System.Drawing.Color.White;
            this.materialButton1.IconSize = 1;
            this.materialButton1.Location = new System.Drawing.Point(618, 401);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(126, 30);
            this.materialButton1.TabIndex = 38;
            this.materialButton1.Text = "Save && Close";
            this.materialButton1.UseVisualStyleBackColor = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(600, 78);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 15);
            this.lblID.TabIndex = 40;
            this.lblID.Text = "0";
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.materialButton2.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.materialButton2.FlatAppearance.BorderSize = 2;
            this.materialButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.materialButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.materialButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.materialButton2.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.materialButton2.IconColor = System.Drawing.Color.White;
            this.materialButton2.IconSize = 1;
            this.materialButton2.Location = new System.Drawing.Point(752, 78);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(126, 30);
            this.materialButton2.TabIndex = 38;
            this.materialButton2.Text = "Add Section";
            this.materialButton2.UseVisualStyleBackColor = false;
            // 
            // materialButton3
            // 
            this.materialButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.materialButton3.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.materialButton3.FlatAppearance.BorderSize = 2;
            this.materialButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.materialButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.materialButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.materialButton3.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.materialButton3.IconColor = System.Drawing.Color.White;
            this.materialButton3.IconSize = 1;
            this.materialButton3.Location = new System.Drawing.Point(886, 79);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(126, 30);
            this.materialButton3.TabIndex = 38;
            this.materialButton3.Text = "Add Boq Item";
            this.materialButton3.UseVisualStyleBackColor = false;
            // 
            // materialButton4
            // 
            this.materialButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.materialButton4.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.materialButton4.FlatAppearance.BorderSize = 2;
            this.materialButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.materialButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.materialButton4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.materialButton4.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.materialButton4.IconColor = System.Drawing.Color.White;
            this.materialButton4.IconSize = 1;
            this.materialButton4.Location = new System.Drawing.Point(931, -244);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.Size = new System.Drawing.Size(126, 30);
            this.materialButton4.TabIndex = 38;
            this.materialButton4.Text = "Save && Close";
            this.materialButton4.UseVisualStyleBackColor = false;
            // 
            // CreateBoQ_Step2_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.mbtNext);
            this.Controls.Add(this.mbtCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpValidDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtTermsCondition);
            this.Controls.Add(this.txtBOQDesc);
            this.Controls.Add(this.txtBOQTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "CreateBoQ_Step2_Frm";
            this.Text = "Create New Bill of Quantity";
            this.Activated += new System.EventHandler(this.CreateBoQ_Step2_Frm_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private FontAwesome.Sharp.Material.MaterialButton mbtAddSite;
		private FontAwesome.Sharp.Material.MaterialButton mbtAddCustomer;
		private System.Windows.Forms.ComboBox cboSite;
		private System.Windows.Forms.ComboBox cboCustomerName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpValidDate;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.TextBox txtBOQDesc;
		private System.Windows.Forms.TextBox txtBOQTitle;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTermsCondition;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn no;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
		private System.Windows.Forms.DataGridViewTextBoxColumn boqdescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn uom;
		private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
		private System.Windows.Forms.DataGridViewTextBoxColumn action;
		private FontAwesome.Sharp.Material.MaterialButton mbtNext;
		private FontAwesome.Sharp.Material.MaterialButton mbtCancel;
		private FontAwesome.Sharp.Material.MaterialButton materialButton1;
        private System.Windows.Forms.Label lblID;
        private FontAwesome.Sharp.Material.MaterialButton materialButton2;
        private FontAwesome.Sharp.Material.MaterialButton materialButton3;
        private FontAwesome.Sharp.Material.MaterialButton materialButton4;
    }
}