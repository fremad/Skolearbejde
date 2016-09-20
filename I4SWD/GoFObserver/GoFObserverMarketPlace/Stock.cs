namespace GoFObserverMarketPlace
{
    public class Stock : GoFObserverGeneric.Subject<Stock>
    {
        private double _stockValue;

        public double StockValue
        {
            get { return _stockValue; }
            set
            {
                _stockValue = value;
                Notify(this);
            }
        }


        public string StockName { get; set; }
    }
}
