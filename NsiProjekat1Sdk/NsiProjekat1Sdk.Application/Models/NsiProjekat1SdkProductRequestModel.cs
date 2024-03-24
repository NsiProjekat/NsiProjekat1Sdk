using NsiProjekat1Sdk.Sdk.Dto;

namespace NsiProjekat1Sdk.Application.Models;

public record NsiProjekat1SdkProductRequestModel(Guid CompanyId, string Name,string Description, string BaseUrl, IDictionary<string, string> Headers)
{
    public NsiProjekat1SdkProductRequestDto ToDto()
    {
        return new NsiProjekat1SdkProductRequestDto(new NsiProjekat1SdkProductCreateDto(CompanyId,
            Name,
            Description));
    }
}