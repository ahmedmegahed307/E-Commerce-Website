using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiKartt.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbCategory",
                columns: table => new
                {
                    TbCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCategory", x => x.TbCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "TbSlider",
                columns: table => new
                {
                    TbSliderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    ImageName = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbSlider", x => x.TbSliderId);
                });

            migrationBuilder.CreateTable(
                name: "TbProduct",
                columns: table => new
                {
                    TbProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: false),
                    SalesPrice = table.Column<decimal>(nullable: false),
                    PurchasePrice = table.Column<decimal>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbProduct", x => x.TbProductId);
                    table.ForeignKey(
                        name: "FK_TbProduct_TbCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TbCategory",
                        principalColumn: "TbCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbProductDiscount",
                columns: table => new
                {
                    TbProductDiscountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    DiscountPercent = table.Column<decimal>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbProductDiscount", x => x.TbProductDiscountId);
                    table.ForeignKey(
                        name: "FK_TbProductDiscount_TbProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TbProduct",
                        principalColumn: "TbProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbProductImages",
                columns: table => new
                {
                    TbProductImagesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbProductImages", x => x.TbProductImagesId);
                    table.ForeignKey(
                        name: "FK_TbProductImages_TbProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TbProduct",
                        principalColumn: "TbProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbProduct_CategoryId",
                table: "TbProduct",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TbProductDiscount_ProductId",
                table: "TbProductDiscount",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TbProductImages_ProductId",
                table: "TbProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbProductDiscount");

            migrationBuilder.DropTable(
                name: "TbProductImages");

            migrationBuilder.DropTable(
                name: "TbSlider");

            migrationBuilder.DropTable(
                name: "TbProduct");

            migrationBuilder.DropTable(
                name: "TbCategory");
        }
    }
}
