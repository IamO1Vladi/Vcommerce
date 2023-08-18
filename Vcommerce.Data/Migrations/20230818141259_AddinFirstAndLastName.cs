using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vcommerce.Data.Migrations
{
    public partial class AddinFirstAndLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("03b69bff-64e9-4a6c-a127-84cfdf0c78ca"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("0dacd3a1-5cbd-4b15-9c65-ccb3fa3d504a"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("0f0e907c-8b53-4e94-8f13-c4ed9874036a"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("18cde57b-e546-49a8-a297-76388f8b7bc0"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("2c149978-029a-4288-b426-0e2b684a7d46"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("31ef184a-5e8a-49c5-a18b-d1c33ead615c"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("8cdf3aa5-8e74-45a6-9f00-ac34afbec4df"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("92b88ece-2b6a-4d8d-a6f4-c7e6319b75c4"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("95d7818d-ff9f-4b9f-8256-d8616bed9704"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("99958dd9-b77d-4e13-b5ee-b129406c9eed"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("9f15b5fa-02a1-4a89-a304-c2800b0eb4e9"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("9fd48fb8-c9f5-40dc-aa7a-c463bdc526d1"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("a7b8828e-9d9f-4c6e-a378-34ea2e081b79"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("aa30f74b-79ba-44b5-8c86-6eac1bde926b"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("c76d04ea-10e9-41bb-8f2a-7767b126378a"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("d4be6290-fbe7-4854-bead-ac1d81ad9781"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("e1231acc-72e2-46d4-8985-095d5bc04420"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("ed5b535e-9296-4a91-8789-a63bdeade61e"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("f452ab40-8da7-4682-bd2b-ac23c06b6801"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("ffb0d51c-3534-42cb-b17e-13ae64bfc7ec"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("04a53825-222f-4f1c-99f7-c1abd9dd5f28"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("08b34d59-ba95-4a11-8840-16f424976cf0"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("10be8bb6-8948-48db-82d7-5e5f98ce569f"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("2750705d-8ae0-44f8-ab9e-bec845a2ab46"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("2c56d1da-85f5-4f00-9d7e-9844f1ba93b8"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("3a99a0b0-1ccf-469a-85eb-0014707b3c33"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("4b2d3f1c-8e93-45c0-93bd-7a35b4603ebe"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("5fddd0d0-bdc2-42fc-8d9f-883e53ab54e6"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("60daaa55-2759-4e12-ac5d-f546434a9b3c"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("6ebead3c-5162-44dd-b6bf-a270c0e995cb"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("79ca3ae0-0baf-4288-a33b-b8989a382104"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("84c2b880-6486-428c-b8db-9d26e2e6dc1a"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("a571358b-59d7-45d4-990b-db60261994fb"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("b4ad0e11-5703-4c76-8af8-4077d5b830fd"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("b729da45-5436-4677-9a66-5b11ec78ef63"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("c39151e3-accf-45cf-a25e-0da429ea10c1"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("c8a538d4-d33e-4613-81d6-ecae995fd0b3"));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("0fc675d9-fb8c-486a-9c79-ce88bc5688c0"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 82 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 80 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 59 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3a63ab3e-d7f0-4c42-b3b2-db6f068e3927"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 83 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3db4321b-8228-45a2-b05a-6831e82039ea"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 76 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 72 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("554bc6c9-a5ff-4515-8d60-d4473fe3f506"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 54 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("722baf22-98de-45c5-b3a1-76f1a2276a41"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("7ee9866b-fd2b-4f64-8db0-f87c7bfae700"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 97 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("820357c5-64d4-4682-b55b-b1710ec91c1b"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 68 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("86b0240c-56cb-449f-b429-575f0937105c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 72 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 87 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("b221d46f-12f4-4813-8909-927720615e53"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 57 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("b6effa76-7c26-4cb5-b277-656e45675482"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("c57e8283-1e82-48bd-996e-705f66f6a3d2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("d3c02d65-dac9-4db7-b073-74630f92ee01"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("d7bdce86-af37-46d8-9d80-1e0979afcfc8"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 54 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("e21d6efd-5049-490b-a4ba-799f5505518b"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("f4cbc240-1a50-4b55-a244-4f75ecd87de8"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("fa924b74-bb89-4fc6-a140-f2df792e1aa5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 62 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("feec2a48-71cb-4377-93e1-c879d659698c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 89 });

            migrationBuilder.InsertData(
                table: "ClothesImages",
                columns: new[] { "Id", "ClothingGuid", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("09d8fd9a-ddfa-4e04-9c1c-22e43c3076f8"), new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Untitled.jpg?alt=media&token=3cc125cf-3a85-4cfc-9129-a2ebaf5f4cd4" },
                    { new Guid("40203383-73c3-4d45-b40c-0fd2277f436b"), new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A3.jpg?alt=media&token=097fb988-3822-441f-93af-498f169a8c96" },
                    { new Guid("4e4ab0be-f37f-4c4f-9a73-e000f2f81201"), new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/4.jpg?alt=media&token=302976de-afcf-4890-820b-e779a301b097" },
                    { new Guid("55ebeecf-1043-4bc9-873f-aa87cca652f6"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/lacoste-teen-boys-striped-polo-shirt-386596-2ecde85e16638564ddf8022cb8e3b7e992190f33.jpg?alt=media&token=0c0fbedd-181e-48d0-b37d-50ae7f9fee5f" },
                    { new Guid("5b35d555-e503-43bb-8686-485e303319dc"), new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A6.jpg?alt=media&token=a0bc4a08-bf49-4414-929e-aae4ffbe888a" },
                    { new Guid("5fbd7d6d-b02d-49e6-b3cf-7c0c8aa9321a"), new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A2.jpg?alt=media&token=b4ad3f80-55ae-4b1f-999b-a4458c8c806f" },
                    { new Guid("678fa88e-9383-4dac-9fbb-69799f67705c"), new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/711CPySZUIL._AC_UY1000_.jpg?alt=media&token=1a95a798-6212-4d38-a2c8-4b3eb04ccf74" }
                });

            migrationBuilder.InsertData(
                table: "ClothesImages",
                columns: new[] { "Id", "ClothingGuid", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("6df030a8-2320-4306-ade4-bbfa598be962"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Kids'%20Graphic%20Print%20Tee.jpg?alt=media&token=ed6e6aa4-d1fd-463c-aa14-4ebdd3f190ca" },
                    { new Guid("814b4c48-7876-45c1-9f8f-22f141aaec63"), new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_7c2c7453-493c-4794-8653-7de130c53eb9.jpg?alt=media&token=6f341a35-5fc4-46c9-aab8-8d03a42906c0" },
                    { new Guid("926c5340-169a-4de4-bfc1-d65ab4f1a095"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("95d7beca-f9b5-43f7-a73b-b458a0602ea8"), new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A7.jpg?alt=media&token=af0ea87a-9947-429f-878e-1c135f2b2132" },
                    { new Guid("9bbeea18-6277-4fb0-afae-28d96b4082e1"), new Guid("feec2a48-71cb-4377-93e1-c879d659698c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A1.jpg?alt=media&token=8125f07a-62e1-40a7-8f25-aec9be4fdfa0" },
                    { new Guid("9cc0055b-5a2d-4514-81f4-461fdd79703d"), new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/EACHIN-Boys-Pants-Boys-Pants-Solid-Cargo-Pants-Teenage-Boy-Multi-Pocket-Trousers-Kids-Spring-Autumn.jpg?alt=media&token=c893e73d-39e5-4aa5-9d59-7b6dc656d53a" },
                    { new Guid("9f85a42c-6620-4ffe-a4b8-f34f296d9d71"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_de1d201a-9f6a-45c0-a832-c0d0176c03a7.jpg?alt=media&token=51bb66e9-cbaf-45d0-8149-2c473c858d18" },
                    { new Guid("b49496a1-9989-4194-9930-8fec2a6a9499"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/male-black-oversized-basketball-graphic-print-t-shirt.jpg?alt=media&token=b6f87596-658f-40e6-82be-6c7d9c2fb0bc" },
                    { new Guid("b85ddea3-343b-4872-a56d-0439e4ce4542"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("cda866e8-113b-4a9c-b893-31c00bb3d4a0"), new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/474305ef653fc6da70213cb4650f37e9.jpg?alt=media&token=f6efc379-f291-4d5e-a330-3f066b96d655" },
                    { new Guid("cf333773-af36-4c00-8e19-971230d74187"), new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A4.jpg?alt=media&token=8a04e1b2-bbc1-4e2f-805f-c0deba5bceb9" },
                    { new Guid("fdd170a0-b9e9-4e11-b0c6-f4057745d77f"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/images.jpg?alt=media&token=b65a904a-0be8-464b-b6df-3f1e3dd24f4a" },
                    { new Guid("fef6af7c-a7a0-4890-bb4a-1da6b58b5036"), new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A5.jpg?alt=media&token=875083db-6b93-47c6-a14d-b8c009c7017c" }
                });

            migrationBuilder.InsertData(
                table: "ClothingSizes",
                columns: new[] { "Id", "ClothingId", "Size", "SizeQuantity" },
                values: new object[,]
                {
                    { new Guid("02a40ef3-8e2d-4944-a34f-2953c96f4190"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 6, 20 },
                    { new Guid("2066d29e-6651-4154-8f48-9c6f243a87be"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 5, 40 },
                    { new Guid("3421a6f8-8e32-4b5c-ac21-214e1300151a"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 4, 20 },
                    { new Guid("4a161e44-b66d-42a7-a4b2-4185bae95f66"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 3, 30 },
                    { new Guid("6fc33ab2-c10c-43bc-b9e3-f1d668072f9a"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 6, 15 },
                    { new Guid("79dd5139-f31b-4243-b901-faba1dbd2786"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 5, 40 },
                    { new Guid("7e3069eb-f805-4523-814c-bdd38c44b221"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 7, 40 },
                    { new Guid("88685c86-460d-4a85-88fb-53cec0b78939"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 3, 40 },
                    { new Guid("97396d43-c741-4d2e-8d5d-94c7519bf45c"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 7, 25 },
                    { new Guid("9d307e19-cba4-4e82-ac58-9654524b795a"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 2, 40 },
                    { new Guid("ae6492b1-1d6d-4f0e-a26d-87812b2a69d4"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 6, 20 },
                    { new Guid("bcab7ac2-fda9-4fd1-9d88-679789903837"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 3, 10 },
                    { new Guid("bec3a710-4c56-49d5-a7ae-79804080e3d3"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 5, 35 },
                    { new Guid("d213417a-8c86-462c-9403-23d6754980a6"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 4, 15 },
                    { new Guid("e77592d0-54c8-4caa-9bfc-45f5dad28901"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 3, 30 },
                    { new Guid("edf4bce1-5329-40f1-82b4-4b1fea9347ef"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 4, 40 },
                    { new Guid("fd885567-9f45-4cf3-aa2d-ea9abb1fc1f5"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 4, 25 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("09d8fd9a-ddfa-4e04-9c1c-22e43c3076f8"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("40203383-73c3-4d45-b40c-0fd2277f436b"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("4e4ab0be-f37f-4c4f-9a73-e000f2f81201"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("55ebeecf-1043-4bc9-873f-aa87cca652f6"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("5b35d555-e503-43bb-8686-485e303319dc"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("5fbd7d6d-b02d-49e6-b3cf-7c0c8aa9321a"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("678fa88e-9383-4dac-9fbb-69799f67705c"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("6df030a8-2320-4306-ade4-bbfa598be962"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("814b4c48-7876-45c1-9f8f-22f141aaec63"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("926c5340-169a-4de4-bfc1-d65ab4f1a095"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("95d7beca-f9b5-43f7-a73b-b458a0602ea8"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("9bbeea18-6277-4fb0-afae-28d96b4082e1"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("9cc0055b-5a2d-4514-81f4-461fdd79703d"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("9f85a42c-6620-4ffe-a4b8-f34f296d9d71"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("b49496a1-9989-4194-9930-8fec2a6a9499"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("b85ddea3-343b-4872-a56d-0439e4ce4542"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("cda866e8-113b-4a9c-b893-31c00bb3d4a0"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("cf333773-af36-4c00-8e19-971230d74187"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("fdd170a0-b9e9-4e11-b0c6-f4057745d77f"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("fef6af7c-a7a0-4890-bb4a-1da6b58b5036"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("02a40ef3-8e2d-4944-a34f-2953c96f4190"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("2066d29e-6651-4154-8f48-9c6f243a87be"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("3421a6f8-8e32-4b5c-ac21-214e1300151a"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("4a161e44-b66d-42a7-a4b2-4185bae95f66"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("6fc33ab2-c10c-43bc-b9e3-f1d668072f9a"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("79dd5139-f31b-4243-b901-faba1dbd2786"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("7e3069eb-f805-4523-814c-bdd38c44b221"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("88685c86-460d-4a85-88fb-53cec0b78939"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("97396d43-c741-4d2e-8d5d-94c7519bf45c"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("9d307e19-cba4-4e82-ac58-9654524b795a"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("ae6492b1-1d6d-4f0e-a26d-87812b2a69d4"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("bcab7ac2-fda9-4fd1-9d88-679789903837"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("bec3a710-4c56-49d5-a7ae-79804080e3d3"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("d213417a-8c86-462c-9403-23d6754980a6"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("e77592d0-54c8-4caa-9bfc-45f5dad28901"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("edf4bce1-5329-40f1-82b4-4b1fea9347ef"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("fd885567-9f45-4cf3-aa2d-ea9abb1fc1f5"));

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 98 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("0fc675d9-fb8c-486a-9c79-ce88bc5688c0"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 72 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 81 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3a63ab3e-d7f0-4c42-b3b2-db6f068e3927"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 79 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 68 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3db4321b-8228-45a2-b05a-6831e82039ea"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("554bc6c9-a5ff-4515-8d60-d4473fe3f506"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 84 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("722baf22-98de-45c5-b3a1-76f1a2276a41"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("7ee9866b-fd2b-4f64-8db0-f87c7bfae700"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 58 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("820357c5-64d4-4682-b55b-b1710ec91c1b"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 69 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("86b0240c-56cb-449f-b429-575f0937105c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 57 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 61 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("b221d46f-12f4-4813-8909-927720615e53"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("b6effa76-7c26-4cb5-b277-656e45675482"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 73 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("c57e8283-1e82-48bd-996e-705f66f6a3d2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("d3c02d65-dac9-4db7-b073-74630f92ee01"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 64 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("d7bdce86-af37-46d8-9d80-1e0979afcfc8"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("e21d6efd-5049-490b-a4ba-799f5505518b"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 60 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("f4cbc240-1a50-4b55-a244-4f75ecd87de8"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 63 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("fa924b74-bb89-4fc6-a140-f2df792e1aa5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("feec2a48-71cb-4377-93e1-c879d659698c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.InsertData(
                table: "ClothesImages",
                columns: new[] { "Id", "ClothingGuid", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("03b69bff-64e9-4a6c-a127-84cfdf0c78ca"), new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A7.jpg?alt=media&token=af0ea87a-9947-429f-878e-1c135f2b2132" },
                    { new Guid("0dacd3a1-5cbd-4b15-9c65-ccb3fa3d504a"), new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A6.jpg?alt=media&token=a0bc4a08-bf49-4414-929e-aae4ffbe888a" },
                    { new Guid("0f0e907c-8b53-4e94-8f13-c4ed9874036a"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("18cde57b-e546-49a8-a297-76388f8b7bc0"), new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A5.jpg?alt=media&token=875083db-6b93-47c6-a14d-b8c009c7017c" },
                    { new Guid("2c149978-029a-4288-b426-0e2b684a7d46"), new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A3.jpg?alt=media&token=097fb988-3822-441f-93af-498f169a8c96" },
                    { new Guid("31ef184a-5e8a-49c5-a18b-d1c33ead615c"), new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/4.jpg?alt=media&token=302976de-afcf-4890-820b-e779a301b097" },
                    { new Guid("8cdf3aa5-8e74-45a6-9f00-ac34afbec4df"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Kids'%20Graphic%20Print%20Tee.jpg?alt=media&token=ed6e6aa4-d1fd-463c-aa14-4ebdd3f190ca" }
                });

            migrationBuilder.InsertData(
                table: "ClothesImages",
                columns: new[] { "Id", "ClothingGuid", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("92b88ece-2b6a-4d8d-a6f4-c7e6319b75c4"), new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/EACHIN-Boys-Pants-Boys-Pants-Solid-Cargo-Pants-Teenage-Boy-Multi-Pocket-Trousers-Kids-Spring-Autumn.jpg?alt=media&token=c893e73d-39e5-4aa5-9d59-7b6dc656d53a" },
                    { new Guid("95d7818d-ff9f-4b9f-8256-d8616bed9704"), new Guid("feec2a48-71cb-4377-93e1-c879d659698c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A1.jpg?alt=media&token=8125f07a-62e1-40a7-8f25-aec9be4fdfa0" },
                    { new Guid("99958dd9-b77d-4e13-b5ee-b129406c9eed"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_de1d201a-9f6a-45c0-a832-c0d0176c03a7.jpg?alt=media&token=51bb66e9-cbaf-45d0-8149-2c473c858d18" },
                    { new Guid("9f15b5fa-02a1-4a89-a304-c2800b0eb4e9"), new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_7c2c7453-493c-4794-8653-7de130c53eb9.jpg?alt=media&token=6f341a35-5fc4-46c9-aab8-8d03a42906c0" },
                    { new Guid("9fd48fb8-c9f5-40dc-aa7a-c463bdc526d1"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("a7b8828e-9d9f-4c6e-a378-34ea2e081b79"), new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A4.jpg?alt=media&token=8a04e1b2-bbc1-4e2f-805f-c0deba5bceb9" },
                    { new Guid("aa30f74b-79ba-44b5-8c86-6eac1bde926b"), new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/474305ef653fc6da70213cb4650f37e9.jpg?alt=media&token=f6efc379-f291-4d5e-a330-3f066b96d655" },
                    { new Guid("c76d04ea-10e9-41bb-8f2a-7767b126378a"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/male-black-oversized-basketball-graphic-print-t-shirt.jpg?alt=media&token=b6f87596-658f-40e6-82be-6c7d9c2fb0bc" },
                    { new Guid("d4be6290-fbe7-4854-bead-ac1d81ad9781"), new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/711CPySZUIL._AC_UY1000_.jpg?alt=media&token=1a95a798-6212-4d38-a2c8-4b3eb04ccf74" },
                    { new Guid("e1231acc-72e2-46d4-8985-095d5bc04420"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/images.jpg?alt=media&token=b65a904a-0be8-464b-b6df-3f1e3dd24f4a" },
                    { new Guid("ed5b535e-9296-4a91-8789-a63bdeade61e"), new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Untitled.jpg?alt=media&token=3cc125cf-3a85-4cfc-9129-a2ebaf5f4cd4" },
                    { new Guid("f452ab40-8da7-4682-bd2b-ac23c06b6801"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/lacoste-teen-boys-striped-polo-shirt-386596-2ecde85e16638564ddf8022cb8e3b7e992190f33.jpg?alt=media&token=0c0fbedd-181e-48d0-b37d-50ae7f9fee5f" },
                    { new Guid("ffb0d51c-3534-42cb-b17e-13ae64bfc7ec"), new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A2.jpg?alt=media&token=b4ad3f80-55ae-4b1f-999b-a4458c8c806f" }
                });

            migrationBuilder.InsertData(
                table: "ClothingSizes",
                columns: new[] { "Id", "ClothingId", "Size", "SizeQuantity" },
                values: new object[,]
                {
                    { new Guid("04a53825-222f-4f1c-99f7-c1abd9dd5f28"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 3, 30 },
                    { new Guid("08b34d59-ba95-4a11-8840-16f424976cf0"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 5, 40 },
                    { new Guid("10be8bb6-8948-48db-82d7-5e5f98ce569f"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 3, 40 },
                    { new Guid("2750705d-8ae0-44f8-ab9e-bec845a2ab46"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 7, 25 },
                    { new Guid("2c56d1da-85f5-4f00-9d7e-9844f1ba93b8"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 4, 15 },
                    { new Guid("3a99a0b0-1ccf-469a-85eb-0014707b3c33"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 5, 40 },
                    { new Guid("4b2d3f1c-8e93-45c0-93bd-7a35b4603ebe"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 3, 30 },
                    { new Guid("5fddd0d0-bdc2-42fc-8d9f-883e53ab54e6"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 7, 40 },
                    { new Guid("60daaa55-2759-4e12-ac5d-f546434a9b3c"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 4, 40 },
                    { new Guid("6ebead3c-5162-44dd-b6bf-a270c0e995cb"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 5, 35 },
                    { new Guid("79ca3ae0-0baf-4288-a33b-b8989a382104"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 2, 40 },
                    { new Guid("84c2b880-6486-428c-b8db-9d26e2e6dc1a"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 4, 20 },
                    { new Guid("a571358b-59d7-45d4-990b-db60261994fb"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 3, 10 },
                    { new Guid("b4ad0e11-5703-4c76-8af8-4077d5b830fd"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 4, 25 },
                    { new Guid("b729da45-5436-4677-9a66-5b11ec78ef63"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 6, 15 },
                    { new Guid("c39151e3-accf-45cf-a25e-0da429ea10c1"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 6, 20 },
                    { new Guid("c8a538d4-d33e-4613-81d6-ecae995fd0b3"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 6, 20 }
                });
        }
    }
}
