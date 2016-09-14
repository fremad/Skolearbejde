using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking.Lights
{
    class Greenlight : ILight
    {
        public void On()
        {
            Console.WriteLine("The Green Light goes On\n");
        }

        public void Off()
        {
            Console.WriteLine("The Green light goes Off\n");
        }
    }
}
