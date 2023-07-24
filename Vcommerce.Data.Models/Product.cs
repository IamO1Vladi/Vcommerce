﻿using System.ComponentModel.DataAnnotations;

namespace Vcommerce.Data.Models;

public abstract class Product
{
    

    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    [Required]
    public string Brand { get; set; } = null!;

    [Required]
    public decimal Price { get; set; }

    [Required]
    public string Color { get; set; } = null!;

    [Required]
    public string Description { get; set; } = null!;

    [Required]
    public int Quantity { get; set; }


}