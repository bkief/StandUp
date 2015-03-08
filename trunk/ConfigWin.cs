using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace StandUp
{
    public partial class ConfigWin : Form
    {
        public ConfigWin()
        {
            InitializeComponent();
            this.maxtimeH.Value = (int)TimeSpan.FromSeconds(Program.monitor.maxActivityTime).Hours;
            this.maxtimeM.Value = (int)TimeSpan.FromSeconds(Program.monitor.maxActivityTime).Minutes;
            this.mintimeH.Value = (int)TimeSpan.FromSeconds(Program.atvTimer.breakTime).Hours;
            this.mintimeM.Value = (int)TimeSpan.FromSeconds(Program.atvTimer.breakTime).Minutes;
            this.nagtimeH.Value = (int)TimeSpan.FromSeconds(Program.monitor.nagTime).Hours;
            this.nagtimeM.Value = (int)TimeSpan.FromSeconds(Program.monitor.nagTime).Minutes;
            this.nagCheck.Checked = Program.monitor.nagStatus;

            if (ConfigurationManager.AppSettings.Count == 0)
            {
                this.configErrLabel.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int maxtime = (int)((maxtimeH.Value * 60 * 60) + (maxtimeM.Value * 60));
            int mintime = (int)((mintimeH.Value * 60 * 60) + (mintimeM.Value * 60));
            int nagtime = (int)((nagtimeH.Value * 60 * 60) + (nagtimeM.Value * 60));
            bool nagstat = nagCheck.Checked;

            Program.atvTimer.setParams(mintime);
            Program.monitor.setParams(maxtime, nagtime, nagstat);

            writeConfig(mintime, maxtime, nagtime, nagstat);
        }

        private void nagcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                labelNag.Enabled = true;
                nagtimeH.Enabled = true;
                nagtimeM.Enabled = true;
                hours3.Enabled = true;
                minutes3.Enabled = true;
            }
            else
            {
                labelNag.Enabled = false;
                nagtimeH.Enabled = false;
                nagtimeM.Enabled = false;
                hours3.Enabled = false;
                minutes3.Enabled = false;
            }
        }

        private void writeConfig(int mintime, int maxtime, int nagtime, bool nagstatus)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (ConfigurationManager.AppSettings.Count > 0)
            {
                config.AppSettings.Settings["MinBreakTime"].Value = mintime.ToString();
                config.AppSettings.Settings["MaxActiveTime"].Value = maxtime.ToString();
                config.AppSettings.Settings["NagTime"].Value = nagtime.ToString();
                config.AppSettings.Settings["Nag"].Value = nagstatus.ToString();
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
             
        }

    }
}