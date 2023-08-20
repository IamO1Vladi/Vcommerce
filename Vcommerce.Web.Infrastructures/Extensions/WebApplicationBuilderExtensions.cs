using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Vcommerce.Data.Models.Users;

using static Vcommerce.Web.Infrastructures.AdminConstraints.AdminUser;

namespace Vcommerce.Web.Infrastructures.Extensions;

public static class WebApplicationBuilderExtensions
{
    /// <summary>
    /// This method registers all services with their interfaces and implementations in the given Assembly
    /// The Assembly is taken from the service provided
    /// </summary>
    /// <param name="serviceType">Type of random service implementation used to get the Assembly of the services</param>
    /// <exception cref="InvalidOperationException"></exception>
    public static void AddApplicationServices(this IServiceCollection services,Type serviceType)
    {
        Assembly? serviceAssembly= Assembly.GetAssembly(serviceType);

        if (serviceAssembly == null)
        {
            throw new InvalidOperationException("Invalid service type provided");
        }
        Type[] serviceTypes = serviceAssembly.GetTypes()
            .Where(t=>t.Name.EndsWith("Service") &&!t.IsInterface)
            .ToArray();

        foreach (var implementationType in serviceTypes)
        {
            Type? interfaceType = implementationType.GetInterface($"I{implementationType.Name}");
            if (interfaceType == null)
            {
                throw new InvalidOperationException($"No interface is provided for the service with name {implementationType.Name}");
            }

            services.AddScoped(interfaceType, implementationType);
        }
    }


    /// <summary>
    /// This method registers all repository services with their interfaces and implementations in the given Assembly
    /// The Assembly is taken from the service provided
    /// </summary>
    /// <param name="serviceType">Type of random repository service implementation used to get the Assembly of the services</param>
    /// <exception cref="InvalidOperationException"></exception>
    public static void AddApplicationRepositoryServices(this IServiceCollection services, Type serviceType)
    {
        Assembly? serviceAssembly = Assembly.GetAssembly(serviceType);

        if (serviceAssembly == null)
        {
            throw new InvalidOperationException("Invalid service type provided");
        }
        Type[] serviceTypes = serviceAssembly.GetTypes()
            .Where(t => t.Name.EndsWith("Repo") && !t.IsInterface)
            .ToArray();

        foreach (var implementationType in serviceTypes)
        {
            Type? interfaceType = implementationType.GetInterface($"I{implementationType.Name}");
            if (interfaceType == null)
            {
                throw new InvalidOperationException($"No interface is provided for the service with name {implementationType.Name}");
            }

            services.AddScoped(interfaceType, implementationType);
        }
    }


    /// <summary>
    /// This method seeds admin role if it does not exist.
    /// Passed email should be valid email of existing user in the application.
    /// </summary>
    /// <param name="app"></param>
    /// <returns></returns>
    public static IApplicationBuilder SeedAdministrator(this IApplicationBuilder app)
    {
        using IServiceScope scopedServices = app.ApplicationServices.CreateScope();

        IServiceProvider serviceProvider = scopedServices.ServiceProvider;

        UserManager<ApplicationUser> userManager =
            serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        RoleManager<IdentityRole<Guid>> roleManager =
            serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

        Task.Run(async () =>
            {
                if (await roleManager.RoleExistsAsync(AdminRoleName))
                {
                   
                }
                else
                {
                    IdentityRole<Guid> role =
                        new IdentityRole<Guid>(AdminRoleName);

                    await roleManager.CreateAsync(role);
                }

                if (!await roleManager.RoleExistsAsync("Moderator"))
                {
                    IdentityRole<Guid> role =
                        new IdentityRole<Guid>("Moderator");

                    await roleManager.CreateAsync(role);
                }
                

                // Seed users
                if (await userManager.FindByEmailAsync(AdminEmail) == null)
                {
                    var user = new ApplicationUser()
                    {
                        //Id = Guid.Parse("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                        Id= Guid.NewGuid(),
                        Email = AdminEmail,
                        NormalizedEmail = AdminEmail,
                        UserName = AdminEmail,
                        NormalizedUserName = AdminEmail,
                        FirstName = "Great",
                        LastName = "Admin"
                    };

                    var result = await userManager.CreateAsync(user, "admin123"); // Set the password here

                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, "Administrator"); // Add user to a role if needed
                    }
                }
                else
                {
                    var user = await userManager.FindByEmailAsync(AdminEmail);

                    var userRoles = await userManager.GetRolesAsync(user);

                    if (!userRoles.Contains("Administrator"))
                    {
                        await userManager.AddToRoleAsync(user, "Administrator");
                    }
                }
                

               
            })
            .GetAwaiter()
            .GetResult();

        return app;
    }

}

