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
    public partial class Calendar : Form
    {
        
        public Calendar()
        {
            InitializeComponent();
            loadCalendar();
        }

        public Home parent;
        List<CalendarRef> calRef = new List<CalendarRef>();
        List<CalendarRef> toShow = new List<CalendarRef>();

        private void loadCalendar()
        {
           
            Home frmchild = new Home();
            SessionData sesh;
            string filepath;
            calRef = new List<CalendarRef>();
            DirectoryInfo dinfo = new DirectoryInfo(@"F:\CycleDataReader\Data");
            FileInfo[] Files = dinfo.GetFiles("*.txt");

            foreach (FileInfo file in Files)
            {
                filepath = file.Directory + "\\" + file.ToString();

                frmchild = new Home();
                frmchild.LoadingFile(filepath);
                sesh = new SessionData();
                sesh = frmchild.getSession();

                // Makes a calendar ref for later    
                CalendarRef calendar = new CalendarRef(sesh, filepath);
                calRef.Add(calendar);


                monthCalendar1.AddBoldedDate(sesh.getDateTime());
            }

            for (int i = 0; i < calRef.Count; i++)
            {
                Console.WriteLine(calRef[i].getSession().getDateTime().Date);
            }
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dateT = e.Start;

            for (int i = 0; i < calRef.Count; i++)
            {
                Console.WriteLine(calRef[i].getSession().getDateTime().Date);
                if (dateT.Date == calRef[i].getSession().getDateTime().Date)
                {
                    toShow.Add(calRef[i]);
                    Console.WriteLine(dateT.ToString());
                }
            }

            if (toShow.Count > 0)
            {
                displayData();
            }
        }

        void displayData()
        {
            if (toShow.Count > 1)
            {
                Date selectD = new Date();
                selectD.setEntry(toShow);
                selectD.parent = this;
                selectD.Show();
                toShow.Clear();
            }
            else
            {
                parent.LoadingFile(toShow[0].getFilePath());
                parent.manualDisplayData();
                Close();
            }
        }

        public void loadAndClose(string file)
        {
            parent.LoadingFile(file);
            parent.manualDisplayData();
            Close();
        }


    }

    // Class for refeence
    public class CalendarRef
    {
        string filepath;
        SessionData session;

        public CalendarRef(SessionData sesh, string file)
        {
            session = sesh;
            filepath = file;
        }

        public SessionData getSession() { return session; }
        public string getFilePath() { return filepath; }


    }

}
