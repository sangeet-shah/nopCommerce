﻿using Nop.Core.Domain.Tax;
using Nop.Services.Caching.CachingDefaults;

namespace Nop.Services.Caching.CacheEventConsumers.Tax
{
    public partial class TaxCategoryCacheEventConsumer : CacheEventConsumer<TaxCategory>
    {
        public override void ClearCashe(TaxCategory entity)
        {
            RemoveByPrefix(NopTaxCachingDefaults.TaxCategoriesPrefixCacheKey);
        }
    }
}
