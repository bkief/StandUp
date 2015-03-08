using System;
using System.Diagnostics;
using System.Windows.Forms;
using StandUp.Properties;
using System.Drawing;

namespace StandUp
{

	class ContextMenus
	{
		/// Is the About box displayed?
		bool isAboutLoaded = false;
        bool isConfigWinLoaded = false;

		public ContextMenuStrip Create()
		{
			// Add the default menu options.
			ContextMenuStrip menu = new ContextMenuStrip();
			ToolStripMenuItem item;
            ToolStripSeparator sep;

            // Configure
            item = new ToolStripMenuItem();
            item.Text = "Settings";
            item.Click += new EventHandler(Config_Click);
            //item.Image = Resources.Explorer;
            menu.Items.Add(item);

            // Separator.
            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            // Mute Alarm
            item = new ToolStripMenuItem();
            item.Text = "Mute";
            item.Click += new EventHandler(Mute_Click);
            menu.Items.Add(item);

            // Acknowledge Alarm
            item = new ToolStripMenuItem();
            item.Text = "Acknowledge";
            item.Click += new EventHandler(Acknowledge_Click);
            //item.Image = Resources.Explorer;
            menu.Items.Add(item);

			// Separator.
            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            // About.
            item = new ToolStripMenuItem();
            item.Text = "About";
            item.Click += new EventHandler(About_Click);
            //item.Image = Resources.About;
            menu.Items.Add(item);

			// Exit.
			item = new ToolStripMenuItem();
			item.Text = "Exit";
			item.Click += new System.EventHandler(Exit_Click);
			//item.Image = Resources.Exit;
			menu.Items.Add(item);

			return menu;
		}

		/// Handles the Click event of the Explorer control.
		void Config_Click(object sender, EventArgs e)
		{
            if (!isConfigWinLoaded)
            {
                isConfigWinLoaded = true;
                new ConfigWin().ShowDialog();
                isConfigWinLoaded = false;
            }
		}

        /// Handles the Click event of the Explorer control.
        void Mute_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itemMute = ((ToolStripMenuItem)sender);
            itemMute.Checked = !itemMute.Checked;
            Program.atvTimer.toggleMute();
        }

        /// Handles the Click event of the Explorer control.
        void Acknowledge_Click(object sender, EventArgs e)
        {
            Program.atvTimer.reset();
        }

		/// Handles the Click event of the About control.
        void About_Click(object sender, EventArgs e)
        {
            if (!isAboutLoaded)
            {
                isAboutLoaded = true;
                new AboutBox().ShowDialog();
                isAboutLoaded = false;
            }
        }

		/// Processes a menu item.
		void Exit_Click(object sender, EventArgs e)
		{
			// Quit without further ado.
			Application.Exit();
		}
	}
}