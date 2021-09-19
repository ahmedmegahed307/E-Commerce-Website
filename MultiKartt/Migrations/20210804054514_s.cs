using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiKartt.Migrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopingCartItem_personaldata_PersonalInfoId",
                table: "ShopingCartItem");

            migrationBuilder.DropTable(
                name: "personaldata");

            migrationBuilder.DropIndex(
                name: "IX_ShopingCartItem_PersonalInfoId",
                table: "ShopingCartItem");

            migrationBuilder.DropColumn(
                name: "PersonalInfoId",
                table: "ShopingCartItem");

            migrationBuilder.AddColumn<int>(
                name: "ShopingCartid",
                table: "ShopingCartItem",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "personaldata1",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<decimal>(nullable: false),
                    firstname = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    phonenumber = table.Column<double>(nullable: false),
                    country = table.Column<string>(nullable: true),
                    emailaddress = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    postalcode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personaldata1", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopingCartItem_ShopingCartid",
                table: "ShopingCartItem",
                column: "ShopingCartid");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopingCartItem_personaldata1_ShopingCartid",
                table: "ShopingCartItem",
                column: "ShopingCartid",
                principalTable: "personaldata1",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopingCartItem_personaldata1_ShopingCartid",
                table: "ShopingCartItem");

            migrationBuilder.DropTable(
                name: "personaldata1");

            migrationBuilder.DropIndex(
                name: "IX_ShopingCartItem_ShopingCartid",
                table: "ShopingCartItem");

            migrationBuilder.DropColumn(
                name: "ShopingCartid",
                table: "ShopingCartItem");

            migrationBuilder.AddColumn<int>(
                name: "PersonalInfoId",
                table: "ShopingCartItem",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "personaldata",
                columns: table => new
                {
                    PersonalInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailaddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phonenumber = table.Column<double>(type: "float", nullable: false),
                    postalcode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personaldata", x => x.PersonalInfoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopingCartItem_PersonalInfoId",
                table: "ShopingCartItem",
                column: "PersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopingCartItem_personaldata_PersonalInfoId",
                table: "ShopingCartItem",
                column: "PersonalInfoId",
                principalTable: "personaldata",
                principalColumn: "PersonalInfoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
