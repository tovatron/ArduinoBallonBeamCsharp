using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.IO.Ports;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;

namespace ArduinoBallonBeam
{
    public partial class Form1 : Form
    {
        string[] baud = { "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200" };
        LineItem line1;         //Khai báo đường line 1 hiển thị trên đồ thị
        LineItem line2;         //Khai báo đường line 2 hiển thị trên đồ thị
        RollingPointPairList listvalue1;            //Khai báo danh sách các điểm "giá trị đặt" trên đồ thị
        RollingPointPairList listvalue2;            //Khai báo danh sách các điểm "giá trị thực" trên đồ thị
        double distance;
        double setpoint;
        double ServoOutput;
        double Kp;
        double Ki;
        double Kd;
        double minY = 20.0;         
        double maxY = 237.0;          //Khoảng cách di chuyển(mô phỏng) của quả bóng là từ Y=20 đến Y = 237
        int TickStart;                // Khai báo giá trị thời gian bắt đầu chạy của hệ thống.
        int mode;                     // Khai báo chế độ của đồ thị
        bool IsConnected;             // Khai báo biến trạng thái mở, tắt.
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] myport = SerialPort.GetPortNames();        //Lấy thông tin các cổng COM
            cboxPortname.Items.AddRange(myport);                //Thêm cổng COM vào combobox
            cboxBaudrate.Items.AddRange(baud);                  //Thêm baudrate vào combobox

            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            txtStatus.Text = "Disconnected";
            pboxStatus.BackColor = Color.Red;
            KhoitaoZedgraph();                                  //Khởi tạo đồ thị

