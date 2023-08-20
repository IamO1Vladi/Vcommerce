using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using Vcommerce.Data.Models.Users;

namespace Vcommerce.Data.Configurations;



public class ApplicationUserEntityConfiguration:IEntityTypeConfiguration<ApplicationUser>
{

    

   

    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {

        builder.Property(u => u.FirstName).HasDefaultValue("Test");

        builder.Property(u => u.FirstName).HasDefaultValue("Test");

    }


  

}