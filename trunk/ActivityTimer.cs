using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

namespace StandUp
{
    public class ActivityTimer
    {
        public int breakTime;

        private bool mute = false;
        private int ActiveTime = 0;
        private System.Timers.Timer myTimer;

        public ActivityTimer(int breaktime=120)
        {
            setParams(breaktime);
            myTimer = new System.Timers.Timer(1000);
            myTimer.Elapsed += OnTimedEvent;
            myTimer.Enabled = true;
        }

        public void setParams(int breaktime)
        {
            if (breaktime < 60)
            {
                breaktime = 60;
            }
            breakTime = breaktime;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            aTimer();
        }

        private void aTimer()
        {
            int idleTime = getIdleTime(); 

            if (idleTime > breakTime || mute)
            {
                ActiveTime = 0;
            }
            else
            {
                ActiveTime += 1;
            }
        }

        public void reset()
        {
            ActiveTime = 0;
        }

        public void toggleMute()
        {
            mute = !mute;
        }

        public int getIdleTime()
        {
            return (int)Win32.GetIdleTime() / 1000; // uint -> int
        }

        public int getActiveTime(){
            return ActiveTime;
        }
    }
}
