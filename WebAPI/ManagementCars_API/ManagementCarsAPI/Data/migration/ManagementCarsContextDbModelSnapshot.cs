﻿// <auto-generated />
using System;
using ManagementCarsAPI.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ManagementCarsAPI.Data.migration
{
    [DbContext(typeof(ManagementCarsContextDb))]
    partial class ManagementCarsContextDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ManagementCarsAPI.Models.Entity.Car", b =>
                {
                    b.Property<string>("number")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("generalCost")
                        .HasColumnType("int");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("rentalCost")
                        .HasColumnType("int");

                    b.Property<string>("specialLetters")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("number");

                    b.ToTable("Car", (string)null);
                });

            modelBuilder.Entity("ManagementCarsAPI.Models.Entity.CarAndDigitalTools", b =>
                {
                    b.Property<string>("numberCar")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("idDigitalTools")
                        .HasColumnType("int");

                    b.HasKey("numberCar", "idDigitalTools");

                    b.ToTable("CarAndDigitalTools", (string)null);
                });

            modelBuilder.Entity("ManagementCarsAPI.Models.Entity.Client", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<bool>("VIP")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("bornDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("carNumber")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("id");

                    b.HasIndex("carNumber")
                        .IsUnique()
                        .HasFilter("[carNumber] IS NOT NULL");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("ManagementCarsAPI.Models.Entity.Department", b =>
                {
                    b.Property<string>("name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.HasKey("name");

                    b.ToTable("Department", (string)null);
                });

            modelBuilder.Entity("ManagementCarsAPI.Models.Entity.DigitalTools", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DigitalTools", (string)null);
                });

            modelBuilder.Entity("ManagementCarsAPI.Models.Entity.Worker", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("joinIn")
                        .HasColumnType("datetime2");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Worker", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
