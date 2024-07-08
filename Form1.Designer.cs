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
            runwayGroupBox = new GroupBox();
            rb28 = new RadioButton();
            rb24 = new RadioButton();
            rb19 = new RadioButton();
            rb10 = new RadioButton();
            rb06 = new RadioButton();
            rb01 = new RadioButton();
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusTxt = new ToolStripStatusLabel();
            progBar = new ToolStripProgressBar();
            timeRemainingTxt = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            runwayGroupBox.SuspendLayout();
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
            // runwayGroupBox
            // 
            runwayGroupBox.Controls.Add(rb28);
            runwayGroupBox.Controls.Add(rb24);
            runwayGroupBox.Controls.Add(rb19);
            runwayGroupBox.Controls.Add(rb10);
            runwayGroupBox.Controls.Add(rb06);
            runwayGroupBox.Controls.Add(rb01);
            runwayGroupBox.Location = new Point(458, 27);
            runwayGroupBox.Name = "runwayGroupBox";
            runwayGroupBox.Size = new Size(233, 102);
            runwayGroupBox.TabIndex = 29;
            runwayGroupBox.TabStop = false;
            runwayGroupBox.Text = "Select Runway";
            // 
            // rb28
            // 
            rb28.AutoSize = true;
            rb28.Location = new Point(123, 72);
            rb28.Name = "rb28";
            rb28.Size = new Size(37, 19);
            rb28.TabIndex = 5;
            rb28.TabStop = true;
            rb28.Text = "28";
            rb28.UseVisualStyleBackColor = true;
            rb28.CheckedChanged += RunwayRadioButton_CheckedChanged;
            // 
            // rb24
            // 
            rb24.AutoSize = true;
            rb24.Location = new Point(123, 47);
            rb24.Name = "rb24";
            rb24.Size = new Size(37, 19);
            rb24.TabIndex = 4;
            rb24.TabStop = true;
            rb24.Text = "24";
            rb24.UseVisualStyleBackColor = true;
            rb24.CheckedChanged += RunwayRadioButton_CheckedChanged;
            // 
            // rb19
            // 
            rb19.AutoSize = true;
            rb19.Location = new Point(123, 22);
            rb19.Name = "rb19";
            rb19.Size = new Size(104, 19);
            rb19.TabIndex = 3;
            rb19.TabStop = true;
            rb19.Text = "19 (H: 88 C: 88)";
            rb19.UseVisualStyleBackColor = true;
            rb19.CheckedChanged += RunwayRadioButton_CheckedChanged;
            // 
            // rb10
            // 
            rb10.AutoSize = true;
            rb10.Location = new Point(6, 72);
            rb10.Name = "rb10";
            rb10.Size = new Size(37, 19);
            rb10.TabIndex = 2;
            rb10.TabStop = true;
            rb10.Text = "10";
            rb10.UseVisualStyleBackColor = true;
            rb10.CheckedChanged += RunwayRadioButton_CheckedChanged;
            // 
            // rb06
            // 
            rb06.AutoSize = true;
            rb06.Location = new Point(6, 47);
            rb06.Name = "rb06";
            rb06.Size = new Size(37, 19);
            rb06.TabIndex = 1;
            rb06.TabStop = true;
            rb06.Text = "06";
            rb06.UseVisualStyleBackColor = true;
            rb06.CheckedChanged += RunwayRadioButton_CheckedChanged;
            // 
            // rb01
            // 
            rb01.AutoSize = true;
            rb01.Location = new Point(6, 22);
            rb01.Name = "rb01";
            rb01.Size = new Size(109, 19);
            rb01.TabIndex = 0;
            rb01.TabStop = true;
            rb01.Text = "01 (H: -88 C: 88)";
            rb01.UseVisualStyleBackColor = true;
            rb01.CheckedChanged += RunwayRadioButton_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 30;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(125, 22);
            settingsToolStripMenuItem.Text = "Settings...";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(runwayGroupBox);
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
            Text = "Form1";
            Paint += Form1_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            runwayGroupBox.ResumeLayout(false);
            runwayGroupBox.PerformLayout();
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
        private GroupBox runwayGroupBox;
        private RadioButton rb28;
        private RadioButton rb24;
        private RadioButton rb19;
        private RadioButton rb10;
        private RadioButton rb06;
        private RadioButton rb01;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusTxt;
        private ToolStripProgressBar progBar;
        private ToolStripStatusLabel timeRemainingTxt;
    }
}
