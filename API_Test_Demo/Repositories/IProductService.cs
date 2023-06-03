using API_Test_Demo.Entities;

namespace API_Test_Demo.Repositories
{
    public interface IProductService
    {
        public Task<List<ProductDetails>> ProductListAsync();

        public Task<ProductDetails> GetProductDetailByIdAsync(int productId);

        public Task<bool> AddProductAsync(ProductDetails productDetails);

        public Task<bool> UpdateProductAsync(ProductDetails productDetails);

        public Task<bool> DeleteProductAsync(int productId);
    }
}
