using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ILanguagesApi
{
    [Obsolete("This endpoint is deprecated. Please see the Routing API (DELETE /api/v2/routing/languages/{languageId})")]
    Task DeleteLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    [Obsolete("This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages/{languageId})")]
    Task<Language> GetLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    [Obsolete("This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages)")]
    Task<LanguageEntityListing> GetLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    Task<AvailableTranslations> GetLanguagesTranslationsAsync(CancellationToken cancellationToken = default);

    Task<Dictionary<string, object>> GetLanguagesTranslationsBuiltinAsync(string language, CancellationToken cancellationToken = default);

    Task<Dictionary<string, object>> GetLanguagesTranslationsOrganizationAsync(string language, CancellationToken cancellationToken = default);

    Task<Dictionary<string, object>> GetLanguagesTranslationsUserAsync(string userId, CancellationToken cancellationToken = default);

    [Obsolete("This endpoint is deprecated. Please see the Routing API. (POST /api/v2/routing/languages)")]
    Task<Language> PostLanguagesAsync(Language body, CancellationToken cancellationToken = default);
}
