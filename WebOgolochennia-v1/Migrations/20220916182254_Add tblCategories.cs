using Microsoft.EntityFrameworkCore.Migrations;

namespace WebOgolochennia_v1.Migrations
{
    public partial class AddtblCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Advertisement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Tel1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicInNewspaper = table.Column<bool>(type: "bit", nullable: false),
                    InicialData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Highlighted = table.Column<bool>(type: "bit", nullable: false),
                    Frame = table.Column<bool>(type: "bit", nullable: false),
                    Background = table.Column<bool>(type: "bit", nullable: false),
                    PublicInSite = table.Column<bool>(type: "bit", nullable: false),
                    InitialWeek = table.Column<int>(type: "int", nullable: false),
                    Up = table.Column<bool>(type: "bit", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategories", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCategories");
        }
    }
}
