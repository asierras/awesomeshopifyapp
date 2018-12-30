namespace awesomeshopifyapp.Services
{
    public interface ICache<T>
    {
        bool HasValue(T value);
    }
}