namespace Vcommerce.Services.ApiServices.FireBaseApiService.Interfaces;

public interface IFireBaseApiService
{
    public Task<string> UploadImageToFireBase(Stream imageStream, string fileName,string bucket);

    public Task<string> GenerateCustomerTokenAsync();
}