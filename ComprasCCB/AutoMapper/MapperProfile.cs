using AutoMapper;
using ComprasCCB.AcessoDados.Dominio;
using ComprasCCB.Models;

namespace ComprasCCB.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<Unidade, UnidadeViewModel>().ReverseMap();
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Categoria, CategoriaViewModel>().ReverseMap();
        }
    }
}
