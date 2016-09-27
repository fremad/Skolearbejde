using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressionStocking.Factory
{
    public interface Ioutputfactory
    {
        CompressionStocking.Mechanisms.UserInterface.IUserOutput CreateOutput();
    }
}
