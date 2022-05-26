using DevIO.Business.Models;

namespace DevIO.Business.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsProvidersAsync();
        
        Task<IEnumerable<Product>> GetProvidersProductsAsync(Guid providerId);
        
        Task<Product> GetProviderProductAsync(Guid id);
    }
}
