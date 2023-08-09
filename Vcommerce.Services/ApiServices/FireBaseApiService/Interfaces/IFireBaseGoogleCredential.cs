using Google.Apis.Auth.OAuth2;

namespace Vcommerce.Services.ApiServices.FireBaseApiService.Interfaces;

public interface IFireBaseGoogleCredential
{

    public GoogleCredential GetGoogleCredentials();

    public  Task<string> GetAccessTokenAsync();

}