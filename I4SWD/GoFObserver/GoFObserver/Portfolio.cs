using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFObserver
{
    public class Portfolio : GoFObserverDLL.Subject, GoFObserverDLL.IObserver
    {
        public void Update()
        {
            
        }



        private List<Stocks> _stockList = new List<Stocks>();

    }
}
