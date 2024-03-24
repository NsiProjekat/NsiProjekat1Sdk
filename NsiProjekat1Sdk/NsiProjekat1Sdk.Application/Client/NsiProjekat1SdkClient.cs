using NsiProjekat1Sdk.Application.Extensions;
using NsiProjekat1Sdk.Application.Models;
using NsiProjekat1Sdk.Sdk;

namespace NsiProjekat1Sdk.Application.Client;

public class NsiProjekat1SdkClient(INsiProjekat1SdkApi api) : INsiProjekat1SdkClient
{
    public async Task<NsiProjekat1SdkProductCreateResponseModel> CreateProductAsync(NsiProjekat1SdkProductRequestModel request)
    {
        var result = await api.CreateProductAsync(request.ToDto(), request.Headers);
        return result.ToModel();
    }
    
    
}