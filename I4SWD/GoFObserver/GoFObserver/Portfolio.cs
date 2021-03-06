﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoFObserverDLL;

namespace GoFObserver
{
    public class Portfolio : GoFObserverDLL.Subject, GoFObserverDLL.IObserver
    {
        public void Update(GoFObserverDLL.Subject subject)
        {
        //Console.WriteLine("Update funktion called!");

            Stocks temp = _stockList.Find(x => x.StockName.Contains(((Stocks) subject).StockName));

            //temp.StockValue = ((Stocks) subject).StockValue;
            TotalStockRevenue = 0;

        }

        public void AddStock(Stocks s)
        {
            _stockList.Add(s);
            s.Attach(this);
        }

        public void DeleteStock(Stocks s)
        {
            _stockList.Remove(s);
            s.Detach(this);
        }


        

        public double TotalStockRevenue
        {
            get { return _totalStockRevenue; }
            protected set
            {
                double sum = 0;
                foreach (var stock in _stockList)
                {
                    sum += stock.StockValue;
                }

                _totalStockRevenue = sum;

                Notify(this);
            }
        }

        public string PortifolioName { get; set; }
        


        

        public List<Stocks> _stockList = new List<Stocks>();
        private double _totalStockRevenue;
    }
}
