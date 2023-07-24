using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCommerce.Common.DataBaseValidations
{
    public static class ProductValidations
    {
        public const int MaxNameLength = 40;
        public const int MaxBrandLength = 40;
        public const decimal MaxPrice=decimal.MaxValue;
        public const decimal MinPrice=decimal.MinValue;
        public const int MaxColorNameLength = 30;
        public const int MaxDescriptionLength = 500;
        public const int MaxQuantity = 1000;

    }
}
