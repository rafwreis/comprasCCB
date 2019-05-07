using ComprasCCB.AcessoDados.Dominio;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComprasCCB.Models
{
    public class ProdutoViewModel
    {
        [Display(Name = "Identificação")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Referência")]
        public string Referencia { get; set; }

        [Display(Name = "Último Preço")]
        public double UltimoPreco { get; set; }

        [Display(Name = "Fornecedor")]
        public int? FornecedorId { get; set; }

        [Display(Name = "Unidade")]
        public int? UnidadeId { get; set; }

        [Display(Name = "Categoria")]
        public int? CategoriaId { get; set; }
    }
}
