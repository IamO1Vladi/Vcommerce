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

    }


    public Clothes[] GenerateClothes()
    {

        ICollection<Clothes> clothes = new HashSet<Clothes>();

        Clothes clothing;

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)

        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)

        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)

        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)

        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)

        };
        clothes.Add(clothing);
       
        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = this.IsNew(this.dateCreated)

        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = this.IsNew(this.dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = this.IsNew(this.dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = this.IsNew(this.dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = this.IsNew(this.dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = this.IsNew(this.dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = this.IsNew(this.dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = this.IsNew(this.dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = this.IsNew(this.dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = this.IsNew(this.dateCreated)
        };
        clothes.Add(clothing);


        //Women clothing

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)

        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);


        //Kids clothing

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)

        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
        };
        clothes.Add(clothing);

        dateCreated = RandomDate(thisYear);
        clothing = new Clothes()
        {
            Id = Guid.NewGuid(),
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
            Quantity = 0,
            IsNew = IsNew(dateCreated)
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

    private bool IsNew(DateTime dateCreated)
    {
        if (dateCreated > DateTime.Today.AddDays(-14))
        {
            return true;
        }

        return false;
    }
}