using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFObserverMarketPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock aStock = new Stock();
            aStock.StockName = "Systematic A/S";
            aStock.StockValue = 40;

            MarketDisplay marketDisplay = new MarketDisplay();

            MarketPlace marketPlace = new MarketPlace(1000000);

            marketPlace.Attach(marketDisplay);

            marketPlace.MarketBuyStock(aStock);

            marketPlace.MarkedSellStock(aStock);


        }
    }
}
