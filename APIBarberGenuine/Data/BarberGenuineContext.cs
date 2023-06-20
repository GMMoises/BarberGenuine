using APIBarberGenuine.Models;
using Microsoft.EntityFrameworkCore;

namespace APIBarberGenuine.Data
{
    public class BarberGenuineContext:DbContext
    {
        public BarberGenuineContext(DbContextOptions<BarberGenuineContext> options) : base(options)
        {

        }

        public DbSet<Cita> Citas { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Factura> Facturas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Cita>().HasOne(e => e.Client).WithMany(e => e.citas).HasForeignKey(d => d.ClientId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Client>().HasData(
                new Client()
                {
                    Id = 1,
                    Name = "Moises",
                    LastName = "Gallegos",
                    Phone = "76130819"
                },
                new Client()
                {
                    Id = 2,
                    Name = "Mateo",
                    LastName= "Oviedo",
                    Phone = "81133691"
                });
            modelBuilder.Entity<Cita>().HasData(
                new Cita()
                {
                    Id = 1,
                    //PersonName = "Moises Gallegos",
                    Dates = new DateTime(2023, 06, 14),
                    Service = "Corte",
                    ClientId = 1


                },
                new Cita()
                {
                    Id = 2,
                    //PersonName = "Pedro Gutierrez",
                    Dates = new DateTime(2023, 06, 15),
                    Service = "Barba",
                    ClientId = 2
                },
                new Cita()
                {
                    Id = 3,
                    //PersonName = "Pedro Gutierrez",
                    Dates = new DateTime(2023, 06, 08),
                    Service = "Barba",
                    ClientId = 1
                });

            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id = 1,
                   NameProduct = "CeraSpider",
                   UnitInStock = 100,
                   PriceUnit = 50,
                   Providers = "Ceras S.A",
                   FacturaId = 1
               },
               new Product()
               {
                   Id = 2,
                   NameProduct = "Gel EGO",
                   UnitInStock = 100,
                   PriceUnit = 25,
                   Providers = "eGo",
                   FacturaId= 2
               },
               new Product()
               {
                   Id = 3,
                   NameProduct = "Crema Sedal",
                   UnitInStock = 100,
                   PriceUnit = 15,
                   Providers = "Sedal",
                   FacturaId = 3
               },
               new Product()
               {
                   Id = 4,
                   NameProduct = "XTREME",
                   UnitInStock = 460,
                   PriceUnit = 15,
                   Providers = "Belleza S.A",
                   FacturaId = 3
               },
               new Product()
               {
                   Id = 5,
                   NameProduct = "Shampoo Sedal",
                   UnitInStock = 300,
                   PriceUnit = 20,
                   Providers = "Sedal",
                   FacturaId = 3
               },
               new Product()
               {
                   Id = 6,
                   NameProduct = "CeraXtreme",
                   UnitInStock = 300,
                   PriceUnit = 45,
                   Providers = "Belleza S.A",
                   FacturaId = 3
               },
               new Product()
               {
                   Id = 7,
                   NameProduct = "Fijador EGO",
                   UnitInStock = 240,
                   PriceUnit = 60,
                   Providers = "eGo",
                   FacturaId = 3
               },
               new Product()
               {
                   Id = 8,
                   NameProduct = "Crema Pert",
                   UnitInStock = 100,
                   PriceUnit = 30,
                   Providers = "Schwarzkpf",
                   FacturaId = 3
               },
               new Product()
               {
                   Id = 9,
                   NameProduct = "Seda Rizos",
                   UnitInStock = 600,
                   PriceUnit = 15,
                   Providers = "Sedal",
                   FacturaId = 3
               },
               new Product()
               {
                   Id = 10,
                   NameProduct = "Cera vol.10",
                   UnitInStock = 250,
                   PriceUnit = 30,
                   Providers = "Cera's S.A",
                   FacturaId = 3
               });

            modelBuilder.Entity<Factura>().HasData(
                new Factura()
                {
                    Id = 1,
                    Fecha= DateTime.Now,
                    Description = "Venta",
                    SoldUnits = 3,
                    Total=150

                },
                new Factura()
                {
                    Id = 2,
                    Fecha = DateTime.Now,
                    Description = "Venta",
                    SoldUnits = 2 ,
                    Total = 50

                },
                new Factura()
                {
                    Id = 3,
                    Fecha = DateTime.Now,
                    Description = "Venta",
                    SoldUnits= 3,
                    Total = 45

                });

        }

    }
}
