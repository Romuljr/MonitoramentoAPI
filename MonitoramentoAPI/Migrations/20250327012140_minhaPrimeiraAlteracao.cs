using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonitoramentoAPI.Infra.Migrations
{
    /// <inheritdoc />
    public partial class minhaPrimeiraAlteracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Angulo",
                table: "Rastreamento");

            migrationBuilder.DropColumn(
                name: "IdentResultado",
                table: "Rastreamento");

            migrationBuilder.DropColumn(
                name: "Torque",
                table: "Rastreamento");

            migrationBuilder.AddColumn<bool>(
                name: "CurvasOk",
                table: "Rastreamento",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAnalise",
                table: "Rastreamento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurvasOk",
                table: "Rastreamento");

            migrationBuilder.DropColumn(
                name: "DataAnalise",
                table: "Rastreamento");

            migrationBuilder.AddColumn<double>(
                name: "Angulo",
                table: "Rastreamento",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "IdentResultado",
                table: "Rastreamento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Torque",
                table: "Rastreamento",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
