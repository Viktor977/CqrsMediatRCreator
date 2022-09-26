namespace CqrsMadiatRExampel.Models
{
    public class FakeDataStore
    {
        private List<Product> _products;
        public FakeDataStore()
        {
            _products = new List<Product>()
            {
                new Product(){Id=1,Name="Test Product one"},
                new Product(){Id=2,Name="Test Product two"},
                new Product(){Id=3,Name="Test Product three"},
                new Product(){Id=4,Name="Test Product foure"},
            };
        }



        public async Task AddProduct(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Product>> GetProductsAll() =>
            await Task.FromResult(_products);

        public async Task<Product> GetById(int id) =>
            await Task.FromResult(_products.Single(t => t.Id == id));

        public async Task EventOccured(Product product, string evt)
        {
            _products.Single(r => r.Id == product.Id).Name = $"{product.Name} evt: {evt}";
            await Task.CompletedTask;
        }
    }
}
