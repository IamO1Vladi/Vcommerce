using Vcommerce.Data.Models.BrandInfo;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Web.ViewModels.Clothes.Enums;

using static VCommerce.Common.GeneralApplicationConstants.GeneralApplicationConstants;

namespace Vcommerce.Web.ViewModels.Clothes;

public class ClothesQueryModel
{

    public ClothesQueryModel()
    {
        this.Clothes = new HashSet<ShopListClothingViewModel>();
        this.Brands = new HashSet<string>();

        this.CurrentPage = DefaultPage;
        this.ClothesPerPage = EntitiesPerPage;
    }
    
    public string? Brand { get; set; }

    public string? SearchString { get; set; }

    public ClothesSorting? ClothesSorting { get; set; }

    public int CurrentPage { get; set; }

    public int TotalClothes { get; set; }

    public int ClothesPerPage { get; set; }

    public IEnumerable<string> Brands { get; set; }

    public IEnumerable<ShopListClothingViewModel> Clothes { get; set; }

    public Gender Gender { get; set; }
    public Category? Category { get; set; }

}