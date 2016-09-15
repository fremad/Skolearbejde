using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompressionStocking.Timers;

namespace CompressionStocking
{
    class Pump : IPump
    {
        
        public void On()
        {
            Console.WriteLine("Pump is On\n");
        }

        public void Stop()
        {
            Console.WriteLine("Pump is OFF\n");
        }

        public void Reverse()
        {
            Console.WriteLine("Pump is in Reverse\n");
        }
    }
}
