namespace awesomeshopifyapp.Services
{
    public interface ICacheExpirationPolicy<T>
    {
        bool HasExpired(CachedValue<T> cachedValue);
    }
}