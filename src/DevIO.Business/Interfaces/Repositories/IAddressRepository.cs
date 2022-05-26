using DevIO.Business.Models;

namespace DevIO.Business.Interfaces.Repositories
{
    public interface IAddressRepository : IRepository<Address>
    {
        Task<Address> GetAddressByProviderAsync(Guid providerId);
    }
}
