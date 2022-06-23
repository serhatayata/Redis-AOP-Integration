using Redis.AopCache.API.Models;
using Redis.AopCache.Core.Attributes;

namespace Redis.AopCache.API.Services
{
    public class DemoService
    {
        [CacheAble(CacheKeyPrefix = "test", Expiration = 30, OnceUpdate = true)]
        public async virtual Task<DateTimeModel> GetTime()
        {
            return await Task.Run(() =>
            {
                return new DateTimeModel
                {
                    Id = GetHashCode(),
                    Time = DateTime.Now
                };
            });
        }

        [CacheAble(CacheKeyPrefix = "product", Expiration = 30, OnceUpdate = true)]
        public async virtual Task<List<ProductModel>> GetProductsAsync()
        {

            return await Task.Run(() =>
            {
                var products = new[]
                {
                    new ProductModel{Id=1,Name="Product1",Details = new[]{ new ProductDetail { ProductId = 1, Category = "Category1" }, new ProductDetail {ProductId=1,Category= "Category2" } }.ToList() },
                    new ProductModel{Id=2,Name="Product2",Details = new[]{ new ProductDetail { ProductId = 2, Category = "Category1" }, new ProductDetail {ProductId=2,Category= "Category2" } }.ToList() },
                    new ProductModel{Id=3,Name="Product3",Details = new[]{ new ProductDetail { ProductId = 3, Category = "Category1" }, new ProductDetail {ProductId=3,Category= "Category2" } }.ToList() },
                };
                return products.ToList();
            });
        }

        [CacheAble(CacheKeyPrefix = "product", Expiration = 30, OnceUpdate = true)]
        public virtual List<ProductModel> GetProducts()
        {
            var products = new[]
            {
                    new ProductModel{Id=1,Name="Product1",Details = new[]{ new ProductDetail { ProductId = 1, Category = "Category1" }, new ProductDetail {ProductId=1,Category= "Category2" } }.ToList() },
                    new ProductModel{Id=2,Name="Product2",Details = new[]{ new ProductDetail { ProductId = 2, Category = "Category1" }, new ProductDetail {ProductId=2,Category= "Category2" } }.ToList() },
                    new ProductModel{Id=3,Name="Product3",Details = new[]{ new ProductDetail { ProductId = 3, Category = "Category1" }, new ProductDetail {ProductId=3,Category= "Category2" } }.ToList() },
                };
            return products.ToList();
        }
    }
}
