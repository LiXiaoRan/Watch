using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MySniffer
{
    public partial class QQForm : Form
    {
        Thread RealTimeDataThread;
        ProcessingQQLoginLogoutList<ProcessingQQLoginLogout> qqllList = ProcessingQQLoginLogoutList<ProcessingQQLoginLogout>.GetInstance();
        delegate void DataGridRowsShowHandler1(ProcessingQQLoginLogout pqll);
        bool isLoadRealTimeData = false;
        object threadLock = new object();
        object bufferLock = new object();
        string[] rowsLine = new string[4];
        /// <summary>
        /// 
        /// </summary>
        ArrayList qqllListBuffer = new ArrayList();

        //查询记录string
        private string recordButtonString = "recordButton";
        private string startCurrentMonitoringString = "startCurrentMonitoring";
        private string stopCurrentMonitoringString = "stopCurrentMonitoring";




        public QQForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//设置窗体居屏幕中央
            //this.Opacity = 0.92;
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        bool beginMove = false;//初始化鼠标位置  
        int currentXPosition;
        int currentYPosition;

        private void QQForm_Load(object sender, EventArgs e)
        {
            UIConfig(recordButtonString);
            DataGridViewConfig();
        }

        private void QQForm_Resize(object sender, EventArgs e)
        {
            DataGridViewConfig();
        }

        private void DataGridViewConfig()
        {
            int width = this.monitoringResultslistView.Width;
            this.rowIP.Width = width / monitoringResultslistView.ColumnCount;
            this.rowQQnumber.Width = width / monitoringResultslistView.ColumnCount;
            this.rowTime.Width = width / monitoringResultslistView.ColumnCount;
            this.rowLogin.Width = width / monitoringResultslistView.ColumnCount;
        }

        private void UIConfig(string buttionName)
        {
            if (buttionName.Equals(recordButtonString))
            {
                // recordUpButton.Enabled = true;
                // recordDownButton.Enabled = true;
                //  currentUpButton.Enabled = false;
                //currentDownButton.Enabled = false;
                stopCurrentMonitoring.Enabled = false;
            }
            else
            if (buttionName.Equals(startCurrentMonitoringString))
            {
                startDateTimePicker.Enabled = false;
                stopDateTimePicker.Enabled = false;
                qqNumTextBox.Enabled = false;
                qqLoginCheckBox.Enabled = false;
                qqLogoutCheckBox.Enabled = false;
                startCurrentMonitoring.Enabled = false;
                recordButton.Enabled = false;
                //recordUpButton.Enabled = false;
                // recordDownButton.Enabled = false;
                // currentUpButton.Enabled = true;
                //currentDownButton.Enabled = true;
                stopCurrentMonitoring.Enabled = true;
            }
            else
            {
                startDateTimePicker.Enabled = true;
                stopDateTimePicker.Enabled = true;
                qqNumTextBox.Enabled = true;
                qqLoginCheckBox.Enabled = true;
                qqLogoutCheckBox.Enabled = true;
                stopCurrentMonitoring.Enabled = false;
                recordButton.Enabled = true;
                startCurrentMonitoring.Enabled = true;
            }

        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            UIConfig(recordButtonString);

            string startDetailTime = startDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string startDayTime = startDateTimePicker.Value.ToString("yyyy-MM-dd");

            string stopDetailTime = stopDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string stopDayTime = stopDateTimePicker.Value.ToString("yyyy-MM-dd");

            string qqNum = qqNumTextBox.Text;
            bool qqLogin = qqLoginCheckBox.Checked;
            bool qqLogout = qqLogoutCheckBox.Checked;
            SaveAllToSQL mySql = new SaveAllToSQL();
            List<ProcessingQQLoginLogout> qqResultList = mySql.SearchQQ(mySql.MyConnect, startDayTime, stopDetailTime, qqNum, qqLogin, qqLogout);

            monitoringResultslistView.Rows.Clear();
            foreach (ProcessingQQLoginLogout pqll in qqResultList)
            {
                ShowDataRows(pqll);
            }
        }

        private void startCurrentMonitoring_Click(object sender, EventArgs e)
        {
            monitoringResultslistView.Rows.Clear();
            UIConfig(startCurrentMonitoringString);
            LoadRealData();
        }

        private void LoadRealData()
        {
            isLoadRealTimeData = true;
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
                    if (qqllList.Count != 0)
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
                    lock (qqllList.SyncRoot)
                    {
                        lock (bufferLock)
                        {
                            qqllListBuffer.AddRange(qqllList);
                        }
                        foreach (ProcessingQQLoginLogout qqll in qqllList)
                        {
                            this.BeginInvoke(new DataGridRowsShowHandler1(ShowDataRows), qqll);
                        }
                        //清除传递的数据
                        qqllList.Clear();
                    }
                }
            }
        }

        private void ShowDataRows(ProcessingQQLoginLogout qqll)
        {
            try
            {
                rowsLine[0] = qqll.Time;
                rowsLine[1] = qqll.QqIP;
                rowsLine[2] = qqll.QqID;
                if (qqll.QqLogin == 1)
                {
                    rowsLine[3] = "上线";
                }
                else
                {
                    rowsLine[3] = "下线";
                }

                monitoringResultslistView.Rows.Add(rowsLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void stopCurrentMonitoring_Click(object sender, EventArgs e)
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
                //Debug.WriteLine();
                MessageBox.Show("退出出现异常");
            }
        }

        private void monitoringResultslistView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            this.rowLogin.Width = monitoringResultslistView.Width - rowIP.Width - rowTime.Width - rowIP.Width;
        }

        private void recordButton_Click_1(object sender, EventArgs e)
        {
            UIConfig(recordButtonString);

            string startDetailTime = startDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string startDayTime = startDateTimePicker.Value.ToString("yyyy-MM-dd");

            string stopDetailTime = stopDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string stopDayTime = stopDateTimePicker.Value.ToString("yyyy-MM-dd");

            string qqNum = qqNumTextBox.Text;
            bool qqLogin = qqLoginCheckBox.Checked;
            bool qqLogout = qqLogoutCheckBox.Checked;
            SaveAllToSQL mySql = new SaveAllToSQL();
            List<ProcessingQQLoginLogout> qqResultList = mySql.SearchQQ(mySql.MyConnect, startDayTime, stopDetailTime, qqNum, qqLogin, qqLogout);

            monitoringResultslistView.Rows.Clear();
            foreach (ProcessingQQLoginLogout pqll in qqResultList)
            {
                ShowDataRows(pqll);
            }
        }



        private void currentMonitoringGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void startCurrentMonitoring_Click_1(object sender, EventArgs e)
        {
            monitoringResultslistView.Rows.Clear();
            UIConfig(startCurrentMonitoringString);
            LoadRealData();
        }

        private void stopCurrentMonitoring_Click_1(object sender, EventArgs e)
        {
            UIConfig(stopCurrentMonitoringString);
            ExitThread();
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
    }
}

