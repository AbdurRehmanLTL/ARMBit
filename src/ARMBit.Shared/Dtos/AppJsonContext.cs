using ARMBit.Shared.Dtos.Categories;
using ARMBit.Shared.Dtos.Dashboard;
using ARMBit.Shared.Dtos.Products;
using ARMBit.Shared.Dtos.Identity;

namespace ARMBit.Shared.Dtos;

/// <summary>
/// https://devblogs.microsoft.com/dotnet/try-the-new-system-text-json-source-generator/
/// </summary>
[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
[JsonSerializable(typeof(Dictionary<string, object>))]
[JsonSerializable(typeof(UserDto))]
[JsonSerializable(typeof(ProductsCountPerCategoryResponseDto))]
[JsonSerializable(typeof(OverallAnalyticsStatsDataResponseDto))]
[JsonSerializable(typeof(ProductSaleStatResponseDto))]
[JsonSerializable(typeof(ProductPercentagePerCategoryResponseDto))]
[JsonSerializable(typeof(ProductDto))]
[JsonSerializable(typeof(PagedResult<ProductDto>))]
[JsonSerializable(typeof(CategoryDto))]
[JsonSerializable(typeof(PagedResult<CategoryDto>))]
[JsonSerializable(typeof(SignInRequestDto))]
[JsonSerializable(typeof(TokenResponseDto))]
[JsonSerializable(typeof(RefreshRequestDto))]
[JsonSerializable(typeof(SignUpRequestDto))]
[JsonSerializable(typeof(EditUserDto))]
[JsonSerializable(typeof(RestErrorInfo))]
[JsonSerializable(typeof(SendConfirmationEmailRequestDto))]
[JsonSerializable(typeof(ConfirmEmailRequestDto))]
[JsonSerializable(typeof(SendResetPasswordEmailRequestDto))]
[JsonSerializable(typeof(ResetPasswordRequestDto))]
public partial class AppJsonContext : JsonSerializerContext
{
}
