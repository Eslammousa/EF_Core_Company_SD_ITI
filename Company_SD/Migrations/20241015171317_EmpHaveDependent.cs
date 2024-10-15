using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company_SD.Migrations
{
    /// <inheritdoc />
    public partial class EmpHaveDependent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dependent",
                columns: table => new
                {
                    DName = table.Column<int>(type: "int", nullable: false),
                    SSN = table.Column<int>(type: "int", nullable: false),
                    BDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependent", x => new { x.DName, x.SSN });
                    table.ForeignKey(
                        name: "FK_Dependent_Employees_SSN",
                        column: x => x.SSN,
                        principalTable: "Employees",
                        principalColumn: "SSN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dependent_SSN",
                table: "Dependent",
                column: "SSN");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dependent");
        }
    }
}
