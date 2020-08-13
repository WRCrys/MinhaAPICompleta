
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

            CreateMap<ProdutoViewModel, Produto>();

            CreateMap<Produto, ProdutoViewModel>()
                .ForMember(dest => dest.NomeFornecedor, opt => opt.MapFrom(src => src.Fornecedor.Nome));
        }

    }
}
