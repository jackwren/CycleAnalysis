namespace CycleDataReader
{
    partial class Home
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.maxHrLabel = new System.Windows.Forms.Label();
            this.restLabel = new System.Windows.Forms.Label();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.startTxt = new System.Windows.Forms.TextBox();
            this.lengthTxt = new System.Windows.Forms.TextBox();
            this.maxHRTxt = new System.Windows.Forms.TextBox();
            this.RestTxt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heatRatePerMinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.sumLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAvgHR = new System.Windows.Forms.TextBox();
            this.txtMaxSpeed = new System.Windows.Forms.TextBox();
            this.txtAvgSpeed = new System.Windows.Forms.TextBox();
            this.txtMaxPower = new System.Windows.Forms.TextBox();
            this.txtAvgAlt = new System.Windows.Forms.TextBox();
            this.txtMaxAlt = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.avgPower = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TSStxt = new System.Windows.Forms.TextBox();
            this.IFtxt = new System.Windows.Forms.TextBox();
            this.NPtxt = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
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
            this.maxHrLabel.Location = new System.Drawing.Point(816, 219);
            this.maxHrLabel.Name = "maxHrLabel";
            this.maxHrLabel.Size = new System.Drawing.Size(125, 20);
            this.maxHrLabel.TabIndex = 6;
            this.maxHrLabel.Text = "Max Heart Rate:";
            // 
            // restLabel
            // 
            this.restLabel.AutoSize = true;
            this.restLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restLabel.Location = new System.Drawing.Point(816, 255);
            this.restLabel.Name = "restLabel";
            this.restLabel.Size = new System.Drawing.Size(130, 20);
            this.restLabel.TabIndex = 7;
            this.restLabel.Text = "Rest Heart Rate:";
            // 
            // dateTxt
            // 
            this.dateTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTxt.Location = new System.Drawing.Point(78, 58);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(100, 15);
            this.dateTxt.TabIndex = 10;
            // 
            // startTxt
            // 
            this.startTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTxt.Location = new System.Drawing.Point(116, 94);
            this.startTxt.Name = "startTxt";
            this.startTxt.Size = new System.Drawing.Size(100, 15);
            this.startTxt.TabIndex = 11;
            // 
            // lengthTxt
            // 
            this.lengthTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lengthTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lengthTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthTxt.Location = new System.Drawing.Point(93, 133);
            this.lengthTxt.Name = "lengthTxt";
            this.lengthTxt.Size = new System.Drawing.Size(100, 15);
            this.lengthTxt.TabIndex = 12;
            // 
            // maxHRTxt
            // 
            this.maxHRTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.maxHRTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxHRTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxHRTxt.Location = new System.Drawing.Point(947, 222);
            this.maxHRTxt.Name = "maxHRTxt";
            this.maxHRTxt.Size = new System.Drawing.Size(100, 15);
            this.maxHRTxt.TabIndex = 13;
            // 
            // RestTxt
            // 
            this.RestTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RestTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RestTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestTxt.Location = new System.Drawing.Point(952, 258);
            this.RestTxt.Name = "RestTxt";
            this.RestTxt.Size = new System.Drawing.Size(100, 15);
            this.RestTxt.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 24);
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            this.graphsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heatRatePerMinToolStripMenuItem});
            this.graphsToolStripMenuItem.Name = "graphsToolStripMenuItem";
            this.graphsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.graphsToolStripMenuItem.Text = "Graphs";
            // 
            // heatRatePerMinToolStripMenuItem
            // 
            this.heatRatePerMinToolStripMenuItem.Name = "heatRatePerMinToolStripMenuItem";
            this.heatRatePerMinToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.heatRatePerMinToolStripMenuItem.Text = "Heart rate per min";
            this.heatRatePerMinToolStripMenuItem.Click += new System.EventHandler(this.heatRatePerMinToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromDateToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // fromDateToolStripMenuItem
            // 
            this.fromDateToolStripMenuItem.Name = "fromDateToolStripMenuItem";
            this.fromDateToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.fromDateToolStripMenuItem.Text = "From Date";
            this.fromDateToolStripMenuItem.Click += new System.EventHandler(this.fromDateToolStripMenuItem_Click);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataView.Location = new System.Drawing.Point(28, 176);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(762, 471);
            this.dataView.TabIndex = 18;
            this.dataView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataView_CellMouseUp);
            this.dataView.SelectionChanged += new System.EventHandler(this.dataView_SelectionChanged);
            // 
            // sumLbl
            // 
            this.sumLbl.AutoSize = true;
            this.sumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumLbl.Location = new System.Drawing.Point(816, 176);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(84, 20);
            this.sumLbl.TabIndex = 19;
            this.sumLbl.Text = "Summary: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(816, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Average Heart Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(816, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Average Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(816, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Max Speed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(816, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Average Altitude:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(816, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Max Power:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(816, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Max Altitude:";
            // 
            // txtAvgHR
            // 
            this.txtAvgHR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAvgHR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAvgHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgHR.Location = new System.Drawing.Point(977, 295);
            this.txtAvgHR.Name = "txtAvgHR";
            this.txtAvgHR.Size = new System.Drawing.Size(100, 15);
            this.txtAvgHR.TabIndex = 27;
            // 
            // txtMaxSpeed
            // 
            this.txtMaxSpeed.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMaxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxSpeed.Location = new System.Drawing.Point(915, 336);
            this.txtMaxSpeed.Name = "txtMaxSpeed";
            this.txtMaxSpeed.Size = new System.Drawing.Size(100, 15);
            this.txtMaxSpeed.TabIndex = 28;
            // 
            // txtAvgSpeed
            // 
            this.txtAvgSpeed.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAvgSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAvgSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgSpeed.Location = new System.Drawing.Point(945, 372);
            this.txtAvgSpeed.Name = "txtAvgSpeed";
            this.txtAvgSpeed.Size = new System.Drawing.Size(100, 15);
            this.txtAvgSpeed.TabIndex = 29;
            // 
            // txtMaxPower
            // 
            this.txtMaxPower.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMaxPower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaxPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxPower.Location = new System.Drawing.Point(912, 407);
            this.txtMaxPower.Name = "txtMaxPower";
            this.txtMaxPower.Size = new System.Drawing.Size(100, 15);
            this.txtMaxPower.TabIndex = 30;
            // 
            // txtAvgAlt
            // 
            this.txtAvgAlt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAvgAlt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAvgAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgAlt.Location = new System.Drawing.Point(947, 473);
            this.txtAvgAlt.Name = "txtAvgAlt";
            this.txtAvgAlt.Size = new System.Drawing.Size(100, 15);
            this.txtAvgAlt.TabIndex = 31;
            // 
            // txtMaxAlt
            // 
            this.txtMaxAlt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMaxAlt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaxAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxAlt.Location = new System.Drawing.Point(922, 508);
            this.txtMaxAlt.Name = "txtMaxAlt";
            this.txtMaxAlt.Size = new System.Drawing.Size(100, 15);
            this.txtMaxAlt.TabIndex = 32;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(687, 133);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(103, 34);
            this.loadButton.TabIndex = 33;
            this.loadButton.Text = "Load File";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // avgPower
            // 
            this.avgPower.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.avgPower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avgPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgPower.Location = new System.Drawing.Point(935, 442);
            this.avgPower.Name = "avgPower";
            this.avgPower.Size = new System.Drawing.Size(100, 15);
            this.avgPower.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(816, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Average Power:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 36;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(816, 569);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Normalised Power:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(924, 598);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "IF:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(908, 627);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "TSS:";
            // 
            // TSStxt
            // 
            this.TSStxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TSStxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TSStxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSStxt.Location = new System.Drawing.Point(958, 630);
            this.TSStxt.Name = "TSStxt";
            this.TSStxt.Size = new System.Drawing.Size(100, 15);
            this.TSStxt.TabIndex = 42;
            // 
            // IFtxt
            // 
            this.IFtxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.IFtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IFtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IFtxt.Location = new System.Drawing.Point(962, 601);
            this.IFtxt.Name = "IFtxt";
            this.IFtxt.Size = new System.Drawing.Size(100, 15);
            this.IFtxt.TabIndex = 41;
            // 
            // NPtxt
            // 
            this.NPtxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NPtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NPtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPtxt.Location = new System.Drawing.Point(958, 572);
            this.NPtxt.Name = "NPtxt";
            this.NPtxt.Size = new System.Drawing.Size(100, 15);
            this.NPtxt.TabIndex = 40;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1109, 675);
            this.Controls.Add(this.TSStxt);
            this.Controls.Add(this.IFtxt);
            this.Controls.Add(this.NPtxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.avgPower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.txtMaxAlt);
            this.Controls.Add(this.txtAvgAlt);
            this.Controls.Add(this.txtMaxPower);
            this.Controls.Add(this.txtAvgSpeed);
            this.Controls.Add(this.txtMaxSpeed);
            this.Controls.Add(this.txtAvgHR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sumLbl);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.RestTxt);
            this.Controls.Add(this.maxHRTxt);
            this.Controls.Add(this.lengthTxt);
            this.Controls.Add(this.startTxt);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.restLabel);
            this.Controls.Add(this.maxHrLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label maxHrLabel;
        private System.Windows.Forms.Label restLabel;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.TextBox startTxt;
        private System.Windows.Forms.TextBox lengthTxt;
        private System.Windows.Forms.TextBox maxHRTxt;
        private System.Windows.Forms.TextBox RestTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label sumLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAvgHR;
        private System.Windows.Forms.TextBox txtMaxSpeed;
        private System.Windows.Forms.TextBox txtAvgSpeed;
        private System.Windows.Forms.TextBox txtMaxPower;
        private System.Windows.Forms.TextBox txtAvgAlt;
        private System.Windows.Forms.TextBox txtMaxAlt;
        private System.Windows.Forms.ToolStripMenuItem heatRatePerMinToolStripMenuItem;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox avgPower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromDateToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TSStxt;
        private System.Windows.Forms.TextBox IFtxt;
        private System.Windows.Forms.TextBox NPtxt;
    }
}

