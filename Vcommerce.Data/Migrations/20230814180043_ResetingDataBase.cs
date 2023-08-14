using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vcommerce.Data.Migrations
{
    public partial class ResetingDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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

            migrationBuilder.CreateTable(
                name: "Clothes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOnSale = table.Column<bool>(type: "bit", nullable: false),
                    SalePercentage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    NumberOfSales = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clothes_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClothesImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    ClothingGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothesImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClothesImages_Clothes_ClothingGuid",
                        column: x => x.ClothingGuid,
                        principalTable: "Clothes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0a64a7d4-7cc9-441e-b6d0-55d295f186f4"), "Vans" },
                    { new Guid("7dee85d1-8681-40d4-93ed-b4702afade72"), "Zara" },
                    { new Guid("8bdc7349-8182-4df5-9fd0-3a4770f3d1fc"), "Levi's" },
                    { new Guid("8d5121b9-097d-432c-b49a-ad582a3a71d2"), "Calvin Klein" },
                    { new Guid("a9b80144-68b2-4eb3-8c06-b98ed0c5b672"), "Ralph Lauren" },
                    { new Guid("af65433f-562e-4233-84fa-feac5b99c142"), "Reebok" },
                    { new Guid("b2d1ef3e-b42b-4ccb-a88e-51184e7d7da2"), "Converse" },
                    { new Guid("b89987d5-80b1-4b0e-afb5-48db1ebf76e2"), "H&M" },
                    { new Guid("bda763c3-2e5b-4db9-9959-36f3a03daa8e"), "New Balance" },
                    { new Guid("c19542eb-7c8e-48e9-98a5-e7b5d5df43b9"), "GAP" },
                    { new Guid("c7b6a459-6ce9-4f6f-ac0f-f92d61f17a1b"), "Adidas" },
                    { new Guid("d6a153bf-fb89-45be-8e1c-e33adc7766ff"), "Nike" },
                    { new Guid("e9089772-5892-4f5b-8e3d-82ef55d1e4a3"), "Puma" },
                    { new Guid("f4eedcda-6b05-434e-b9f9-22f5a7df981e"), "Under Armour" },
                    { new Guid("fe806f53-78d7-4ac3-bc48-735da7ef15dd"), "Tommy Hilfiger" }
                });

            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "Id", "BrandId", "Category", "Color", "DateCreated", "Description", "Gender", "IsOnSale", "Material", "Name", "NumberOfSales", "Price", "Quantity", "SalePercentage" },
                values: new object[,]
                {
                    { new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), new Guid("d6a153bf-fb89-45be-8e1c-e33adc7766ff"), 4, "Blue", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic striped polo shirt for men.", 1, false, "Cotton", "Men's Striped Polo Shirt", 93, 29.99m, 0, null },
                    { new Guid("0fc675d9-fb8c-486a-9c79-ce88bc5688c0"), new Guid("b89987d5-80b1-4b0e-afb5-48db1ebf76e2"), 8, "Blue", new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable sporty shorts for active kids.", 3, false, "Polyester", "Kids' Sporty Shorts", 30, 24.99m, 0, null },
                    { new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"), new Guid("af65433f-562e-4233-84fa-feac5b99c142"), 12, "Blue", new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "A stylish floral sundress for women.", 2, true, "Rayon", "Women's Floral Sundress", 64, 69.95m, 0, 20m },
                    { new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"), new Guid("8bdc7349-8182-4df5-9fd0-3a4770f3d1fc"), 13, "Pink", new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "A graceful pleated maxi skirt for women.", 2, false, "Chiffon", "Women's Pleated Maxi Skirt", 66, 79.95m, 0, null },
                    { new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), new Guid("d6a153bf-fb89-45be-8e1c-e33adc7766ff"), 1, "Black", new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cool graphic print t-shirt for stylish men.", 1, true, "Cotton", "Men's Graphic Print Tee", 74, 24.95m, 0, 20m },
                    { new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"), new Guid("af65433f-562e-4233-84fa-feac5b99c142"), 11, "White", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "A comfortable and chic blouse for women.", 2, false, "Cotton", "Women's Casual Blouse", 18, 39.99m, 0, null },
                    { new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"), new Guid("f4eedcda-6b05-434e-b9f9-22f5a7df981e"), 8, "Olive", new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Durable cargo shorts for men.", 1, false, "Cotton", "Men's Cargo Shorts", 44, 44.99m, 0, null },
                    { new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"), new Guid("f4eedcda-6b05-434e-b9f9-22f5a7df981e"), 6, "Gray", new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "A comfortable hoodie for men.", 1, true, "Cotton", "Men's Hoodie", 60, 39.99m, 0, 10m },
                    { new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"), new Guid("d6a153bf-fb89-45be-8e1c-e33adc7766ff"), 10, "Gray", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "A sophisticated formal blazer for women.", 2, false, "Polyester", "Women's Formal Blazer", 91, 89.99m, 0, null },
                    { new Guid("3a63ab3e-d7f0-4c42-b3b2-db6f068e3927"), new Guid("c7b6a459-6ce9-4f6f-ac0f-f92d61f17a1b"), 1, "Black", new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A comfortable casual t-shirt for men.", 1, false, "Cotton", "Men's Casual T-Shirt", 9, 29.99m, 0, null },
                    { new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), new Guid("b89987d5-80b1-4b0e-afb5-48db1ebf76e2"), 1, "Green", new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cool graphic print t-shirt for stylish kids.", 3, true, "Cotton", "Kids' Graphic Print Tee", 2, 17.95m, 0, 25m },
                    { new Guid("3db4321b-8228-45a2-b05a-6831e82039ea"), new Guid("8bdc7349-8182-4df5-9fd0-3a4770f3d1fc"), 9, "Gray", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cozy knit sweater for women.", 2, true, "Wool", "Women's Knit Sweater", 77, 54.99m, 0, 25m },
                    { new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), new Guid("c7b6a459-6ce9-4f6f-ac0f-f92d61f17a1b"), 1, "Gray", new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Versatile crew neck t-shirt for men.", 1, true, "Cotton", "Men's Crew Neck Tee", 46, 21.95m, 0, 15m },
                    { new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"), new Guid("b89987d5-80b1-4b0e-afb5-48db1ebf76e2"), 13, "Pink", new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cute and frilly ruffled skirt for little girls.", 3, true, "Cotton", "Kids' Ruffled Skirt", 70, 22.95m, 0, 10m },
                    { new Guid("554bc6c9-a5ff-4515-8d60-d4473fe3f506"), new Guid("b89987d5-80b1-4b0e-afb5-48db1ebf76e2"), 12, "Pink", new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A beautiful princess dress for little girls.", 3, false, "Satin", "Kids' Princess Dress", 84, 49.99m, 0, null },
                    { new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"), new Guid("af65433f-562e-4233-84fa-feac5b99c142"), 9, "Navy", new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cozy V-neck sweater for men.", 1, true, "Wool", "Men's V-Neck Sweater", 13, 54.99m, 0, 25m },
                    { new Guid("722baf22-98de-45c5-b3a1-76f1a2276a41"), new Guid("d6a153bf-fb89-45be-8e1c-e33adc7766ff"), 2, "White", new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "A formal dress shirt for men.", 1, true, "Cotton", "Men's Formal Dress Shirt", 19, 49.99m, 0, 20m },
                    { new Guid("7ee9866b-fd2b-4f64-8db0-f87c7bfae700"), new Guid("8bdc7349-8182-4df5-9fd0-3a4770f3d1fc"), 5, "Black", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A stylish faux leather jacket for women.", 2, false, "Faux Leather", "Women's Faux Leather Jacket", 17, 89.99m, 0, null },
                    { new Guid("820357c5-64d4-4682-b55b-b1710ec91c1b"), new Guid("b89987d5-80b1-4b0e-afb5-48db1ebf76e2"), 9, "Red", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A fun and cozy hoodie with cartoon characters for kids.", 3, true, "Fleece", "Kids' Cartoon Hoodie", 45, 29.95m, 0, 20m },
                    { new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"), new Guid("8bdc7349-8182-4df5-9fd0-3a4770f3d1fc"), 13, "Navy", new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A trendy A-line midi skirt for women.", 2, true, "Cotton", "Women's A-Line Midi Skirt", 8, 49.99m, 0, 15m },
                    { new Guid("86b0240c-56cb-449f-b429-575f0937105c"), new Guid("af65433f-562e-4233-84fa-feac5b99c142"), 10, "Charcoal", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A versatile casual blazer for men.", 1, false, "Cotton", "Men's Casual Blazer", 19, 89.99m, 0, null },
                    { new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), new Guid("b89987d5-80b1-4b0e-afb5-48db1ebf76e2"), 4, "Blue", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic striped polo shirt for little preppy kids.", 3, false, "Cotton", "Kids' Striped Polo Shirt", 54, 27.99m, 0, null },
                    { new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"), new Guid("f4eedcda-6b05-434e-b9f9-22f5a7df981e"), 7, "Charcoal", new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "An elegant formal suit for men.", 1, false, "Wool", "Men's Formal Suit", 96, 299.99m, 0, null },
                    { new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"), new Guid("b89987d5-80b1-4b0e-afb5-48db1ebf76e2"), 1, "Green", new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A fun and colorful cartoon printed shirt for kids.", 3, false, "Cotton", "Kids' Cartoon Printed Shirt", 14, 19.95m, 0, null },
                    { new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), new Guid("d6a153bf-fb89-45be-8e1c-e33adc7766ff"), 1, "White", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Essential V-neck basic t-shirt for men.", 1, false, "Cotton", "Men's V-Neck Basic Tee", 79, 19.99m, 0, null },
                    { new Guid("b221d46f-12f4-4813-8909-927720615e53"), new Guid("e9089772-5892-4f5b-8e3d-82ef55d1e4a3"), 4, "Navy", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic polo shirt for men.", 1, true, "Cotton", "Men's Polo Shirt", 76, 34.99m, 0, 15m },
                    { new Guid("b6effa76-7c26-4cb5-b277-656e45675482"), new Guid("f4eedcda-6b05-434e-b9f9-22f5a7df981e"), 5, "Brown", new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A stylish leather jacket for men.", 1, false, "Leather", "Men's Leather Jacket", 27, 149.99m, 0, null },
                    { new Guid("c57e8283-1e82-48bd-996e-705f66f6a3d2"), new Guid("d6a153bf-fb89-45be-8e1c-e33adc7766ff"), 13, "Purple", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "A boho-style maxi skirt for women.", 2, true, "Rayon", "Women's Boho Maxi Skirt", 59, 59.99m, 0, 20m },
                    { new Guid("d3c02d65-dac9-4db7-b073-74630f92ee01"), new Guid("8bdc7349-8182-4df5-9fd0-3a4770f3d1fc"), 3, "Black", new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trendy skinny jeans for women.", 2, true, "Denim", "Women's Skinny Jeans", 18, 79.99m, 0, 15m },
                    { new Guid("d7bdce86-af37-46d8-9d80-1e0979afcfc8"), new Guid("b89987d5-80b1-4b0e-afb5-48db1ebf76e2"), 18, "Blue", new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adorable denim overalls for adventurous kids.", 3, false, "Denim", "Kids' Denim Overalls", 31, 34.95m, 0, null },
                    { new Guid("e21d6efd-5049-490b-a4ba-799f5505518b"), new Guid("c7b6a459-6ce9-4f6f-ac0f-f92d61f17a1b"), 1, "Navy", new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stylish and comfortable Henley shirt for men.", 1, true, "Cotton", "Men's Henley Shirt", 12, 26.99m, 0, 10m },
                    { new Guid("f4cbc240-1a50-4b55-a244-4f75ecd87de8"), new Guid("d6a153bf-fb89-45be-8e1c-e33adc7766ff"), 1, "Yellow", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cute and colorful t-shirt for kids.", 3, true, "Cotton", "Kids' Cute T-Shirt", 90, 19.99m, 0, 10m },
                    { new Guid("fa924b74-bb89-4fc6-a140-f2df792e1aa5"), new Guid("e9089772-5892-4f5b-8e3d-82ef55d1e4a3"), 3, "Blue", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stylish slim-fit jeans for men.", 1, false, "Denim", "Men's Slim-Fit Jeans", 76, 69.99m, 0, null },
                    { new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"), new Guid("b89987d5-80b1-4b0e-afb5-48db1ebf76e2"), 18, "Khaki", new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sturdy cargo pants for adventurous kids.", 3, false, "Cotton", "Kids' Cargo Pants", 56, 34.99m, 0, null },
                    { new Guid("feec2a48-71cb-4377-93e1-c879d659698c"), new Guid("d6a153bf-fb89-45be-8e1c-e33adc7766ff"), 18, "Beige", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fashionable wide-leg pants for women.", 2, true, "Polyester", "Women's Wide-Leg Pants", 13, 64.95m, 0, 10m }
                });

            migrationBuilder.InsertData(
                table: "ClothesImages",
                columns: new[] { "Id", "ClothingGuid", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("06333af5-af51-4025-af29-503fbb87f5f0"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_de1d201a-9f6a-45c0-a832-c0d0176c03a7.jpg?alt=media&token=51bb66e9-cbaf-45d0-8149-2c473c858d18" },
                    { new Guid("289d011e-382e-4d68-8bc4-9a723f4f5e1a"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/male-black-oversized-basketball-graphic-print-t-shirt.jpg?alt=media&token=b6f87596-658f-40e6-82be-6c7d9c2fb0bc" },
                    { new Guid("32ce5adb-a13b-487a-a61f-764530feb75d"), new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Untitled.jpg?alt=media&token=3cc125cf-3a85-4cfc-9129-a2ebaf5f4cd4" },
                    { new Guid("3b87ee3e-6073-429c-9f68-4c7e42e9c1d4"), new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/711CPySZUIL._AC_UY1000_.jpg?alt=media&token=1a95a798-6212-4d38-a2c8-4b3eb04ccf74" },
                    { new Guid("51ce332e-0d7b-4d7c-b7e5-ae4ba034bc6a"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Kids'%20Graphic%20Print%20Tee.jpg?alt=media&token=ed6e6aa4-d1fd-463c-aa14-4ebdd3f190ca" },
                    { new Guid("5447235f-dc35-4b1e-806a-e862d8dbe36c"), new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/4.jpg?alt=media&token=302976de-afcf-4890-820b-e779a301b097" },
                    { new Guid("6248983b-7e95-45d5-aece-fbe77fd6cc55"), new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A2.jpg?alt=media&token=b4ad3f80-55ae-4b1f-999b-a4458c8c806f" },
                    { new Guid("727e217f-91d9-453b-a62d-7f6e6be026db"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/lacoste-teen-boys-striped-polo-shirt-386596-2ecde85e16638564ddf8022cb8e3b7e992190f33.jpg?alt=media&token=0c0fbedd-181e-48d0-b37d-50ae7f9fee5f" },
                    { new Guid("814b6425-6f96-4a7b-b1b3-925400d2c459"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("8c7d6bf6-458e-49f5-a128-4bb16628e882"), new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A7.jpg?alt=media&token=af0ea87a-9947-429f-878e-1c135f2b2132" },
                    { new Guid("a4b624a8-3897-4851-b50b-2ecb3268a255"), new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A4.jpg?alt=media&token=8a04e1b2-bbc1-4e2f-805f-c0deba5bceb9" },
                    { new Guid("b1a06531-44d5-4b84-82a8-e748feb5963f"), new Guid("feec2a48-71cb-4377-93e1-c879d659698c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A1.jpg?alt=media&token=8125f07a-62e1-40a7-8f25-aec9be4fdfa0" },
                    { new Guid("b5069628-c1ff-414b-98e9-15628ed8488b"), new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/474305ef653fc6da70213cb4650f37e9.jpg?alt=media&token=f6efc379-f291-4d5e-a330-3f066b96d655" },
                    { new Guid("b56c816b-cbca-4566-b0e0-1b185acac30f"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/images.jpg?alt=media&token=b65a904a-0be8-464b-b6df-3f1e3dd24f4a" },
                    { new Guid("c30f5579-0bc4-4ecf-a63a-3bff04a96dfb"), new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A5.jpg?alt=media&token=875083db-6b93-47c6-a14d-b8c009c7017c" },
                    { new Guid("c8738aad-3f2f-4117-9cc0-d97b412e9ded"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("cc3b484e-c165-472f-88b2-e45d40efdbb0"), new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A6.jpg?alt=media&token=a0bc4a08-bf49-4414-929e-aae4ffbe888a" },
                    { new Guid("ce5017df-5036-4bcf-9c22-8b97e2bb2540"), new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_7c2c7453-493c-4794-8653-7de130c53eb9.jpg?alt=media&token=6f341a35-5fc4-46c9-aab8-8d03a42906c0" },
                    { new Guid("e57a1075-2bd6-4ec6-b11b-d1dd6533ca1c"), new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A3.jpg?alt=media&token=097fb988-3822-441f-93af-498f169a8c96" },
                    { new Guid("ff601c1d-bad4-4788-beb8-38b6c196df22"), new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/EACHIN-Boys-Pants-Boys-Pants-Solid-Cargo-Pants-Teenage-Boy-Multi-Pocket-Trousers-Kids-Spring-Autumn.jpg?alt=media&token=c893e73d-39e5-4aa5-9d59-7b6dc656d53a" }
                });

            migrationBuilder.InsertData(
                table: "ClothingSizes",
                columns: new[] { "Id", "ClothingId", "Size", "SizeQuantity" },
                values: new object[,]
                {
                    { new Guid("10900664-c93b-419d-ae6e-8d873518d501"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 6, 20 },
                    { new Guid("1d68a312-b79c-41a1-97f6-1232594f0488"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 6, 15 },
                    { new Guid("2ad5bf5f-07cb-47c6-82df-9d9ba04e521c"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 7, 25 },
                    { new Guid("2f228b86-9f74-4f2b-90a2-2bc20964732d"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 3, 40 },
                    { new Guid("4ad38a0f-9a81-49b8-82e1-13d34ccfbb7e"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 3, 30 },
                    { new Guid("4e9809df-7c5b-49e9-8e3f-7a51d8578135"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 4, 40 },
                    { new Guid("5b81c962-b12d-46a3-9172-e1232f77a1a3"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 2, 40 },
                    { new Guid("5f1d33ee-30d8-489e-b922-9d36c0a25f7d"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 4, 25 },
                    { new Guid("60187913-1920-4d8f-afb8-8b2347602f1b"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 7, 40 },
                    { new Guid("7666792d-2d15-4325-bd45-a3feaa5ce295"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 3, 10 },
                    { new Guid("8cd74aa2-80cd-45dd-9b1d-815161b3a060"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 4, 20 },
                    { new Guid("9e17c2f3-13a3-4a74-bfd1-8f3958c8906d"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 6, 20 },
                    { new Guid("bebe0bd1-60be-45ea-887d-3d8101813ec9"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 5, 40 },
                    { new Guid("c4ca8ad2-a0bc-4f6f-9f0d-5c99a6754972"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 5, 40 },
                    { new Guid("d86ad018-8f04-4958-bfd9-a76f52a333d6"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 4, 15 },
                    { new Guid("df8666de-1582-4d12-9152-f276a4875e90"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 3, 30 },
                    { new Guid("f806a580-7721-4224-aa33-4c767520e4a5"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 5, 35 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_BrandId",
                table: "Clothes",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothesImages_ClothingGuid",
                table: "ClothesImages",
                column: "ClothingGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingReviews_RelatedClothingIdGuid",
                table: "ClothingReviews",
                column: "RelatedClothingIdGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingReviews_UserPostedId",
                table: "ClothingReviews",
                column: "UserPostedId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingSizes_ClothingId",
                table: "ClothingSizes",
                column: "ClothingId");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ClothesImages");

            migrationBuilder.DropTable(
                name: "ClothingReviews");

            migrationBuilder.DropTable(
                name: "ClothingSizes");

            migrationBuilder.DropTable(
                name: "PostComments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Clothes");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
