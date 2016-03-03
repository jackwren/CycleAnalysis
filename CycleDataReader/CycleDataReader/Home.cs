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
using System.Collections;

namespace CycleDataReader
{
    public partial class Home : Form
    {

        string date1 = "";
        string starttime1 = "";
        string length1 = "";
        string maxhr1 = "";
        string resthr1 = "";
        string vo2max1 = "";
        string weight1 = "";

        List<string> hrCol = new List<string>();

        SessionData session = new SessionData();
        string filepath = @"C:\temp\cycle.hrm";


        struct DataMark
        {
            public const string hrData = "[HRData]";
            public const string docInfo = "[Params]";
            public const string intTimes = "[IntTimes]";
        }

        struct SessionVar
        {
            public const string version = "Version";
            public const string smode = "SMode";
            public const string date = "Date";
            public const string startTime = "StartTime";
            public const string length = "Length";
            public const string interval = "Interval";
        }

        string[] data;

        List<DataEntry> sessionData = new List<DataEntry>();


        public Home()
        {
            InitializeComponent();
            ReadFile();


        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.Filter = "hrm file (*.hrm)|*.hrm";

            if (dia.ShowDialog() == DialogResult.OK)
            {
                filepath = dia.FileName;

                MessageBox.Show(dia.FileName);
                dataView.Rows.Clear();
                dataView.Refresh();
                showResults();
            }
        }

        public void ReadFile()
        {

            if (File.Exists(filepath))

                processfile(filepath);

            else
                System.Console.WriteLine("Error - File {0}  not Found", filepath);


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cycling Analysis Program              \n\r\n\rLeeds Beckett University               \n\r\n\r(C) 2015 Jack Wren");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            data = loadData();

            if (data.Length > 0)
            {
                readData(data);
                showResults();
            }
            else
            {
                Console.WriteLine("Broke");
            }

        }


        public void processfile(String filePath)
        {

            try
            {

                String[] lines = File.ReadAllLines(filepath);
                IEnumerable<String> date = from n in lines
                                           where n.StartsWith("Date")
                                           select n.Split('=')[1];
                IEnumerable<String> starttime = from n in lines
                                                where n.StartsWith("StartTime")
                                                select n.Split('=')[1];
                IEnumerable<String> length = from n in lines
                                             where n.StartsWith("Length")
                                             select n.Split('=')[1];
                IEnumerable<String> maxhr = from n in lines
                                            where n.StartsWith("MaxHR")
                                            select n.Split('=')[1];
                IEnumerable<String> resthr = from n in lines
                                             where n.StartsWith("RestHR")
                                             select n.Split('=')[1];
                IEnumerable<String> vo2max = from n in lines
                                             where n.StartsWith("VO2max")
                                             select n.Split('=')[1];
                IEnumerable<String> weight = from n in lines
                                             where n.StartsWith("Weight")
                                             select n.Split('=')[1];
                foreach (String d in date)
                {
                    Console.WriteLine(d);
                    date1 = d;
                }
                foreach (String d in starttime)
                {
                    Console.WriteLine(d);
                    starttime1 = d;
                }
                foreach (String d in length)
                {
                    Console.WriteLine(d);
                    length1 = d;
                }
                foreach (String d in maxhr)
                {
                    Console.WriteLine(d);
                    maxhr1 = d;
                }
                foreach (String d in resthr)
                {
                    Console.WriteLine(d);
                    resthr1 = d;
                }
                foreach (String d in vo2max)
                {
                    Console.WriteLine(d);
                    vo2max1 = d;
                }
                foreach (String d in weight)
                {
                    Console.WriteLine(d);
                    weight1 = d;
                }

                dateTxt.Text = date1;
                startTxt.Text = starttime1;
                lengthTxt.Text = length1;
                maxHRTxt.Text = maxhr1;
                RestTxt.Text = resthr1;
                VO2txt.Text = vo2max1;
                weightTxt.Text = weight1;


            }
            catch (IOException e)
            {
                MessageBox.Show("Broke");
            }

        }

