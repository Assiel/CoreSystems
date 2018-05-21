using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Clientes
    {
        public Clientes()
        {
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage = "Debe introducir el nombre del cliente")]
        [StringLength(50)]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Debe introducir los apellidos del cliente")]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Debe introducir la cédula del cliente")]
        [StringLength(16)]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Debe introducir la dirección del cliente")]
        [StringLength(250)]
        public string Direccion { get; set; }
        [Required]        
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Activo { get; set; }
    }
}
