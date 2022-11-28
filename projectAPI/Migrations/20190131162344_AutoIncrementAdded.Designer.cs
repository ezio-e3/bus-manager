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
    [Migration("20190131162344_AutoIncrementAdded")]
    partial class AutoIncrementAdded
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

                    b.Property<string>("DriverName")
                        .IsRequired();

                    b.Property<int>("Maintenance");

                    b.Property<DateTime>("RegistrationYear");

                    b.HasKey("Id");

                    b.ToTable("Bus");
                });
#pragma warning restore 612, 618
        }
    }
}
