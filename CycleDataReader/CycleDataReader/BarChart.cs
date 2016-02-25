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

namespace CycleDataReader
{
    public partial class BarChart : Form
    {
        public string MaxH { get; set; }
        public string AvgH { get; set; }
        //public string MinH { get; set; }

        public string MaxA { get; set; }
        public string AvgA { get; set; }
        //public string MinA { get; set; }

        public string MaxS { get; set; }
        public string AvgS { get; set; }
        //public string MinS { get; set; }

        public string MaxP { get; set; }
        //public string AvgP { get; set; }
        //public string MinP { get; set; }

        public int MaxHR = 0;
        public int AvgHR = 0;

        public int MaxAlt = 0;
        public int AvgAlt = 0;

        public int MaxSpd = 0;
        public int AvgSpd = 0;

        public int MaxPow = 0;
        //public int AvgPow = 0;

        public BarChart()
        {
            InitializeComponent();
        }

        private void BarChart_Load(object sender, EventArgs e)
        {
            CreateGraph(zg1);

            MaxHR = Int32.Parse(MaxH);
            AvgHR = Int32.Parse(AvgH);

            MaxAlt = Int32.Parse(MaxA);
            AvgAlt = Int32.Parse(AvgA);

            MaxSpd = Int32.Parse(MaxS);
            AvgSpd = Int32.Parse(AvgS);

            MaxPow = Int32.Parse(MaxP);
            //AvgPow = Int32.Parse(AvgP);

        }

        private void CreateGraph(ZedGraphControl zgc)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zg1.GraphPane;

            // Set the Titles
            myPane.Title.Text = "Summary Bar Chart";
            myPane.XAxis.Title.Text = "Summary";
            myPane.YAxis.Title.Text = "Values";

            // Make up some random data points
            string[] labels = { "Heart Rate", "Altitude", "Speed", 
                      "Power"};
            double[] y = { 195, 313, 300, 500 };
            double[] y2 = { 146, 308, 140, 50 };
            //double[] y3 = { 46, 308, 40, 50};

            // Generate a red bar with "Curve 1" in the legend
            BarItem myBar = myPane.AddBar("Max", null, y,
                                                        Color.Red);
            myBar.Bar.Fill = new Fill(Color.Red, Color.White,
                                                        Color.Red);

            // Generate a blue bar with "Curve 2" in the legend
            myBar = myPane.AddBar("Average", null, y2, Color.Blue);
            myBar.Bar.Fill = new Fill(Color.Blue, Color.White,
                                                        Color.Blue);

            // Generate a green bar with "Curve 3" in the legend
            //myBar = myPane.AddBar("Min", null, y3, Color.Green);
            //myBar.Bar.Fill = new Fill(Color.Green, Color.White,
            //                                            Color.Green);

            // Draw the X tics between the labels instead of 
            // at the labels
            myPane.XAxis.MajorTic.IsBetweenLabels = true;

            // Set the XAxis labels
            myPane.XAxis.Scale.TextLabels = labels;
            // Set the XAxis to Text type
            myPane.XAxis.Type = AxisType.Text;

            // Fill the Axis and Pane backgrounds
            myPane.Chart.Fill = new Fill(Color.White,
                  Color.FromArgb(255, 255, 166), 90F);
            myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));

            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zg1.AxisChange();

        }
    }
}
