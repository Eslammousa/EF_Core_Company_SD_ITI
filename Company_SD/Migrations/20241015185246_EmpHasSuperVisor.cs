using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company_SD.Migrations
{
    /// <inheritdoc />
    public partial class EmpHasSuperVisor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SuperId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SuperId",
                table: "Employees",
                column: "SuperId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_SuperId",
                table: "Employees",
                column: "SuperId",
                principalTable: "Employees",
                principalColumn: "SSN",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_SuperId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SuperId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SuperId",
                table: "Employees");
        }
    }
}
