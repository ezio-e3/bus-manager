﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projectAPI.Models;

namespace projectAPI.Migrations
{
    [DbContext(typeof(VipContext))]
    [Migration("20190315124744_MaintenanceChanges")]
    partial class MaintenanceChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("projectAPI.Models.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusNumber")
                        .IsRequired();

                    b.Property<string>("BusType");

                    b.Property<int>("Capacity");

                    b.Property<int?>("MaintenanceId");

                    b.Property<DateTime>("RegistrationYear");

                    b.HasKey("Id");

                    b.HasIndex("MaintenanceId");

                    b.ToTable("Bus");
                });

            modelBuilder.Entity("projectAPI.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusId");

                    b.Property<DateTime>("Dob");

                    b.Property<string>("FirstMidName");

                    b.Property<string>("LastName");

                    b.Property<string>("License");

                    b.Property<int>("Performance");

                    b.Property<int>("Phone");

                    b.Property<string>("Picture");

                    b.Property<int>("Salary");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("projectAPI.Models.Maintenance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaintenanceCost");

                    b.Property<DateTime>("MaintenanceDate");

                    b.Property<string>("MaintenanceType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Maintenance");
                });

            modelBuilder.Entity("projectAPI.Models.Trips", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusId");

                    b.Property<int>("Cost");

                    b.Property<int>("DriverId");

                    b.Property<bool>("IsStandby");

                    b.Property<int>("Passengers");

                    b.Property<string>("Trip");

                    b.Property<DateTime>("TripDate");

                    b.Property<int>("Waybill");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.HasIndex("DriverId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("projectAPI.Models.Bus", b =>
                {
                    b.HasOne("projectAPI.Models.Maintenance", "Maintenance")
                        .WithMany()
                        .HasForeignKey("MaintenanceId");
                });

            modelBuilder.Entity("projectAPI.Models.Driver", b =>
                {
                    b.HasOne("projectAPI.Models.Bus", "Bus")
                        .WithMany()
                        .HasForeignKey("BusId");
                });

            modelBuilder.Entity("projectAPI.Models.Trips", b =>
                {
                    b.HasOne("projectAPI.Models.Bus", "Bus")
                        .WithMany()
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("projectAPI.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
