using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vcommerce.Data.Migrations
{
    public partial class AddingReviewsAndBlogsAndComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostMainPictureUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    PostMidSectionLeftImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    PostMidSectionRightImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    Context = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClothingReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserPostedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RelatedClothingIdGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothingReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClothingReviews_AspNetUsers_UserPostedId",
                        column: x => x.UserPostedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClothingReviews_Clothes_RelatedClothingIdGuid",
                        column: x => x.RelatedClothingIdGuid,
                        principalTable: "Clothes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AvatarImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RelatedPostGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentCommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostComments_BlogPosts_RelatedPostGuid",
                        column: x => x.RelatedPostGuid,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostComments_PostComments_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "PostComments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClothingReviews_RelatedClothingIdGuid",
                table: "ClothingReviews",
                column: "RelatedClothingIdGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingReviews_UserPostedId",
                table: "ClothingReviews",
                column: "UserPostedId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_ParentCommentId",
                table: "PostComments",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_RelatedPostGuid",
                table: "PostComments",
                column: "RelatedPostGuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClothingReviews");

            migrationBuilder.DropTable(
                name: "PostComments");

            migrationBuilder.DropTable(
                name: "BlogPosts");
        }
    }
}
