﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VCommerce.Common.DataBaseValidations.ProductValidations;

namespace Vcommerce.Web.ViewModels.Clothes
{
    public class ShopListClothingViewModel
    {
        [Required]
        public Guid ClothingId { get; set; }

        [Required]
        [StringLength(MaxNameLength,MinimumLength = MinNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        [Range(minimum: MinPrice, maximum: MaxPrice)]
        public decimal Price { get; set; }

        [Range(minimum: MinSalesPercentage,maximum: MaxSalesPercentage)]
        public decimal? SalesPercentage { get; set; }

        [Required]
        public bool IsOnSale { get; set; }

        [Required]
        public bool IsNew { get; set; }


        [Required]
        [StringLength(MaxColorNameLength,MinimumLength = MinColorNameLength)]
        public string Color { get; set; } = null!;





    }
}
