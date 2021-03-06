﻿using System;
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
        List<double> rollingPower = new List<double>();
        List<double> totalAverages = new List<double>();

        string NP = "";
        int norm_Pow;
        int int_fac;
        int length;
        int tss_cal;

        double nth_root;

        DataSet DataSet = new DataSet();
       

        SessionData session = new SessionData();
        string filepath = @"C:\Users\Jack\Documents\GitHub\CycleAnalysis\CycleDataReader\cycle.hrm";        //put the cycle hrm file in temp to work...
        public struct SModes
        {
            public const string timetrial = "000000000";
            public const string run = "111111100";
        }

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
            DataSet.Tables.Add("Table");

            DataSet.Tables[0].Columns.Add("Heart Rate");
            DataSet.Tables[0].Columns.Add("Speed");
            DataSet.Tables[0].Columns.Add("Cadence");
            DataSet.Tables[0].Columns.Add("Altitude");
            DataSet.Tables[0].Columns.Add("Power");
            DataSet.Tables[0].Columns.Add("Power balance");
            DataSet.Tables[0].Columns.Add("Time");

        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.Filter = "txt file (*.txt)|*.txt";

            DirectoryInfo dinfo = new DirectoryInfo(@"C:\Users\Jack\Documents\GitHub\CycleAnalysis\CycleDataReader\Data");
            FileInfo[] Files = dinfo.GetFiles("*.txt");

            if (dia.ShowDialog() == DialogResult.OK)
            {
               
                foreach (FileInfo file in Files)
                {
                    filepath = file.Directory + "\\" + file.ToString();
                    LoadingFile(filepath);
                }

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

                // data for HR
                if (parseType == DataMark.hrData)
                {
                             
                    string[] columns = data[i].Split(null); 
        
                    if (session.getSMode().Equals(SModes.run))
                    {
                        dataEntry = new DataEntry();
                        dataEntry.setEntry(int.Parse(columns[0]), int.Parse(columns[1]), 
                            int.Parse(columns[2]), int.Parse(columns[3]), 
                            int.Parse(columns[4]), int.Parse(columns[5]));
                        sessionData.Add(dataEntry);
                    }

                }
            }
        }

        public void showResults()
        {
            //Header J
            this.lengthTxt.Text = session.getLength();
            this.dateTxt.Text = session.getDate();
            this.startTxt.Text = session.getStartTime();
            

            //Data 
            dataView.ColumnCount = 7;
            dataView.Columns[0].Name = "Heart Rate (Bpm)";
            dataView.Columns[1].Name = "Speed (K/ph)";
            dataView.Columns[2].Name = "Cadence";
            dataView.Columns[3].Name = "Altitude";
            dataView.Columns[4].Name = "Power (Watts)";
            dataView.Columns[5].Name = "Power Balance";
            dataView.Columns[6].Name = "Time";

            DataEntry dataEnt;
            DateTime time = session.getDateTime();
            int interval = int.Parse(session.getInterval()); //initate looper
            length = sessionData.Count;

            // WORK OUT Normalised Poweer YEYEYE
            for (int i = 0; i < sessionData.Count; i++)
            {
                dataEnt = sessionData[i];

                rollingPower.Add(dataEnt.getPower());

                if (i % 30 / interval == 0 && i > 0)
                {
                    double total = 0;

                    for (int j = 0; j < rollingPower.Count; j++)
                    {
                        rollingPower[j] = Math.Pow(rollingPower[j], 4); // times by 4th power
                        total += rollingPower[j];
                        rollingPower.Clear();
                    }

                    totalAverages.Add(total);
                }
            }


            double fullPower = 0;

            for (int i = 0; i < totalAverages.Count; i++)
            {
                fullPower += totalAverages[i];
            }

            fullPower /= totalAverages.Count;

            nth_root = Math.Round(Math.Pow(fullPower, 1 / 4.0),2); // find 4th root of the averages of powers

            norm_Pow = Convert.ToInt32(nth_root);
            
            NP = nth_root.ToString(); // convert it to string so can dsiplay


            //ADD DATA TO GRID YEYE

            for (int i = 0; i < sessionData.Count; i++)
            {
                dataEnt = sessionData[i];

                if (session.getSMode().Equals(SModes.run))
                {
                    dataView.Rows.Add(dataEnt.getHeartRate(), dataEnt.getSpeed() / 10, 
                        dataEnt.getCadence(), dataEnt.getAscent(), dataEnt.getPower(), 
                        dataEnt.getPowerBal(), time.AddSeconds(i * interval).TimeOfDay);

                    DataSet.Tables[0].Rows.Add(dataEnt.getHeartRate(), dataEnt.getSpeed() / 10,
                        dataEnt.getCadence(), dataEnt.getAscent(), dataEnt.getPower(),
                        dataEnt.getPowerBal(), time.AddSeconds(i * interval).TimeOfDay);

                }

            }
            dataView.Refresh();
            summary();

        }



        public void summary()
        {
            //average HR
            double avgHR = (from DataGridViewRow row in dataView.Rows
                               where row.Cells[0].FormattedValue.ToString() != string.Empty
                               select Convert.ToInt32(row.Cells[0].FormattedValue)).Average();

            txtAvgHR.Text = Math.Round(avgHR,2).ToString();

            int maxHR = dataView.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells[0].Value));

            string maxHER = maxHR.ToString();
            maxHRTxt.Text = maxHER;


            int minHR = dataView.Rows.Cast<DataGridViewRow>()
                        .Min(r => Convert.ToInt32(r.Cells[0].Value));

            string minHER = minHR.ToString();
            RestTxt.Text = minHER;

            //max and average Speed
            int maxSpeed = dataView.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells[1].Value));

            string maxS = maxSpeed.ToString();
            txtMaxSpeed.Text = maxS;

            double avgSpeed = (from DataGridViewRow row in dataView.Rows
                                 where row.Cells[1].FormattedValue.ToString() != string.Empty 
                                   select Convert.ToInt32(row.Cells[1].FormattedValue)).Average();

            txtAvgSpeed.Text = Math.Round(avgSpeed,2).ToString();

            //max power
            int mp = dataView.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells[4].Value));

            string maxPower = mp.ToString();
            txtMaxPower.Text = maxPower;

            double avgpow = (from DataGridViewRow row in dataView.Rows
                               where row.Cells[4].FormattedValue.ToString() != string.Empty
                               select Convert.ToInt32(row.Cells[4].FormattedValue)).Average();

            avgPower.Text = Math.Round(avgpow, 2).ToString();

            //max and average Altitude
            int alt = dataView.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells[3].Value));

            double avgAlt = (from DataGridViewRow row in dataView.Rows
                             where row.Cells[3].FormattedValue.ToString() != string.Empty
                             select Convert.ToInt32(row.Cells[3].FormattedValue)).Average();

            
            txtAvgAlt.Text = Math.Round(avgAlt,2).ToString();

            string maxAlt = alt.ToString();
            txtMaxAlt.Text = maxAlt;


            ////NORMALISISED POWER 

            NPtxt.Text = NP;

            //divide by avg power for INTENSITY FACTOR

            int_fac = Convert.ToInt32(nth_root) / Convert.ToInt32(avgpow);
            IFtxt.Text = int_fac.ToString();

            //TSS

            tss_cal = (length * norm_Pow * int_fac) / (Convert.ToInt32(avgpow) * 3600) * 100;
            TSStxt.Text = tss_cal.ToString();

        }

        private void heatRatePerMinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HeartRate frmchild = new HeartRate();
            frmchild.setData(session, sessionData);
            frmchild.Show();
        }

        private void dataView_SelectionChanged(object sender, EventArgs e)
        {
            

        }


        // So it can be done from other classes
        public void LoadingFile(string file)
        {
            filepath = file;

            // Load from txt file
            data = loadData();

            // If has appropriate size check data 
            if (data.Length > 0)
            {
                readData(data);
            }
            else
            {
                //Display error message here donny 
                Console.WriteLine("");
            }
        }

        public void manualDisplayData()
        {
            showResults();
            
        }

        // Returns 
        public SessionData getSession() { return session; }
        public List<DataEntry> getSessionData() { return sessionData; }

        private void fromDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.parent = this;
            calendar.Show();
        }

        private void dataView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int32 selectedCellCount = dataView.GetCellCount(DataGridViewElementStates.Selected);
            DataEntry dataEnt;
            DateTime time = session.getDateTime();
            int interval = int.Parse(session.getInterval()); //initate looper

            if (selectedCellCount > 0)
                {
                    if (dataView.AreAllCellsSelected(true) )
                    {
                        MessageBox.Show("All cells are selected", "Selected Cells");
                    }
                    else
                    {
                    for (int i = 0; i < selectedCellCount; i++)
                    {

                        foreach (DataGridViewRow dr in dataView.Rows)
                        {
                             dataEnt = sessionData[i];
                                dataView.Rows.Clear();
                                dataView.Rows.Add(dataEnt.getHeartRate(), dataEnt.getSpeed() / 10,
                                dataEnt.getCadence(), dataEnt.getAscent(), dataEnt.getPower(),
                                dataEnt.getPowerBal(), time.AddSeconds(i * interval).TimeOfDay);
                            
                        }

                    }
                   }    
                 }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataView.Rows.Clear();
            dataView.Show();
            showResults();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {

            DataTable clone = this.DataSet.Tables[0].Clone();

            foreach (DataGridViewRow row in dataView.SelectedRows)
            {
                object[] values = new object[row.Cells.Count];

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    values[i] = row.Cells[i].Value;

                }

                clone.Rows.Add(values);
            }

            dataView.Rows.Clear();
            dataView.Refresh();
            dataView.DataSource = DataSet.Tables[0];
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

