using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiKartt.Migrations
{
    public partial class cxaz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopingCartItem_personaldata_ShopingCartid",
                table: "ShopingCartItem");

            migrationBuilder.DropIndex(
                name: "IX_ShopingCartItem_ShopingCartid",
                table: "ShopingCartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_personaldata",
                table: "personaldata");

            migrationBuilder.DropColumn(
                name: "ShopingCartid",
                table: "ShopingCartItem");

            migrationBuilder.DropColumn(
                name: "id",
                table: "personaldata");

            migrationBuilder.AddColumn<int>(
                name: "PersonalInfoId",
                table: "ShopingCartItem",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                table: "personaldata",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "emailaddress",
                table: "personaldata",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "country",
                table: "personaldata",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "PersonalInfoId",
                table: "personaldata",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personaldata",
                table: "personaldata",
                column: "PersonalInfoId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopingCartItem_personaldata_PersonalInfoId",
                table: "ShopingCartItem");

            migrationBuilder.DropIndex(
                name: "IX_ShopingCartItem_PersonalInfoId",
                table: "ShopingCartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_personaldata",
                table: "personaldata");

            migrationBuilder.DropColumn(
                name: "PersonalInfoId",
                table: "ShopingCartItem");

            migrationBuilder.DropColumn(
                name: "PersonalInfoId",
                table: "personaldata");

            migrationBuilder.AddColumn<int>(
                name: "ShopingCartid",
                table: "ShopingCartItem",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                table: "personaldata",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "emailaddress",
                table: "personaldata",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "country",
                table: "personaldata",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "personaldata",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personaldata",
                table: "personaldata",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_ShopingCartItem_ShopingCartid",
                table: "ShopingCartItem",
                column: "ShopingCartid");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopingCartItem_personaldata_ShopingCartid",
                table: "ShopingCartItem",
                column: "ShopingCartid",
                principalTable: "personaldata",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
