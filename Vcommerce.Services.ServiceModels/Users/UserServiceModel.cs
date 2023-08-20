namespace Vcommerce.Services.ServiceModels.Users;

public class UserServiceModel
{


    public string Email { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public bool IsModerator { get; set; } 
}