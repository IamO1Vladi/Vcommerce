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
        public const double MaxPrice=double.MaxValue;
        public const double MinPrice = 0.99;
        public const int MaxColorNameLength = 30;
        public const int MinColorNameLength = 3;
        public const int MaxDescriptionLength = 500;
        public const int MinDescriptionLength = 50;
        public const int MaxQuantity = 1000;
        public const int MinQuantity = 0;
        public const int MaxSalesPercentage = 99;
        public const int MinSalesPercentage = 5;


    }
}
