using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFObserverDLL
{
    public abstract class Subject
    {
        public void Attach(IObserver obs)
        {
            _observers.Add(obs);
        }
        public void Detach(IObserver obs)
        {
            _observers.Remove(obs);
        }
        public void Notify(Subject subject)
        {
            foreach (var item in _observers)
            {
                item.Update(subject);
            }
        }

       readonly List<IObserver> _observers = new List<IObserver>(); 
    }
}
