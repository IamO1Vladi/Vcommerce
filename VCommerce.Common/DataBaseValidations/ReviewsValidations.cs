using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCommerce.Common.DataBaseValidations
{
    public static class ReviewsValidations
    {

        public const int MaxAvatarUrlLength = 2048;
        public const int MinRating = 0;
        public const int MaxRating = 5;
        public const int MaxDescriptionLength = 500;
        public const int MinDescriptionLength = 4;

    }
}
