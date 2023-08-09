using Google.Apis.Auth.OAuth2;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Vcommerce.Services.ApiServices.FireBaseApiService.Interfaces;

namespace Vcommerce.Services.ApiServices.FireBaseApiService;

public class FireBaseGoogleCredential:IFireBaseGoogleCredential
{
    private readonly IEnumerable<IConfigurationSection> firebaseCredentials;

    public FireBaseGoogleCredential(IEnumerable<IConfigurationSection> credentials)
    {
        this.firebaseCredentials = credentials;
    }

    private string ConvertToJsonString()
    {
        var jsonCredentials = new Dictionary<string, string>();

        foreach (var firebaseCredential in firebaseCredentials)
        {
            jsonCredentials[firebaseCredential.Key] = firebaseCredential.Value;
        }

        string json = JsonConvert.SerializeObject(jsonCredentials,Formatting.Indented);

        return json;

    }

    public GoogleCredential GetGoogleCredentials()
    {

        string fireBaseCredentials = this.ConvertToJsonString();

        return GoogleCredential.FromJson(fireBaseCredentials);
    }

    public async Task<string> GetAccessTokenAsync()
    {
        var credentials = GetGoogleCredentials();
        var token = await credentials.UnderlyingCredential.GetAccessTokenForRequestAsync();

        return token;
    }
}