            TickStart = Environment.TickCount;                  //Thời gian tính từ lúc bắt đầu chạy phần mềm.
            mode = 1;

        }
        private void KhoitaoZedgraph()
        {
            GraphPane myGraphpane = zgpane01.GraphPane;             //Đặt tên cho đồ thị
            myGraphpane.Title.Text = "Đường đặc tính hệ thống";
            myGraphpane.YAxis.Title.Text = "Giá trị";               //Đặt tên trục Y
            myGraphpane.XAxis.Title.Text = "Thời gian";             //Đặt tên trục X

            listvalue1 = new RollingPointPairList(600000);          //Lấy 600000 giá trị rồi dừng.
            listvalue2 = new RollingPointPairList(600000);

            line1 = myGraphpane.AddCurve("Giá trị đặt", listvalue1, Color.Blue, SymbolType.None);       //Hiển thị đường trên đồ thị
            line2 = myGraphpane.AddCurve("Giá trị thực", listvalue2, Color.Red, SymbolType.None);

            myGraphpane.YAxis.Scale.Min = 0;            //Giá trị hiển thị nhỏ nhất trên trục Y
            myGraphpane.YAxis.Scale.Max = 30;           //Giá trị hiển thị lớn nhất trên trục Y
            myGraphpane.YAxis.Scale.MinorStep = 1;      //Bước nhảy nhỏ nhất của trục Y
            myGraphpane.YAxis.Scale.MajorStep = 5;      //Bước nhảy lớn nhất của trục Y

            myGraphpane.XAxis.Scale.Min = 0;
            myGraphpane.XAxis.Scale.Max = 30;
            myGraphpane.XAxis.Scale.MinorStep = 1;
            myGraphpane.XAxis.Scale.MajorStep = 5;

            zgpane01.AxisChange();                      //Thay đổi đồ thị theo những giá trị ở trên.
        }
        public void Draw(double distance, double setpoint)
        {
            line1 = zgpane01.GraphPane.CurveList[0] as LineItem;
            line2 = zgpane01.GraphPane.CurveList[1] as LineItem;
            if (line1 == null)
                return;
            if (line2 == null)
                return;
            IPointListEdit listvalue1 = line1.Points as IPointListEdit;
            IPointListEdit listvalue2 = line2.Points as IPointListEdit;
            if (listvalue1 == null)
                return;
            if (listvalue2 == null)
                return;
            double time = (Environment.TickCount - TickStart) / 1000.0;
            listvalue1.Add(time, setpoint);
            listvalue2.Add(time, distance);
            Scale xScale = zgpane01.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                if (mode == 1)
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = xScale.Max - 30.0;
                }
                else
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = 0;
                }
            }
            zgpane01.AxisChange();
            zgpane01.Invalidate();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cboxPortname.Text;
                serialPort1.BaudRate = Convert.ToInt32(cboxBaudrate.Text);
                serialPort1.Open();
                IsConnected = true;
                timer1.Enabled = true;
                KhoitaoZedgraph();

                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                btnMode1.Enabled = false;
                btnMode2.Enabled = true;
                txtStatus.Text = "Connected";
                pboxStatus.BackColor = Color.Green;
                MessageBox.Show("Đã kết nối với Arduino");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                IsConnected = false;
                timer1.Enabled = false;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                txtStatus.Text = "Disconnected";
                pboxStatus.BackColor = Color.Red;
                MessageBox.Show("Đã ngắt kết nối với Arduino");
                Clear_Zedgraph();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void btnMode1_Click(object sender, EventArgs e)
        {
            btnMode1.Enabled = false;
            btnMode2.Enabled = true;
            mode = 1;

        }

        private void btnMode2_Click(object sender, EventArgs e)
        {
            btnMode1.Enabled = true;
            btnMode2.Enabled = false;
            mode = 0;
        }
        private void Displayvalue()
        {
            Invoke(new MethodInvoker(() => txtboxCP.Text = distance.ToString()));
            Invoke(new MethodInvoker(() => txtboxAngle.Text = ServoOutput.ToString()));
            Invoke(new MethodInvoker(() => txtboxSP_show.Text = setpoint.ToString()));
            Invoke(new MethodInvoker(() => txtboxKpread.Text = Kp.ToString()));
            Invoke(new MethodInvoker(() => txtboxKiread.Text = Ki.ToString()));
            Invoke(new MethodInvoker(() => txtboxKdread.Text = Kd.ToString()));
            Invoke(new MethodInvoker(() => Draw(distance, setpoint)));
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string ReciveData = serialPort1.ReadTo("\n");
            Data_Calculate(ReciveData);
            Displayvalue();
        }
        private void Data_Calculate(string data)
        {
            sbyte IndexOf_startDataCharacter = (sbyte)data.IndexOf("#");
            sbyte IndexOfA = (sbyte)data.IndexOf("A");
            sbyte IndexOfB = (sbyte)data.IndexOf("B");
            sbyte IndexOfC = (sbyte)data.IndexOf("C");
            sbyte IndexOfH = (sbyte)data.IndexOf("H");
            sbyte IndexOfI = (sbyte)data.IndexOf("I");
            sbyte IndexOfK = (sbyte)data.IndexOf("K");

            if (IndexOf_startDataCharacter != -1 && IndexOfA != -1 && IndexOfB != -1 && IndexOfC != -1 && IndexOfH != -1 && IndexOfI != -1 && IndexOfK != -1)
            {
                string str_distance = data.Substring(IndexOf_startDataCharacter + 1, (IndexOfA - IndexOf_startDataCharacter) - 1);
                string str_setpoint = data.Substring(IndexOfA + 1, (IndexOfB - IndexOfA) - 1);
                string str_servooutput = data.Substring(IndexOfB + 1, (IndexOfC - IndexOfB) - 1);
                string srt_Kp = data.Substring(IndexOfC + 1, (IndexOfH - IndexOfC) - 1);
                string srt_Ki = data.Substring(IndexOfH + 1, (IndexOfI - IndexOfH) - 1);
                string srt_Kd = data.Substring(IndexOfI + 1, (IndexOfK - IndexOfI) - 1);


                distance = Convert.ToDouble(str_distance);
                setpoint = Convert.ToDouble(str_setpoint);
                ServoOutput = Convert.ToDouble(str_servooutput);
                Kp = Convert.ToDouble(srt_Kp);
                Ki = Convert.ToDouble(srt_Ki);
                Kd = Convert.ToDouble(srt_Kd);
            }


        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                MessageBox.Show("Chưa kết nối với Arduino");
            }
            else
            {
                String dataSend;
                String SPdata = txtboxSP.Text;
                String Kpdata = txtboxKp.Text;
                String Kidata = txtboxKi.Text;
                String Kddata = txtboxKd.Text;
                double SPdataConvert;
                dataSend = SPdata + "D" + Kpdata + "E" +
                 Kidata + "F" + Kddata + "G" + "\n";
                serialPort1.Write(dataSend);
                txtboxCodesend.Text = dataSend;
            }
        }
        private void Clear_Zedgraph()
        {
            zgpane01.GraphPane.CurveList.Clear();
            zgpane01.GraphPane.GraphObjList.Clear();
            zgpane01.AxisChange();
            zgpane01.Invalidate();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            double y1 = minY + ((maxY - minY)*distance) / 23.0;
            pboxBall.Top = Convert.ToInt32(y1);

            double y2 = minY + ((maxY - minY) * setpoint) / 23.0;
            pboxSetpoint.Top = Convert.ToInt32(y2);
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Black);
                g.DrawEllipse(pen, 179, 20, 31, 31);
        }
    }
}
