namespace ESProMeter.Views.Boq
{
    partial class SectionFrm
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
            this.txtBoqSection = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mbtNext = new FontAwesome.Sharp.Material.MaterialButton();
            this.materialButton1 = new FontAwesome.Sharp.Material.MaterialButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoqSection
            // 
            this.txtBoqSection.Location = new System.Drawing.Point(12, 78);
            this.txtBoqSection.Multiline = true;
            this.txtBoqSection.Name = "txtBoqSection";
            this.txtBoqSection.Size = new System.Drawing.Size(443, 65);
            this.txtBoqSection.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Section Name";
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
            this.mbtNext.IconChar = FontAwesome.Sharp.MaterialIcons.PlusCircle;
            this.mbtNext.IconColor = System.Drawing.Color.White;
            this.mbtNext.IconSize = 20;
            this.mbtNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mbtNext.Location = new System.Drawing.Point(290, 149);
            this.mbtNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtNext.Name = "mbtNext";
            this.mbtNext.Size = new System.Drawing.Size(72, 30);
            this.mbtNext.TabIndex = 39;
            this.mbtNext.Text = "Add";
            this.mbtNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mbtNext.UseVisualStyleBackColor = false;
            this.mbtNext.Click += new System.EventHandler(this.mbtNext_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButton1.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.materialButton1.FlatAppearance.BorderSize = 2;
            this.materialButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.materialButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.materialButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.materialButton1.IconChar = FontAwesome.Sharp.MaterialIcons.ArrowLeftCircle;
            this.materialButton1.IconColor = System.Drawing.Color.Cyan;
            this.materialButton1.IconSize = 20;
            this.materialButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton1.Location = new System.Drawing.Point(375, 149);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(77, 30);
            this.materialButton1.TabIndex = 39;
            this.materialButton1.Text = "Cancel";
            this.materialButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(443, 23);
            this.txtName.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "Name";
            // 
            // SectionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 180);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.mbtNext);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoqSection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SectionFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SectionFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoqSection;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.Material.MaterialButton mbtNext;
        private FontAwesome.Sharp.Material.MaterialButton materialButton1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}