using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComprasCCB.AcessoDados.Dominio
{
    public class Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public Unidade Unidade { get; set; }

        public string Referencia { get; set; }

        public double UltimoPreco { get; set; }
    }
}
