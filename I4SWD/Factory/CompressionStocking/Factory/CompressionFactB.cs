using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompressionStocking.Mechanisms.Compression;

namespace CompressionStocking.Factory
{
    public class CompressionFactB : ICompressionFactory
    {
        public ICompressionMechanism CreateCompressionctrl()
        {
            return new LaceCompressionMechanism(50, 2, new CompressionStocking.Devices.Compression.LaceTighteningDevice());
        }
    }
}
