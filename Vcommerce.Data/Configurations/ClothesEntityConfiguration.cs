using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Enums;

namespace Vcommerce.Data.Configurations;

public class ClothesEntityConfiguration :IEntityTypeConfiguration<Clothes>
{
    private Random random;
    private int thisYear;
    private DateTime dateCreated;

    public ClothesEntityConfiguration()
    {
        this.random = new Random();
        this.thisYear = DateTime.Now.Year;
    }

    public void Configure(EntityTypeBuilder<Clothes> builder)
    {
        builder.Property(c => c.Price)
            .HasPrecision(18, 2);

        builder.Property(c=>c.SalePercentage)
            .HasPrecision(18, 2);

        builder.HasData(GenerateClothes());

    }


    private Clothes[] GenerateClothes()
    {

        ICollection<Clothes> clothes = new HashSet<Clothes>();

        Clothes clothing;

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("283B533B-7ED3-4187-AA7F-CD8A52ED51A5"),
            Name = "Men's Graphic Print Tee",
            Brand = "CoolGuys",
            Price = 24.95m,
            Color = "Black",
            Description = "Cool graphic print t-shirt for stylish men.",
            IsOnSale = true,
            SalePercentage = 20,
            Material = "Cotton",
            Category = Category.TShirts,
            Gender = Gender.Male,
            DateCreated = dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0

        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("9F984CB7-39A8-4003-B9F2-B27ECD32842F"),
            Name = "Men's V-Neck Basic Tee",
            Brand = "ClassicMan",
            Price = 19.99m,
            Color = "White",
            Description = "Essential V-neck basic t-shirt for men.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Cotton",
            Category = Category.TShirts,
            Gender = Gender.Male,
            DateCreated = dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0

        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("0BBB0CE2-68F3-4CB1-B3A6-DE68C6AD1FCD"),
            Name = "Men's Striped Polo Shirt",
            Brand = "PreppyStyle",
            Price = 29.99m,
            Color = "Blue",
            Description = "Classic striped polo shirt for men.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Cotton",
            Category = Category.PoloShirts,
            Gender = Gender.Male,
            DateCreated = dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0

        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("47B74821-1DD5-4AAC-868A-AED6661017F6"),
            Name = "Men's Crew Neck Tee",
            Brand = "CasualChic",
            Price = 21.95m,
            Color = "Gray",
            Description = "Versatile crew neck t-shirt for men.",
            IsOnSale = true,
            SalePercentage = 15,
            Material = "Cotton",
            Category = Category.TShirts,
            Gender = Gender.Male,
            DateCreated = dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0

        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("E21D6EFD-5049-490B-A4BA-799F5505518B"),
            Name = "Men's Henley Shirt",
            Brand = "ModernMan",
            Price = 26.99m,
            Color = "Navy",
            Description = "Stylish and comfortable Henley shirt for men.",
            IsOnSale = true,
            SalePercentage = 10,
            Material = "Cotton",
            Category = Category.TShirts,
            Gender = Gender.Male,
            DateCreated = dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0

        };
        clothes.Add(clothing);
       
        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("3A63AB3E-D7F0-4C42-B3B2-DB6F068E3927"),
            Name = "Men's Casual T-Shirt",
            Brand = "ABC",
            Price = 29.99m,
            Color = "Black",
            Description = "A comfortable casual t-shirt for men.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Cotton",
            Category = Category.TShirts,
            Gender = Gender.Male,
            DateCreated = this.dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0

        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("722BAF22-98DE-45C5-B3A1-76F1A2276A41"),
            Name = "Men's Formal Dress Shirt",
            Brand = "Elegant Attire",
            Price = 49.99m,
            Color = "White",
            Description = "A formal dress shirt for men.",
            IsOnSale = true,
            SalePercentage = 20,
            Material = "Cotton",
            Category = Category.DressShirts,
            Gender = Gender.Male,
            DateCreated = this.dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("FA924B74-BB89-4FC6-A140-F2DF792E1AA5"),
            Name = "Men's Slim-Fit Jeans",
            Brand = "DenimStyle",
            Price = 69.99m,
            Color = "Blue",
            Description = "Stylish slim-fit jeans for men.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Denim",
            Category = Category.Jeans,
            Gender = Gender.Male,
            DateCreated = this.dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("B221D46F-12F4-4813-8909-927720615E53"),
            Name = "Men's Polo Shirt",
            Brand = "SportyLook",
            Price = 34.99m,
            Color = "Navy",
            Description = "A classic polo shirt for men.",
            IsOnSale = true,
            SalePercentage = 15,
            Material = "Cotton",
            Category = Category.PoloShirts,
            Gender = Gender.Male,
            DateCreated = this.dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("B6EFFA76-7C26-4CB5-B277-656E45675482"),
            Name = "Men's Leather Jacket",
            Brand = "RuggedStyle",
            Price = 149.99m,
            Color = "Brown",
            Description = "A stylish leather jacket for men.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Leather",
            Category = Category.Jackets,
            Gender = Gender.Male,
            DateCreated = this.dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("32D319E0-C6A4-46B1-82D9-240D7DE9AD2C"),
            Name = "Men's Hoodie",
            Brand = "UrbanWear",
            Price = 39.99m,
            Color = "Gray",
            Description = "A comfortable hoodie for men.",
            IsOnSale = true,
            SalePercentage = 10,
            Material = "Cotton",
            Category = Category.Hoodies,
            Gender = Gender.Male,
            DateCreated = this.dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("902C1A00-502C-40AB-8BBB-5A93D54674A2"),
            Name = "Men's Formal Suit",
            Brand = "ClassyLook",
            Price = 299.99m,
            Color = "Charcoal",
            Description = "An elegant formal suit for men.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Wool",
            Category = Category.Suits,
            Gender = Gender.Male,
            DateCreated = this.dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("2D7A7984-DFB6-4C94-AFF4-71047F676F96"),
            Name = "Men's Cargo Shorts",
            Brand = "AdventureGear",
            Price = 44.99m,
            Color = "Olive",
            Description = "Durable cargo shorts for men.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Cotton",
            Category = Category.Shorts,
            Gender = Gender.Male,
            DateCreated = this.dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("6E7438C2-245E-42EF-86DD-43280EEEE071"),
            Name = "Men's V-Neck Sweater",
            Brand = "CozyKnits",
            Price = 54.99m,
            Color = "Navy",
            Description = "A cozy V-neck sweater for men.",
            IsOnSale = true,
            SalePercentage = 25,
            Material = "Wool",
            Category = Category.Sweaters,
            Gender = Gender.Male,
            DateCreated = this.dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("86B0240C-56CB-449F-B429-575F0937105C"),
            Name = "Men's Casual Blazer",
            Brand = "SmartCasual",
            Price = 89.99m,
            Color = "Charcoal",
            Description = "A versatile casual blazer for men.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Cotton",
            Category = Category.Blazers,
            Gender = Gender.Male,
            DateCreated = this.dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);


        //Women clothing

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("2BA9A727-D0C6-4A41-AE5B-3E8575CE6EF0"),
            Name = "Women's Casual Blouse",
            Brand = "ChicStyle",
            Price = 39.99m,
            Color = "White",
            Description = "A comfortable and chic blouse for women.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Cotton",
            Category = Category.Blouses,
            Gender = Gender.Female,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0

        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("1234180A-CAE7-4CF6-B237-A0D443B9C963"),
            Name = "Women's Floral Sundress",
            Brand = "GardenGlam",
            Price = 69.95m,
            Color = "Blue",
            Description = "A stylish floral sundress for women.",
            IsOnSale = true,
            SalePercentage = 20,
            Material = "Rayon",
            Category = Category.Dresses,
            Gender = Gender.Female,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("D3C02D65-DAC9-4DB7-B073-74630F92EE01"),
            Name = "Women's Skinny Jeans",
            Brand = "DenimDivas",
            Price = 79.99m,
            Color = "Black",
            Description = "Trendy skinny jeans for women.",
            IsOnSale = true,
            SalePercentage = 15,
            Material = "Denim",
            Category = Category.Jeans,
            Gender = Gender.Female,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("3DB4321B-8228-45A2-B05A-6831E82039EA"),
            Name = "Women's Knit Sweater",
            Brand = "CozyKnits",
            Price = 54.99m,
            Color = "Gray",
            Description = "A cozy knit sweater for women.",
            IsOnSale = true,
            SalePercentage = 25,
            Material = "Wool",
            Category = Category.Sweaters,
            Gender = Gender.Female,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("7EE9866B-FD2B-4F64-8DB0-F87C7BFAE700"),
            Name = "Women's Faux Leather Jacket",
            Brand = "UrbanChic",
            Price = 89.99m,
            Color = "Black",
            Description = "A stylish faux leather jacket for women.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Faux Leather",
            Category = Category.Jackets,
            Gender = Gender.Female,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("FEEC2A48-71CB-4377-93E1-C879D659698C"),
            Name = "Women's Wide-Leg Pants",
            Brand = "FashionForward",
            Price = 64.95m,
            Color = "Beige",
            Description = "Fashionable wide-leg pants for women.",
            IsOnSale = true,
            SalePercentage = 10,
            Material = "Polyester",
            Category = Category.Pants,
            Gender = Gender.Female,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("36E19D2C-825B-431F-9390-5AB3EC07FB2F"),
            Name = "Women's Formal Blazer",
            Brand = "ElegantAttire",
            Price = 89.99m,
            Color = "Gray",
            Description = "A sophisticated formal blazer for women.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Polyester",
            Category = Category.Blazers,
            Gender = Gender.Female,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("C57E8283-1E82-48BD-996E-705F66F6A3D2"),
            Name = "Women's Boho Maxi Skirt",
            Brand = "BohemianSpirit",
            Price = 59.99m,
            Color = "Purple",
            Description = "A boho-style maxi skirt for women.",
            IsOnSale = true,
            SalePercentage = 20,
            Material = "Rayon",
            Category = Category.Skirts,
            Gender = Gender.Female,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("82BBE618-2B7E-4027-A83A-BFD55D85A3B5"),
            Name = "Women's A-Line Midi Skirt",
            Brand = "ModishMe",
            Price = 49.99m,
            Color = "Navy",
            Description = "A trendy A-line midi skirt for women.",
            IsOnSale = true,
            SalePercentage = 15,
            Material = "Cotton",
            Category = Category.Skirts,
            Gender = Gender.Female,
            DateCreated = dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("206BDF4E-8A81-4B28-BCF8-68E9ED167209"),
            Name = "Women's Pleated Maxi Skirt",
            Brand = "ElegantEve",
            Price = 79.95m,
            Color = "Pink",
            Description = "A graceful pleated maxi skirt for women.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Chiffon",
            Category = Category.Skirts,
            Gender = Gender.Female,
            DateCreated = dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);


        //Kids clothing

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("F4CBC240-1A50-4B55-A244-4F75ECD87DE8"),
            Name = "Kids' Cute T-Shirt",
            Brand = "HappyKids",
            Price = 19.99m,
            Color = "Yellow",
            Description = "A cute and colorful t-shirt for kids.",
            IsOnSale = true,
            SalePercentage = 10,
            Material = "Cotton",
            Category = Category.TShirts,
            Gender = Gender.Kids,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0

        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("D7BDCE86-AF37-46D8-9D80-1E0979AFCFC8"),
            Name = "Kids' Denim Overalls",
            Brand = "LittleExplorers",
            Price = 34.95m,
            Color = "Blue",
            Description = "Adorable denim overalls for adventurous kids.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Denim",
            Category = Category.Pants,
            Gender = Gender.Kids,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("554BC6C9-A5FF-4515-8D60-D4473FE3F506"),
            Name = "Kids' Princess Dress",
            Brand = "RoyalKids",
            Price = 49.99m,
            Color = "Pink",
            Description = "A beautiful princess dress for little girls.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Satin",
            Category = Category.Dresses,
            Gender = Gender.Kids,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("820357C5-64D4-4682-B55B-B1710EC91C1B"),
            Name = "Kids' Cartoon Hoodie",
            Brand = "FunTime",
            Price = 29.95m,
            Color = "Red",
            Description = "A fun and cozy hoodie with cartoon characters for kids.",
            IsOnSale = true,
            SalePercentage = 20,
            Material = "Fleece",
            Category = Category.Sweaters,
            Gender = Gender.Kids,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("0FC675D9-FB8C-486A-9C79-CE88BC5688C0"),
            Name = "Kids' Sporty Shorts",
            Brand = "ActiveKids",
            Price = 24.99m,
            Color = "Blue",
            Description = "Comfortable sporty shorts for active kids.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Polyester",
            Category = Category.Shorts,
            Gender = Gender.Kids,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("3B86CD7F-C0B6-487F-BE42-A6F61F05B456"),
            Name = "Kids' Graphic Print Tee",
            Brand = "CoolKids",
            Price = 17.95m,
            Color = "Green",
            Description = "Cool graphic print t-shirt for stylish kids.",
            IsOnSale = true,
            SalePercentage = 25,
            Material = "Cotton",
            Category = Category.TShirts,
            Gender = Gender.Kids,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("8EC859E8-597E-463B-8A4B-A485D4BE7200"),
            Name = "Kids' Striped Polo Shirt",
            Brand = "PreppyKids",
            Price = 27.99m,
            Color = "Blue",
            Description = "Classic striped polo shirt for little preppy kids.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Cotton",
            Category = Category.PoloShirts,
            Gender = Gender.Kids,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("4DF2F27B-788A-4EB4-8C1A-30B397D4A1AA"),
            Name = "Kids' Ruffled Skirt",
            Brand = "CuteKids",
            Price = 22.95m,
            Color = "Pink",
            Description = "A cute and frilly ruffled skirt for little girls.",
            IsOnSale = true,
            SalePercentage = 10,
            Material = "Cotton",
            Category = Category.Skirts,
            Gender = Gender.Kids,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("FE367F15-2491-4B35-B956-8B05B7AC7EDA"),
            Name = "Kids' Cargo Pants",
            Brand = "AdventureKids",
            Price = 34.99m,
            Color = "Khaki",
            Description = "Sturdy cargo pants for adventurous kids.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Cotton",
            Category = Category.Pants,
            Gender = Gender.Kids,
            DateCreated = RandomDate(thisYear),
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.Parse("94C233FA-0A62-4A3E-9140-F3010EFEDEE2"),
            Name = "Kids' Cartoon Printed Shirt",
            Brand = "PlayfulKids",
            Price = 19.95m,
            Color = "Green",
            Description = "A fun and colorful cartoon printed shirt for kids.",
            IsOnSale = false,
            SalePercentage = null,
            Material = "Cotton",
            Category = Category.TShirts,
            Gender = Gender.Kids,
            DateCreated = dateCreated,
            NumberOfSales = random.Next(1, 100),
            Quantity = 0
        };
        clothes.Add(clothing);

        return clothes.ToArray();
    }

    // Function to generate a random date from the current year
    private DateTime RandomDate(int year)
    {
        int daysInYear = DateTime.IsLeapYear(year) ? 366 : 365;
        int randomDay = random.Next(1, daysInYear + 1);
        return new DateTime(year, 1, 1).AddDays(randomDay - 1);
    }

   
}