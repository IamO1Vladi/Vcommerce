using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vcommerce.Data.Migrations
{
    public partial class RemovingAvatarUrlFromReviewBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("047108ec-e635-4ef5-88d2-711bb3ecc8aa"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("088f8ae6-de0b-4901-9db5-0098c0cc34ec"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("0e15c9e7-3c15-432e-ba79-b7526977889e"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("19a59462-60bc-47ea-8752-e92756cfed33"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("1e9b40f6-19ce-4ed2-9af9-8698c26f3ddc"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("303383bd-8847-41ab-9474-615fbcaf41c1"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("4cddeeb3-ff2f-49d1-ac3f-3213c3045979"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("51dd8d10-e902-476d-9021-2a32fcee9a2e"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("6336c418-22bc-4f87-bef5-4daa3b91997f"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("aed54180-c874-4bc8-b9bc-25b3c6003815"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("bb4fd9c9-c17c-4613-85d0-864900d0f65c"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("bdf111d6-d78c-4cb0-95b7-ebf013e25591"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("bea3d50b-483c-43fd-865f-a6b2742fc241"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("c361f3cb-03bc-47c5-a665-1a0faccab920"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("c71d736e-9434-4d0e-aad2-a90b58e5c735"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("ce653cef-0978-4632-9424-b16ea4e072d2"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("cee863bd-e8b2-4348-a991-67018bd4d21f"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("d04f5c7b-27de-48e1-be44-37c64c2da75b"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("d18db127-f7fb-41a1-8750-0d7a0aada4f0"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("fdb28526-59f5-4332-9396-bdb124e404af"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("1597162f-7135-4ee2-853b-616d84ea68a2"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("2d622222-149c-4db2-9191-40a427826e8e"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("3f7ee60e-0c74-4dc5-acc6-c97d149506c7"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("47e277dd-cb13-4df0-93ef-9eab63e797b8"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("568d7dac-34cf-4872-aa94-7e66005319ba"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("57b98867-bde3-4baa-9331-041d9a5f8a90"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("7d5604a3-360e-45c1-834b-70fc9f70d0f0"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("83787c15-d988-4922-8a0d-d07e93033af1"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("9fbceb76-1cd3-4fed-86ad-9580ed1ad4d0"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("b112124d-96df-4fe0-ae2c-d71b99d0738e"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("c46f69bc-8544-41a6-a31a-c0934d860c1d"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("df0627a7-19e5-4118-8c93-2cd9b60bd17e"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("df14f685-81d5-41dd-afb1-d3d7b2be747d"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("e1b8afb7-f523-41ae-98cc-dd6a9a42abdc"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("ee6238dc-b745-4163-9a74-ca9c06ff9fd9"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("ef861bd4-6f5d-4d0b-8c27-2692bf292f30"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("fdd26bfb-e6f1-4841-9697-eb921b0162c3"));

            migrationBuilder.DropColumn(
                name: "AvatarUrl",
                table: "ClothingReviews");

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("0fc675d9-fb8c-486a-9c79-ce88bc5688c0"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 78 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 59 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 92 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 82 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 71 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3a63ab3e-d7f0-4c42-b3b2-db6f068e3927"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 60 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3db4321b-8228-45a2-b05a-6831e82039ea"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("554bc6c9-a5ff-4515-8d60-d4473fe3f506"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 95 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("722baf22-98de-45c5-b3a1-76f1a2276a41"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("7ee9866b-fd2b-4f64-8db0-f87c7bfae700"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 82 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("820357c5-64d4-4682-b55b-b1710ec91c1b"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 57 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("86b0240c-56cb-449f-b429-575f0937105c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 81 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 77 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("b221d46f-12f4-4813-8909-927720615e53"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 79 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("b6effa76-7c26-4cb5-b277-656e45675482"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 93 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("c57e8283-1e82-48bd-996e-705f66f6a3d2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 96 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("d3c02d65-dac9-4db7-b073-74630f92ee01"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("d7bdce86-af37-46d8-9d80-1e0979afcfc8"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("e21d6efd-5049-490b-a4ba-799f5505518b"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 96 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("f4cbc240-1a50-4b55-a244-4f75ecd87de8"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 76 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("fa924b74-bb89-4fc6-a140-f2df792e1aa5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("feec2a48-71cb-4377-93e1-c879d659698c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.InsertData(
                table: "ClothesImages",
                columns: new[] { "Id", "ClothingGuid", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("0685f51a-88bb-496b-99c5-fc7c5ee1025a"), new Guid("feec2a48-71cb-4377-93e1-c879d659698c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A1.jpg?alt=media&token=8125f07a-62e1-40a7-8f25-aec9be4fdfa0" },
                    { new Guid("19700215-3b71-4ddb-a809-61e07d727b56"), new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A7.jpg?alt=media&token=af0ea87a-9947-429f-878e-1c135f2b2132" },
                    { new Guid("41c08f63-c932-4c47-8b8c-6eaa6e7dc339"), new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/EACHIN-Boys-Pants-Boys-Pants-Solid-Cargo-Pants-Teenage-Boy-Multi-Pocket-Trousers-Kids-Spring-Autumn.jpg?alt=media&token=c893e73d-39e5-4aa5-9d59-7b6dc656d53a" },
                    { new Guid("4e1d2e72-7123-4daa-bf05-4b19a6f88cce"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/lacoste-teen-boys-striped-polo-shirt-386596-2ecde85e16638564ddf8022cb8e3b7e992190f33.jpg?alt=media&token=0c0fbedd-181e-48d0-b37d-50ae7f9fee5f" },
                    { new Guid("557d08cb-e621-403c-955d-5051a6b58034"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("578e1ba8-db6c-4347-a734-dd58a9847511"), new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/711CPySZUIL._AC_UY1000_.jpg?alt=media&token=1a95a798-6212-4d38-a2c8-4b3eb04ccf74" },
                    { new Guid("71ab111a-0cc6-40b7-8eec-ee645e9699cf"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/images.jpg?alt=media&token=b65a904a-0be8-464b-b6df-3f1e3dd24f4a" }
                });

            migrationBuilder.InsertData(
                table: "ClothesImages",
                columns: new[] { "Id", "ClothingGuid", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("7905d2c3-f12b-4ba5-bdd6-02b7904eb0e2"), new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A3.jpg?alt=media&token=097fb988-3822-441f-93af-498f169a8c96" },
                    { new Guid("7e4fd8e0-c503-43a9-8762-e665ef46ce1d"), new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Untitled.jpg?alt=media&token=3cc125cf-3a85-4cfc-9129-a2ebaf5f4cd4" },
                    { new Guid("8b498758-4457-4afb-90d8-cc672788b195"), new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A5.jpg?alt=media&token=875083db-6b93-47c6-a14d-b8c009c7017c" },
                    { new Guid("a229996c-74f6-4de6-8a13-ea0d85a009d1"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_de1d201a-9f6a-45c0-a832-c0d0176c03a7.jpg?alt=media&token=51bb66e9-cbaf-45d0-8149-2c473c858d18" },
                    { new Guid("a3cf61dd-fab3-4ca5-a1e9-4e232e205a95"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("a7f8e839-ec23-45ec-b902-d34c59db36d9"), new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A6.jpg?alt=media&token=a0bc4a08-bf49-4414-929e-aae4ffbe888a" },
                    { new Guid("aa5846a9-c216-4b01-865b-31d61b153e2c"), new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/474305ef653fc6da70213cb4650f37e9.jpg?alt=media&token=f6efc379-f291-4d5e-a330-3f066b96d655" },
                    { new Guid("be65077b-3631-4ad2-b5af-eab92b308f23"), new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_7c2c7453-493c-4794-8653-7de130c53eb9.jpg?alt=media&token=6f341a35-5fc4-46c9-aab8-8d03a42906c0" },
                    { new Guid("c21bde6b-c0e6-4c0f-ac70-f88f5d7d9bab"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Kids'%20Graphic%20Print%20Tee.jpg?alt=media&token=ed6e6aa4-d1fd-463c-aa14-4ebdd3f190ca" },
                    { new Guid("c4b1c3d4-e75f-4586-b50c-11cb7cc9c24b"), new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/4.jpg?alt=media&token=302976de-afcf-4890-820b-e779a301b097" },
                    { new Guid("d060ca9c-ed83-4a11-b4c3-74a286a8054e"), new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A4.jpg?alt=media&token=8a04e1b2-bbc1-4e2f-805f-c0deba5bceb9" },
                    { new Guid("ecfdc6cd-adfb-4132-b624-fc11d4ffa709"), new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A2.jpg?alt=media&token=b4ad3f80-55ae-4b1f-999b-a4458c8c806f" },
                    { new Guid("f6bed545-85b5-46c7-9bf5-d761c0e1a580"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/male-black-oversized-basketball-graphic-print-t-shirt.jpg?alt=media&token=b6f87596-658f-40e6-82be-6c7d9c2fb0bc" }
                });

            migrationBuilder.InsertData(
                table: "ClothingSizes",
                columns: new[] { "Id", "ClothingId", "Size", "SizeQuantity" },
                values: new object[,]
                {
                    { new Guid("12fb01de-97ce-4cdf-93bd-8cf43bac49d2"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 5, 40 },
                    { new Guid("2eb2e3ea-90e1-4b41-9eef-d24fb28982dc"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 3, 40 },
                    { new Guid("323cbed0-db06-441e-be4d-961e577fcd30"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 3, 30 },
                    { new Guid("35a9ba92-cdda-4657-99ab-bebbb2e036d2"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 4, 25 },
                    { new Guid("43d91de2-57ed-40fd-94e1-f7db9dc34508"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 4, 20 },
                    { new Guid("4d55c3ef-4254-4b53-aa1b-9d12884a2a68"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 3, 10 },
                    { new Guid("5a167225-54fb-4524-bb97-1cf74a86abd3"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 6, 20 },
                    { new Guid("611a30ed-5ca3-4bf1-bb3a-32f92d488b97"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 5, 40 },
                    { new Guid("666970d3-e9f5-478e-bd08-00544fcd8301"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 5, 35 },
                    { new Guid("8e51272d-3162-40aa-be75-90a30c1303ad"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 4, 40 },
                    { new Guid("9f0e16ef-92ae-4144-8b57-aa736aee808b"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 2, 40 },
                    { new Guid("a2014526-0910-472d-aa6f-ef752bb1101b"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 6, 20 },
                    { new Guid("a2d5038f-483c-4f1c-b31c-cda8f10addfc"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 7, 40 },
                    { new Guid("adec9b44-003a-49e4-a8ae-5c79b3b46919"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 6, 15 },
                    { new Guid("c63cbc37-7a9d-4ebf-af40-ff12dbba4b45"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 3, 30 },
                    { new Guid("df6f1951-df60-477f-9ecf-582396857d6e"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 7, 25 },
                    { new Guid("e7522bea-88de-4c24-a2da-1a6d07d53b06"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 4, 15 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("0685f51a-88bb-496b-99c5-fc7c5ee1025a"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("19700215-3b71-4ddb-a809-61e07d727b56"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("41c08f63-c932-4c47-8b8c-6eaa6e7dc339"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("4e1d2e72-7123-4daa-bf05-4b19a6f88cce"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("557d08cb-e621-403c-955d-5051a6b58034"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("578e1ba8-db6c-4347-a734-dd58a9847511"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("71ab111a-0cc6-40b7-8eec-ee645e9699cf"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("7905d2c3-f12b-4ba5-bdd6-02b7904eb0e2"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("7e4fd8e0-c503-43a9-8762-e665ef46ce1d"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("8b498758-4457-4afb-90d8-cc672788b195"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("a229996c-74f6-4de6-8a13-ea0d85a009d1"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("a3cf61dd-fab3-4ca5-a1e9-4e232e205a95"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("a7f8e839-ec23-45ec-b902-d34c59db36d9"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("aa5846a9-c216-4b01-865b-31d61b153e2c"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("be65077b-3631-4ad2-b5af-eab92b308f23"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("c21bde6b-c0e6-4c0f-ac70-f88f5d7d9bab"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("c4b1c3d4-e75f-4586-b50c-11cb7cc9c24b"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("d060ca9c-ed83-4a11-b4c3-74a286a8054e"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("ecfdc6cd-adfb-4132-b624-fc11d4ffa709"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("f6bed545-85b5-46c7-9bf5-d761c0e1a580"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("12fb01de-97ce-4cdf-93bd-8cf43bac49d2"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("2eb2e3ea-90e1-4b41-9eef-d24fb28982dc"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("323cbed0-db06-441e-be4d-961e577fcd30"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("35a9ba92-cdda-4657-99ab-bebbb2e036d2"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("43d91de2-57ed-40fd-94e1-f7db9dc34508"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("4d55c3ef-4254-4b53-aa1b-9d12884a2a68"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("5a167225-54fb-4524-bb97-1cf74a86abd3"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("611a30ed-5ca3-4bf1-bb3a-32f92d488b97"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("666970d3-e9f5-478e-bd08-00544fcd8301"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("8e51272d-3162-40aa-be75-90a30c1303ad"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("9f0e16ef-92ae-4144-8b57-aa736aee808b"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("a2014526-0910-472d-aa6f-ef752bb1101b"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("a2d5038f-483c-4f1c-b31c-cda8f10addfc"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("adec9b44-003a-49e4-a8ae-5c79b3b46919"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("c63cbc37-7a9d-4ebf-af40-ff12dbba4b45"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("df6f1951-df60-477f-9ecf-582396857d6e"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("e7522bea-88de-4c24-a2da-1a6d07d53b06"));

            migrationBuilder.AddColumn<string>(
                name: "AvatarUrl",
                table: "ClothingReviews",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("0fc675d9-fb8c-486a-9c79-ce88bc5688c0"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 56 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 66 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 84 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3a63ab3e-d7f0-4c42-b3b2-db6f068e3927"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3db4321b-8228-45a2-b05a-6831e82039ea"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 68 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 83 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("554bc6c9-a5ff-4515-8d60-d4473fe3f506"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 87 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("722baf22-98de-45c5-b3a1-76f1a2276a41"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("7ee9866b-fd2b-4f64-8db0-f87c7bfae700"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 85 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("820357c5-64d4-4682-b55b-b1710ec91c1b"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 81 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("86b0240c-56cb-449f-b429-575f0937105c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 90 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 80 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("b221d46f-12f4-4813-8909-927720615e53"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 59 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("b6effa76-7c26-4cb5-b277-656e45675482"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 59 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("c57e8283-1e82-48bd-996e-705f66f6a3d2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("d3c02d65-dac9-4db7-b073-74630f92ee01"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 81 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("d7bdce86-af37-46d8-9d80-1e0979afcfc8"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("e21d6efd-5049-490b-a4ba-799f5505518b"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 89 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("f4cbc240-1a50-4b55-a244-4f75ecd87de8"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("fa924b74-bb89-4fc6-a140-f2df792e1aa5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 60 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 54 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("feec2a48-71cb-4377-93e1-c879d659698c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.InsertData(
                table: "ClothesImages",
                columns: new[] { "Id", "ClothingGuid", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("047108ec-e635-4ef5-88d2-711bb3ecc8aa"), new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/4.jpg?alt=media&token=302976de-afcf-4890-820b-e779a301b097" },
                    { new Guid("088f8ae6-de0b-4901-9db5-0098c0cc34ec"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Kids'%20Graphic%20Print%20Tee.jpg?alt=media&token=ed6e6aa4-d1fd-463c-aa14-4ebdd3f190ca" },
                    { new Guid("0e15c9e7-3c15-432e-ba79-b7526977889e"), new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/EACHIN-Boys-Pants-Boys-Pants-Solid-Cargo-Pants-Teenage-Boy-Multi-Pocket-Trousers-Kids-Spring-Autumn.jpg?alt=media&token=c893e73d-39e5-4aa5-9d59-7b6dc656d53a" },
                    { new Guid("19a59462-60bc-47ea-8752-e92756cfed33"), new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A3.jpg?alt=media&token=097fb988-3822-441f-93af-498f169a8c96" },
                    { new Guid("1e9b40f6-19ce-4ed2-9af9-8698c26f3ddc"), new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A6.jpg?alt=media&token=a0bc4a08-bf49-4414-929e-aae4ffbe888a" },
                    { new Guid("303383bd-8847-41ab-9474-615fbcaf41c1"), new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A4.jpg?alt=media&token=8a04e1b2-bbc1-4e2f-805f-c0deba5bceb9" },
                    { new Guid("4cddeeb3-ff2f-49d1-ac3f-3213c3045979"), new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/474305ef653fc6da70213cb4650f37e9.jpg?alt=media&token=f6efc379-f291-4d5e-a330-3f066b96d655" }
                });

            migrationBuilder.InsertData(
                table: "ClothesImages",
                columns: new[] { "Id", "ClothingGuid", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("51dd8d10-e902-476d-9021-2a32fcee9a2e"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/lacoste-teen-boys-striped-polo-shirt-386596-2ecde85e16638564ddf8022cb8e3b7e992190f33.jpg?alt=media&token=0c0fbedd-181e-48d0-b37d-50ae7f9fee5f" },
                    { new Guid("6336c418-22bc-4f87-bef5-4daa3b91997f"), new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/711CPySZUIL._AC_UY1000_.jpg?alt=media&token=1a95a798-6212-4d38-a2c8-4b3eb04ccf74" },
                    { new Guid("aed54180-c874-4bc8-b9bc-25b3c6003815"), new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A5.jpg?alt=media&token=875083db-6b93-47c6-a14d-b8c009c7017c" },
                    { new Guid("bb4fd9c9-c17c-4613-85d0-864900d0f65c"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/male-black-oversized-basketball-graphic-print-t-shirt.jpg?alt=media&token=b6f87596-658f-40e6-82be-6c7d9c2fb0bc" },
                    { new Guid("bdf111d6-d78c-4cb0-95b7-ebf013e25591"), new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A7.jpg?alt=media&token=af0ea87a-9947-429f-878e-1c135f2b2132" },
                    { new Guid("bea3d50b-483c-43fd-865f-a6b2742fc241"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("c361f3cb-03bc-47c5-a665-1a0faccab920"), new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_7c2c7453-493c-4794-8653-7de130c53eb9.jpg?alt=media&token=6f341a35-5fc4-46c9-aab8-8d03a42906c0" },
                    { new Guid("c71d736e-9434-4d0e-aad2-a90b58e5c735"), new Guid("feec2a48-71cb-4377-93e1-c879d659698c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A1.jpg?alt=media&token=8125f07a-62e1-40a7-8f25-aec9be4fdfa0" },
                    { new Guid("ce653cef-0978-4632-9424-b16ea4e072d2"), new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Untitled.jpg?alt=media&token=3cc125cf-3a85-4cfc-9129-a2ebaf5f4cd4" },
                    { new Guid("cee863bd-e8b2-4348-a991-67018bd4d21f"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/images.jpg?alt=media&token=b65a904a-0be8-464b-b6df-3f1e3dd24f4a" },
                    { new Guid("d04f5c7b-27de-48e1-be44-37c64c2da75b"), new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A2.jpg?alt=media&token=b4ad3f80-55ae-4b1f-999b-a4458c8c806f" },
                    { new Guid("d18db127-f7fb-41a1-8750-0d7a0aada4f0"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("fdb28526-59f5-4332-9396-bdb124e404af"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_de1d201a-9f6a-45c0-a832-c0d0176c03a7.jpg?alt=media&token=51bb66e9-cbaf-45d0-8149-2c473c858d18" }
                });

            migrationBuilder.InsertData(
                table: "ClothingSizes",
                columns: new[] { "Id", "ClothingId", "Size", "SizeQuantity" },
                values: new object[,]
                {
                    { new Guid("1597162f-7135-4ee2-853b-616d84ea68a2"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 6, 15 },
                    { new Guid("2d622222-149c-4db2-9191-40a427826e8e"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 6, 20 },
                    { new Guid("3f7ee60e-0c74-4dc5-acc6-c97d149506c7"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 3, 30 },
                    { new Guid("47e277dd-cb13-4df0-93ef-9eab63e797b8"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 4, 40 },
                    { new Guid("568d7dac-34cf-4872-aa94-7e66005319ba"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 2, 40 },
                    { new Guid("57b98867-bde3-4baa-9331-041d9a5f8a90"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 4, 25 },
                    { new Guid("7d5604a3-360e-45c1-834b-70fc9f70d0f0"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 5, 40 },
                    { new Guid("83787c15-d988-4922-8a0d-d07e93033af1"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 5, 40 },
                    { new Guid("9fbceb76-1cd3-4fed-86ad-9580ed1ad4d0"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 3, 10 },
                    { new Guid("b112124d-96df-4fe0-ae2c-d71b99d0738e"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 4, 20 },
                    { new Guid("c46f69bc-8544-41a6-a31a-c0934d860c1d"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 7, 25 },
                    { new Guid("df0627a7-19e5-4118-8c93-2cd9b60bd17e"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 5, 35 },
                    { new Guid("df14f685-81d5-41dd-afb1-d3d7b2be747d"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 6, 20 },
                    { new Guid("e1b8afb7-f523-41ae-98cc-dd6a9a42abdc"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 7, 40 },
                    { new Guid("ee6238dc-b745-4163-9a74-ca9c06ff9fd9"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 3, 40 },
                    { new Guid("ef861bd4-6f5d-4d0b-8c27-2692bf292f30"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 4, 15 },
                    { new Guid("fdd26bfb-e6f1-4841-9697-eb921b0162c3"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 3, 30 }
                });
        }
    }
}
