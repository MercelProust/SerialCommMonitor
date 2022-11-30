
namespace SerialCommMonitor
{
    partial class MainWindow
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCom1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCom2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSerialPorts = new System.Windows.Forms.GroupBox();
            this.gbSerialPortSetting = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFlowControl = new System.Windows.Forms.ComboBox();
            this.cbDataBit = new System.Windows.Forms.ComboBox();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.cbCheckBit = new System.Windows.Forms.ComboBox();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.gbSerialPorts.SuspendLayout();
            this.gbSerialPortSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCom1
            // 
            this.cbCom1.FormattingEnabled = true;
            this.cbCom1.Location = new System.Drawing.Point(95, 38);
            this.cbCom1.Name = "cbCom1";
            this.cbCom1.Size = new System.Drawing.Size(121, 23);
            this.cbCom1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口1";
            // 
            // cbCom2
            // 
            this.cbCom2.FormattingEnabled = true;
            this.cbCom2.Location = new System.Drawing.Point(95, 77);
            this.cbCom2.Name = "cbCom2";
            this.cbCom2.Size = new System.Drawing.Size(121, 23);
            this.cbCom2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "串口2";
            // 
            // gbSerialPorts
            // 
            this.gbSerialPorts.Controls.Add(this.label1);
            this.gbSerialPorts.Controls.Add(this.label2);
            this.gbSerialPorts.Controls.Add(this.cbCom1);
            this.gbSerialPorts.Controls.Add(this.cbCom2);
            this.gbSerialPorts.Location = new System.Drawing.Point(27, 25);
            this.gbSerialPorts.Name = "gbSerialPorts";
            this.gbSerialPorts.Size = new System.Drawing.Size(260, 121);
            this.gbSerialPorts.TabIndex = 2;
            this.gbSerialPorts.TabStop = false;
            this.gbSerialPorts.Text = "监视转发串口";
            // 
            // gbSerialPortSetting
            // 
            this.gbSerialPortSetting.Controls.Add(this.label6);
            this.gbSerialPortSetting.Controls.Add(this.label7);
            this.gbSerialPortSetting.Controls.Add(this.label5);
            this.gbSerialPortSetting.Controls.Add(this.label4);
            this.gbSerialPortSetting.Controls.Add(this.label3);
            this.gbSerialPortSetting.Controls.Add(this.cbFlowControl);
            this.gbSerialPortSetting.Controls.Add(this.cbDataBit);
            this.gbSerialPortSetting.Controls.Add(this.cbStopBit);
            this.gbSerialPortSetting.Controls.Add(this.cbCheckBit);
            this.gbSerialPortSetting.Controls.Add(this.cbBaudrate);
            this.gbSerialPortSetting.Location = new System.Drawing.Point(27, 191);
            this.gbSerialPortSetting.Name = "gbSerialPortSetting";
            this.gbSerialPortSetting.Size = new System.Drawing.Size(260, 199);
            this.gbSerialPortSetting.TabIndex = 3;
            this.gbSerialPortSetting.TabStop = false;
            this.gbSerialPortSetting.Text = "串口通信设置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "流控";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "数据位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "校验位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "波特率";
            // 
            // cbFlowControl
            // 
            this.cbFlowControl.FormattingEnabled = true;
            this.cbFlowControl.Items.AddRange(new object[] {
            "None",
            "RTS/CTS",
            "XON/XOFF"});
            this.cbFlowControl.Location = new System.Drawing.Point(95, 127);
            this.cbFlowControl.Name = "cbFlowControl";
            this.cbFlowControl.Size = new System.Drawing.Size(121, 23);
            this.cbFlowControl.TabIndex = 0;
            // 
            // cbDataBit
            // 
            this.cbDataBit.FormattingEnabled = true;
            this.cbDataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.cbDataBit.Location = new System.Drawing.Point(95, 156);
            this.cbDataBit.Name = "cbDataBit";
            this.cbDataBit.Size = new System.Drawing.Size(121, 23);
            this.cbDataBit.TabIndex = 0;
            // 
            // cbStopBit
            // 
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStopBit.Location = new System.Drawing.Point(95, 98);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(121, 23);
            this.cbStopBit.TabIndex = 0;
            // 
            // cbCheckBit
            // 
            this.cbCheckBit.FormattingEnabled = true;
            this.cbCheckBit.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.cbCheckBit.Location = new System.Drawing.Point(95, 69);
            this.cbCheckBit.Name = "cbCheckBit";
            this.cbCheckBit.Size = new System.Drawing.Size(121, 23);
            this.cbCheckBit.TabIndex = 0;
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBaudrate.Location = new System.Drawing.Point(95, 40);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(121, 23);
            this.cbBaudrate.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(27, 416);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 38);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(186, 416);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(101, 38);
            this.btnClearLog.TabIndex = 5;
            this.btnClearLog.Text = "清空日志";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // rtxtLog
            // 
            this.rtxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtLog.Location = new System.Drawing.Point(294, 13);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.ReadOnly = true;
            this.rtxtLog.Size = new System.Drawing.Size(652, 499);
            this.rtxtLog.TabIndex = 6;
            this.rtxtLog.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 524);
            this.Controls.Add(this.rtxtLog);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbSerialPortSetting);
            this.Controls.Add(this.gbSerialPorts);
            this.Name = "MainWindow";
            this.Text = "SerialCommMonitor";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gbSerialPorts.ResumeLayout(false);
            this.gbSerialPorts.PerformLayout();
            this.gbSerialPortSetting.ResumeLayout(false);
            this.gbSerialPortSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCom1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCom2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSerialPorts;
        private System.Windows.Forms.GroupBox gbSerialPortSetting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFlowControl;
        private System.Windows.Forms.ComboBox cbDataBit;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.ComboBox cbCheckBit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.RichTextBox rtxtLog;
    }
}

