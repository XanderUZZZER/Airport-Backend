﻿// <auto-generated />
using System;
using Airport.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Airport.DB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210128125035_fligthPropsAltered")]
    partial class fligthPropsAltered
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Airport.DB.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Arrivals")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Departures")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}