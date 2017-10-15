using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LenguajesAvanzados.Models
{
    public class Vendedor
    {
        [Key]
        public int IDVendedor { get; set; }
        [Required]
        [DisplayName("Nombre")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Apellidos")]
        public string Apellido { get; set; }
        [Required]
        [Display(Name = "Fecha Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreado { get; set; }

        public ICollection<Facturar> Facturars { get; set; }
    }
}