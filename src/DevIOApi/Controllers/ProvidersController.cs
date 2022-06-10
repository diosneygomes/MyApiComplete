using AutoMapper;
using DevIO.Business.Interfaces.Repositories;
using DevIOApi.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevIOApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvidersController : MainController
    {
        private readonly IProviderRepository _providerRepository;
        private readonly IMapper _mapper;


        public ProvidersController(
            IProviderRepository providerRepository,
            IMapper mapper)
        {
            _providerRepository = providerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProviderViewModel>> GetAll()
        {
            var fornecedores = _mapper.Map<IEnumerable<ProviderViewModel>>(await _providerRepository.GetAllAsync());

            return fornecedores;
        }
    }
}
