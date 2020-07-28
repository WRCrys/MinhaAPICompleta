
using AutoMapper;
using DevCA.Api.ViewModels;
using DevCA.Business.Models;

namespace DevCA.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //Resolvendo mapeamentos

            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();

            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();

            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }

    }
}
