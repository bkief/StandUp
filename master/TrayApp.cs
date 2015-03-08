using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StandUp.Properties;

namespace StandUp
{
    class TrayApp : IDisposable
	{
		NotifyIcon ni;

		public TrayApp()
		{
			// Instantiate the NotifyIcon object.
			ni = new NotifyIcon();
		}

		public void Display()
		{
			//// Put the icon in the system tray and allow it react to mouse clicks.			
			ni.MouseClick += new MouseEventHandler(ni_MouseClick);
			ni.Icon = Resources.crosswalk;
			ni.Text = "StandUp";
			ni.Visible = true;

			//// Attach a context menu.
			ni.ContextMenuStrip = new ContextMenus().Create();
		}

        public void activate()
        {
            ni.Icon = Resources.crosswalk_alarm;
            ni.ShowBalloonTip(3000, "Stand Up!", "Please take a break for your health.", ToolTipIcon.Info);
        }

        public void deactivate()
        {
            ni.Icon = Resources.crosswalk;
        }

		public void Dispose()
		{
			// When the application closes, this will remove the icon from the system tray immediately.
            System.Console.WriteLine("bye");
            ni.Visible = false;
            ni.Icon = null;
			ni.Dispose();
		}

        void ni_MouseClick(object sender, MouseEventArgs e)
        {
            // Handle mouse button clicks.
            if (e.Button == MouseButtons.Left)
            {
                // Show Balloon with ActiveTime and IdleTime
                showActiveTime();
            }
        }

        public void showActiveTime()
        {
            TimeSpan activeSpan = TimeSpan.FromSeconds(Program.atvTimer.getActiveTime());
            string activeLabel = activeSpan.ToString(@"hh\:mm\:ss");
            ni.ShowBalloonTip(500, "Stand Up!", "Active Time: " + activeLabel + "\n", ToolTipIcon.Info);
        }
    }

}
