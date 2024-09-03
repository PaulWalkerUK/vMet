namespace vMet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataLbl = new Label();
            windDirLbl = new Label();
            windDirTxt = new TextBox();
            tempLbl = new Label();
            tempTxt = new TextBox();
            qnhLbl = new Label();
            qnhTxt = new TextBox();
            qfeLbl = new Label();
            qfeTxt = new TextBox();
            visibilityLbl = new Label();
            visibilityTxt = new TextBox();
            windSpdLbl = new Label();
            windSpdTxt = new TextBox();
            gustLbl = new Label();
            gustTxt = new TextBox();
            sunriseLbl = new Label();
            sunsetLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            dataLocalTxt = new TextBox();
            sunriseLocalTxt = new TextBox();
            sunsetLocalTxt = new TextBox();
            fetchedLbl = new Label();
            fetchedLocalTxt = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            airportToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusTxt = new ToolStripStatusLabel();
            progBar = new ToolStripProgressBar();
            timeRemainingTxt = new ToolStripStatusLabel();
            runwayTableLayoutPanel = new TableLayoutPanel();
            label1 = new Label();
            alwaysOnTopToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataLbl
            // 
            dataLbl.AutoSize = true;
            dataLbl.Location = new Point(25, 59);
            dataLbl.Name = "dataLbl";
            dataLbl.Size = new Size(63, 15);
            dataLbl.TabIndex = 0;
            dataLbl.Text = "Data Time:";
            // 
            // windDirLbl
            // 
            windDirLbl.AutoSize = true;
            windDirLbl.Location = new Point(8, 6);
            windDirLbl.Name = "windDirLbl";
            windDirLbl.Size = new Size(72, 15);
            windDirLbl.TabIndex = 2;
            windDirLbl.Text = "Wind Dir (°):";
            // 
            // windDirTxt
            // 
            windDirTxt.Location = new Point(86, 3);
            windDirTxt.Name = "windDirTxt";
            windDirTxt.ReadOnly = true;
            windDirTxt.Size = new Size(83, 23);
            windDirTxt.TabIndex = 3;
            // 
            // tempLbl
            // 
            tempLbl.AutoSize = true;
            tempLbl.Location = new Point(28, 146);
            tempLbl.Name = "tempLbl";
            tempLbl.Size = new Size(63, 15);
            tempLbl.TabIndex = 4;
            tempLbl.Text = "Temp (°C):";
            // 
            // tempTxt
            // 
            tempTxt.Location = new Point(94, 143);
            tempTxt.Name = "tempTxt";
            tempTxt.ReadOnly = true;
            tempTxt.Size = new Size(100, 23);
            tempTxt.TabIndex = 5;
            // 
            // qnhLbl
            // 
            qnhLbl.AutoSize = true;
            qnhLbl.Location = new Point(3, 6);
            qnhLbl.Name = "qnhLbl";
            qnhLbl.Size = new Size(37, 15);
            qnhLbl.TabIndex = 6;
            qnhLbl.Text = "QNH:";
            // 
            // qnhTxt
            // 
            qnhTxt.Location = new Point(46, 3);
            qnhTxt.Name = "qnhTxt";
            qnhTxt.ReadOnly = true;
            qnhTxt.Size = new Size(123, 23);
            qnhTxt.TabIndex = 7;
            // 
            // qfeLbl
            // 
            qfeLbl.AutoSize = true;
            qfeLbl.Location = new Point(9, 39);
            qfeLbl.Name = "qfeLbl";
            qfeLbl.Size = new Size(31, 15);
            qfeLbl.TabIndex = 8;
            qfeLbl.Text = "QFE:";
            // 
            // qfeTxt
            // 
            qfeTxt.Location = new Point(46, 37);
            qfeTxt.Name = "qfeTxt";
            qfeTxt.ReadOnly = true;
            qfeTxt.Size = new Size(123, 23);
            qfeTxt.TabIndex = 9;
            // 
            // visibilityLbl
            // 
            visibilityLbl.AutoSize = true;
            visibilityLbl.Location = new Point(15, 175);
            visibilityLbl.Name = "visibilityLbl";
            visibilityLbl.Size = new Size(76, 15);
            visibilityLbl.TabIndex = 10;
            visibilityLbl.Text = "Visibility (m):";
            // 
            // visibilityTxt
            // 
            visibilityTxt.Location = new Point(94, 172);
            visibilityTxt.Name = "visibilityTxt";
            visibilityTxt.ReadOnly = true;
            visibilityTxt.Size = new Size(100, 23);
            visibilityTxt.TabIndex = 11;
            // 
            // windSpdLbl
            // 
            windSpdLbl.AutoSize = true;
            windSpdLbl.Location = new Point(12, 35);
            windSpdLbl.Name = "windSpdLbl";
            windSpdLbl.Size = new Size(68, 15);
            windSpdLbl.TabIndex = 12;
            windSpdLbl.Text = "Speed (kts):";
            // 
            // windSpdTxt
            // 
            windSpdTxt.Location = new Point(86, 32);
            windSpdTxt.Name = "windSpdTxt";
            windSpdTxt.ReadOnly = true;
            windSpdTxt.Size = new Size(83, 23);
            windSpdTxt.TabIndex = 13;
            // 
            // gustLbl
            // 
            gustLbl.AutoSize = true;
            gustLbl.Location = new Point(3, 64);
            gustLbl.Name = "gustLbl";
            gustLbl.Size = new Size(77, 15);
            gustLbl.TabIndex = 14;
            gustLbl.Text = "Gusting (kts):";
            // 
            // gustTxt
            // 
            gustTxt.Location = new Point(86, 61);
            gustTxt.Name = "gustTxt";
            gustTxt.ReadOnly = true;
            gustTxt.Size = new Size(83, 23);
            gustTxt.TabIndex = 15;
            // 
            // sunriseLbl
            // 
            sunriseLbl.AutoSize = true;
            sunriseLbl.Location = new Point(43, 88);
            sunriseLbl.Name = "sunriseLbl";
            sunriseLbl.Size = new Size(48, 15);
            sunriseLbl.TabIndex = 16;
            sunriseLbl.Text = "Sunrise:";
            // 
            // sunsetLbl
            // 
            sunsetLbl.AutoSize = true;
            sunsetLbl.Location = new Point(46, 117);
            sunsetLbl.Name = "sunsetLbl";
            sunsetLbl.Size = new Size(45, 15);
            sunsetLbl.TabIndex = 18;
            sunsetLbl.Text = "Sunset:";
            // 
            // timer1
            // 
            timer1.Interval = 600000;
            timer1.Tick += timer1_Tick;
            // 
            // dataLocalTxt
            // 
            dataLocalTxt.Location = new Point(94, 56);
            dataLocalTxt.Name = "dataLocalTxt";
            dataLocalTxt.ReadOnly = true;
            dataLocalTxt.Size = new Size(178, 23);
            dataLocalTxt.TabIndex = 20;
            // 
            // sunriseLocalTxt
            // 
            sunriseLocalTxt.Location = new Point(94, 85);
            sunriseLocalTxt.Name = "sunriseLocalTxt";
            sunriseLocalTxt.ReadOnly = true;
            sunriseLocalTxt.Size = new Size(176, 23);
            sunriseLocalTxt.TabIndex = 21;
            // 
            // sunsetLocalTxt
            // 
            sunsetLocalTxt.Location = new Point(94, 114);
            sunsetLocalTxt.Name = "sunsetLocalTxt";
            sunsetLocalTxt.ReadOnly = true;
            sunsetLocalTxt.Size = new Size(176, 23);
            sunsetLocalTxt.TabIndex = 22;
            // 
            // fetchedLbl
            // 
            fetchedLbl.AutoSize = true;
            fetchedLbl.Location = new Point(12, 30);
            fetchedLbl.Name = "fetchedLbl";
            fetchedLbl.Size = new Size(76, 15);
            fetchedLbl.TabIndex = 23;
            fetchedLbl.Text = "Last Fetched:";
            // 
            // fetchedLocalTxt
            // 
            fetchedLocalTxt.Location = new Point(94, 27);
            fetchedLocalTxt.Name = "fetchedLocalTxt";
            fetchedLocalTxt.ReadOnly = true;
            fetchedLocalTxt.Size = new Size(178, 23);
            fetchedLocalTxt.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(windDirLbl);
            panel1.Controls.Add(windDirTxt);
            panel1.Controls.Add(windSpdTxt);
            panel1.Controls.Add(windSpdLbl);
            panel1.Controls.Add(gustTxt);
            panel1.Controls.Add(gustLbl);
            panel1.Location = new Point(278, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 92);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(qnhTxt);
            panel2.Controls.Add(qfeTxt);
            panel2.Controls.Add(qnhLbl);
            panel2.Controls.Add(qfeLbl);
            panel2.Location = new Point(278, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(174, 70);
            panel2.TabIndex = 27;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 30;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { airportToolStripMenuItem, settingsToolStripMenuItem, alwaysOnTopToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // airportToolStripMenuItem
            // 
            airportToolStripMenuItem.Name = "airportToolStripMenuItem";
            airportToolStripMenuItem.Size = new Size(180, 22);
            airportToolStripMenuItem.Text = "Airport...";
            airportToolStripMenuItem.Click += airportToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "Settings...";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(116, 22);
            aboutToolStripMenuItem.Text = "About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusTxt, progBar, timeRemainingTxt });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 31;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusTxt
            // 
            statusTxt.Name = "statusTxt";
            statusTxt.Size = new Size(70, 17);
            statusTxt.Text = "Initialising...";
            // 
            // progBar
            // 
            progBar.Name = "progBar";
            progBar.Size = new Size(100, 16);
            // 
            // timeRemainingTxt
            // 
            timeRemainingTxt.Name = "timeRemainingTxt";
            timeRemainingTxt.Size = new Size(22, 17);
            timeRemainingTxt.Text = "---";
            // 
            // runwayTableLayoutPanel
            // 
            runwayTableLayoutPanel.AutoSize = true;
            runwayTableLayoutPanel.ColumnCount = 2;
            runwayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            runwayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            runwayTableLayoutPanel.Location = new Point(458, 42);
            runwayTableLayoutPanel.Name = "runwayTableLayoutPanel";
            runwayTableLayoutPanel.RowCount = 2;
            runwayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            runwayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            runwayTableLayoutPanel.Size = new Size(253, 59);
            runwayTableLayoutPanel.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(458, 24);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 33;
            label1.Text = "Select Runway:";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            alwaysOnTopToolStripMenuItem.Size = new Size(180, 22);
            alwaysOnTopToolStripMenuItem.Text = "Always on top";
            alwaysOnTopToolStripMenuItem.Click += alwaysOnTopToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(runwayTableLayoutPanel);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(fetchedLocalTxt);
            Controls.Add(fetchedLbl);
            Controls.Add(sunsetLocalTxt);
            Controls.Add(sunriseLocalTxt);
            Controls.Add(dataLocalTxt);
            Controls.Add(sunsetLbl);
            Controls.Add(sunriseLbl);
            Controls.Add(visibilityTxt);
            Controls.Add(visibilityLbl);
            Controls.Add(tempTxt);
            Controls.Add(tempLbl);
            Controls.Add(dataLbl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "vMet";
            Paint += Form1_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dataLbl;
        private Label windDirLbl;
        private TextBox windDirTxt;
        private Label tempLbl;
        private TextBox tempTxt;
        private Label qnhLbl;
        private TextBox qnhTxt;
        private Label qfeLbl;
        private TextBox qfeTxt;
        private Label visibilityLbl;
        private TextBox visibilityTxt;
        private Label windSpdLbl;
        private TextBox windSpdTxt;
        private Label gustLbl;
        private TextBox gustTxt;
        private Label sunriseLbl;
        private Label sunsetLbl;
        private System.Windows.Forms.Timer timer1;
        private TextBox dataLocalTxt;
        private TextBox sunriseLocalTxt;
        private TextBox sunsetLocalTxt;
        private Label fetchedLbl;
        private TextBox fetchedLocalTxt;
        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusTxt;
        private ToolStripProgressBar progBar;
        private ToolStripStatusLabel timeRemainingTxt;
        private ToolStripMenuItem airportToolStripMenuItem;
        private TableLayoutPanel runwayTableLayoutPanel;
        private Label label1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem alwaysOnTopToolStripMenuItem;
    }
}
