using System.Net.Http.Json;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class AgentAssistantsApi : IAgentAssistantsApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public AgentAssistantsApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<Assistant> GetAssistantAsync(string assistantId, string expand = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/assistants/{assistantId}";
        if (!string.IsNullOrEmpty(expand))
        {
            url = QueryHelpers.AddQueryString(url, "expand", expand);
        }

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Assistant>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AssistantQueue> GetAssistantQueueAsync(string assistantId, string queueId, string expand = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/assistants/{assistantId}/queues/{queueId}";
        if (!string.IsNullOrEmpty(expand))
        {
            url = QueryHelpers.AddQueryString(url, "expand", expand);
        }

        var response = await client.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AssistantQueue>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AssistantQueueListing> GetAssistantQueuesAsync(string assistantId, string before = null, string after = null, string pageSize = null, string expand = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/assistants/{assistantId}/queues";

        var queryParams = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(before))
        {
            queryParams.Add("before", before);
        }

        if (!string.IsNullOrEmpty(after))
        {
            queryParams.Add("after", after);
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            queryParams.Add("pageSize", pageSize);
        }

        if (!string.IsNullOrEmpty(expand))
        {
            queryParams.Add("expand", expand);
        }

        if (queryParams.Count > 0)
        {
            url = QueryHelpers.AddQueryString(url, queryParams);
        }

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AssistantQueueListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AssistantListing> GetAssistantsAsync(string before = null, string after = null, string limit = null, string pageSize = null, string name = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/assistants";

        var queryParams = new Dictionary<string, string>();

        if (!string.IsNullOrEmpty(before))
        {
            queryParams.Add("before", before);
        }

        if (!string.IsNullOrEmpty(after))
        {
            queryParams.Add("after", after);
        }

        if (!string.IsNullOrEmpty(limit))
        {
            queryParams.Add("limit", limit);
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            queryParams.Add("pageSize", pageSize);
        }

        if (!string.IsNullOrEmpty(name))
        {
            queryParams.Add("name", name);
        }

        if (queryParams.Count > 0)
        {
            url = QueryHelpers.AddQueryString(url, queryParams);
        }

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AssistantListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AssistantQueueListing> GetAssistantsQueuesAsync(string before = "", string after = "", string pageSize = "", string queueIds = "", string expand = "", CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var url = "api/v2/assistants/queues";

        var queryParams = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(before))
        {
            queryParams.Add("before", before);
        }

        if (!string.IsNullOrEmpty(after))
        {
            queryParams.Add("after", after);
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            queryParams.Add("pageSize", pageSize);
        }

        if (!string.IsNullOrEmpty(queueIds))
        {
            queryParams.Add("queueIds", queueIds);
        }

        if (!string.IsNullOrEmpty(expand))
        {
            queryParams.Add("expand", expand);
        }

        if (queryParams.Count > 0)
        {
            url = QueryHelpers.AddQueryString(url, queryParams);
        }

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AssistantQueueListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Assistant> UpdateAssistantAsync(string assistantId, Assistant body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/assistants/{assistantId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Assistant>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AssistantQueueListing> UpdateAssistantQueuesAsync(string assistantId, List<AssistantQueue> body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/assistants/{assistantId}/queues", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AssistantQueueListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AssistantQueue> UpdateAssistantQueueAsync(string assistantId, string queueId, AssistantQueue body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/assistants/{assistantId}/queues/{queueId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AssistantQueue>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Assistant> CreateAssistantsAsync(Assistant body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/assistants", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Assistant>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> DeleteAssistantAsync(string assistantId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/assistants/{assistantId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAssistantQueueAsync(string assistantId, string queueId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/assistants/{assistantId}/queues/{queueId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAssistantQueuesAsync(string assistantId, string queueIds = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/assistants/{assistantId}/queues";

        if (!string.IsNullOrEmpty(queueIds))
        {
            url = QueryHelpers.AddQueryString(url, "queueIds", queueIds);
        }

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

}
