using System;
using GoFObserverGeneric;

namespace GoFObserverGenerics
{
    public class PortfolioDisplay : GoFObserverGeneric.IObserver<Portfolio>
    {
        //public void Update(Subject<> subject)
        //{
        //    var temp = (Portfolio) subject;
        //    PrintStockList(temp);
        //}

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
                Console.WriteLine("StockName : " + stock.First.StockName + ",  Value : " + stock.First.StockValue + ",  Stockcount : " + stock.Second + ",  total : "+ stock.First.StockValue*stock.Second + "\n");
            }

            Console.WriteLine("\n\n\n\n__________________________________________________________________________");
        }

        public void Update(Subject<Portfolio> subject)
        {
            var temp = (Portfolio)subject;
                PrintStockList(temp);
        }
    }
}
