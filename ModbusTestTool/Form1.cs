using ModbusTestTool.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using System.Collections;

namespace ModbusTestTool
{
    public partial class Form1 : Form
    {
        public static bool AUTO = true;
        public Form1()
        {
            InitializeComponent();
        }

        public static string ComboBoxModbusCode_1 = "03";
        public static string ComboBoxModbusCode_2 = "03";
        public static string ComboBoxModbusCode_3 = "03";
        public static string ComboBoxModbusCode_4 = "03";
        public static string ComboBoxModbusCode_5 = "03";

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
                bool v = PortUtils.Open(port, MODBUS_RATE, dataBits, parityData, stopBitsData, new SerialDataReceivedEventHandler(CommDataReceived));
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
            //默认选中1
            this.radioButton1.Checked = true;
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
            //加载modbus功能码
            object[] code = new object[]{
                    "01",
                    "02",
                    "03",
                    "04",
                    "05",
                    "06",
                    "0F",
                    "10"
            };
            this.comboBoxModbusCode1.Items.AddRange(code);
            this.comboBoxModbusCode1.SelectedIndex = 2;
            this.comboBoxModbusCode2.Items.AddRange(code);
            this.comboBoxModbusCode2.SelectedIndex = 2;
            this.comboBoxModbusCode3.Items.AddRange(code);
            this.comboBoxModbusCode3.SelectedIndex = 2;
            this.comboBoxModbusCode4.Items.AddRange(code);
            this.comboBoxModbusCode4.SelectedIndex = 2;
            this.comboBoxModbusCode5.Items.AddRange(code);
            this.comboBoxModbusCode5.SelectedIndex = 2;
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
                this.comboBoxDataBits.Enabled = false;
            }
            else
            {
                commandLog("关闭串口=" + this.comboBoxPort.Text);
                this.buttonSwitch.Text = "打开";
                this.comboBoxPort.Enabled = true;
                this.comboBoxBaudRate.Enabled = true;
                this.comboBoxParity.Enabled = true;
                this.comboBoxStopBits.Enabled = true;
                this.comboBoxDataBits.Enabled = true;
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
            commandLog("收←◆ " + accept);
            if (AUTO)
            {
                sendData(bytes[0],true);
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
            sendData(1, false);
        }

        /// <summary>
        /// 主动发送
        /// </summary>
        public void sendData(int address, bool auto)
        {
            //发送
            try
            {
                string vHex = GetCmdInfo(address, auto).Replace(" ", string.Empty);
                if (vHex == "")
                {
                    return;
                }
                byte[] vs = StringToByteArray(vHex);
                //增加crc
                ushort crcCode = CrcCheck.Check(vs, vs.Length);
                byte crcOne;
                byte crcTwo;
                FromUshortLittle(crcCode, out crcOne, out crcTwo);
                byte[] value = new byte[vs.Length + 2];
                vs.CopyTo(value, 0);
                value[value.Length - 2] = crcOne;
                value[value.Length - 1] = crcTwo;
                SerialPort serialPort = PortUtils.GetPort();
                serialPort.Write(value, 0, value.Length);
                string hexString = BitConverter.ToString(value).Replace("-", " ");
                commandLog("发→◇ " + hexString);
            }
            catch (Exception et)
            {
                commandLog("hex转换错误！" + et.Message);
            }
        }

        /// <summary>
        /// 获取命令
        /// </summary>
        /// <returns></returns>
        public string GetCmdInfo(int address, bool auto)
        {
            if (address < 0 || address > 254)
            {
                MessageBox.Show("地址应该在1-254区间");
                return "";
            }
            if (auto)
            {
                //自动应答
                //地址
                string tbma1 = this.textBoxModBusAddress1.Text.Trim();
                string tbma2 = this.textBoxModBusAddress2.Text.Trim();
                string tbma3 = this.textBoxModBusAddress3.Text.Trim();
                string tbma4 = this.textBoxModBusAddress4.Text.Trim();
                string tbma5 = this.textBoxModBusAddress5.Text.Trim();
                //功能码
                string cbmc1 = ComboBoxModbusCode_1;
                string cbmc2 = ComboBoxModbusCode_2;
                string cbmc3 = ComboBoxModbusCode_3;
                string cbmc4 = ComboBoxModbusCode_4;
                string cbmc5 = ComboBoxModbusCode_5;
                //数据
                string tbc1 = this.textBoxCmd1.Text.Trim();
                string tbc2 = this.textBoxCmd2.Text.Trim();
                string tbc3 = this.textBoxCmd3.Text.Trim();
                string tbc4 = this.textBoxCmd4.Text.Trim();
                string tbc5 = this.textBoxCmd5.Text.Trim();
                Dictionary<string, string> CMD = new Dictionary<string, string>(10);
                if (!string.IsNullOrEmpty(tbma1))
                {
                    CMD.Add(tbma1, AddModbusData(tbma1, cbmc1, tbc1));
                }
                if (!string.IsNullOrEmpty(tbma2))
                {
                    CMD.Add(tbma2, AddModbusData(tbma2, cbmc2, tbc2));
                }
                if (!string.IsNullOrEmpty(tbma3))
                {
                    CMD.Add(tbma3, AddModbusData(tbma3, cbmc3, tbc3));
                }
                if (!string.IsNullOrEmpty(tbma4))
                {
                    CMD.Add(tbma4, AddModbusData(tbma4, cbmc4, tbc4));
                }
                if (!string.IsNullOrEmpty(tbma5))
                {
                    CMD.Add(tbma5, AddModbusData(tbma5, cbmc5, tbc5));
                }
                string value;
                CMD.TryGetValue(address.ToString(), out value);
                return value;
            }
            else
            {
                //获取选中的谁
                if (this.radioButton1.Checked)
                {
                    return AddModbusData(this.textBoxModBusAddress1.Text.Trim(), this.comboBoxModbusCode1.Text.Trim(), this.textBoxCmd1.Text.Trim());
                }
                if (this.radioButton2.Checked)
                {
                    return AddModbusData(this.textBoxModBusAddress2.Text.Trim(), this.comboBoxModbusCode2.Text.Trim(), this.textBoxCmd2.Text.Trim());
                }
                if (this.radioButton3.Checked)
                {
                    return AddModbusData(this.textBoxModBusAddress3.Text.Trim(), this.comboBoxModbusCode3.Text.Trim(), this.textBoxCmd3.Text.Trim());
                }
                if (this.radioButton4.Checked)
                {
                    return AddModbusData(this.textBoxModBusAddress4.Text.Trim(), this.comboBoxModbusCode4.Text.Trim(), this.textBoxCmd4.Text.Trim());
                }
                if (this.radioButton5.Checked)
                {
                    return AddModbusData(this.textBoxModBusAddress5.Text.Trim(), this.comboBoxModbusCode5.Text.Trim(), this.textBoxCmd5.Text.Trim());
                }
            }
            return "";
        }

        /// <summary>
        /// 合成modbus数据
        /// </summary>
        /// <param name="address">十进制</param>
        /// <param name="code">16进制</param>
        /// <param name="data">16进制</param>
        /// <returns></returns>
        private static string AddModbusData(string address, string code, string data)
        {
            string temp = int.Parse(address).ToString("X");
            if (temp.Length <= 1)
            {
                temp = "0" + temp;
            }
            return temp + " " + code + " " + data;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// short to byte[2]  返回小端
        /// </summary>
        /// <param name="number"></param>
        /// <param name="byte1"></param>
        /// <param name="byte2"></param>
        public static void FromUshortLittle(ushort number, out byte byte1, out byte byte2)
        {
            byte2 = (byte)(number >> 8);
            byte1 = (byte)(number & 255);
        }

        private void comboBoxModbusCode1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxModbusCode_1 = this.comboBoxModbusCode1.Text.Trim();
        }

        private void comboBoxModbusCode2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxModbusCode_2 = this.comboBoxModbusCode2.Text.Trim();
        }

        private void comboBoxModbusCode3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxModbusCode_3 = this.comboBoxModbusCode3.Text.Trim();
        }

        private void comboBoxModbusCode4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxModbusCode_4 = this.comboBoxModbusCode4.Text.Trim();
        }

        private void comboBoxModbusCode5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxModbusCode_5 = this.comboBoxModbusCode5.Text.Trim();
        }
    }
}
