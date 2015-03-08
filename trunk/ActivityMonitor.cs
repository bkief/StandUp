using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace StandUp
{
    public class ActivityMonitor
    {
        public int maxActivityTime;
        public int nagTime;
        public bool nagStatus;
        private int timeSinceLastNotify = -2;
        private bool activeAlarm = false;
        private int _idletime = 0;
        private System.Timers.Timer alarmPoll;

        public ActivityMonitor(int maxactivitytime = 3600, int nagtime = 120, bool nag = true)
        {
            setParams(maxactivitytime, nagtime, nag);
        }

        public void setParams(int maxactivitytime, int nagtime, bool nag)
        {
            maxActivityTime = maxactivitytime;
            nagTime = nagtime;
            nagStatus = nag;
        }

        public void start()
        {
            alarmPoll = new Timer(1000);
            alarmPoll.Elapsed += OnTimedEvent;
            alarmPoll.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            checkActivity();
        }

        private void checkActivity()
        {
            int activetime = Program.atvTimer.getActiveTime();
            int idletime = Program.atvTimer.getIdleTime();


            // Set Alarm Status
            if (activetime > maxActivityTime)
            {
                activeAlarm = true;
                timeSinceLastNotify += 1;
            }
            else if (activeAlarm && activetime < maxActivityTime)
            {
                Program.app.deactivate();
                timeSinceLastNotify = -2;
                activeAlarm = false;
            }
            else
            {
                activeAlarm = false;
                timeSinceLastNotify = -2;
            }

            // Raise Alarms if needed
            if (nagStatus && activeAlarm && timeSinceLastNotify > nagTime && idletime <= _idletime)
            {
                Program.app.activate();
                timeSinceLastNotify = 0;
            }
            else if (activeAlarm && timeSinceLastNotify < 0)
            {
                Program.app.activate();
                timeSinceLastNotify = 0;
            }
            _idletime = idletime;
        }

    }
}
