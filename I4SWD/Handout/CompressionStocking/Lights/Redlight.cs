using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking.Lights
{
    class Redlight : ILight
    {
        public void On()
        {
            Console.WriteLine("The Red Light goes On\n");
        }

        public void Off()
        {
            Console.WriteLine("The Red light goes Off\n");
        }
    }
}
