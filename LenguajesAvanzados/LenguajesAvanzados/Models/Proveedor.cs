using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LenguajesAvanzados.Models
{
    public class Proveedor
    {
        [Key]
        public int IDProveedor { get; set; }

        [Required]
        [StringLength(30)]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Representante")]
        public string Encargado { get; set; }

        [Required]
        [StringLength(30)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Telefono")]
        public string Telefono { get; set; }

        [Required]
        [StringLength(200)]
        [DisplayName("Descripcion")]
        public string Descripcion { get; set; }
        [Required]
        [Display(Name = "Fecha Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Productos { get; set; }
    }
}