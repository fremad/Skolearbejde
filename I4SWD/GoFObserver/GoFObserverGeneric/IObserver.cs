


namespace GoFObserverGeneric
{
    public interface IObserver<T>
    {
        void Update(Subject<T> subject);
    }
}
