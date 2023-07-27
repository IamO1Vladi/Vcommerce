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
        public const int MinNameLength = 5;
        public const int MaxBrandLength = 40;
        public const int MinBrandLength = 5;
        public const decimal MaxPrice=decimal.MaxValue;
        public const decimal MinPrice=decimal.MinValue;
        public const int MaxColorNameLength = 30;
        public const int MinColorNameLength = 3;
        public const int MaxDescriptionLength = 500;
        public const int MinDescriptionLength = 50;
        public const int MaxQuantity = 1000;
        public const int MinQuantity = 0;

    }
}
