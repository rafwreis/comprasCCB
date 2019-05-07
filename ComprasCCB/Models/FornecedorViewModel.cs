using System.ComponentModel.DataAnnotations;

namespace ComprasCCB.Models
{
    public class FornecedorViewModel
    {
        [Display(Name = "Identificação")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}
