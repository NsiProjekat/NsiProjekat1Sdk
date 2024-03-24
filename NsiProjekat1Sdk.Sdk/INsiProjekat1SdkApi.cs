using NsiProjekat1Sdk.Sdk.Dto;
using Refit;

namespace NsiProjekat1Sdk.Sdk;

public interface INsiProjekat1SdkApi
{
    [Post("/webhook/ProductWebhook/Create")]
    public Task<NsiProjekat1SdkProductCreateResponseDto> CreateProductAsync(NsiProjekat1SdkProductRequestDto request, [HeaderCollection] IDictionary<string, string> headers);
    
}