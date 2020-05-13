using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.IO.Ports;
using ZedGraph;

namespace DataPlot3
{
    public partial class Form1 : Form
    {
        String COMRx;
        int NoOfCurves, Samples;
        int[,] colourList = {{128,0,0},{0,128,0},{0,0,128},{0,128,128},{128,128,0},{255,0,0},{0,255,0},
                            {0,0,255},{255,255,0},{255,0,255},{0,255,255}};

        List<PointPairList> Data = new List<PointPairList>();
        List<PointPairList> LData = new List<PointPairList>();

        List<PointPairList> MaxLData = new List<PointPairList>();
        List<PointPairList> MinLData = new List<PointPairList>();

        delegate void SerialDataReceivedDelegate(object sender, SerialDataReceivedEventArgs e);

        delegate void SerialErrorReceivedDelegate(object sender, SerialErrorReceivedEventArgs e);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the titles and axis labels
            // MAA
            ZedGraphControl1.GraphPane.Title.Text = "Time History";
            ZedGraphControl1.GraphPane.XAxis.Title.Text = "Samples";
            ZedGraphControl1.GraphPane.YAxis.Title.Text = "";

            ZedGraphControl1.GraphPane.XAxis.Scale.MaxGrace = 0;
            ZedGraphControl1.GraphPane.YAxis.MajorGrid.IsVisible = true;
            ZedGraphControl1.GraphPane.XAxis.MajorGrid.IsVisible = true;
            ZedGraphControl1.GraphPane.Legend.Position = ZedGraph.LegendPos.Bottom;

            ZedGraphControl2.GraphPane.Title.Text = "XY Plots";
            ZedGraphControl2.GraphPane.XAxis.Title.Text = "X-Axis";
            ZedGraphControl2.GraphPane.YAxis.Title.Text = "Y-Axis";

            //ZedGraphControl2.GraphPane.XAxis.Scale.MaxGrace = 0;
            ZedGraphControl2.GraphPane.YAxis.MajorGrid.IsVisible = true;
            ZedGraphControl2.GraphPane.XAxis.MajorGrid.IsVisible = true;
            ZedGraphControl2.GraphPane.Legend.Position = ZedGraph.LegendPos.Bottom;


        }

        private void COMConnectBtn_Click(object sender, EventArgs e)
        {
            COMConnectButton.Enabled = false;

            COMPortStatusLight.Value = 3;

            if (SerialPort.IsOpen)
            {
                timer1.Enabled = false;

                SerialPort.Close();

                COMPortStatusLight.Value = -1;
                COMConnectButton.Text = "Connect";
            }
            else
            {
                SerialPort.PortName = COMPortComboBox.Text;
                SerialPort.BaudRate = int.Parse(COMBaudComboBox.Text);

                try
                {
                    SerialPort.Open();
                }
                catch
                {
                    COMPortStatusLight.Value = -1;
                    MessageBox.Show("Could not open " + COMPortComboBox.Text);
                }

                if (SerialPort.IsOpen)
                {
                    COMPortStatusLight.Value = 1;
                    COMConnectButton.Text = "Disconnect";

                    Data.Clear();
                    LData.Clear();
                    deleteCurves();
                    initCurves();
                    initLCurves();

                    timer1.Enabled = true;
                }
            }

            COMConnectButton.Enabled = true;
        }

        private void initCurves()
        {
            Samples = int.Parse(SampleTextBox.Text);
            NoOfCurves = (int)NoOfDataNumericUpDown.Value;


            for (int j = 0; j < NoOfCurves; j++)
            {
                PointPairList tempppl = new PointPairList();

                for (double x = 0; x < Samples; x++)
                {
                    tempppl.Add(x, 0);
                }

                Data.Add(tempppl);
                
                ZedGraphControl1.GraphPane.AddCurve("Data " + j.ToString(), Data[j],
                    Color.FromArgb(colourList[j, 0], colourList[j, 1], colourList[j, 2]), SymbolType.None);                
            }
            
        }

        private void initLCurves()
        {
            Samples = int.Parse(SampleTextBox.Text);
            NoOfCurves = (int)NoOfDataNumericUpDown.Value;

            PointPairList tempppl = new PointPairList();
            PointPairList max_tempppl = new PointPairList();
            PointPairList min_tempppl = new PointPairList();

            float _angle = 0.0f;
                for (double x = 0; x < Samples; x++)
                {
                    _angle = (float)Math.PI  * (float)x / (float)Samples * 2.1f;

                    tempppl.Add(Math.Cos(_angle) * 3300.0f, Math.Sin(_angle) * 3300.0f);

                     max_tempppl.Add(Math.Cos(_angle) * float.Parse(MaxTextBox.Text), Math.Sin(_angle) * float.Parse(MaxTextBox.Text));
                     min_tempppl.Add(Math.Cos(_angle) * float.Parse(MinTextBox.Text), Math.Sin(_angle) * float.Parse(MinTextBox.Text));
            }

                LData.Add(tempppl);
                MaxLData.Add(max_tempppl);
                MinLData.Add(min_tempppl);

                ZedGraphControl2.GraphPane.AddCurve("LData ", LData[0],Color.FromArgb(colourList[0, 0], colourList[0, 1], colourList[0, 2]), SymbolType.None);
            
                ZedGraphControl2.GraphPane.AddCurve("Max ", MaxLData[0], System.Drawing.Color.Red, SymbolType.None);
                ZedGraphControl2.GraphPane.AddCurve("Min ", MinLData[0], System.Drawing.Color.Red, SymbolType.None);


        }


