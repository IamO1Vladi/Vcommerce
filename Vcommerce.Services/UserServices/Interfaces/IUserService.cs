using Vcommerce.Data.Models.Users;
using Vcommerce.Services.ServiceModels.Users;

namespace Vcommerce.Services.UserServices.Interfaces;

public interface IUserService
{

    Task<string> UserFullName(Guid userId);


    Task<IEnumerable<UserServiceModel>> All();

}