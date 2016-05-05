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
        SessionData session = new SessionData();
        List<DataEntry> sessionData = new List<DataEntry>();

        /// <summary>
        GraphPane GraphP;

        // variables
        LineItem OneC;
        LineItem TwoC;
        LineItem ThreeC;
        LineItem FourC;
        LineItem FiveC;
        
        PointPairList list1 = new PointPairList();
        PointPairList list2 = new PointPairList();
        PointPairList list3 = new PointPairList();
        PointPairList list4 = new PointPairList();
        PointPairList list5 = new PointPairList();
        
        /// </summary>

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
            showData();

        }

        public void setData(SessionData sesh, List<DataEntry> data)
        {
            session = sesh;
            sessionData = data;
        }

        public void showData()
        {
            GraphP = zg1.GraphPane;

            GraphP.Title.Text = "Cycle Data";
            GraphP.XAxis.Title.Text = "Time (Secs)";
            GraphP.YAxis.Title.Text = "Values";

            GraphP.YAxis.Scale.Min = 10.0;
            GraphP.YAxis.Scale.Max = 700.0;

            int length = sessionData.Count;
            int interval = int.Parse(session.getInterval());

            GraphP.XAxis.Scale.Min = 0;
            GraphP.XAxis.Scale.Max = length * interval;


            // SET THE VALUES                    
            for (int i = 0; i < length; i++)
            {
                DataEntry da = sessionData[i];
                int it = i * interval;

                list1.Add(it, da.getHeartRate());
                list2.Add(it, da.getSpeed() / 10);
                list3.Add(it, da.getCadence());
                list4.Add(it, da.getAscent());
                list5.Add(it, da.getPower());
                
            }



            OneC = GraphP.AddCurve(null, list1, Color.Red, SymbolType.None);
            TwoC = GraphP.AddCurve(null, list2, Color.DarkOrange, SymbolType.None);
            ThreeC = GraphP.AddCurve(null, list3, Color.Blue, SymbolType.None);
            FourC = GraphP.AddCurve(null, list4, Color.Green, SymbolType.None);
            FiveC = GraphP.AddCurve(null, list5, Color.Purple, SymbolType.None);
            

            // draw 
            zg1.AxisChange();

            // Change the color of the title
            GraphP.Title.FontSpec.FontColor = Color.Green;

            // Add gridlines to the plot, and make them gray
            GraphP.XAxis.MajorGrid.IsVisible = true;
            GraphP.YAxis.MajorGrid.IsVisible = true;
            GraphP.XAxis.MajorGrid.Color = Color.LightGray;
            GraphP.YAxis.MajorGrid.Color = Color.LightGray;

            // Move the legend location
            GraphP.Legend.Position = ZedGraph.LegendPos.Bottom;

            // Make both curves thicker
            OneC.Line.Width = 2.0F;
            TwoC.Line.Width = 2.0F;
            ThreeC.Line.Width = 2.0F;
            FourC.Line.Width = 2.0F;
            FiveC.Line.Width = 2.0F;


            // Add a background gradient fill to the axis frame
            GraphP.Chart.Fill = new Fill(Color.White,
                Color.FromArgb(255, 255, 210), -45F);

          

        }

        //Check Boxes HR
        private void hrBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GraphP.CurveList.Contains(OneC))
            {
                GraphP.CurveList.Remove(OneC);
            }
            else
            {
                OneC = GraphP.AddCurve(null, list1, Color.Red, SymbolType.None);
            }

            GraphP.AxisChange();
            zg1.Refresh();
        }
        //Check Box Speed
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (GraphP.CurveList.Contains(TwoC))
            {
                GraphP.CurveList.Remove(TwoC);
            }
            else
            {
                TwoC = GraphP.AddCurve(null, list2, Color.DarkOrange, SymbolType.None);
            }

            GraphP.AxisChange();
            zg1.Refresh();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (GraphP.CurveList.Contains(ThreeC))
            {
                GraphP.CurveList.Remove(ThreeC);
            }
            else
            {
                ThreeC = GraphP.AddCurve(null, list3, Color.Blue, SymbolType.None);
            }

            GraphP.AxisChange();
            zg1.Refresh();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (GraphP.CurveList.Contains(FourC))
            {
                GraphP.CurveList.Remove(FourC);
            }
            else
            {
                FourC = GraphP.AddCurve(null, list4, Color.Green, SymbolType.None);
            }

            GraphP.AxisChange();
            zg1.Refresh();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (GraphP.CurveList.Contains(FiveC))
            {
                GraphP.CurveList.Remove(FiveC);
            }
            else
            {
                FiveC = GraphP.AddCurve(null, list5, Color.Purple, SymbolType.None);
            }

            GraphP.AxisChange();
            zg1.Refresh();
        }


    }
}