        private string[] loadData()
        {
            string[] lines = System.IO.File.ReadAllLines(filepath);
            return lines;
        }


        public void readData(string[] data)
        {
            DataEntry dataEntry;
            string parseType = "";

            for (int i = 0; i < data.Length; i++)
            {
               
                if (data[i] == DataMark.hrData)
                {
                    parseType = DataMark.hrData;
                    i++; 
                }
                if (data[i] == DataMark.docInfo)
                {
                    parseType = DataMark.docInfo;
                    i++;
                }
                if (data[i] == DataMark.intTimes)
                {
                    parseType = DataMark.intTimes;
                    i++;
                }

                if (parseType == DataMark.docInfo)
                {
                    // Delmiter splits row by 0 = type , 1 = value
                    string[] columns = data[i].Split('=');

                    if (columns[0] == SessionVar.version)
                    {
                        session.setVersion(columns[1]);
                    }
                    if (columns[0] == SessionVar.date)
                    {
                        session.setDate(columns[1]);
                    }
                    if (columns[0] == SessionVar.length)
                    {
                        session.setLenth(columns[1]);
                    }
                    if (columns[0] == SessionVar.smode)
                    {
                        session.setSMode(columns[1]);
                    }
                    if (columns[0] == SessionVar.startTime)
                    {
                        session.setStartTime(columns[1]);
                    }
                    if (columns[0] == SessionVar.interval)
                    {
                        session.setInterval(columns[1]);
                    }
                }

                // HR DATA
                if (parseType == DataMark.hrData)
                {
                    //Split per line          
                    string[] columns = data[i].Split(null);

                    dataEntry = new DataEntry();
                    dataEntry.setEntry(int.Parse(columns[0]), 
                                       int.Parse(columns[1]), 
                                       int.Parse(columns[2]), 
                                       int.Parse(columns[3]), 
                                       int.Parse(columns[4]), 
                                       int.Parse(columns[5]));

                    sessionData.Add(dataEntry);
                }
            }
        }

        public void showResults()
        {
            dataView.ColumnCount = 7;
            dataView.Columns[0].Name = "Heart Rate (Bpm)";
            dataView.Columns[1].Name = "Speed (Km/h)";
            dataView.Columns[2].Name = "Cadence (Rpm)";
            dataView.Columns[3].Name = "Altitude (M/ft)";
            dataView.Columns[4].Name = "Power (Watts)";
            dataView.Columns[5].Name = "Power Balance (Pedal Index)";
            dataView.Columns[6].Name = "Time";

            DataEntry dataEnt;
            DateTime time = session.getDateTime();
            int interval = int.Parse(session.getInterval());

            // Loop through entries
            for (int i = 0; i < sessionData.Count; i++)
            {
                dataEnt = sessionData[i];

                dataView.Rows.Add(dataEnt.getHeartRate(),
                                  dataEnt.getSpeed(),
                                  dataEnt.getCadence(),
                                  dataEnt.getAscent(),
                                  dataEnt.getPower(),
                                  dataEnt.getPowerBal(),
                                  time.AddSeconds(i * interval).TimeOfDay);
            }

            summary();

        }


        public void summary()
        {
            //average HR
            string avgHR = (from DataGridViewRow row in dataView.Rows
                               where row.Cells[0].FormattedValue.ToString() != string.Empty
                               select Convert.ToInt32(row.Cells[0].FormattedValue)).Average().ToString();

            txtAvgHR.Text = avgHR;
                
            //max and average Speed
            int maxSpeed = dataView.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells[1].Value));

            string maxS = maxSpeed.ToString();
            txtMaxSpeed.Text = maxS;

            string avgSpeed = (from DataGridViewRow row in dataView.Rows
                                 where row.Cells[1].FormattedValue.ToString() != string.Empty 
                                   select Convert.ToInt32(row.Cells[1].FormattedValue)).Average().ToString();

            txtAvgSpeed.Text = avgSpeed;

