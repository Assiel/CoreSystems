using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

using Entidades;



namespace Datos
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class FactClienteDbContext:DbContext
    {
        public FactClienteDbContext():base("CnnFactCliente")
        {
            //Database.SetInitializer<FactClienteDbContext>(new DropCreateDatabaseAlways<FactClienteDbContext>());
        }

        
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<DetalleFacturas> DetalleFactura { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<DateTime>().Configure(x => x.HasColumnType("smalldatetime"));
            modelBuilder.Properties<int>().Where(x => x.Name.StartsWith("ID")).Configure(p => p.IsKey());

            modelBuilder.Entity<Productos>()
                     .Property(x => x.Precio)
                     .HasPrecision(8, 2);

            modelBuilder.Entity<DetalleFacturas>()
                     .Property(x => x.Precio)
                     .HasPrecision(8, 2);

            modelBuilder.Entity<DetalleFacturas>()
                     .Property(x => x.Total)
                     .HasPrecision(8, 2);
        }
        }


}
