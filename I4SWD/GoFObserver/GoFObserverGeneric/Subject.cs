using System;
using System.Collections.Generic;

namespace GoFObserverGeneric
{
    public abstract class Subject<T>
    {
        public void Attach(IObserver<T> obs)
        {
            _observers.Add(obs);
        }
        public void Detach(IObserver<T> obs)
        {
            _observers.Remove(obs);
        }
        public void Notify(Subject<T> subject)
        {
            foreach (var item in _observers)
            {
                item.Update(subject);
            }
        }

        readonly List<IObserver<T>> _observers = new List<IObserver<T>>();
    }
}
