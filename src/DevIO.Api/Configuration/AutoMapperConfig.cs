using AutoMapper;
using DevIO.Business.Models;
using DevIOApi.ViewModel;

namespace DevIOApi.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Provider, ProviderViewModel>().ReverseMap();
            CreateMap<Address, AddressViewModel>().ReverseMap();
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}
