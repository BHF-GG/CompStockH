using System;
using System.Collections.Generic;
using System.Text;
using CompStock.Interfaces;
using System.Timers;

namespace CompStock.Classes
{
    class TimerMilliSeconds
    {
 
        private ITimer _iTimer;
        private Timer timer;


        public void Register(int t, ITimer iTimer)
        {
            _iTimer = iTimer;
            timer = new Timer(t);
            timer.AutoReset = false;
            timer.Elapsed += TimeOut;       
            timer.Start();
        }

        private void TimeOut(object sender, ElapsedEventArgs e)
        {
            _iTimer.Timeout();
            
        }

        public void UnRegister()
        {
            _iTimer = null;
        }
    }
}
