using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompressionStocking.Mechanisms.UserInterface;

namespace CompressionStocking.Factory
{
    class OutputfactoryA : Ioutputfactory
    {
        public IUserOutput CreateOutput()
        {
            return new UserOutput 
        }
    }
}
