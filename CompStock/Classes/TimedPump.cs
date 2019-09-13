using System;
using System.Collections.Generic;
using System.Text;
using CompStock.Interfaces;

namespace CompStock.Classes
{
    class TimedPump : ICompressionCtrl, ITimer
    {
        private bool _pumpRunning = false;
        public void Compress()
        {
            Console.WriteLine("Compressing for 5 seconds");
            TimerMilliSeconds timerSeconds = new TimerMilliSeconds();
            timerSeconds.Register(5000,this);
            _pumpRunning = true;

        }

        public void Decompress()
        {
            Console.WriteLine("Decompressing for 2 seconds");
            TimerMilliSeconds timerSeconds = new TimerMilliSeconds();
            timerSeconds.Register(2000,this);
            _pumpRunning = true;
        }

        public void Timeout()
        {
            Console.WriteLine("Timed out, Pump Stopped");
            _pumpRunning = false;
        }

        public bool PumpRunning()
        {
            return _pumpRunning;
        }
    }
}
