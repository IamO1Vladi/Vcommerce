using System.ComponentModel.DataAnnotations;

using static VCommerce.Common.EmailMessagesValidations.EmailMessageValidations;

namespace Vcommerce.Services.ServiceModels.Email;

public class GetInTouchServiceModel
{

    [Required]
    [EmailAddress] 
    public string Email { get; set; } = null!;

    [Required]
    [Phone]
    public string PhoneNumber { get; set; } = null!;

    [Required]
    [StringLength(MaxNameLength,MinimumLength = MinNameLnegth)]
    public string Name { get; set; } = null!;

    [Required]
    [StringLength(MaxSubjectLnegth,MinimumLength = MinSubjectLnegth)]
    public string Subject { get; set; } = null!;

    [Required]
    [StringLength(MaxMessageLength,MinimumLength = MinSubjectLnegth)]
    public string Body { get; set; } = null!;

}