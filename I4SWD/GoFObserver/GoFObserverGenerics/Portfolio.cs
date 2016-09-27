using System.Collections.Generic;
using GoFObserverGeneric;
using System.Linq;
using System;

namespace GoFObserverGenerics
{
    public class Portfolio : GoFObserverGeneric.Subject<Portfolio>, GoFObserverGeneric.IObserver<Stocks>
    {
        //public void Update(GoFObserverDLL.Subject subject)
        //{
        ////Console.WriteLine("Update funktion called!");

        //    Stocks temp = _stockList.Find(x => x.StockName.Contains(((Stocks) subject).StockName));

        //    //temp.StockValue = ((Stocks) subject).StockValue;
        //    TotalStockRevenue = 0;

        //}

        public void AddStock(Stocks s)
        {
            // _stockList.Contains.item


            foreach (var item in _stockList)
            {
                if (item.First.StockName == s.StockName)
                {
                    item.Second++;
                    return;
                }
            }

            
                Pair<Stocks, int> temp = new Pair<Stocks, int>();
                temp.First = s;
                temp.Second = 1;
                _stockList.Add(temp);

            s.Attach(this);
        }

        public void DeleteStock(Stocks s)
        {
            foreach (var item in _stockList)
            {
                if (item.First.StockName == s.StockName)
                {
                    item.Second--;

                    if(item.Second == 0)
                    {
                        Pair<Stocks, int> temp = new Pair<Stocks, int>();
                        temp.First = s;
                       _stockList.Remove(temp);
                        s.Detach(this);
                    }
                    
                    
                }
            }
        }

        public void Update(Subject<Stocks> subject)
        {
            //Stocks temp = _stockList.Find(x => x.StockName.Contains(((Stocks) subject).StockName));
            TotalStockRevenue = 0;
            //temp.StockValue = ((Stocks) subject).StockValue;

        }


        public double TotalStockRevenue
        {
            get { return _totalStockRevenue; }
            protected set
            {
                double sum = 0;
                foreach (var stock in _stockList)
                {
                    sum += stock.First.StockValue * stock.Second;
                }

                _totalStockRevenue = sum;

                Notify(this);
            }
        }

        public string PortifolioName { get; set; }



        public List<Pair<Stocks, int>> _stockList = new List<Pair<Stocks, int>>();
        private double _totalStockRevenue;

    }

    public class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }
    }
}