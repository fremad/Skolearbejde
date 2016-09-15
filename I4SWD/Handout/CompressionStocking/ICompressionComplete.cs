using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking
{
   public interface ICompressionComplete
    {
        void HandleCompressionComplete();

        void HandleDeCompressionComplete();
    }
}
