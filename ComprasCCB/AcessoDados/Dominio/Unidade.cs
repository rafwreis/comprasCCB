using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComprasCCB.AcessoDados.Dominio
{
    public class Unidade
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
