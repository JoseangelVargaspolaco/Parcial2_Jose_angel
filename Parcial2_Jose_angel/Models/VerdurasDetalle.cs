using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial2_Jose_angel.Models
{
   public class VerdurasDetalles
    {
        [Key]
        public int Id { get; set; }
        public int VerduraId { get; set; }
        public int VitaminaId { get; set; }
        public double Cantidad { get; set; }
        public double Total { get; set; }

    }
   
}