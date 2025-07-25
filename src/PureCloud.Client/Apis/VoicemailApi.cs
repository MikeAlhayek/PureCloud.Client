using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public sealed class VoicemailApi : IVoicemailApi
{
    private readonly HttpClient _httpClient;
    private readonly PureCloudJsonSerializerOptions _options;

    public VoicemailApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<VoicemailMessage> GetVoicemailMessageAsync(string messageId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messageId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var uri = UriHelper.GetUri($"api/v2/voicemail/messages/{messageId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMessage>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteVoicemailMessageAsync(string messageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messageId);

        var uri = UriHelper.GetUri($"api/v2/voicemail/messages/{messageId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<VoicemailMailboxInfo> GetVoicemailMailboxAsync(CancellationToken cancellationToken = default)
    {
        var uri = UriHelper.GetUri("api/v2/voicemail/mailbox", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailMailboxInfo>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailUserPolicy> PatchVoicemailMePolicyAsync(VoicemailUserPolicy body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/voicemail/me/policy", null);

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailUserPolicy>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<VoicemailsSearchResponse> SearchVoicemailsAsync(VoicemailSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/voicemail/search", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<VoicemailsSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }
}
