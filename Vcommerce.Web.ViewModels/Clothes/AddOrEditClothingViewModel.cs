using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Enums;

using static VCommerce.Common.DataBaseValidations.ProductValidations;
using static VCommerce.Common.DataBaseValidations.ClothesValidations;

namespace Vcommerce.Web.ViewModels.Clothes
{
    public class AddOrEditClothingViewModel
    {
        public AddOrEditClothingViewModel()
        {
            this.Images = new HashSet<IFormFile>();
            this.Sizes = new HashSet<ClothesSizes>();
        }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(MaxBrandLength)]
        public string Brand { get; set; } = null!;

        [Required]
        [Range(minimum: MinPrice, maximum: MaxPrice)]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(MaxColorNameLength)]
        public string Color { get; set; } = null!;

        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(minimum: MinQuantity, maximum: MaxQuantity)]
        public int Quantity { get; set; }


        [Required]
        public bool IsOnSale { get; set; }

        [Range(minimum: MinSalesPercentage, maximum: MaxSalesPercentage)]
        public decimal? SalePercentage { get; set; }


        public ICollection<IFormFile> Images { get; set; } = null!;


        [Required]
        [MaxLength(MaxMaterialNameLength)]
        public string Material { get; set; } = null!;

        [Required] public ICollection<ClothesSizes> Sizes { get; set; } = null!;

        [Required]
        public Category Category { get; set; }

        [Required]
        public Gender Gender { get; set; }


    }
}

