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

    public async Task DeleteOutboundCampaignProgressAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/campaigns/{Uri.EscapeDataString(campaignId)}/progress", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundCampaignruleAsync(string campaignRuleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignRuleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/campaignrules/{Uri.EscapeDataString(campaignRuleId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundContactlistAsync(string contactListId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/contactlists/{Uri.EscapeDataString(contactListId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundContactlistContactAsync(string contactListId, string contactId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/contactlists/{Uri.EscapeDataString(contactListId)}/contacts/{Uri.EscapeDataString(contactId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundContactlistContactsAsync(string contactListId, List<string> contactIds, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);
        ArgumentNullException.ThrowIfNull(contactIds);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/outbound/contactlists/{Uri.EscapeDataString(contactListId)}/contacts/bulk/delete", contactIds, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundContactlistfilterAsync(string contactListFilterId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListFilterId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/contactlistfilters/{Uri.EscapeDataString(contactListFilterId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundContactlistsAsync(List<string> id, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/contactlists/bulk/delete", id, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundContactlisttemplateAsync(string contactListTemplateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListTemplateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/contactlisttemplates/{Uri.EscapeDataString(contactListTemplateId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundContactlisttemplatesAsync(List<string> id, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/contactlisttemplates/bulk/delete", id, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundDigitalrulesetAsync(string digitalRuleSetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(digitalRuleSetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/digitalrulesets/{Uri.EscapeDataString(digitalRuleSetId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundDnclistAsync(string dncListId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/dnclists/{Uri.EscapeDataString(dncListId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundDnclistCustomexclusioncolumnsAsync(string dncListId, bool? expiredOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);

        var parameters = new NameValueCollection();

        if (expiredOnly.HasValue)
        {
            parameters.Add("expiredOnly", UriHelper.ParameterToString(expiredOnly.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/dnclists/{Uri.EscapeDataString(dncListId)}/customexclusioncolumns", parameters);
        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundDnclistEmailaddressesAsync(string dncListId, bool? expiredOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);

        var parameters = new NameValueCollection();

        if (expiredOnly.HasValue)
        {
            parameters.Add("expiredOnly", UriHelper.ParameterToString(expiredOnly.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/dnclists/{Uri.EscapeDataString(dncListId)}/emailaddresses", parameters);
        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundDnclistPhonenumbersAsync(string dncListId, bool? expiredOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);

        var parameters = new NameValueCollection();

        if (expiredOnly.HasValue)
        {
            parameters.Add("expiredOnly", UriHelper.ParameterToString(expiredOnly.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/dnclists/{Uri.EscapeDataString(dncListId)}/phonenumbers", parameters);
        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundDnclistWhatsappnumbersAsync(string dncListId, bool? expiredOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);

        var parameters = new NameValueCollection();

        if (expiredOnly.HasValue)
        {
            parameters.Add("expiredOnly", UriHelper.ParameterToString(expiredOnly.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/dnclists/{Uri.EscapeDataString(dncListId)}/whatsappnumbers", parameters);
        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundFilespecificationtemplateAsync(string fileSpecificationTemplateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(fileSpecificationTemplateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/filespecificationtemplates/{Uri.EscapeDataString(fileSpecificationTemplateId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundFilespecificationtemplatesBulkAsync(List<string> id, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/filespecificationtemplates/bulk/delete", id, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundImporttemplateAsync(string importTemplateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(importTemplateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/importtemplates/{Uri.EscapeDataString(importTemplateId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundImporttemplatesAsync(List<string> id, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/importtemplates/bulk/delete", id, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    // TODO: Fix MessagingCampaign model reference
    /*
    public async Task<MessagingCampaign> DeleteOutboundMessagingcampaignAsync(string messagingCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/messagingcampaigns/{Uri.EscapeDataString(messagingCampaignId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MessagingCampaign>(_options.JsonSerializerOptions, cancellationToken);
    }
    */

    public async Task DeleteOutboundMessagingcampaignProgressAsync(string messagingCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/messagingcampaigns/{Uri.EscapeDataString(messagingCampaignId)}/progress", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundRulesetAsync(string ruleSetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(ruleSetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/rulesets/{Uri.EscapeDataString(ruleSetId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundSchedulesCampaignAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/schedules/campaigns/{Uri.EscapeDataString(campaignId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundSchedulesEmailcampaignAsync(string emailCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(emailCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/schedules/emailcampaigns/{Uri.EscapeDataString(emailCampaignId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundSchedulesMessagingcampaignAsync(string messagingCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/schedules/messagingcampaigns/{Uri.EscapeDataString(messagingCampaignId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundSchedulesSequenceAsync(string sequenceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sequenceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/schedules/sequences/{Uri.EscapeDataString(sequenceId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteOutboundSequenceAsync(string sequenceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sequenceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/sequences/{Uri.EscapeDataString(sequenceId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    // TODO: Add remaining GET methods - some model types need to be resolved first
    // Temporarily commenting out methods with missing model references
    
    /*
    public async Task<AgentOwnedMappingPreviewListing> GetOutboundCampaignAgentownedmappingpreviewResultsAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/campaigns/{Uri.EscapeDataString(campaignId)}/agentownedmappingpreview/results", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentOwnedMappingPreviewListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignDiagnostics> GetOutboundCampaignDiagnosticsAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/campaigns/{Uri.EscapeDataString(campaignId)}/diagnostics", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignDiagnostics>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignInteractions> GetOutboundCampaignInteractionsAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/campaigns/{Uri.EscapeDataString(campaignId)}/interactions", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignInteractions>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignOutboundLinesDistribution> GetOutboundCampaignLinedistributionAsync(string campaignId, bool? includeOnlyActiveCampaigns = null, string edgeGroupId = null, string siteId = null, bool? useWeight = null, int? relativeWeight = null, int? outboundLineCount = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var parameters = new NameValueCollection();

        if (includeOnlyActiveCampaigns.HasValue)
        {
            parameters.Add("includeOnlyActiveCampaigns", UriHelper.ParameterToString(includeOnlyActiveCampaigns.Value));
        }

        if (!string.IsNullOrEmpty(edgeGroupId))
        {
            parameters.Add("edgeGroupId", UriHelper.ParameterToString(edgeGroupId));
        }

        if (!string.IsNullOrEmpty(siteId))
        {
            parameters.Add("siteId", UriHelper.ParameterToString(siteId));
        }

        if (useWeight.HasValue)
        {
            parameters.Add("useWeight", UriHelper.ParameterToString(useWeight.Value));
        }

        if (relativeWeight.HasValue)
        {
            parameters.Add("relativeWeight", UriHelper.ParameterToString(relativeWeight.Value));
        }

        if (outboundLineCount.HasValue)
        {
            parameters.Add("outboundLineCount", UriHelper.ParameterToString(outboundLineCount.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/campaigns/{Uri.EscapeDataString(campaignId)}/linedistribution", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignOutboundLinesDistribution>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignProgress> GetOutboundCampaignProgressAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/campaigns/{Uri.EscapeDataString(campaignId)}/progress", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignProgress>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PagedSkillCombinationListing> GetOutboundCampaignSkillcombinationsAsync(string campaignId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/campaigns/{Uri.EscapeDataString(campaignId)}/skillcombinations", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PagedSkillCombinationListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignStats> GetOutboundCampaignStatsAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/campaigns/{Uri.EscapeDataString(campaignId)}/stats", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignStats>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignRule> GetOutboundCampaignruleAsync(string campaignRuleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignRuleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/campaignrules/{Uri.EscapeDataString(campaignRuleId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignRule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignRuleEntityListing> GetOutboundCampaignrulesAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri("api/v2/outbound/campaignrules", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignRuleEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CommonCampaignEntityListing> GetOutboundCampaignsAllAsync(int? pageSize = null, int? pageNumber = null, List<string> id = null, string name = null, List<string> divisionId = null, List<string> mediaType = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (id != null && id.Count > 0)
        {
            foreach (var item in id)
            {
                parameters.Add("id", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (divisionId != null && divisionId.Count > 0)
        {
            foreach (var item in divisionId)
            {
                parameters.Add("divisionId", UriHelper.ParameterToString(item));
            }
        }

        if (mediaType != null && mediaType.Count > 0)
        {
            foreach (var item in mediaType)
            {
                parameters.Add("mediaType", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/outbound/campaigns/all", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CommonCampaignEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CommonCampaignDivisionViewEntityListing> GetOutboundCampaignsAllDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, List<string> id = null, string name = null, List<string> divisionId = null, List<string> mediaType = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (id != null && id.Count > 0)
        {
            foreach (var item in id)
            {
                parameters.Add("id", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (divisionId != null && divisionId.Count > 0)
        {
            foreach (var item in divisionId)
            {
                parameters.Add("divisionId", UriHelper.ParameterToString(item));
            }
        }

        if (mediaType != null && mediaType.Count > 0)
        {
            foreach (var item in mediaType)
            {
                parameters.Add("mediaType", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/outbound/campaigns/all/divisionviews", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CommonCampaignDivisionViewEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }
    */

    // TODO: Add missing GET methods - temporarily commented due to model dependencies
    // Will need to add CommonCampaignDivisionView, ContactList, DialerContact and related models

    // Working POST methods using existing models
    public async Task<AttemptLimits> PostOutboundAttemptlimitsAsync(AttemptLimits body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/attemptlimits", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AttemptLimits>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CallableTimeSet> PostOutboundCallabletimesetsAsync(CallableTimeSet body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/callabletimesets", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CallableTimeSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ResponseSet> PostOutboundCallanalysisresponsesetsAsync(ResponseSet body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/callanalysisresponsesets", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ResponseSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    // Working PUT methods using existing models
    public async Task<AttemptLimits> PutOutboundAttemptlimitAsync(string attemptLimitsId, AttemptLimits body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(attemptLimitsId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/attemptlimits/{Uri.EscapeDataString(attemptLimitsId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AttemptLimits>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CallableTimeSet> PutOutboundCallabletimesetAsync(string callableTimeSetId, CallableTimeSet body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(callableTimeSetId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/callabletimesets/{Uri.EscapeDataString(callableTimeSetId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CallableTimeSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ResponseSet> PutOutboundCallanalysisresponsesetAsync(string callAnalysisSetId, ResponseSet body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(callAnalysisSetId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/callanalysisresponsesets/{Uri.EscapeDataString(callAnalysisSetId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ResponseSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    // GET methods for ContactLists operations
    public async Task<ContactListEntityListing> GetOutboundContactlistsAsync(bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, List<string> id = null, List<string> divisionId = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (includeImportStatus.HasValue)
        {
            parameters.Add("includeImportStatus", UriHelper.ParameterToString(includeImportStatus.Value));
        }

        if (includeSize.HasValue)
        {
            parameters.Add("includeSize", UriHelper.ParameterToString(includeSize.Value));
        }

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

        if (id != null && id.Count > 0)
        {
            foreach (var item in id)
            {
                parameters.Add("id", UriHelper.ParameterToString(item));
            }
        }

        if (divisionId != null && divisionId.Count > 0)
        {
            foreach (var item in divisionId)
            {
                parameters.Add("divisionId", UriHelper.ParameterToString(item));
            }
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

        var uri = UriHelper.GetUri("api/v2/outbound/contactlists", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListFilter> GetOutboundContactlistfilterAsync(string contactListFilterId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListFilterId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/contactlistfilters/{Uri.EscapeDataString(contactListFilterId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListFilter>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListFilterEntityListing> GetOutboundContactlistfiltersAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, string contactListId = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(contactListId))
        {
            parameters.Add("contactListId", UriHelper.ParameterToString(contactListId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/outbound/contactlistfilters", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListFilterEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListTemplate> GetOutboundContactlisttemplateAsync(string contactListTemplateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListTemplateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/contactlisttemplates/{Uri.EscapeDataString(contactListTemplateId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListTemplate>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListTemplateEntityListing> GetOutboundContactlisttemplatesAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri("api/v2/outbound/contactlisttemplates", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListTemplateEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    // GET methods for DigitalRuleset operations  
    public async Task<DigitalRuleSet> GetOutboundDigitalrulesetAsync(string digitalRuleSetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(digitalRuleSetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/digitalrulesets/{Uri.EscapeDataString(digitalRuleSetId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DigitalRuleSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DigitalRuleSetEntityListing> GetOutboundDigitalrulesetsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri("api/v2/outbound/digitalrulesets", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DigitalRuleSetEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    // GET methods for DncList operations
    public async Task<DncList> GetOutboundDnclistAsync(string dncListId, bool? includeImportStatus = null, bool? includeSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);

        var parameters = new NameValueCollection();

        if (includeImportStatus.HasValue)
        {
            parameters.Add("includeImportStatus", UriHelper.ParameterToString(includeImportStatus.Value));
        }

        if (includeSize.HasValue)
        {
            parameters.Add("includeSize", UriHelper.ParameterToString(includeSize.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/dnclists/{Uri.EscapeDataString(dncListId)}", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DncList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DncListEntityListing> GetOutboundDnclistsAsync(bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string dncSourceType = null, List<string> divisionId = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (includeImportStatus.HasValue)
        {
            parameters.Add("includeImportStatus", UriHelper.ParameterToString(includeImportStatus.Value));
        }

        if (includeSize.HasValue)
        {
            parameters.Add("includeSize", UriHelper.ParameterToString(includeSize.Value));
        }

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

        if (!string.IsNullOrEmpty(dncSourceType))
        {
            parameters.Add("dncSourceType", UriHelper.ParameterToString(dncSourceType));
        }

        if (divisionId != null && divisionId.Count > 0)
        {
            foreach (var item in divisionId)
            {
                parameters.Add("divisionId", UriHelper.ParameterToString(item));
            }
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

        var uri = UriHelper.GetUri("api/v2/outbound/dnclists", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DncListEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    // GET methods for Event operations
    public async Task<EventLog> GetOutboundEventAsync(string eventId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(eventId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/events/{Uri.EscapeDataString(eventId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EventLog>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DialerEventEntityListing> GetOutboundEventsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string category = null, string level = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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
            parameters.Add("filterType", UriHelper.ParameterToString(filterType));
        }

        if (!string.IsNullOrEmpty(category))
        {
            parameters.Add("category", UriHelper.ParameterToString(category));
        }

        if (!string.IsNullOrEmpty(level))
        {
            parameters.Add("level", UriHelper.ParameterToString(level));
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

        var uri = UriHelper.GetUri("api/v2/outbound/events", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DialerEventEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    // GET methods for FileSpecificationTemplate operations
    public async Task<FileSpecificationTemplate> GetOutboundFilespecificationtemplateAsync(string fileSpecificationTemplateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(fileSpecificationTemplateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/filespecificationtemplates/{Uri.EscapeDataString(fileSpecificationTemplateId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FileSpecificationTemplate>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FileSpecificationTemplateEntityListing> GetOutboundFilespecificationtemplatesAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri("api/v2/outbound/filespecificationtemplates", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FileSpecificationTemplateEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    // GET methods for ImportTemplate operations
    public async Task<ImportTemplate> GetOutboundImporttemplateAsync(string importTemplateId, bool? includeImportStatus = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(importTemplateId);

        var parameters = new NameValueCollection();

        if (includeImportStatus.HasValue)
        {
            parameters.Add("includeImportStatus", UriHelper.ParameterToString(includeImportStatus.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/importtemplates/{Uri.EscapeDataString(importTemplateId)}", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ImportTemplate>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ImportTemplateEntityListing> GetOutboundImporttemplatesAsync(bool? includeImportStatus = null, int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, string contactListTemplateId = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (includeImportStatus.HasValue)
        {
            parameters.Add("includeImportStatus", UriHelper.ParameterToString(includeImportStatus.Value));
        }

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

        if (!string.IsNullOrEmpty(contactListTemplateId))
        {
            parameters.Add("contactListTemplateId", UriHelper.ParameterToString(contactListTemplateId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/outbound/importtemplates", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ImportTemplateEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    // GET methods for RuleSet operations
    public async Task<RuleSet> GetOutboundRulesetAsync(string ruleSetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(ruleSetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/rulesets/{Uri.EscapeDataString(ruleSetId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RuleSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<RuleSetEntityListing> GetOutboundRulesetsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri("api/v2/outbound/rulesets", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RuleSetEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    // GET methods for Sequence operations
    public async Task<CampaignSequence> GetOutboundSequenceAsync(string sequenceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sequenceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/sequences/{Uri.EscapeDataString(sequenceId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignSequence>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignSequenceEntityListing> GetOutboundSequencesAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri("api/v2/outbound/sequences", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignSequenceEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    // GET methods for Settings operations
    public async Task<OutboundSettings> GetOutboundSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/outbound/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutboundSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    // GET methods for WrapUpCodeMapping operations
    public async Task<WrapUpCodeMapping> GetOutboundWrapupcodemappingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/outbound/wrapupcodemappings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WrapUpCodeMapping>(_options.JsonSerializerOptions, cancellationToken);
    }

    // POST methods for creating entities
    public async Task<DigitalRuleSet> PostOutboundDigitalrulesetAsync(DigitalRuleSet body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/digitalrulesets", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DigitalRuleSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DncList> PostOutboundDnclistAsync(DncListCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/dnclists", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DncList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FileSpecificationTemplate> PostOutboundFilespecificationtemplatesAsync(FileSpecificationTemplate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/filespecificationtemplates", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FileSpecificationTemplate>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ImportTemplate> PostOutboundImporttemplatesAsync(ImportTemplate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/importtemplates", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ImportTemplate>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<RuleSet> PostOutboundRulesetAsync(RuleSet body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/rulesets", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RuleSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignSequence> PostOutboundSequenceAsync(CampaignSequence body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/sequences", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignSequence>(_options.JsonSerializerOptions, cancellationToken);
    }

    // PUT methods for updating entities
    public async Task<DigitalRuleSet> PutOutboundDigitalrulesetAsync(string digitalRuleSetId, DigitalRuleSet body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(digitalRuleSetId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/digitalrulesets/{Uri.EscapeDataString(digitalRuleSetId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DigitalRuleSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DncList> PutOutboundDnclistAsync(string dncListId, DncList body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/dnclists/{Uri.EscapeDataString(dncListId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DncList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FileSpecificationTemplate> PutOutboundFilespecificationtemplateAsync(string fileSpecificationTemplateId, FileSpecificationTemplate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(fileSpecificationTemplateId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/filespecificationtemplates/{Uri.EscapeDataString(fileSpecificationTemplateId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FileSpecificationTemplate>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ImportTemplate> PutOutboundImporttemplateAsync(string importTemplateId, ImportTemplate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(importTemplateId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/importtemplates/{Uri.EscapeDataString(importTemplateId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ImportTemplate>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<RuleSet> PutOutboundRulesetAsync(string ruleSetId, RuleSet body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(ruleSetId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/rulesets/{Uri.EscapeDataString(ruleSetId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RuleSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignSequence> PutOutboundSequenceAsync(string sequenceId, CampaignSequence body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sequenceId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/sequences/{Uri.EscapeDataString(sequenceId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignSequence>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<OutboundSettings> PutOutboundSettingsAsync(OutboundSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/outbound/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutboundSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<WrapUpCodeMapping> PutOutboundWrapupcodemappingsAsync(WrapUpCodeMapping body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/outbound/wrapupcodemappings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WrapUpCodeMapping>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListTemplateEntityListing> GetOutboundContactlisttemplatesAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri("api/v2/outbound/contactlisttemplates", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListTemplateEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    // Specialized GET methods that return basic types
    public async Task<string> GetOutboundContactlistExportAsync(string contactListId, string download = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(download))
        {
            parameters.Add("download", UriHelper.ParameterToString(download));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/contactlists/{Uri.EscapeDataString(contactListId)}/export", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    public async Task<ImportStatus> GetOutboundContactlistImportstatusAsync(string contactListId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/contactlists/{Uri.EscapeDataString(contactListId)}/importstatus", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ImportStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<string> GetOutboundDnclistExportAsync(string dncListId, string download = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(download))
        {
            parameters.Add("download", UriHelper.ParameterToString(download));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/dnclists/{Uri.EscapeDataString(dncListId)}/export", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    public async Task<ImportStatus> GetOutboundDnclistImportstatusAsync(string dncListId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/dnclists/{Uri.EscapeDataString(dncListId)}/importstatus", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ImportStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ImportStatus> GetOutboundImporttemplateImportstatusAsync(string importTemplateId, List<string> listNamePrefix = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(importTemplateId);

        var parameters = new NameValueCollection();

        if (listNamePrefix != null && listNamePrefix.Count > 0)
        {
            foreach (var item in listNamePrefix)
            {
                parameters.Add("listNamePrefix", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/importtemplates/{Uri.EscapeDataString(importTemplateId)}/importstatus", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ImportStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    // POST methods for specialized operations  
    public async Task<string> PostOutboundContactlistClearAsync(string contactListId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/outbound/contactlists/{Uri.EscapeDataString(contactListId)}/clear", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    public async Task<string> PostOutboundContactlistExportAsync(string contactListId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/outbound/contactlists/{Uri.EscapeDataString(contactListId)}/export", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    public async Task<DncList> PostOutboundDnclistExportAsync(string dncListId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/outbound/dnclists/{Uri.EscapeDataString(dncListId)}/export", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DncList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<string> PostOutboundDnclistEmailaddressesAsync(string dncListId, List<string> body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/outbound/dnclists/{Uri.EscapeDataString(dncListId)}/emailaddresses", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    public async Task<string> PostOutboundDnclistPhonenumbersAsync(string dncListId, List<string> body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/outbound/dnclists/{Uri.EscapeDataString(dncListId)}/phonenumbers", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    public async Task<CampaignSchedule> PostOutboundSchedulesCampaignAsync(CampaignSchedule body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/schedules/campaigns", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignSchedule> PostOutboundSchedulesSequenceAsync(CampaignSchedule body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/schedules/sequences", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }
}