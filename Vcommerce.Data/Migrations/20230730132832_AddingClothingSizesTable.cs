using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vcommerce.Data.Migrations
{
    public partial class AddingClothingSizesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Clothes");

            migrationBuilder.CreateTable(
                name: "ClothingSizes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    SizeQuantity = table.Column<int>(type: "int", nullable: false),
                    ClothingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothingSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClothingSizes_Clothes_ClothingId",
                        column: x => x.ClothingId,
                        principalTable: "Clothes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClothingSizes_ClothingId",
                table: "ClothingSizes",
                column: "ClothingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClothingSizes");

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Clothes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
