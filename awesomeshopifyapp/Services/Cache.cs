using System;
using System.Collections.Generic;

namespace awesomeshopifyapp.Services
{
    public class CachedValue<T>
    {
        public T Value { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class Cache<T> : ICache<T>
    {
        private Dictionary<int, CachedValue<T>> _cachedValues;

        private ICacheExpirationPolicy<T> _expirationPolicy;

        public Cache(ICacheExpirationPolicy<T> expirationPolicy)
        {
            _cachedValues = new Dictionary<int, CachedValue<T>>();
            _expirationPolicy = expirationPolicy;
        }

        public bool HasValue(T value)
        {
            var key = value.GetHashCode();
            if (_cachedValues.ContainsKey(key) && !_expirationPolicy.HasExpired(_cachedValues[key]))
            {
                _cachedValues[key] = new CachedValue<T>
                {
                    Value = value,
                    UpdatedAt = DateTime.Now
                };
                return true;
            }

            _cachedValues[key] = new CachedValue<T>
            {
                Value = value,
                UpdatedAt = DateTime.Now
            };
            return false;
        }
    }
}
