using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Productos
    {

        public Productos()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage= "Debe introducir el nombre del producto")]
        [StringLength(50)]
        public string Nombre {get;set;}
        [Required(ErrorMessage = "Debe introducir la descripción del producto")]
        [StringLength(150)]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Debe introducir el precio del producto")]
        
        public decimal Precio { get; set; }
        public bool Activo { get; set; }
    }
}
