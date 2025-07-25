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
public sealed class TokensApi : ITokensApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public TokensApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options    = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<TokenInfo> GetTokensMeAsync(bool? preserveIdleTTL = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (preserveIdleTTL.HasValue)
        {
            parameters.Add("preserveIdleTTL", UriHelper.ParameterToString(preserveIdleTTL.Value));
        }

        var uri = UriHelper.GetUri("api/v2/tokens/me", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TokenInfo>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteTokenAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var uri = UriHelper.GetUri($"api/v2/tokens/{userId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<IdleTokenTimeout> UpdateTokensTimeoutAsync(IdleTokenTimeout body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/tokens/timeout", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdleTokenTimeout>(_options, cancellationToken);
    }
}