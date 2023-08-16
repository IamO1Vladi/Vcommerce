using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vcommerce.Web.ViewModels.Users;

public class LoginUserFormViewModel
{

    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [DisplayName("Remember me?")]
    public bool RememberMe { get; set; }

    public string? ReturnUrl { get; set; }

}