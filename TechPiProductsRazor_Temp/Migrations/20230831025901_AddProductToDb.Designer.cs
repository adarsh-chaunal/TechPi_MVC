﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechPiProductsRazor_Temp.Data;

#nullable disable

namespace TechPiProductsRazor_Temp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230831025901_AddProductToDb")]
    partial class AddProductToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechPiProductsRazor_Temp.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Created = new DateTime(2023, 8, 27, 8, 30, 39, 999, DateTimeKind.Unspecified),
                            DisplayOrder = 1,
                            InStock = true,
                            Price = 100.00m,
                            ProductCode = "12345",
                            ProductDescription = "First Product",
                            ProductName = "Product1"
                        },
                        new
                        {
                            Id = 2L,
                            Created = new DateTime(2023, 8, 28, 10, 41, 3, 101, DateTimeKind.Unspecified),
                            DisplayOrder = 2,
                            InStock = false,
                            Price = 200.00m,
                            ProductCode = "12346",
                            ProductDescription = "Second Product",
                            ProductName = "Product2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
