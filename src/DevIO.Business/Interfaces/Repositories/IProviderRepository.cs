using DevIO.Business.Models;

namespace DevIO.Business.Interfaces.Repositories
{
    public interface IProviderRepository : IRepository<Provider>
    {
        Task<Provider> GetAddressProviderAsync(Guid id);
        
        Task<Provider> GetProductsAddressProviderAsync(Guid id);
    }
}
