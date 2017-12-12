namespace MySniffer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.comDeviceList = new System.Windows.Forms.ToolStripComboBox();
            this.comFilter = new System.Windows.Forms.ToolStripComboBox();
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
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.comDeviceList,
            this.comFilter,
            this.btnStart,
            this.btnStop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1083, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 47);
            this.toolStripLabel1.Text = "网卡：";
            // 
            // comDeviceList
            // 
            this.comDeviceList.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.comDeviceList.Name = "comDeviceList";
            this.comDeviceList.Size = new System.Drawing.Size(399, 50);
            this.comDeviceList.SelectedIndexChanged += new System.EventHandler(this.comDeviceList_SelectedIndexChanged);
            // 
            // comFilter
            // 
            this.comFilter.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.comFilter.Name = "comFilter";
            this.comFilter.Size = new System.Drawing.Size(160, 50);
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
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer1.Size = new System.Drawing.Size(1083, 634);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridPacket
            // 
            this.dataGridPacket.AllowUserToAddRows = false;
            this.dataGridPacket.AllowUserToDeleteRows = false;
            this.dataGridPacket.AllowUserToResizeRows = false;
            this.dataGridPacket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPacket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPacket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridPacket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridPacket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPacket.Location = new System.Drawing.Point(0, 0);
            this.dataGridPacket.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridPacket.MultiSelect = false;
            this.dataGridPacket.Name = "dataGridPacket";
            this.dataGridPacket.ReadOnly = true;
            this.dataGridPacket.RowHeadersVisible = false;
            this.dataGridPacket.RowTemplate.Height = 23;
            this.dataGridPacket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPacket.ShowCellErrors = false;
            this.dataGridPacket.ShowCellToolTips = false;
            this.dataGridPacket.ShowEditingIcon = false;
            this.dataGridPacket.ShowRowErrors = false;
            this.dataGridPacket.Size = new System.Drawing.Size(1081, 245);
            this.dataGridPacket.TabIndex = 0;
            this.dataGridPacket.CancelRowEdit += new System.Windows.Forms.QuestionEventHandler(this.dataGridPacket_CancelRowEdit);
            this.dataGridPacket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacket_CellContentClick);
            this.dataGridPacket.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridPacket_CellMouseDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "编  号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "协  议";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "数据长度(bytes)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "源地址";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "目的地址";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "信息";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer2.Size = new System.Drawing.Size(1083, 382);
            this.splitContainer2.SplitterDistance = 529;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(221, 192);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(306, 188);
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
            this.staffMonitoringPanel.Location = new System.Drawing.Point(221, 93);
            this.staffMonitoringPanel.Margin = new System.Windows.Forms.Padding(4);
            this.staffMonitoringPanel.Name = "staffMonitoringPanel";
            this.staffMonitoringPanel.Size = new System.Drawing.Size(306, 99);
            this.staffMonitoringPanel.TabIndex = 9;
            // 
            // staffMonitoringOpenLabel
            // 
            this.staffMonitoringOpenLabel.AutoSize = true;
            this.staffMonitoringOpenLabel.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.staffMonitoringOpenLabel.Location = new System.Drawing.Point(4, 16);
            this.staffMonitoringOpenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffMonitoringOpenLabel.Name = "staffMonitoringOpenLabel";
            this.staffMonitoringOpenLabel.Size = new System.Drawing.Size(162, 26);
            this.staffMonitoringOpenLabel.TabIndex = 0;
            this.staffMonitoringOpenLabel.Text = "影音娱乐检测";
            // 
            // staffNoticeLabel
            // 
            this.staffNoticeLabel.AutoSize = true;
            this.staffNoticeLabel.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.staffNoticeLabel.Location = new System.Drawing.Point(49, 54);
            this.staffNoticeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffNoticeLabel.Name = "staffNoticeLabel";
            this.staffNoticeLabel.Size = new System.Drawing.Size(120, 15);
            this.staffNoticeLabel.TabIndex = 3;
            this.staffNoticeLabel.Text = "今日新增记录0条";
            // 
            // qqLoginPanel
            // 
            this.qqLoginPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qqLoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qqLoginPanel.Controls.Add(this.qqLoginOpenLabel);
            this.qqLoginPanel.Controls.Add(this.qqNoticeLabel);
            this.qqLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.qqLoginPanel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qqLoginPanel.Location = new System.Drawing.Point(221, 0);
            this.qqLoginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.qqLoginPanel.Name = "qqLoginPanel";
            this.qqLoginPanel.Size = new System.Drawing.Size(306, 93);
            this.qqLoginPanel.TabIndex = 8;
            // 
            // qqLoginOpenLabel
            // 
            this.qqLoginOpenLabel.AutoSize = true;
            this.qqLoginOpenLabel.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qqLoginOpenLabel.Location = new System.Drawing.Point(4, 12);
            this.qqLoginOpenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qqLoginOpenLabel.Name = "qqLoginOpenLabel";
            this.qqLoginOpenLabel.Size = new System.Drawing.Size(150, 26);
            this.qqLoginOpenLabel.TabIndex = 1;
            this.qqLoginOpenLabel.Text = "QQ登录监测";
            this.qqLoginOpenLabel.Click += new System.EventHandler(this.qqLoginOpenLabel_Click);
            // 
            // qqNoticeLabel
            // 
            this.qqNoticeLabel.AutoSize = true;
            this.qqNoticeLabel.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qqNoticeLabel.Location = new System.Drawing.Point(49, 59);
            this.qqNoticeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qqNoticeLabel.Name = "qqNoticeLabel";
            this.qqNoticeLabel.Size = new System.Drawing.Size(172, 15);
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
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(221, 380);
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
            chartArea1.Name = "ChartArea1";
            this.chartflow.ChartAreas.Add(chartArea1);
            this.chartflow.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartflow.Legends.Add(legend1);
            this.chartflow.Location = new System.Drawing.Point(0, 0);
            this.chartflow.Margin = new System.Windows.Forms.Padding(4);
            this.chartflow.Name = "chartflow";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chartflow.Series.Add(series1);
            this.chartflow.Series.Add(series2);
            this.chartflow.Size = new System.Drawing.Size(547, 380);
            this.chartflow.TabIndex = 1;
            this.chartflow.Text = "chartflow";
            this.chartflow.Click += new System.EventHandler(this.chartflow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 684);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripComboBox comFilter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel qqLoginPanel;
        private System.Windows.Forms.Label qqLoginOpenLabel;
        private System.Windows.Forms.Label qqNoticeLabel;
        private System.Windows.Forms.Panel staffMonitoringPanel;
        private System.Windows.Forms.Label staffMonitoringOpenLabel;
        private System.Windows.Forms.Label staffNoticeLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartflow;
    }
}

