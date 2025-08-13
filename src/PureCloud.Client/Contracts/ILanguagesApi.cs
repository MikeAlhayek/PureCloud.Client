using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ILanguagesApi
{
    /// <summary>
    /// Delete a language (Deprecated)
    /// </summary>
    Task<bool> DeleteLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a language (Deprecated)
    /// </summary>
    Task<Language> GetLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of languages (Deprecated)
    /// </summary>
    Task<LanguageEntityListing> GetLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get available translation languages
    /// </summary>
    Task<AvailableTranslations> GetLanguagesTranslationsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get built-in translations for a language
    /// </summary>
    Task<Dictionary<string, object>> GetLanguagesTranslationsBuiltinAsync(string language, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get organization translations for a language
    /// </summary>
    Task<Dictionary<string, object>> GetLanguagesTranslationsOrganizationAsync(string language, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get user translations for a specific user
    /// </summary>
    Task<Dictionary<string, object>> GetLanguagesTranslationsUserAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a language (Deprecated)
    /// </summary>
    Task<Language> PostLanguagesAsync(Language body, CancellationToken cancellationToken = default);
}
