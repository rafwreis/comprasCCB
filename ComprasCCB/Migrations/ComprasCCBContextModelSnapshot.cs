﻿// <auto-generated />
using System;
using ComprasCCB.AcessoDados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComprasCCB.Migrations
{
    [DbContext(typeof(ComprasCCBContext))]
    partial class ComprasCCBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ComprasCCB.AcessoDados.Dominio.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("ComprasCCB.AcessoDados.Dominio.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("ComprasCCB.AcessoDados.Dominio.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaId");

                    b.Property<string>("Descricao")
                        .HasMaxLength(200);

                    b.Property<int?>("FornecedorId");

                    b.Property<string>("Referencia");

                    b.Property<double?>("UltimoPreco");

                    b.Property<int?>("UnidadeId");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("UnidadeId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("ComprasCCB.AcessoDados.Dominio.Unidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Unidade");
                });

            modelBuilder.Entity("ComprasCCB.AcessoDados.Dominio.Produto", b =>
                {
                    b.HasOne("ComprasCCB.AcessoDados.Dominio.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId");

                    b.HasOne("ComprasCCB.AcessoDados.Dominio.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId");

                    b.HasOne("ComprasCCB.AcessoDados.Dominio.Unidade", "Unidade")
                        .WithMany("Produtos")
                        .HasForeignKey("UnidadeId");
                });
#pragma warning restore 612, 618
        }
    }
}
