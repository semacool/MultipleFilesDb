using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Datas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data1 = table.Column<string>(type: "TEXT", nullable: false),
                    Data2 = table.Column<string>(type: "TEXT", nullable: false),
                    Data3 = table.Column<string>(type: "TEXT", nullable: false),
                    Data4 = table.Column<string>(type: "TEXT", nullable: false),
                    Data5 = table.Column<string>(type: "TEXT", nullable: false),
                    Data6 = table.Column<string>(type: "TEXT", nullable: false),
                    Data7 = table.Column<string>(type: "TEXT", nullable: false),
                    Data8 = table.Column<string>(type: "TEXT", nullable: false),
                    Data9 = table.Column<string>(type: "TEXT", nullable: false),
                    Data10 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datas");
        }
    }
}
