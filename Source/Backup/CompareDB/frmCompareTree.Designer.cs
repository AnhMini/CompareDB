namespace CompareDB
{
    partial class frmCompareTree
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompareTree));
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.splMain = new System.Windows.Forms.SplitContainer();
            this.splUp = new System.Windows.Forms.SplitContainer();
            this.splDown = new System.Windows.Forms.SplitContainer();
            this.trvDBLeft = new System.Windows.Forms.TreeView();
            this.trvDBRight = new System.Windows.Forms.TreeView();
            this.grdProperties = new System.Windows.Forms.DataGridView();
            this.ctmTreeViewLeft = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmTreeViewRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToRightToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeft = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRight = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopyToRightAll = new System.Windows.Forms.Button();
            this.btnCopyToRight = new System.Windows.Forms.Button();
            this.btnCopyToLeft = new System.Windows.Forms.Button();
            this.btnCopyToLeftAll = new System.Windows.Forms.Button();
            this.grbScripts = new System.Windows.Forms.GroupBox();
            this.txtScripts = new System.Windows.Forms.TextBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain.SuspendLayout();
            this.splMain.Panel1.SuspendLayout();
            this.splMain.Panel2.SuspendLayout();
            this.splMain.SuspendLayout();
            this.splUp.Panel1.SuspendLayout();
            this.splUp.Panel2.SuspendLayout();
            this.splUp.SuspendLayout();
            this.splDown.Panel1.SuspendLayout();
            this.splDown.Panel2.SuspendLayout();
            this.splDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).BeginInit();
            this.ctmTreeViewLeft.SuspendLayout();
            this.ctmTreeViewRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.grbScripts.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Controls.Add(this.splMain, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 2;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Size = new System.Drawing.Size(895, 520);
            this.pnlMain.TabIndex = 2;
            // 
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.Location = new System.Drawing.Point(3, 28);
            this.splMain.Name = "splMain";
            this.splMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splMain.Panel1
            // 
            this.splMain.Panel1.Controls.Add(this.splUp);
            // 
            // splMain.Panel2
            // 
            this.splMain.Panel2.Controls.Add(this.grbScripts);
            this.splMain.Size = new System.Drawing.Size(889, 489);
            this.splMain.SplitterDistance = 401;
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
            this.splUp.Panel1.Controls.Add(this.splDown);
            // 
            // splUp.Panel2
            // 
            this.splUp.Panel2.Controls.Add(this.grdProperties);
            this.splUp.Size = new System.Drawing.Size(889, 401);
            this.splUp.SplitterDistance = 588;
            this.splUp.TabIndex = 0;
            // 
            // splDown
            // 
            this.splDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splDown.Location = new System.Drawing.Point(0, 0);
            this.splDown.Name = "splDown";
            // 
            // splDown.Panel1
            // 
            this.splDown.Panel1.Controls.Add(this.pnlLeft);
            // 
            // splDown.Panel2
            // 
            this.splDown.Panel2.Controls.Add(this.pnlRight);
            this.splDown.Size = new System.Drawing.Size(588, 401);
            this.splDown.SplitterDistance = 269;
            this.splDown.TabIndex = 0;
            // 
            // trvDBLeft
            // 
            this.pnlLeft.SetColumnSpan(this.trvDBLeft, 4);
            this.trvDBLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDBLeft.FullRowSelect = true;
            this.trvDBLeft.ImageIndex = 0;
            this.trvDBLeft.ImageList = this.imgList;
            this.trvDBLeft.Location = new System.Drawing.Point(3, 33);
            this.trvDBLeft.Name = "trvDBLeft";
            this.trvDBLeft.SelectedImageIndex = 0;
            this.trvDBLeft.ShowLines = false;
            this.trvDBLeft.Size = new System.Drawing.Size(263, 365);
            this.trvDBLeft.TabIndex = 0;
            this.trvDBLeft.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.trvDBLeft_AfterCollapse);
            this.trvDBLeft.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDBLeft_AfterSelect);
            this.trvDBLeft.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvDBLeft_AfterExpand);
            this.trvDBLeft.Click += new System.EventHandler(this.trvDBLeft_Click);
            // 
            // trvDBRight
            // 
            this.pnlRight.SetColumnSpan(this.trvDBRight, 4);
            this.trvDBRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDBRight.FullRowSelect = true;
            this.trvDBRight.ImageIndex = 0;
            this.trvDBRight.ImageList = this.imgList;
            this.trvDBRight.Location = new System.Drawing.Point(3, 33);
            this.trvDBRight.Name = "trvDBRight";
            this.trvDBRight.SelectedImageIndex = 0;
            this.trvDBRight.ShowLines = false;
            this.trvDBRight.Size = new System.Drawing.Size(309, 365);
            this.trvDBRight.TabIndex = 0;
            this.trvDBRight.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.trvDBRight_AfterCollapse);
            this.trvDBRight.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDBRight_AfterSelect);
            this.trvDBRight.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvDBRight_AfterExpand);
            this.trvDBRight.Click += new System.EventHandler(this.trvDBRight_Click);
            // 
            // grdProperties
            // 
            this.grdProperties.AllowUserToAddRows = false;
            this.grdProperties.AllowUserToDeleteRows = false;
            this.grdProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProperties.Location = new System.Drawing.Point(0, 0);
            this.grdProperties.Name = "grdProperties";
            this.grdProperties.Size = new System.Drawing.Size(297, 401);
            this.grdProperties.TabIndex = 0;
            // 
            // ctmTreeViewLeft
            // 
            this.ctmTreeViewLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToRightToolStripMenuItem1});
            this.ctmTreeViewLeft.Name = "ctmTreeViewLeft";
            this.ctmTreeViewLeft.Size = new System.Drawing.Size(151, 26);
            // 
            // ctmTreeViewRight
            // 
            this.ctmTreeViewRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToRightToolStripMenuItem});
            this.ctmTreeViewRight.Name = "ctmTreeViewRight";
            this.ctmTreeViewRight.Size = new System.Drawing.Size(143, 26);
            // 
            // copyToRightToolStripMenuItem
            // 
            this.copyToRightToolStripMenuItem.Name = "copyToRightToolStripMenuItem";
            this.copyToRightToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.copyToRightToolStripMenuItem.Text = "Copy To Left";
            // 
            // copyToRightToolStripMenuItem1
            // 
            this.copyToRightToolStripMenuItem1.Name = "copyToRightToolStripMenuItem1";
            this.copyToRightToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.copyToRightToolStripMenuItem1.Text = "Copy To Right";
            // 
            // pnlLeft
            // 
            this.pnlLeft.ColumnCount = 4;
            this.pnlLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.pnlLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.pnlLeft.Controls.Add(this.trvDBLeft, 0, 1);
            this.pnlLeft.Controls.Add(this.btnCopyToRightAll, 2, 0);
            this.pnlLeft.Controls.Add(this.btnCopyToRight, 3, 0);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.RowCount = 2;
            this.pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlLeft.Size = new System.Drawing.Size(269, 401);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.ColumnCount = 4;
            this.pnlRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.pnlRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.pnlRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlRight.Controls.Add(this.trvDBRight, 0, 1);
            this.pnlRight.Controls.Add(this.btnCopyToLeft, 0, 0);
            this.pnlRight.Controls.Add(this.btnCopyToLeftAll, 1, 0);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.RowCount = 2;
            this.pnlRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRight.Size = new System.Drawing.Size(315, 401);
            this.pnlRight.TabIndex = 0;
            // 
            // btnCopyToRightAll
            // 
            this.btnCopyToRightAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyToRightAll.Location = new System.Drawing.Point(91, 3);
            this.btnCopyToRightAll.Name = "btnCopyToRightAll";
            this.btnCopyToRightAll.Size = new System.Drawing.Size(84, 24);
            this.btnCopyToRightAll.TabIndex = 1;
            this.btnCopyToRightAll.Text = ">>";
            this.btnCopyToRightAll.UseVisualStyleBackColor = true;
            this.btnCopyToRightAll.Click += new System.EventHandler(this.btnCopyToRightAll_Click);
            // 
            // btnCopyToRight
            // 
            this.btnCopyToRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyToRight.Location = new System.Drawing.Point(181, 3);
            this.btnCopyToRight.Name = "btnCopyToRight";
            this.btnCopyToRight.Size = new System.Drawing.Size(85, 24);
            this.btnCopyToRight.TabIndex = 1;
            this.btnCopyToRight.Text = ">";
            this.btnCopyToRight.UseVisualStyleBackColor = true;
            this.btnCopyToRight.Click += new System.EventHandler(this.btnCopyToRight_Click);
            // 
            // btnCopyToLeft
            // 
            this.btnCopyToLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyToLeft.Location = new System.Drawing.Point(3, 3);
            this.btnCopyToLeft.Name = "btnCopyToLeft";
            this.btnCopyToLeft.Size = new System.Drawing.Size(84, 24);
            this.btnCopyToLeft.TabIndex = 1;
            this.btnCopyToLeft.Text = "<";
            this.btnCopyToLeft.UseVisualStyleBackColor = true;
            this.btnCopyToLeft.Click += new System.EventHandler(this.btnCopyToLeft_Click);
            // 
            // btnCopyToLeftAll
            // 
            this.btnCopyToLeftAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyToLeftAll.Location = new System.Drawing.Point(93, 3);
            this.btnCopyToLeftAll.Name = "btnCopyToLeftAll";
            this.btnCopyToLeftAll.Size = new System.Drawing.Size(84, 24);
            this.btnCopyToLeftAll.TabIndex = 1;
            this.btnCopyToLeftAll.Text = "<<";
            this.btnCopyToLeftAll.UseVisualStyleBackColor = true;
            this.btnCopyToLeftAll.Click += new System.EventHandler(this.btnCopyToLeftAll_Click);
            // 
            // grbScripts
            // 
            this.grbScripts.Controls.Add(this.txtScripts);
            this.grbScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbScripts.Location = new System.Drawing.Point(0, 0);
            this.grbScripts.Name = "grbScripts";
            this.grbScripts.Size = new System.Drawing.Size(889, 84);
            this.grbScripts.TabIndex = 0;
            this.grbScripts.TabStop = false;
            this.grbScripts.Text = "Scripts Create Table";
            // 
            // txtScripts
            // 
            this.txtScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScripts.Location = new System.Drawing.Point(3, 16);
            this.txtScripts.Multiline = true;
            this.txtScripts.Name = "txtScripts";
            this.txtScripts.ReadOnly = true;
            this.txtScripts.Size = new System.Drawing.Size(883, 65);
            this.txtScripts.TabIndex = 0;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "database.png");
            this.imgList.Images.SetKeyName(1, "folder.png");
            this.imgList.Images.SetKeyName(2, "pivot.png");
            this.imgList.Images.SetKeyName(3, "table-column.jpg");
            this.imgList.Images.SetKeyName(4, "null.png");
            // 
            // frmCompareTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 520);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmCompareTree";
            this.Text = "Compare DB";
            this.Load += new System.EventHandler(this.frmCompareTree_Load);
            this.pnlMain.ResumeLayout(false);
            this.splMain.Panel1.ResumeLayout(false);
            this.splMain.Panel2.ResumeLayout(false);
            this.splMain.ResumeLayout(false);
            this.splUp.Panel1.ResumeLayout(false);
            this.splUp.Panel2.ResumeLayout(false);
            this.splUp.ResumeLayout(false);
            this.splDown.Panel1.ResumeLayout(false);
            this.splDown.Panel2.ResumeLayout(false);
            this.splDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).EndInit();
            this.ctmTreeViewLeft.ResumeLayout(false);
            this.ctmTreeViewRight.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.grbScripts.ResumeLayout(false);
            this.grbScripts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.SplitContainer splMain;
        private System.Windows.Forms.SplitContainer splUp;
        private System.Windows.Forms.SplitContainer splDown;
        private System.Windows.Forms.TreeView trvDBLeft;
        private System.Windows.Forms.TreeView trvDBRight;
        private System.Windows.Forms.DataGridView grdProperties;
        private System.Windows.Forms.ContextMenuStrip ctmTreeViewLeft;
        private System.Windows.Forms.ContextMenuStrip ctmTreeViewRight;
        private System.Windows.Forms.ToolStripMenuItem copyToRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToRightToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel pnlLeft;
        private System.Windows.Forms.Button btnCopyToRightAll;
        private System.Windows.Forms.Button btnCopyToRight;
        private System.Windows.Forms.TableLayoutPanel pnlRight;
        private System.Windows.Forms.Button btnCopyToLeft;
        private System.Windows.Forms.Button btnCopyToLeftAll;
        private System.Windows.Forms.GroupBox grbScripts;
        private System.Windows.Forms.TextBox txtScripts;
        private System.Windows.Forms.ImageList imgList;
    }
}