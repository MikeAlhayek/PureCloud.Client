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
public sealed class WorkforceManagementApi : IWorkforceManagementApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public WorkforceManagementApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<UserScheduleAdherence[]> GetAdherenceAsync(IEnumerable<string> userId, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(userId);

        var parameters = new NameValueCollection();
        
        foreach (var id in userId)
        {
            parameters.Add("userId", id);
        }

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/adherence", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserScheduleAdherence[]>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AdherenceExplanationAsyncResponse> CreateAdherenceExplanationAsync(AddAdherenceExplanationAgentRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/adherence/explanations", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AdherenceExplanationAsyncResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteBusinessUnitAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<AgentIntegrationsResponse> UpdateAgentIntegrationsHrisAsync(string agentId, AgentIntegrationsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/agents/{agentId}/integrations/hris", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentIntegrationsResponse>(_options, cancellationToken);
    }
}