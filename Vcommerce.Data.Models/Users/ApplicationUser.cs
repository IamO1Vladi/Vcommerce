using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

using static VCommerce.Common.DataBaseValidations.UserValidations;

namespace Vcommerce.Data.Models.Users;

public class ApplicationUser : IdentityUser<Guid>
{

    public ApplicationUser()
    {
        this.Orders = new HashSet<Order.Order>();
       
    }

    public virtual ICollection<Order.Order> Orders { get; set; }

    [MaxLength(MaxFirstNameLength)]
    public string? FirstName { get; set; }

    [MaxLength(MaxLastNameLentgh)]
    public string? LastName { get; set; }


}