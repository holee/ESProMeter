namespace ESProMeter.Views.Item
{
    partial class ItemExportFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemExportFrm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOpen = new FontAwesome.Sharp.Material.MaterialButton();
            this.materialButton2 = new FontAwesome.Sharp.Material.MaterialButton();
            this.materialButton3 = new FontAwesome.Sharp.Material.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(383, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.IconChar = FontAwesome.Sharp.MaterialIcons.DotsHorizontal;
            this.btnOpen.IconColor = System.Drawing.Color.Black;
            this.btnOpen.IconSize = 22;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(420, 39);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(34, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.materialButton2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.materialButton2.IconChar = FontAwesome.Sharp.MaterialIcons.Openid;
            this.materialButton2.IconColor = System.Drawing.Color.Black;
            this.materialButton2.IconSize = 22;
            this.materialButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton2.Location = new System.Drawing.Point(256, 82);
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(76, 26);
            this.materialButton2.TabIndex = 1;
            this.materialButton2.Text = "Ok";
            this.materialButton2.UseVisualStyleBackColor = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.IconChar = FontAwesome.Sharp.MaterialIcons.Openid;
            this.materialButton3.IconColor = System.Drawing.Color.Black;
            this.materialButton3.IconSize = 22;
            this.materialButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton3.Location = new System.Drawing.Point(338, 82);
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(76, 23);
            this.materialButton3.TabIndex = 1;
            this.materialButton3.Text = "Cancel";
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // ItemExportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 120);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.textBox1);
            this.Name = "ItemExportFrm";
            this.Text = "ItemExportFrm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.Material.MaterialButton btnOpen;
        private FontAwesome.Sharp.Material.MaterialButton materialButton2;
        private FontAwesome.Sharp.Material.MaterialButton materialButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}