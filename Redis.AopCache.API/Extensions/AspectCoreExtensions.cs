using AspectCore.Configuration;
using AspectCore.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Redis.AopCache.API.Services;
using Redis.AopCache.Core.Interceptors;

namespace Redis.AopCache.API.Extensions
{
    public static class AspectCoreExtensions
    {
		public static void ConfigAspectCore(this IServiceCollection services)
		{
			services.ConfigureDynamicProxy(config =>
			{
				config.Interceptors.AddTyped<CacheAbleInterceptor>(Predicates.Implement(typeof(DemoService)));
			});
		}
	}
}
