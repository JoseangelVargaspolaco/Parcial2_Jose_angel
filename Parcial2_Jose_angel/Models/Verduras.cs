using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial2_Jose_angel.Models
{
    public class Verduras
    {
        [Key]
        public int VerduraId { get; set; }

        [Required(ErrorMessage ="La fecha es requerida")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage ="La descripcion es requerida")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage ="Una observacion es requerida")]
        public string? Observaciones { get; set; }  
        
        [ForeignKey("VerduraId")]
        public List<VerdurasDetalles> Detalle { get; set; } = new List<VerdurasDetalles>();

    }
}