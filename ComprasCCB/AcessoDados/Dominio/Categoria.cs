using System.Collections.Generic;

namespace ComprasCCB.AcessoDados.Dominio
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
