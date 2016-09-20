using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace GoFObserverMarketPlace
{
    public class MarketPlace : GoFObserverGeneric.Subject<MarketPlace>
    {

        public MarketPlace(double revenue)
        {
            MarketRevenue = revenue;
        }

       public void MarkedSellStock(Stock stock)
        {
            if (_marketstocks.Contains(stock))
            {
                MarketRevenue += stock.StockValue;
                _marketstocks.Remove(stock);
                Notify(this);
            }        
        }

        public void MarketBuyStock(Stock stock)
        {
            MarketRevenue -= stock.StockValue;
            AddStock(stock);
            Notify(this);
        }

        public void AddStock(Stock stock)
        {
            _marketstocks.Add(stock);
        }



        public double MarketRevenue { get; set; }


        public readonly List<Stock> _marketstocks = new List<Stock>();
    }
}