﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PSGC.Api.Data;

#nullable disable

namespace PSGC.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250130012100_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("PSGC.Api.Entities.GeoData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BarangayCode")
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.Property<string>("GeographicLevel")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("MunicipalCode")
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("OldName")
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("PSGCCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvinceCode")
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.Property<string>("RegionCode")
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("GeoDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
