using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ILanguagesApi
{
    /// <summary>
    /// Delete a language (Deprecated)
    /// </summary>
    /// <param name="languageId">The language ID to delete</param>
    /// <param name="cancellationToken">Cancellation token to cancel the operation</param>
    /// <returns>True if the deletion was successful</returns>
    Task<bool> DeleteLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a language (Deprecated)
    /// </summary>
    /// <param name="languageId">The language ID to retrieve</param>
    /// <param name="cancellationToken">Cancellation token to cancel the operation</param>
    /// <returns>The language entity</returns>
    Task<Language> GetLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of languages (Deprecated)
    /// </summary>
    /// <param name="pageSize">The page size for pagination</param>
    /// <param name="pageNumber">The page number for pagination</param>
    /// <param name="sortOrder">The sort order for the results</param>
    /// <param name="name">The name filter for languages</param>
    /// <param name="cancellationToken">Cancellation token to cancel the operation</param>
    /// <returns>A list of languages</returns>
    Task<LanguageEntityListing> GetLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get available translation languages
    /// </summary>
    /// <param name="cancellationToken">Cancellation token to cancel the operation</param>
    /// <returns>Available translations</returns>
    Task<AvailableTranslations> GetLanguagesTranslationsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get built-in translations for a language
    /// </summary>
    /// <param name="language">The language code to get built-in translations for</param>
    /// <param name="cancellationToken">Cancellation token to cancel the operation</param>
    /// <returns>Dictionary of built-in translations</returns>
    Task<Dictionary<string, object>> GetLanguagesTranslationsBuiltinAsync(string language, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get organization translations for a language
    /// </summary>
    /// <param name="language">The language code to get organization translations for</param>
    /// <param name="cancellationToken">Cancellation token to cancel the operation</param>
    /// <returns>Dictionary of organization translations</returns>
    Task<Dictionary<string, object>> GetLanguagesTranslationsOrganizationAsync(string language, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get user translations for a specific user
    /// </summary>
    /// <param name="userId">The user ID to get translations for</param>
    /// <param name="cancellationToken">Cancellation token to cancel the operation</param>
    /// <returns>Dictionary of user translations</returns>
    Task<Dictionary<string, object>> GetLanguagesTranslationsUserAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a language (Deprecated)
    /// </summary>
    /// <param name="body">The language object to create</param>
    /// <param name="cancellationToken">Cancellation token to cancel the operation</param>
    /// <returns>The created language entity</returns>
    Task<Language> PostLanguagesAsync(Language body, CancellationToken cancellationToken = default);
}
