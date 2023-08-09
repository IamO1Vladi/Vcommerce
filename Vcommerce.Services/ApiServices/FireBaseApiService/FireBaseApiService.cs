using System.Runtime.CompilerServices;
using Firebase.Storage;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Vcommerce.Services.ApiServices.FireBaseApiService.Interfaces;

namespace Vcommerce.Services.ApiServices.FireBaseApiService;

public class FireBaseApiService:IFireBaseApiService
{

    private readonly IFireBaseGoogleCredential fireBaseCredentials;
    private readonly FirebaseApp app;
    private  FirebaseStorage storage;

    public FireBaseApiService(IFireBaseGoogleCredential credential)
    {
        this.fireBaseCredentials=credential;
        var credentialResult = fireBaseCredentials.GetGoogleCredentials();
        if (FirebaseApp.DefaultInstance == null)
        {
            this.app = FirebaseApp.Create(new AppOptions
            {
                Credential = credentialResult
            });
        }


       

    }

  /*  public async Task<string> UploadImageToFireBase(Stream imageStream, string fileName, string bucket)
    {


        string token = await this.GenerateCustomerTokenAsync();



        //var testStorage = await StorageClient.CreateAsync(fireBaseCredentials.GetGoogleCredentials());
        //var imageObject = await testStorage.UploadObjectAsync(bucket, fileName, null, imageStream);
        //var imageUrl = imageObject.MediaLink;

        

        this.storage = new FirebaseStorage(
            Environment.GetEnvironmentVariable("bucket"),
            new FirebaseStorageOptions()
            {
                AuthTokenAsyncFactory = async () => await fireBaseCredentials.GetAccessTokenAsync()

            });

        var imageUrl = await storage.Child(fileName).PutAsync(imageStream);


        //string url =
        //   $"https://firebasestorage.googleapis.com/v0/b/${bucket}/o/{fileName}?alt=media";

        return imageUrl;

    }*/


    public async Task<string> UploadImageToFireBase(Stream imageStream, string fileName, string bucket)
    {


       

        var storage = new FirebaseStorage(bucket);

        var imageUrl = await storage.Child(fileName).PutAsync(imageStream);


        //string url =
        //   $"https://firebasestorage.googleapis.com/v0/b/${bucket}/o/{fileName}?alt=media";

        return imageUrl;

    }
  

    public async Task<string> GenerateCustomerTokenAsync()
    {
        var uid = "USs9vRXgl9Xav3PntxcPZLXvYLU2"; // Add as enviroment varable later
        
        var customToken = await FirebaseAuth.DefaultInstance.CreateCustomTokenAsync(uid.ToString());

        return customToken;
    }
}