using NsiProjekat1Sdk.Application.Models;
using NsiProjekat1Sdk.Application.Models;
using NsiProjekat1Sdk.Sdk.Dto;

namespace NsiProjekat1Sdk.Application.Extensions;

public static class NsiProjekat1SdkResponseExtensions
{
    public static NsiProjekat1SdkProductCreateResponseModel ToModel(this NsiProjekat1SdkProductCreateResponseDto dto)
    {
        return new NsiProjekat1SdkProductCreateResponseModel(dto.Name, dto.Description, dto.CompanyName, dto.CompanyDescription);
    }
    
    
}
