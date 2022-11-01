using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial2_Jose_angel.Migrations
{
    public partial class Verduras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Vitaminas");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Vitaminas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Existencia",
                table: "Vitaminas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "VerdurasDetalles",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Verduras",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Observaciones",
                table: "Verduras",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 1,
                column: "Descripcion",
                value: "Vitamina C");

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 2,
                column: "Descripcion",
                value: "Betaína D");

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 3,
                column: "Descripcion",
                value: "Vitamina K");

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 4,
                column: "Descripcion",
                value: "Vitamina B12");

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 5,
                column: "Descripcion",
                value: "Vitamina B6");

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 6,
                column: "Descripcion",
                value: "Acido fólico(B9)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Vitaminas");

            migrationBuilder.DropColumn(
                name: "Existencia",
                table: "Vitaminas");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "VerdurasDetalles");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Verduras");

            migrationBuilder.DropColumn(
                name: "Observaciones",
                table: "Verduras");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Vitaminas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 1,
                column: "Nombre",
                value: "Vitamina C");

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 2,
                column: "Nombre",
                value: "Betaína D");

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 3,
                column: "Nombre",
                value: "Vitamina K");

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 4,
                column: "Nombre",
                value: "Vitamina B12");

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 5,
                column: "Nombre",
                value: "Vitamina B6");

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 6,
                column: "Nombre",
                value: "Acido fólico(B9)");
        }
    }
}
