using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiKartt.Migrations
{
    public partial class banners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbBanner",
                columns: table => new
                {
                    TbBannerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BannerTitle = table.Column<string>(nullable: false),
                    ImageName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbBanner", x => x.TbBannerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbBanner");
        }
    }
}
