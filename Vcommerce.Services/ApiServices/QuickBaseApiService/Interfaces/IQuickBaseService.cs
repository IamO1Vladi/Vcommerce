using Vcommerce.Services.ServiceModels.Email;

namespace Vcommerce.Services.ApiServices.QuickBaseApiService.Interfaces;

public interface IQuickBaseService
{

    public Task SendMessage(GetInTouchServiceModel message);

    public Task SaveToSubscriptions(string email);

}