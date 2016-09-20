using System.Collections.Generic;
using GoFObserverGeneric;

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
            _stockList.Add(s);
            s.Attach(this);
        }

        public void DeleteStock(Stocks s)
        {
            _stockList.Remove(s);
            s.Detach(this);
        }

        public void Update(Subject<Stocks> subject)
        {
                Stocks temp = _stockList.Find(x => x.StockName.Contains(((Stocks) subject).StockName));

                //temp.StockValue = ((Stocks) subject).StockValue;
                TotalStockRevenue = 0;
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
