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

namespace CycleDataReader
{
    public partial class Form1 : Form
    {

        string date1 = "";
        string starttime1 = "";
        string length1 = "";
        string maxhr1 = "";
        string resthr1 = "";
        string vo2max1 = "";
        string weight1 = "";

        string filePath;

        public Form1()
        {
            InitializeComponent();
            ReadFile();
            insertData();
        }

        public void ReadFile()
        {
            filePath = @"C:\Temp\cycle.hrm";

            if (File.Exists(filePath))

                processfile(filePath);

            else
                System.Console.WriteLine("Error - File {0}  not Found", filePath);


        }

        public void processfile(String filePath)
        {

            try
            {

                String[] lines = File.ReadAllLines(filePath);
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
        public Random rand = new Random();

        public void insertData()
        {
            // read first ten line
            IEnumerable<string> lines = File.ReadAllLines(filePath);
            var lineToRead = rand.Next(1, lines.Count());
            var line = lines.Skip(lineToRead - 130).First();

            //ListViewItem item1 = new ListViewItem(date1 + "");
            //item1.SubItems.Add(starttime1 + "");
            //item1.SubItems.Add(length1 + "");
            //item1.SubItems.Add(maxhr1 + "");
            //item1.SubItems.Add(resthr1 + "");
            //item1.SubItems.Add(vo2max1 + "");

            //listView1.Items.AddRange(new ListViewItem[] { item1 });

            textBox1.Text = line;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cycling Analysis Program              \n\r\n\rLeeds Beckett University               \n\r\n\r(C) 2015 Jack Wren");
        }


     }
    
}
