﻿// <auto-generated />
using System;
using Asp.NetCore_api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Asp.NetCore_api.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230414155849_mm")]
    partial class mm
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Asp.NetCore_api.Model.Entities.Order", b =>
                {
                    b.Property<long>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("OrderID"));

                    b.Property<int>("OrderAmount")
                        .HasColumnType("int");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<long>("WarehouseID")
                        .HasColumnType("bigint");

                    b.HasKey("OrderID");

                    b.HasIndex("ProductID")
                        .IsUnique();

                    b.HasIndex("WarehouseID")
                        .IsUnique();

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Asp.NetCore_api.Model.Entities.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductID"));

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductCode")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Asp.NetCore_api.Model.Entities.Warehouse", b =>
                {
                    b.Property<long>("WarehouseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("WarehouseID"));

                    b.Property<string>("WarehouseAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WarehouseID");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("Asp.NetCore_api.Model.Entities.Order", b =>
                {
                    b.HasOne("Asp.NetCore_api.Model.Entities.Product", null)
                        .WithOne("Order")
                        .HasForeignKey("Asp.NetCore_api.Model.Entities.Order", "ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Asp.NetCore_api.Model.Entities.Warehouse", null)
                        .WithOne("Order")
                        .HasForeignKey("Asp.NetCore_api.Model.Entities.Order", "WarehouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Asp.NetCore_api.Model.Entities.Product", b =>
                {
                    b.Navigation("Order")
                        .IsRequired();
                });

            modelBuilder.Entity("Asp.NetCore_api.Model.Entities.Warehouse", b =>
                {
                    b.Navigation("Order")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
