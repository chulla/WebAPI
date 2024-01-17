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
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "CorreoElectronico", "FechaRegistro", "Nombre" },
                values: new object[,]
                {
                    { 1, "usuario1@example.com", new DateTime(2024, 1, 17, 13, 10, 26, 586, DateTimeKind.Local).AddTicks(6174), "Usuario1" },
                    { 2, "usuario2@example.com", new DateTime(2024, 1, 17, 13, 10, 26, 586, DateTimeKind.Local).AddTicks(6235), "Usuario2" },
                    { 3, "usuario3@example.com", new DateTime(2024, 1, 17, 13, 10, 26, 586, DateTimeKind.Local).AddTicks(6237), "Usuario3" },
                    { 4, "usuario4@example.com", new DateTime(2024, 1, 17, 13, 10, 26, 586, DateTimeKind.Local).AddTicks(6239), "Usuario4" },
                    { 5, "usuario5@example.com", new DateTime(2024, 1, 17, 13, 10, 26, 586, DateTimeKind.Local).AddTicks(6240), "Usuario5" },
                    { 6, "usuario6@example.com", new DateTime(2024, 1, 17, 13, 10, 26, 586, DateTimeKind.Local).AddTicks(6242), "Usuario6" },
                    { 7, "usuario7@example.com", new DateTime(2024, 1, 17, 13, 10, 26, 586, DateTimeKind.Local).AddTicks(6243), "Usuario7" },
                    { 8, "usuario8@example.com", new DateTime(2024, 1, 17, 13, 10, 26, 586, DateTimeKind.Local).AddTicks(6245), "Usuario8" },
                    { 9, "usuario9@example.com", new DateTime(2024, 1, 17, 13, 10, 26, 586, DateTimeKind.Local).AddTicks(6247), "Usuario9" },
                    { 10, "usuario10@example.com", new DateTime(2024, 1, 17, 13, 10, 26, 586, DateTimeKind.Local).AddTicks(6248), "Usuario10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
