using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleFacturas
    {
        public DetalleFacturas()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int ProductosId { get; set; }
        public int FacturasId { get; set; }
        [Required(ErrorMessage = "Debe introducir la cantidad del producto")]
        public Int16 Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }


        public virtual Facturas Facturas { get; set; }
        public virtual Productos Productos { get; set; }
    }
}
