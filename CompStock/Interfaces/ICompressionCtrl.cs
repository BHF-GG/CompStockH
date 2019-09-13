using System;
using System.Collections.Generic;
using System.Text;

namespace CompStock.Interfaces
{
    interface ICompressionCtrl
    {
        void Compress();
        void Decompress();
        bool PumpRunning();
    }
}
