using System;
using System.IO.Ports;

namespace ModbusTestTool.utils
{
    class PortUtils
    {
        public static string[] GetPortList()
        {
            return SerialPort.GetPortNames();
        }
        /// <summary>
        /// 串口
        /// </summary>
        private static SerialPort Serial_Port = null;

        /// <summary>
        /// 获取串口
        /// </summary>
        /// <returns></returns>
        public static SerialPort GetPort()
        {
            if (Serial_Port == null)
            {
                throw new ArgumentNullException("串口对象为空！");
            }
            return Serial_Port;
        }

        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="port">串口名称</param>
        /// <param name="baudRate">波特率</param>
        /// <param name="parity">校验位</param>
        /// <param name="stopBits">停止位</param>
        /// <returns>串口是否正常打开</returns>
        public static bool Open(string port, int baudRate, Parity parity, StopBits stopBits, SerialDataReceivedEventHandler dataReceivedEventHandler)
        {
            if (Serial_Port != null)
            {
                Close();
            }
            Serial_Port = new SerialPort(port)
            {
                BaudRate = baudRate,
                DataBits = 8,
                Parity = parity,
                StopBits = stopBits
            };
            if (Serial_Port.IsOpen)
            {
                return false;
            }
            Serial_Port.ReceivedBytesThreshold = 1;
            Serial_Port.DataReceived += dataReceivedEventHandler;
            try
            {
                Serial_Port.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

            /// <summary>
            /// 打开串口
            /// </summary>
            /// <param name="port">串口名称</param>
            /// <param name="baudRate">波特率</param>
            /// <param name="parity">校验位</param>
            /// <param name="stopBits">停止位</param>
            /// <returns>串口是否正常打开</returns>
            public static bool Open(string port, int baudRate, Parity parity, StopBits stopBits)
        {
            if (Serial_Port != null)
            {
                Close();
            }
            Serial_Port = new SerialPort(port)
            {
                BaudRate = baudRate,
                DataBits = 8,
                Parity = parity,
                StopBits = stopBits
            };
            if (Serial_Port.IsOpen)
            {
                return false;
            }
            try
            {
                Serial_Port.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <returns></returns>
        public static void Close()
        {
            if (Serial_Port != null)
            {
                Serial_Port.Close();
            }
        }
    }
}
