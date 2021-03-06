﻿namespace MySniffer
{
    partial class QQForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.recordGroupBox = new System.Windows.Forms.GroupBox();
            this.currentMonitoringGroupBox = new System.Windows.Forms.GroupBox();
            this.startCurrentMonitoring = new System.Windows.Forms.Button();
            this.stopCurrentMonitoring = new System.Windows.Forms.Button();
            this.monitoringResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.monitoringResultslistView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.recordButton = new System.Windows.Forms.Button();
            this.designatesourceIPLabel = new System.Windows.Forms.Label();
            this.qqNumTextBox = new System.Windows.Forms.TextBox();
            this.stopDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.stopTimeLabel = new System.Windows.Forms.Label();
            this.qqLogoutCheckBox = new System.Windows.Forms.CheckBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.qqLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.rowTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowQQnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recordGroupBox.SuspendLayout();
            this.currentMonitoringGroupBox.SuspendLayout();
            this.monitoringResultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringResultslistView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // recordGroupBox
            // 
            this.recordGroupBox.Controls.Add(this.monitoringResultsGroupBox);
            this.recordGroupBox.Controls.Add(this.currentMonitoringGroupBox);
            this.recordGroupBox.Controls.Add(this.label1);
            this.recordGroupBox.Controls.Add(this.recordButton);
            this.recordGroupBox.Controls.Add(this.designatesourceIPLabel);
            this.recordGroupBox.Controls.Add(this.qqNumTextBox);
            this.recordGroupBox.Controls.Add(this.stopDateTimePicker);
            this.recordGroupBox.Controls.Add(this.startTimeLabel);
            this.recordGroupBox.Controls.Add(this.stopTimeLabel);
            this.recordGroupBox.Controls.Add(this.qqLogoutCheckBox);
            this.recordGroupBox.Controls.Add(this.startDateTimePicker);
            this.recordGroupBox.Controls.Add(this.qqLoginCheckBox);
            this.recordGroupBox.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recordGroupBox.ForeColor = System.Drawing.Color.White;
            this.recordGroupBox.Location = new System.Drawing.Point(12, 58);
            this.recordGroupBox.Name = "recordGroupBox";
            this.recordGroupBox.Size = new System.Drawing.Size(1078, 622);
            this.recordGroupBox.TabIndex = 16;
            this.recordGroupBox.TabStop = false;
            this.recordGroupBox.Text = "记录查询";
            // 
            // currentMonitoringGroupBox
            // 
            this.currentMonitoringGroupBox.Controls.Add(this.startCurrentMonitoring);
            this.currentMonitoringGroupBox.Controls.Add(this.stopCurrentMonitoring);
            this.currentMonitoringGroupBox.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentMonitoringGroupBox.ForeColor = System.Drawing.Color.White;
            this.currentMonitoringGroupBox.Location = new System.Drawing.Point(3, 386);
            this.currentMonitoringGroupBox.Name = "currentMonitoringGroupBox";
            this.currentMonitoringGroupBox.Size = new System.Drawing.Size(300, 179);
            this.currentMonitoringGroupBox.TabIndex = 17;
            this.currentMonitoringGroupBox.TabStop = false;
            this.currentMonitoringGroupBox.Text = "实时监测";
            // 
            // startCurrentMonitoring
            // 
            this.startCurrentMonitoring.Font = new System.Drawing.Font("华文楷体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startCurrentMonitoring.ForeColor = System.Drawing.Color.Black;
            this.startCurrentMonitoring.Location = new System.Drawing.Point(42, 33);
            this.startCurrentMonitoring.Name = "startCurrentMonitoring";
            this.startCurrentMonitoring.Size = new System.Drawing.Size(200, 32);
            this.startCurrentMonitoring.TabIndex = 4;
            this.startCurrentMonitoring.Text = "开始监测";
            this.startCurrentMonitoring.UseVisualStyleBackColor = true;
            // 
            // stopCurrentMonitoring
            // 
            this.stopCurrentMonitoring.BackColor = System.Drawing.Color.Silver;
            this.stopCurrentMonitoring.Font = new System.Drawing.Font("华文楷体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopCurrentMonitoring.ForeColor = System.Drawing.Color.Black;
            this.stopCurrentMonitoring.Location = new System.Drawing.Point(41, 141);
            this.stopCurrentMonitoring.Name = "stopCurrentMonitoring";
            this.stopCurrentMonitoring.Size = new System.Drawing.Size(200, 32);
            this.stopCurrentMonitoring.TabIndex = 5;
            this.stopCurrentMonitoring.Text = "结束监测";
            this.stopCurrentMonitoring.UseVisualStyleBackColor = false;
            // 
            // monitoringResultsGroupBox
            // 
            this.monitoringResultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monitoringResultsGroupBox.Controls.Add(this.monitoringResultslistView);
            this.monitoringResultsGroupBox.Controls.Add(this.panel2);
            this.monitoringResultsGroupBox.Font = new System.Drawing.Font("华文楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monitoringResultsGroupBox.ForeColor = System.Drawing.Color.White;
            this.monitoringResultsGroupBox.Location = new System.Drawing.Point(309, 122);
            this.monitoringResultsGroupBox.Name = "monitoringResultsGroupBox";
            this.monitoringResultsGroupBox.Size = new System.Drawing.Size(763, 695);
            this.monitoringResultsGroupBox.TabIndex = 16;
            this.monitoringResultsGroupBox.TabStop = false;
            this.monitoringResultsGroupBox.Text = "检测结果";
            // 
            // monitoringResultslistView
            // 
            this.monitoringResultslistView.AllowUserToAddRows = false;
            this.monitoringResultslistView.AllowUserToOrderColumns = true;
            this.monitoringResultslistView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("华文楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.monitoringResultslistView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.monitoringResultslistView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monitoringResultslistView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowTime,
            this.rowIP,
            this.rowQQnumber,
            this.rowLogin});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("华文楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.monitoringResultslistView.DefaultCellStyle = dataGridViewCellStyle22;
            this.monitoringResultslistView.Location = new System.Drawing.Point(3, 31);
            this.monitoringResultslistView.Name = "monitoringResultslistView";
            this.monitoringResultslistView.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("华文楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.monitoringResultslistView.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.monitoringResultslistView.RowHeadersVisible = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.monitoringResultslistView.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.monitoringResultslistView.RowTemplate.Height = 23;
            this.monitoringResultslistView.ShowEditingIcon = false;
            this.monitoringResultslistView.Size = new System.Drawing.Size(761, 452);
            this.monitoringResultslistView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(38, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "QQ记录筛选";
            // 
            // recordButton
            // 
            this.recordButton.Font = new System.Drawing.Font("华文楷体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recordButton.ForeColor = System.Drawing.Color.Black;
            this.recordButton.Location = new System.Drawing.Point(34, 275);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(200, 32);
            this.recordButton.TabIndex = 15;
            this.recordButton.Text = "查询记录";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // designatesourceIPLabel
            // 
            this.designatesourceIPLabel.AutoSize = true;
            this.designatesourceIPLabel.Font = new System.Drawing.Font("华文楷体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.designatesourceIPLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.designatesourceIPLabel.Location = new System.Drawing.Point(36, 188);
            this.designatesourceIPLabel.Name = "designatesourceIPLabel";
            this.designatesourceIPLabel.Size = new System.Drawing.Size(103, 19);
            this.designatesourceIPLabel.TabIndex = 12;
            this.designatesourceIPLabel.Text = "指定QQ号码";
            // 
            // qqNumTextBox
            // 
            this.qqNumTextBox.ForeColor = System.Drawing.Color.Black;
            this.qqNumTextBox.Location = new System.Drawing.Point(35, 216);
            this.qqNumTextBox.Multiline = true;
            this.qqNumTextBox.Name = "qqNumTextBox";
            this.qqNumTextBox.Size = new System.Drawing.Size(200, 24);
            this.qqNumTextBox.TabIndex = 11;
            // 
            // stopDateTimePicker
            // 
            this.stopDateTimePicker.Font = new System.Drawing.Font("华文楷体", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopDateTimePicker.Location = new System.Drawing.Point(309, 66);
            this.stopDateTimePicker.Name = "stopDateTimePicker";
            this.stopDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.stopDateTimePicker.TabIndex = 10;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.startTimeLabel.Font = new System.Drawing.Font("华文楷体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startTimeLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.startTimeLabel.Location = new System.Drawing.Point(38, 44);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(77, 19);
            this.startTimeLabel.TabIndex = 7;
            this.startTimeLabel.Text = "开始日期";
            // 
            // stopTimeLabel
            // 
            this.stopTimeLabel.AutoSize = true;
            this.stopTimeLabel.Font = new System.Drawing.Font("华文楷体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopTimeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.stopTimeLabel.Location = new System.Drawing.Point(306, 44);
            this.stopTimeLabel.Name = "stopTimeLabel";
            this.stopTimeLabel.Size = new System.Drawing.Size(77, 19);
            this.stopTimeLabel.TabIndex = 9;
            this.stopTimeLabel.Text = "结束日期";
            // 
            // qqLogoutCheckBox
            // 
            this.qqLogoutCheckBox.AutoSize = true;
            this.qqLogoutCheckBox.Font = new System.Drawing.Font("华文楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qqLogoutCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.qqLogoutCheckBox.Location = new System.Drawing.Point(147, 144);
            this.qqLogoutCheckBox.Name = "qqLogoutCheckBox";
            this.qqLogoutCheckBox.Size = new System.Drawing.Size(103, 27);
            this.qqLogoutCheckBox.TabIndex = 2;
            this.qqLogoutCheckBox.Text = "QQ下线";
            this.qqLogoutCheckBox.UseVisualStyleBackColor = true;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("华文楷体", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startDateTimePicker.Location = new System.Drawing.Point(41, 66);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.startDateTimePicker.TabIndex = 8;
            // 
            // qqLoginCheckBox
            // 
            this.qqLoginCheckBox.AutoSize = true;
            this.qqLoginCheckBox.Font = new System.Drawing.Font("华文楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qqLoginCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.qqLoginCheckBox.Location = new System.Drawing.Point(42, 144);
            this.qqLoginCheckBox.Name = "qqLoginCheckBox";
            this.qqLoginCheckBox.Size = new System.Drawing.Size(103, 27);
            this.qqLoginCheckBox.TabIndex = 1;
            this.qqLoginCheckBox.Text = "QQ上线";
            this.qqLoginCheckBox.UseVisualStyleBackColor = true;
            // 
            // rowTime
            // 
            this.rowTime.HeaderText = "时间";
            this.rowTime.Name = "rowTime";
            this.rowTime.ReadOnly = true;
            this.rowTime.Width = 190;
            // 
            // rowIP
            // 
            this.rowIP.HeaderText = "IP地址";
            this.rowIP.Name = "rowIP";
            this.rowIP.ReadOnly = true;
            this.rowIP.Width = 190;
            // 
            // rowQQnumber
            // 
            this.rowQQnumber.HeaderText = "QQ号码";
            this.rowQQnumber.Name = "rowQQnumber";
            this.rowQQnumber.ReadOnly = true;
            this.rowQQnumber.Width = 190;
            // 
            // rowLogin
            // 
            this.rowLogin.HeaderText = "上/下 线";
            this.rowLogin.Name = "rowLogin";
            this.rowLogin.ReadOnly = true;
            this.rowLogin.Width = 190;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 45);
            this.panel1.TabIndex = 17;
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
            this.button2.Location = new System.Drawing.Point(1023, 0);
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
            this.button1.Location = new System.Drawing.Point(1070, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "×";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(3, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 55);
            this.panel2.TabIndex = 1;
            // 
            // QQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1117, 692);
            this.Controls.Add(this.recordGroupBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QQForm";
            this.Text = "QQForm";
            this.recordGroupBox.ResumeLayout(false);
            this.recordGroupBox.PerformLayout();
            this.currentMonitoringGroupBox.ResumeLayout(false);
            this.monitoringResultsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monitoringResultslistView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox recordGroupBox;
        private System.Windows.Forms.GroupBox currentMonitoringGroupBox;
        private System.Windows.Forms.Button startCurrentMonitoring;
        private System.Windows.Forms.Button stopCurrentMonitoring;
        private System.Windows.Forms.GroupBox monitoringResultsGroupBox;
        private System.Windows.Forms.DataGridView monitoringResultslistView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Label designatesourceIPLabel;
        private System.Windows.Forms.TextBox qqNumTextBox;
        private System.Windows.Forms.DateTimePicker stopDateTimePicker;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label stopTimeLabel;
        private System.Windows.Forms.CheckBox qqLogoutCheckBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.CheckBox qqLoginCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowQQnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}