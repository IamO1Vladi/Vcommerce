using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vcommerce.Data.Models.BrandInfo;

namespace Vcommerce.Data.Configurations;

public class BrandsEntityConfiguration:IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {

        builder.HasData(GenerateBrands());
    }

    private Brand[] GenerateBrands()
    {
        ICollection<Brand> brands = new HashSet<Brand>();

        Brand newBrand;

        newBrand = new Brand()
        {
            Id = Guid.Parse("D6A153BF-FB89-45BE-8E1C-E33ADC7766FF"),
            Name = "Nike"
        };
        brands.Add(newBrand);

        newBrand = new Brand()
        {
            Id = Guid.Parse("C7B6A459-6CE9-4F6F-AC0F-F92D61F17A1B"),
            Name = "Adidas"
        };
        brands.Add(newBrand);

        newBrand = new Brand()
        {
            Id = Guid.Parse("E9089772-5892-4F5B-8E3D-82EF55D1E4A3"),
            Name = "Puma"
        };
        brands.Add(newBrand);

        newBrand = new Brand()
        {
            Id = Guid.Parse("F4EEDCDA-6B05-434E-B9F9-22F5A7DF981E"),
            Name = "Under Armour"
        };
        brands.Add(newBrand);

        newBrand = new Brand()
        {
            Id = Guid.Parse("AF65433F-562E-4233-84FA-FEAC5B99C142"),
            Name = "Reebok"
        };
        brands.Add(newBrand);

        newBrand = new Brand()
        {
            Id = Guid.Parse("BDA763C3-2E5B-4DB9-9959-36F3A03DAA8E"),
            Name = "New Balance"
        };
        brands.Add(newBrand);

        newBrand = new Brand()
        {
            Id = Guid.Parse("0A64A7D4-7CC9-441E-B6D0-55D295F186F4"),
            Name = "Vans"
        };
        brands.Add(newBrand);

        newBrand = new Brand()
        {
            Id = Guid.Parse("B2D1EF3E-B42B-4CCB-A88E-51184E7D7DA2"),
            Name = "Converse"
        };
        brands.Add(newBrand);

        newBrand = new Brand()
        {
            Id = Guid.Parse("8BDC7349-8182-4DF5-9FD0-3A4770F3D1FC"),
            Name = "Levi's"
        };
        brands.Add(newBrand);

        newBrand = new Brand()
        {
            Id = Guid.Parse("FE806F53-78D7-4AC3-BC48-735DA7EF15DD"),
            Name = "Tommy Hilfiger"
        };
        brands.Add(newBrand);

        newBrand = new Brand()
        {
            Id = Guid.Parse("A9B80144-68B2-4EB3-8C06-B98ED0C5B672"),
            Name = "Ralph Lauren"
        };
        brands.Add(newBrand);

        newBrand = new Brand()
        {
            Id = Guid.Parse("8D5121B9-097D-432C-B49A-AD582A3A71D2"),
            Name = "Calvin Klein"
        };
        brands.Add(newBrand);

        newBrand = new Brand()
        {
            Id = Guid.Parse("B89987D5-80B1-4B0E-AFB5-48DB1EBF76E2"),
            Name = "H&M"
        };
        brands.Add(newBrand);

        newBrand = new Brand()
        {
            Id = Guid.Parse("7DEE85D1-8681-40D4-93ED-B4702AFADE72"),
            Name = "Zara"
        };
        brands.Add(newBrand);

        newBrand = new Brand()
        {
            Id = Guid.Parse("C19542EB-7C8E-48E9-98A5-E7B5D5DF43B9"),
            Name = "GAP"
        };
        brands.Add(newBrand);


        return brands.ToArray();
    }
}