
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
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
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.textBoxCmd6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.textBoxCmd8 = new System.Windows.Forms.TextBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.textBoxCmd7 = new System.Windows.Forms.TextBox();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.textBoxCmd10 = new System.Windows.Forms.TextBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.textBoxCmd9 = new System.Windows.Forms.TextBox();
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
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(11, 186);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(464, 282);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // textBoxCmd1
            // 
            this.textBoxCmd1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmd1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCmd1.Location = new System.Drawing.Point(572, 37);
            this.textBoxCmd1.Name = "textBoxCmd1";
            this.textBoxCmd1.Size = new System.Drawing.Size(336, 35);
            this.textBoxCmd1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 69);
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
            this.comboBoxBaudRate.Location = new System.Drawing.Point(89, 66);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(95, 29);
            this.comboBoxBaudRate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 116);
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
            this.comboBoxParity.Location = new System.Drawing.Point(89, 112);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(95, 29);
            this.comboBoxParity.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(191, 115);
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
            this.comboBoxStopBits.Location = new System.Drawing.Point(270, 113);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(65, 29);
            this.comboBoxStopBits.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(99, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 33);
            this.textBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(8, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "数据名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(425, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "毫秒";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(191, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "数据位";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBits.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(271, 65);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(64, 29);
            this.comboBoxDataBits.TabIndex = 16;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTime.Location = new System.Drawing.Point(394, 24);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(23, 25);
            this.labelTime.TabIndex = 18;
            this.labelTime.Text = "0";
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSend.Location = new System.Drawing.Point(341, 61);
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
            this.buttonClear.Location = new System.Drawing.Point(341, 147);
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
            this.radioButton1.Location = new System.Drawing.Point(494, 42);
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
            this.radioButton2.Location = new System.Drawing.Point(494, 84);
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
            this.textBoxCmd2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCmd2.Location = new System.Drawing.Point(572, 79);
            this.textBoxCmd2.Name = "textBoxCmd2";
            this.textBoxCmd2.Size = new System.Drawing.Size(336, 35);
            this.textBoxCmd2.TabIndex = 23;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton3.Location = new System.Drawing.Point(494, 128);
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
            this.textBoxCmd3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCmd3.Location = new System.Drawing.Point(572, 121);
            this.textBoxCmd3.Name = "textBoxCmd3";
            this.textBoxCmd3.Size = new System.Drawing.Size(336, 35);
            this.textBoxCmd3.TabIndex = 25;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton4.Location = new System.Drawing.Point(494, 168);
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
            this.textBoxCmd4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCmd4.Location = new System.Drawing.Point(572, 163);
            this.textBoxCmd4.Name = "textBoxCmd4";
            this.textBoxCmd4.Size = new System.Drawing.Size(336, 35);
            this.textBoxCmd4.TabIndex = 27;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton5.Location = new System.Drawing.Point(494, 210);
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
            this.textBoxCmd5.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCmd5.Location = new System.Drawing.Point(572, 205);
            this.textBoxCmd5.Name = "textBoxCmd5";
            this.textBoxCmd5.Size = new System.Drawing.Size(336, 35);
            this.textBoxCmd5.TabIndex = 29;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton6.Location = new System.Drawing.Point(494, 252);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(69, 25);
            this.radioButton6.TabIndex = 32;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "命令6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd6
            // 
            this.textBoxCmd6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmd6.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCmd6.Location = new System.Drawing.Point(572, 247);
            this.textBoxCmd6.Name = "textBoxCmd6";
            this.textBoxCmd6.Size = new System.Drawing.Size(336, 35);
            this.textBoxCmd6.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(647, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "16进制命令空格分隔";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton8.Location = new System.Drawing.Point(494, 336);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(69, 25);
            this.radioButton8.TabIndex = 37;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "命令8";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd8
            // 
            this.textBoxCmd8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmd8.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCmd8.Location = new System.Drawing.Point(572, 331);
            this.textBoxCmd8.Name = "textBoxCmd8";
            this.textBoxCmd8.Size = new System.Drawing.Size(336, 35);
            this.textBoxCmd8.TabIndex = 36;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton7.Location = new System.Drawing.Point(494, 294);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(69, 25);
            this.radioButton7.TabIndex = 35;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "命令7";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd7
            // 
            this.textBoxCmd7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmd7.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCmd7.Location = new System.Drawing.Point(572, 289);
            this.textBoxCmd7.Name = "textBoxCmd7";
            this.textBoxCmd7.Size = new System.Drawing.Size(336, 35);
            this.textBoxCmd7.TabIndex = 34;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton10.Location = new System.Drawing.Point(494, 420);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(78, 25);
            this.radioButton10.TabIndex = 41;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "命令10";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd10
            // 
            this.textBoxCmd10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmd10.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCmd10.Location = new System.Drawing.Point(572, 415);
            this.textBoxCmd10.Name = "textBoxCmd10";
            this.textBoxCmd10.Size = new System.Drawing.Size(336, 35);
            this.textBoxCmd10.TabIndex = 40;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton9.Location = new System.Drawing.Point(497, 378);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(69, 25);
            this.radioButton9.TabIndex = 39;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "命令9";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd9
            // 
            this.textBoxCmd9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmd9.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCmd9.Location = new System.Drawing.Point(572, 373);
            this.textBoxCmd9.Name = "textBoxCmd9";
            this.textBoxCmd9.Size = new System.Drawing.Size(336, 35);
            this.textBoxCmd9.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 480);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.textBoxCmd10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.textBoxCmd9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.textBoxCmd8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.textBoxCmd7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.textBoxCmd6);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
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
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.TextBox textBoxCmd6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.TextBox textBoxCmd8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.TextBox textBoxCmd7;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.TextBox textBoxCmd10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.TextBox textBoxCmd9;
        private System.Windows.Forms.TextBox textBoxCmd2;
    }
}

