using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {

        public Productos()
        {

        }

        public int ID { get; set; }
        public string Nombre {get;set;}
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public bool Activo { get; set; }
    }
}
