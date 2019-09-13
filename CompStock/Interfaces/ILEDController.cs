using System;
using System.Collections.Generic;
using System.Text;

namespace CompStock.Interfaces
{
    interface ILEDController
    {
        void ShineGreen();
        void ShineRed();
        void TurnOff();
    }
}
