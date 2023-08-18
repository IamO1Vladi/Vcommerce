using Microsoft.AspNetCore.Identity;

namespace Vcommerce.Data.Models.Users;

public class ApplicationUser : IdentityUser<Guid>
{

    public ApplicationUser()
    {
        this.Orders = new HashSet<Order.Order>();
       
    }

    public virtual ICollection<Order.Order> Orders { get; set; }

   
}