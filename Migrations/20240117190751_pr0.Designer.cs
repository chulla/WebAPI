﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPINET8.Database;

#nullable disable

namespace WebAPINET8.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240117190751_pr0")]
    partial class pr0
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPINET8.Models.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpresaId"));

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpresaId");

                    b.ToTable("Empresas");

                    b.HasData(
                        new
                        {
                            EmpresaId = 1,
                            Direccion = "Dirección1",
                            Nombre = "Empresa1"
                        },
                        new
                        {
                            EmpresaId = 2,
                            Direccion = "Dirección2",
                            Nombre = "Empresa2"
                        });
                });

            modelBuilder.Entity("WebAPINET8.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            CorreoElectronico = "usuario1@example.com",
                            EmpresaId = 1,
                            FechaRegistro = new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7922),
                            Nombre = "Usuario1"
                        },
                        new
                        {
                            UsuarioId = 2,
                            CorreoElectronico = "usuario2@example.com",
                            EmpresaId = 1,
                            FechaRegistro = new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7969),
                            Nombre = "Usuario2"
                        },
                        new
                        {
                            UsuarioId = 3,
                            CorreoElectronico = "usuario3@example.com",
                            EmpresaId = 1,
                            FechaRegistro = new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7971),
                            Nombre = "Usuario3"
                        },
                        new
                        {
                            UsuarioId = 4,
                            CorreoElectronico = "usuario4@example.com",
                            EmpresaId = 1,
                            FechaRegistro = new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7973),
                            Nombre = "Usuario4"
                        },
                        new
                        {
                            UsuarioId = 5,
                            CorreoElectronico = "usuario5@example.com",
                            EmpresaId = 1,
                            FechaRegistro = new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7975),
                            Nombre = "Usuario5"
                        },
                        new
                        {
                            UsuarioId = 6,
                            CorreoElectronico = "usuario6@example.com",
                            EmpresaId = 2,
                            FechaRegistro = new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7977),
                            Nombre = "Usuario6"
                        },
                        new
                        {
                            UsuarioId = 7,
                            CorreoElectronico = "usuario7@example.com",
                            EmpresaId = 2,
                            FechaRegistro = new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7979),
                            Nombre = "Usuario7"
                        },
                        new
                        {
                            UsuarioId = 8,
                            CorreoElectronico = "usuario8@example.com",
                            EmpresaId = 2,
                            FechaRegistro = new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7981),
                            Nombre = "Usuario8"
                        },
                        new
                        {
                            UsuarioId = 9,
                            CorreoElectronico = "usuario9@example.com",
                            EmpresaId = 2,
                            FechaRegistro = new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7982),
                            Nombre = "Usuario9"
                        },
                        new
                        {
                            UsuarioId = 10,
                            CorreoElectronico = "usuario10@example.com",
                            EmpresaId = 2,
                            FechaRegistro = new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7984),
                            Nombre = "Usuario10"
                        });
                });

            modelBuilder.Entity("WebAPINET8.Models.Usuario", b =>
                {
                    b.HasOne("WebAPINET8.Models.Empresa", "Empresa")
                        .WithMany("Usuarios")
                        .HasForeignKey("EmpresaId");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("WebAPINET8.Models.Empresa", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
