using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class TokensApi : ITokensApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public TokensApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<TokenInfo> GetTokensMeAsync(bool? preserveIdleTTL = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var parameters = new NameValueCollection();
        
        if (preserveIdleTTL.HasValue)
        {
            parameters.Add("preserveIdleTTL", UriHelper.ParameterToString(preserveIdleTTL.Value));
        }

        var response = await client.GetAsync(UriHelper.GetUri("api/v2/tokens/me", parameters), cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TokenInfo>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTokenAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/tokens/{Uri.EscapeDataString(userId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<IdleTokenTimeout> UpdateTokensTimeoutAsync(IdleTokenTimeout body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/tokens/timeout", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdleTokenTimeout>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTokensMeAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/tokens/me", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<IdleTokenTimeout> GetTokensTimeoutAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/tokens/timeout", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdleTokenTimeout>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> HeadTokensMeAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/tokens/me";

        var request = new HttpRequestMessage(HttpMethod.Head, uri);

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }
}
