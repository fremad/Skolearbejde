using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking.Timers
{
    class TimerCtrl : ITimerCtrl
    {
        public void Timeout(int seconds)
        {
                Console.WriteLine("{0} miliseconds passed... \n", seconds );     
        }
    }  
}
