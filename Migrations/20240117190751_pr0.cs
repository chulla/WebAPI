using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPINET8.Migrations
{
    /// <inheritdoc />
    public partial class pr0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.EmpresaId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmpresaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuarios_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "EmpresaId");
                });

            migrationBuilder.InsertData(
                table: "Empresas",
                columns: new[] { "EmpresaId", "Direccion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Dirección1", "Empresa1" },
                    { 2, "Dirección2", "Empresa2" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "CorreoElectronico", "EmpresaId", "FechaRegistro", "Nombre" },
                values: new object[,]
                {
                    { 1, "usuario1@example.com", 1, new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7922), "Usuario1" },
                    { 2, "usuario2@example.com", 1, new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7969), "Usuario2" },
                    { 3, "usuario3@example.com", 1, new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7971), "Usuario3" },
                    { 4, "usuario4@example.com", 1, new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7973), "Usuario4" },
                    { 5, "usuario5@example.com", 1, new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7975), "Usuario5" },
                    { 6, "usuario6@example.com", 2, new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7977), "Usuario6" },
                    { 7, "usuario7@example.com", 2, new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7979), "Usuario7" },
                    { 8, "usuario8@example.com", 2, new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7981), "Usuario8" },
                    { 9, "usuario9@example.com", 2, new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7982), "Usuario9" },
                    { 10, "usuario10@example.com", 2, new DateTime(2024, 1, 17, 20, 7, 50, 374, DateTimeKind.Local).AddTicks(7984), "Usuario10" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EmpresaId",
                table: "Usuarios",
                column: "EmpresaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
