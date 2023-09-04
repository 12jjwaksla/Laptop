namespace MIK_P300
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
            this.components = new System.ComponentModel.Container();
            this.zedGraphX = new ZedGraph.ZedGraphControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_link = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxComNumber = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.button_select = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxtTemperature = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphX
            // 
            this.zedGraphX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zedGraphX.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zedGraphX.EditModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.None)));
            this.zedGraphX.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zedGraphX.IsAutoScrollRange = false;
            this.zedGraphX.IsEnableHEdit = false;
            this.zedGraphX.IsEnableHPan = false;
            this.zedGraphX.IsEnableHZoom = true;
            this.zedGraphX.IsEnableVEdit = false;
            this.zedGraphX.IsEnableVPan = true;
            this.zedGraphX.IsEnableVZoom = true;
            this.zedGraphX.IsPrintFillPage = true;
            this.zedGraphX.IsPrintKeepAspectRatio = true;
            this.zedGraphX.IsScrollY2 = false;
            this.zedGraphX.IsShowContextMenu = true;
            this.zedGraphX.IsShowCopyMessage = true;
            this.zedGraphX.IsShowCursorValues = false;
            this.zedGraphX.IsShowHScrollBar = false;
            this.zedGraphX.IsShowPointValues = true;
            this.zedGraphX.IsShowVScrollBar = false;
            this.zedGraphX.IsSynchronizeXAxes = false;
            this.zedGraphX.IsSynchronizeYAxes = false;
            this.zedGraphX.IsZoomOnMouseCenter = false;
            this.zedGraphX.LinkButtons = System.Windows.Forms.MouseButtons.Left;
            this.zedGraphX.LinkModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.None)));
            this.zedGraphX.Location = new System.Drawing.Point(38, -7);
            this.zedGraphX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedGraphX.Name = "zedGraphX";
            this.zedGraphX.PanButtons = System.Windows.Forms.MouseButtons.Left;
            this.zedGraphX.PanButtons2 = System.Windows.Forms.MouseButtons.None;
            this.zedGraphX.PanModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.None)));
            this.zedGraphX.PanModifierKeys2 = System.Windows.Forms.Keys.None;
            this.zedGraphX.PointDateFormat = "g";
            this.zedGraphX.PointValueFormat = "G";
            this.zedGraphX.ScrollMaxX = 0D;
            this.zedGraphX.ScrollMaxY = 0D;
            this.zedGraphX.ScrollMaxY2 = 0D;
            this.zedGraphX.ScrollMinX = 0D;
            this.zedGraphX.ScrollMinY = 0D;
            this.zedGraphX.ScrollMinY2 = 0D;
            this.zedGraphX.Size = new System.Drawing.Size(578, 428);
            this.zedGraphX.TabIndex = 1;
            this.zedGraphX.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
            this.zedGraphX.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
            this.zedGraphX.ZoomModifierKeys = System.Windows.Forms.Keys.None;
            this.zedGraphX.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
            this.zedGraphX.ZoomStepFraction = 0.1D;
            this.zedGraphX.Load += new System.EventHandler(this.zedGraphX_Load);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox);
            this.groupBox4.Controls.Add(this.button_link);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.comboBoxBaud);
            this.groupBox4.Controls.Add(this.comboBoxComNumber);
            this.groupBox4.Location = new System.Drawing.Point(667, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 80);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "串口通信配置";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(152, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(35, 27);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // button_link
            // 
            this.button_link.BackColor = System.Drawing.Color.Lime;
            this.button_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_link.Location = new System.Drawing.Point(143, 49);
            this.button_link.Name = "button_link";
            this.button_link.Size = new System.Drawing.Size(52, 22);
            this.button_link.TabIndex = 4;
            this.button_link.Text = "连接";
            this.button_link.UseVisualStyleBackColor = false;
            this.button_link.Click += new System.EventHandler(this.button_link_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "波特率";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "串口号";
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "576000",
            "115200"});
            this.comboBoxBaud.Location = new System.Drawing.Point(53, 51);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(76, 20);
            this.comboBoxBaud.TabIndex = 1;
            // 
            // comboBoxComNumber
            // 
            this.comboBoxComNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComNumber.FormattingEnabled = true;
            this.comboBoxComNumber.Location = new System.Drawing.Point(53, 20);
            this.comboBoxComNumber.Name = "comboBoxComNumber";
            this.comboBoxComNumber.Size = new System.Drawing.Size(76, 20);
            this.comboBoxComNumber.TabIndex = 0;
            this.comboBoxComNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxComNumber_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.button_start);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.button_select);
            this.groupBox6.Controls.Add(this.textBox_path);
            this.groupBox6.Location = new System.Drawing.Point(667, 288);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(208, 94);
            this.groupBox6.TabIndex = 81;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Log";
            // 
            // button_start
            // 
            this.button_start.Enabled = false;
            this.button_start.Location = new System.Drawing.Point(7, 19);
            this.button_start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(67, 18);
            this.button_start.TabIndex = 75;
            this.button_start.TabStop = false;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(-2, 52);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 73;
            this.label17.Text = "Path：";
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(95, 19);
            this.button_select.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(71, 18);
            this.button_select.TabIndex = 72;
            this.button_select.Text = "Select ";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(40, 50);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(164, 21);
            this.textBox_path.TabIndex = 71;
            this.textBox_path.TextChanged += new System.EventHandler(this.textBox_path_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxtTemperature);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxX0);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(667, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 113);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "监测数据显示";
            // 
            // textBoxtTemperature
            // 
            this.textBoxtTemperature.Location = new System.Drawing.Point(93, 61);
            this.textBoxtTemperature.Name = "textBoxtTemperature";
            this.textBoxtTemperature.ReadOnly = true;
            this.textBoxtTemperature.Size = new System.Drawing.Size(102, 21);
            this.textBoxtTemperature.TabIndex = 13;
            this.textBoxtTemperature.TextChanged += new System.EventHandler(this.textBoxtTemperature_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "PC机时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 5;
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(93, 16);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.ReadOnly = true;
            this.textBoxX0.Size = new System.Drawing.Size(102, 21);
            this.textBoxX0.TabIndex = 1;
            this.textBoxX0.TextChanged += new System.EventHandler(this.textBoxX0_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "压强(MP)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(892, 22);
            this.statusStrip1.TabIndex = 83;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 540);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.zedGraphX);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ZedGraph.ZedGraphControl zedGraphX;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_link;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox comboBoxBaud;
        public System.Windows.Forms.ComboBox comboBoxComNumber;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxtTemperature;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer2;
    }
}

