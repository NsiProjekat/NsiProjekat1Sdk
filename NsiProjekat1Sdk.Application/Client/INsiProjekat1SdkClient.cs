using NsiProjekat1Sdk.Application.Models;

namespace NsiProjekat1Sdk.Application.Client;

public interface INsiProjekat1SdkClient
{
    public Task<NsiProjekat1SdkProductCreateResponseModel> CreateProductAsync(NsiProjekat1SdkProductRequestModel request);
    
    public Task<NsiProjekat1SdkCompanyCreateResponseModel> CreateCompanyAsync(NsiProjekat1SdkCompanyRequestModel request);
    
}
