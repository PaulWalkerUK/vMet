using System;
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
        private UserConfigMgr userConfigMgr;

        public SettingsForm(UserConfigMgr userConfigMgr)
        {
            this.userConfigMgr = userConfigMgr;
            InitializeComponent();
            apikeyTxt.Text = userConfigMgr.config.openWeatherApiKey;
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
            userConfigMgr.config.openWeatherApiKey = newApiKey;
            userConfigMgr.saveConfig();
        }
    }
}
