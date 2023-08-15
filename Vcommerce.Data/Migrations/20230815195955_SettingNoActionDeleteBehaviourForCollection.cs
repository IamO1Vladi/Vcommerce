using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vcommerce.Data.Migrations
{
    public partial class SettingNoActionDeleteBehaviourForCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_Collections_CollectionId",
                table: "Clothes");

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("028200a7-c462-4a66-af60-619f93472421"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("04fe1392-f57b-4f90-8c0d-68c37560962e"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("05b8353d-c360-4216-89b4-3e60de70b2e9"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("24acbd68-72b1-414a-90bc-64126bf5c89e"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("2ee0f5f8-69ba-4d8e-9fcc-8e312dd89a32"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("42eacabd-eda1-486b-9709-3eb5e77d2fe3"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("5fa91b68-d9bc-449c-81f4-c207c21486ca"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("69b4c4ee-7da5-4a87-8634-bf19d22155f4"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("6cf1a930-79ec-410d-9ce0-e84a1fa79284"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("70296238-2bdf-46b5-b7d3-81f0ade52343"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("81095231-6570-4c43-9ec3-c09e5fbde1d1"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("92ae87fa-3db3-434f-a587-bf11f3a00fcc"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("95158c51-1996-4f14-a958-c7927bd36490"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("9571cc92-86fd-46a2-8121-c68ec8adce2a"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("9d37d357-9805-4ef6-8a2d-c14f3ea068e8"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("a7894445-3c37-4c1c-b648-e9bb74cb1435"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("b4382f50-5eb1-4bb7-8b4f-b5f8f71738e1"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("d7bc99ac-adee-4e1f-920a-4f9833c302df"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("dca05cad-8a08-45ae-a89e-df71c4b95cf0"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("f179f00a-eb02-40f6-8049-8f18e5190ebc"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("0c8c211e-4e8e-4032-ab14-4d1d7ec3297c"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("10a425b6-b829-4f21-804d-4852c36a7dec"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("1d8fabea-411a-4857-8183-10e266a0a4b2"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("282bfcd9-1fab-46db-a473-ea5e9763389f"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("2b3325f2-dabd-4b0b-ac09-f36f9d8589cb"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("51a5ff0a-a1d4-499b-8e73-b3665480bec0"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("66829f6a-096d-4d47-aeb2-f05a16780e5b"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("88d976c9-3cc9-40ac-946a-dd55c35cae8b"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("a0dd1435-42ec-473a-b40a-d16fc797f1f2"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("abd6b486-9afb-4553-b75d-7f8496334734"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("c157e457-d7f5-450d-b64d-fce76878e7ea"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("cf602a29-4085-4a8d-b3a9-30bb19abd8a7"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("d19c55ad-a258-409e-95f9-40a34f252529"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("d409e495-8782-4cba-a586-f36fd43f579a"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("e603a62b-1496-4e8f-9c01-a14f8742addb"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("f09fdae5-dc67-44a6-a24e-62439a365123"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("f48f7fe3-2c4f-4f4c-90d0-1d80759fdfb2"));

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("0fc675d9-fb8c-486a-9c79-ce88bc5688c0"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 75 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 94 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 60 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 77 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3a63ab3e-d7f0-4c42-b3b2-db6f068e3927"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3db4321b-8228-45a2-b05a-6831e82039ea"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 79 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("554bc6c9-a5ff-4515-8d60-d4473fe3f506"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 96 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 71 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("722baf22-98de-45c5-b3a1-76f1a2276a41"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("7ee9866b-fd2b-4f64-8db0-f87c7bfae700"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("820357c5-64d4-4682-b55b-b1710ec91c1b"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 83 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("86b0240c-56cb-449f-b429-575f0937105c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 86 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 86 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("b221d46f-12f4-4813-8909-927720615e53"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("b6effa76-7c26-4cb5-b277-656e45675482"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("c57e8283-1e82-48bd-996e-705f66f6a3d2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("d3c02d65-dac9-4db7-b073-74630f92ee01"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("d7bdce86-af37-46d8-9d80-1e0979afcfc8"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 63 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("e21d6efd-5049-490b-a4ba-799f5505518b"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("f4cbc240-1a50-4b55-a244-4f75ecd87de8"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("fa924b74-bb89-4fc6-a140-f2df792e1aa5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 90 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("feec2a48-71cb-4377-93e1-c879d659698c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 });

            migrationBuilder.InsertData(
                table: "ClothesImages",
                columns: new[] { "Id", "ClothingGuid", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("05058715-b225-48e8-8632-83f10ff3d2cb"), new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/4.jpg?alt=media&token=302976de-afcf-4890-820b-e779a301b097" },
                    { new Guid("2765f6bc-bb67-4a0d-bdbc-1c0242bf6dc9"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Kids'%20Graphic%20Print%20Tee.jpg?alt=media&token=ed6e6aa4-d1fd-463c-aa14-4ebdd3f190ca" },
                    { new Guid("30336aa6-d101-4be8-b148-dd09d4f33f27"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/images.jpg?alt=media&token=b65a904a-0be8-464b-b6df-3f1e3dd24f4a" },
                    { new Guid("33b8e7dd-68e5-49ba-ae4c-541a52b18c15"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/male-black-oversized-basketball-graphic-print-t-shirt.jpg?alt=media&token=b6f87596-658f-40e6-82be-6c7d9c2fb0bc" },
                    { new Guid("4a208b75-72b3-4721-b3f3-896319892b49"), new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/474305ef653fc6da70213cb4650f37e9.jpg?alt=media&token=f6efc379-f291-4d5e-a330-3f066b96d655" },
                    { new Guid("6148fbe6-52e9-42cb-9d2d-c283478eb011"), new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/EACHIN-Boys-Pants-Boys-Pants-Solid-Cargo-Pants-Teenage-Boy-Multi-Pocket-Trousers-Kids-Spring-Autumn.jpg?alt=media&token=c893e73d-39e5-4aa5-9d59-7b6dc656d53a" },
                    { new Guid("6884aad1-7c68-4fdd-85fd-a7ffdd82a782"), new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/711CPySZUIL._AC_UY1000_.jpg?alt=media&token=1a95a798-6212-4d38-a2c8-4b3eb04ccf74" }
                });

            migrationBuilder.InsertData(
                table: "ClothesImages",
                columns: new[] { "Id", "ClothingGuid", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("77340c9a-56d5-4926-a6e8-0f5e30f58d13"), new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A7.jpg?alt=media&token=af0ea87a-9947-429f-878e-1c135f2b2132" },
                    { new Guid("7ca4c988-dfb0-4395-8f23-dad48d1b9608"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("86ac72d7-a04c-4dc7-ba25-73fa960c5bf0"), new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A3.jpg?alt=media&token=097fb988-3822-441f-93af-498f169a8c96" },
                    { new Guid("8ad4a5c0-f146-422b-bb22-c99088a06d48"), new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A5.jpg?alt=media&token=875083db-6b93-47c6-a14d-b8c009c7017c" },
                    { new Guid("8ae8cc84-49d2-475c-a029-75b31f41ae63"), new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A6.jpg?alt=media&token=a0bc4a08-bf49-4414-929e-aae4ffbe888a" },
                    { new Guid("8fe735ec-6cb6-4315-a314-30e9b1f8dfd6"), new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A2.jpg?alt=media&token=b4ad3f80-55ae-4b1f-999b-a4458c8c806f" },
                    { new Guid("912a66e8-9355-481f-ad3b-60e29183bfa0"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_de1d201a-9f6a-45c0-a832-c0d0176c03a7.jpg?alt=media&token=51bb66e9-cbaf-45d0-8149-2c473c858d18" },
                    { new Guid("96d9ee4c-3943-4c14-9674-c22811bf745f"), new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Untitled.jpg?alt=media&token=3cc125cf-3a85-4cfc-9129-a2ebaf5f4cd4" },
                    { new Guid("9d45d483-6e43-444b-bf8b-ed35ecc69ced"), new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A4.jpg?alt=media&token=8a04e1b2-bbc1-4e2f-805f-c0deba5bceb9" },
                    { new Guid("f2db2c99-1e90-4861-905e-8b2bd3ea8168"), new Guid("feec2a48-71cb-4377-93e1-c879d659698c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A1.jpg?alt=media&token=8125f07a-62e1-40a7-8f25-aec9be4fdfa0" },
                    { new Guid("f368402b-c757-4045-8d42-a3a6eca907fa"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("f70a159b-e075-4eba-a8f4-4d520a7bd856"), new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_7c2c7453-493c-4794-8653-7de130c53eb9.jpg?alt=media&token=6f341a35-5fc4-46c9-aab8-8d03a42906c0" },
                    { new Guid("fabee7fc-c987-4997-b35d-5e67aeb25f8f"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/lacoste-teen-boys-striped-polo-shirt-386596-2ecde85e16638564ddf8022cb8e3b7e992190f33.jpg?alt=media&token=0c0fbedd-181e-48d0-b37d-50ae7f9fee5f" }
                });

            migrationBuilder.InsertData(
                table: "ClothingSizes",
                columns: new[] { "Id", "ClothingId", "Size", "SizeQuantity" },
                values: new object[,]
                {
                    { new Guid("13a07361-31f7-4339-a4d0-31cb2d66d9f8"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 5, 40 },
                    { new Guid("1d0d5470-ef63-43c7-9cc6-23ebcbfd201b"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 4, 40 },
                    { new Guid("206a1dca-fed8-43c3-9708-4c913bf61fea"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 5, 40 },
                    { new Guid("22c18fe5-b626-4fec-a4d6-fc1bbdec437d"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 3, 30 },
                    { new Guid("4eafbb0f-83de-4056-b185-389115388412"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 6, 15 },
                    { new Guid("6bbaebaf-87ac-4524-82da-fcd730679a12"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 7, 40 },
                    { new Guid("7ae802cc-01d2-4b08-b290-9e8072785ecb"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 3, 40 },
                    { new Guid("81ac0f25-f1f3-4e7b-9354-09a31744308c"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 5, 35 },
                    { new Guid("994ba363-36b8-4d09-bea4-2940232fcf81"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 3, 10 },
                    { new Guid("a0b063ec-aea8-44b6-bb86-74514776cee8"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 2, 40 },
                    { new Guid("a1123faa-69ff-411d-ac4c-790b626bffcb"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 7, 25 },
                    { new Guid("c3931254-3def-48be-838d-507fb788c397"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 6, 20 },
                    { new Guid("c7c66935-1579-4cbb-a296-a0de468815ae"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 4, 20 },
                    { new Guid("d18c34ef-a4bb-4cc3-8338-1cfe29145831"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 4, 15 },
                    { new Guid("e9eca91f-1d2e-40e0-88aa-bedf4d0c6522"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 6, 20 },
                    { new Guid("ec62bb79-193c-4818-932f-abf90bb45672"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 4, 25 },
                    { new Guid("f332fa33-53c3-4522-bf37-63299dac28a0"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 3, 30 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_Collections_CollectionId",
                table: "Clothes",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_Collections_CollectionId",
                table: "Clothes");

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("05058715-b225-48e8-8632-83f10ff3d2cb"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("2765f6bc-bb67-4a0d-bdbc-1c0242bf6dc9"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("30336aa6-d101-4be8-b148-dd09d4f33f27"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("33b8e7dd-68e5-49ba-ae4c-541a52b18c15"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("4a208b75-72b3-4721-b3f3-896319892b49"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("6148fbe6-52e9-42cb-9d2d-c283478eb011"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("6884aad1-7c68-4fdd-85fd-a7ffdd82a782"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("77340c9a-56d5-4926-a6e8-0f5e30f58d13"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("7ca4c988-dfb0-4395-8f23-dad48d1b9608"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("86ac72d7-a04c-4dc7-ba25-73fa960c5bf0"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("8ad4a5c0-f146-422b-bb22-c99088a06d48"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("8ae8cc84-49d2-475c-a029-75b31f41ae63"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("8fe735ec-6cb6-4315-a314-30e9b1f8dfd6"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("912a66e8-9355-481f-ad3b-60e29183bfa0"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("96d9ee4c-3943-4c14-9674-c22811bf745f"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("9d45d483-6e43-444b-bf8b-ed35ecc69ced"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("f2db2c99-1e90-4861-905e-8b2bd3ea8168"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("f368402b-c757-4045-8d42-a3a6eca907fa"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("f70a159b-e075-4eba-a8f4-4d520a7bd856"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("fabee7fc-c987-4997-b35d-5e67aeb25f8f"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("13a07361-31f7-4339-a4d0-31cb2d66d9f8"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("1d0d5470-ef63-43c7-9cc6-23ebcbfd201b"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("206a1dca-fed8-43c3-9708-4c913bf61fea"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("22c18fe5-b626-4fec-a4d6-fc1bbdec437d"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("4eafbb0f-83de-4056-b185-389115388412"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("6bbaebaf-87ac-4524-82da-fcd730679a12"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("7ae802cc-01d2-4b08-b290-9e8072785ecb"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("81ac0f25-f1f3-4e7b-9354-09a31744308c"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("994ba363-36b8-4d09-bea4-2940232fcf81"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("a0b063ec-aea8-44b6-bb86-74514776cee8"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("a1123faa-69ff-411d-ac4c-790b626bffcb"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("c3931254-3def-48be-838d-507fb788c397"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("c7c66935-1579-4cbb-a296-a0de468815ae"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("d18c34ef-a4bb-4cc3-8338-1cfe29145831"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("e9eca91f-1d2e-40e0-88aa-bedf4d0c6522"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("ec62bb79-193c-4818-932f-abf90bb45672"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("f332fa33-53c3-4522-bf37-63299dac28a0"));

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 73 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("0fc675d9-fb8c-486a-9c79-ce88bc5688c0"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 58 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3a63ab3e-d7f0-4c42-b3b2-db6f068e3927"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3db4321b-8228-45a2-b05a-6831e82039ea"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("554bc6c9-a5ff-4515-8d60-d4473fe3f506"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("722baf22-98de-45c5-b3a1-76f1a2276a41"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 57 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("7ee9866b-fd2b-4f64-8db0-f87c7bfae700"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("820357c5-64d4-4682-b55b-b1710ec91c1b"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("86b0240c-56cb-449f-b429-575f0937105c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 98 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 54 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 94 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("b221d46f-12f4-4813-8909-927720615e53"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 89 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("b6effa76-7c26-4cb5-b277-656e45675482"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("c57e8283-1e82-48bd-996e-705f66f6a3d2"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("d3c02d65-dac9-4db7-b073-74630f92ee01"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("d7bdce86-af37-46d8-9d80-1e0979afcfc8"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("e21d6efd-5049-490b-a4ba-799f5505518b"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 73 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("f4cbc240-1a50-4b55-a244-4f75ecd87de8"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("fa924b74-bb89-4fc6-a140-f2df792e1aa5"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("feec2a48-71cb-4377-93e1-c879d659698c"),
                columns: new[] { "DateCreated", "NumberOfSales" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.InsertData(
                table: "ClothesImages",
                columns: new[] { "Id", "ClothingGuid", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("028200a7-c462-4a66-af60-619f93472421"), new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/4.jpg?alt=media&token=302976de-afcf-4890-820b-e779a301b097" },
                    { new Guid("04fe1392-f57b-4f90-8c0d-68c37560962e"), new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A5.jpg?alt=media&token=875083db-6b93-47c6-a14d-b8c009c7017c" },
                    { new Guid("05b8353d-c360-4216-89b4-3e60de70b2e9"), new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Untitled.jpg?alt=media&token=3cc125cf-3a85-4cfc-9129-a2ebaf5f4cd4" },
                    { new Guid("24acbd68-72b1-414a-90bc-64126bf5c89e"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("2ee0f5f8-69ba-4d8e-9fcc-8e312dd89a32"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_de1d201a-9f6a-45c0-a832-c0d0176c03a7.jpg?alt=media&token=51bb66e9-cbaf-45d0-8149-2c473c858d18" },
                    { new Guid("42eacabd-eda1-486b-9709-3eb5e77d2fe3"), new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A3.jpg?alt=media&token=097fb988-3822-441f-93af-498f169a8c96" },
                    { new Guid("5fa91b68-d9bc-449c-81f4-c207c21486ca"), new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A2.jpg?alt=media&token=b4ad3f80-55ae-4b1f-999b-a4458c8c806f" }
                });

            migrationBuilder.InsertData(
                table: "ClothesImages",
                columns: new[] { "Id", "ClothingGuid", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("69b4c4ee-7da5-4a87-8634-bf19d22155f4"), new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/711CPySZUIL._AC_UY1000_.jpg?alt=media&token=1a95a798-6212-4d38-a2c8-4b3eb04ccf74" },
                    { new Guid("6cf1a930-79ec-410d-9ce0-e84a1fa79284"), new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/EACHIN-Boys-Pants-Boys-Pants-Solid-Cargo-Pants-Teenage-Boy-Multi-Pocket-Trousers-Kids-Spring-Autumn.jpg?alt=media&token=c893e73d-39e5-4aa5-9d59-7b6dc656d53a" },
                    { new Guid("70296238-2bdf-46b5-b7d3-81f0ade52343"), new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A7.jpg?alt=media&token=af0ea87a-9947-429f-878e-1c135f2b2132" },
                    { new Guid("81095231-6570-4c43-9ec3-c09e5fbde1d1"), new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A6.jpg?alt=media&token=a0bc4a08-bf49-4414-929e-aae4ffbe888a" },
                    { new Guid("92ae87fa-3db3-434f-a587-bf11f3a00fcc"), new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_7c2c7453-493c-4794-8653-7de130c53eb9.jpg?alt=media&token=6f341a35-5fc4-46c9-aab8-8d03a42906c0" },
                    { new Guid("95158c51-1996-4f14-a958-c7927bd36490"), new Guid("feec2a48-71cb-4377-93e1-c879d659698c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A1.jpg?alt=media&token=8125f07a-62e1-40a7-8f25-aec9be4fdfa0" },
                    { new Guid("9571cc92-86fd-46a2-8121-c68ec8adce2a"), new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A4.jpg?alt=media&token=8a04e1b2-bbc1-4e2f-805f-c0deba5bceb9" },
                    { new Guid("9d37d357-9805-4ef6-8a2d-c14f3ea068e8"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/images.jpg?alt=media&token=b65a904a-0be8-464b-b6df-3f1e3dd24f4a" },
                    { new Guid("a7894445-3c37-4c1c-b648-e9bb74cb1435"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/male-black-oversized-basketball-graphic-print-t-shirt.jpg?alt=media&token=b6f87596-658f-40e6-82be-6c7d9c2fb0bc" },
                    { new Guid("b4382f50-5eb1-4bb7-8b4f-b5f8f71738e1"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/lacoste-teen-boys-striped-polo-shirt-386596-2ecde85e16638564ddf8022cb8e3b7e992190f33.jpg?alt=media&token=0c0fbedd-181e-48d0-b37d-50ae7f9fee5f" },
                    { new Guid("d7bc99ac-adee-4e1f-920a-4f9833c302df"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Kids'%20Graphic%20Print%20Tee.jpg?alt=media&token=ed6e6aa4-d1fd-463c-aa14-4ebdd3f190ca" },
                    { new Guid("dca05cad-8a08-45ae-a89e-df71c4b95cf0"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("f179f00a-eb02-40f6-8049-8f18e5190ebc"), new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/474305ef653fc6da70213cb4650f37e9.jpg?alt=media&token=f6efc379-f291-4d5e-a330-3f066b96d655" }
                });

            migrationBuilder.InsertData(
                table: "ClothingSizes",
                columns: new[] { "Id", "ClothingId", "Size", "SizeQuantity" },
                values: new object[,]
                {
                    { new Guid("0c8c211e-4e8e-4032-ab14-4d1d7ec3297c"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 3, 30 },
                    { new Guid("10a425b6-b829-4f21-804d-4852c36a7dec"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 7, 25 },
                    { new Guid("1d8fabea-411a-4857-8183-10e266a0a4b2"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 4, 15 },
                    { new Guid("282bfcd9-1fab-46db-a473-ea5e9763389f"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 3, 40 },
                    { new Guid("2b3325f2-dabd-4b0b-ac09-f36f9d8589cb"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 7, 40 },
                    { new Guid("51a5ff0a-a1d4-499b-8e73-b3665480bec0"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 4, 20 },
                    { new Guid("66829f6a-096d-4d47-aeb2-f05a16780e5b"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 5, 40 },
                    { new Guid("88d976c9-3cc9-40ac-946a-dd55c35cae8b"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 3, 10 },
                    { new Guid("a0dd1435-42ec-473a-b40a-d16fc797f1f2"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 2, 40 },
                    { new Guid("abd6b486-9afb-4553-b75d-7f8496334734"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 3, 30 },
                    { new Guid("c157e457-d7f5-450d-b64d-fce76878e7ea"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 6, 20 },
                    { new Guid("cf602a29-4085-4a8d-b3a9-30bb19abd8a7"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 6, 20 },
                    { new Guid("d19c55ad-a258-409e-95f9-40a34f252529"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 4, 25 },
                    { new Guid("d409e495-8782-4cba-a586-f36fd43f579a"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 5, 40 },
                    { new Guid("e603a62b-1496-4e8f-9c01-a14f8742addb"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 5, 35 },
                    { new Guid("f09fdae5-dc67-44a6-a24e-62439a365123"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 6, 15 },
                    { new Guid("f48f7fe3-2c4f-4f4c-90d0-1d80759fdfb2"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 4, 40 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_Collections_CollectionId",
                table: "Clothes",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id");
        }
    }
}
