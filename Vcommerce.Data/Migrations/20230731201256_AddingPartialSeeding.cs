using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vcommerce.Data.Migrations
{
    public partial class AddingPartialSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "Id", "Brand", "Category", "Color", "DateCreated", "Description", "Gender", "IsNew", "IsOnSale", "Material", "Name", "NumberOfSales", "Price", "Quantity", "SalePercentage" },
                values: new object[,]
                {
                    { new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), "PreppyStyle", 4, "Blue", new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic striped polo shirt for men.", 1, true, false, "Cotton", "Men's Striped Polo Shirt", 84, 29.99m, 0, null },
                    { new Guid("0fc675d9-fb8c-486a-9c79-ce88bc5688c0"), "ActiveKids", 8, "Blue", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable sporty shorts for active kids.", 3, true, false, "Polyester", "Kids' Sporty Shorts", 74, 24.99m, 0, null },
                    { new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"), "GardenGlam", 12, "Blue", new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "A stylish floral sundress for women.", 2, false, true, "Rayon", "Women's Floral Sundress", 39, 69.95m, 0, 20m },
                    { new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"), "ElegantEve", 13, "Pink", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "A graceful pleated maxi skirt for women.", 2, true, false, "Chiffon", "Women's Pleated Maxi Skirt", 56, 79.95m, 0, null },
                    { new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "CoolGuys", 1, "Black", new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cool graphic print t-shirt for stylish men.", 1, false, true, "Cotton", "Men's Graphic Print Tee", 90, 24.95m, 0, 20m },
                    { new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"), "ChicStyle", 11, "White", new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "A comfortable and chic blouse for women.", 2, true, false, "Cotton", "Women's Casual Blouse", 40, 39.99m, 0, null },
                    { new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"), "AdventureGear", 8, "Olive", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Durable cargo shorts for men.", 1, false, false, "Cotton", "Men's Cargo Shorts", 58, 44.99m, 0, null },
                    { new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"), "UrbanWear", 6, "Gray", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A comfortable hoodie for men.", 1, true, true, "Cotton", "Men's Hoodie", 16, 39.99m, 0, 10m },
                    { new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"), "ElegantAttire", 10, "Gray", new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A sophisticated formal blazer for women.", 2, false, false, "Polyester", "Women's Formal Blazer", 61, 89.99m, 0, null },
                    { new Guid("3a63ab3e-d7f0-4c42-b3b2-db6f068e3927"), "ABC", 1, "Black", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A comfortable casual t-shirt for men.", 1, false, false, "Cotton", "Men's Casual T-Shirt", 97, 29.99m, 0, null },
                    { new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "CoolKids", 1, "Green", new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cool graphic print t-shirt for stylish kids.", 3, true, true, "Cotton", "Kids' Graphic Print Tee", 90, 17.95m, 0, 25m },
                    { new Guid("3db4321b-8228-45a2-b05a-6831e82039ea"), "CozyKnits", 9, "Gray", new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cozy knit sweater for women.", 2, false, true, "Wool", "Women's Knit Sweater", 10, 54.99m, 0, 25m },
                    { new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), "CasualChic", 1, "Gray", new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Versatile crew neck t-shirt for men.", 1, true, true, "Cotton", "Men's Crew Neck Tee", 82, 21.95m, 0, 15m },
                    { new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"), "CuteKids", 13, "Pink", new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cute and frilly ruffled skirt for little girls.", 3, true, true, "Cotton", "Kids' Ruffled Skirt", 82, 22.95m, 0, 10m },
                    { new Guid("554bc6c9-a5ff-4515-8d60-d4473fe3f506"), "RoyalKids", 12, "Pink", new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "A beautiful princess dress for little girls.", 3, false, false, "Satin", "Kids' Princess Dress", 22, 49.99m, 0, null },
                    { new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"), "CozyKnits", 9, "Navy", new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cozy V-neck sweater for men.", 1, false, true, "Wool", "Men's V-Neck Sweater", 97, 54.99m, 0, 25m },
                    { new Guid("722baf22-98de-45c5-b3a1-76f1a2276a41"), "Elegant Attire", 2, "White", new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A formal dress shirt for men.", 1, true, true, "Cotton", "Men's Formal Dress Shirt", 80, 49.99m, 0, 20m },
                    { new Guid("7ee9866b-fd2b-4f64-8db0-f87c7bfae700"), "UrbanChic", 5, "Black", new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A stylish faux leather jacket for women.", 2, false, false, "Faux Leather", "Women's Faux Leather Jacket", 57, 89.99m, 0, null },
                    { new Guid("820357c5-64d4-4682-b55b-b1710ec91c1b"), "FunTime", 9, "Red", new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "A fun and cozy hoodie with cartoon characters for kids.", 3, true, true, "Fleece", "Kids' Cartoon Hoodie", 21, 29.95m, 0, 20m },
                    { new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"), "ModishMe", 13, "Navy", new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "A trendy A-line midi skirt for women.", 2, true, true, "Cotton", "Women's A-Line Midi Skirt", 54, 49.99m, 0, 15m },
                    { new Guid("86b0240c-56cb-449f-b429-575f0937105c"), "SmartCasual", 10, "Charcoal", new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "A versatile casual blazer for men.", 1, false, false, "Cotton", "Men's Casual Blazer", 81, 89.99m, 0, null },
                    { new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "PreppyKids", 4, "Blue", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic striped polo shirt for little preppy kids.", 3, false, false, "Cotton", "Kids' Striped Polo Shirt", 63, 27.99m, 0, null },
                    { new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"), "ClassyLook", 7, "Charcoal", new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "An elegant formal suit for men.", 1, false, false, "Wool", "Men's Formal Suit", 28, 299.99m, 0, null },
                    { new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"), "PlayfulKids", 1, "Green", new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "A fun and colorful cartoon printed shirt for kids.", 3, true, false, "Cotton", "Kids' Cartoon Printed Shirt", 72, 19.95m, 0, null },
                    { new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), "ClassicMan", 1, "White", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Essential V-neck basic t-shirt for men.", 1, true, false, "Cotton", "Men's V-Neck Basic Tee", 68, 19.99m, 0, null },
                    { new Guid("b221d46f-12f4-4813-8909-927720615e53"), "SportyLook", 4, "Navy", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic polo shirt for men.", 1, false, true, "Cotton", "Men's Polo Shirt", 42, 34.99m, 0, 15m },
                    { new Guid("b6effa76-7c26-4cb5-b277-656e45675482"), "RuggedStyle", 5, "Brown", new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A stylish leather jacket for men.", 1, false, false, "Leather", "Men's Leather Jacket", 55, 149.99m, 0, null },
                    { new Guid("c57e8283-1e82-48bd-996e-705f66f6a3d2"), "BohemianSpirit", 13, "Purple", new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "A boho-style maxi skirt for women.", 2, false, true, "Rayon", "Women's Boho Maxi Skirt", 60, 59.99m, 0, 20m },
                    { new Guid("d3c02d65-dac9-4db7-b073-74630f92ee01"), "DenimDivas", 3, "Black", new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trendy skinny jeans for women.", 2, false, true, "Denim", "Women's Skinny Jeans", 5, 79.99m, 0, 15m },
                    { new Guid("d7bdce86-af37-46d8-9d80-1e0979afcfc8"), "LittleExplorers", 18, "Blue", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adorable denim overalls for adventurous kids.", 3, true, false, "Denim", "Kids' Denim Overalls", 10, 34.95m, 0, null },
                    { new Guid("e21d6efd-5049-490b-a4ba-799f5505518b"), "ModernMan", 1, "Navy", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stylish and comfortable Henley shirt for men.", 1, false, true, "Cotton", "Men's Henley Shirt", 92, 26.99m, 0, 10m },
                    { new Guid("f4cbc240-1a50-4b55-a244-4f75ecd87de8"), "HappyKids", 1, "Yellow", new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cute and colorful t-shirt for kids.", 3, false, true, "Cotton", "Kids' Cute T-Shirt", 64, 19.99m, 0, 10m },
                    { new Guid("fa924b74-bb89-4fc6-a140-f2df792e1aa5"), "DenimStyle", 3, "Blue", new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stylish slim-fit jeans for men.", 1, false, false, "Denim", "Men's Slim-Fit Jeans", 44, 69.99m, 0, null },
                    { new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"), "AdventureKids", 18, "Khaki", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sturdy cargo pants for adventurous kids.", 3, false, false, "Cotton", "Kids' Cargo Pants", 58, 34.99m, 0, null },
                    { new Guid("feec2a48-71cb-4377-93e1-c879d659698c"), "FashionForward", 18, "Beige", new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fashionable wide-leg pants for women.", 2, false, true, "Polyester", "Women's Wide-Leg Pants", 15, 64.95m, 0, 10m }
                });

            migrationBuilder.InsertData(
                table: "ClothesImages",
                columns: new[] { "Id", "ClothingGuid", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("11b59d25-5505-4d09-801d-095a248f423b"), new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/711CPySZUIL._AC_UY1000_.jpg?alt=media&token=1a95a798-6212-4d38-a2c8-4b3eb04ccf74" },
                    { new Guid("1a7e5d17-b62e-4139-8be6-983951cb8c6d"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/lacoste-teen-boys-striped-polo-shirt-386596-2ecde85e16638564ddf8022cb8e3b7e992190f33.jpg?alt=media&token=0c0fbedd-181e-48d0-b37d-50ae7f9fee5f" },
                    { new Guid("2d845dcd-d2af-4280-abaa-905ac1056e50"), new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A7.jpg?alt=media&token=af0ea87a-9947-429f-878e-1c135f2b2132" },
                    { new Guid("615a54e6-892c-453e-ad8b-6c79912860c8"), new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A2.jpg?alt=media&token=b4ad3f80-55ae-4b1f-999b-a4458c8c806f" },
                    { new Guid("703918d4-a48f-4a3b-a510-098d1e83ce96"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("73d4acfe-55b0-4a57-b1ef-56bfd581b615"), new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_7c2c7453-493c-4794-8653-7de130c53eb9.jpg?alt=media&token=6f341a35-5fc4-46c9-aab8-8d03a42906c0" },
                    { new Guid("85daab2d-093b-4045-99db-e71276288c31"), new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/474305ef653fc6da70213cb4650f37e9.jpg?alt=media&token=f6efc379-f291-4d5e-a330-3f066b96d655" },
                    { new Guid("9ccc6937-8d23-4e6d-8658-6b1bfa902507"), new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/4.jpg?alt=media&token=302976de-afcf-4890-820b-e779a301b097" },
                    { new Guid("9dbdfd86-1538-4fc0-875c-0ff6233bdb90"), new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/EACHIN-Boys-Pants-Boys-Pants-Solid-Cargo-Pants-Teenage-Boy-Multi-Pocket-Trousers-Kids-Spring-Autumn.jpg?alt=media&token=c893e73d-39e5-4aa5-9d59-7b6dc656d53a" },
                    { new Guid("a571b4af-62a4-4632-9f1f-b0b34eedb772"), new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A4.jpg?alt=media&token=8a04e1b2-bbc1-4e2f-805f-c0deba5bceb9" },
                    { new Guid("ab5e400f-851c-4202-9f33-9cc822975665"), new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A3.jpg?alt=media&token=097fb988-3822-441f-93af-498f169a8c96" },
                    { new Guid("ac238e7e-0a72-42f1-91fd-9cf694f1d928"), new Guid("feec2a48-71cb-4377-93e1-c879d659698c"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A1.jpg?alt=media&token=8125f07a-62e1-40a7-8f25-aec9be4fdfa0" },
                    { new Guid("bd1d3bfb-b423-4bf4-8c5a-df0a9165b205"), new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A6.jpg?alt=media&token=a0bc4a08-bf49-4414-929e-aae4ffbe888a" },
                    { new Guid("c72445ed-bf49-4600-9542-40809bb0d6d2"), new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Untitled.jpg?alt=media&token=3cc125cf-3a85-4cfc-9129-a2ebaf5f4cd4" },
                    { new Guid("c84a1aa2-a2d4-484a-b66d-11189d96cc86"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533" },
                    { new Guid("d2467509-e320-4178-95f5-b9f588187601"), new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_de1d201a-9f6a-45c0-a832-c0d0176c03a7.jpg?alt=media&token=51bb66e9-cbaf-45d0-8149-2c473c858d18" },
                    { new Guid("d5a85635-ec43-4d4f-b685-c920523ab7d7"), new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A5.jpg?alt=media&token=875083db-6b93-47c6-a14d-b8c009c7017c" },
                    { new Guid("d908183e-3e12-46d4-a3fa-b93feca50f8d"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/images.jpg?alt=media&token=b65a904a-0be8-464b-b6df-3f1e3dd24f4a" },
                    { new Guid("f7db3b9c-d771-43a6-8e09-ad63d4fbb6f2"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/male-black-oversized-basketball-graphic-print-t-shirt.jpg?alt=media&token=b6f87596-658f-40e6-82be-6c7d9c2fb0bc" },
                    { new Guid("f86e87c2-2fc8-456b-878c-d5eb66a08725"), new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"), "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Kids'%20Graphic%20Print%20Tee.jpg?alt=media&token=ed6e6aa4-d1fd-463c-aa14-4ebdd3f190ca" }
                });

            migrationBuilder.InsertData(
                table: "ClothingSizes",
                columns: new[] { "Id", "ClothingId", "Size", "SizeQuantity" },
                values: new object[,]
                {
                    { new Guid("066ec91f-d50e-4588-b592-fe2067b24486"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 3, 10 },
                    { new Guid("09dc8450-9d70-421c-8a51-60b1ffde5620"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 6, 20 },
                    { new Guid("18000ae1-ed8c-44ff-8df8-7725ecf009c6"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 4, 15 },
                    { new Guid("1f12a7c6-be3f-476b-a268-f8fe36cd81ba"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 6, 15 },
                    { new Guid("26eadb66-e6bf-468a-9f4c-eb8c02f304b5"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 3, 30 },
                    { new Guid("321e8e75-ecb2-48d7-a786-c0386dcf3668"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 6, 20 },
                    { new Guid("346aebc7-3a4c-41b2-aee4-e51f6b0afd14"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 5, 40 },
                    { new Guid("4b881173-a452-4df7-aae4-d692e5dd64a8"), new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"), 7, 25 },
                    { new Guid("639e82ed-16d3-4e7a-b3bb-97a960609a50"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 5, 35 },
                    { new Guid("8271cb0e-f3ad-47f0-9cbd-97271e9cd0c1"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 2, 40 },
                    { new Guid("8a368aef-04a2-4033-8807-085925c75927"), new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"), 4, 20 },
                    { new Guid("9cd52004-231f-4465-a0e6-57510dff6ff9"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 4, 40 },
                    { new Guid("b0bf6fcd-3061-4237-bfd9-85e9e8225dd6"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 3, 40 },
                    { new Guid("b8126a0d-314b-4eb4-9f25-277672de8e07"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 7, 40 },
                    { new Guid("f963804b-78e4-411e-b923-388b2638b67c"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 4, 25 },
                    { new Guid("fe6fa9d5-c3be-44d8-84e5-14da811067d9"), new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"), 3, 30 },
                    { new Guid("ffa4f988-ae37-47e6-a564-2a542e445784"), new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"), 5, 40 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("0fc675d9-fb8c-486a-9c79-ce88bc5688c0"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3a63ab3e-d7f0-4c42-b3b2-db6f068e3927"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3db4321b-8228-45a2-b05a-6831e82039ea"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("554bc6c9-a5ff-4515-8d60-d4473fe3f506"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("722baf22-98de-45c5-b3a1-76f1a2276a41"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("7ee9866b-fd2b-4f64-8db0-f87c7bfae700"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("820357c5-64d4-4682-b55b-b1710ec91c1b"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("86b0240c-56cb-449f-b429-575f0937105c"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("b221d46f-12f4-4813-8909-927720615e53"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("b6effa76-7c26-4cb5-b277-656e45675482"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("c57e8283-1e82-48bd-996e-705f66f6a3d2"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("d3c02d65-dac9-4db7-b073-74630f92ee01"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("d7bdce86-af37-46d8-9d80-1e0979afcfc8"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("e21d6efd-5049-490b-a4ba-799f5505518b"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("f4cbc240-1a50-4b55-a244-4f75ecd87de8"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("fa924b74-bb89-4fc6-a140-f2df792e1aa5"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("11b59d25-5505-4d09-801d-095a248f423b"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("1a7e5d17-b62e-4139-8be6-983951cb8c6d"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("2d845dcd-d2af-4280-abaa-905ac1056e50"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("615a54e6-892c-453e-ad8b-6c79912860c8"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("703918d4-a48f-4a3b-a510-098d1e83ce96"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("73d4acfe-55b0-4a57-b1ef-56bfd581b615"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("85daab2d-093b-4045-99db-e71276288c31"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("9ccc6937-8d23-4e6d-8658-6b1bfa902507"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("9dbdfd86-1538-4fc0-875c-0ff6233bdb90"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("a571b4af-62a4-4632-9f1f-b0b34eedb772"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("ab5e400f-851c-4202-9f33-9cc822975665"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("ac238e7e-0a72-42f1-91fd-9cf694f1d928"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("bd1d3bfb-b423-4bf4-8c5a-df0a9165b205"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("c72445ed-bf49-4600-9542-40809bb0d6d2"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("c84a1aa2-a2d4-484a-b66d-11189d96cc86"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("d2467509-e320-4178-95f5-b9f588187601"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("d5a85635-ec43-4d4f-b685-c920523ab7d7"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("d908183e-3e12-46d4-a3fa-b93feca50f8d"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("f7db3b9c-d771-43a6-8e09-ad63d4fbb6f2"));

            migrationBuilder.DeleteData(
                table: "ClothesImages",
                keyColumn: "Id",
                keyValue: new Guid("f86e87c2-2fc8-456b-878c-d5eb66a08725"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("066ec91f-d50e-4588-b592-fe2067b24486"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("09dc8450-9d70-421c-8a51-60b1ffde5620"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("18000ae1-ed8c-44ff-8df8-7725ecf009c6"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("1f12a7c6-be3f-476b-a268-f8fe36cd81ba"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("26eadb66-e6bf-468a-9f4c-eb8c02f304b5"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("321e8e75-ecb2-48d7-a786-c0386dcf3668"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("346aebc7-3a4c-41b2-aee4-e51f6b0afd14"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("4b881173-a452-4df7-aae4-d692e5dd64a8"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("639e82ed-16d3-4e7a-b3bb-97a960609a50"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("8271cb0e-f3ad-47f0-9cbd-97271e9cd0c1"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("8a368aef-04a2-4033-8807-085925c75927"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("9cd52004-231f-4465-a0e6-57510dff6ff9"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("b0bf6fcd-3061-4237-bfd9-85e9e8225dd6"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("b8126a0d-314b-4eb4-9f25-277672de8e07"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("f963804b-78e4-411e-b923-388b2638b67c"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("fe6fa9d5-c3be-44d8-84e5-14da811067d9"));

            migrationBuilder.DeleteData(
                table: "ClothingSizes",
                keyColumn: "Id",
                keyValue: new Guid("ffa4f988-ae37-47e6-a564-2a542e445784"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("0bbb0ce2-68f3-4cb1-b3a6-de68c6ad1fcd"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("1234180a-cae7-4cf6-b237-a0d443b9c963"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("206bdf4e-8a81-4b28-bcf8-68e9ed167209"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("283b533b-7ed3-4187-aa7f-cd8a52ed51a5"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("2ba9a727-d0c6-4a41-ae5b-3e8575ce6ef0"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("2d7a7984-dfb6-4c94-aff4-71047f676f96"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("32d319e0-c6a4-46b1-82d9-240d7de9ad2c"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("36e19d2c-825b-431f-9390-5ab3ec07fb2f"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("3b86cd7f-c0b6-487f-be42-a6f61f05b456"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("47b74821-1dd5-4aac-868a-aed6661017f6"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("4df2f27b-788a-4eb4-8c1a-30b397d4a1aa"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("6e7438c2-245e-42ef-86dd-43280eeee071"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("82bbe618-2b7e-4027-a83a-bfd55d85a3b5"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("8ec859e8-597e-463b-8a4b-a485d4be7200"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("902c1a00-502c-40ab-8bbb-5a93d54674a2"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("94c233fa-0a62-4a3e-9140-f3010efedee2"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("9f984cb7-39a8-4003-b9f2-b27ecd32842f"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("fe367f15-2491-4b35-b956-8b05b7ac7eda"));

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: new Guid("feec2a48-71cb-4377-93e1-c879d659698c"));
        }
    }
}
