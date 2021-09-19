using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiKartt.Migrations
{
    public partial class slug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "TbCategory",
                nullable: true);

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "TbCategory");
        }
    }
}
