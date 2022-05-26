using DevIO.Business.Models;

namespace DevIO.Business.Interfaces.Services
{
    public interface IProviderService : IDisposable
    {
        Task AddAsync(Provider provider);
        
        Task UpdateAsync(Provider provider);
        
        Task RemoveAsync(Guid id);
        
        Task AddressUpdateAsync(Address address);
    }
}
