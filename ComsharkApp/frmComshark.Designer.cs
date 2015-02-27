namespace Comshark
{
    partial class frmComshark
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComshark));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportRAWDataAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportProcessedDataAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAWDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processedInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectInvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolbayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.packetListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetBytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.timeDisplayFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourisePacketListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoScrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAPacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.previousPacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextPacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstPacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastPacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.enabledProtocolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythonShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbtnProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnStart = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStop = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnConnect = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.RightToolStripPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.timestamp,
            this.Interface,
            this.protocol,
            this.source,
            this.destination,
            this.length,
            this.info,
            this.valid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 20;
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1070, 286);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // number
            // 
            this.number.DataPropertyName = "Id";
            this.number.HeaderText = "No.";
            this.number.MinimumWidth = 20;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 50;
            // 
            // timestamp
            // 
            this.timestamp.DataPropertyName = "Time";
            this.timestamp.FillWeight = 200F;
            this.timestamp.HeaderText = "Time";
            this.timestamp.MinimumWidth = 150;
            this.timestamp.Name = "timestamp";
            this.timestamp.ReadOnly = true;
            this.timestamp.Width = 200;
            // 
            // Interface
            // 
            this.Interface.DataPropertyName = "Interface";
            this.Interface.HeaderText = "Interface";
            this.Interface.MinimumWidth = 50;
            this.Interface.Name = "Interface";
            this.Interface.ReadOnly = true;
            // 
            // protocol
            // 
            this.protocol.DataPropertyName = "Protocol";
            this.protocol.HeaderText = "Protocol";
            this.protocol.MinimumWidth = 80;
            this.protocol.Name = "protocol";
            this.protocol.ReadOnly = true;
            this.protocol.Width = 150;
            // 
            // source
            // 
            this.source.DataPropertyName = "Source";
            this.source.FillWeight = 70F;
            this.source.HeaderText = "Source";
            this.source.MinimumWidth = 50;
            this.source.Name = "source";
            this.source.ReadOnly = true;
            this.source.Width = 70;
            // 
            // destination
            // 
            this.destination.DataPropertyName = "Destination";
            this.destination.FillWeight = 70F;
            this.destination.HeaderText = "Destination";
            this.destination.MinimumWidth = 50;
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            this.destination.Width = 70;
            // 
            // length
            // 
            this.length.DataPropertyName = "Length";
            this.length.FillWeight = 50F;
            this.length.HeaderText = "Length";
            this.length.MinimumWidth = 20;
            this.length.Name = "length";
            this.length.ReadOnly = true;
            this.length.Width = 50;
            // 
            // info
            // 
            this.info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.info.DataPropertyName = "Info";
            this.info.HeaderText = "Info";
            this.info.MinimumWidth = 50;
            this.info.Name = "info";
            this.info.ReadOnly = true;
            // 
            // valid
            // 
            this.valid.DataPropertyName = "Valid";
            this.valid.FillWeight = 50F;
            this.valid.HeaderText = "Valid";
            this.valid.MinimumWidth = 20;
            this.valid.Name = "valid";
            this.valid.ReadOnly = true;
            this.valid.Width = 50;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.White;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.ForeColor = System.Drawing.Color.Black;
            this.treeView.FullRowSelect = true;
            this.treeView.HideSelection = false;
            this.treeView.Indent = 16;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Node4";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Node6";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Node8";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Node9";
            treeNode10.Name = "Node10";
            treeNode10.Text = "Node10";
            treeNode11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            treeNode11.Name = "Node3";
            treeNode11.Text = "Node3";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode11});
            this.treeView.ShowLines = false;
            this.treeView.Size = new System.Drawing.Size(1070, 163);
            this.treeView.TabIndex = 1;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView);
            this.splitContainer1.Size = new System.Drawing.Size(1070, 453);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 3;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1070, 453);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripContainer1.RightToolStripPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.Size = new System.Drawing.Size(1136, 530);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1136, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(66, 50);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 36);
            this.toolStripButton1.Text = "Test";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.goToolStripMenuItem,
            this.captureToolStripMenuItem,
            this.analyseToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.importDataToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exportRAWDataAsToolStripMenuItem,
            this.exportProcessedDataAsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.importDataToolStripMenuItem.Text = "Import Data";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(212, 6);
            // 
            // exportRAWDataAsToolStripMenuItem
            // 
            this.exportRAWDataAsToolStripMenuItem.Name = "exportRAWDataAsToolStripMenuItem";
            this.exportRAWDataAsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.exportRAWDataAsToolStripMenuItem.Text = "Export RAW Data As...";
            // 
            // exportProcessedDataAsToolStripMenuItem
            // 
            this.exportProcessedDataAsToolStripMenuItem.Name = "exportProcessedDataAsToolStripMenuItem";
            this.exportProcessedDataAsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.exportProcessedDataAsToolStripMenuItem.Text = "Export Processed Data As...";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(212, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.toolStripMenuItem8,
            this.selectAllToolStripMenuItem,
            this.selectNoneToolStripMenuItem,
            this.selectInvertToolStripMenuItem,
            this.toolStripMenuItem12,
            this.propertiesToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rAWDataToolStripMenuItem,
            this.processedInformationToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // rAWDataToolStripMenuItem
            // 
            this.rAWDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decimalToolStripMenuItem,
            this.hexToolStripMenuItem,
            this.aSCIIToolStripMenuItem});
            this.rAWDataToolStripMenuItem.Name = "rAWDataToolStripMenuItem";
            this.rAWDataToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.rAWDataToolStripMenuItem.Text = "Packet Bytes";
            // 
            // decimalToolStripMenuItem
            // 
            this.decimalToolStripMenuItem.Name = "decimalToolStripMenuItem";
            this.decimalToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.decimalToolStripMenuItem.Text = "Decimal";
            // 
            // hexToolStripMenuItem
            // 
            this.hexToolStripMenuItem.Name = "hexToolStripMenuItem";
            this.hexToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.hexToolStripMenuItem.Text = "Hex";
            // 
            // aSCIIToolStripMenuItem
            // 
            this.aSCIIToolStripMenuItem.Name = "aSCIIToolStripMenuItem";
            this.aSCIIToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aSCIIToolStripMenuItem.Text = "ASCII";
            // 
            // processedInformationToolStripMenuItem
            // 
            this.processedInformationToolStripMenuItem.Name = "processedInformationToolStripMenuItem";
            this.processedInformationToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.processedInformationToolStripMenuItem.Text = "Processed Information";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(135, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // selectNoneToolStripMenuItem
            // 
            this.selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
            this.selectNoneToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.selectNoneToolStripMenuItem.Text = "Select None";
            // 
            // selectInvertToolStripMenuItem
            // 
            this.selectInvertToolStripMenuItem.Name = "selectInvertToolStripMenuItem";
            this.selectInvertToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.selectInvertToolStripMenuItem.Text = "Select Invert";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(135, 6);
            // 
            // propertiesToolStripMenuItem1
            // 
            this.propertiesToolStripMenuItem1.Name = "propertiesToolStripMenuItem1";
            this.propertiesToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.propertiesToolStripMenuItem1.Text = "Properties";
            this.propertiesToolStripMenuItem1.Click += new System.EventHandler(this.propertiesToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolbayToolStripMenuItem,
            this.toolStripMenuItem6,
            this.packetListToolStripMenuItem,
            this.packetDetailsToolStripMenuItem,
            this.packetBytesToolStripMenuItem,
            this.toolStripMenuItem7,
            this.timeDisplayFormatToolStripMenuItem,
            this.colourisePacketListToolStripMenuItem,
            this.autoScrollToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mainToolbayToolStripMenuItem
            // 
            this.mainToolbayToolStripMenuItem.Checked = true;
            this.mainToolbayToolStripMenuItem.CheckOnClick = true;
            this.mainToolbayToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mainToolbayToolStripMenuItem.Name = "mainToolbayToolStripMenuItem";
            this.mainToolbayToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.mainToolbayToolStripMenuItem.Text = "Main Toolbar";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 6);
            // 
            // packetListToolStripMenuItem
            // 
            this.packetListToolStripMenuItem.Checked = true;
            this.packetListToolStripMenuItem.CheckOnClick = true;
            this.packetListToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.packetListToolStripMenuItem.Name = "packetListToolStripMenuItem";
            this.packetListToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.packetListToolStripMenuItem.Text = "Packet List";
            // 
            // packetDetailsToolStripMenuItem
            // 
            this.packetDetailsToolStripMenuItem.Checked = true;
            this.packetDetailsToolStripMenuItem.CheckOnClick = true;
            this.packetDetailsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.packetDetailsToolStripMenuItem.Name = "packetDetailsToolStripMenuItem";
            this.packetDetailsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.packetDetailsToolStripMenuItem.Text = "Packet Details";
            // 
            // packetBytesToolStripMenuItem
            // 
            this.packetBytesToolStripMenuItem.Checked = true;
            this.packetBytesToolStripMenuItem.CheckOnClick = true;
            this.packetBytesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.packetBytesToolStripMenuItem.Name = "packetBytesToolStripMenuItem";
            this.packetBytesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.packetBytesToolStripMenuItem.Text = "Packet Bytes";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 6);
            // 
            // timeDisplayFormatToolStripMenuItem
            // 
            this.timeDisplayFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iSOToolStripMenuItem});
            this.timeDisplayFormatToolStripMenuItem.Name = "timeDisplayFormatToolStripMenuItem";
            this.timeDisplayFormatToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.timeDisplayFormatToolStripMenuItem.Text = "Time Display Format";
            // 
            // iSOToolStripMenuItem
            // 
            this.iSOToolStripMenuItem.Checked = true;
            this.iSOToolStripMenuItem.CheckOnClick = true;
            this.iSOToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iSOToolStripMenuItem.Name = "iSOToolStripMenuItem";
            this.iSOToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.iSOToolStripMenuItem.Text = "ISO";
            // 
            // colourisePacketListToolStripMenuItem
            // 
            this.colourisePacketListToolStripMenuItem.Checked = true;
            this.colourisePacketListToolStripMenuItem.CheckOnClick = true;
            this.colourisePacketListToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.colourisePacketListToolStripMenuItem.Name = "colourisePacketListToolStripMenuItem";
            this.colourisePacketListToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.colourisePacketListToolStripMenuItem.Text = "Colourise Packet List";
            // 
            // autoScrollToolStripMenuItem
            // 
            this.autoScrollToolStripMenuItem.Checked = true;
            this.autoScrollToolStripMenuItem.CheckOnClick = true;
            this.autoScrollToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoScrollToolStripMenuItem.Name = "autoScrollToolStripMenuItem";
            this.autoScrollToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.autoScrollToolStripMenuItem.Text = "Auto Scroll";
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findAPacketToolStripMenuItem,
            this.gotoToolStripMenuItem,
            this.toolStripMenuItem4,
            this.previousPacketToolStripMenuItem,
            this.nextPacketToolStripMenuItem,
            this.firstPacketToolStripMenuItem,
            this.lastPacketToolStripMenuItem});
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.goToolStripMenuItem.Text = "Navigate";
            // 
            // findAPacketToolStripMenuItem
            // 
            this.findAPacketToolStripMenuItem.Name = "findAPacketToolStripMenuItem";
            this.findAPacketToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.findAPacketToolStripMenuItem.Text = "Find a Packet";
            // 
            // gotoToolStripMenuItem
            // 
            this.gotoToolStripMenuItem.Name = "gotoToolStripMenuItem";
            this.gotoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.gotoToolStripMenuItem.Text = "Go to Packet";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(154, 6);
            // 
            // previousPacketToolStripMenuItem
            // 
            this.previousPacketToolStripMenuItem.Name = "previousPacketToolStripMenuItem";
            this.previousPacketToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.previousPacketToolStripMenuItem.Text = "Previous Packet";
            // 
            // nextPacketToolStripMenuItem
            // 
            this.nextPacketToolStripMenuItem.Name = "nextPacketToolStripMenuItem";
            this.nextPacketToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nextPacketToolStripMenuItem.Text = "Next Packet";
            // 
            // firstPacketToolStripMenuItem
            // 
            this.firstPacketToolStripMenuItem.Name = "firstPacketToolStripMenuItem";
            this.firstPacketToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.firstPacketToolStripMenuItem.Text = "First Packet";
            // 
            // lastPacketToolStripMenuItem
            // 
            this.lastPacketToolStripMenuItem.Name = "lastPacketToolStripMenuItem";
            this.lastPacketToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.lastPacketToolStripMenuItem.Text = "Last Packet";
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripSeparator2,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.pauseToolStripMenuItem});
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.captureToolStripMenuItem.Text = "Capture";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem9.Text = "Interface";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem10.Text = "Options";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(117, 6);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            // 
            // analyseToolStripMenuItem
            // 
            this.analyseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decodeAsToolStripMenuItem,
            this.toolStripMenuItem5,
            this.enabledProtocolsToolStripMenuItem});
            this.analyseToolStripMenuItem.Name = "analyseToolStripMenuItem";
            this.analyseToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.analyseToolStripMenuItem.Text = "Analyse";
            // 
            // decodeAsToolStripMenuItem
            // 
            this.decodeAsToolStripMenuItem.Name = "decodeAsToolStripMenuItem";
            this.decodeAsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.decodeAsToolStripMenuItem.Text = "Decode As..";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(166, 6);
            // 
            // enabledProtocolsToolStripMenuItem
            // 
            this.enabledProtocolsToolStripMenuItem.Name = "enabledProtocolsToolStripMenuItem";
            this.enabledProtocolsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.enabledProtocolsToolStripMenuItem.Text = "Enabled Protocols";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pythonShellToolStripMenuItem,
            this.toolStripMenuItem11});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // pythonShellToolStripMenuItem
            // 
            this.pythonShellToolStripMenuItem.Name = "pythonShellToolStripMenuItem";
            this.pythonShellToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pythonShellToolStripMenuItem.Text = "Python Console";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(155, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator5,
            this.tsbtnStart,
            this.tsbtnStop,
            this.tsbtnPause,
            this.toolStripSeparator3,
            this.tsbtnConnect,
            this.tsbtnDisconnect,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(305, 31);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnProperties,
            this.toolStripMenuItem1,
            this.tsbtnQuit});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(37, 28);
            this.toolStripDropDownButton1.Text = "Comshark";
            this.toolStripDropDownButton1.ToolTipText = "Comshark Menu";
            // 
            // tsbtnProperties
            // 
            this.tsbtnProperties.Name = "tsbtnProperties";
            this.tsbtnProperties.Size = new System.Drawing.Size(127, 22);
            this.tsbtnProperties.Text = "Properties";
            this.tsbtnProperties.Click += new System.EventHandler(this.tsbtnProperties_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 6);
            // 
            // tsbtnQuit
            // 
            this.tsbtnQuit.Name = "tsbtnQuit";
            this.tsbtnQuit.Size = new System.Drawing.Size(127, 22);
            this.tsbtnQuit.Text = "Quit";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnStart
            // 
            this.tsbtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnStart.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStart.Image")));
            this.tsbtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStart.Name = "tsbtnStart";
            this.tsbtnStart.Size = new System.Drawing.Size(35, 28);
            this.tsbtnStart.Text = "Start";
            this.tsbtnStart.ToolTipText = "Start Capture";
            // 
            // tsbtnStop
            // 
            this.tsbtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStop.Image")));
            this.tsbtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStop.Name = "tsbtnStop";
            this.tsbtnStop.Size = new System.Drawing.Size(35, 28);
            this.tsbtnStop.Text = "Stop";
            this.tsbtnStop.ToolTipText = "Stop Capture";
            // 
            // tsbtnPause
            // 
            this.tsbtnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnPause.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPause.Image")));
            this.tsbtnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPause.Name = "tsbtnPause";
            this.tsbtnPause.Size = new System.Drawing.Size(42, 28);
            this.tsbtnPause.Text = "Pause";
            this.tsbtnPause.ToolTipText = "Pause Capture";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnConnect
            // 
            this.tsbtnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConnect.Image")));
            this.tsbtnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConnect.Name = "tsbtnConnect";
            this.tsbtnConnect.Size = new System.Drawing.Size(56, 28);
            this.tsbtnConnect.Text = "Connect";
            this.tsbtnConnect.ToolTipText = "Connect selected interface";
            this.tsbtnConnect.Click += new System.EventHandler(this.tsbtnConnect_Click);
            // 
            // tsbtnDisconnect
            // 
            this.tsbtnDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDisconnect.Image")));
            this.tsbtnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDisconnect.Name = "tsbtnDisconnect";
            this.tsbtnDisconnect.Size = new System.Drawing.Size(70, 28);
            this.tsbtnDisconnect.Text = "Disconnect";
            this.tsbtnDisconnect.ToolTipText = "Disconnect selected interface";
            this.tsbtnDisconnect.Click += new System.EventHandler(this.tsbtnDisconnect_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // frmComshark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 530);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmComshark";
            this.Text = "Comshark";
            this.Load += new System.EventHandler(this.frmComshark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.RightToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.RightToolStripPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tsbtnProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsbtnQuit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exportRAWDataAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportProcessedDataAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnStart;
        private System.Windows.Forms.ToolStripButton tsbtnStop;
        private System.Windows.Forms.ToolStripButton tsbtnPause;
        private System.Windows.Forms.ToolStripMenuItem findAPacketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem previousPacketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextPacketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstPacketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastPacketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodeAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem enabledProtocolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pythonShellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAWDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSCIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processedInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectNoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectInvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainToolbayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem packetListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packetDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packetBytesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem timeDisplayFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourisePacketListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoScrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interface;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn source;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
        private System.Windows.Forms.DataGridViewTextBoxColumn info;
        private System.Windows.Forms.DataGridViewTextBoxColumn valid;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnDisconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

