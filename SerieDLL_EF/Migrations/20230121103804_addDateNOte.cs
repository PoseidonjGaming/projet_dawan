using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SerieDLLEF.Migrations
{
    /// <inheritdoc />
    public partial class addDateNOte : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "date de parution",
                table: "note",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date de parution",
                table: "note");
        }
    }
}
