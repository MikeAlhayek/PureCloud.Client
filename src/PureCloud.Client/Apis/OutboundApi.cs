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

    public async Task<MessagingCampaign> DeleteOutboundMessagingcampaignAsync(string messagingCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/messagingcampaigns/{Uri.EscapeDataString(messagingCampaignId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MessagingCampaign>(_options.JsonSerializerOptions, cancellationToken);
    }

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
}