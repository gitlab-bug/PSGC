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
    [Migration("20250203081316_Add-LocationData")]
    partial class AddLocationData
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

            modelBuilder.Entity("PSGC.Api.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BarangayCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CityClass")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorrespondenceCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("GeographicLevel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IncomeClassification")
                        .HasColumnType("TEXT");

                    b.Property<string>("MunicipalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OldNames")
                        .HasColumnType("TEXT");

                    b.Property<string>("PSGCCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Population")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvincialCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RegionCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("psgc");
                });
#pragma warning restore 612, 618
        }
    }
}
