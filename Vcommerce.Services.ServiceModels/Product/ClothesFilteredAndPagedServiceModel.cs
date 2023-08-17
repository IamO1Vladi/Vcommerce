using Vcommerce.Web.ViewModels.Clothes;

namespace Vcommerce.Services.ServiceModels.Product;

public class ClothesFilteredAndPagedServiceModel
{

    public ClothesFilteredAndPagedServiceModel()
    {
        this.Clothes = new HashSet<ShopListClothingViewModel>();
    }

    public int TotalClothesCount { get; set; }

    public IEnumerable<ShopListClothingViewModel> Clothes { get; set; }



}