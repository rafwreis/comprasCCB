using AutoMapper;
using ComprasCCB.AcessoDados.Dominio;
using ComprasCCB.Models;

namespace ComprasCCB.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Unidade, UnidadeViewModel>().ReverseMap();
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Categoria, CategoriaViewModel>().ReverseMap();

            CreateMap<Produto, ProdutoViewModel>()
                .ForMember(d => d.Unidade, o => o.MapFrom(m => m.Unidade.Descricao))
                .ForMember(d => d.Categoria, o => o.MapFrom(m => m.Categoria.Descricao))
                .ForMember(d => d.Fornecedor, o => o.MapFrom(m => m.Fornecedor.Descricao))
                .ReverseMap();
        }
    }
}
