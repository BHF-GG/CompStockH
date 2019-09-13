using System;
using System.Collections.Generic;
using System.Text;
using CompStock.Interfaces;

namespace CompStock.Classes
{
    class CompStockClass
    {
        private IBtnControl _btnControl;
        private IBtnHandler _btnHandler;

        public CompStockClass(IBtnControl btnControl)
        {
            _btnControl = btnControl;
        }


        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Press key.");
                Console.WriteLine("1: Compress Pump ");
                Console.WriteLine("2: Stop ");
                Console.WriteLine("3: Compress Lace");

                int btnPushed = _btnControl.GetBtnPushed();
                switch (btnPushed)
                {
                    case 1:
                        _btnHandler = new StockingController(new TimedPump(), new Vibrator(), new LED());
                        _btnHandler.StartBtnPushed();
                        break;
                    case 2:
                        _btnHandler.StopBtnPushed();
                        break;
                    case 3:
                        _btnHandler = new StockingController(new Lacer(), new Vibrator(), new LED());
                        _btnHandler.StartBtnPushed();
                        break;

                }
            }

        }
    }
}
