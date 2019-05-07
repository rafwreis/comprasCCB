namespace ComprasCCB.AcessoDados.Dominio
{
    public class Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public int? FornecedorId { get; set; }

        public int? UnidadeId { get; set; }

        public int? CategoriaId { get; set; }

        public string Referencia { get; set; }

        public double UltimoPreco { get; set; }

        public virtual Unidade Unidade { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
    }
}
