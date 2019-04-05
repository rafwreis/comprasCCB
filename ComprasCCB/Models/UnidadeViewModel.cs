using System.ComponentModel.DataAnnotations;

namespace ComprasCCB.Models
{
    public class UnidadeViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }
    }
}
