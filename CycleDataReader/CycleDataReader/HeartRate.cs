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
    public partial class HeartRate : Form
    {
        public HeartRate()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HeartRate_Load(object sender, EventArgs e)
        {
            CreateGraph(zg1);
            SetSize();
        }

        private void CreateGraph(ZedGraphControl zgc)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;

            // Set the Titles
            myPane.Title.Text = "Heart Rate Over Time\n (BPM)";
            myPane.XAxis.Title.Text = "Time (Mins)";
            myPane.YAxis.Title.Text = "HR (BPM)";

            // Make up some data arrays based on the Sine function
            double x, y1;
            PointPairList list1 = new PointPairList();
           
            for (int i = 0; i < 60; i++)
            {
                x = (double)i + 5;
                y1 = 50 + Math.Sin((double)i * 0.2);
                
                list1.Add(x, y1);
                
            }

            // Generate a red curve with diamond
            // symbols, and "HR" in the legend
            LineItem myCurve = myPane.AddCurve("Heart Rate",
                  list1, Color.Red, SymbolType.Circle);

            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zgc.AxisChange();


            // Change the color of the title
            myPane.Title.FontSpec.FontColor = Color.Green;

            // Add gridlines to the plot, and make them gray
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.MajorGrid.Color = Color.LightGray;
            myPane.YAxis.MajorGrid.Color = Color.LightGray;

            // Move the legend location
            myPane.Legend.Position = ZedGraph.LegendPos.Bottom;

            // Make both curves thicker
            myCurve.Line.Width = 2.0F;
            
            // Fill the area under the curves
            myCurve.Line.Fill = new Fill(Color.White, Color.Red, 45F);
           
            // Increase the symbol sizes, and fill them with solid white
            myCurve.Symbol.Size = 8.0F;
           
            myCurve.Symbol.Fill = new Fill(Color.White);

            // Add a background gradient fill to the axis frame
            myPane.Chart.Fill = new Fill(Color.White,
                Color.FromArgb(255, 255, 210), -45F);

            // Add a caption and an arrow
            TextObj myText = new TextObj("Interesting\nPoint", 230F, 70F);
            myText.FontSpec.FontColor = Color.Red;
            myText.Location.AlignH = AlignH.Center;
            myText.Location.AlignV = AlignV.Top;
            myPane.GraphObjList.Add(myText);
            ArrowObj myArrow = new ArrowObj(Color.Red, 12F, 230F, 70F, 280F, 55F);
            myPane.GraphObjList.Add(myArrow);

        }

        private void SetSize()
        {
            zg1.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            zg1.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 20);
        }
    }
}
