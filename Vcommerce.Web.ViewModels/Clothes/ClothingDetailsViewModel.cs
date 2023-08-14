using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vcommerce.Data.Models.Enums;
using static VCommerce.Common.DataBaseValidations.ClothesValidations;
using static VCommerce.Common.DataBaseValidations.ProductValidations;

namespace Vcommerce.Web.ViewModels.Clothes
{
    public class ClothingDetailsViewModel
    {

        public ClothingDetailsViewModel()
        {
            this.ImageUrls = new List<string>();
        }

        
        public Guid ClothingId { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public decimal? SalesPercentage { get; set; }

        public bool IsOnSale { get; set; }

        public bool IsNew { get; set; }

        
        public string Color { get; set; } = null!;

        
        public string Description { get; set; } = null!;

        public string Material { get; set; } = null!;

        public ICollection<string> ImageUrls { get; set; }

        public Category Category { get; set; }

        public Gender Gender { get; set; }


    }
}
