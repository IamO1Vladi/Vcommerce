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