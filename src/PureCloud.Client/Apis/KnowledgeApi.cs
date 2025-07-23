using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class KnowledgeApi : IKnowledgeApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public KnowledgeApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <summary>
    /// Get knowledge base
    /// URL: /api/v2/knowledge/knowledgebases/{knowledgeBaseId}
    /// </summary>
    public async Task<KnowledgeBase> GetKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// Create new knowledge base
    /// URL: /api/v2/knowledge/knowledgebases
    /// </summary>
    public async Task<KnowledgeBase> PostKnowledgeKnowledgebasesAsync(KnowledgeBaseCreateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/knowledge/knowledgebases", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// Update Salesforce Knowledge integration source
    /// URL: /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/salesforce/{sourceId}
    /// </summary>
    public async Task<SalesforceSourceResponse> PutKnowledgeKnowledgebaseSourcesSalesforceSourceIdAsync(string knowledgeBaseId, string sourceId, SalesforceSourceRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(sourceId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/salesforce/{sourceId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SalesforceSourceResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// Delete knowledge base
    /// URL: /api/v2/knowledge/knowledgebases/{knowledgeBaseId}
    /// </summary>
    public async Task<KnowledgeBase> DeleteKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBase>(_options.JsonSerializerOptions, cancellationToken);
    }
}