using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompressionStocking.Timers;

namespace CompressionStocking
{
    class Pump : Pressure.PressureCtrl, IPump
    {
        private readonly Timers.ITimerCtrl _timerCtrl = new TimerCtrl();
        public void On()
        {
            Console.WriteLine("Pump is On\n");
            _timerCtrl.Timeout(5000);
            Stop();
        }

        private void Stop()
        {
            Console.WriteLine("Pump is OFF\n");
        }

        public void Reverse()
        {
            Console.WriteLine("Pump is in Reverse\n");
            _timerCtrl.Timeout(2000);
            Stop();
        }
    }
}
