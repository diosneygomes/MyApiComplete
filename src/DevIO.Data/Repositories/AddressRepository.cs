using DevIO.Business.Interfaces.Repositories;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevIO.Data.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(MyDbContext context) : base(context) { }
        public async Task<Address> GetAddressByProviderAsync(Guid providerId)
        {
            return await Db.Addresses.AsNoTracking()
                .FirstOrDefaultAsync(p => p.ProviderId == providerId);
        }
    }
}
