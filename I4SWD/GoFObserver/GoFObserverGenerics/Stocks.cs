namespace GoFObserverGenerics
{
    public class Stocks : GoFObserverGeneric.Subject<Stocks>
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
