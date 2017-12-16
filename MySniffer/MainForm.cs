using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SharpPcap;
using SharpPcap.LibPcap;//引用SharpPcap
using System.Windows.Forms.DataVisualization.Charting;

namespace MySniffer
{
    public partial class MainForm : Form
    {
        ICaptureDevice device;// 定义设备
        List<RawCapture> packetList = new List<RawCapture>();//捕获的数据列表
        List<RawCapture> bufferList;//缓存列表

        Thread AnalyzerThread;//分析数据的线程
        object threadLock = new object();//线程锁定
        bool isStartAnalyzer;//用于表示是否启动分析线程的标志
        DeviceMode devMode = DeviceMode.Promiscuous;//数据采集模式
        int readTimeOut = 1000;
        delegate void DataGridRowsShowHandler(RawCapture packet);
        DataBuilder rowsBulider = new DataBuilder();

        private static readonly object syncRoot = new object();

        PacketInfo pktInfo;
        uint packetIndex = 0;
        uint temp_packetIndex;


        /// <summary>
        /// QQ上下线引用
        /// </summary>
        ProcessingQQLoginLogout pqll;
        /// <summary>
        /// QQ上下线单例列表
        /// </summary>
        ProcessingQQLoginLogoutList<ProcessingQQLoginLogout> pqllList = ProcessingQQLoginLogoutList<ProcessingQQLoginLogout>.GetInstance();

        ProcessingAllDataList<ProcessingAllData> padList = ProcessingAllDataList<ProcessingAllData>.GetInstance();


        ProcessingAllData rowData;

        List<ProcessingAllData> padBufferList = new List<ProcessingAllData>();
        List<ProcessingQQLoginLogout> pqllBufferList = new List<ProcessingQQLoginLogout>();



        private int countQQ = 0;

