using System.Net.Http;
using System.Text;
using FirebaseAdmin.Messaging;
using Newtonsoft.Json;
using Vcommerce.Services.ApiServices.QuickBaseApiService.Interfaces;
using Vcommerce.Services.ServiceModels.Email;


namespace Vcommerce.Services.ApiServices.QuickBaseApiService;

public class QuickBaseService:IQuickBaseService
{
    private readonly HttpClient httpClient;

    public QuickBaseService()
    {
        httpClient=new HttpClient();
       
    }
    
    public async Task SendMessage(GetInTouchServiceModel message)
    {

        string realm = "vladimirbuilder.quickbase.com";

        string tableId = "btig79rvb";

        string userToken = "b7sajd_qaib_0_c7x59f4cwjjix5b3yajspb5mrk3a";

       

        httpClient.DefaultRequestHeaders.Add("Authorization", $"QB-USER-TOKEN {userToken}");
        httpClient.DefaultRequestHeaders.Add("QB-Realm-Hostname", $"{realm}");

      

        var trueData = new List<Dictionary<string, Dictionary<string, string>>>
        {
            new Dictionary<string, Dictionary<string, string>>()
            {
                {
                    "6", new Dictionary<string, string>()
                    {
                        { "value", message.Name }
                    }

                },

                {
                    "7", new Dictionary<string, string>()
                    {
                        { "value", message.Email }
                    }
                },

                {
                    "8", new Dictionary<string, string>()
                    {
                        { "value", message.PhoneNumber }
                    }
                },

                {
                    "9", new Dictionary<string, string>()
                    {
                        { "value", message.Subject }
                    }
                },

                {
                    "10", new Dictionary<string, string>()
                    {
                        { "value", message.Body }
                    }
                }

                
                
            }


        };
      

        

        var payLoad = new
        {
            to = $"{tableId}",
            data = trueData
        };

        var jsonPayload = JsonConvert.SerializeObject(payLoad);

        var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

        var response = await httpClient.PostAsync("https://api.quickbase.com/v1/records", content);



    }

    public async Task SaveToSubscriptions(string email)
    {
        string realm = "vladimirbuilder.quickbase.com";

        string tableId = "btig8byes";

        string userToken = "b7sajd_qaib_0_c7x59f4cwjjix5b3yajspb5mrk3a";



        httpClient.DefaultRequestHeaders.Add("Authorization", $"QB-USER-TOKEN {userToken}");
        httpClient.DefaultRequestHeaders.Add("QB-Realm-Hostname", $"{realm}");



        var trueData = new List<Dictionary<string, Dictionary<string, string>>>
        {
            new Dictionary<string, Dictionary<string, string>>()
            {
                {
                    "6", new Dictionary<string, string>()
                    {
                        { "value", email }
                    }

                }
            }


        };




        var payLoad = new
        {
            to = $"{tableId}",
            data = trueData
        };

        var jsonPayload = JsonConvert.SerializeObject(payLoad);

        var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

        var response = await httpClient.PostAsync("https://api.quickbase.com/v1/records", content);

    }
}