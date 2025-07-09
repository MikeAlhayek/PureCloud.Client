using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class AuditApi : IAuditApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public AuditApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }


    public async Task<AuditQueryServiceMapping> GetAuditsQueryRealtimeServicemappingAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri("api/v2/audits/query/realtime/servicemapping", null);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuditQueryServiceMapping>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuditQueryServiceMapping> GetAuditsQueryServicemappingAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = UriHelper.GetUri("api/v2/audits/query/servicemapping", null);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuditQueryServiceMapping>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuditQueryExecutionStatusResponse> GetAuditsQueryTransactionIdAsync(string transactionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(transactionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var requestUri = UriHelper.GetUri($"api/v2/audits/query/{transactionId}", null);

        var response = await client.GetAsync(requestUri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuditQueryExecutionStatusResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuditQueryExecutionResultsResponse> GetAuditsQueryTransactionIdResultsAsync(string transactionId, string cursor = null, int? pageSize = null, IList<string> expand = null, bool? allowRedirect = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(transactionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var parametersDictionary = new Dictionary<string, string>
        {
            ["cursor"] = cursor,
            ["pageSize"] = pageSize?.ToString(),
            ["allowRedirect"] = allowRedirect.HasValue ? allowRedirect.Value.ToString().ToLowerInvariant() : null
        };

        foreach (var items in parametersDictionary)
        {
            if (items.Value != null)
            {
                parameters.Add(items.Key, items.Value);
            }
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", item);
            }
        }

        var url = UriHelper.GetUri($"api/v2/audits/query/{transactionId}/results", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuditQueryExecutionResultsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuditQueryExecutionStatusResponse> PostAuditsQueryAsync(AuditQueryRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/audits/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuditQueryExecutionStatusResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuditRealtimeQueryResultsResponse> PostAuditsQueryRealtimeAsync(AuditRealtimeQueryRequest body, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", item);
            }
        }

        var uri = UriHelper.GetUri("api/v2/audits/query/realtime", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuditRealtimeQueryResultsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AuditRealtimeRelatedResultsResponse> CreateAuditsQueryRealtimeRelatedAsync(AuditRealtimeRelatedRequest body, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", item);
            }
        }

        var requestUri = UriHelper.GetUri("api/v2/audits/query/realtime/related", parameters);

        var response = await client.PostAsJsonAsync(requestUri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuditRealtimeRelatedResultsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

}
