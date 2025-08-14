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
public sealed class TelephonyApi : ITelephonyApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public TelephonyApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<MediaRegions> GetMediaRegionsAsync(CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/telephony/mediaregions";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MediaRegions>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Callmessage> GetSipMessageAsync(string conversationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

        var uri = $"api/v2/telephony/sipmessages/conversations/{Uri.EscapeDataString(conversationId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Callmessage>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Callheader> GetSipHeadersAsync(string conversationId, IEnumerable<string> keys = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

        var parameters = new NameValueCollection();

        if (keys != null)
        {
            foreach (var key in keys)
            {
                parameters.Add("keys", UriHelper.ParameterToString(key));
            }
        }

        var uri = parameters.Count > 0 
            ? UriHelper.GetUri($"api/v2/telephony/sipmessages/conversations/{Uri.EscapeDataString(conversationId)}/headers", parameters)
            : $"api/v2/telephony/sipmessages/conversations/{Uri.EscapeDataString(conversationId)}/headers";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Callheader>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SipSearchResult> GetSipTracesAsync(DateTime dateStart, DateTime dateEnd, string callId = null, string toUser = null, string fromUser = null, string conversationId = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection
        {
            { "dateStart", UriHelper.ParameterToString(dateStart) },
            { "dateEnd", UriHelper.ParameterToString(dateEnd) }
        };

        if (!string.IsNullOrEmpty(callId))
        {
            parameters.Add("callId", UriHelper.ParameterToString(callId));
        }

        if (!string.IsNullOrEmpty(toUser))
        {
            parameters.Add("toUser", UriHelper.ParameterToString(toUser));
        }

        if (!string.IsNullOrEmpty(fromUser))
        {
            parameters.Add("fromUser", UriHelper.ParameterToString(fromUser));
        }

        if (!string.IsNullOrEmpty(conversationId))
        {
            parameters.Add("conversationId", UriHelper.ParameterToString(conversationId));
        }

        var uri = UriHelper.GetUri("api/v2/telephony/siptraces", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SipSearchResult>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SignedUrlResponse> GetSipTraceDownloadAsync(string downloadId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(downloadId);

        var uri = $"api/v2/telephony/siptraces/download/{Uri.EscapeDataString(downloadId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SignedUrlResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SipDownloadResponse> CreateSipTraceDownloadAsync(SIPSearchPublicRequest request, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);

        var uri = "api/v2/telephony/siptraces/download";

        var response = await _httpClient.PostAsJsonAsync(uri, request, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SipDownloadResponse>(_options, cancellationToken);
    }
}