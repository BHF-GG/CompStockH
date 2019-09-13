using System;
using System.Collections.Generic;
using System.Text;
using CompStock.Interfaces;

namespace CompStock.Classes
{
    class LED : ILEDController
    {
        public void ShineGreen()
        {
            Console.WriteLine("LED: Green");
        }

        public void ShineRed()
        {
            Console.WriteLine("LED: Red");
        }

        public void TurnOff()
        {
            Console.WriteLine("LED: OFF");
        }
    }
}
