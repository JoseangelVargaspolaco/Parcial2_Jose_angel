using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial2_Jose_angel.Models
{
    public class Verduras
    {
        [Key]
        public int VerduraId { get; set; }
        public string? Nombre { get; set; }

        [ForeignKey("VerduraId")]
        public List<VerdurasDetalles> Detalle { get; set; } = new List<VerdurasDetalles>();

    }
}