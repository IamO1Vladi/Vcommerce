using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Vcommerce.Data.Models;
using Vcommerce.Data.Models.BrandInfo;
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
        }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [Required]
       
        public Guid Brand { get; set; }

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
        public bool IsOnSale { get; set; }

        [Range(minimum: MinSalesPercentage, maximum: MaxSalesPercentage)]
        public decimal? SalePercentage { get; set; }


        public ICollection<IFormFile> Images { get; set; } = null!;


        [Required]
        [MaxLength(MaxMaterialNameLength)]
        public string Material { get; set; } = null!;

        [Required]
        public Category Category { get; set; }

        [Required]
        public Gender Gender { get; set; }


    }
}

