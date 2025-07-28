using System.Collections.Specialized;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class LanguagesApi : ILanguagesApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public LanguagesApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    [Obsolete("This endpoint is deprecated. Please see the Routing API (DELETE /api/v2/routing/languages/{languageId})")]
    public async Task DeleteLanguageAsync(string languageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(languageId, nameof(languageId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/languages/{languageId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    [Obsolete("This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages/{languageId})")]
    public async Task<Language> GetLanguageAsync(string languageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(languageId, nameof(languageId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/languages/{languageId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Language>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    [Obsolete("This endpoint is deprecated. Please see the Routing API (GET /api/v2/routing/languages)")]
    public async Task<LanguageEntityListing> GetLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();
        
        var parameterMappings = new Dictionary<string, object>
        {
            { "pageSize", pageSize?.ToString() },
            { "pageNumber", pageNumber?.ToString() },
            { "sortOrder", sortOrder },
            { "name", name }
        };

        foreach (var (key, value) in parameterMappings)
        {
            if (!string.IsNullOrEmpty(value?.ToString()))
                parameters.Add(key, value.ToString());
        }

        var uri = UriHelper.GetUri("api/v2/languages", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LanguageEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AvailableTranslations> GetLanguagesTranslationsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/languages/translations", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AvailableTranslations>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Dictionary<string, object>> GetLanguagesTranslationsBuiltinAsync(string language, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(language, nameof(language));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection { { "language", language } };

        var uri = UriHelper.GetUri("api/v2/languages/translations/builtin", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Dictionary<string, object>>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Dictionary<string, object>> GetLanguagesTranslationsOrganizationAsync(string language, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(language, nameof(language));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection { { "language", language } };

        var uri = UriHelper.GetUri("api/v2/languages/translations/organization", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Dictionary<string, object>>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Dictionary<string, object>> GetLanguagesTranslationsUserAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId, nameof(userId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/languages/translations/users/{userId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Dictionary<string, object>>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    [Obsolete("This endpoint is deprecated. Please see the Routing API. (POST /api/v2/routing/languages)")]
    public async Task<Language> PostLanguagesAsync(Language body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/languages", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Language>(_options.JsonSerializerOptions, cancellationToken);
    }
}
