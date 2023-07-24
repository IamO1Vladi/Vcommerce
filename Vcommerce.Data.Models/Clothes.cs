using System.ComponentModel.DataAnnotations;
using Vcommerce.Data.Models.Enums;

namespace Vcommerce.Data.Models;

public class Clothes:Product
{
    public Clothes()
    {
        this.Id = new Guid();
    }

    [Required]
    public string Size { get; set; } = null!;

    [Required]
    public string Material { get; set; } = null!;

    [Required]
    public Category Category { get; set; }

    [Required]
    public Gender Gender { get; set; }

}