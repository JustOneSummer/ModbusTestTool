using ModbusTestTool.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace ModbusTestTool
{
    public partial class Form1 : Form
    {
        public static bool AUTO = true;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 串口日志
        /// </summary>
        /// <param name="data"></param>
        private void commandLog(string data)
        {
            Invoke((new Action(() =>
            {
                this.richTextBox1.AppendText(DateTime.Now.ToString("HH:mm:ss.fff") + " => " + data + "\r\n");
                if (this.richTextBox1.Lines.Length >= 10000)
                {
                    this.richTextBox1.Clear();
                }
                //this.richTextBoxCommandLog.SelectionStart = this.richTextBoxCommandLog.Lines.Length;
                this.richTextBox1.ScrollToCaret();
            })));
        }

        /// <summary>
        /// 串口列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 开关按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (this.buttonSwitch.Text.Equals("打开"))
            {
                //打开串口 读取用户设置的参数
                string port = this.comboBoxPort.Text;
                if (string.IsNullOrEmpty(port))
                {
                    this.commandLog("请选择串口！");
                    return;
                }
                //读取波特率
                ushort MODBUS_RATE = ushort.Parse(this.comboBoxBaudRate.Text);
                //数据位
                ushort dataBits = ushort.Parse(this.comboBoxDataBits.Text);
                //校验
                Parity parityData;
                //停止位
                StopBits stopBitsData;
                ushort parity = 0;
                switch (this.comboBoxParity.Text)
                {
                    case "ODD":
                        parity = 1;
                        parityData = Parity.Odd;
                        break;
                    case "EVEN":
                        parity = 2;
                        parityData = Parity.Even;
                        break;
                    default:
                        parityData = Parity.None;
                        break;
                }
                double stop = 1;
                switch (this.comboBoxStopBits.Text.Trim())
                {
                    case "1.5":
                        stopBitsData = StopBits.OnePointFive;
                        stop = 1.5;
                        break;
                    case "2":
                        stop = 2;
                        stopBitsData = StopBits.Two;
                        break;
                    default:
                        stopBitsData = StopBits.One;
                        break;
                }
                //open
                bool v = PortUtils.Open(port, MODBUS_RATE, parityData, stopBitsData, new SerialDataReceivedEventHandler(CommDataReceived));
                if (v)
                {
                    //计算间隔时间 1.
                    double timeDe = (dataBits + parity + stop + 1) / MODBUS_RATE * 1000 * 3.5;
                    long time = Convert.ToInt64(Math.Ceiling(timeDe));
                    this.labelTime.Text = time.ToString();
                    portController(true);
                    //监听数据
                    SerialPort serialPort = PortUtils.GetPort();
                }
                else
                {
                    MessageBox.Show(port + "被占用!");
                    return;
                }
            }
            else
            {
                //关闭
                portController(false);
                PortUtils.Close();
            }
        }

        /// <summary>
        /// 串口加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //加载串口列表
            string[] vs = PortUtils.GetPortList();
            foreach (string data in vs)
            {
                this.comboBoxPort.Items.Add(data);
            }
            if (vs.Length >= 1)
            {
                this.comboBoxPort.SelectedIndex = 0;
            }
            //加载波特率
            this.comboBoxBaudRate.Items.Add("9600");
            this.comboBoxBaudRate.Items.Add("19200");
            this.comboBoxBaudRate.Items.Add("38400");
            this.comboBoxBaudRate.SelectedIndex = 0;
            //加载数据位
            this.comboBoxDataBits.Items.Add("8");
            this.comboBoxDataBits.Items.Add("7");
            this.comboBoxDataBits.Items.Add("6");
            this.comboBoxDataBits.Items.Add("5");
            this.comboBoxDataBits.SelectedIndex = 0;
            //加载校验位
            this.comboBoxParity.Items.Add("NONE");
            this.comboBoxParity.Items.Add("ODD");
            this.comboBoxParity.Items.Add("EVEN");
            this.comboBoxParity.SelectedIndex = 0;
            //加载停止位
            this.comboBoxStopBits.Items.Add("1");
            this.comboBoxStopBits.Items.Add("1.5");
            this.comboBoxStopBits.Items.Add("2");
            this.comboBoxStopBits.SelectedIndex = 0;
        }

        /// <summary>
        /// 鼠标点击时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxPort_MouseDown(object sender, MouseEventArgs e)
        {
            this.comboBoxPort.Items.Clear();
            foreach (string data in PortUtils.GetPortList())
            {
                this.comboBoxPort.Items.Add(data);
            }
        }

        /// <summary>
        /// 串口开关控制
        /// </summary>
        /// <param name="status">true表示打开串口</param>
        private void portController(bool status)
        {
            if (status)
            {

                commandLog("打开串口=" + this.comboBoxPort.Text);
                this.buttonSwitch.Text = "关闭";
                this.comboBoxPort.Enabled = false;
                this.comboBoxBaudRate.Enabled = false;
                this.comboBoxParity.Enabled = false;
                this.comboBoxStopBits.Enabled = false;
            }
            else
            {
                commandLog("关闭串口=" + this.comboBoxPort.Text);
                this.buttonSwitch.Text = "打开";
                this.comboBoxPort.Enabled = true;
                this.comboBoxBaudRate.Enabled = true;
                this.comboBoxParity.Enabled = true;
                this.comboBoxStopBits.Enabled = true;
            }
        }

        /// <summary>
        /// 接收数据返回
        /// </summary>
        public void DataRes()
        {
            //获取命令
            string cmd = this.textBoxCmd.Text.Trim();
            if (!string.IsNullOrEmpty(cmd))
            {
                string[] cmdArray = cmd.Split(' ');
            }
            else
            {
                commandLog("命令数据为空！");
            }
        }

        /// <summary>
        /// 数据监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CommDataReceived(Object sender, SerialDataReceivedEventArgs e)
        {
            int dataTime = int.Parse(this.labelTime.Text) + 1;
            SerialPort serialPort = PortUtils.GetPort();
            long time = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
            List<byte> bytes = new List<byte>();
            while (true)
            {
                //读数据 超时则认为读取完毕
                long tempTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
                int len = serialPort.BytesToRead;
                if (len <= 0)
                {
                    //计算时间差
                    if (tempTime - time > dataTime)
                    {
                        break;
                    }
                }
                else
                {
                    byte[] tempBuff = new byte[len];
                    serialPort.Read(tempBuff, 0, len);
                    bytes.AddRange(tempBuff);
                    time = tempTime;
                }
            }
            string accept = BitConverter.ToString(bytes.ToArray()).Replace("-", " ");
            //应答
            commandLog("accept => " + accept);
            if (AUTO)
            {
                sendData();
            }
            else
            {
                AUTO = true;
            }
        }


        /// <summary>
        /// hex string to byte array
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        /// <summary>
        /// 清空日志区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }

        /// <summary>
        /// 主动发送区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSend_Click(object sender, EventArgs e)
        {
            AUTO = false;
            sendData();
        }

        /// <summary>
        /// 主动发送
        /// </summary>
        public void sendData()
        {
            //发送
            try
            {
                string vHex = this.textBoxCmd.Text.Replace(" ", string.Empty);
                byte[] vs = StringToByteArray(vHex);
                SerialPort serialPort = PortUtils.GetPort();
                serialPort.Write(vs, 0, vs.Length);
                commandLog("send => " + this.textBoxCmd.Text);
            }
            catch (Exception et)
            {
                commandLog("hex转换错误！" + et.Message);
            }
        }
    }
}
