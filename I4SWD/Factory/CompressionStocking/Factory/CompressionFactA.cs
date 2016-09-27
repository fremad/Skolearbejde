using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompressionStocking.Mechanisms.Compression;

namespace CompressionStocking.Factory
{
    public class CompressionFactA : ICompressionFactory
    {
        ICompressionMechanism ICompressionFactory.CreateCompressionctrl()
        {
           //return new AirCompressionMechanism(new CompressionStocking.Devices.Compression.Pump() ,5,2);
           return new AirCompressionMechanism(new CompressionStocking.Devices.Compression.Pump(), 5000, 2000);
        }
    }
}
