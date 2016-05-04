using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleDataReader
{
    public partial class Date : Form
    {
        List<CalendarRef> calRef;
        public Calendar parent;
        int startPos = 40;
        int spacing = 50;

        public Date()
        {
            InitializeComponent();
        }

        void showOptions()
        {
            List<Button> buttons = new List<Button>();
            for (int i = 0; i < calRef.Count; i++)
            {
                Button newButton = new Button();
                newButton.Location = new Point(10, i * spacing + startPos);
                newButton.Tag = calRef[i].getFilePath();
                newButton.Text = calRef[i].getSession().getStartTime();
                newButton.Click += new System.EventHandler(dynamicbutton_Click);
                buttons.Add(newButton);
                this.Controls.Add(newButton);

            }
        }

        public void dynamicbutton_Click(Object sender, System.EventArgs e)
        {
            Button button = sender as Button;
            parent.loadAndClose(button.Tag.ToString());
            Close();
        }

        public void setEntry(List<CalendarRef> refs)
        {
            calRef = refs;
            showOptions();
        }

    }
}
