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
    [Migration("20190207110018_ContextUpdate")]
    partial class ContextUpdate
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

                    b.Property<string>("DriverName");

                    b.Property<int>("Maintenance");

                    b.Property<DateTime>("RegistrationYear");

                    b.HasKey("Id");

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

                    b.Property<int>("Salary");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("projectAPI.Models.Trips", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusId");

                    b.Property<int>("Cost");

                    b.Property<int>("Passengers");

                    b.Property<string>("Trip");

                    b.Property<int>("WayBill");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.ToTable("Trips");
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
                        .WithMany("Trips")
                        .HasForeignKey("BusId");
                });
#pragma warning restore 612, 618
        }
    }
}
