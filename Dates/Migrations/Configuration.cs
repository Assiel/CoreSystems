namespace Dates.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
  
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Data.Entity.Validation;

    internal sealed class Configuration : DbMigrationsConfiguration<Datos.FactClienteDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            
        }

        protected override void Seed(Datos.FactClienteDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.  
            //context.Database.Delete();    

            context.Productos.AddOrUpdate(x => x.ID
                ,
            new Entidades.Productos()
            {
                Nombre = "Mouse",
                Descripcion = "Mouse GAMER",
                Precio = Convert.ToDecimal(20),
                Activo = true
            },
            new Entidades.Productos()
            {
                Nombre = "Teclado",
                Descripcion = "Teclado GAMER",
                Precio = Convert.ToDecimal(45),
                Activo = true
            },
            new Entidades.Productos()
            {
                Nombre = "Tarjeta Gráfiica",
                Descripcion = "Para GAMER",
                Precio = Convert.ToDecimal(400),
                Activo = true
            });     

            context.Clientes.AddOrUpdate(x => x.ID, new Entidades.Clientes()
            {                
                Nombres = "Assiel Nahum",
                Apellidos = "Reyes Umaña",
                Cedula = "041-080591-0002V",
                Direccion="De la capilla el socorro 75 vrs al este",
                FechaCreacion=DateTime.Now,
                Activo=true
            },
            new Entidades.Clientes()
            {
                Nombres = "Keyrell Georgina",
                Apellidos = "Cuadra Fernandez",
                Cedula = "041-240689-0002X",
                Direccion = "Barrio Jass",
                FechaCreacion = DateTime.Now,
                Activo = true
            },
            new Entidades.Clientes()
            {
                Nombres = "Kiara Nahim",
                Apellidos = "Reyes Cuadra",
                Cedula = "041-150591-0002V",
                Direccion = "De la capilla el socorro 75 vrs al este",
                FechaCreacion = DateTime.Now,
                Activo = true
            }
            );
            context.SaveChanges();
            context.Facturas.AddOrUpdate(x => x.ID, new Entidades.Facturas()
            {
                ClientesId = 1,
                FechaCreacion = DateTime.Now,
                Activo = true
            },
            new Entidades.Facturas()
            {
                ClientesId = 2,
                FechaCreacion = DateTime.Now,
                Activo = true
            });
            context.SaveChanges();
            context.DetalleFactura.AddOrUpdate(x => x.ID, new Entidades.DetalleFacturas() {
                ProductosId=1,
                FacturasId=1,
                Cantidad=2,
                Precio=20,
                Total=2*20
            },
            new Entidades.DetalleFacturas()
            {
                ProductosId = 2,
                FacturasId = 1,
                Cantidad = 1,
                Precio = 45,
                Total = 1 * 45
            },

            new Entidades.DetalleFacturas()
            {
                ProductosId = 1,
                FacturasId = 2,
                Cantidad = 2,
                Precio = 20,
                Total = 2 * 20
            },
            new Entidades.DetalleFacturas()
            {
                ProductosId = 3,
                FacturasId = 2,
                Cantidad = 2,
                Precio = 400,
                Total = 2 * 400
            }
            );
        }
    }
}
