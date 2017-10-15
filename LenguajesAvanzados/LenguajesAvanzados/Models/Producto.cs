using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace LenguajesAvanzados.Models
{
    [Table("Producto")]
    public partial class Producto
    {
        [Key]
        public int IDProducto { get; set; }
        [Required]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [Required]
        [DisplayName("Precio/U")]
        public decimal Precio { get; set; }

        [Required]
        [DisplayName("Categoria")]
        public int IDCategoria { get; set; }
        [ForeignKey("IDCategoria")]
        public virtual Categoria Categorias { get; set; }

        [Required]
        [DisplayName("Proveedor")]
        public int IDProveedor { get; set; }
        [ForeignKey("IDProveedor")]
        public virtual Proveedor Proveedors { get; set; }

        [Required]
        [Display(Name = "Fecha Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreado { get; set; }

        public ICollection<Detalle> Detalles { get; set; }
        
    }
}