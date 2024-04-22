using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Data.Migrations
{
    public partial class AddClassesListToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassesList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassTeacher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassCaptain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassFirst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassSecond = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassThird = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalStudent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassesList", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassesList");
        }
    }
}
