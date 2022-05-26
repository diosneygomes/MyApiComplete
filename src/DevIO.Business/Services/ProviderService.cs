using DevIO.Business.Interfaces.Repositories;
using DevIO.Business.Interfaces.Services;
using DevIO.Business.Models;
using DevIO.Business.Models.Validations;
using DevIO.Business.Notifications.Interfaces;

namespace DevIO.Business.Services
{
    public class ProviderService : BaseService, IProviderService
    {
        private readonly IProviderRepository _providerRepository;
        private readonly IAddressRepository _addressRepository;
        public ProviderService(IProviderRepository providerRepository, IAddressRepository addressRepository, INotifier notifier) : base(notifier)
        {
            _providerRepository = providerRepository;
            _addressRepository = addressRepository;
        }
        public async Task AddAsync(Provider provider)
        {
            if (!ExecuteValidation(new ProviderValidation(), provider)
                || !ExecuteValidation(new AddressValidation(), provider.Address)) return;

            if (_providerRepository.SearchAsync(p => p.Document == provider.Document).Result.Any())
            {
                Notify("Já existe um fornecedor com este documento informado.");
                return;
            }

            await _providerRepository.AddAsync(provider);
        }
        public async Task UpdateAsync(Provider provider)
        {
            if (!ExecuteValidation(new ProviderValidation(), provider)) return;

            if (_providerRepository.SearchAsync(p => p.Document == provider.Document && p.Id != provider.Id).Result.Any())
            {
                Notify("Já existe um fornecedor com este documento informado.");
                return;
            }

            await _providerRepository.UpdateAsync(provider);
        }

        public async Task RemoveAsync(Guid id)
        {
            if (_providerRepository.GetProductsAddressProviderAsync(id).Result.Products.Any())
            {
                Notify("O Fornecedor possui produtos cadastrados!");
                return;
            }

            var address = await _addressRepository.GetAddressByProviderAsync(id);

            if (address != null)
            {
                await _addressRepository.RemoveAsync(address.Id);
            }

            await _providerRepository.RemoveAsync(id);
        }

        public async Task AddressUpdateAsync(Address address)
        {
            if (!ExecuteValidation(new AddressValidation(), address)) return;

            await _addressRepository.UpdateAsync(address);
        }

        public void Dispose()
        {
            _providerRepository?.Dispose();
            _addressRepository?.Dispose();
        }
    }
}
