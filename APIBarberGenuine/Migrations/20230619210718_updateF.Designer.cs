﻿// <auto-generated />
using System;
using APIBarberGenuine.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIBarberGenuine.Migrations
{
    [DbContext(typeof(BarberGenuineContext))]
    [Migration("20230619210718_updateF")]
    partial class updateF
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("APIBarberGenuine.Models.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Dates")
                        .HasColumnType("datetime2");

                    b.Property<string>("Service")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Citas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 1,
                            Dates = new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Service = "Corte"
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 2,
                            Dates = new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Service = "Barba"
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 1,
                            Dates = new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Service = "Barba"
                        });
                });

            modelBuilder.Entity("APIBarberGenuine.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LastName = "Gallegos",
                            Name = "Moises",
                            Phone = "76130819"
                        },
                        new
                        {
                            Id = 2,
                            LastName = "Oviedo",
                            Name = "Mateo",
                            Phone = "81133691"
                        });
                });

            modelBuilder.Entity("APIBarberGenuine.Models.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoldUnits")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Facturas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Venta",
                            Fecha = new DateTime(2023, 6, 19, 15, 7, 18, 633, DateTimeKind.Local).AddTicks(3346),
                            SoldUnits = 3,
                            Total = 150m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Venta",
                            Fecha = new DateTime(2023, 6, 19, 15, 7, 18, 633, DateTimeKind.Local).AddTicks(3356),
                            SoldUnits = 2,
                            Total = 50m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Venta",
                            Fecha = new DateTime(2023, 6, 19, 15, 7, 18, 633, DateTimeKind.Local).AddTicks(3357),
                            SoldUnits = 3,
                            Total = 45m
                        });
                });

            modelBuilder.Entity("APIBarberGenuine.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FacturaId")
                        .HasColumnType("int");

                    b.Property<string>("NameProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PriceUnit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Providers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FacturaId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FacturaId = 1,
                            NameProduct = "CeraSpider",
                            PriceUnit = 50m,
                            Providers = "Ceras S.A",
                            UnitInStock = 100
                        },
                        new
                        {
                            Id = 2,
                            FacturaId = 2,
                            NameProduct = "Gel EGO",
                            PriceUnit = 25m,
                            Providers = "eGo",
                            UnitInStock = 100
                        },
                        new
                        {
                            Id = 3,
                            FacturaId = 3,
                            NameProduct = "Crema Sedal",
                            PriceUnit = 15m,
                            Providers = "Sedal",
                            UnitInStock = 100
                        });
                });

            modelBuilder.Entity("APIBarberGenuine.Models.Cita", b =>
                {
                    b.HasOne("APIBarberGenuine.Models.Client", "Client")
                        .WithMany("Citas")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("APIBarberGenuine.Models.Product", b =>
                {
                    b.HasOne("APIBarberGenuine.Models.Factura", "Factura")
                        .WithMany("Products")
                        .HasForeignKey("FacturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factura");
                });

            modelBuilder.Entity("APIBarberGenuine.Models.Client", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("APIBarberGenuine.Models.Factura", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
