﻿// <auto-generated />
using System;
using EmployeesCh12.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeesCh12.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20241112143114_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeesCh12.Models.Benefits", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("Category")
                        .HasColumnType("int");

                    b.Property<bool>("Dental")
                        .HasColumnType("bit");

                    b.Property<bool>("Health")
                        .HasColumnType("bit");

                    b.Property<decimal>("LifeIns")
                        .HasColumnType("decimal(18,4)");

                    b.Property<bool>("Vision")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Benefits");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Category = 0,
                            Dental = false,
                            Health = false,
                            LifeIns = 0m,
                            Vision = false
                        },
                        new
                        {
                            ID = 2,
                            Category = 2,
                            Dental = true,
                            Health = true,
                            LifeIns = 100000m,
                            Vision = true
                        },
                        new
                        {
                            ID = 3,
                            Category = 1,
                            Dental = true,
                            Health = true,
                            LifeIns = 100000m,
                            Vision = true
                        });
                });

            modelBuilder.Entity("EmployeesCh12.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Accounting"
                        },
                        new
                        {
                            ID = 2,
                            Name = "IT"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Marketing"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Sales"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Management"
                        },
                        new
                        {
                            ID = 6,
                            Name = "Plant"
                        },
                        new
                        {
                            ID = 7,
                            Name = "Shipping"
                        },
                        new
                        {
                            ID = 8,
                            Name = "Warehouse"
                        });
                });

            modelBuilder.Entity("EmployeesCh12.Models.DepartmentLocation", b =>
                {
                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.HasKey("DepartmentID", "LocationID");

                    b.HasIndex("LocationID");

                    b.ToTable("DepartmentLocations");

                    b.HasData(
                        new
                        {
                            DepartmentID = 1,
                            LocationID = 1
                        },
                        new
                        {
                            DepartmentID = 2,
                            LocationID = 1
                        },
                        new
                        {
                            DepartmentID = 3,
                            LocationID = 1
                        },
                        new
                        {
                            DepartmentID = 4,
                            LocationID = 1
                        },
                        new
                        {
                            DepartmentID = 5,
                            LocationID = 1
                        },
                        new
                        {
                            DepartmentID = 8,
                            LocationID = 1
                        },
                        new
                        {
                            DepartmentID = 6,
                            LocationID = 4
                        },
                        new
                        {
                            DepartmentID = 7,
                            LocationID = 5
                        },
                        new
                        {
                            DepartmentID = 7,
                            LocationID = 2
                        });
                });

            modelBuilder.Entity("EmployeesCh12.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<int?>("BenefitsID")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("BenefitsID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            ID = 1012,
                            BenefitsID = 1,
                            DepartmentID = 1,
                            FirstName = "Freddie",
                            HireDate = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Flintstone"
                        },
                        new
                        {
                            ID = 1067,
                            BenefitsID = 1,
                            DepartmentID = 2,
                            FirstName = "Wilma",
                            HireDate = new DateTime(2005, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Flintstone"
                        },
                        new
                        {
                            ID = 1098,
                            BenefitsID = 2,
                            DepartmentID = 3,
                            FirstName = "Barney",
                            HireDate = new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Rubble"
                        },
                        new
                        {
                            ID = 100,
                            BenefitsID = 1,
                            DepartmentID = 1,
                            FirstName = "Judy",
                            HireDate = new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Jetson"
                        },
                        new
                        {
                            ID = 101,
                            BenefitsID = 2,
                            DepartmentID = 1,
                            FirstName = "Daphne",
                            HireDate = new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Blake"
                        });
                });

            modelBuilder.Entity("EmployeesCh12.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "2200 Park Ave",
                            Type = 1,
                            Zipcode = "49696"
                        },
                        new
                        {
                            ID = 2,
                            Address = "2200 Park Ave",
                            Type = 4,
                            Zipcode = "49696"
                        },
                        new
                        {
                            ID = 3,
                            Address = "2200 Park Ave",
                            Type = 0,
                            Zipcode = "49696"
                        },
                        new
                        {
                            ID = 4,
                            Address = "2100 Park Ave",
                            Type = 3,
                            Zipcode = "49696"
                        },
                        new
                        {
                            ID = 5,
                            Address = "6 Hickory Blvd.",
                            Type = 3,
                            Zipcode = "49696"
                        },
                        new
                        {
                            ID = 6,
                            Address = "6 Hickory Blvd.",
                            Type = 2,
                            Zipcode = "49696"
                        });
                });

            modelBuilder.Entity("EmployeesCh12.Models.DepartmentLocation", b =>
                {
                    b.HasOne("EmployeesCh12.Models.Department", "Department")
                        .WithMany("DepartmentLocations")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeesCh12.Models.Location", "Location")
                        .WithMany("DepartmentLocations")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("EmployeesCh12.Models.Employee", b =>
                {
                    b.HasOne("EmployeesCh12.Models.Benefits", null)
                        .WithMany("Employees")
                        .HasForeignKey("BenefitsID");

                    b.HasOne("EmployeesCh12.Models.Department", null)
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID");
                });

            modelBuilder.Entity("EmployeesCh12.Models.Benefits", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("EmployeesCh12.Models.Department", b =>
                {
                    b.Navigation("DepartmentLocations");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("EmployeesCh12.Models.Location", b =>
                {
                    b.Navigation("DepartmentLocations");
                });
#pragma warning restore 612, 618
        }
    }
}
