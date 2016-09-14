using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking
{
    class VibratorA : IVibrator
    {
        public void On()
        {
            Console.WriteLine("The vibrator goes On\n");
        }

        public void Off()
        {
            Console.WriteLine("The vibrator goes Off\n");
        }
    }
}
