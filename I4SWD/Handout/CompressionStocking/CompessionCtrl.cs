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
        public void Compress()
        { 
            _laceTightener.Tighten();
            //_pump.On();
        }

        

        public void Decompress()
        {
            _laceTightener.Loosen();
            //_pump.Reverse();
        }


        private readonly Laces.ILaceTightener _laceTightener = new LaceTightener();
        //private readonly IPump _pump = new Pump();

    }
}
