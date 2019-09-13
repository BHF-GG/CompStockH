using System;
using System.Collections.Generic;
using System.Text;
using CompStock.Interfaces;

namespace CompStock.Classes
{
    class Lacer : ICompressionCtrl, ITimer
    {
        private bool _pumpRunning = false;
        private int i = 0;
        public void Compress()
        {
            _pumpRunning = true;
            for (i = 0; i < 40;)
            {
                TimerMilliSeconds timerSeconds = new TimerMilliSeconds();
                timerSeconds.Register(100,this);
                Console.WriteLine($"Compressing: Tick nr. {i+1}");
                Timeout();
            }
            Console.WriteLine("Compression done, Lacing Stopped");
            _pumpRunning = false;
        }

        public void Decompress()
        {
            _pumpRunning = true;
            for (int i = 0; i < 40; i++)
            {
                TimerMilliSeconds timerSeconds = new TimerMilliSeconds();
                timerSeconds.Register(100, this);
                Console.WriteLine($"Loosening: Tick nr. {i}");
            }
        }

        public bool PumpRunning()
        {
            return _pumpRunning;
        }

        public void Timeout()
        {
            i++;
        }
    }
}
