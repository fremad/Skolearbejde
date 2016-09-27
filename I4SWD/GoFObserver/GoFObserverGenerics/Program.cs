using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFObserverGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Portfolio portfolio = new Portfolio();
            portfolio.PortifolioName = "Jakob's Stocks";

            Portfolio p2_portfolio = new Portfolio();

            p2_portfolio.PortifolioName = "Michaels BankAccount";

            Stocks aStock = new Stocks();
            Stocks aSecondStock = new Stocks();

            PortfolioDisplay p1Display = new PortfolioDisplay();


            aStock.StockName = "Microsoft";
            aStock.StockValue = 0;

            

            aSecondStock.StockName = "Systematic A/S";
            aSecondStock.StockValue = 0;

            p2_portfolio.AddStock(aSecondStock);
            portfolio.AddStock(aStock);
            portfolio.AddStock(aStock);
            portfolio.AddStock(aSecondStock);

            p1Display.Subscibe(portfolio);
            p1Display.Subscibe(p2_portfolio);

            Random rnd = new Random();
            while (true)
            {
                aSecondStock.StockValue = rnd.Next(1, 15);
                System.Threading.Thread.Sleep(1000);
                aStock.StockValue = rnd.Next(1, 13);
                System.Threading.Thread.Sleep(1000);

            }           
        }       
    }
}
