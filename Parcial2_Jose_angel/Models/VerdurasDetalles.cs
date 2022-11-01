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
        public decimal Cantidad { get; set; }
        public decimal Total { get; set; }


        // Nota: Para agregar el Vitaminas.Descripcion se iniciar 
        // con la declaracion de un nuevo atributo con el nombre Descripcion para almacenar el dato
        // o pasar los datos del Vitaminas.Descripcion al atributo creado.

        // Entidad nueva
        public string Descripcion { get; set; }
        
    }  
}