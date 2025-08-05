using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
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

    public async Task<bool> DeleteOutboundAttemptlimitAsync(string attemptLimitsId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(attemptLimitsId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/attemptlimits/{attemptLimitsId}", cancellationToken);

        return response.IsSuccessStatusCode;
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

    public async Task<bool> DeleteOutboundCallabletimesetAsync(string callableTimeSetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(callableTimeSetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/callabletimesets/{Uri.EscapeDataString(callableTimeSetId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<Campaign> GetOutboundCampaignAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/campaigns/{Uri.EscapeDataString(campaignId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Campaign>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignEntityListing> GetOutboundCampaignsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, IEnumerable<string> ids = null, string contactListId = null, string dncListIds = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, IEnumerable<string> divisionIds = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", id);
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

        if (divisionIds != null)
        {
            foreach (var divisionId in divisionIds)
            {
                parameters.Add("divisionId", divisionId);
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

    public async Task<bool> DeleteOutboundCampaignAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/campaigns/{Uri.EscapeDataString(campaignId)}", cancellationToken);

        return response.IsSuccessStatusCode;
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

    public async Task<bool> DeleteOutboundCallanalysisresponsesetAsync(string callAnalysisSetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(callAnalysisSetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/callanalysisresponsesets/{Uri.EscapeDataString(callAnalysisSetId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundCampaignProgressAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/campaigns/{Uri.EscapeDataString(campaignId)}/progress", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundCampaignruleAsync(string campaignRuleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignRuleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/campaignrules/{Uri.EscapeDataString(campaignRuleId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundContactlistAsync(string contactListId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/contactlists/{Uri.EscapeDataString(contactListId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundContactlistContactAsync(string contactListId, string contactId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/contactlists/{Uri.EscapeDataString(contactListId)}/contacts/{Uri.EscapeDataString(contactId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundContactlistContactsAsync(string contactListId, IEnumerable<string> contactIds, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);
        ArgumentNullException.ThrowIfNull(contactIds);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/outbound/contactlists/{Uri.EscapeDataString(contactListId)}/contacts/bulk/delete", contactIds, _options.JsonSerializerOptions, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundContactlistfilterAsync(string contactListFilterId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListFilterId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/contactlistfilters/{Uri.EscapeDataString(contactListFilterId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundContactlistsAsync(IEnumerable<string> id, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/contactlists/bulk/delete", id, _options.JsonSerializerOptions, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundContactlisttemplateAsync(string contactListTemplateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListTemplateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/contactlisttemplates/{Uri.EscapeDataString(contactListTemplateId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundContactlisttemplatesAsync(IEnumerable<string> id, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/contactlisttemplates/bulk/delete", id, _options.JsonSerializerOptions, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundDigitalrulesetAsync(string digitalRuleSetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(digitalRuleSetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/digitalrulesets/{Uri.EscapeDataString(digitalRuleSetId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundDnclistAsync(string dncListId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/dnclists/{Uri.EscapeDataString(dncListId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundDnclistCustomexclusioncolumnsAsync(string dncListId, bool? expiredOnly = null, CancellationToken cancellationToken = default)
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

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundDnclistEmailaddressesAsync(string dncListId, bool? expiredOnly = null, CancellationToken cancellationToken = default)
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

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundDnclistPhonenumbersAsync(string dncListId, bool? expiredOnly = null, CancellationToken cancellationToken = default)
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

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundDnclistWhatsappnumbersAsync(string dncListId, bool? expiredOnly = null, CancellationToken cancellationToken = default)
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

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundFilespecificationtemplateAsync(string fileSpecificationTemplateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(fileSpecificationTemplateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/filespecificationtemplates/{Uri.EscapeDataString(fileSpecificationTemplateId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundFilespecificationtemplatesBulkAsync(IEnumerable<string> id, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/filespecificationtemplates/bulk/delete", id, _options.JsonSerializerOptions, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundImporttemplateAsync(string importTemplateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(importTemplateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/importtemplates/{Uri.EscapeDataString(importTemplateId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundImporttemplatesAsync(IEnumerable<string> id, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/importtemplates/bulk/delete", id, _options.JsonSerializerOptions, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundMessagingcampaignAsync(string messagingCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/messagingcampaigns/{Uri.EscapeDataString(messagingCampaignId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundMessagingcampaignProgressAsync(string messagingCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/messagingcampaigns/{Uri.EscapeDataString(messagingCampaignId)}/progress", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundRulesetAsync(string ruleSetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(ruleSetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/rulesets/{Uri.EscapeDataString(ruleSetId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundSchedulesCampaignAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/schedules/campaigns/{Uri.EscapeDataString(campaignId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundSchedulesEmailcampaignAsync(string emailCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(emailCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/schedules/emailcampaigns/{Uri.EscapeDataString(emailCampaignId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundSchedulesMessagingcampaignAsync(string messagingCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/schedules/messagingcampaigns/{Uri.EscapeDataString(messagingCampaignId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundSchedulesSequenceAsync(string sequenceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sequenceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/schedules/sequences/{Uri.EscapeDataString(sequenceId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteOutboundSequenceAsync(string sequenceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sequenceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/outbound/sequences/{Uri.EscapeDataString(sequenceId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    // TODO: Add remaining GET methods - some model types need to be resolved first
    // Temporarily commenting out methods with missing model references
    
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

    public async Task<CommonCampaignEntityListing> GetOutboundCampaignsAllAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> ids = null, string name = null, IEnumerable<string> divisionIds = null, IEnumerable<string> mediaTypes = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", UriHelper.ParameterToString(id));
            }
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (divisionIds != null)
        {
            foreach (var divisionId in divisionIds)
            {
                parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
            }
        }

        if (mediaTypes != null)
        {
            foreach (var mediaType in mediaTypes)
            {
                parameters.Add("mediaType", UriHelper.ParameterToString(mediaType));
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

    public async Task<CommonCampaignDivisionViewEntityListing> GetOutboundCampaignsAllDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> ids = null, string name = null, IEnumerable<string> divisionIds = null, IEnumerable<string> mediaTypes = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", UriHelper.ParameterToString(id));
            }
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (divisionIds != null)
        {
            foreach (var divisionId in divisionIds)
            {
                parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
            }
        }

        if (mediaTypes != null)
        {
            foreach (var mediaType in mediaTypes)
            {
                parameters.Add("mediaType", UriHelper.ParameterToString(mediaType));
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

    // All GET methods successfully migrated - models were available

    // Working POST methods using existing models




    // Working PUT methods using existing models
    // GET methods for ContactLists operations
    public async Task<ContactListEntityListing> GetOutboundContactlistsAsync(bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", UriHelper.ParameterToString(id));
            }
        }

        if (divisionIds != null)
        {
            foreach (var divisionId in divisionIds)
            {
                parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
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

    public async Task<DncListEntityListing> GetOutboundDnclistsAsync(bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string dncSourceType = null, IEnumerable<string> divisionIds = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (divisionIds != null)
        {
            foreach (var divisionId in divisionIds)
            {
                parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
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

    public async Task<ImportStatus> GetOutboundImporttemplateImportstatusAsync(string importTemplateId, IEnumerable<string> listNamePrefixes = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(importTemplateId);

        var parameters = new NameValueCollection();

        if (listNamePrefixes != null)
        {
            foreach (var listNamePrefix in listNamePrefixes)
            {
                parameters.Add("listNamePrefix", UriHelper.ParameterToString(listNamePrefix));
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

    public async Task<string> PostOutboundDnclistEmailaddressesAsync(string dncListId, IEnumerable<string> body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/outbound/dnclists/{Uri.EscapeDataString(dncListId)}/emailaddresses", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    public async Task<string> PostOutboundDnclistPhonenumbersAsync(string dncListId, IEnumerable<string> body, CancellationToken cancellationToken = default)
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

    public async Task<CampaignDivisionView> GetOutboundCampaignsDivisionviewAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/campaigns/divisionviews/{campaignId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignDivisionView>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignDivisionViewListing> GetOutboundCampaignsDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, IEnumerable<string> ids = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", UriHelper.ParameterToString(id));
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

        var uri = UriHelper.GetUri("api/v2/outbound/campaigns/divisionviews", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignDivisionViewListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactList> GetOutboundContactlistAsync(string contactListId, bool? includeImportStatus = null, bool? includeSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);

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

        var uri = UriHelper.GetUri($"api/v2/outbound/contactlists/{contactListId}", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DialerContact> GetOutboundContactlistContactAsync(string contactListId, string contactId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/contactlists/{contactListId}/contacts/{contactId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DialerContact>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactsBulkOperationJob> GetOutboundContactlistContactsBulkJobAsync(string contactListId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/contactlists/{contactListId}/contacts/bulk/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactsBulkOperationJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactsBulkOperationJobListing> GetOutboundContactlistContactsBulkJobsAsync(string contactListId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/contactlists/{contactListId}/contacts/bulk", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactsBulkOperationJobListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TimeZoneMappingPreview> GetOutboundContactlistTimezonemappingpreviewAsync(string contactListId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/contactlists/{contactListId}/timezonemappingpreview", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeZoneMappingPreview>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListDivisionView> GetOutboundContactlistsDivisionviewAsync(string contactListId, bool? includeImportStatus = null, bool? includeSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);

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

        var uri = UriHelper.GetUri($"api/v2/outbound/contactlists/divisionviews/{contactListId}", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListDivisionView>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListDivisionViewListing> GetOutboundContactlistsDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, IEnumerable<string> ids = null, string sortBy = null, string sortOrder = null, bool? includeImportStatus = null, bool? includeSize = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", UriHelper.ParameterToString(id));
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

        if (includeImportStatus.HasValue)
        {
            parameters.Add("includeImportStatus", UriHelper.ParameterToString(includeImportStatus.Value));
        }

        if (includeSize.HasValue)
        {
            parameters.Add("includeSize", UriHelper.ParameterToString(includeSize.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/outbound/contactlists/divisionviews", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListDivisionViewListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DncListDivisionView> GetOutboundDnclistsDivisionviewAsync(string dncListId, bool? includeImportStatus = null, bool? includeSize = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri($"api/v2/outbound/dnclists/divisionviews/{dncListId}", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DncListDivisionView>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DncListDivisionViewListing> GetOutboundDnclistsDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, IEnumerable<string> ids = null, string sortBy = null, string sortOrder = null, bool? includeImportStatus = null, bool? includeSize = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", UriHelper.ParameterToString(id));
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

        if (includeImportStatus.HasValue)
        {
            parameters.Add("includeImportStatus", UriHelper.ParameterToString(includeImportStatus.Value));
        }

        if (includeSize.HasValue)
        {
            parameters.Add("includeSize", UriHelper.ParameterToString(includeSize.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/outbound/dnclists/divisionviews", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DncListDivisionViewListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MessagingCampaign> GetOutboundMessagingcampaignAsync(string messagingCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/messagingcampaigns/{messagingCampaignId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MessagingCampaign>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MessagingCampaignDiagnostics> GetOutboundMessagingcampaignDiagnosticsAsync(string messagingCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/messagingcampaigns/{messagingCampaignId}/diagnostics", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MessagingCampaignDiagnostics>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignProgress> GetOutboundMessagingcampaignProgressAsync(string messagingCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/messagingcampaigns/{messagingCampaignId}/progress", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignProgress>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MessagingCampaignEntityListing> GetOutboundMessagingcampaignsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, IEnumerable<string> ids = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, IEnumerable<string> divisionIds = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", UriHelper.ParameterToString(id));
            }
        }

        if (!string.IsNullOrEmpty(contactListId))
        {
            parameters.Add("contactListId", UriHelper.ParameterToString(contactListId));
        }

        if (!string.IsNullOrEmpty(dncListId))
        {
            parameters.Add("dncListId", UriHelper.ParameterToString(dncListId));
        }

        if (!string.IsNullOrEmpty(distributionQueueId))
        {
            parameters.Add("distributionQueueId", UriHelper.ParameterToString(distributionQueueId));
        }

        if (!string.IsNullOrEmpty(edgeGroupId))
        {
            parameters.Add("edgeGroupId", UriHelper.ParameterToString(edgeGroupId));
        }

        if (divisionIds != null)
        {
            foreach (var divisionId in divisionIds)
            {
                parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
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

        var uri = UriHelper.GetUri("api/v2/outbound/messagingcampaigns", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MessagingCampaignEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MessagingCampaignDivisionView> GetOutboundMessagingcampaignsDivisionviewAsync(string messagingCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/messagingcampaigns/divisionviews/{messagingCampaignId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MessagingCampaignDivisionView>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MessagingCampaignDivisionViewEntityListing> GetOutboundMessagingcampaignsDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, IEnumerable<string> ids = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", UriHelper.ParameterToString(id));
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

        var uri = UriHelper.GetUri("api/v2/outbound/messagingcampaigns/divisionviews", parameters);
        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MessagingCampaignDivisionViewEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignSchedule> GetOutboundSchedulesCampaignAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/schedules/campaigns/{campaignId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IEnumerable<CampaignSchedule>> GetOutboundSchedulesCampaignsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/outbound/schedules/campaigns", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<CampaignSchedule>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EmailCampaignSchedule> GetOutboundSchedulesEmailcampaignAsync(string emailCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(emailCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/schedules/emailcampaigns/{emailCampaignId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmailCampaignSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IEnumerable<EmailCampaignSchedule>> GetOutboundSchedulesEmailcampaignsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/outbound/schedules/emailcampaigns", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<EmailCampaignSchedule>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MessagingCampaignSchedule> GetOutboundSchedulesMessagingcampaignAsync(string messagingCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/schedules/messagingcampaigns/{messagingCampaignId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MessagingCampaignSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IEnumerable<MessagingCampaignSchedule>> GetOutboundSchedulesMessagingcampaignsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/outbound/schedules/messagingcampaigns", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<MessagingCampaignSchedule>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignSchedule> GetOutboundSchedulesSequenceAsync(string sequenceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sequenceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/outbound/schedules/sequences/{sequenceId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IEnumerable<CampaignSchedule>> GetOutboundSchedulesSequencesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/outbound/schedules/sequences", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<CampaignSchedule>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Campaign> PatchOutboundCampaignAsync(string campaignId, Campaign body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/outbound/campaigns/{campaignId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Campaign>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task PatchOutboundDnclistCustomexclusioncolumnsAsync(string dncListId, DncPatchCustomExclusionColumnsRequest body, bool? expiredOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (expiredOnly.HasValue)
        {
            parameters.Add("expiredOnly", UriHelper.ParameterToString(expiredOnly.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/dnclists/{dncListId}/customexclusioncolumns", parameters);
        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task PatchOutboundDnclistEmailaddressesAsync(string dncListId, DncPatchEmailsRequest body, bool? expiredOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (expiredOnly.HasValue)
        {
            parameters.Add("expiredOnly", UriHelper.ParameterToString(expiredOnly.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/dnclists/{dncListId}/emailaddresses", parameters);
        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task PatchOutboundDnclistPhonenumbersAsync(string dncListId, DncPatchPhoneNumbersRequest body, bool? expiredOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (expiredOnly.HasValue)
        {
            parameters.Add("expiredOnly", UriHelper.ParameterToString(expiredOnly.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/dnclists/{dncListId}/phonenumbers", parameters);
        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task PatchOutboundDnclistWhatsappnumbersAsync(string dncListId, DncPatchEmailsRequest body, bool? expiredOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dncListId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (expiredOnly.HasValue)
        {
            parameters.Add("expiredOnly", UriHelper.ParameterToString(expiredOnly.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/dnclists/{dncListId}/whatsappnumbers", parameters);
        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<OutboundSettings> PatchOutboundSettingsAsync(OutboundSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync("api/v2/outbound/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutboundSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AgentOwnedMappingPreviewListing> PostOutboundCampaignAgentownedmappingpreviewAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/outbound/campaigns/{campaignId}/agentownedmappingpreview", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentOwnedMappingPreviewListing>(_options.JsonSerializerOptions, cancellationToken);
    }



    public async Task<Campaign> PostOutboundCampaignStartAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/outbound/campaigns/{campaignId}/start", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Campaign>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Campaign> PostOutboundCampaignStopAsync(string campaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/outbound/campaigns/{campaignId}/stop", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Campaign>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignRule> PostOutboundCampaignrulesAsync(CampaignRule body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/campaignrules", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignRule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IEnumerable<CampaignProgress>> PostOutboundCampaignsProgressAsync(IEnumerable<string> body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/campaigns/progress", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<CampaignProgress>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DialerContact> PostOutboundContactlistContactsAsync(string contactListId, IEnumerable<DialerContact> body, int? priority = null, bool? clearSystemData = null, bool? doNotQueue = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (priority.HasValue)
        {
            parameters.Add("priority", UriHelper.ParameterToString(priority.Value));
        }

        if (clearSystemData.HasValue)
        {
            parameters.Add("clearSystemData", UriHelper.ParameterToString(clearSystemData.Value));
        }

        if (doNotQueue.HasValue)
        {
            parameters.Add("doNotQueue", UriHelper.ParameterToString(doNotQueue.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/outbound/contactlists/{contactListId}/contacts", parameters);
        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DialerContact>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactsBulkOperationJob> PostOutboundContactlistContactsBulkAsync(string contactListId, IEnumerable<string> body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/outbound/contactlists/{contactListId}/contacts/bulk", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactsBulkOperationJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactsBulkOperationJob> PostOutboundContactlistContactsBulkRemoveAsync(string contactListId, ContactBulkDeleteRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/outbound/contactlists/{contactListId}/contacts/bulk/remove", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactsBulkOperationJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactsBulkOperationJob> PostOutboundContactlistContactsBulkUpdateAsync(string contactListId, ContactBulkEditRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/outbound/contactlists/{contactListId}/contacts/bulk/update", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactsBulkOperationJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListingResponse> PostOutboundContactlistContactsSearchAsync(string contactListId, ContactListingRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/outbound/contactlists/{contactListId}/contacts/search", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListingResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListFilter> PostOutboundContactlistfiltersAsync(ContactListFilter body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/contactlistfilters", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListFilter>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListFilterEntityListing> PostOutboundContactlistfiltersBulkRetrieveAsync(ContactListFilterBulkRetrieveBody body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/contactlistfilters/bulk/retrieve", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListFilterEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FilterPreviewResponse> PostOutboundContactlistfiltersPreviewAsync(ContactListFilter body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/contactlistfilters/preview", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FilterPreviewResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactList> PostOutboundContactlistsAsync(ContactList body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/contactlists", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListTemplate> PostOutboundContactlisttemplatesAsync(ContactListTemplate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/contactlisttemplates", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListTemplate>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListTemplateEntityListing> PostOutboundContactlisttemplatesBulkAddAsync(IEnumerable<ContactListTemplate> body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/contactlisttemplates/bulk/add", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListTemplateEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListTemplateEntityListing> PostOutboundContactlisttemplatesBulkRetrieveAsync(ContactListTemplateBulkRetrieveBody body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/contactlisttemplates/bulk/retrieve", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListTemplateEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }



    public async Task<ImportTemplate> PostOutboundImporttemplatesBulkAddAsync(IEnumerable<ImportTemplate> body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/importtemplates/bulk/add", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ImportTemplate>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MessagingCampaign> PostOutboundMessagingcampaignStartAsync(string messagingCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/outbound/messagingcampaigns/{messagingCampaignId}/start", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MessagingCampaign>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MessagingCampaign> PostOutboundMessagingcampaignStopAsync(string messagingCampaignId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/outbound/messagingcampaigns/{messagingCampaignId}/stop", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MessagingCampaign>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MessagingCampaign> PostOutboundMessagingcampaignsAsync(MessagingCampaign body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/messagingcampaigns", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MessagingCampaign>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IEnumerable<CampaignProgress>> PostOutboundMessagingcampaignsProgressAsync(IEnumerable<string> body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/outbound/messagingcampaigns/progress", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<CampaignProgress>>(_options.JsonSerializerOptions, cancellationToken);
    }


    }

    public async Task<CampaignRule> PutOutboundCampaignruleAsync(string campaignRuleId, CampaignRule body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignRuleId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/campaignrules/{campaignRuleId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignRule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactList> PutOutboundContactlistAsync(string contactListId, ContactList body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/contactlists/{contactListId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DialerContact> PutOutboundContactlistContactAsync(string contactListId, string contactId, DialerContact body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListId);
        ArgumentException.ThrowIfNullOrEmpty(contactId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/contactlists/{contactListId}/contacts/{contactId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DialerContact>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListFilter> PutOutboundContactlistfilterAsync(string contactListFilterId, ContactListFilter body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListFilterId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/contactlistfilters/{contactListFilterId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListFilter>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ContactListTemplate> PutOutboundContactlisttemplateAsync(string contactListTemplateId, ContactListTemplate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactListTemplateId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/contactlisttemplates/{contactListTemplateId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContactListTemplate>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MessagingCampaign> PutOutboundMessagingcampaignAsync(string messagingCampaignId, MessagingCampaign body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/messagingcampaigns/{messagingCampaignId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MessagingCampaign>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignSchedule> PutOutboundSchedulesCampaignAsync(string campaignId, CampaignSchedule body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/schedules/campaigns/{campaignId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EmailCampaignSchedule> PutOutboundSchedulesEmailcampaignAsync(string emailCampaignId, EmailCampaignSchedule body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(emailCampaignId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/schedules/emailcampaigns/{emailCampaignId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmailCampaignSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<MessagingCampaignSchedule> PutOutboundSchedulesMessagingcampaignAsync(string messagingCampaignId, MessagingCampaignSchedule body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messagingCampaignId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/schedules/messagingcampaigns/{messagingCampaignId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MessagingCampaignSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CampaignSchedule> PutOutboundSchedulesSequenceAsync(string sequenceId, CampaignSchedule body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sequenceId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/schedules/sequences/{sequenceId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CampaignSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    // Additional missing endpoints from systematic migration








    // Missing POST methods that match old naming
















    // Missing PUT methods that match old naming








    // Remaining missing methods
    public async Task PostOutboundCampaignCallbackScheduleAsync(string campaignId, ContactCallbackRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/outbound/campaigns/{campaignId}/callback/schedule", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task PostOutboundConversationDncAsync(string conversationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/outbound/conversations/{conversationId}/dnc", null, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task PutOutboundCampaignAgentAsync(string campaignId, string userId, Agent body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(campaignId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/outbound/campaigns/{campaignId}/agents/{userId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}

