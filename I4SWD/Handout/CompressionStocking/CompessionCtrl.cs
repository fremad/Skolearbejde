using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompressionStocking.Laces;
using CompressionStocking.Timers;

namespace CompressionStocking
{
    public class CompressionCtrl : ICompressionCtrl
    {
        private readonly Timers.ITimerCtrl _timerCtrl = new TimerCtrl();
        private readonly IPump _pump = new Pump();
       

    public void Compress(ICompressionComplete there)
        { 
           // _laceTightener.Tighten();
            _pump.On();
            _timerCtrl.Timeout(5000);
            _pump.Stop();
            there.HandleCompressionComplete();
            
        }


        public void Decompress()
        {
            //_laceTightener.Loosen();
            _pump.Reverse();
        }


        //private readonly Laces.ILaceTightener _laceTightener = new LaceTightener();
        

    }
}