            //max power
            int mp = dataView.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells[4].Value));

            string maxPower = mp.ToString();
            txtMaxPower.Text = maxPower;

            //max and average Altitude
            int alt = dataView.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells[3].Value));

            string avgAlt = (from DataGridViewRow row in dataView.Rows
                             where row.Cells[3].FormattedValue.ToString() != string.Empty
                             select Convert.ToInt32(row.Cells[3].FormattedValue)).Average().ToString();

            txtAvgAlt.Text = avgAlt;

            string maxAlt = alt.ToString();
            txtMaxAlt.Text = maxAlt;


            //foreach (DataGridViewRow item in dataView.Rows)
            //{
            //    hrCol.Add(item.Cells[0].Value.ToString());
            //}

        }

        private void heatRatePerMinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HeartRate frmchild = new HeartRate();
            frmchild.setData(session, sessionData);
            frmchild.Show();
        }

        private void barChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarChart frmchild = new BarChart();

            frmchild.MaxH = maxHRTxt.Text;
            frmchild.AvgH = txtAvgHR.Text;
            //frmchild.MinH = maxHRTxt.Text;

            frmchild.MaxA = txtMaxAlt.Text;
            frmchild.AvgA = txtAvgAlt.Text;
            //frmchild.MinA = maxHRTxt.Text;

            frmchild.MaxS = txtMaxSpeed.Text;
            frmchild.AvgS = txtAvgSpeed.Text;
            //frmchild.MinS = maxHRTxt.Text;

            frmchild.MaxP = txtMaxPower.Text;
            //frmchild.AvgP = ;
            //frmchild.MinP = maxHRTxt.Text;

            frmchild.Show();
        }

        
    }

    public class DataEntry
    {
        int heartRate;
        int speed;
        int cadence;
        int alt;
        int power;
        int powerBal;

        public void setEntry(int heartRate, int speed, int cadence, int altitude, int power, int powerBal)
        {
            this.heartRate = heartRate;
            this.speed = speed;
            this.cadence = cadence;
            this.alt = altitude;
            this.power = power;
            this.powerBal = powerBal;
        }

        public string getEntry()
        {
            string gap = ", ";
            string data = getHeartRate() + gap + getSpeed() + gap + cadence + gap + alt + gap + power + gap + powerBal + " ||";
            return data;
        }


        public int getHeartRate()
        {
            return heartRate;
        }
        public int getSpeed()
        {
            return speed;
        }
        public int getCadence()
        {
            return cadence;
        }
        public int getAscent()
        {
            return alt;
        }
        public int getPower()
        {
            return power;
        }
        public int getPowerBal()
        {
            return powerBal;
        }

    }

    public class SessionData
    {
        string version;
        string sMode;
        string date;
        string startTime;
        string length;
        string interval;

        public void setVersion(string version)
        {
            this.version = version;
        }
        public void setSMode(string sMode)
        {
            this.sMode = sMode;
        }
        public void setDate(string date)
        {
            this.date = date;
        }
        public void setStartTime(string startTime)
        {
            this.startTime = startTime;
        }
        public void setLenth(string length)
        {
            this.length = length;
        }
        public void setInterval(string interval)
        {
            this.interval = interval;
        }

        public string getVersion() { return version; }
        public string getSMode() { return sMode; }
        public string getDate() { return date; }
        public string getStartTime() { return startTime; }
        public string getLength() { return length; }
        public string getInterval() { return interval; }


        // Returns datetime object 
        public DateTime getDateTime()
        {
            string date = getDate();
            string time = getStartTime();

            int year = int.Parse(date.Substring(0, 4));
            int month = int.Parse(date.Substring(4, 2));
            int day = int.Parse(date.Substring(6, 2));


            int hour = int.Parse(time.Substring(0, 2));
            int minute = int.Parse(time.Substring(3, 2));
            int second = int.Parse(time.Substring(6, 2));

            DateTime dt = new DateTime(year, month, day, hour, minute, second);
            return dt;
        }


    }

}

