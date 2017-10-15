using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LenguajesAvanzados.Models
{
    public class Facturar
    {        
        [Key]
        public int IDFactura { get; set; }

        [Required]
        public int IDCliente { get; set; }
        [ForeignKey("IDCliente")]
        public virtual Cliente Clientes { get; set; }

        [Required]
        public int IDVendedor { get; set; }
        [ForeignKey("IDVendedor")]
        public virtual Vendedor Vendedors { get; set; }

        [Required]
        [Display(Name = "Fecha Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreado { get; set; }

        public ICollection<Detalle> Detalles { get; set; }
    }

}