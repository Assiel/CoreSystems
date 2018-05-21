using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleFactura
    {
        public DetalleFactura()
        {

        }

        public int ID { get; set; }
        public int ProductosId { get; set; }
        public int FacturaId { get; set; }
        public Int16 Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }


        public virtual Factura Factura {get;set;}
        public virtual List<Productos> Productos { get; set; }
    }
}
