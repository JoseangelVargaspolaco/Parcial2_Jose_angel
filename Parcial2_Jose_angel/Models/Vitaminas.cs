using System.ComponentModel.DataAnnotations;

namespace Parcial2_Jose_angel.Models
{
    public class Vitaminas
    {
        [Key]
        public int VitaminaId { get; set; }
        public string Descripcion { get; set; }
        public double Existencia { get; set; }
    }
}