
namespace ModbusTestTool
{
    partial class Form1
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
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.PortLable = new System.Windows.Forms.Label();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxCmd1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBoxCmd2 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBoxCmd3 = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.textBoxCmd4 = new System.Windows.Forms.TextBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.textBoxCmd5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxModBusAddress1 = new System.Windows.Forms.TextBox();
            this.comboBoxModbusCode1 = new System.Windows.Forms.ComboBox();
            this.textBoxModBusAddress2 = new System.Windows.Forms.TextBox();
            this.textBoxModBusAddress3 = new System.Windows.Forms.TextBox();
            this.textBoxModBusAddress4 = new System.Windows.Forms.TextBox();
            this.textBoxModBusAddress5 = new System.Windows.Forms.TextBox();
            this.comboBoxModbusCode2 = new System.Windows.Forms.ComboBox();
            this.comboBoxModbusCode3 = new System.Windows.Forms.ComboBox();
            this.comboBoxModbusCode4 = new System.Windows.Forms.ComboBox();
            this.comboBoxModbusCode5 = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(89, 24);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(94, 29);
            this.comboBoxPort.TabIndex = 0;
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBoxPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxPort_MouseDown);
            // 
            // PortLable
            // 
            this.PortLable.AutoSize = true;
            this.PortLable.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PortLable.Location = new System.Drawing.Point(27, 30);
            this.PortLable.Name = "PortLable";
            this.PortLable.Size = new System.Drawing.Size(52, 21);
            this.PortLable.TabIndex = 1;
            this.PortLable.Text = "串口";
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSwitch.Location = new System.Drawing.Point(195, 23);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(65, 33);
            this.buttonSwitch.TabIndex = 2;
            this.buttonSwitch.Text = "打开";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(11, 249);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(919, 219);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // textBoxCmd1
            // 
            this.textBoxCmd1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmd1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCmd1.Location = new System.Drawing.Point(556, 38);
            this.textBoxCmd1.Name = "textBoxCmd1";
            this.textBoxCmd1.Size = new System.Drawing.Size(370, 30);
            this.textBoxCmd1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "波特率";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(89, 79);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(95, 29);
            this.comboBoxBaudRate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "校验位";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(89, 125);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(95, 29);
            this.comboBoxParity.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(191, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "停止位";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(270, 126);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(65, 29);
            this.comboBoxStopBits.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(296, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(191, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "数据位";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTime.Location = new System.Drawing.Point(267, 26);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(23, 25);
            this.labelTime.TabIndex = 18;
            this.labelTime.Text = "0";
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSend.Location = new System.Drawing.Point(201, 205);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(134, 33);
            this.buttonSend.TabIndex = 19;
            this.buttonSend.Text = "发送命令";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClear.Location = new System.Drawing.Point(12, 206);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(134, 33);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "清空日志";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(361, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 25);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "命令1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.Location = new System.Drawing.Point(361, 85);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 25);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "命令2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd2
            // 
            this.textBoxCmd2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmd2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCmd2.Location = new System.Drawing.Point(555, 82);
            this.textBoxCmd2.Name = "textBoxCmd2";
            this.textBoxCmd2.Size = new System.Drawing.Size(370, 30);
            this.textBoxCmd2.TabIndex = 23;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton3.Location = new System.Drawing.Point(361, 129);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 25);
            this.radioButton3.TabIndex = 26;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "命令3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd3
            // 
            this.textBoxCmd3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmd3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCmd3.Location = new System.Drawing.Point(556, 128);
            this.textBoxCmd3.Name = "textBoxCmd3";
            this.textBoxCmd3.Size = new System.Drawing.Size(370, 30);
            this.textBoxCmd3.TabIndex = 25;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton4.Location = new System.Drawing.Point(361, 169);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(69, 25);
            this.radioButton4.TabIndex = 28;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "命令4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // textBoxCmd4
            // 
            this.textBoxCmd4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmd4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCmd4.Location = new System.Drawing.Point(556, 168);
            this.textBoxCmd4.Name = "textBoxCmd4";
            this.textBoxCmd4.Size = new System.Drawing.Size(370, 30);
            this.textBoxCmd4.TabIndex = 27;
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton5.Location = new System.Drawing.Point(361, 211);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(69, 25);
            this.radioButton5.TabIndex = 30;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "命令5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd5
            // 
            this.textBoxCmd5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmd5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCmd5.Location = new System.Drawing.Point(555, 210);
            this.textBoxCmd5.Name = "textBoxCmd5";
            this.textBoxCmd5.Size = new System.Drawing.Size(370, 30);
            this.textBoxCmd5.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(688, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "数据HEX";
            // 
            // textBoxModBusAddress1
            // 
            this.textBoxModBusAddress1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxModBusAddress1.Location = new System.Drawing.Point(439, 38);
            this.textBoxModBusAddress1.Name = "textBoxModBusAddress1";
            this.textBoxModBusAddress1.Size = new System.Drawing.Size(49, 33);
            this.textBoxModBusAddress1.TabIndex = 42;
            // 
            // comboBoxModbusCode1
            // 
            this.comboBoxModbusCode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModbusCode1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxModbusCode1.FormattingEnabled = true;
            this.comboBoxModbusCode1.Location = new System.Drawing.Point(494, 39);
            this.comboBoxModbusCode1.Name = "comboBoxModbusCode1";
            this.comboBoxModbusCode1.Size = new System.Drawing.Size(56, 33);
            this.comboBoxModbusCode1.TabIndex = 43;
            this.comboBoxModbusCode1.SelectedIndexChanged += new System.EventHandler(this.comboBoxModbusCode1_SelectedIndexChanged);
            // 
            // textBoxModBusAddress2
            // 
            this.textBoxModBusAddress2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxModBusAddress2.Location = new System.Drawing.Point(439, 83);
            this.textBoxModBusAddress2.Name = "textBoxModBusAddress2";
            this.textBoxModBusAddress2.Size = new System.Drawing.Size(49, 33);
            this.textBoxModBusAddress2.TabIndex = 44;
            // 
            // textBoxModBusAddress3
            // 
            this.textBoxModBusAddress3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxModBusAddress3.Location = new System.Drawing.Point(439, 125);
            this.textBoxModBusAddress3.Name = "textBoxModBusAddress3";
            this.textBoxModBusAddress3.Size = new System.Drawing.Size(49, 33);
            this.textBoxModBusAddress3.TabIndex = 45;
            // 
            // textBoxModBusAddress4
            // 
            this.textBoxModBusAddress4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxModBusAddress4.Location = new System.Drawing.Point(439, 166);
            this.textBoxModBusAddress4.Name = "textBoxModBusAddress4";
            this.textBoxModBusAddress4.Size = new System.Drawing.Size(49, 33);
            this.textBoxModBusAddress4.TabIndex = 46;
            // 
            // textBoxModBusAddress5
            // 
            this.textBoxModBusAddress5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxModBusAddress5.Location = new System.Drawing.Point(439, 208);
            this.textBoxModBusAddress5.Name = "textBoxModBusAddress5";
            this.textBoxModBusAddress5.Size = new System.Drawing.Size(49, 33);
            this.textBoxModBusAddress5.TabIndex = 47;
            // 
            // comboBoxModbusCode2
            // 
            this.comboBoxModbusCode2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModbusCode2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxModbusCode2.FormattingEnabled = true;
            this.comboBoxModbusCode2.Location = new System.Drawing.Point(494, 82);
            this.comboBoxModbusCode2.Name = "comboBoxModbusCode2";
            this.comboBoxModbusCode2.Size = new System.Drawing.Size(56, 33);
            this.comboBoxModbusCode2.TabIndex = 53;
            this.comboBoxModbusCode2.SelectedIndexChanged += new System.EventHandler(this.comboBoxModbusCode2_SelectedIndexChanged);
            // 
            // comboBoxModbusCode3
            // 
            this.comboBoxModbusCode3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModbusCode3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxModbusCode3.FormattingEnabled = true;
            this.comboBoxModbusCode3.Location = new System.Drawing.Point(494, 125);
            this.comboBoxModbusCode3.Name = "comboBoxModbusCode3";
            this.comboBoxModbusCode3.Size = new System.Drawing.Size(56, 33);
            this.comboBoxModbusCode3.TabIndex = 54;
            this.comboBoxModbusCode3.SelectedIndexChanged += new System.EventHandler(this.comboBoxModbusCode3_SelectedIndexChanged);
            // 
            // comboBoxModbusCode4
            // 
            this.comboBoxModbusCode4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModbusCode4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxModbusCode4.FormattingEnabled = true;
            this.comboBoxModbusCode4.Location = new System.Drawing.Point(494, 166);
            this.comboBoxModbusCode4.Name = "comboBoxModbusCode4";
            this.comboBoxModbusCode4.Size = new System.Drawing.Size(56, 33);
            this.comboBoxModbusCode4.TabIndex = 55;
            this.comboBoxModbusCode4.SelectedIndexChanged += new System.EventHandler(this.comboBoxModbusCode4_SelectedIndexChanged);
            // 
            // comboBoxModbusCode5
            // 
            this.comboBoxModbusCode5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModbusCode5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxModbusCode5.FormattingEnabled = true;
            this.comboBoxModbusCode5.Location = new System.Drawing.Point(494, 208);
            this.comboBoxModbusCode5.Name = "comboBoxModbusCode5";
            this.comboBoxModbusCode5.Size = new System.Drawing.Size(56, 33);
            this.comboBoxModbusCode5.TabIndex = 56;
            this.comboBoxModbusCode5.SelectedIndexChanged += new System.EventHandler(this.comboBoxModbusCode5_SelectedIndexChanged);
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBits.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(271, 78);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(64, 29);
            this.comboBoxDataBits.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(401, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 62;
            this.label8.Text = "地址DEC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(489, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 63;
            this.label9.Text = "功能码";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 480);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxModbusCode5);
            this.Controls.Add(this.comboBoxModbusCode4);
            this.Controls.Add(this.comboBoxModbusCode3);
            this.Controls.Add(this.comboBoxModbusCode2);
            this.Controls.Add(this.textBoxModBusAddress5);
            this.Controls.Add(this.textBoxModBusAddress4);
            this.Controls.Add(this.textBoxModBusAddress3);
            this.Controls.Add(this.textBoxModBusAddress2);
            this.Controls.Add(this.comboBoxModbusCode1);
            this.Controls.Add(this.textBoxModBusAddress1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.textBoxCmd5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.textBoxCmd4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.textBoxCmd3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.textBoxCmd2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxDataBits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.textBoxCmd1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.PortLable);
            this.Controls.Add(this.comboBoxPort);
            this.Name = "Form1";
            this.Text = "调试软件";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label PortLable;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxCmd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBoxCmd3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox textBoxCmd4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox textBoxCmd5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCmd2;
        private System.Windows.Forms.TextBox textBoxModBusAddress1;
        private System.Windows.Forms.ComboBox comboBoxModbusCode1;
        private System.Windows.Forms.TextBox textBoxModBusAddress2;
        private System.Windows.Forms.TextBox textBoxModBusAddress3;
        private System.Windows.Forms.TextBox textBoxModBusAddress4;
        private System.Windows.Forms.TextBox textBoxModBusAddress5;
        private System.Windows.Forms.ComboBox comboBoxModbusCode2;
        private System.Windows.Forms.ComboBox comboBoxModbusCode3;
        private System.Windows.Forms.ComboBox comboBoxModbusCode4;
        private System.Windows.Forms.ComboBox comboBoxModbusCode5;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

