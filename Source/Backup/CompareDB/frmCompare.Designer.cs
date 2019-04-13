namespace CompareDB
{
    partial class frmCompareDB
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
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.splMain = new System.Windows.Forms.SplitContainer();
            this.splUp = new System.Windows.Forms.SplitContainer();
            this.grbSame = new System.Windows.Forms.GroupBox();
            this.grdSame = new System.Windows.Forms.DataGridView();
            this.grbDifferent = new System.Windows.Forms.GroupBox();
            this.pnlDifferent = new System.Windows.Forms.TableLayoutPanel();
            this.grdDatabaseLeft = new System.Windows.Forms.DataGridView();
            this.grdDatabaseRight = new System.Windows.Forms.DataGridView();
            this.btnCopyLeft = new System.Windows.Forms.Button();
            this.btnCopyRight = new System.Windows.Forms.Button();
            this.splDown = new System.Windows.Forms.SplitContainer();
            this.pnlScripts = new System.Windows.Forms.TableLayoutPanel();
            this.grbScriptLeft = new System.Windows.Forms.GroupBox();
            this.pnlScriptLeft = new System.Windows.Forms.TableLayoutPanel();
            this.txtScriptDBLeft = new System.Windows.Forms.TextBox();
            this.btnCopyScriptLeft = new System.Windows.Forms.Button();
            this.grbScriptRight = new System.Windows.Forms.GroupBox();
            this.pnlScriptRight = new System.Windows.Forms.TableLayoutPanel();
            this.txtScriptDBRight = new System.Windows.Forms.TextBox();
            this.btnCopyScriptRight = new System.Windows.Forms.Button();
            this.pnlProperties = new System.Windows.Forms.TableLayoutPanel();
            this.grbPropertiesLeft = new System.Windows.Forms.GroupBox();
            this.pnlPropertiesLeft = new System.Windows.Forms.TableLayoutPanel();
            this.grbPropertiesRight = new System.Windows.Forms.GroupBox();
            this.pnlPropertiesRight = new System.Windows.Forms.TableLayoutPanel();
            this.grdLeftProperties = new System.Windows.Forms.DataGridView();
            this.grdRightProperties = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckDBLeft = new System.Windows.Forms.Button();
            this.btnCheckDBRight = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.splMain.Panel1.SuspendLayout();
            this.splMain.Panel2.SuspendLayout();
            this.splMain.SuspendLayout();
            this.splUp.Panel1.SuspendLayout();
            this.splUp.Panel2.SuspendLayout();
            this.splUp.SuspendLayout();
            this.grbSame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSame)).BeginInit();
            this.grbDifferent.SuspendLayout();
            this.pnlDifferent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatabaseLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatabaseRight)).BeginInit();
            this.splDown.Panel1.SuspendLayout();
            this.splDown.Panel2.SuspendLayout();
            this.splDown.SuspendLayout();
            this.pnlScripts.SuspendLayout();
            this.grbScriptLeft.SuspendLayout();
            this.pnlScriptLeft.SuspendLayout();
            this.grbScriptRight.SuspendLayout();
            this.pnlScriptRight.SuspendLayout();
            this.pnlProperties.SuspendLayout();
            this.grbPropertiesLeft.SuspendLayout();
            this.pnlPropertiesLeft.SuspendLayout();
            this.grbPropertiesRight.SuspendLayout();
            this.pnlPropertiesRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLeftProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRightProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Controls.Add(this.splMain, 0, 0);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 1;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Size = new System.Drawing.Size(895, 520);
            this.pnlMain.TabIndex = 2;
            // 
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.Location = new System.Drawing.Point(3, 3);
            this.splMain.Name = "splMain";
            this.splMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splMain.Panel1
            // 
            this.splMain.Panel1.Controls.Add(this.splUp);
            // 
            // splMain.Panel2
            // 
            this.splMain.Panel2.Controls.Add(this.splDown);
            this.splMain.Size = new System.Drawing.Size(889, 514);
            this.splMain.SplitterDistance = 292;
            this.splMain.TabIndex = 0;
            // 
            // splUp
            // 
            this.splUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splUp.Location = new System.Drawing.Point(0, 0);
            this.splUp.Name = "splUp";
            // 
            // splUp.Panel1
            // 
            this.splUp.Panel1.Controls.Add(this.grbSame);
            // 
            // splUp.Panel2
            // 
            this.splUp.Panel2.Controls.Add(this.grbDifferent);
            this.splUp.Size = new System.Drawing.Size(889, 292);
            this.splUp.SplitterDistance = 462;
            this.splUp.TabIndex = 0;
            // 
            // grbSame
            // 
            this.grbSame.Controls.Add(this.grdSame);
            this.grbSame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbSame.Location = new System.Drawing.Point(0, 0);
            this.grbSame.Name = "grbSame";
            this.grbSame.Size = new System.Drawing.Size(462, 292);
            this.grbSame.TabIndex = 0;
            this.grbSame.TabStop = false;
            this.grbSame.Text = "Same";
            // 
            // grdSame
            // 
            this.grdSame.AllowUserToAddRows = false;
            this.grdSame.AllowUserToDeleteRows = false;
            this.grdSame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.grdSame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSame.Location = new System.Drawing.Point(3, 16);
            this.grdSame.Name = "grdSame";
            this.grdSame.Size = new System.Drawing.Size(456, 273);
            this.grdSame.TabIndex = 0;
            this.grdSame.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdSame_ColumnHeaderMouseClick);
            this.grdSame.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSame_CellClick);
            this.grdSame.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdSame_DataBindingComplete);
            this.grdSame.Click += new System.EventHandler(this.grdSame_Click);
            // 
            // grbDifferent
            // 
            this.grbDifferent.Controls.Add(this.pnlDifferent);
            this.grbDifferent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDifferent.Location = new System.Drawing.Point(0, 0);
            this.grbDifferent.Name = "grbDifferent";
            this.grbDifferent.Size = new System.Drawing.Size(423, 292);
            this.grbDifferent.TabIndex = 0;
            this.grbDifferent.TabStop = false;
            this.grbDifferent.Text = "Different";
            // 
            // pnlDifferent
            // 
            this.pnlDifferent.ColumnCount = 2;
            this.pnlDifferent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlDifferent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlDifferent.Controls.Add(this.grdDatabaseLeft, 0, 0);
            this.pnlDifferent.Controls.Add(this.grdDatabaseRight, 1, 0);
            this.pnlDifferent.Controls.Add(this.btnCopyLeft, 0, 1);
            this.pnlDifferent.Controls.Add(this.btnCopyRight, 1, 1);
            this.pnlDifferent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDifferent.Location = new System.Drawing.Point(3, 16);
            this.pnlDifferent.Name = "pnlDifferent";
            this.pnlDifferent.RowCount = 3;
            this.pnlDifferent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlDifferent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlDifferent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlDifferent.Size = new System.Drawing.Size(417, 273);
            this.pnlDifferent.TabIndex = 0;
            // 
            // grdDatabaseLeft
            // 
            this.grdDatabaseLeft.AllowUserToAddRows = false;
            this.grdDatabaseLeft.AllowUserToDeleteRows = false;
            this.grdDatabaseLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatabaseLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5});
            this.grdDatabaseLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatabaseLeft.Location = new System.Drawing.Point(3, 3);
            this.grdDatabaseLeft.Name = "grdDatabaseLeft";
            this.grdDatabaseLeft.Size = new System.Drawing.Size(202, 232);
            this.grdDatabaseLeft.TabIndex = 0;
            this.grdDatabaseLeft.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatabaseLeft_CellDoubleClick);
            this.grdDatabaseLeft.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdDatabaseLeft_CellFormatting);
            this.grdDatabaseLeft.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatabaseLeft_CellClick);
            this.grdDatabaseLeft.Click += new System.EventHandler(this.grdDatabaseLeft_Click);
            // 
            // grdDatabaseRight
            // 
            this.grdDatabaseRight.AllowUserToAddRows = false;
            this.grdDatabaseRight.AllowUserToDeleteRows = false;
            this.grdDatabaseRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatabaseRight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6});
            this.grdDatabaseRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatabaseRight.Location = new System.Drawing.Point(211, 3);
            this.grdDatabaseRight.Name = "grdDatabaseRight";
            this.grdDatabaseRight.Size = new System.Drawing.Size(203, 232);
            this.grdDatabaseRight.TabIndex = 1;
            this.grdDatabaseRight.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatabaseRight_CellDoubleClick);
            this.grdDatabaseRight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatabaseRight_CellClick);
            this.grdDatabaseRight.Click += new System.EventHandler(this.grdDatabaseRight_Click);
            // 
            // btnCopyLeft
            // 
            this.btnCopyLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCopyLeft.Location = new System.Drawing.Point(79, 241);
            this.btnCopyLeft.Name = "btnCopyLeft";
            this.btnCopyLeft.Size = new System.Drawing.Size(126, 24);
            this.btnCopyLeft.TabIndex = 2;
            this.btnCopyLeft.Text = "Left >> Right";
            this.btnCopyLeft.UseVisualStyleBackColor = true;
            this.btnCopyLeft.Click += new System.EventHandler(this.btnCopyLeft_Click);
            // 
            // btnCopyRight
            // 
            this.btnCopyRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCopyRight.Location = new System.Drawing.Point(296, 241);
            this.btnCopyRight.Name = "btnCopyRight";
            this.btnCopyRight.Size = new System.Drawing.Size(118, 24);
            this.btnCopyRight.TabIndex = 3;
            this.btnCopyRight.Text = "Right >> Left";
            this.btnCopyRight.UseVisualStyleBackColor = true;
            this.btnCopyRight.Click += new System.EventHandler(this.btnCopyRight_Click);
            // 
            // splDown
            // 
            this.splDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splDown.Location = new System.Drawing.Point(0, 0);
            this.splDown.Name = "splDown";
            // 
            // splDown.Panel1
            // 
            this.splDown.Panel1.Controls.Add(this.pnlScripts);
            // 
            // splDown.Panel2
            // 
            this.splDown.Panel2.Controls.Add(this.pnlProperties);
            this.splDown.Size = new System.Drawing.Size(889, 218);
            this.splDown.SplitterDistance = 462;
            this.splDown.TabIndex = 0;
            // 
            // pnlScripts
            // 
            this.pnlScripts.ColumnCount = 2;
            this.pnlScripts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlScripts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlScripts.Controls.Add(this.grbScriptLeft, 0, 0);
            this.pnlScripts.Controls.Add(this.grbScriptRight, 1, 0);
            this.pnlScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScripts.Location = new System.Drawing.Point(0, 0);
            this.pnlScripts.Name = "pnlScripts";
            this.pnlScripts.RowCount = 1;
            this.pnlScripts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlScripts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.pnlScripts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.pnlScripts.Size = new System.Drawing.Size(462, 218);
            this.pnlScripts.TabIndex = 0;
            // 
            // grbScriptLeft
            // 
            this.grbScriptLeft.Controls.Add(this.pnlScriptLeft);
            this.grbScriptLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbScriptLeft.Location = new System.Drawing.Point(3, 3);
            this.grbScriptLeft.Name = "grbScriptLeft";
            this.grbScriptLeft.Size = new System.Drawing.Size(225, 212);
            this.grbScriptLeft.TabIndex = 0;
            this.grbScriptLeft.TabStop = false;
            this.grbScriptLeft.Text = "Scripts DB Left";
            // 
            // pnlScriptLeft
            // 
            this.pnlScriptLeft.ColumnCount = 1;
            this.pnlScriptLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlScriptLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlScriptLeft.Controls.Add(this.txtScriptDBLeft, 0, 0);
            this.pnlScriptLeft.Controls.Add(this.btnCopyScriptLeft, 0, 1);
            this.pnlScriptLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScriptLeft.Location = new System.Drawing.Point(3, 16);
            this.pnlScriptLeft.Name = "pnlScriptLeft";
            this.pnlScriptLeft.RowCount = 3;
            this.pnlScriptLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlScriptLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlScriptLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlScriptLeft.Size = new System.Drawing.Size(219, 193);
            this.pnlScriptLeft.TabIndex = 0;
            // 
            // txtScriptDBLeft
            // 
            this.txtScriptDBLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScriptDBLeft.Location = new System.Drawing.Point(3, 3);
            this.txtScriptDBLeft.Multiline = true;
            this.txtScriptDBLeft.Name = "txtScriptDBLeft";
            this.txtScriptDBLeft.ReadOnly = true;
            this.txtScriptDBLeft.Size = new System.Drawing.Size(213, 152);
            this.txtScriptDBLeft.TabIndex = 0;
            // 
            // btnCopyScriptLeft
            // 
            this.btnCopyScriptLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCopyScriptLeft.Location = new System.Drawing.Point(141, 161);
            this.btnCopyScriptLeft.Name = "btnCopyScriptLeft";
            this.btnCopyScriptLeft.Size = new System.Drawing.Size(75, 24);
            this.btnCopyScriptLeft.TabIndex = 1;
            this.btnCopyScriptLeft.Text = "Copy";
            this.btnCopyScriptLeft.UseVisualStyleBackColor = true;
            this.btnCopyScriptLeft.Click += new System.EventHandler(this.btnCopyScriptLeft_Click);
            // 
            // grbScriptRight
            // 
            this.grbScriptRight.Controls.Add(this.pnlScriptRight);
            this.grbScriptRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbScriptRight.Location = new System.Drawing.Point(234, 3);
            this.grbScriptRight.Name = "grbScriptRight";
            this.grbScriptRight.Size = new System.Drawing.Size(225, 212);
            this.grbScriptRight.TabIndex = 0;
            this.grbScriptRight.TabStop = false;
            this.grbScriptRight.Text = "Scripts DB Right";
            // 
            // pnlScriptRight
            // 
            this.pnlScriptRight.ColumnCount = 1;
            this.pnlScriptRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlScriptRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlScriptRight.Controls.Add(this.txtScriptDBRight, 0, 0);
            this.pnlScriptRight.Controls.Add(this.btnCopyScriptRight, 0, 1);
            this.pnlScriptRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScriptRight.Location = new System.Drawing.Point(3, 16);
            this.pnlScriptRight.Name = "pnlScriptRight";
            this.pnlScriptRight.RowCount = 3;
            this.pnlScriptRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlScriptRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlScriptRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlScriptRight.Size = new System.Drawing.Size(219, 193);
            this.pnlScriptRight.TabIndex = 0;
            // 
            // txtScriptDBRight
            // 
            this.txtScriptDBRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScriptDBRight.Location = new System.Drawing.Point(3, 3);
            this.txtScriptDBRight.Multiline = true;
            this.txtScriptDBRight.Name = "txtScriptDBRight";
            this.txtScriptDBRight.ReadOnly = true;
            this.txtScriptDBRight.Size = new System.Drawing.Size(213, 152);
            this.txtScriptDBRight.TabIndex = 0;
            // 
            // btnCopyScriptRight
            // 
            this.btnCopyScriptRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCopyScriptRight.Location = new System.Drawing.Point(141, 161);
            this.btnCopyScriptRight.Name = "btnCopyScriptRight";
            this.btnCopyScriptRight.Size = new System.Drawing.Size(75, 24);
            this.btnCopyScriptRight.TabIndex = 1;
            this.btnCopyScriptRight.Text = "Copy";
            this.btnCopyScriptRight.UseVisualStyleBackColor = true;
            this.btnCopyScriptRight.Click += new System.EventHandler(this.btnCopyScriptRight_Click);
            // 
            // pnlProperties
            // 
            this.pnlProperties.ColumnCount = 2;
            this.pnlProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlProperties.Controls.Add(this.grbPropertiesLeft, 0, 0);
            this.pnlProperties.Controls.Add(this.grbPropertiesRight, 1, 0);
            this.pnlProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProperties.Location = new System.Drawing.Point(0, 0);
            this.pnlProperties.Name = "pnlProperties";
            this.pnlProperties.RowCount = 1;
            this.pnlProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.pnlProperties.Size = new System.Drawing.Size(423, 218);
            this.pnlProperties.TabIndex = 0;
            // 
            // grbPropertiesLeft
            // 
            this.grbPropertiesLeft.Controls.Add(this.pnlPropertiesLeft);
            this.grbPropertiesLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbPropertiesLeft.Location = new System.Drawing.Point(3, 3);
            this.grbPropertiesLeft.Name = "grbPropertiesLeft";
            this.grbPropertiesLeft.Size = new System.Drawing.Size(205, 212);
            this.grbPropertiesLeft.TabIndex = 0;
            this.grbPropertiesLeft.TabStop = false;
            this.grbPropertiesLeft.Text = "DB Left Properties";
            // 
            // pnlPropertiesLeft
            // 
            this.pnlPropertiesLeft.ColumnCount = 1;
            this.pnlPropertiesLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlPropertiesLeft.Controls.Add(this.grdLeftProperties, 0, 0);
            this.pnlPropertiesLeft.Controls.Add(this.btnCheckDBLeft, 0, 1);
            this.pnlPropertiesLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPropertiesLeft.Location = new System.Drawing.Point(3, 16);
            this.pnlPropertiesLeft.Name = "pnlPropertiesLeft";
            this.pnlPropertiesLeft.RowCount = 2;
            this.pnlPropertiesLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlPropertiesLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlPropertiesLeft.Size = new System.Drawing.Size(199, 193);
            this.pnlPropertiesLeft.TabIndex = 0;
            // 
            // grbPropertiesRight
            // 
            this.grbPropertiesRight.Controls.Add(this.pnlPropertiesRight);
            this.grbPropertiesRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbPropertiesRight.Location = new System.Drawing.Point(214, 3);
            this.grbPropertiesRight.Name = "grbPropertiesRight";
            this.grbPropertiesRight.Size = new System.Drawing.Size(206, 212);
            this.grbPropertiesRight.TabIndex = 0;
            this.grbPropertiesRight.TabStop = false;
            this.grbPropertiesRight.Text = "DB Right Properties";
            // 
            // pnlPropertiesRight
            // 
            this.pnlPropertiesRight.ColumnCount = 1;
            this.pnlPropertiesRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlPropertiesRight.Controls.Add(this.grdRightProperties, 0, 0);
            this.pnlPropertiesRight.Controls.Add(this.btnCheckDBRight, 0, 1);
            this.pnlPropertiesRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPropertiesRight.Location = new System.Drawing.Point(3, 16);
            this.pnlPropertiesRight.Name = "pnlPropertiesRight";
            this.pnlPropertiesRight.RowCount = 2;
            this.pnlPropertiesRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlPropertiesRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlPropertiesRight.Size = new System.Drawing.Size(200, 193);
            this.pnlPropertiesRight.TabIndex = 0;
            // 
            // grdLeftProperties
            // 
            this.grdLeftProperties.AllowUserToAddRows = false;
            this.grdLeftProperties.AllowUserToDeleteRows = false;
            this.grdLeftProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLeftProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLeftProperties.Location = new System.Drawing.Point(3, 3);
            this.grdLeftProperties.Name = "grdLeftProperties";
            this.grdLeftProperties.Size = new System.Drawing.Size(193, 157);
            this.grdLeftProperties.TabIndex = 0;
            this.grdLeftProperties.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdLeftProperties_ColumnHeaderMouseClick);
            this.grdLeftProperties.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdLeftProperties_DataBindingComplete);
            // 
            // grdRightProperties
            // 
            this.grdRightProperties.AllowUserToAddRows = false;
            this.grdRightProperties.AllowUserToDeleteRows = false;
            this.grdRightProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRightProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRightProperties.Location = new System.Drawing.Point(3, 3);
            this.grdRightProperties.Name = "grdRightProperties";
            this.grdRightProperties.Size = new System.Drawing.Size(194, 157);
            this.grdRightProperties.TabIndex = 0;
            this.grdRightProperties.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdRightProperties_DataBindingComplete);
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "DataBase 1 Table";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "DataBase 2 Table";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Same Table";
            this.Column4.Name = "Column4";
            // 
            // btnCheckDBLeft
            // 
            this.btnCheckDBLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCheckDBLeft.Location = new System.Drawing.Point(76, 166);
            this.btnCheckDBLeft.Name = "btnCheckDBLeft";
            this.btnCheckDBLeft.Size = new System.Drawing.Size(120, 24);
            this.btnCheckDBLeft.TabIndex = 1;
            this.btnCheckDBLeft.Text = "Check DB Left";
            this.btnCheckDBLeft.UseVisualStyleBackColor = true;
            this.btnCheckDBLeft.Click += new System.EventHandler(this.btnCheckDBLeft_Click);
            // 
            // btnCheckDBRight
            // 
            this.btnCheckDBRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCheckDBRight.Location = new System.Drawing.Point(82, 166);
            this.btnCheckDBRight.Name = "btnCheckDBRight";
            this.btnCheckDBRight.Size = new System.Drawing.Size(115, 24);
            this.btnCheckDBRight.TabIndex = 1;
            this.btnCheckDBRight.Text = "Check DB Right";
            this.btnCheckDBRight.UseVisualStyleBackColor = true;
            this.btnCheckDBRight.Click += new System.EventHandler(this.btnCheckDBRight_Click);
            // 
            // frmCompareDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 520);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmCompareDB";
            this.Text = "Compare DB";
            this.Load += new System.EventHandler(this.frmCompareDB_Load);
            this.pnlMain.ResumeLayout(false);
            this.splMain.Panel1.ResumeLayout(false);
            this.splMain.Panel2.ResumeLayout(false);
            this.splMain.ResumeLayout(false);
            this.splUp.Panel1.ResumeLayout(false);
            this.splUp.Panel2.ResumeLayout(false);
            this.splUp.ResumeLayout(false);
            this.grbSame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSame)).EndInit();
            this.grbDifferent.ResumeLayout(false);
            this.pnlDifferent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatabaseLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatabaseRight)).EndInit();
            this.splDown.Panel1.ResumeLayout(false);
            this.splDown.Panel2.ResumeLayout(false);
            this.splDown.ResumeLayout(false);
            this.pnlScripts.ResumeLayout(false);
            this.grbScriptLeft.ResumeLayout(false);
            this.pnlScriptLeft.ResumeLayout(false);
            this.pnlScriptLeft.PerformLayout();
            this.grbScriptRight.ResumeLayout(false);
            this.pnlScriptRight.ResumeLayout(false);
            this.pnlScriptRight.PerformLayout();
            this.pnlProperties.ResumeLayout(false);
            this.grbPropertiesLeft.ResumeLayout(false);
            this.pnlPropertiesLeft.ResumeLayout(false);
            this.grbPropertiesRight.ResumeLayout(false);
            this.pnlPropertiesRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLeftProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRightProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.SplitContainer splMain;
        private System.Windows.Forms.SplitContainer splUp;
        private System.Windows.Forms.GroupBox grbSame;
        private System.Windows.Forms.DataGridView grdSame;
        private System.Windows.Forms.GroupBox grbDifferent;
        private System.Windows.Forms.TableLayoutPanel pnlDifferent;
        private System.Windows.Forms.DataGridView grdDatabaseLeft;
        private System.Windows.Forms.DataGridView grdDatabaseRight;
        private System.Windows.Forms.Button btnCopyLeft;
        private System.Windows.Forms.Button btnCopyRight;
        private System.Windows.Forms.SplitContainer splDown;
        private System.Windows.Forms.TableLayoutPanel pnlScripts;
        private System.Windows.Forms.TableLayoutPanel pnlProperties;
        private System.Windows.Forms.GroupBox grbScriptLeft;
        private System.Windows.Forms.TableLayoutPanel pnlScriptLeft;
        private System.Windows.Forms.GroupBox grbScriptRight;
        private System.Windows.Forms.TableLayoutPanel pnlScriptRight;
        private System.Windows.Forms.GroupBox grbPropertiesLeft;
        private System.Windows.Forms.GroupBox grbPropertiesRight;
        private System.Windows.Forms.TextBox txtScriptDBLeft;
        private System.Windows.Forms.Button btnCopyScriptLeft;
        private System.Windows.Forms.TextBox txtScriptDBRight;
        private System.Windows.Forms.Button btnCopyScriptRight;
        private System.Windows.Forms.TableLayoutPanel pnlPropertiesLeft;
        private System.Windows.Forms.TableLayoutPanel pnlPropertiesRight;
        private System.Windows.Forms.DataGridView grdLeftProperties;
        private System.Windows.Forms.DataGridView grdRightProperties;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnCheckDBLeft;
        private System.Windows.Forms.Button btnCheckDBRight;
    }
}