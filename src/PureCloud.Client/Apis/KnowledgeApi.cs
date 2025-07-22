using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class KnowledgeApi : IKnowledgeApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public KnowledgeApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<KnowledgeBase> GetKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBase>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeBase> CreateKnowledgeKnowledgebasesAsync(KnowledgeBaseCreateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/knowledge/knowledgebases", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBase>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SalesforceSourceResponse> UpdateKnowledgeKnowledgebaseSourcesSalesforceSourceAsync(string knowledgeBaseId, string sourceId, SalesforceSourceRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(sourceId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/salesforce/{sourceId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SalesforceSourceResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeBase> DeleteKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBase>(_options, cancellationToken);
    }
}