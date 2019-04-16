using ComprasCCB.AcessoDados.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComprasCCB.AcessoDados.Configuracao
{
    public class UnidadeConfiguracao : IEntityTypeConfiguration<Unidade>
    {
        public void Configure(EntityTypeBuilder<Unidade> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id);
            builder.Property(p => p.Descricao).HasMaxLength(200);
        }
    }
}
