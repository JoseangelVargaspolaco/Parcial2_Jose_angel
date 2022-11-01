using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial2_Jose_angel.Migrations
{
    public partial class Vitaminas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Existencia",
                table: "Vitaminas",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "VerdurasDetalles",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cantidad",
                table: "VerdurasDetalles",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<string>(
                name: "Observaciones",
                table: "Verduras",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Verduras",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 1,
                column: "Existencia",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 2,
                column: "Existencia",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 3,
                column: "Existencia",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 4,
                column: "Existencia",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 5,
                column: "Existencia",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 6,
                column: "Existencia",
                value: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Existencia",
                table: "Vitaminas",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<double>(
                name: "Total",
                table: "VerdurasDetalles",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<double>(
                name: "Cantidad",
                table: "VerdurasDetalles",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Observaciones",
                table: "Verduras",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Verduras",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 1,
                column: "Existencia",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 2,
                column: "Existencia",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 3,
                column: "Existencia",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 4,
                column: "Existencia",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 5,
                column: "Existencia",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 6,
                column: "Existencia",
                value: 0.0);
        }
    }
}
