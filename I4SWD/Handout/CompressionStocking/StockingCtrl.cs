using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompressionStocking.Lights;
using CompressionStocking.Timers;

namespace CompressionStocking
{
    public interface IBtnHandler
    {
        void StartBtnPushed();
        void StopBtnPushed();
    }


    public class StockingCtrl : IBtnHandler
    {
        private readonly ICompressionCtrl _compressionCtrl;
        
        private readonly IVibrator _vibrator = new VibratorA();
        private ILight _light = null;


        public StockingCtrl(ICompressionCtrl compressionCtrl)
        {
            _compressionCtrl = compressionCtrl;
        }


        // From IBtnHandler
        public void StartBtnPushed()
        {
            _vibrator.On();
            _light = new Greenlight();
            _light.On();
            _compressionCtrl.Compress();
            _light.Off();
            _vibrator.Off();
        }

        public void StopBtnPushed()
        {
            _vibrator.On();
            _light = new Redlight();
            _light.On();
            _compressionCtrl.Decompress();
            _light.Off();
            _vibrator.Off();

        }


    }
}
