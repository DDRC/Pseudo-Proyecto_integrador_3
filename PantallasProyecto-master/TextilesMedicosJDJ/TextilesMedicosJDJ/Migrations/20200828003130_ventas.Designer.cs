﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TextilesMedicosJDJ.Data;

namespace TextilesMedicosJDJ.Migrations
{
    [DbContext(typeof(ventasContext))]
    [Migration("20200828003130_ventas")]
    partial class ventas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TextilesMedicosJDJ.Models.ventas", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("ventas");
                });
#pragma warning restore 612, 618
        }
    }
}
