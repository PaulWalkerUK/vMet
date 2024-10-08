﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vMet
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            apikeyTxt.Text = Properties.Settings.Default.OpenWeatherMapApiKey;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            SaveApiKey(apikeyTxt.Text);
            this.Close();
        }
        private void SaveApiKey(string newApiKey)
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            Properties.Settings.Default.OpenWeatherMapApiKey = newApiKey;
            Properties.Settings.Default.Save();
            //config.Save(ConfigurationSaveMode.Modified);
            //ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
