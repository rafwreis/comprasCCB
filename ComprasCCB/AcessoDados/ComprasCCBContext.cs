using ComprasCCB.AcessoDados.Configuracao;
using ComprasCCB.AcessoDados.Dominio;
using Microsoft.EntityFrameworkCore;

namespace ComprasCCB.AcessoDados
{
    public class ComprasCCBContext : DbContext
    {
        public ComprasCCBContext(DbContextOptions<ComprasCCBContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UnidadeConfiguracao());
            modelBuilder.ApplyConfiguration(new FornecedorConfiguracao());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguracao());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguracao());
        }

        public DbSet<Unidade> Unidade { get; set; }

        public DbSet<Fornecedor> Fornecedor { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Produto> Produto { get; set; }
    }
}
