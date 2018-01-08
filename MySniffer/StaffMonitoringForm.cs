using SharpPcap;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MySniffer
{
    
    public partial class StaffMonitoringForm : Form
    {
        Hashtable myHt;
        public StaffMonitoringForm(Hashtable ht)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//设置窗体居屏幕中央
            myHt = ht;
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        bool beginMove = false;//初始化鼠标位置  
        int currentXPosition;
        int currentYPosition;

        Thread RealTimeDataThread;
        bool isLoadRealTimeData = false;
        object threadLock = new object();
        object bufferLock = new object();
        string[] rowsLine = new string[5];
        delegate void DataGridRowsShowHandler1(ProcessingBehave pb);
        ProcessingBehaveList<ProcessingBehave> pbList = ProcessingBehaveList<ProcessingBehave>.GetInstance();


        ///注意装箱和拆箱
        ArrayList pbListBuffer = new ArrayList();

        /// <summary>
        /// 控件可用与不可用逻辑
        /// </summary>
        /// <param name="buttionName"></param>
        private void UIConfig(string buttionName)
        {
            if (buttionName.Equals(recordButtonString))
            {
                recordUpButton.Enabled = true;
                recordDownButton.Enabled = true;
                currentUpButton.Enabled = false;
                currentDownButton.Enabled = false;
                stopCurrentMonitoring.Enabled = false;
            }
            else
            if (buttionName.Equals(startCurrentMonitoringString))
            {
                startDateTimePicker.Enabled = false;
                stopDateTimePicker.Enabled = false;
                sourceTextBox.Enabled = false;
                destinationTextBox.Enabled = false;
                networkGames.Enabled = false;
                entertainmentSite.Enabled = false;
                startCurrentMonitoring.Enabled = false;
                recordButton.Enabled = false;
                recordUpButton.Enabled = false;
                recordDownButton.Enabled = false;
                currentUpButton.Enabled = true;
                currentDownButton.Enabled = true;
                stopCurrentMonitoring.Enabled = true;
            }
            else
            {
                startDateTimePicker.Enabled = true;
                stopDateTimePicker.Enabled = true;
                sourceTextBox.Enabled = true;
                destinationTextBox.Enabled = true;
                networkGames.Enabled = true;
                entertainmentSite.Enabled = true;
                stopCurrentMonitoring.Enabled = false;
                recordButton.Enabled = true;
                startCurrentMonitoring.Enabled = true;
            }

        }

        private void StaffMonitoringForm_Load(object sender, EventArgs e)
        {
            UIConfig(recordButtonString);
            DataGridViewConfig();
        }

        private void networkGames_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void entertainmentSite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void monitoringResultslistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startMonitoring_Click(object sender, EventArgs e)
        {
            monitoringResultslistView.Rows.Clear();
            UIConfig(startCurrentMonitoringString);
            isLoadRealTimeData = true;
            LoadRealTimeData();
            //this.monitoringResultslistView.Update();  //结束数据处理，UI界面一次性绘制。 
        }

        private void LoadRealTimeData()
        {
            RealTimeDataThread = new Thread(new ThreadStart(LoadRealTimeDateThread));
            RealTimeDataThread.IsBackground = true;
            RealTimeDataThread.Start();
        }

        private void LoadRealTimeDateThread()
        {
            while (isLoadRealTimeData)
            {
                bool isShouldSleep = true;
                lock (threadLock)
                {
                    if (pbList.Count != 0)
                    {
                        isShouldSleep = false;
                    }
                }
                if (isShouldSleep)//
                {
                    Thread.Sleep(101);
                }
                else
                {
                    lock (pbList.SyncRoot)
                    {
                        lock (bufferLock)
                        {
                            pbListBuffer.AddRange(pbList);
                        }
                        foreach (ProcessingBehave pb in pbList)
                        {
                            this.BeginInvoke(new DataGridRowsShowHandler1(ShowDataRows), pb);
                        }
                        pbList.Clear();
                    }
                }
            }
        }


        private void ShowDataRows(ProcessingBehave pb)
        {
            try
            {
                rowsLine[1] = pb.UserIPA;
                rowsLine[2] = pb.UserIPB;
                rowsLine[3] = pb.Reason;
                rowsLine[0] = pb.Time;
                rowsLine[4] = pb.DetailReason;
                monitoringResultslistView.Rows.Add(rowsLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


     

        /// <summary>
        /// 需要关闭线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopMonitoring_Click(object sender, EventArgs e)
        {
            UIConfig(stopCurrentMonitoringString);
            ExitThread();
        }

        private void ExitThread()
        {
            try
            {
                isLoadRealTimeData = false;
                if (RealTimeDataThread != null && RealTimeDataThread.IsAlive)
                {
                    RealTimeDataThread.Abort();
                }
            }
            catch
            {
                MessageBox.Show("退出线程错误");
            }
        }

        private void DataGridViewConfig()
        {
            int width = this.monitoringResultslistView.Width;
            this.rowSourceIP.Width = width / monitoringResultslistView.ColumnCount;
            this.rowDestinationIP.Width = width / monitoringResultslistView.ColumnCount;
            this.rowTime.Width = width / monitoringResultslistView.ColumnCount;
            this.rowReason.Width = width / monitoringResultslistView.ColumnCount;
            this.rowDetailReason.Width = width / monitoringResultslistView.ColumnCount;
        }

        private void StaffMonitoringForm_Resize(object sender, EventArgs e)
        {
            DataGridViewConfig();
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            startDateTimePicker.Value.ToString("hh:mm:ss  MM/dd/yyyy");
        }

        private void monitoringResultslistView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            rowDetailReason.Width = monitoringResultslistView.Width - rowSourceIP.Width - rowDestinationIP.Width - rowReason.Width - rowTime.Width;
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            UIConfig(recordButtonString);

            string startDetailTime = startDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string startDayTime = startDateTimePicker.Value.ToString("yyyy-MM-dd");

            string stopDetailTime = stopDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss:ff");
            string stopDayTime = stopDateTimePicker.Value.ToString("yyyy-MM-dd");
            string sourceIP = sourceTextBox.Text;
            string destinationIP = destinationTextBox.Text;
            bool checkGame = networkGames.Checked;
            bool checkShop = entertainmentSite.Checked;

            SaveAllToSQL mysql = new SaveAllToSQL();
            List<ProcessingBehave> pblist = mysql.SearchPB(mysql.MyConnect, startDayTime, stopDetailTime, sourceIP, destinationIP, checkGame, checkShop);

            monitoringResultslistView.Rows.Clear();
            foreach (ProcessingBehave pb in pblist)
            {
                ShowDataRows(pb);
            }
        }

        private void StaffMonitoringForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UIConfig(stopCurrentMonitoringString);
            ExitThread();
        }

        private void monitoringResultslistView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (e.Button == MouseButtons.Right)//右击也可选中
            {
                monitoringResultslistView.Rows[e.RowIndex].Selected = true;
            }
            selectDataGridRow(e.RowIndex);
        }

        /// <summary>
        /// 选中一行
        /// </summary>
        /// <param name="index">选定的数据行索引值</param>
        private void selectDataGridRow(int index)
        {
            if (index < 0 || index >= monitoringResultslistView.Rows.Count || monitoringResultslistView.Rows.Count == 0)
                return;
            //获取数据包位置
            //int i = Convert.ToInt32(monitoringResultslistView.Rows[index].Cells[0].Value.ToString());
            //if (i > pbListBuffer.Count)
            //    return;
            //richTextBox1.Text = ((ProcessingBehave)pbListBuffer[index]).Caption;
        }

        private void stopDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StaffMonitoringForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //关闭窗口
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //窗口最大化和最小化的代码
            if (FormWindowState.Maximized == this.WindowState)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        //获取鼠标按下时的位置  
        private void loginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标  
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标  
            }
        }

        //获取鼠标移动到的位置  
        private void loginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x  
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标  
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        //释放鼠标时的位置  
        private void loginForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //设置初始状态  
                currentYPosition = 0;
                beginMove = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void confirmRule_Click(object sender, EventArgs e)
        {
            
            String rule1 = this.ruelText1.Text;
            String rule2 = this.comboBox1.SelectedItem.ToString();
            String rule3 = this.ruelText3.Text;
            String mixrule = rule2 + "," + rule3;
            
            Console.WriteLine("rule1 = "+ rule1);
            Console.WriteLine("rule2 = " + rule2);
            Console.WriteLine("rule3 = " + rule3);
            Console.WriteLine("mixrule = " + mixrule);
            
            myHt.Add(rule1, mixrule);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ruelText2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
