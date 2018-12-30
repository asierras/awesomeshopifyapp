using awesomeshopifyapp.Model.FacebookModel;
using System;

namespace awesomeshopifyapp.Services
{
    internal class TTLExpirationPolicy : ICacheExpirationPolicy<FbUser>
    {
        public TimeSpan TTL { get; set; }

        public TTLExpirationPolicy()
        {
            TTL = TimeSpan.FromDays(1);
        }

        public virtual bool HasExpired(CachedValue<FbUser> cachedValue)
        {
            return cachedValue.UpdatedAt.Add(TTL) < DateTime.Now;
        }
    }
}