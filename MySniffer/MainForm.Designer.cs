﻿namespace MySniffer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.comDeviceList = new System.Windows.Forms.ToolStripComboBox();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridPacket = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.staffMonitoringPanel = new System.Windows.Forms.Panel();
            this.staffMonitoringOpenLabel = new System.Windows.Forms.Label();
            this.staffNoticeLabel = new System.Windows.Forms.Label();
            this.qqLoginPanel = new System.Windows.Forms.Panel();
            this.qqLoginOpenLabel = new System.Windows.Forms.Label();
            this.qqNoticeLabel = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chartflow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.closeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.staffMonitoringPanel.SuspendLayout();
            this.qqLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartflow)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.comDeviceList,
            this.btnStart,
            this.btnStop,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(812, 40);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.toolStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseMove);
            this.toolStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseUp);
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = false;
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(35, 35);
            this.btnOpen.Text = "打开";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 35);
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 37);
            this.toolStripLabel1.Text = "网卡：";
            // 
            // comDeviceList
            // 
            this.comDeviceList.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.comDeviceList.Name = "comDeviceList";
            this.comDeviceList.Size = new System.Drawing.Size(300, 40);
            this.comDeviceList.SelectedIndexChanged += new System.EventHandler(this.comDeviceList_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = false;
            this.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(35, 35);
            this.btnStart.Text = "开始";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = false;
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Enabled = false;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(35, 35);
            this.btnStop.Text = "停止";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridPacket);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(812, 507);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridPacket
            // 
            this.dataGridPacket.AllowUserToAddRows = false;
            this.dataGridPacket.AllowUserToDeleteRows = false;
            this.dataGridPacket.AllowUserToResizeRows = false;
            this.dataGridPacket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPacket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.dataGridPacket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPacket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle64.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPacket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle64;
            this.dataGridPacket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridPacket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle71.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle71.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPacket.DefaultCellStyle = dataGridViewCellStyle71;
            this.dataGridPacket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPacket.EnableHeadersVisualStyles = false;
            this.dataGridPacket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dataGridPacket.Location = new System.Drawing.Point(0, 0);
            this.dataGridPacket.MultiSelect = false;
            this.dataGridPacket.Name = "dataGridPacket";
            this.dataGridPacket.ReadOnly = true;
            dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle72.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle72.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle72.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle72.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle72.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPacket.RowHeadersDefaultCellStyle = dataGridViewCellStyle72;
            this.dataGridPacket.RowHeadersVisible = false;
            this.dataGridPacket.RowTemplate.Height = 23;
            this.dataGridPacket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPacket.ShowCellErrors = false;
            this.dataGridPacket.ShowCellToolTips = false;
            this.dataGridPacket.ShowEditingIcon = false;
            this.dataGridPacket.ShowRowErrors = false;
            this.dataGridPacket.Size = new System.Drawing.Size(810, 225);
            this.dataGridPacket.TabIndex = 0;
            this.dataGridPacket.CancelRowEdit += new System.Windows.Forms.QuestionEventHandler(this.dataGridPacket_CancelRowEdit);
            this.dataGridPacket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacket_CellContentClick);
            this.dataGridPacket.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridPacket_CellMouseDown);
            // 
            // Column1
            // 
            dataGridViewCellStyle65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle65.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle65;
            this.Column1.HeaderText = "编  号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle66.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle66.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle66;
            this.Column2.HeaderText = "协  议";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle67.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle67.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle67;
            this.Column3.HeaderText = "数据长度(bytes)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle68.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle68.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle68;
            this.Column4.HeaderText = "源地址";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle69.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle69.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle69;
            this.Column5.HeaderText = "目的地址";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle70.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Column6.DefaultCellStyle = dataGridViewCellStyle70;
            this.Column6.HeaderText = "信息";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer2.Panel1.Controls.Add(this.staffMonitoringPanel);
            this.splitContainer2.Panel1.Controls.Add(this.qqLoginPanel);
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chartflow);
            this.splitContainer2.Size = new System.Drawing.Size(812, 276);
            this.splitContainer2.SplitterDistance = 409;
            this.splitContainer2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(167, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 119);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // staffMonitoringPanel
            // 
            this.staffMonitoringPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.staffMonitoringPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staffMonitoringPanel.Controls.Add(this.staffMonitoringOpenLabel);
            this.staffMonitoringPanel.Controls.Add(this.staffNoticeLabel);
            this.staffMonitoringPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.staffMonitoringPanel.Location = new System.Drawing.Point(167, 75);
            this.staffMonitoringPanel.Name = "staffMonitoringPanel";
            this.staffMonitoringPanel.Size = new System.Drawing.Size(240, 80);
            this.staffMonitoringPanel.TabIndex = 9;
            this.staffMonitoringPanel.Click += new System.EventHandler(this.staffMonitoringOpenLabel_Click);
            this.staffMonitoringPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.staffMonitoringPanel_Paint);
            // 
            // staffMonitoringOpenLabel
            // 
            this.staffMonitoringOpenLabel.AutoSize = true;
            this.staffMonitoringOpenLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.staffMonitoringOpenLabel.Location = new System.Drawing.Point(3, 13);
            this.staffMonitoringOpenLabel.Name = "staffMonitoringOpenLabel";
            this.staffMonitoringOpenLabel.Size = new System.Drawing.Size(132, 27);
            this.staffMonitoringOpenLabel.TabIndex = 0;
            this.staffMonitoringOpenLabel.Text = "影音娱乐检测";
            // 
            // staffNoticeLabel
            // 
            this.staffNoticeLabel.AutoSize = true;
            this.staffNoticeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.staffNoticeLabel.Location = new System.Drawing.Point(37, 43);
            this.staffNoticeLabel.Name = "staffNoticeLabel";
            this.staffNoticeLabel.Size = new System.Drawing.Size(135, 17);
            this.staffNoticeLabel.TabIndex = 3;
            this.staffNoticeLabel.Text = "已捕获影音娱乐记录0条";
            // 
            // qqLoginPanel
            // 
            this.qqLoginPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qqLoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qqLoginPanel.Controls.Add(this.qqLoginOpenLabel);
            this.qqLoginPanel.Controls.Add(this.qqNoticeLabel);
            this.qqLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.qqLoginPanel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qqLoginPanel.Location = new System.Drawing.Point(167, 0);
            this.qqLoginPanel.Name = "qqLoginPanel";
            this.qqLoginPanel.Size = new System.Drawing.Size(240, 75);
            this.qqLoginPanel.TabIndex = 8;
            this.qqLoginPanel.Click += new System.EventHandler(this.qqLoginPanel_Click);
            this.qqLoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.qqLoginPanel_Paint);
            // 
            // qqLoginOpenLabel
            // 
            this.qqLoginOpenLabel.AutoSize = true;
            this.qqLoginOpenLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qqLoginOpenLabel.Location = new System.Drawing.Point(3, 10);
            this.qqLoginOpenLabel.Name = "qqLoginOpenLabel";
            this.qqLoginOpenLabel.Size = new System.Drawing.Size(124, 27);
            this.qqLoginOpenLabel.TabIndex = 1;
            this.qqLoginOpenLabel.Text = "QQ登录监测";
            this.qqLoginOpenLabel.Click += new System.EventHandler(this.qqLoginOpenLabel_Click);
            // 
            // qqNoticeLabel
            // 
            this.qqNoticeLabel.AutoSize = true;
            this.qqNoticeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qqNoticeLabel.Location = new System.Drawing.Point(37, 47);
            this.qqNoticeLabel.Name = "qqNoticeLabel";
            this.qqNoticeLabel.Size = new System.Drawing.Size(143, 17);
            this.qqNoticeLabel.TabIndex = 4;
            this.qqNoticeLabel.Text = "已捕获QQ上下线记录0条";
            this.qqNoticeLabel.Click += new System.EventHandler(this.qqNoticeLabel_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(167, 274);
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BD14656_.GIF");
            // 
            // chartflow
            // 
            chartArea8.Name = "ChartArea1";
            this.chartflow.ChartAreas.Add(chartArea8);
            this.chartflow.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Alignment = System.Drawing.StringAlignment.Far;
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.chartflow.Legends.Add(legend8);
            this.chartflow.Location = new System.Drawing.Point(0, 0);
            this.chartflow.Name = "chartflow";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.IsXValueIndexed = true;
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            series15.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.IsXValueIndexed = true;
            series16.Legend = "Legend1";
            series16.Name = "Series2";
            series16.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chartflow.Series.Add(series15);
            this.chartflow.Series.Add(series16);
            this.chartflow.Size = new System.Drawing.Size(397, 274);
            this.chartflow.TabIndex = 1;
            this.chartflow.Text = "chartflow";
            this.chartflow.Click += new System.EventHandler(this.chartflow_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Snow;
            this.closeButton.Location = new System.Drawing.Point(775, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(37, 28);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "×";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(738, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "□";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(20, 37);
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "UserWatch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacket)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.staffMonitoringPanel.ResumeLayout(false);
            this.staffMonitoringPanel.PerformLayout();
            this.qqLoginPanel.ResumeLayout(false);
            this.qqLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartflow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox comDeviceList;
        private System.Windows.Forms.ToolStripButton btnStart;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridPacket;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel qqLoginPanel;
        private System.Windows.Forms.Label qqLoginOpenLabel;
        private System.Windows.Forms.Label qqNoticeLabel;
        private System.Windows.Forms.Panel staffMonitoringPanel;
        private System.Windows.Forms.Label staffMonitoringOpenLabel;
        private System.Windows.Forms.Label staffNoticeLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartflow;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

