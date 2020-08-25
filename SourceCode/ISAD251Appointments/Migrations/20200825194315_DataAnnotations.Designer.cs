﻿// <auto-generated />
using System;
using ISAD251Appointments.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ISAD251Appointments.Migrations
{
    [DbContext(typeof(MvcAppointmentContext))]
    [Migration("20200825194315_DataAnnotations")]
    partial class DataAnnotations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ISAD251Appointments.Models.Appointments", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppointmentDescription")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<bool>("AppointmentIsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("AppointmentName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AppointmentNote")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("AppointmentTarget")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("AppointmentTime")
                        .HasColumnType("datetime2");

                    b.HasKey("AppointmentID");

                    b.ToTable("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
