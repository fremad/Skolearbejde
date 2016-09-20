using System;
using GoFObserverGeneric;

namespace GoFObserverMarketPlace
{
    public class MarketDisplay : GoFObserverGeneric.IObserver<MarketPlace>
    {
        public void Update(Subject<MarketPlace> subject)
        {
            var temp = (MarketPlace) subject;


            foreach (var item in temp._marketstocks)
            {
                Console.WriteLine("Stock Company : "+item.StockName+ "\n");
            }
        }
    }
}