using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ILanguagesApi
{
    Task<AvailableTranslations> GetLanguagesTranslationsAsync(CancellationToken cancellationToken = default);

    Task<Dictionary<string, object>> GetLanguagesTranslationsBuiltinAsync(string language, CancellationToken cancellationToken = default);

    Task<Dictionary<string, object>> GetLanguagesTranslationsOrganizationAsync(string language, CancellationToken cancellationToken = default);

    Task<Dictionary<string, object>> GetLanguagesTranslationsUserAsync(string userId, CancellationToken cancellationToken = default);
}