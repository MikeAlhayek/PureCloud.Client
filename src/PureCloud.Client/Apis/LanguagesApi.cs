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
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public LanguagesApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<AvailableTranslations> GetLanguagesTranslationsAsync(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("api/v2/languages/translations", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AvailableTranslations>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Dictionary<string, object>> GetLanguagesTranslationsBuiltinAsync(string language, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(language, nameof(language));

        var parameters = new NameValueCollection { { "language", language } };

        var uri = UriHelper.GetUri("api/v2/languages/translations/builtin", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Dictionary<string, object>>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Dictionary<string, object>> GetLanguagesTranslationsOrganizationAsync(string language, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(language, nameof(language));

        var parameters = new NameValueCollection { { "language", language } };

        var uri = UriHelper.GetUri("api/v2/languages/translations/organization", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Dictionary<string, object>>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Dictionary<string, object>> GetLanguagesTranslationsUserAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId, nameof(userId));

        var response = await _httpClient.GetAsync($"api/v2/languages/translations/users/{userId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Dictionary<string, object>>(_options, cancellationToken);
    }
}
