using System.ComponentModel.DataAnnotations;

namespace ComprasCCB.Models
{
    public class CategoriaViewModel
    {
        [Display(Name = "Identificação")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}
