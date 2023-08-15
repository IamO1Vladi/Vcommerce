using Vcommerce.Data.Models.Enums;

namespace Vcommerce.Web.ViewModels.Collections;

public class ListAllCollectionsViewModel
{
    
    public Guid CollectionId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Gender Gender { get; set; }

}