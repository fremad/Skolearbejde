using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoFObserverDLL;

namespace GoFObserver
{
    public class PortfolioDisplay : GoFObserverDLL.IObserver
    {
        public void Update(Subject subject)
        {
            var temp = (Portfolio) subject;
            PrintStockList(temp);
        }

        public void Subscibe(Portfolio s)
        {
            s.Attach(this);
        }

        public void UnSubscibe(Portfolio s)
        {
            s.Detach(this);
        }

        public void PrintStockList(Portfolio portfolio)
        {
            Console.WriteLine("PortifolioName : " + portfolio.PortifolioName + " Revenue: " + portfolio.TotalStockRevenue + "\n--------------------------------------------------------------------------\n ");

            foreach (var stock in portfolio._stockList)
            {
                Console.WriteLine("StockName : " + stock.StockName + ",  Value : " + stock.StockValue + "\n");
            }

            Console.WriteLine("\n\n\n\n___________________________________________________________________________________");
        }

    }
}
