﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFObserver
{
    public class Stocks : GoFObserverDLL.Subject
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
