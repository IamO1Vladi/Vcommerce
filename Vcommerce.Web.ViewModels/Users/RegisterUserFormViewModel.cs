using System.ComponentModel.DataAnnotations;

using static VCommerce.Common.DataBaseValidations.UserValidations;

namespace Vcommerce.Web.ViewModels.Users;


public class RegisterUserFormViewModel
{

    [Required]
    [StringLength(MaxUserNameLength,MinimumLength = MinUserNameLength)]
    public string UserName { get; set; } = null!;

    [Required]
    [StringLength(MaxPasswordLength,MinimumLength = MinPasswordLength)]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    [Compare("Password",ErrorMessage = "The password and confirmation password do not match!")]
    public string ConfirmPassword { get; set; } = null!;

}