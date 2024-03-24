using NsiProjekat1Sdk.Sdk.Dto;

namespace NsiProjekat1Sdk.Application.Models;

public record NsiProjekat1SdkCompanyRequestModel(string Name, string BaseUrl, IDictionary<string, string> Headers)
{
    public NsiProjekat1SdkCompanyRequestDto ToDto()
    {
        return new NsiProjekat1SdkCompanyRequestDto(new NsiProjekat1SdkCompanyCreateDto(
            Name,
            Name + " Company"));
    }
}