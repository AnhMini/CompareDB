namespace CompareDB
{
    partial class frmNewComparision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewComparision));
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.TableLayoutPanel();
            this.grbLeftDB = new System.Windows.Forms.GroupBox();
            this.pnlLeftDB = new System.Windows.Forms.TableLayoutPanel();
            this.lblServerNameLeft = new System.Windows.Forms.Label();
            this.lblAuthenticationLeft = new System.Windows.Forms.Label();
            this.lblLoginLeft = new System.Windows.Forms.Label();
            this.lblPasswordLeft = new System.Windows.Forms.Label();
            this.lblDatabaseNameLeft = new System.Windows.Forms.Label();
            this.cbbServerNameLeft = new System.Windows.Forms.ComboBox();
            this.cbbAuthenticationLeft = new System.Windows.Forms.ComboBox();
            this.cbbDatabaseNameLeft = new System.Windows.Forms.ComboBox();
            this.txtLoginLeft = new System.Windows.Forms.TextBox();
            this.txtPasswordLeft = new System.Windows.Forms.TextBox();
            this.grbRightDB = new System.Windows.Forms.GroupBox();
            this.pnlRightDB = new System.Windows.Forms.TableLayoutPanel();
            this.lblServerNameRight = new System.Windows.Forms.Label();
            this.lblAuthenticationRight = new System.Windows.Forms.Label();
            this.lblLoginRight = new System.Windows.Forms.Label();
            this.lblPasswordRight = new System.Windows.Forms.Label();
            this.lblDatabaseNameRight = new System.Windows.Forms.Label();
            this.cbbServerNameRight = new System.Windows.Forms.ComboBox();
            this.cbbAuthenticationRight = new System.Windows.Forms.ComboBox();
            this.cbbDatabaseNameRight = new System.Windows.Forms.ComboBox();
            this.txtLoginRight = new System.Windows.Forms.TextBox();
            this.txtPasswordRight = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.grbLeftDB.SuspendLayout();
            this.pnlLeftDB.SuspendLayout();
            this.grbRightDB.SuspendLayout();
            this.pnlRightDB.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Controls.Add(this.pnlContent, 0, 1);
            this.pnlMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.pnlMain.Controls.Add(this.pictureBox1, 0, 0);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 4;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.pnlMain.Size = new System.Drawing.Size(782, 318);
            this.pnlMain.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.ColumnCount = 2;
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlContent.Controls.Add(this.grbLeftDB, 0, 0);
            this.pnlContent.Controls.Add(this.grbRightDB, 1, 0);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(3, 103);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.RowCount = 1;
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.pnlContent.Size = new System.Drawing.Size(776, 158);
            this.pnlContent.TabIndex = 10;
            // 
            // grbLeftDB
            // 
            this.grbLeftDB.Controls.Add(this.pnlLeftDB);
            this.grbLeftDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbLeftDB.Location = new System.Drawing.Point(3, 3);
            this.grbLeftDB.Name = "grbLeftDB";
            this.grbLeftDB.Size = new System.Drawing.Size(382, 152);
            this.grbLeftDB.TabIndex = 0;
            this.grbLeftDB.TabStop = false;
            this.grbLeftDB.Text = "Left Database";
            // 
            // pnlLeftDB
            // 
            this.pnlLeftDB.ColumnCount = 2;
            this.pnlLeftDB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.pnlLeftDB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlLeftDB.Controls.Add(this.lblServerNameLeft, 0, 0);
            this.pnlLeftDB.Controls.Add(this.lblAuthenticationLeft, 0, 1);
            this.pnlLeftDB.Controls.Add(this.lblLoginLeft, 0, 2);
            this.pnlLeftDB.Controls.Add(this.lblPasswordLeft, 0, 3);
            this.pnlLeftDB.Controls.Add(this.lblDatabaseNameLeft, 0, 4);
            this.pnlLeftDB.Controls.Add(this.cbbServerNameLeft, 1, 0);
            this.pnlLeftDB.Controls.Add(this.cbbAuthenticationLeft, 1, 1);
            this.pnlLeftDB.Controls.Add(this.cbbDatabaseNameLeft, 1, 4);
            this.pnlLeftDB.Controls.Add(this.txtLoginLeft, 1, 2);
            this.pnlLeftDB.Controls.Add(this.txtPasswordLeft, 1, 3);
            this.pnlLeftDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftDB.Location = new System.Drawing.Point(3, 16);
            this.pnlLeftDB.Name = "pnlLeftDB";
            this.pnlLeftDB.RowCount = 6;
            this.pnlLeftDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlLeftDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlLeftDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlLeftDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlLeftDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlLeftDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlLeftDB.Size = new System.Drawing.Size(376, 133);
            this.pnlLeftDB.TabIndex = 0;
            // 
            // lblServerNameLeft
            // 
            this.lblServerNameLeft.AutoSize = true;
            this.lblServerNameLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServerNameLeft.Location = new System.Drawing.Point(3, 0);
            this.lblServerNameLeft.Name = "lblServerNameLeft";
            this.lblServerNameLeft.Size = new System.Drawing.Size(144, 25);
            this.lblServerNameLeft.TabIndex = 0;
            this.lblServerNameLeft.Text = "Server Name";
            // 
            // lblAuthenticationLeft
            // 
            this.lblAuthenticationLeft.AutoSize = true;
            this.lblAuthenticationLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthenticationLeft.Location = new System.Drawing.Point(3, 25);
            this.lblAuthenticationLeft.Name = "lblAuthenticationLeft";
            this.lblAuthenticationLeft.Size = new System.Drawing.Size(144, 25);
            this.lblAuthenticationLeft.TabIndex = 0;
            this.lblAuthenticationLeft.Text = "Authentication";
            // 
            // lblLoginLeft
            // 
            this.lblLoginLeft.AutoSize = true;
            this.lblLoginLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoginLeft.Location = new System.Drawing.Point(3, 50);
            this.lblLoginLeft.Name = "lblLoginLeft";
            this.lblLoginLeft.Size = new System.Drawing.Size(144, 25);
            this.lblLoginLeft.TabIndex = 0;
            this.lblLoginLeft.Text = "Login";
            // 
            // lblPasswordLeft
            // 
            this.lblPasswordLeft.AutoSize = true;
            this.lblPasswordLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPasswordLeft.Location = new System.Drawing.Point(3, 75);
            this.lblPasswordLeft.Name = "lblPasswordLeft";
            this.lblPasswordLeft.Size = new System.Drawing.Size(144, 25);
            this.lblPasswordLeft.TabIndex = 0;
            this.lblPasswordLeft.Text = "Password";
            // 
            // lblDatabaseNameLeft
            // 
            this.lblDatabaseNameLeft.AutoSize = true;
            this.lblDatabaseNameLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatabaseNameLeft.Location = new System.Drawing.Point(3, 100);
            this.lblDatabaseNameLeft.Name = "lblDatabaseNameLeft";
            this.lblDatabaseNameLeft.Size = new System.Drawing.Size(144, 25);
            this.lblDatabaseNameLeft.TabIndex = 0;
            this.lblDatabaseNameLeft.Text = "Database Name";
            // 
            // cbbServerNameLeft
            // 
            this.cbbServerNameLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbServerNameLeft.FormattingEnabled = true;
            this.cbbServerNameLeft.Location = new System.Drawing.Point(153, 3);
            this.cbbServerNameLeft.Name = "cbbServerNameLeft";
            this.cbbServerNameLeft.Size = new System.Drawing.Size(220, 21);
            this.cbbServerNameLeft.TabIndex = 0;
            // 
            // cbbAuthenticationLeft
            // 
            this.cbbAuthenticationLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbAuthenticationLeft.FormattingEnabled = true;
            this.cbbAuthenticationLeft.Location = new System.Drawing.Point(153, 28);
            this.cbbAuthenticationLeft.Name = "cbbAuthenticationLeft";
            this.cbbAuthenticationLeft.Size = new System.Drawing.Size(220, 21);
            this.cbbAuthenticationLeft.TabIndex = 1;
            this.cbbAuthenticationLeft.TextChanged += new System.EventHandler(this.cbbAuthenticationLeft_TextChanged);
            // 
            // cbbDatabaseNameLeft
            // 
            this.cbbDatabaseNameLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbDatabaseNameLeft.FormattingEnabled = true;
            this.cbbDatabaseNameLeft.Location = new System.Drawing.Point(153, 103);
            this.cbbDatabaseNameLeft.Name = "cbbDatabaseNameLeft";
            this.cbbDatabaseNameLeft.Size = new System.Drawing.Size(220, 21);
            this.cbbDatabaseNameLeft.TabIndex = 4;
            this.cbbDatabaseNameLeft.Click += new System.EventHandler(this.cbbDatabaseNameLeft_Click);
            // 
            // txtLoginLeft
            // 
            this.txtLoginLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLoginLeft.Location = new System.Drawing.Point(153, 53);
            this.txtLoginLeft.Name = "txtLoginLeft";
            this.txtLoginLeft.Size = new System.Drawing.Size(220, 20);
            this.txtLoginLeft.TabIndex = 2;
            // 
            // txtPasswordLeft
            // 
            this.txtPasswordLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPasswordLeft.Location = new System.Drawing.Point(153, 78);
            this.txtPasswordLeft.Name = "txtPasswordLeft";
            this.txtPasswordLeft.PasswordChar = '*';
            this.txtPasswordLeft.Size = new System.Drawing.Size(220, 20);
            this.txtPasswordLeft.TabIndex = 3;
            // 
            // grbRightDB
            // 
            this.grbRightDB.Controls.Add(this.pnlRightDB);
            this.grbRightDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbRightDB.Location = new System.Drawing.Point(391, 3);
            this.grbRightDB.Name = "grbRightDB";
            this.grbRightDB.Size = new System.Drawing.Size(382, 152);
            this.grbRightDB.TabIndex = 1;
            this.grbRightDB.TabStop = false;
            this.grbRightDB.Text = "Right Database";
            // 
            // pnlRightDB
            // 
            this.pnlRightDB.ColumnCount = 2;
            this.pnlRightDB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.pnlRightDB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRightDB.Controls.Add(this.lblServerNameRight, 0, 0);
            this.pnlRightDB.Controls.Add(this.lblAuthenticationRight, 0, 1);
            this.pnlRightDB.Controls.Add(this.lblLoginRight, 0, 2);
            this.pnlRightDB.Controls.Add(this.lblPasswordRight, 0, 3);
            this.pnlRightDB.Controls.Add(this.lblDatabaseNameRight, 0, 4);
            this.pnlRightDB.Controls.Add(this.cbbServerNameRight, 1, 0);
            this.pnlRightDB.Controls.Add(this.cbbAuthenticationRight, 1, 1);
            this.pnlRightDB.Controls.Add(this.cbbDatabaseNameRight, 1, 4);
            this.pnlRightDB.Controls.Add(this.txtLoginRight, 1, 2);
            this.pnlRightDB.Controls.Add(this.txtPasswordRight, 1, 3);
            this.pnlRightDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightDB.Location = new System.Drawing.Point(3, 16);
            this.pnlRightDB.Name = "pnlRightDB";
            this.pnlRightDB.RowCount = 6;
            this.pnlRightDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlRightDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlRightDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlRightDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlRightDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlRightDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlRightDB.Size = new System.Drawing.Size(376, 133);
            this.pnlRightDB.TabIndex = 1;
            // 
            // lblServerNameRight
            // 
            this.lblServerNameRight.AutoSize = true;
            this.lblServerNameRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServerNameRight.Location = new System.Drawing.Point(3, 0);
            this.lblServerNameRight.Name = "lblServerNameRight";
            this.lblServerNameRight.Size = new System.Drawing.Size(144, 25);
            this.lblServerNameRight.TabIndex = 0;
            this.lblServerNameRight.Text = "Server Name";
            // 
            // lblAuthenticationRight
            // 
            this.lblAuthenticationRight.AutoSize = true;
            this.lblAuthenticationRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthenticationRight.Location = new System.Drawing.Point(3, 25);
            this.lblAuthenticationRight.Name = "lblAuthenticationRight";
            this.lblAuthenticationRight.Size = new System.Drawing.Size(144, 25);
            this.lblAuthenticationRight.TabIndex = 0;
            this.lblAuthenticationRight.Text = "Authentication";
            // 
            // lblLoginRight
            // 
            this.lblLoginRight.AutoSize = true;
            this.lblLoginRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoginRight.Location = new System.Drawing.Point(3, 50);
            this.lblLoginRight.Name = "lblLoginRight";
            this.lblLoginRight.Size = new System.Drawing.Size(144, 25);
            this.lblLoginRight.TabIndex = 0;
            this.lblLoginRight.Text = "Login";
            // 
            // lblPasswordRight
            // 
            this.lblPasswordRight.AutoSize = true;
            this.lblPasswordRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPasswordRight.Location = new System.Drawing.Point(3, 75);
            this.lblPasswordRight.Name = "lblPasswordRight";
            this.lblPasswordRight.Size = new System.Drawing.Size(144, 25);
            this.lblPasswordRight.TabIndex = 0;
            this.lblPasswordRight.Text = "Password";
            // 
            // lblDatabaseNameRight
            // 
            this.lblDatabaseNameRight.AutoSize = true;
            this.lblDatabaseNameRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatabaseNameRight.Location = new System.Drawing.Point(3, 100);
            this.lblDatabaseNameRight.Name = "lblDatabaseNameRight";
            this.lblDatabaseNameRight.Size = new System.Drawing.Size(144, 25);
            this.lblDatabaseNameRight.TabIndex = 0;
            this.lblDatabaseNameRight.Text = "Database Name";
            // 
            // cbbServerNameRight
            // 
            this.cbbServerNameRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbServerNameRight.FormattingEnabled = true;
            this.cbbServerNameRight.Location = new System.Drawing.Point(153, 3);
            this.cbbServerNameRight.Name = "cbbServerNameRight";
            this.cbbServerNameRight.Size = new System.Drawing.Size(220, 21);
            this.cbbServerNameRight.TabIndex = 0;
            // 
            // cbbAuthenticationRight
            // 
            this.cbbAuthenticationRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbAuthenticationRight.FormattingEnabled = true;
            this.cbbAuthenticationRight.Location = new System.Drawing.Point(153, 28);
            this.cbbAuthenticationRight.Name = "cbbAuthenticationRight";
            this.cbbAuthenticationRight.Size = new System.Drawing.Size(220, 21);
            this.cbbAuthenticationRight.TabIndex = 1;
            this.cbbAuthenticationRight.TextChanged += new System.EventHandler(this.cbbAuthenticationRight_TextChanged);
            // 
            // cbbDatabaseNameRight
            // 
            this.cbbDatabaseNameRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbDatabaseNameRight.FormattingEnabled = true;
            this.cbbDatabaseNameRight.Location = new System.Drawing.Point(153, 103);
            this.cbbDatabaseNameRight.Name = "cbbDatabaseNameRight";
            this.cbbDatabaseNameRight.Size = new System.Drawing.Size(220, 21);
            this.cbbDatabaseNameRight.TabIndex = 4;
            this.cbbDatabaseNameRight.Click += new System.EventHandler(this.cbbDataBaseNameRight_Click);
            // 
            // txtLoginRight
            // 
            this.txtLoginRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLoginRight.Location = new System.Drawing.Point(153, 53);
            this.txtLoginRight.Name = "txtLoginRight";
            this.txtLoginRight.Size = new System.Drawing.Size(220, 20);
            this.txtLoginRight.TabIndex = 2;
            // 
            // txtPasswordRight
            // 
            this.txtPasswordRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPasswordRight.Location = new System.Drawing.Point(153, 78);
            this.txtPasswordRight.Name = "txtPasswordRight";
            this.txtPasswordRight.PasswordChar = '*';
            this.txtPasswordRight.Size = new System.Drawing.Size(220, 20);
            this.txtPasswordRight.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnCompare, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 267);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 35);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnCompare
            // 
            this.btnCompare.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompare.Location = new System.Drawing.Point(579, 3);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(84, 29);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "&Compare Now";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(669, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 29);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmNewComparision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 318);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.Name = "frmNewComparision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Comparision";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.grbLeftDB.ResumeLayout(false);
            this.pnlLeftDB.ResumeLayout(false);
            this.pnlLeftDB.PerformLayout();
            this.grbRightDB.ResumeLayout(false);
            this.pnlRightDB.ResumeLayout(false);
            this.pnlRightDB.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel pnlContent;
        private System.Windows.Forms.TableLayoutPanel pnlRightDB;
        private System.Windows.Forms.TableLayoutPanel pnlLeftDB;
        private System.Windows.Forms.Label lblServerNameRight;
        private System.Windows.Forms.Label lblAuthenticationRight;
        private System.Windows.Forms.Label lblLoginRight;
        private System.Windows.Forms.Label lblPasswordRight;
        private System.Windows.Forms.Label lblDatabaseNameRight;
        private System.Windows.Forms.ComboBox cbbServerNameRight;
        private System.Windows.Forms.ComboBox cbbAuthenticationRight;
        private System.Windows.Forms.ComboBox cbbDatabaseNameRight;
        private System.Windows.Forms.Label lblServerNameLeft;
        private System.Windows.Forms.Label lblAuthenticationLeft;
        private System.Windows.Forms.Label lblLoginLeft;
        private System.Windows.Forms.Label lblPasswordLeft;
        private System.Windows.Forms.Label lblDatabaseNameLeft;
        private System.Windows.Forms.ComboBox cbbServerNameLeft;
        private System.Windows.Forms.ComboBox cbbAuthenticationLeft;
        private System.Windows.Forms.ComboBox cbbDatabaseNameLeft;
        private System.Windows.Forms.TextBox txtLoginRight;
        private System.Windows.Forms.TextBox txtPasswordRight;
        private System.Windows.Forms.TextBox txtLoginLeft;
        private System.Windows.Forms.TextBox txtPasswordLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbLeftDB;
        private System.Windows.Forms.GroupBox grbRightDB;
    }
}