        public MainForm()
        {
            InitializeComponent();

            
            pktInfo = new PacketInfo(this.treeView1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDevice();//加载窗体时加载网卡
        }



       


        private void loadDevice()// 获取网卡方法
        {
            try
            {
                foreach (var i in CaptureDeviceList.Instance)
                {
                    comDeviceList.Items.Add(i.Description);  //在combox中添加
                }
                if (comDeviceList.Items.Count > 0)
                {
                    comDeviceList.SelectedIndex = 0;//自动选中第一个
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        //选择网卡
        private void comDeviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            device = CaptureDeviceList.Instance[comDeviceList.SelectedIndex];
        }
        private void UIConfig(bool isStart)
        {
            comDeviceList.Enabled = !isStart;
            btnStart.Enabled = !isStart;
            btnStop.Enabled = isStart;
            btnOpen.Enabled = !isStart;
            btnSave.Enabled = !isStart;
            //checkBox1.Enabled = !isStart;

        }

        public void Clear()
        {
            if (packetList != null)
            {
                packetList.Clear();
            }
            if (bufferList != null)
            {
                bufferList.Clear();
            }
            dataGridPacket.Rows.Clear();
            treeView1.Nodes.Clear();
            richTextBox1.Text = "";
            packetIndex = 0;

        }

    


        /// <summary>
        /// 启动网卡
        /// </summary>
        private void Start()
        {
            if (device == null || device.Started)
                return;

            bufferList = new List<RawCapture>();
            Clear();//清理原有的数据
            isStartAnalyzer = true;


            StartAnalyzer();//启动分析线程


            try
            {
                device.OnPacketArrival += new PacketArrivalEventHandler(device_OnPacketArrival);
                //默认使用混杂模式，超时 1000
                device.Open(devMode, readTimeOut);
                device.StartCapture();

                UIConfig(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                UIConfig(false);
            }
            InitChart();

        }
        /// <summary>
        /// 启动分析
        /// </summary>
        private void StartAnalyzer()
        {
            AnalyzerThread = new Thread(new ThreadStart(analysrThreadMethod));
            AnalyzerThread.IsBackground = true;
            AnalyzerThread.Start();

        }
        /// <summary>
        /// 停止
        /// </summary>
        private void Stop()
        {
            try
            {
                if (device != null && device.Started)
                {
                    device.StopCapture();
                    device.Close();
                }

                isStartAnalyzer = false;
                if (AnalyzerThread !=null && AnalyzerThread.IsAlive)
                {
                    AnalyzerThread.Abort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UIConfig(false);
        }

        void device_OnPacketArrival(object sender, CaptureEventArgs e)
        {
            lock (threadLock)
            {
                bufferList.Add(e.Packet);
            }
        }

        //数据分析线程
        private void analysrThreadMethod()
        {
            while (isStartAnalyzer)
            {
                bool isShoudSleep = true;
                lock (threadLock)
                {
                    if (bufferList.Count != 0)
                        isShoudSleep = false;
                }
                if (isShoudSleep)//
                {
                    Thread.Sleep(200);
                }
                else
                {
                    List<RawCapture> tmpPacketList;
                    lock (threadLock) //获取数据
                    {
                        tmpPacketList = bufferList;
                        bufferList = new List<RawCapture>();//构建新列表
                        packetList.AddRange(tmpPacketList);
                    }
                    foreach (var i in tmpPacketList)
                    {
                        this.Invoke(new DataGridRowsShowHandler(ShowDataRows), i);

                    }
                }
            }
        }

        private void ShowDataRows(RawCapture packet)
        {


            try
            {
                temp_packetIndex = packetIndex + 1;
                dataGridPacket.Rows.Add(rowsBulider.Row(packet, temp_packetIndex));//加载DataGridRows;


                string[] rowsLinebuffer = new string[7];

                rowsLinebuffer = rowsBulider.Row(packet, ++packetIndex);
                
                if (rowsLinebuffer[1] == "TCP" || rowsLinebuffer[1] == "SMTP" || rowsLinebuffer[1] == "POP3" || rowsLinebuffer[1] == "HTTP" || rowsLinebuffer[1] == "OICQ")
                {

                    rowData = new ProcessingAllData();
                    rowData.Id = rowsLinebuffer[0];
                    rowData.Protocol = rowsLinebuffer[1];
                    rowData.Length = rowsLinebuffer[2];
                    rowData.SourceAddress = rowsLinebuffer[3];
                    rowData.DestinationAddress = rowsLinebuffer[4];
                    rowData.HardwareType = rowsLinebuffer[5];
                    rowData.Time = rowsLinebuffer[6];
                    rowData.BinaryData = packet.Data; //?
                    rowData.Data = HexConvert.ConvertToAscii(packet.Data);

                    //添加总的数据
                    lock (padList.SyncRoot)
                    {
                        padList.Add(rowData);
                    }



                    if (rowsLinebuffer[1] == "OICQ")
                    {
                        pqll = new ProcessingQQLoginLogout();
                        countQQ += pqll.Analysis(rowData);
                        if (pqll.QqLogin == 1 || pqll.QqLogin == 2)
                        {
                            lock (pqllList.SyncRoot)
                            {
                                pqllList.Add(pqll);
                                //这里写存入数据库的代码
                            }
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.qqNoticeLabel.Text = "已捕获QQ上下线记录" + countQQ + "条";

        }


        /// <summary>
        /// 将分析好的数据添加到列表
        /// </summary>
        /// <param name="packet"></param>
        private void AddDataToList(RawCapture packet)
        {
            Console.Write("AddDataToList");

            try
            {
                string[] rowsLinebuffer = new string[7];
                rowsLinebuffer = rowsBulider.Row(packet, ++packetIndex);
                if (rowsLinebuffer[1] == "TCP" || rowsLinebuffer[1] == "SMTP" || rowsLinebuffer[1] == "POP3" || rowsLinebuffer[1] == "HTTP" || rowsLinebuffer[1] == "OICQ")
                {
                    rowData = new ProcessingAllData();
                    rowData.Id = rowsLinebuffer[0];
                    rowData.Protocol = rowsLinebuffer[1];
                    rowData.Length = rowsLinebuffer[2];
                    rowData.SourceAddress = rowsLinebuffer[3];
                    rowData.DestinationAddress = rowsLinebuffer[4];
                    rowData.HardwareType = rowsLinebuffer[5];
                    rowData.Time = rowsLinebuffer[6];
                    rowData.BinaryData = packet.Data; //?
                    rowData.Data = HexConvert.ConvertToAscii(packet.Data);

                    //添加总的数据
                    lock (padList.SyncRoot)
                    {
                        padList.Add(rowData);
                    }


                    if (rowsLinebuffer[1] == "OICQ")
                    {
                        pqll = new ProcessingQQLoginLogout();
                        countQQ += pqll.Analysis(rowData);
                        if (pqll.QqLogin == 1 || pqll.QqLogin == 2)
                        {
                            lock (pqllList.SyncRoot)
                            {
                                pqllList.Add(pqll);
                                //这里写存入数据库的代码
                            }
                        }

                    }
        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.staffNoticeLabel.Text = "今日新增记录" + countBehave + "条";
            this.qqNoticeLabel.Text = "今日新增记录" + countQQ + "条";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }

        private void dataGridPacket_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (e.Button == MouseButtons.Right)//右击也可选中
            {
                dataGridPacket.Rows[e.RowIndex].Selected = true;
            }
            selectDataGridRow(e.RowIndex);
        }
        /// <summary>
        /// 选中一行
        /// </summary>
        /// <param name="index">选定的数据行索引值</param>
        private void selectDataGridRow(int index)
        {
            if (index < 0 || index > dataGridPacket.Rows.Count)
                return;
            //获取数据包位置
            int i = Convert.ToInt32(dataGridPacket.Rows[index].Cells[0].Value.ToString());
            if (i > packetList.Count)
                return;
            RawCapture rawPacket = packetList[i - 1];

            treeView1.Nodes.Clear();
            pktInfo.GetProtcolTree(rawPacket);
            richTextBox1.Text = HexConvert.ConvertToHexText(rawPacket .Data);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Pcap文件|*.pcap";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                var offDev = new SharpPcap.LibPcap.CaptureFileWriterDevice(sd.FileName);
                foreach (var i in packetList)
                {
                    offDev.Write(i);
                }
                MessageBox.Show("文件保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //打开文件
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "pcap文件|*.pcap";

            if (od.ShowDialog() == DialogResult.OK)
            {
                Clear();

                ICaptureDevice offDev = new SharpPcap.LibPcap.CaptureFileReaderDevice(od.FileName);
                RawCapture tempPacket;
                offDev.Open();
                while ((tempPacket = offDev.GetNextPacket()) != null)
                {
                    packetList.Add(tempPacket);
                    ShowDataRows(tempPacket);
                }
                offDev.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridPacket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridPacket_CancelRowEdit(object sender, QuestionEventArgs e)
        {

        }

        private void qqLoginOpenLabel_Click(object sender, EventArgs e)
        {

        }

        private void qqNoticeLabel_Click(object sender, EventArgs e)
        {

        }

        private void chartflow_Click(object sender, EventArgs e)
        {

        }

        //流量监控图   
        System.Windows.Forms.Timer chartTimer = new System.Windows.Forms.Timer();


        // <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chartTimer_Tick(object sender, EventArgs e)
        {
            int length = 0;
            if (packetList != null)
            {
                lock (syncRoot)
                {
                    foreach (RawCapture rawCapture in packetList) 
                    {
                        length += rawCapture.Data.Length;
                    }
                }

                try
                {  
                    //Random ra = new Random();
                    Series series = chartflow.Series[0];
                    //series.Points.AddXY(DateTime.Now, ra.Next(1, 10));
                    series.Points.AddXY(DateTime.Now, length / 1024);
                    chartflow.ChartAreas[0].AxisX.ScaleView.Position = series.Points.Count - 5;
                }
                catch
                {

                }
            }
        }



        private void InitChart()
        {
            DateTime time = DateTime.Now;
            chartTimer.Interval = 1000;
            chartTimer.Tick += chartTimer_Tick;

            Series series = chartflow.Series[0];
            series.ChartType = SeriesChartType.Spline;
            series.IsVisibleInLegend = false;

            chartflow.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chartflow.ChartAreas[0].AxisX.ScaleView.Size = 5;
            chartflow.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chartflow.ChartAreas[0].AxisX.ScrollBar.Enabled = true;

            chartTimer.Start();
        }

        
    }
}