        private void deleteCurves()
        {
            ZedGraphControl1.GraphPane.CurveList.Clear();
            ZedGraphControl2.GraphPane.CurveList.Clear();
        }

        // event handler for getting serial data
        private void ProcessCOMRx(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(COMRx))
            {
                string[] parsed = COMRx.Split(',');
                int curveNo;

                if (parsed.Count() > ZedGraphControl1.GraphPane.CurveList.Count())
                    curveNo = ZedGraphControl1.GraphPane.CurveList.Count();
                else
                    curveNo = parsed.Count();


                for (int k = 0; k < curveNo; k++)
                {
                    for (int j = ZedGraphControl1.GraphPane.CurveList[k].NPts - 1; j > 0; j--)
                    {
                        ZedGraphControl1.GraphPane.CurveList[k].Points[j].Y = ZedGraphControl1.GraphPane.CurveList[k].Points[j - 1].Y;
                    }
                    
                    double temp = 0;

                    try
                    {
                        temp = double.Parse(parsed[k]);
                    }
                    catch
                    {
                        RawTextBox.AppendText("Parse Error\n");
                    }

                    //RawTextBox.AppendText(temp.ToString() + "-" + k.ToString() + ", ");
                    ZedGraphControl1.GraphPane.CurveList[k].Points[0].X = 0;
                    ZedGraphControl1.GraphPane.CurveList[k].Points[0].Y = temp;
                }

                //RawTextBox.AppendText("\n");
                RawTextBox.AppendText(COMRx + '\n');
                //COMRx = "";
            }
        }

        private void ProcessCOMRx2(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(COMRx))
            {
                string[] parsed = COMRx.Split(',');
                int curveNo;

                if (parsed.Count() > ZedGraphControl2.GraphPane.CurveList.Count())
                    curveNo = ZedGraphControl2.GraphPane.CurveList.Count();
                else
                    curveNo = parsed.Count();


                for (int k = 0; k < curveNo; k++)
                {
                    for (int j = ZedGraphControl2.GraphPane.CurveList[k].NPts - 1; j > 0; j--)
                    {                        
                        ZedGraphControl2.GraphPane.CurveList[0].Points[j].X = ZedGraphControl2.GraphPane.CurveList[0].Points[j - 1].X;
                        ZedGraphControl2.GraphPane.CurveList[0].Points[j].Y = ZedGraphControl2.GraphPane.CurveList[0].Points[j - 1].Y;
                    }

                    double temp = 0;

                    try
                    {
                        temp = double.Parse(parsed[k]);
                    }
                    catch
                    {
                        RawTextBox.AppendText("Parse Error\n");
                    }

                    ZedGraphControl2.GraphPane.CurveList[0].Points[0].X = double.Parse(parsed[0]);
                    ZedGraphControl2.GraphPane.CurveList[0].Points[0].Y = double.Parse(parsed[1]);
                }
            }
        }

        private void ReadLineError(object sender, EventArgs e)
        {
            RawTextBox.AppendText("Read Line Error\n");
        }

        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int BufferLength = SerialPort.BytesToRead;
            //StringBuilder tempS = new StringBuilder();

            while (BufferLength > 0 && SerialPort.IsOpen)
            {
                try
                {
                    COMRx = SerialPort.ReadLine();

                    this.BeginInvoke(new EventHandler(ProcessCOMRx));

                    if (SerialPort.IsOpen)
                        BufferLength = SerialPort.BytesToRead;
                }
                catch
                {
                    this.BeginInvoke(new EventHandler(ReadLineError));
                }
            }
        }

        float ind = 0.0f;

        private void timer2_Tick(object sender, EventArgs e)
        {
            ZedGraphControl1.AxisChange();
            ZedGraphControl1.Refresh();
            ZedGraphControl2.AxisChange();
            ZedGraphControl2.Refresh();

            //COMRx =  Math.Cos(Math.PI * ind / 180.0) * 3300 + "," + Math.Sin(Math.PI * ind / 180.0) * 3300;
            COMRx = Math.Cos(ind) * 3300 + "," + Math.Sin(ind) * 3300;

            ind += 0.05f;

            this.BeginInvoke(new EventHandler(ProcessCOMRx));
            this.BeginInvoke(new EventHandler(ProcessCOMRx2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.Clear();
            LData.Clear();
            MaxLData.Clear();
            MinLData.Clear();

            deleteCurves();
            initCurves();
            initLCurves();

            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ZedGraphControl1.AxisChange();
            ZedGraphControl1.Invalidate();
        }
    }
}
