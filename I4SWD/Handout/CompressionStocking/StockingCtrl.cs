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


    public class StockingCtrl : IBtnHandler, ICompressionComplete
    {
        private INotify notifier = null;
        private readonly ICompressionCtrl _compressionCtrl;
        
        

        public StockingCtrl(ICompressionCtrl compressionCtrl)
        {
            _compressionCtrl = compressionCtrl;
        }

        public void HandleCompressionComplete()
        {
            notifier = new Notification.CompressionStoppetMessage();
            notifier.notify(); 
        }

        public void HandleDeCompressionComplete()
        {
        }

        // From IBtnHandler
        public void StartBtnPushed()
        {
            notifier = new Notification.CompStartedMsg();
            notifier.notify();
            _compressionCtrl.Compress(this);
        }

        public void StopBtnPushed()
        {
            Console.WriteLine("not implemented!\n");
            //_vibrator.On();
            //_light = new Redlight();
            //_light.On();
            //_compressionCtrl.Decompress();
            //_light.Off();
            //_vibrator.Off();

        }


    }
}
