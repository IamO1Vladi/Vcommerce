using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vcommerce.Web.ViewModels.Clothes
{
    public class AllExclusiveProductsForHomePageVIewModel
    {

        public AllExclusiveProductsForHomePageVIewModel()
        {
            this.HotProducts = new HashSet<ExclusiveProductsViewModel>();
            this.NewProducts = new HashSet<ExclusiveProductsViewModel>();
            this.ProductsOnSale = new HashSet<ExclusiveProductsViewModel>();
        }

        public ICollection<ExclusiveProductsViewModel> ProductsOnSale { get; set; }
        
        public ICollection<ExclusiveProductsViewModel> NewProducts { get; set; }

        public ICollection<ExclusiveProductsViewModel> HotProducts { get; set; }

    }
}
