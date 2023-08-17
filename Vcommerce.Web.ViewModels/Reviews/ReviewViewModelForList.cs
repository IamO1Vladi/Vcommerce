using System.ComponentModel.DataAnnotations;

namespace Vcommerce.Web.ViewModels.Reviews;

public class ReviewViewModelForList
{
    
    public string Description { get; set; } = null!;

    public Guid ClothingId { get; set; }

    public int Rating { get; set; }

    public DateTime DateCreated { get; set; }

    public string AvatarUrl { get; set; }=null!;

   public string Name { get; set; } = null!;
}