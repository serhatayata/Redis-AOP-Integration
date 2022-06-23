namespace Redis.AopCache.API.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductDetail> Details { get; set; }
    }

    public class ProductDetail
    {
        public int ProductId { get; set; }
        public string Category { get; set; }
    }
}
