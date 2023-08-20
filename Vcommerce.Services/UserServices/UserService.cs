using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Vcommerce.Data;
using Vcommerce.Data.Models.Users;
using Vcommerce.Services.ServiceModels.Users;
using Vcommerce.Services.UserServices.Interfaces;
using Vcommerce.Web.Infrastructures.Extensions;

namespace Vcommerce.Services.UserServices;

public class UserService:IUserService
{

    private readonly VcommerceDbContext dbContext;
    private readonly UserManager<ApplicationUser> userManager;

    public UserService(VcommerceDbContext context, UserManager<ApplicationUser> manager)
    {
        this.dbContext = context;
        this.userManager = manager;
    }

    public async Task<string> UserFullName(Guid userId)
    {

        var user = await dbContext.Users.FindAsync(userId);

        if (user == null)
        {
            return "User not found";
        }

        string fullName = $"{user.FirstName} {user.LastName}";

        return fullName ;

    }

  

    public async Task<IEnumerable<UserServiceModel>> All()
    {


        var allUsers = await dbContext.Users.ToListAsync();

        ICollection<UserServiceModel> allUsersViewModel = new List<UserServiceModel>();

        UserServiceModel model;

        foreach (var user in allUsers)
        {

            model = new UserServiceModel()
            {
                Email = user.Email,
                FullName = $"{user.FirstName} {user.LastName}",
                UserName = user.UserName,
                IsModerator = false
            };

            var roles = await userManager.GetRolesAsync(user);

            if (roles != null && roles.Contains("Moderator"))
            {
                model.IsModerator = true;
            }

            allUsersViewModel.Add(model);

        }

        return allUsersViewModel;
    }
}