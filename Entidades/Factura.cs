using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public Factura()
        {

        }

        public int ID { get; set; }
        public int ClientesId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Activo { get; set; }
        public virtual Clientes Clientes { get; set; }
    }
}
