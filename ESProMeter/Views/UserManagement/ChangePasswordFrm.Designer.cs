
namespace ESProMeter.Views.UserManagement
{
	partial class ChangePasswordFrm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.mbtSave = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(411, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter your old password and new password and click Save. Make sure, password are " +
    "case sensitive with at lease three characters. ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Enter your old password:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "Enter your new password:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 15);
			this.label5.TabIndex = 0;
			this.label5.Text = "Reconfirm password:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 79);
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = '*';
			this.textBox1.PlaceholderText = "Enter your old password";
			this.textBox1.Size = new System.Drawing.Size(411, 23);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 134);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.PlaceholderText = "Your new password";
			this.textBox2.Size = new System.Drawing.Size(411, 23);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(12, 187);
			this.textBox3.Name = "textBox3";
			this.textBox3.PasswordChar = '*';
			this.textBox3.PlaceholderText = "Confirm";
			this.textBox3.Size = new System.Drawing.Size(411, 23);
			this.textBox3.TabIndex = 1;
			// 
			// mbtSave
			// 
			this.mbtSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.mbtSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtSave.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
			this.mbtSave.FlatAppearance.BorderSize = 2;
			this.mbtSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
			this.mbtSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtSave.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.mbtSave.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtSave.IconColor = System.Drawing.Color.White;
			this.mbtSave.IconSize = 1;
			this.mbtSave.Location = new System.Drawing.Point(163, 220);
			this.mbtSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtSave.Name = "mbtSave";
			this.mbtSave.Size = new System.Drawing.Size(126, 30);
			this.mbtSave.TabIndex = 26;
			this.mbtSave.Text = "Save";
			this.mbtSave.UseVisualStyleBackColor = false;
			this.mbtSave.Click += new System.EventHandler(this.mbtSave_Click);
			// 
			// mbtCancel
			// 
			this.mbtCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mbtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtCancel.ForeColor = System.Drawing.Color.White;
			this.mbtCancel.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtCancel.IconColor = System.Drawing.Color.White;
			this.mbtCancel.IconSize = 1;
			this.mbtCancel.Location = new System.Drawing.Point(297, 220);
			this.mbtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtCancel.Name = "mbtCancel";
			this.mbtCancel.Size = new System.Drawing.Size(126, 30);
			this.mbtCancel.TabIndex = 27;
			this.mbtCancel.Text = "Cancel";
			this.mbtCancel.UseVisualStyleBackColor = false;
			// 
			// ChangePasswordFrm
			// 
			this.AcceptButton = this.mbtSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mbtCancel;
			this.ClientSize = new System.Drawing.Size(430, 251);
			this.Controls.Add(this.mbtSave);
			this.Controls.Add(this.mbtCancel);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ChangePasswordFrm";
			this.Text = "Change your password";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private FontAwesome.Sharp.Material.MaterialButton mbtSave;
		private FontAwesome.Sharp.Material.MaterialButton mbtCancel;
	}
}