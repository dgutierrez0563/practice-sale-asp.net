using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LenguajesAvanzados.Models
{
    public class Detalle
    {
        [Key]
        public int IDDetalle { get; set; }
        [Required]
        public int IDFactura { get; set; }
        [ForeignKey("IDFactura")]
        public virtual Facturar Facturars { get; set; }
        [Required]
        public int IDProducto { get; set; }
        [ForeignKey("IDProducto")]
        public virtual Producto Productos { get; set; }
        [Required]
        [DisplayName("Cantidad")]
        public int Cantidad { get; set; }

    }
}