using ComprasCCB.AcessoDados.Configuracao;
using ComprasCCB.AcessoDados.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            modelBuilder.ApplyConfiguration(new ProdutoConfiguracao());
        }

        public DbSet<Unidade> Unidade { get; set; }

        public DbSet<Fornecedor> Fornecedor { get; set; }

        public DbSet<Produto> Produto { get; set; }
    }
}
