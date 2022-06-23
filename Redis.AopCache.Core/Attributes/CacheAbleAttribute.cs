using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redis.AopCache.Core.Attributes
{
    public class CacheAbleAttribute: Attribute
    {
		public int Expiration { get; set; } = 300;
		public string CacheKeyPrefix { get; set; } = string.Empty;
		public bool IsHighAvailability { get; set; } = true;
		public bool OnceUpdate { get; set; } = false;
	}
}
