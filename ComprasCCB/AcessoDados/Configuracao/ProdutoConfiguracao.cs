using ComprasCCB.AcessoDados.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComprasCCB.AcessoDados.Configuracao
{
    public class ProdutoConfiguracao : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id);
            builder.Property(p => p.Descricao).HasMaxLength(200);
            builder.Property(p => p.UnidadeId);
            builder.Property(p => p.CategoriaId);
            builder.Property(p => p.FornecedorId);
            builder.Property(p => p.Referencia);
            builder.Property(p => p.UltimoPreco);

            builder.HasOne(p => p.Unidade).WithMany(p => p.Produtos);
            builder.HasOne(p => p.Fornecedor).WithMany(p => p.Produtos);
            builder.HasOne(p => p.Categoria).WithMany(p => p.Produtos);
        }
    }
}
