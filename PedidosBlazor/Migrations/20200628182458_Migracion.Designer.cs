﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PedidosBlazor.DAL;

namespace PedidosBlazor.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200628182458_Migracion")]
    partial class Migracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("PedidosBlazor.Models.Ordenes", b =>
                {
                    b.Property<int>("ordenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("monto")
                        .HasColumnType("TEXT");

                    b.Property<int>("suplidorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ordenId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("PedidosBlazor.Models.OrdenesDetalle", b =>
                {
                    b.Property<int>("ordenDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("costo")
                        .HasColumnType("TEXT");

                    b.Property<int>("ordenId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("productoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ordenDetalleId");

                    b.HasIndex("ordenId");

                    b.ToTable("OrdenesDetalle");
                });

            modelBuilder.Entity("PedidosBlazor.Models.Productos", b =>
                {
                    b.Property<int>("productoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("costo")
                        .HasColumnType("TEXT");

                    b.Property<string>("descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("inventario")
                        .HasColumnType("INTEGER");

                    b.HasKey("productoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            productoId = 1,
                            costo = 100m,
                            descripcion = "Agua Frandy",
                            inventario = 0
                        },
                        new
                        {
                            productoId = 2,
                            costo = 100m,
                            descripcion = "Botellones",
                            inventario = 0
                        });
                });

            modelBuilder.Entity("PedidosBlazor.Models.Suplidores", b =>
                {
                    b.Property<int>("suplidorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("suplidorId");

                    b.ToTable("Suplidores");

                    b.HasData(
                        new
                        {
                            suplidorId = 1,
                            nombre = "Frandy"
                        },
                        new
                        {
                            suplidorId = 2,
                            nombre = "Embases Dominicano"
                        });
                });

            modelBuilder.Entity("PedidosBlazor.Models.OrdenesDetalle", b =>
                {
                    b.HasOne("PedidosBlazor.Models.Ordenes", null)
                        .WithMany("OrdenDetalles")
                        .HasForeignKey("ordenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
