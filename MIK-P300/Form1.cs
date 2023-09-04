using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Timers;
using ZedGraph;

namespace MIK_P300
{
    public partial class Form1 : Form
    {
        #region 变量数据
        private float xvalues;
        private float yvalues;  
        //窗体宽度、高度变量
        PointPairList listX0 = new PointPairList();
        bool flag=false;
        GraphPane myPanelX;
        int ZedX, ZedY, ZedHeight, ZedWidth;
        public string path;
        public float TimeWatch = 1;
        //默认监测时间范围10分钟
        float Xlow = -40f, Xhig = 40;
        bool Xauto = false;
        //X轴是否自动压缩
        LineItem myCurveX;//4条曲线
        double a = 0.00001158;//时间常数
        #endregion
        StreamWriter sw = null;
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            #region X轴绘图面板
            myPanelX = zedGraphX.GraphPane;
            // 得到绘图面板
            myPanelX.Title.Text = "实时压强";
            //标题名称
            myPanelX.Title.FontSpec.Size = 24;
            //标题字体大小
            myPanelX.Title.FontSpec.FontColor = Color.Teal;
            myPanelX.YAxis.Title.Text = "";
            myPanelX.XAxis.Title.Text = "";
            myPanelX.XAxis.Type = AxisType.DateAsOrdinal;
            //X坐标格式
            myPanelX.XAxis.Scale.Format = "HH:mm:ss";
            //时间格式
            myPanelX.Legend.IsVisible = false;
            //注释框不显示  
            myPanelX.XAxis.MajorGrid.IsVisible = true;
            // 显示X 格            
            myPanelX.YAxis.MajorGrid.IsVisible = true;
            // 显示Y 格                         
            myPanelX.YAxis.MajorGrid.IsZeroLine = false;
            // 不显示零点线条           
            myPanelX.YAxis.Scale.MaxAuto = true;
            myPanelX.YAxis.Scale.MinAuto = true;
            myCurveX = myPanelX.AddCurve("压强", listX0, Color.Red, SymbolType.None);
            //线条说明
            myCurveX.Symbol.Fill = new Fill(Color.White);
            myPanelX.Chart.Fill = new Fill(Color.White, Color.LightGray, 100.0f);
            // Fill the axis background with a gradient
            myPanelX.Fill = new Fill(Control.DefaultBackColor);
            zedGraphX.PointValueEvent += new ZedGraphControl.PointValueHandler(MyPointValueHandler);
            myPanelX.XAxis.Scale.MajorStepAuto = true;
            myPanelX.YAxis.Scale.IsUseTenPower = false;
            myPanelX.YAxis.Scale.Mag = 0;
            zedGraphX.Invalidate(); // Make sure the Graph gets redrawn
            zedGraphX.AxisChange();
            #endregion
        }
        private string MyPointValueHandler(ZedGraphControl control, GraphPane pane, CurveItem curve, int iPt)
        {
            // Get the PointPair that is under the mouse
            PointPair pt = curve[iPt];
            return curve.Label.Text + ":" + pt.Y.ToString("f4") + " at " + ((XDate)pt.X).ToString("HH:mm:ss");
        }
        private void comboBoxComNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void createPane(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;
            // 设置图表标题 和 x y 轴标题
            myPane.Title.Text = "温度实时控制曲线";
            myPane.XAxis.Title.Text = "时间";
            myPane.YAxis.Title.Text = "压强";
            // 更改标题的字体
            FontSpec myFont = new FontSpec("Arial", 20, Color.Red, false, false, false);
            myPane.Title.FontSpec = myFont;
            myPane.XAxis.Title.FontSpec = myFont;
            myPane.YAxis.Title.FontSpec = myFont;
            bool Xauto = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 20; i++)
            {
                comboBoxComNumber.Items.Add("COM" + i.ToString());
            }
            comboBoxComNumber.Text = "COM1";
            //textBox_path.Text = @System.Environment.CurrentDirectory+ @"\test.txt";
            //获取当前路径，并保存到txt文件中，没有则创建



        }
        private void button_select_Click(object sender, EventArgs e)
        {
            try
            {
                
                SaveFileDialog file = new SaveFileDialog();
                //注意区分savefile和openfile
                file.InitialDirectory = @"C:\";
                file.FileName = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
                //文件名格式
                file.DefaultExt = "txt";
                //指定文件格式
                file.AddExtension = true;
                file.RestoreDirectory = true;
                file.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*";
                if(file.ShowDialog() == DialogResult.OK)
                {
                    string localFilepath=file.FileName;
                    if (sw != null)
                    {
                        sw.Close();
                        sw.Dispose();
                    }
                    sw=new StreamWriter(localFilepath,true,Encoding.Unicode);
                    //在这里创建流 下面就不用创建流了
                    
                    this.textBox_path.Text = Path.GetFullPath(file.FileName);
                    button_start.Enabled = true;
                }
               
              
            }
            catch
            
            {
                MessageBox.Show("未选择文件，请选择合适文件","未选择");
            }
           // string newTxtPath = this.textBox_path.Text +"/" +datetime;
            //StreamWriter sw = new StreamWriter(newTxtPath, false, Encoding.Default);
            
            
        }
        private void textBox_path_TextChanged(object sender, EventArgs e)
        {

        }

        private void zedGraphX_Load(object sender, EventArgs e)
        {

        }

        private void textBoxtTemperature_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX0_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)//显示pc机时间，并向串口发送命令
        {
            try
            {
                    byte[] cmd = {0x01,0x03,0x00,0x04,0x00,0x01,0xC5,0xCB};
                    serialPort1.Write(cmd,0,8);
            }
            catch
            {
                MessageBox.Show("请先连接串口！");//捕获错误
            }

            DateTime time = DateTime.Now;
            string t = time.ToString(" HH:mm:ss");
            this.textBoxtTemperature.Text = t;
        }

        private void timer2_Tick(object sender, EventArgs e)//定时保存数据,在点击start的时候开始
        {
            if (flag)//flag为标志位，方便和下面的保存文件一起操作
            {
                //保存到指定路径

                sw.Write("时间：" + textBoxtTemperature.Text + ",压强值:" + textBoxX0.Text + "\r\n");
                sw.Flush();

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button_link_Click(object sender, EventArgs e)//打开串口和关闭串口的功能
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = comboBoxComNumber.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                    serialPort1.Open();
                    timer1.Enabled = true;
                    MessageBox.Show("打开成功", "成功");
                    button_link.Text = "断开";
                }
                catch
                {

                    MessageBox.Show("端口错误，请检查串口", "错误");

                }
            }
            else if (serialPort1.IsOpen)

            {
                timer1.Enabled = false;
                serialPort1.Close();
                MessageBox.Show("关闭成功", "成功");
                button_link.Text = "连接";
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            int len = serialPort1.BytesToRead;
            //获取缓冲区的字节数
            if(len==0) return;
            //看缓冲区的字节是否已经收到
            byte [] buffer = new byte[len]; 
            
            //根据收到的字节数指定byte数组的长度
            serialPort1.Read(buffer, 0, len);
            //将读取到的数据从头写入byte数组
            double k =(double)( (buffer[3] << 8 | buffer[4])*0.1);
            //将读取到的16进制数据转换为十进制
            textBoxX0.Text = k.ToString("f2");
            //将数据显示到文本框中
            myPanelX.YAxis.Scale.IsUseTenPower = false;
            myPanelX.YAxis.Scale.Mag = 0;
            myPanelX.XAxis.Scale.Format = "HH:mm:ss";
            double x = (double)new XDate(DateTime.Now);
            //获取当前时间，并转换成double类型
            listX0.Add(x, k);
            // 将点添加到曲线上
            while (((myCurveX.Points[myCurveX.Points.Count - 1].X - myCurveX.Points[0].X) / a) > TimeWatch * 60)
            {
                //数据长度大于设定范围时移除多余数据
                listX0.RemoveAt(0);
            }
            zedGraphX.AxisChange();  
            // 在数据变化时绘图
            zedGraphX.Invalidate();  
            // 更新图表
            Refresh();
            // 重绘控件
            
           
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void button_start_Click(object sender, EventArgs e)
        {
            
            if (button_start.Text=="Start")//点击开始后，将按钮转为停止
            {
                flag = true ;
                button_start.Text = "Stop";
                timer2.Enabled = true;
                MessageBox.Show("开始保存", "开始");
            }
           else if(button_start.Text == "Stop")//点击停止，按钮重新转为开始
            {
                flag = false;
                button_start.Text="Start";
                MessageBox.Show("结束保存", "结束");
                timer2.Enabled = false;
            }
        }
    }
}
