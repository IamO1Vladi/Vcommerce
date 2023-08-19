using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using Vcommerce.Data.Models.Users;

namespace Vcommerce.Data.Configurations;

using static Vcommerce.Data.Models.Users.AdminUser;

public class ApplicationUserEntityConfiguration:IEntityTypeConfiguration<ApplicationUser>
{

    private readonly UserManager<ApplicationUser> userManager;
    private readonly RoleManager<IdentityRole> roleManager;

    public ApplicationUserEntityConfiguration(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        userManager = userManager;
        roleManager = roleManager;
    }

   

    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {

        

    }


  

}