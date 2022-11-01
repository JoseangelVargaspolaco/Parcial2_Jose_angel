using System.ComponentModel.DataAnnotations;

namespace Parcial2_Jose_angel.Models
{
    public class Vitaminas
    {
        [Key]
        public int VitaminaId { get; set; }

        [Required(ErrorMessage ="La descripcion es requerida")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage ="La extencia es requerida")]
        public decimal Existencia { get; set; }
    }
}