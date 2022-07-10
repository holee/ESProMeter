namespace ESProMeter.Views.Servers
{
    partial class FormRegister
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtDBFilePath = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.rbtSQLDB = new System.Windows.Forms.RadioButton();
			this.rbtLDB = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDatabase = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtRegister = new FontAwesome.Sharp.Material.MaterialButton();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.mbtTestCnn = new FontAwesome.Sharp.Material.MaterialButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtDBFilePath);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.btnBrowse);
			this.panel1.Controls.Add(this.rbtSQLDB);
			this.panel1.Controls.Add(this.rbtLDB);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtDatabase);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtUserID);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtServer);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(0, 79);
			this.panel1.Margin = new System.Windows.Forms.Padding(5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(628, 262);
			this.panel1.TabIndex = 1;
			// 
			// txtDBFilePath
			// 
			this.txtDBFilePath.Location = new System.Drawing.Point(134, 45);
			this.txtDBFilePath.Name = "txtDBFilePath";
			this.txtDBFilePath.Size = new System.Drawing.Size(401, 24);
			this.txtDBFilePath.TabIndex = 9;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(407, 107);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(216, 145);
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(131, 74);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(485, 16);
			this.label7.TabIndex = 7;
			this.label7.Text = "Enter your database file path in text box above or browse to select its file loca" +
    "tion.";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(541, 44);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 27);
			this.btnBrowse.TabIndex = 3;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// rbtSQLDB
			// 
			this.rbtSQLDB.AutoSize = true;
			this.rbtSQLDB.Location = new System.Drawing.Point(21, 107);
			this.rbtSQLDB.Name = "rbtSQLDB";
			this.rbtSQLDB.Size = new System.Drawing.Size(266, 22);
			this.rbtSQLDB.TabIndex = 4;
			this.rbtSQLDB.Text = "Your application is using SQL Server";
			this.rbtSQLDB.UseVisualStyleBackColor = true;
			this.rbtSQLDB.CheckedChanged += new System.EventHandler(this.rbtSQLDB_CheckedChanged);
			// 
			// rbtLDB
			// 
			this.rbtLDB.AutoSize = true;
			this.rbtLDB.Checked = true;
			this.rbtLDB.Location = new System.Drawing.Point(21, 16);
			this.rbtLDB.Name = "rbtLDB";
			this.rbtLDB.Size = new System.Drawing.Size(238, 22);
			this.rbtLDB.TabIndex = 1;
			this.rbtLDB.TabStop = true;
			this.rbtLDB.Text = "Your applcation is using localDB";
			this.rbtLDB.UseVisualStyleBackColor = true;
			this.rbtLDB.CheckedChanged += new System.EventHandler(this.rbtLDB_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Enabled = false;
			this.label4.Location = new System.Drawing.Point(32, 234);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 18);
			this.label4.TabIndex = 0;
			this.label4.Text = "Password";
			// 
			// txtPassword
			// 
			this.txtPassword.Enabled = false;
			this.txtPassword.Location = new System.Drawing.Point(134, 228);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(242, 24);
			this.txtPassword.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Enabled = false;
			this.label3.Location = new System.Drawing.Point(32, 204);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "User Name";
			// 
			// txtDatabase
			// 
			this.txtDatabase.Enabled = false;
			this.txtDatabase.Location = new System.Drawing.Point(134, 168);
			this.txtDatabase.Margin = new System.Windows.Forms.Padding(4);
			this.txtDatabase.Name = "txtDatabase";
			this.txtDatabase.Size = new System.Drawing.Size(242, 24);
			this.txtDatabase.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Enabled = false;
			this.label2.Location = new System.Drawing.Point(32, 174);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Database";
			// 
			// txtUserID
			// 
			this.txtUserID.Enabled = false;
			this.txtUserID.Location = new System.Drawing.Point(134, 198);
			this.txtUserID.Margin = new System.Windows.Forms.Padding(4);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Size = new System.Drawing.Size(242, 24);
			this.txtUserID.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(32, 45);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 18);
			this.label6.TabIndex = 0;
			this.label6.Text = "DB File Path";
			// 
			// txtServer
			// 
			this.txtServer.Enabled = false;
			this.txtServer.Location = new System.Drawing.Point(134, 137);
			this.txtServer.Margin = new System.Windows.Forms.Padding(4);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(242, 24);
			this.txtServer.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Enabled = false;
			this.label1.Location = new System.Drawing.Point(32, 143);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server Name";
			// 
			// mbtCancel
			// 
			this.mbtCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mbtCancel.ForeColor = System.Drawing.Color.White;
			this.mbtCancel.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
			this.mbtCancel.IconColor = System.Drawing.Color.White;
			this.mbtCancel.IconSize = 32;
			this.mbtCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mbtCancel.Location = new System.Drawing.Point(521, 346);
			this.mbtCancel.Margin = new System.Windows.Forms.Padding(4);
			this.mbtCancel.Name = "mbtCancel";
			this.mbtCancel.Size = new System.Drawing.Size(106, 36);
			this.mbtCancel.TabIndex = 11;
			this.mbtCancel.Text = "Close";
			this.mbtCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.mbtCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mbtCancel.UseVisualStyleBackColor = false;
			this.mbtCancel.Click += new System.EventHandler(this.mbtCancel_Click);
			// 
			// mbtRegister
			// 
			this.mbtRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
			this.mbtRegister.ForeColor = System.Drawing.Color.White;
			this.mbtRegister.IconChar = FontAwesome.Sharp.MaterialIcons.TabPlus;
			this.mbtRegister.IconColor = System.Drawing.Color.White;
			this.mbtRegister.IconSize = 32;
			this.mbtRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mbtRegister.Location = new System.Drawing.Point(232, 346);
			this.mbtRegister.Margin = new System.Windows.Forms.Padding(4);
			this.mbtRegister.Name = "mbtRegister";
			this.mbtRegister.Size = new System.Drawing.Size(113, 36);
			this.mbtRegister.TabIndex = 9;
			this.mbtRegister.Text = "Register";
			this.mbtRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.mbtRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mbtRegister.UseVisualStyleBackColor = false;
			this.mbtRegister.Click += new System.EventHandler(this.mbtRegister_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(26, 30);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(393, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Enter the database server information to connect to the database.";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(628, 73);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Connection to Database Server";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(544, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(72, 50);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(628, 73);
			this.panel2.TabIndex = 2;
			// 
			// mbtTestCnn
			// 
			this.mbtTestCnn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mbtTestCnn.ForeColor = System.Drawing.Color.White;
			this.mbtTestCnn.IconChar = FontAwesome.Sharp.MaterialIcons.MarkerCheck;
			this.mbtTestCnn.IconColor = System.Drawing.Color.White;
			this.mbtTestCnn.IconSize = 32;
			this.mbtTestCnn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mbtTestCnn.Location = new System.Drawing.Point(353, 346);
			this.mbtTestCnn.Margin = new System.Windows.Forms.Padding(4);
			this.mbtTestCnn.Name = "mbtTestCnn";
			this.mbtTestCnn.Size = new System.Drawing.Size(160, 36);
			this.mbtTestCnn.TabIndex = 10;
			this.mbtTestCnn.Text = "Test Connection";
			this.mbtTestCnn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.mbtTestCnn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mbtTestCnn.UseVisualStyleBackColor = false;
			this.mbtTestCnn.Click += new System.EventHandler(this.mbtTestCnn_Click);
			// 
			// FormRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.ClientSize = new System.Drawing.Size(628, 386);
			this.Controls.Add(this.mbtTestCnn);
			this.Controls.Add(this.mbtCancel);
			this.Controls.Add(this.mbtRegister);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRegister";
			this.Text = "Database Connection";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegister_FormClosing);
			this.Load += new System.EventHandler(this.FormRegister_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.Material.MaterialButton mbtRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RadioButton rbtSQLDB;
        private System.Windows.Forms.RadioButton rbtLDB;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.Material.MaterialButton mbtTestCnn;
        private System.Windows.Forms.PictureBox pictureBox2;
        public FontAwesome.Sharp.Material.MaterialButton mbtCancel;
        private System.Windows.Forms.TextBox txtDBFilePath;
    }
}