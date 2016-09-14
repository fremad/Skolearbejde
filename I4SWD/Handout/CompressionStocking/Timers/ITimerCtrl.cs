using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CompressionStocking.Timers
{
    interface ITimerCtrl
    {
        void Timeout(int seconds);


    }
}
