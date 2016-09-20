using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFObserver
{
    class Stocks : GoFObserverDLL.Subject
    {
        public double StockValue { get; set; }

        public string StockName { get; set; }
    }
}
