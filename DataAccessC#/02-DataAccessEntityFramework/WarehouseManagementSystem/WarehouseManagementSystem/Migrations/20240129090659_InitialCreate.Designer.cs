﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WarehouseManagementSystem;

#nullable disable

namespace WarehouseManagementSystem.Migrations
{
    [DbContext(typeof(WarehouseContext))]
    [Migration("20240129090659_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ItemWarehouse", b =>
                {
                    b.Property<Guid>("ItemsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WarehousesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ItemsId", "WarehousesId");

                    b.HasIndex("WarehousesId");

                    b.ToTable("ItemWarehouse");
                });

            modelBuilder.Entity("WarehouseManagementSystem.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WarehouseManagementSystem.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InStock")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("WarehouseManagementSystem.LineItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("LineItems");
                });

            modelBuilder.Entity("WarehouseManagementSystem.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ShippingProviderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ShippingProviderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WarehouseManagementSystem.ShippingProvider", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("FreightCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShippingProviders");
                });

            modelBuilder.Entity("WarehouseManagementSystem.Warehouse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("ItemWarehouse", b =>
                {
                    b.HasOne("WarehouseManagementSystem.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarehouseManagementSystem.Warehouse", null)
                        .WithMany()
                        .HasForeignKey("WarehousesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WarehouseManagementSystem.LineItem", b =>
                {
                    b.HasOne("WarehouseManagementSystem.Item", "Item")
                        .WithMany("LineItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarehouseManagementSystem.Order", "Order")
                        .WithMany("LineItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("WarehouseManagementSystem.Order", b =>
                {
                    b.HasOne("WarehouseManagementSystem.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarehouseManagementSystem.ShippingProvider", "ShippingProvider")
                        .WithMany("Orders")
                        .HasForeignKey("ShippingProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("ShippingProvider");
                });

            modelBuilder.Entity("WarehouseManagementSystem.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WarehouseManagementSystem.Item", b =>
                {
                    b.Navigation("LineItems");
                });

            modelBuilder.Entity("WarehouseManagementSystem.Order", b =>
                {
                    b.Navigation("LineItems");
                });

            modelBuilder.Entity("WarehouseManagementSystem.ShippingProvider", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
