using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlogApp.DataAccess.Migrations
{
    public partial class AddedFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Title2 = table.Column<string>(type: "text", nullable: true),
                    Title2Content = table.Column<string>(type: "text", nullable: true),
                    Title3 = table.Column<string>(type: "text", nullable: true),
                    Title3Content = table.Column<string>(type: "text", nullable: true),
                    Title4 = table.Column<string>(type: "text", nullable: true),
                    Title4Content = table.Column<string>(type: "text", nullable: true),
                    One = table.Column<string>(type: "text", nullable: true),
                    Two = table.Column<string>(type: "text", nullable: true),
                    Three = table.Column<string>(type: "text", nullable: true),
                    Four = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");
        }
    }
}
