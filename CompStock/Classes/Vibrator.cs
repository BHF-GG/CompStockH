using System;
using System.Collections.Generic;
using System.Text;
using CompStock.Interfaces;

namespace CompStock.Classes
{
    class Vibrator : IVibrator
    {
        public void VibrateOn()
        {
            Console.WriteLine("Vibrator: ON");
        }

        public void VibrateOff()
        {
            Console.WriteLine("Vibrator: OFF");
        }
    }
}
