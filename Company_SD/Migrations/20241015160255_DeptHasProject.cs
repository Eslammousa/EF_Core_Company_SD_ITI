using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company_SD.Migrations
{
    /// <inheritdoc />
    public partial class DeptHasProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    PNum = table.Column<int>(type: "int", nullable: false),
                    PName = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true),
                    City = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true),
                    Loc = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true),
                    DNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.PNum);
                    table.ForeignKey(
                        name: "FK_Projects_Departments_DNum",
                        column: x => x.DNum,
                        principalTable: "Departments",
                        principalColumn: "DNum",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DNum",
                table: "Projects",
                column: "DNum");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
