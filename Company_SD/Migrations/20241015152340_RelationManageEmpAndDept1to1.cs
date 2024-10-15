using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company_SD.Migrations
{
    /// <inheritdoc />
    public partial class RelationManageEmpAndDept1to1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DNum = table.Column<int>(type: "int", nullable: false),
                    DName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    hireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MrgSSN = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DNum);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    SSN = table.Column<int>(type: "int", nullable: false),
                    FName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    LName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    DBDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.SSN);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DNo",
                        column: x => x.DNo,
                        principalTable: "Departments",
                        principalColumn: "DNum",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    DNum = table.Column<int>(type: "int", nullable: false),
                    Loc = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => new { x.DNum, x.Loc });
                    table.ForeignKey(
                        name: "FK_Locations_Departments_DNum",
                        column: x => x.DNum,
                        principalTable: "Departments",
                        principalColumn: "DNum",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MrgSSN",
                table: "Departments",
                column: "MrgSSN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DNo",
                table: "Employees",
                column: "DNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_MrgSSN",
                table: "Departments",
                column: "MrgSSN",
                principalTable: "Employees",
                principalColumn: "SSN",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_MrgSSN",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
