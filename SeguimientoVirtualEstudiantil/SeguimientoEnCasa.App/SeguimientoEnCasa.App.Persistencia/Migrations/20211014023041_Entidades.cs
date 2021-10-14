using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeguimientoEnCasa.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parentesco = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Acudiente_EstudianteId = table.Column<int>(type: "int", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Latitud = table.Column<float>(type: "real", nullable: true),
                    Longitud = table.Column<float>(type: "real", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FechaDeNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Asignatura = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Curso = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Registro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstudianteId = table.Column<int>(type: "int", nullable: true),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    HorasLaborales = table.Column<int>(type: "int", nullable: true),
                    Tutor_EstudianteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_Acudiente_EstudianteId",
                        column: x => x.Acudiente_EstudianteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_Tutor_EstudianteId",
                        column: x => x.Tutor_EstudianteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SugerenciaEstudios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SugerenciaEstudios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Historicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SugerenciaEstudioId = table.Column<int>(type: "int", nullable: true),
                    EstudianteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_Personas_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Historicos_SugerenciaEstudios_SugerenciaEstudioId",
                        column: x => x.SugerenciaEstudioId,
                        principalTable: "SugerenciaEstudios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_EstudianteId",
                table: "Historicos",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_SugerenciaEstudioId",
                table: "Historicos",
                column: "SugerenciaEstudioId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Acudiente_EstudianteId",
                table: "Personas",
                column: "Acudiente_EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EstudianteId",
                table: "Personas",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Tutor_EstudianteId",
                table: "Personas",
                column: "Tutor_EstudianteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historicos");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "SugerenciaEstudios");
        }
    }
}
