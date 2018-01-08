﻿namespace MySniffer
{
    partial class StaffMonitoringForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.recordGroupBox = new System.Windows.Forms.GroupBox();
            this.recordDownButton = new System.Windows.Forms.Button();
            this.recordUpButton = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.designatedestinationIPLabel = new System.Windows.Forms.Label();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.designatesourceIPLabel = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.stopDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.stopTimeLabel = new System.Windows.Forms.Label();
            this.entertainmentSite = new System.Windows.Forms.CheckBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.networkGames = new System.Windows.Forms.CheckBox();
            this.currentMonitoringGroupBox = new System.Windows.Forms.GroupBox();
            this.currentDownButton = new System.Windows.Forms.Button();
            this.currentUpButton = new System.Windows.Forms.Button();
            this.startCurrentMonitoring = new System.Windows.Forms.Button();
            this.stopCurrentMonitoring = new System.Windows.Forms.Button();
            this.monitoringResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.monitoringResultslistView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.查询筛选 = new System.Windows.Forms.Label();
            this.rowTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowSourceIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowDestinationIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowDetailReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordGroupBox.SuspendLayout();
            this.currentMonitoringGroupBox.SuspendLayout();
            this.monitoringResultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringResultslistView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // recordGroupBox
            // 
            this.recordGroupBox.Controls.Add(this.查询筛选);
            this.recordGroupBox.Controls.Add(this.recordDownButton);
            this.recordGroupBox.Controls.Add(this.currentMonitoringGroupBox);
            this.recordGroupBox.Controls.Add(this.monitoringResultsGroupBox);
            this.recordGroupBox.Controls.Add(this.recordUpButton);
            this.recordGroupBox.Controls.Add(this.recordButton);
            this.recordGroupBox.Controls.Add(this.designatedestinationIPLabel);
            this.recordGroupBox.Controls.Add(this.destinationTextBox);
            this.recordGroupBox.Controls.Add(this.designatesourceIPLabel);
            this.recordGroupBox.Controls.Add(this.sourceTextBox);
            this.recordGroupBox.Controls.Add(this.stopDateTimePicker);
            this.recordGroupBox.Controls.Add(this.startTimeLabel);
            this.recordGroupBox.Controls.Add(this.stopTimeLabel);
            this.recordGroupBox.Controls.Add(this.entertainmentSite);
            this.recordGroupBox.Controls.Add(this.startDateTimePicker);
            this.recordGroupBox.Controls.Add(this.networkGames);
            this.recordGroupBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recordGroupBox.ForeColor = System.Drawing.Color.White;
            this.recordGroupBox.Location = new System.Drawing.Point(27, 51);
            this.recordGroupBox.Name = "recordGroupBox";
            this.recordGroupBox.Size = new System.Drawing.Size(1208, 630);
            this.recordGroupBox.TabIndex = 12;
            this.recordGroupBox.TabStop = false;
            this.recordGroupBox.Text = "记录查询";
            // 
            // recordDownButton
            // 
            this.recordDownButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recordDownButton.ForeColor = System.Drawing.Color.Black;
            this.recordDownButton.Location = new System.Drawing.Point(151, 257);
            this.recordDownButton.Name = "recordDownButton";
            this.recordDownButton.Size = new System.Drawing.Size(90, 32);
            this.recordDownButton.TabIndex = 17;
            this.recordDownButton.Text = "下页";
            this.recordDownButton.UseVisualStyleBackColor = true;
            // 
            // recordUpButton
            // 
            this.recordUpButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recordUpButton.ForeColor = System.Drawing.Color.Black;
            this.recordUpButton.Location = new System.Drawing.Point(41, 256);
            this.recordUpButton.Name = "recordUpButton";
            this.recordUpButton.Size = new System.Drawing.Size(90, 32);
            this.recordUpButton.TabIndex = 16;
            this.recordUpButton.Text = "上页";
            this.recordUpButton.UseVisualStyleBackColor = true;
            // 
            // recordButton
            // 
            this.recordButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recordButton.ForeColor = System.Drawing.Color.Black;
            this.recordButton.Location = new System.Drawing.Point(41, 197);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(200, 32);
            this.recordButton.TabIndex = 15;
            this.recordButton.Text = "查询记录";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // designatedestinationIPLabel
            // 
            this.designatedestinationIPLabel.AutoSize = true;
            this.designatedestinationIPLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.designatedestinationIPLabel.Location = new System.Drawing.Point(288, 98);
            this.designatedestinationIPLabel.Name = "designatedestinationIPLabel";
            this.designatedestinationIPLabel.Size = new System.Drawing.Size(82, 20);
            this.designatedestinationIPLabel.TabIndex = 14;
            this.designatedestinationIPLabel.Text = "指定目标IP";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(291, 120);
            this.destinationTextBox.Multiline = true;
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(200, 24);
            this.destinationTextBox.TabIndex = 13;
            // 
            // designatesourceIPLabel
            // 
            this.designatesourceIPLabel.AutoSize = true;
            this.designatesourceIPLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.designatesourceIPLabel.Location = new System.Drawing.Point(37, 98);
            this.designatesourceIPLabel.Name = "designatesourceIPLabel";
            this.designatesourceIPLabel.Size = new System.Drawing.Size(82, 20);
            this.designatesourceIPLabel.TabIndex = 12;
            this.designatesourceIPLabel.Text = "指定源端IP";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(41, 120);
            this.sourceTextBox.Multiline = true;
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(200, 24);
            this.sourceTextBox.TabIndex = 11;
            // 
            // stopDateTimePicker
            // 
            this.stopDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopDateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopDateTimePicker.Location = new System.Drawing.Point(291, 52);
            this.stopDateTimePicker.Name = "stopDateTimePicker";
            this.stopDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.stopDateTimePicker.TabIndex = 10;
            this.stopDateTimePicker.ValueChanged += new System.EventHandler(this.stopDateTimePicker_ValueChanged);
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startTimeLabel.Location = new System.Drawing.Point(38, 30);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(69, 20);
            this.startTimeLabel.TabIndex = 7;
            this.startTimeLabel.Text = "开始日期";
            // 
            // stopTimeLabel
            // 
            this.stopTimeLabel.AutoSize = true;
            this.stopTimeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopTimeLabel.Location = new System.Drawing.Point(288, 30);
            this.stopTimeLabel.Name = "stopTimeLabel";
            this.stopTimeLabel.Size = new System.Drawing.Size(69, 20);
            this.stopTimeLabel.TabIndex = 9;
            this.stopTimeLabel.Text = "结束日期";
            // 
            // entertainmentSite
            // 
            this.entertainmentSite.AutoSize = true;
            this.entertainmentSite.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.entertainmentSite.Location = new System.Drawing.Point(628, 110);
            this.entertainmentSite.Name = "entertainmentSite";
            this.entertainmentSite.Size = new System.Drawing.Size(97, 27);
            this.entertainmentSite.TabIndex = 2;
            this.entertainmentSite.Text = "购物行为";
            this.entertainmentSite.UseVisualStyleBackColor = true;
            this.entertainmentSite.CheckedChanged += new System.EventHandler(this.entertainmentSite_CheckedChanged);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startDateTimePicker.Location = new System.Drawing.Point(41, 52);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.startDateTimePicker.TabIndex = 8;
            // 
            // networkGames
            // 
            this.networkGames.AutoSize = true;
            this.networkGames.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.networkGames.Location = new System.Drawing.Point(628, 73);
            this.networkGames.Name = "networkGames";
            this.networkGames.Size = new System.Drawing.Size(97, 27);
            this.networkGames.TabIndex = 1;
            this.networkGames.Text = "娱乐行为";
            this.networkGames.UseVisualStyleBackColor = true;
            this.networkGames.CheckedChanged += new System.EventHandler(this.networkGames_CheckedChanged);
            // 
            // currentMonitoringGroupBox
            // 
            this.currentMonitoringGroupBox.Controls.Add(this.currentDownButton);
            this.currentMonitoringGroupBox.Controls.Add(this.currentUpButton);
            this.currentMonitoringGroupBox.Controls.Add(this.startCurrentMonitoring);
            this.currentMonitoringGroupBox.Controls.Add(this.stopCurrentMonitoring);
            this.currentMonitoringGroupBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentMonitoringGroupBox.ForeColor = System.Drawing.Color.White;
            this.currentMonitoringGroupBox.Location = new System.Drawing.Point(15, 323);
            this.currentMonitoringGroupBox.Name = "currentMonitoringGroupBox";
            this.currentMonitoringGroupBox.Size = new System.Drawing.Size(300, 280);
            this.currentMonitoringGroupBox.TabIndex = 13;
            this.currentMonitoringGroupBox.TabStop = false;
            this.currentMonitoringGroupBox.Text = "实时监测";
            // 
            // currentDownButton
            // 
            this.currentDownButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentDownButton.ForeColor = System.Drawing.Color.Black;
            this.currentDownButton.Location = new System.Drawing.Point(151, 140);
            this.currentDownButton.Name = "currentDownButton";
            this.currentDownButton.Size = new System.Drawing.Size(90, 32);
            this.currentDownButton.TabIndex = 19;
            this.currentDownButton.Text = "下页";
            this.currentDownButton.UseVisualStyleBackColor = true;
            // 
            // currentUpButton
            // 
            this.currentUpButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentUpButton.ForeColor = System.Drawing.Color.Black;
            this.currentUpButton.Location = new System.Drawing.Point(41, 140);
            this.currentUpButton.Name = "currentUpButton";
            this.currentUpButton.Size = new System.Drawing.Size(90, 32);
            this.currentUpButton.TabIndex = 18;
            this.currentUpButton.Text = "上页";
            this.currentUpButton.UseVisualStyleBackColor = true;
            // 
            // startCurrentMonitoring
            // 
            this.startCurrentMonitoring.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startCurrentMonitoring.ForeColor = System.Drawing.Color.Black;
            this.startCurrentMonitoring.Location = new System.Drawing.Point(42, 77);
            this.startCurrentMonitoring.Name = "startCurrentMonitoring";
            this.startCurrentMonitoring.Size = new System.Drawing.Size(200, 32);
            this.startCurrentMonitoring.TabIndex = 4;
            this.startCurrentMonitoring.Text = "开始监测";
            this.startCurrentMonitoring.UseVisualStyleBackColor = true;
            this.startCurrentMonitoring.Click += new System.EventHandler(this.startMonitoring_Click);
            // 
            // stopCurrentMonitoring
            // 
            this.stopCurrentMonitoring.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopCurrentMonitoring.ForeColor = System.Drawing.Color.Black;
            this.stopCurrentMonitoring.Location = new System.Drawing.Point(41, 203);
            this.stopCurrentMonitoring.Name = "stopCurrentMonitoring";
            this.stopCurrentMonitoring.Size = new System.Drawing.Size(200, 32);
            this.stopCurrentMonitoring.TabIndex = 5;
            this.stopCurrentMonitoring.Text = "结束监测";
            this.stopCurrentMonitoring.UseVisualStyleBackColor = true;
            this.stopCurrentMonitoring.Click += new System.EventHandler(this.stopMonitoring_Click);
            // 
            // monitoringResultsGroupBox
            // 
            this.monitoringResultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monitoringResultsGroupBox.Controls.Add(this.monitoringResultslistView);
            this.monitoringResultsGroupBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monitoringResultsGroupBox.ForeColor = System.Drawing.Color.White;
            this.monitoringResultsGroupBox.Location = new System.Drawing.Point(326, 169);
            this.monitoringResultsGroupBox.Name = "monitoringResultsGroupBox";
            this.monitoringResultsGroupBox.Size = new System.Drawing.Size(863, 437);
            this.monitoringResultsGroupBox.TabIndex = 14;
            this.monitoringResultsGroupBox.TabStop = false;
            this.monitoringResultsGroupBox.Text = "行为检测";
            // 
            // monitoringResultslistView
            // 
            this.monitoringResultslistView.AllowUserToAddRows = false;
            this.monitoringResultslistView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.monitoringResultslistView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.monitoringResultslistView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.monitoringResultslistView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.monitoringResultslistView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.monitoringResultslistView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monitoringResultslistView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowTime,
            this.rowSourceIP,
            this.rowDestinationIP,
            this.rowReason,
            this.rowDetailReason});
            this.monitoringResultslistView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.monitoringResultslistView.DefaultCellStyle = dataGridViewCellStyle18;
            this.monitoringResultslistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monitoringResultslistView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.monitoringResultslistView.Location = new System.Drawing.Point(3, 25);
            this.monitoringResultslistView.Name = "monitoringResultslistView";
            this.monitoringResultslistView.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.monitoringResultslistView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.monitoringResultslistView.RowHeadersVisible = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.monitoringResultslistView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.monitoringResultslistView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.monitoringResultslistView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.monitoringResultslistView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.monitoringResultslistView.RowTemplate.Height = 23;
            this.monitoringResultslistView.ShowEditingIcon = false;
            this.monitoringResultslistView.Size = new System.Drawing.Size(857, 409);
            this.monitoringResultslistView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 45);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(1153, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "□";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(1200, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "×";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 查询筛选
            // 
            this.查询筛选.AutoSize = true;
            this.查询筛选.Location = new System.Drawing.Point(623, 30);
            this.查询筛选.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.查询筛选.Name = "查询筛选";
            this.查询筛选.Size = new System.Drawing.Size(92, 27);
            this.查询筛选.TabIndex = 21;
            this.查询筛选.Text = "查询筛选";
            // 
            // rowTime
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.rowTime.DefaultCellStyle = dataGridViewCellStyle13;
            this.rowTime.HeaderText = "时间";
            this.rowTime.Name = "rowTime";
            this.rowTime.ReadOnly = true;
            this.rowTime.Width = 171;
            // 
            // rowSourceIP
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.rowSourceIP.DefaultCellStyle = dataGridViewCellStyle14;
            this.rowSourceIP.HeaderText = "源端IP";
            this.rowSourceIP.Name = "rowSourceIP";
            this.rowSourceIP.ReadOnly = true;
            this.rowSourceIP.Width = 171;
            // 
            // rowDestinationIP
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.rowDestinationIP.DefaultCellStyle = dataGridViewCellStyle15;
            this.rowDestinationIP.HeaderText = "目标端IP";
            this.rowDestinationIP.Name = "rowDestinationIP";
            this.rowDestinationIP.ReadOnly = true;
            this.rowDestinationIP.Width = 171;
            // 
            // rowReason
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.rowReason.DefaultCellStyle = dataGridViewCellStyle16;
            this.rowReason.HeaderText = "用户行为";
            this.rowReason.Name = "rowReason";
            this.rowReason.ReadOnly = true;
            this.rowReason.Width = 171;
            // 
            // rowDetailReason
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.rowDetailReason.DefaultCellStyle = dataGridViewCellStyle17;
            this.rowDetailReason.HeaderText = "具体方式";
            this.rowDetailReason.Name = "rowDetailReason";
            this.rowDetailReason.ReadOnly = true;
            this.rowDetailReason.Width = 171;
            // 
            // StaffMonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1247, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.recordGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffMonitoringForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StaffMonitoringForm_Load_1);
            this.recordGroupBox.ResumeLayout(false);
            this.recordGroupBox.PerformLayout();
            this.currentMonitoringGroupBox.ResumeLayout(false);
            this.monitoringResultsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monitoringResultslistView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //开始时间label
        private System.Windows.Forms.Label startTimeLabel;
        //结束时间label
        private System.Windows.Forms.Label stopTimeLabel;
        //娱乐网站监测
        private System.Windows.Forms.CheckBox entertainmentSite;
        //开始时间timePicker
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        //网络游戏监测
        private System.Windows.Forms.CheckBox networkGames;
        //开始监测
        private System.Windows.Forms.Button startCurrentMonitoring;
        //停止监测
        private System.Windows.Forms.Button stopCurrentMonitoring;
        //监测结果GroupBox
        private System.Windows.Forms.GroupBox monitoringResultsGroupBox;
        //DateTimeString
        public string startDateTime;

        //结束时间timePicker
        private System.Windows.Forms.DateTimePicker stopDateTimePicker;
        private System.Windows.Forms.GroupBox recordGroupBox;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label designatesourceIPLabel;
        private System.Windows.Forms.Label designatedestinationIPLabel;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Button recordDownButton;
        private System.Windows.Forms.Button recordUpButton;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.GroupBox currentMonitoringGroupBox;
        private System.Windows.Forms.Button currentDownButton;
        private System.Windows.Forms.Button currentUpButton;

        //查询记录string
        private string recordButtonString = "recordButton";
        private string startCurrentMonitoringString = "startCurrentMonitoring";
        private string stopCurrentMonitoringString = "stopCurrentMonitoring";
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView monitoringResultslistView;
        private System.Windows.Forms.Label 查询筛选;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowSourceIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDestinationIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDetailReason;
    }
}