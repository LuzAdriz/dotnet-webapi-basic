using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyVaccine.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddingAuditFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependents",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Dependents",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Dependents");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Dependents");
        }
    }
}
