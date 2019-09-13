using System;
using System.Collections.Generic;
using System.Text;
using CompStock.Interfaces;

namespace CompStock.Classes
{
    class StockingController : IBtnHandler
    {
        private readonly ICompressionCtrl _compressionCtrl;
        private readonly IVibrator _vibrator;
        private readonly ILEDController _ledController;
        public StockingController(ICompressionCtrl iCompressionCtrl, IVibrator vibrator, ILEDController ledController)
        {
            _compressionCtrl = iCompressionCtrl;
            _vibrator = vibrator;
            _ledController = ledController;
        }
        public void StartBtnPushed()
        {
            _compressionCtrl.Compress();
            _vibrator.VibrateOn();
            _ledController.ShineGreen();
            TurnOff();
        }

        public void StopBtnPushed()
        {
            _compressionCtrl.Decompress();
            _vibrator.VibrateOn();
            _ledController.ShineRed();
            TurnOff();
        }

        private void TurnOff()
        {
            while (_compressionCtrl.PumpRunning())
            {
                
            }
            _vibrator.VibrateOff();
            _ledController.TurnOff();
        }
    }
}
