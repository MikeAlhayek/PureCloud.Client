using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public sealed class OutboundApi : IOutboundApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public OutboundApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<AttemptLimits> GetOutboundAttemptlimitAsync(string attemptLimitsId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(attemptLimitsId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/attemptlimits/{attemptLimitsId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AttemptLimits>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AttemptLimitsEntityListing> GetOutboundAttemptlimitsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (allowEmptyResult.HasValue)
        {
            parameters.Add("allowEmptyResult", UriHelper.ParameterToString(allowEmptyResult.Value));
        }

        if (!string.IsNullOrEmpty(filterType))
        {
            parameters.Add("filterType", UriHelper.ParameterToString(filterType));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/outbound/attemptlimits", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AttemptLimitsEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AttemptLimits> CreateOutboundAttemptlimitAsync(AttemptLimits body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/attemptlimits", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AttemptLimits>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AttemptLimits> UpdateOutboundAttemptlimitAsync(string attemptLimitsId, AttemptLimits body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(attemptLimitsId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/attemptlimits/{attemptLimitsId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AttemptLimits>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task DeleteOutboundAttemptlimitAsync(string attemptLimitsId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(attemptLimitsId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/attemptlimits/{attemptLimitsId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<CallableTimeSet> GetOutboundCallabletimesetAsync(string callableTimeSetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(callableTimeSetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/callabletimesets/{Uri.EscapeDataString(callableTimeSetId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CallableTimeSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CallableTimeSetEntityListing> GetOutboundCallabletimesetsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (allowEmptyResult.HasValue)
        {
            parameters.Add("allowEmptyResult", UriHelper.ParameterToString(allowEmptyResult.Value));
        }

        if (!string.IsNullOrEmpty(filterType))
        {
            parameters.Add("filterType", UriHelper.ParameterToString(filterType));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/outbound/callabletimesets", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CallableTimeSetEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CallableTimeSet> CreateOutboundCallabletimesetAsync(CallableTimeSet body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/callabletimesets", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CallableTimeSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CallableTimeSet> UpdateOutboundCallabletimesetAsync(string callableTimeSetId, CallableTimeSet body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(callableTimeSetId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/callabletimesets/{Uri.EscapeDataString(callableTimeSetId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CallableTimeSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task DeleteOutboundCallabletimesetAsync(string callableTimeSetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(callableTimeSetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/callabletimesets/{Uri.EscapeDataString(callableTimeSetId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<Campaign> GetOutboundCampaignAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/campaigns/{Uri.EscapeDataString(campaignId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Campaign>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignEntityListing> GetOutboundCampaignsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, List<string> id = null, string contactListId = null, string dncListIds = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, List<string> divisionId = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (!string.IsNullOrEmpty(filterType))
        {
            parameters.Add("filterType", filterType);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (id != null && id.Count > 0)
        {
            foreach (var item in id)
            {
                parameters.Add("id", item);
            }
        }

        if (!string.IsNullOrEmpty(contactListId))
        {
            parameters.Add("contactListId", contactListId);
        }

        if (!string.IsNullOrEmpty(dncListIds))
        {
            parameters.Add("dncListIds", dncListIds);
        }

        if (!string.IsNullOrEmpty(distributionQueueId))
        {
            parameters.Add("distributionQueueId", distributionQueueId);
        }

        if (!string.IsNullOrEmpty(edgeGroupId))
        {
            parameters.Add("edgeGroupId", edgeGroupId);
        }

        if (!string.IsNullOrEmpty(callAnalysisResponseSetId))
        {
            parameters.Add("callAnalysisResponseSetId", callAnalysisResponseSetId);
        }

        if (divisionId != null && divisionId.Count > 0)
        {
            foreach (var item in divisionId)
            {
                parameters.Add("divisionId", item);
            }
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        var uri = UriHelper.GetUri("api/v2/outbound/campaigns", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Campaign> CreateOutboundCampaignAsync(Campaign body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/campaigns", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Campaign>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Campaign> UpdateOutboundCampaignAsync(string campaignId, Campaign body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/campaigns/{Uri.EscapeDataString(campaignId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Campaign>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task DeleteOutboundCampaignAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/campaigns/{Uri.EscapeDataString(campaignId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<ResponseSet> GetOutboundCallanalysisresponsesetAsync(string callAnalysisSetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(callAnalysisSetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/callanalysisresponsesets/{Uri.EscapeDataString(callAnalysisSetId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ResponseSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ResponseSetEntityListing> GetOutboundCallanalysisresponsesetsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (allowEmptyResult.HasValue)
        {
            parameters.Add("allowEmptyResult", UriHelper.ParameterToString(allowEmptyResult.Value));
        }

        if (!string.IsNullOrEmpty(filterType))
        {
            parameters.Add("filterType", filterType);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        var uri = UriHelper.GetUri("api/v2/outbound/callanalysisresponsesets", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ResponseSetEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ResponseSet> CreateOutboundCallanalysisresponsesetAsync(ResponseSet body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/callanalysisresponsesets", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ResponseSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ResponseSet> UpdateOutboundCallanalysisresponsesetAsync(string callAnalysisSetId, ResponseSet body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(callAnalysisSetId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/callanalysisresponsesets/{Uri.EscapeDataString(callAnalysisSetId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ResponseSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task DeleteOutboundCallanalysisresponsesetAsync(string callAnalysisSetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(callAnalysisSetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/callanalysisresponsesets/{Uri.EscapeDataString(callAnalysisSetId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}