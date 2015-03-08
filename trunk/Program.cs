using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace StandUp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static Mutex mutex = new Mutex(true, "BKStandUP");

        public static TrayApp app;
        public static ActivityTimer atvTimer;
        public static ActivityMonitor monitor;

        [STAThread]
        static void Main()
        {
            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                MessageBox.Show("StandUp is already running", "StandUp",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


           if (ConfigurationManager.AppSettings.Count > 0)
           {
                Tuple<int, int, int, bool> config = readConfig();
                atvTimer = new ActivityTimer(config.Item1);
                monitor = new ActivityMonitor(config.Item2, config.Item3, config.Item4);
            }
           else
            {
                atvTimer = new ActivityTimer();
                monitor = new ActivityMonitor();
            }

            using (app = new TrayApp())
            {
                app.Display();
                monitor.start();
                Application.Run();
            }
            mutex.ReleaseMutex();
        }

        public static Tuple<int, int, int, bool> readConfig()
        {
            bool nagSetting = bool.Parse(ConfigurationManager.AppSettings.Get("Nag"));
            int nagTime = Int32.Parse(ConfigurationManager.AppSettings.Get("NagTime"));
            int maxActiveTime = Int32.Parse(ConfigurationManager.AppSettings.Get("MaxActiveTime"));
            int minBreakTime = Int32.Parse(ConfigurationManager.AppSettings.Get("MinBreakTime"));

            return Tuple.Create(minBreakTime, maxActiveTime, nagTime, nagSetting); 
        }
    }
}
