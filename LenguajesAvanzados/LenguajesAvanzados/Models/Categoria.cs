using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LenguajesAvanzados.Models
{
    public class Categoria
    {
        
        [Key]
        public int IDCategoria { get; set; }
        [Required]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [Required]
        [DisplayName("Detalle")]
        public string Detalle { get; set; }

        [Required]
        [Display(Name = "Fecha Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreado { get; set; }

        public ICollection<Producto> Productos { get; set; }
    }
}