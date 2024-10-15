using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company_SD.Migrations
{
    /// <inheritdoc />
    public partial class EmpWorkInProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    SSN = table.Column<int>(type: "int", nullable: false),
                    PNumber = table.Column<int>(type: "int", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: true),
                    ProjectsPNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => new { x.SSN, x.PNumber });
                    table.ForeignKey(
                        name: "FK_Works_Employees_SSN",
                        column: x => x.SSN,
                        principalTable: "Employees",
                        principalColumn: "SSN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Works_Projects_ProjectsPNum",
                        column: x => x.ProjectsPNum,
                        principalTable: "Projects",
                        principalColumn: "PNum",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Works_ProjectsPNum",
                table: "Works",
                column: "ProjectsPNum");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Works");
        }
    }
}
