namespace CycleDataReader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Heart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cadence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Altitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Power = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PowerB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.maxHrLabel = new System.Windows.Forms.Label();
            this.restLabel = new System.Windows.Forms.Label();
            this.vo2Label = new System.Windows.Forms.Label();
            this.weigthLabel = new System.Windows.Forms.Label();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.startTxt = new System.Windows.Forms.TextBox();
            this.lengthTxt = new System.Windows.Forms.TextBox();
            this.maxHRTxt = new System.Windows.Forms.TextBox();
            this.RestTxt = new System.Windows.Forms.TextBox();
            this.VO2txt = new System.Windows.Forms.TextBox();
            this.weightTxt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Heart,
            this.Speed,
            this.Cadence,
            this.Altitude,
            this.Power,
            this.PowerB});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 205);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1083, 290);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Heart
            // 
            this.Heart.Text = "Heart Rate (BPM)";
            this.Heart.Width = 129;
            // 
            // Speed
            // 
            this.Speed.Text = "Speed (Km/h)";
            this.Speed.Width = 143;
            // 
            // Cadence
            // 
            this.Cadence.Text = "Cadence (rpm)";
            this.Cadence.Width = 143;
            // 
            // Altitude
            // 
            this.Altitude.Text = "Altitude (m/ft)";
            this.Altitude.Width = 165;
            // 
            // Power
            // 
            this.Power.Text = "Power (Watts)";
            this.Power.Width = 161;
            // 
            // PowerB
            // 
            this.PowerB.Text = "Power Balance";
            this.PowerB.Width = 124;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(24, 55);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 20);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date:";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(24, 91);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(86, 20);
            this.startLabel.TabIndex = 4;
            this.startLabel.Text = "Start Time:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(24, 128);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(63, 20);
            this.lengthLabel.TabIndex = 5;
            this.lengthLabel.Text = "Length:";
            // 
            // maxHrLabel
            // 
            this.maxHrLabel.AutoSize = true;
            this.maxHrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxHrLabel.Location = new System.Drawing.Point(287, 55);
            this.maxHrLabel.Name = "maxHrLabel";
            this.maxHrLabel.Size = new System.Drawing.Size(125, 20);
            this.maxHrLabel.TabIndex = 6;
            this.maxHrLabel.Text = "Max Heart Rate:";
            // 
            // restLabel
            // 
            this.restLabel.AutoSize = true;
            this.restLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restLabel.Location = new System.Drawing.Point(287, 91);
            this.restLabel.Name = "restLabel";
            this.restLabel.Size = new System.Drawing.Size(130, 20);
            this.restLabel.TabIndex = 7;
            this.restLabel.Text = "Rest Heart Rate:";
            // 
            // vo2Label
            // 
            this.vo2Label.AutoSize = true;
            this.vo2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vo2Label.Location = new System.Drawing.Point(287, 128);
            this.vo2Label.Name = "vo2Label";
            this.vo2Label.Size = new System.Drawing.Size(78, 20);
            this.vo2Label.TabIndex = 8;
            this.vo2Label.Text = "VO2 Max:";
            // 
            // weigthLabel
            // 
            this.weigthLabel.AutoSize = true;
            this.weigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weigthLabel.Location = new System.Drawing.Point(547, 55);
            this.weigthLabel.Name = "weigthLabel";
            this.weigthLabel.Size = new System.Drawing.Size(96, 20);
            this.weigthLabel.TabIndex = 9;
            this.weigthLabel.Text = "Weight (Kg):";
            // 
            // dateTxt
            // 
            this.dateTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTxt.Location = new System.Drawing.Point(78, 58);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(100, 15);
            this.dateTxt.TabIndex = 10;
            // 
            // startTxt
            // 
            this.startTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.startTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTxt.Location = new System.Drawing.Point(116, 94);
            this.startTxt.Name = "startTxt";
            this.startTxt.Size = new System.Drawing.Size(100, 15);
            this.startTxt.TabIndex = 11;
            // 
            // lengthTxt
            // 
            this.lengthTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lengthTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lengthTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthTxt.Location = new System.Drawing.Point(93, 133);
            this.lengthTxt.Name = "lengthTxt";
            this.lengthTxt.Size = new System.Drawing.Size(100, 15);
            this.lengthTxt.TabIndex = 12;
            // 
            // maxHRTxt
            // 
            this.maxHRTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maxHRTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxHRTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxHRTxt.Location = new System.Drawing.Point(418, 58);
            this.maxHRTxt.Name = "maxHRTxt";
            this.maxHRTxt.Size = new System.Drawing.Size(100, 15);
            this.maxHRTxt.TabIndex = 13;
            // 
            // RestTxt
            // 
            this.RestTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.RestTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RestTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestTxt.Location = new System.Drawing.Point(423, 94);
            this.RestTxt.Name = "RestTxt";
            this.RestTxt.Size = new System.Drawing.Size(100, 15);
            this.RestTxt.TabIndex = 14;
            // 
            // VO2txt
            // 
            this.VO2txt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.VO2txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VO2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VO2txt.Location = new System.Drawing.Point(371, 131);
            this.VO2txt.Name = "VO2txt";
            this.VO2txt.Size = new System.Drawing.Size(100, 15);
            this.VO2txt.TabIndex = 15;
            // 
            // weightTxt
            // 
            this.weightTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.weightTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weightTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTxt.Location = new System.Drawing.Point(649, 58);
            this.weightTxt.Name = "weightTxt";
            this.weightTxt.Size = new System.Drawing.Size(100, 15);
            this.weightTxt.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1118, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // graphsToolStripMenuItem
            // 
            this.graphsToolStripMenuItem.Name = "graphsToolStripMenuItem";
            this.graphsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.graphsToolStripMenuItem.Text = "Graphs";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 528);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 77);
            this.textBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1118, 659);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.weightTxt);
            this.Controls.Add(this.VO2txt);
            this.Controls.Add(this.RestTxt);
            this.Controls.Add(this.maxHRTxt);
            this.Controls.Add(this.lengthTxt);
            this.Controls.Add(this.startTxt);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.weigthLabel);
            this.Controls.Add(this.vo2Label);
            this.Controls.Add(this.restLabel);
            this.Controls.Add(this.maxHrLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Heart;
        private System.Windows.Forms.ColumnHeader Speed;
        private System.Windows.Forms.ColumnHeader Cadence;
        private System.Windows.Forms.ColumnHeader Altitude;
        private System.Windows.Forms.ColumnHeader Power;
        private System.Windows.Forms.ColumnHeader PowerB;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label maxHrLabel;
        private System.Windows.Forms.Label restLabel;
        private System.Windows.Forms.Label vo2Label;
        private System.Windows.Forms.Label weigthLabel;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.TextBox startTxt;
        private System.Windows.Forms.TextBox lengthTxt;
        private System.Windows.Forms.TextBox maxHRTxt;
        private System.Windows.Forms.TextBox RestTxt;
        private System.Windows.Forms.TextBox VO2txt;
        private System.Windows.Forms.TextBox weightTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;



    }
}

