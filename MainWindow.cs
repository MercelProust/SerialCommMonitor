using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using NLog;
using System.Threading;

namespace SerialCommMonitor
{
    public partial class MainWindow : Form
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        private static SerialPort serialPort1 = null;

        private static SerialPort serialPort2 = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            rtxtLog.Text = "";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            String[] serialPorts = SerialPortUtils.GetPort();

            rtxtLog.MaxLength = 102400;

            if (serialPorts.Length > 0)
            {
                cbCom1.Items.AddRange(serialPorts);
                cbCom2.Items.AddRange(serialPorts);
            }
            else
            {
                MessageBox.Show("系统内无可用串口，请检查串口内容");
            }

            cbBaudrate.SelectedIndex = 0;
            cbCheckBit.SelectedIndex = 0;
            cbDataBit.SelectedIndex = 0;
            cbFlowControl.SelectedIndex = 0;
            cbStopBit.SelectedIndex = 0;
            rtxtLog.Text = "";

            SetTextEvent += new SetTextCallback(SetText);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "开始")
            {
                startProcess();
            }
            else
            {
                stopProcess();
            }

            return;
        }

        private void startProcess()
        {
            String comName1 = cbCom1.Text;
            String comName2 = cbCom2.Text;
            int baudrate = int.Parse(cbBaudrate.Text);
            Parity parity = Parity.None;
            int dataBit = int.Parse(cbDataBit.Text);
            StopBits stopBits = StopBits.None;

            // 校验画面各项选择项目
            if (!checkSettingItmes())
            {
                return;
            }

            btnStart.Text = "停止";

            if (cbCheckBit.Text == "None")
            {
                parity = Parity.None;
            }
            else if (cbCheckBit.Text == "Even")
            {
                parity = Parity.Even;
            }
            else if (cbCheckBit.Text == "Odd")
            {
                parity = Parity.Odd;
            }
            else if (cbCheckBit.Text == "Mark")
            {
                parity = Parity.Mark;
            }
            else if (cbCheckBit.Text == "Space")
            {
                parity = Parity.Space;
            }

            if (cbStopBit.Text == "")
            {
                stopBits = StopBits.None;
            }
            else if (cbStopBit.Text == "1")
            {
                stopBits = StopBits.One;
            }
            else if (cbStopBit.Text == "1.5")
            {
                stopBits = StopBits.OnePointFive;
            }
            else if (cbStopBit.Text == "2")
            {
                stopBits = StopBits.Two;
            }

            // 确保串口关闭，准备重新打开
            closeSerialPorts();

            if (!openSerialPort(out serialPort1, comName1, baudrate, parity, dataBit, stopBits))
            {
                MessageBox.Show("串口1打开失败，请停止后重试");
                return;
            }
            if (!openSerialPort(out serialPort2, comName2, baudrate, parity, dataBit, stopBits))
            {
                MessageBox.Show("串口2打开失败，请停止后重试");
                return;
            }

            StopSerialPortThread();
            StartSerialPortThread();
        }

        private void stopProcess()
        {
            closeSerialPorts();
            StopSerialPortThread();
            btnStart.Text = "开始";
        }

        private bool checkSettingItmes()
        {
            bool rc = true;

            if (cbCom1.Text == "" || cbCom2.Text == "")
            {
                MessageBox.Show("请选择串口");
                return false;
            }

            if (cbBaudrate.Text == "")
            {
                MessageBox.Show("请选择波特率");
                return false;
            }

            if (cbCheckBit.Text == "")
            {
                MessageBox.Show("请选择校验位");
                return false;
            }

            if (cbDataBit.Text == "")
            {
                MessageBox.Show("请选择数据位");
                return false;
            }

            if (cbFlowControl.Text == "")
            {
                MessageBox.Show("请选择流控制");
                return false;
            }

            return rc;
        }

        private int closeSerialPorts()
        {
            int rc = 0;

            if (null != serialPort1)
            {
                serialPort1.Close();
                serialPort1 = null;
            }

            if (null != serialPort2)
            {
                serialPort2.Close();
                serialPort2 = null;
            }

            return rc;
        }

        private bool openSerialPort(out SerialPort serialPort, String comName, int baudrate, Parity parity, int dataBit, StopBits stopBits)
        {
            bool isSucceed = true;
            SerialPort port = null;

            try
            {
                port = new SerialPort(comName, baudrate, parity, dataBit, stopBits);
                port.Open();
                serialPort = port;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                isSucceed = false;
                serialPort = null;
            }


            return isSucceed;
        }

        delegate void SetTextCallback(string text, Color color);
        event SetTextCallback SetTextEvent;

        private void SetText(string log, Color color)
        {
            try
            {

                if (this.rtxtLog.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { log, color });
                }
                else
                {

                    try
                    {
                        log = log.Replace('\0', ' ');
                        log = log.Replace('\r', ' ');
                        log = log.Replace('\n', ' ');

                        Monitor.Enter(rtxtLog);
                        rtxtLog.AppendText(log + "\n");
                        //rtxtLog.Text = rtxtLog.Text + log;
                        rtxtLog.Select(rtxtLog.Text.Length - log.Length, log.Length);
                        rtxtLog.SelectionColor = color;
                        if (rtxtLog.Text.Length > 100000)
                        {
                            rtxtLog.Text.Remove(0, 10000);
                        }
                    }
                    catch (Exception ee)
                    {
                        Console.WriteLine(ee.Message + "\n" + ee.StackTrace);
                    }
                    finally
                    {
                        Monitor.Exit(rtxtLog);
                    }
                    logger.Info(log);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void updateLog(String comName, byte[] buff, Color color)
        {
            String time = StringUtils.getNowDateString();

            if (null == buff || buff.Length <= 0)
            {
                return;
            }

            String hexLog = StringUtils.bytes2HexString(buff);
            String asciiLog = StringUtils.bytes2ASCIIString(buff);
            String log = time + "," + comName + ":\n" + "hex log:" + hexLog + "\nasciilog:" + asciiLog;
            SetText(log, color);
        }

        private void StopSerialPortThread()
        {
            isThreadRun = false;
            Thread.Sleep(1000);
            serialProcess = null;
        }

        private void StartSerialPortThread()
        {
            StopSerialPortThread();


            isThreadRun = true;
            serialProcess = new Thread(SerialPortProcessThread);
            serialProcess.Start();
        }

        private Thread serialProcess;

        public bool isThreadRun = true;


        public void SerialPortProcessThread()
        {
            int count;
            byte[] buff = new byte[409600];

            while (isThreadRun)
            {
                try
                {
                    count = serialPort1.BytesToRead;
                    if (count > 0)
                    {
                        if (count > 409600)
                        {
                            count = 409600;
                        }
                        int rc = serialPort1.Read(buff, 0, count);
                        if (rc > 0)
                        {
                            byte[] b = new byte[rc];
                            Array.Copy(buff, b, rc);
                            updateLog("串口1", b, Color.Red);
                            serialPort2.Write(b, 0, rc);
                        }
                    }

                    count = serialPort2.BytesToRead;
                    if (count > 0)
                    {
                        if (count > 409600)
                        {
                            count = 409600;
                        }
                        int rc = serialPort2.Read(buff, 0, count);
                        if (rc > 0)
                        {
                            byte[] b = new byte[rc];
                            Array.Copy(buff, b, rc);
                            updateLog("串口2", b, Color.Blue);
                            serialPort1.Write(b, 0, rc);
                        }
                    }

                    Thread.Sleep(5);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
                }

            }

            return;
        }
    }
}
