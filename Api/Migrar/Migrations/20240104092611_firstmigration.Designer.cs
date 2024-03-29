﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Migrar.Data;

#nullable disable

namespace Migrar.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240104092611_firstmigration")]
    partial class firstmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Migrar.Model.Destino", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_destino");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("foto_destino");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("local_destino");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("valor_destino");

                    b.HasKey("Id");

                    b.ToTable("destinos");
                });
#pragma warning restore 612, 618
        }
    }
}
