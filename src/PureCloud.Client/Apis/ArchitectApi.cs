using System.Collections.Specialized;
using System.Data;
using System.Net.Http.Json;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class ArchitectApi : IArchitectApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public ArchitectApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<bool> DeleteArchitectEmergencygroupAsync(string emergencyGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(emergencyGroupId, nameof(emergencyGroupId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/emergencygroups/{UriHelper.ParameterToString(emergencyGroupId)}";

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteArchitectGrammarAsync(string grammarId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(grammarId, nameof(grammarId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/grammars/{UriHelper.ParameterToString(grammarId)}";

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteArchitectGrammarLanguageAsync(string grammarId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(grammarId, nameof(grammarId));

        ArgumentException.ThrowIfNullOrEmpty(languageCode, nameof(languageCode));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/grammars/{UriHelper.ParameterToString(grammarId)}/languages/{UriHelper.ParameterToString(languageCode)}";

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteArchitectGrammarLanguageFilesDtmfAsync(string grammarId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(grammarId, nameof(grammarId));

        ArgumentException.ThrowIfNullOrEmpty(languageCode, nameof(languageCode));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/grammars/{UriHelper.ParameterToString(grammarId)}/languages/{UriHelper.ParameterToString(languageCode)}/files/dtmf";

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteArchitectGrammarLanguageFilesVoiceAsync(string grammarId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(grammarId, nameof(grammarId));

        ArgumentException.ThrowIfNullOrEmpty(languageCode, nameof(languageCode));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/grammars/{UriHelper.ParameterToString(grammarId)}/languages/{UriHelper.ParameterToString(languageCode)}/files/voice";

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteArchitectIvrAsync(string ivrId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(ivrId, nameof(ivrId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/ivrs/{UriHelper.ParameterToString(ivrId)}";

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteArchitectPromptAsync(string promptId, bool? allResources = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId, nameof(promptId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new NameValueCollection();

        if (allResources != null)
        {
            queryParams.Add("allResources", UriHelper.ParameterToString(allResources.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/architect/prompts/{UriHelper.ParameterToString(promptId)}", queryParams);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteArchitectPromptResourceAsync(string promptId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId, nameof(promptId));

        ArgumentException.ThrowIfNullOrEmpty(languageCode, nameof(languageCode));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/architect/prompts/{UriHelper.ParameterToString(promptId)}/resources/{UriHelper.ParameterToString(languageCode)}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteArchitectPromptResourceAudioAsync(string promptId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId, nameof(promptId));

        ArgumentException.ThrowIfNullOrEmpty(languageCode, nameof(languageCode));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/architect/prompts/{UriHelper.ParameterToString(promptId)}/resources/{UriHelper.ParameterToString(languageCode)}/audio", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<Operation> DeleteArchitectPromptsAsync(List<string> id, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id, nameof(id));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        foreach (var item in id)
        {
            parameters.Add("id", UriHelper.ParameterToString(item));
        }

        var uri = UriHelper.GetUri("/api/v2/architect/prompts", parameters);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Operation>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> DeleteArchitectScheduleAsync(string scheduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scheduleId, nameof(scheduleId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/architect/schedules/{UriHelper.ParameterToString(scheduleId)}";

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteArchitectSchedulegroupAsync(string scheduleGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scheduleGroupId, nameof(scheduleGroupId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/architect/schedulegroups/{UriHelper.ParameterToString(scheduleGroupId)}";

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteArchitectSystempromptResourceAsync(string promptId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId, nameof(promptId));

        ArgumentException.ThrowIfNullOrEmpty(languageCode, nameof(languageCode));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/architect/systemprompts/{UriHelper.ParameterToString(promptId)}/resources/{UriHelper.ParameterToString(languageCode)}";

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteFlowAsync(string flowId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId, nameof(flowId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/flows/{UriHelper.ParameterToString(flowId)}";

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteFlowInstancesSettingsLoglevelsAsync(string flowId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId, nameof(flowId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"/api/v2/flows/{UriHelper.ParameterToString(flowId)}/instances/settings/loglevels";

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<Operation> DeleteFlowsAsync(List<string> ids, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(ids, nameof(ids));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = QueryHelpers.AddQueryString("/api/v2/flows", ids.Select(id => new KeyValuePair<string, string>("id", UriHelper.ParameterToString(id))));

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Operation>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> DeleteFlowsDatatableAsync(string datatableId, bool? force = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(datatableId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"/api/v2/flows/datatables/{UriHelper.ParameterToString(datatableId)}";

        if (force is not null)
        {
            url = $"{url}?force={UriHelper.ParameterToString(force)}";
        }

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteFlowsDatatableRowAsync(string datatableId, string rowId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(datatableId, nameof(datatableId));

        ArgumentException.ThrowIfNullOrEmpty(rowId, nameof(rowId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var path = $"/api/v2/flows/datatables/{UriHelper.ParameterToString(datatableId)}/rows/{UriHelper.ParameterToString(rowId)}";

        var response = await client.DeleteAsync(path, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteFlowsInstancesSettingsLoglevelsDefaultAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("/api/v2/flows/instances/settings/loglevels/default", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteFlowsMilestoneAsync(string milestoneId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(milestoneId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"/api/v2/flows/milestones/{Uri.EscapeDataString(milestoneId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<DependencyObjectEntityListing> GetArchitectDependencyTrackingAsync(string name, int? pageNumber = null, int? pageSize = null, IEnumerable<string> objectTypes = null, bool? consumedResources = null, bool? consumingResources = null, IEnumerable<string> consumedResourceTypes = null, IEnumerable<string> consumingResourceTypes = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>
        {
            new("name", UriHelper.ParameterToString(name))
        };

        var singleValuedParams = new Dictionary<string, object>
        {
            ["pageNumber"] = pageNumber,
            ["pageSize"] = pageSize,
            ["consumedResources"] = consumedResources,
            ["consumingResources"] = consumingResources
        };

        foreach (var singleParam in singleValuedParams)
        {
            var paramName = singleParam.Key;

            var paramValue = singleParam.Value;

            if (paramValue != null)
            {
                queryParams.Add(new KeyValuePair<string, string>(paramName, UriHelper.ParameterToString(paramValue)));
            }
        }

        var multiValuedParams = new Dictionary<string, IEnumerable<string>>
        {
            ["objectType"] = objectTypes,
            ["consumedResourceType"] = consumedResourceTypes,
            ["consumingResourceType"] = consumingResourceTypes
        };

        foreach (var multiParam in multiValuedParams)
        {
            var paramName = multiParam.Key;

            var values = multiParam.Value;

            if (values != null)
            {
                foreach (var singleValue in values)
                {
                    queryParams.Add(new KeyValuePair<string, string>(paramName, UriHelper.ParameterToString(singleValue)));
                }
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/dependencytracking", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DependencyObjectEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }


    public async Task<DependencyStatus> GetArchitectDependencyTrackingBuildAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("/api/v2/architect/dependencytracking/build", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DependencyStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ConsumedResourcesEntityListing> GetArchitectDependencyTrackingConsumedResourcesAsync(string id, string version, string objectType, IEnumerable<string> resourceTypes = null, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        ArgumentException.ThrowIfNullOrEmpty(version);

        ArgumentException.ThrowIfNullOrEmpty(objectType);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>
        {
            new("id", UriHelper.ParameterToString(id)),
            new("version", UriHelper.ParameterToString(version)),
            new("objectType", UriHelper.ParameterToString(objectType))
        };

        if (resourceTypes != null)
        {
            foreach (var resourceType in resourceTypes)
            {
                queryParameters.Add(new("resourceType", UriHelper.ParameterToString(resourceType)));
            }
        }

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParameters.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/dependencytracking/consumedresources", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ConsumedResourcesEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<ConsumingResourcesEntityListing> GetArchitectDependencyTrackingConsumingResourcesAsync(string id, string objectType, IEnumerable<string> resourceTypes = null, string version = null, int? pageNumber = null, int? pageSize = null, string flowFilter = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        ArgumentException.ThrowIfNullOrEmpty(objectType);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>
    {
        new("id", UriHelper.ParameterToString(id)),
        new("objectType", UriHelper.ParameterToString(objectType))
    };

        if (resourceTypes != null)
        {
            foreach (var resourceType in resourceTypes)
            {
                queryParams.Add(new("resourceType", UriHelper.ParameterToString(resourceType)));
            }
        }

        if (version is not null)
        {
            queryParams.Add(new("version", UriHelper.ParameterToString(version)));
        }

        if (pageNumber.HasValue)
        {
            queryParams.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (flowFilter is not null)
        {
            queryParams.Add(new("flowFilter", UriHelper.ParameterToString(flowFilter)));
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/dependencytracking/consumingresources", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ConsumingResourcesEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<DependencyObjectEntityListing> GetArchitectDependencyTrackingDeletedResourceConsumersAsync(string name = null, IEnumerable<string> objectTypes = null, string flowFilter = null, bool? consumedResources = null, IEnumerable<string> consumedResourceTypes = null, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        if (name is not null)
        {
            queryParams.Add(new KeyValuePair<string, string>("name", UriHelper.ParameterToString(name)));
        }

        if (objectTypes is not null)
        {
            foreach (var type in objectTypes)
            {
                queryParams.Add(new KeyValuePair<string, string>("objectType", UriHelper.ParameterToString(type)));
            }
        }

        if (flowFilter is not null)
        {
            queryParams.Add(new KeyValuePair<string, string>("flowFilter", UriHelper.ParameterToString(flowFilter)));
        }

        if (consumedResources.HasValue)
        {
            queryParams.Add(new KeyValuePair<string, string>("consumedResources", UriHelper.ParameterToString(consumedResources.Value)));
        }

        if (consumedResourceTypes is not null)
        {
            foreach (var resourceType in consumedResourceTypes)
            {
                queryParams.Add(new KeyValuePair<string, string>("consumedResourceType", UriHelper.ParameterToString(resourceType)));
            }
        }

        if (pageNumber.HasValue)
        {
            queryParams.Add(new KeyValuePair<string, string>("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new KeyValuePair<string, string>("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/dependencytracking/deletedresourceconsumers", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DependencyObjectEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<DependencyObject> GetArchitectDependencyTrackingObjectAsync(string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, IEnumerable<string> consumedResourceTypes = null, IEnumerable<string> consumingResourceTypes = null, bool? consumedResourceRequest = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>
        {
            new("id", UriHelper.ParameterToString(id))
        };

        if (version is not null)
        {
            queryParameters.Add(new("version", UriHelper.ParameterToString(version)));
        }

        if (objectType is not null)
        {
            queryParameters.Add(new("objectType", UriHelper.ParameterToString(objectType)));
        }

        if (consumedResources.HasValue)
        {
            queryParameters.Add(new("consumedResources", UriHelper.ParameterToString(consumedResources.Value)));
        }

        if (consumingResources.HasValue)
        {
            queryParameters.Add(new("consumingResources", UriHelper.ParameterToString(consumingResources.Value)));
        }

        if (consumedResourceTypes is not null)
        {
            foreach (var resourceType in consumedResourceTypes)
            {
                queryParameters.Add(new("consumedResourceType", UriHelper.ParameterToString(resourceType)));
            }
        }

        if (consumingResourceTypes is not null)
        {
            foreach (var resourceType in consumingResourceTypes)
            {
                queryParameters.Add(new("consumingResourceType", UriHelper.ParameterToString(resourceType)));
            }
        }

        if (consumedResourceRequest.HasValue)
        {
            queryParameters.Add(new("consumedResourceRequest", UriHelper.ParameterToString(consumedResourceRequest.Value)));
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/dependencytracking/object", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DependencyObject>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DependencyType> GetArchitectDependencyTrackingTypeAsync(string typeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(typeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"/api/v2/architect/dependencytracking/types/{UriHelper.ParameterToString(typeId)}";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DependencyType>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DependencyTypeEntityListing> GetArchitectDependencyTrackingTypesAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParams.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/dependencytracking/types", queryParams);

        var response = await client.GetAsync(url, cancellationToken); response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DependencyTypeEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DependencyObjectEntityListing> GetArchitectDependencyTrackingUpdatedResourceConsumersAsync(string name = null, IEnumerable<string> objectTypes = null, bool? consumedResources = null, IEnumerable<string> consumedResourceTypes = null, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        if (name is not null)
        {
            queryParams.Add(new("name", UriHelper.ParameterToString(name)));
        }

        if (objectTypes is not null)
        {
            foreach (var type in objectTypes)
            {
                queryParams.Add(new("objectType", UriHelper.ParameterToString(type)));
            }
        }

        if (consumedResources.HasValue)
        {
            queryParams.Add(new("consumedResources", UriHelper.ParameterToString(consumedResources.Value)));
        }

        if (consumedResourceTypes is not null)
        {
            foreach (var resourceType in consumedResourceTypes)
            {
                queryParams.Add(new("consumedResourceType", UriHelper.ParameterToString(resourceType)));
            }
        }

        if (pageNumber.HasValue)
        {
            queryParams.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/dependencytracking/updatedresourceconsumers", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DependencyObjectEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EmergencyGroup> GetArchitectEmergencyGroupAsync(string emergencyGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(emergencyGroupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"/api/v2/architect/emergencygroups/{Uri.EscapeDataString(emergencyGroupId)}";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmergencyGroup>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EmergencyGroupListing> GetArchitectEmergencyGroupsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParams.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParams.Add(new("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParams.Add(new("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (!string.IsNullOrEmpty(name))
        {
            queryParams.Add(new("name", UriHelper.ParameterToString(name)));
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/emergencygroups", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmergencyGroupListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EmergencyGroupDivisionViewEntityListing> GetArchitectEmergencyGroupDivisionViewsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> groupIds = null, string groupName = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParams.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParams.Add(new("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParams.Add(new("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (groupIds != null)
        {
            foreach (var id in groupIds)
            {
                queryParams.Add(new("id", UriHelper.ParameterToString(id)));
            }
        }

        if (!string.IsNullOrEmpty(groupName))
        {
            queryParams.Add(new("name", UriHelper.ParameterToString(groupName)));
        }

        if (divisionIds != null)
        {
            foreach (var divisionId in divisionIds)
            {
                queryParams.Add(new("divisionId", UriHelper.ParameterToString(divisionId)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/emergencygroups/divisionviews", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmergencyGroupDivisionViewEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Grammar> GetArchitectGrammarAsync(string grammarId, bool includeFileUrls = false, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(grammarId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        if (includeFileUrls)
        {
            queryParams.Add(new("includeFileUrls", UriHelper.ParameterToString(includeFileUrls)));
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/architect/grammars/{grammarId}", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Grammar>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<GrammarLanguage> GetArchitectGrammarLanguageAsync(string grammarId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(grammarId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"/api/v2/architect/grammars/{grammarId}/languages/{languageCode}";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GrammarLanguage>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<GrammarListing> GetArchitectGrammarsAsync(IEnumerable<string> ids = null, string name = null, string description = null, string nameOrDescription = null, bool? includeFileUrls = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        if (ids != null)
        {
            foreach (var grammarId in ids)
            {
                queryParams.Add(new KeyValuePair<string, string>("id", UriHelper.ParameterToString(grammarId)));
            }
        }

        if (!string.IsNullOrEmpty(name))
        {
            queryParams.Add(new KeyValuePair<string, string>("name", UriHelper.ParameterToString(name)));
        }

        if (!string.IsNullOrEmpty(description))
        {
            queryParams.Add(new KeyValuePair<string, string>("description", UriHelper.ParameterToString(description)));
        }

        if (!string.IsNullOrEmpty(nameOrDescription))
        {
            queryParams.Add(new KeyValuePair<string, string>("nameOrDescription", UriHelper.ParameterToString(nameOrDescription)));
        }

        if (includeFileUrls.HasValue)
        {
            queryParams.Add(new KeyValuePair<string, string>("includeFileUrls", UriHelper.ParameterToString(includeFileUrls.Value)));
        }

        if (pageNumber.HasValue)
        {
            queryParams.Add(new KeyValuePair<string, string>("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new KeyValuePair<string, string>("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParams.Add(new KeyValuePair<string, string>("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParams.Add(new KeyValuePair<string, string>("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/grammars", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GrammarListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<IVR> GetIvrAsync(string ivrId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(ivrId, nameof(ivrId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"/api/v2/architect/ivrs/{Uri.EscapeDataString(ivrId)}";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IVR>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<IdentityResolutionConfig> GetIvrIdentityResolutionAsync(string ivrId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(ivrId, nameof(ivrId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"/api/v2/architect/ivrs/{Uri.EscapeDataString(ivrId)}/identityresolution";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityResolutionConfig>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<IVREntityListing> GetIvrsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string dnis = null, string scheduleGroup = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        var simpleParams = new Dictionary<string, string>
        {
            ["pageNumber"] = pageNumber?.ToString(),
            ["pageSize"] = pageSize?.ToString(),
            ["sortBy"] = sortBy,
            ["sortOrder"] = sortOrder,
            ["name"] = name,
            ["dnis"] = dnis,
            ["scheduleGroup"] = scheduleGroup
        };

        foreach (var (key, value) in simpleParams)
        {
            if (!string.IsNullOrEmpty(value))
            {
                queryParams.Add(new(key, UriHelper.ParameterToString(value)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/ivrs", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IVREntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }


    public async Task<IVRDivisionViewEntityListing> GetIvrsDivisionViewsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> ivrDivisionViewIds = null, string name = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        var simpleParams = new Dictionary<string, string>
        {
            ["pageNumber"] = pageNumber?.ToString(),
            ["pageSize"] = pageSize?.ToString(),
            ["sortBy"] = sortBy,
            ["sortOrder"] = sortOrder,
            ["name"] = name
        };

        foreach (var (key, value) in simpleParams)
        {
            if (!string.IsNullOrEmpty(value))
            {
                queryParameters.Add(new(key, UriHelper.ParameterToString(value)));
            }
        }

        var listParams = new Dictionary<string, IEnumerable<string>>
        {
            ["id"] = ivrDivisionViewIds,
            ["divisionId"] = divisionIds
        };

        foreach (var (key, values) in listParams)
        {
            if (values is not null)
            {
                foreach (var value in values)
                {
                    queryParameters.Add(new(key, UriHelper.ParameterToString(value)));
                }
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/ivrs/divisionviews", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IVRDivisionViewEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Prompt> GetPromptAsync(string promptId, bool? includeMediaUris = null, bool? includeResources = null, IEnumerable<string> languages = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        var flags = new Dictionary<string, string>
        {
            ["includeMediaUris"] = includeMediaUris?.ToString(),
            ["includeResources"] = includeResources?.ToString()
        };

        foreach (var (name, value) in flags)
        {
            if (!string.IsNullOrEmpty(value))
            {
                queryParams.Add(new(name, UriHelper.ParameterToString(value)));
            }
        }

        if (languages is not null)
        {
            foreach (var lang in languages)
            {
                queryParams.Add(new("language", UriHelper.ParameterToString(lang)));
            }
        }

        var encodedId = UriHelper.ParameterToString(promptId);

        var url = QueryHelpers.AddQueryString($"/api/v2/architect/prompts/{encodedId}", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Prompt>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<HistoryListing> GetPromptHistoryAsync(string promptId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, IEnumerable<string> actions = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        ArgumentException.ThrowIfNullOrEmpty(historyId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        var singles = new Dictionary<string, string>
        {
            ["pageNumber"] = pageNumber?.ToString(),
            ["pageSize"] = pageSize?.ToString(),
            ["sortOrder"] = sortOrder,
            ["sortBy"] = sortBy
        };

        foreach (var entry in singles)
        {
            if (!string.IsNullOrEmpty(entry.Value))
            {
                queryParams.Add(new(entry.Key, UriHelper.ParameterToString(entry.Value)));
            }
        }

        if (actions is not null)
        {
            foreach (var action in actions)
            {
                queryParams.Add(new("action", UriHelper.ParameterToString(action)));
            }
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/architect/prompts/{UriHelper.ParameterToString(promptId)}/history/{UriHelper.ParameterToString(historyId)}", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<HistoryListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<PromptAsset> GetPromptResourceAsync(string promptId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"/api/v2/architect/prompts/{UriHelper.ParameterToString(promptId)}/resources/{UriHelper.ParameterToString(languageCode)}";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PromptAsset>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<PromptAssetEntityListing> GetPromptResourcesAsync(string promptId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>
        {
            // no required query parameters
        };

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParameters.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/architect/prompts/{UriHelper.ParameterToString(promptId)}/resources", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PromptAssetEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<PromptEntityListing> GetPromptsAsync(int? pageNumber = null, int? pageSize = null, IEnumerable<string> promptNames = null, string description = null, string nameOrDescription = null, string sortBy = null, string sortOrder = null, bool? includeMediaUris = null, bool? includeResources = null, IEnumerable<string> languages = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParams.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (promptNames is not null)
        {
            foreach (var promptName in promptNames)
            {
                queryParams.Add(new("name", UriHelper.ParameterToString(promptName)));
            }
        }

        if (!string.IsNullOrEmpty(description))
        {
            queryParams.Add(new("description", UriHelper.ParameterToString(description)));
        }

        if (!string.IsNullOrEmpty(nameOrDescription))
        {
            queryParams.Add(new("nameOrDescription", UriHelper.ParameterToString(nameOrDescription)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParams.Add(new("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParams.Add(new("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (includeMediaUris.HasValue)
        {
            queryParams.Add(new("includeMediaUris", UriHelper.ParameterToString(includeMediaUris.Value)));
        }

        if (includeResources.HasValue)
        {
            queryParams.Add(new("includeResources", UriHelper.ParameterToString(includeResources.Value)));
        }

        if (languages is not null)
        {
            foreach (var lang in languages)
            {
                queryParams.Add(new("language", UriHelper.ParameterToString(lang)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/prompts", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PromptEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Schedule> GetScheduleAsync(string scheduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scheduleId, nameof(scheduleId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var escapedId = Uri.EscapeDataString(scheduleId);

        var url = $"/api/v2/architect/schedules/{escapedId}";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Schedule>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<ScheduleGroup> GetScheduleGroupAsync(string scheduleGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scheduleGroupId, nameof(scheduleGroupId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var escapedId = Uri.EscapeDataString(scheduleGroupId);

        var url = $"/api/v2/architect/schedulegroups/{escapedId}";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScheduleGroup>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<ScheduleGroupEntityListing> GetScheduleGroupsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string scheduleIds = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParams.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParams.Add(new("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParams.Add(new("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (!string.IsNullOrEmpty(name))
        {
            queryParams.Add(new("name", UriHelper.ParameterToString(name)));
        }

        if (!string.IsNullOrEmpty(scheduleIds))
        {
            queryParams.Add(new("scheduleIds", UriHelper.ParameterToString(scheduleIds)));
        }

        if (divisionIds is not null)
        {
            foreach (var divisionId in divisionIds)
            {
                queryParams.Add(new("divisionId", UriHelper.ParameterToString(divisionId)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/schedulegroups", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScheduleGroupEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<ScheduleGroupDivisionViewEntityListing> GetScheduleGroupDivisionViewsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> scheduleGroupIds = null, string name = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParams.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParams.Add(new("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParams.Add(new("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (scheduleGroupIds is not null)
        {
            foreach (var groupId in scheduleGroupIds)
            {
                queryParams.Add(new("id", UriHelper.ParameterToString(groupId)));
            }
        }

        if (!string.IsNullOrEmpty(name))
        {
            queryParams.Add(new("name", UriHelper.ParameterToString(name)));
        }

        if (divisionIds is not null)
        {
            foreach (var divisionId in divisionIds)
            {
                queryParams.Add(new("divisionId", UriHelper.ParameterToString(divisionId)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/schedulegroups/divisionviews", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScheduleGroupDivisionViewEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<ScheduleEntityListing> GetSchedulesAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParameters.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParameters.Add(new("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParameters.Add(new("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (!string.IsNullOrEmpty(name))
        {
            queryParameters.Add(new("name", UriHelper.ParameterToString(name)));
        }

        if (divisionIds is not null)
        {
            foreach (var divisionId in divisionIds)
            {
                queryParameters.Add(new("divisionId", UriHelper.ParameterToString(divisionId)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/schedules", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScheduleEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<ScheduleDivisionViewEntityListing> GetSchedulesDivisionViewsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> scheduleIds = null, string name = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var queryParameters = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParameters.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParameters.Add(new("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParameters.Add(new("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (scheduleIds is not null)
        {
            foreach (var scheduleId in scheduleIds)
            {
                queryParameters.Add(new("id", UriHelper.ParameterToString(scheduleId)));
            }
        }

        if (!string.IsNullOrEmpty(name))
        {
            queryParameters.Add(new("name", UriHelper.ParameterToString(name)));
        }

        if (divisionIds is not null)
        {
            foreach (var divisionId in divisionIds)
            {
                queryParameters.Add(new("divisionId", UriHelper.ParameterToString(divisionId)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/schedules/divisionviews", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScheduleDivisionViewEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<SystemPrompt> GetSystemPromptAsync(string promptId, bool? includeMediaUris = null, bool? includeResources = null, IEnumerable<string> languages = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (includeMediaUris.HasValue)
        {
            queryParameters.Add(new("includeMediaUris", UriHelper.ParameterToString(includeMediaUris.Value)));
        }

        if (includeResources.HasValue)
        {
            queryParameters.Add(new("includeResources", UriHelper.ParameterToString(includeResources.Value)));
        }

        if (languages is not null)
        {
            foreach (var language in languages)
            {
                queryParameters.Add(new("language", UriHelper.ParameterToString(language)));
            }
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/architect/systemprompts/{Uri.EscapeDataString(promptId)}", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SystemPrompt>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<HistoryListing> GetSystemPromptHistoryAsync(string promptId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, IEnumerable<string> actions = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        ArgumentException.ThrowIfNullOrEmpty(historyId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParams.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParams.Add(new("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParams.Add(new("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (actions is not null)
        {
            foreach (var action in actions)
            {
                queryParams.Add(new("action", UriHelper.ParameterToString(action)));
            }
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/architect/systemprompts/{Uri.EscapeDataString(promptId)}/history/{Uri.EscapeDataString(historyId)}", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<HistoryListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<SystemPromptAsset> GetSystemPromptResourceAsync(string promptId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"/api/v2/architect/systemprompts/{Uri.EscapeDataString(promptId)}/resources/{Uri.EscapeDataString(languageCode)}";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SystemPromptAsset>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<SystemPromptAssetEntityListing> GetSystemPromptResourcesAsync(string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParams.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParams.Add(new("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParams.Add(new("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/architect/systemprompts/{Uri.EscapeDataString(promptId)}/resources", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SystemPromptAssetEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<SystemPromptEntityListing> GetSystemPromptsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null, bool? includeMediaUris = null, bool? includeResources = null, IEnumerable<string> languages = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParams.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParams.Add(new("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParams.Add(new("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (!string.IsNullOrEmpty(name))
        {
            queryParams.Add(new("name", UriHelper.ParameterToString(name)));
        }

        if (!string.IsNullOrEmpty(description))
        {
            queryParams.Add(new("description", UriHelper.ParameterToString(description)));
        }

        if (!string.IsNullOrEmpty(nameOrDescription))
        {
            queryParams.Add(new("nameOrDescription", UriHelper.ParameterToString(nameOrDescription)));
        }

        if (includeMediaUris.HasValue)
        {
            queryParams.Add(new("includeMediaUris", UriHelper.ParameterToString(includeMediaUris.Value)));
        }

        if (includeResources.HasValue)
        {
            queryParams.Add(new("includeResources", UriHelper.ParameterToString(includeResources.Value)));
        }

        if (languages is not null)
        {
            foreach (var lang in languages)
            {
                queryParams.Add(new("language", UriHelper.ParameterToString(lang)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/architect/systemprompts", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SystemPromptEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Flow> GetFlowAsync(string flowId, bool? deleted = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (deleted.HasValue)
        {
            queryParameters.Add(new("deleted", UriHelper.ParameterToString(deleted.Value)));
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/flows/{UriHelper.ParameterToString(flowId)}", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Flow>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<HistoryListing> GetFlowHistoryAsync(string flowId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, IEnumerable<string> actions = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId);

        ArgumentException.ThrowIfNullOrEmpty(historyId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParameters.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParameters.Add(new("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParameters.Add(new("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (actions is not null)
        {
            foreach (var action in actions)
            {
                queryParameters.Add(new("action", UriHelper.ParameterToString(action)));
            }
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/flows/{UriHelper.ParameterToString(flowId)}/history/{UriHelper.ParameterToString(historyId)}", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<HistoryListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowSettingsResponse> GetFlowInstancesSettingsLogLevelsAsync(string flowId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();
        if (expand != null)
        {
            foreach (var field in expand)
            {
                queryParameters.Add(new("expand", UriHelper.ParameterToString(field)));
            }
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/flows/{UriHelper.ParameterToString(flowId)}/instances/settings/loglevels", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowSettingsResponse>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<object> GetFlowLatestConfigurationAsync(string flowId, bool? deleted = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (deleted.HasValue)
        {
            queryParameters.Add(new("deleted", UriHelper.ParameterToString(deleted.Value)));
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/flows/{UriHelper.ParameterToString(flowId)}/latestconfiguration", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<object>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowVersion> GetFlowVersionAsync(string flowId, string versionId, bool? deleted = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId);

        ArgumentException.ThrowIfNullOrEmpty(versionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (deleted.HasValue)
        {
            queryParameters.Add(new("deleted", UriHelper.ParameterToString(deleted.Value)));
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/flows/{UriHelper.ParameterToString(flowId)}/versions/{UriHelper.ParameterToString(versionId)}", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowVersion>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<object> GetFlowVersionConfigurationAsync(string flowId, string versionId, bool? deleted = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId);

        ArgumentException.ThrowIfNullOrEmpty(versionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (deleted.HasValue)
        {
            queryParameters.Add(new("deleted", UriHelper.ParameterToString(deleted.Value)));
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/flows/{UriHelper.ParameterToString(flowId)}/versions/{UriHelper.ParameterToString(versionId)}/configuration", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<object>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowHealth> GetFlowVersionHealthAsync(string flowId, string versionId, string language = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId);

        ArgumentException.ThrowIfNullOrEmpty(versionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();
        if (!string.IsNullOrEmpty(language))
        {
            queryParameters.Add(new("language", UriHelper.ParameterToString(language)));
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/flows/{UriHelper.ParameterToString(flowId)}/versions/{UriHelper.ParameterToString(versionId)}/health", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowHealth>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowHealthIntent> GetFlowVersionIntentHealthAsync(string flowId, string versionId, string intentId, string language, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId, nameof(flowId));

        ArgumentException.ThrowIfNullOrEmpty(versionId, nameof(versionId));

        ArgumentException.ThrowIfNullOrEmpty(intentId, nameof(intentId));

        ArgumentException.ThrowIfNullOrEmpty(language, nameof(language));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>
        {
            new("language", UriHelper.ParameterToString(language))
        };

        var relativePath = $"/api/v2/flows/{UriHelper.ParameterToString(flowId)}/versions/{UriHelper.ParameterToString(versionId)}/intents/{UriHelper.ParameterToString(intentId)}/health";

        var url = QueryHelpers.AddQueryString(relativePath, queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowHealthIntent>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowHealthUtterance> GetFlowVersionIntentUtteranceHealthAsync(string flowId, string versionId, string intentId, string utteranceId, string language, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId, nameof(flowId));

        ArgumentException.ThrowIfNullOrEmpty(versionId, nameof(versionId));

        ArgumentException.ThrowIfNullOrEmpty(intentId, nameof(intentId));

        ArgumentException.ThrowIfNullOrEmpty(utteranceId, nameof(utteranceId));

        ArgumentException.ThrowIfNullOrEmpty(language, nameof(language));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>
        {
            new("language", UriHelper.ParameterToString(language))
        };

        var url = QueryHelpers.AddQueryString($"/api/v2/flows/{UriHelper.ParameterToString(flowId)}/versions/{UriHelper.ParameterToString(versionId)}/intents/{UriHelper.ParameterToString(intentId)}/utterances/{UriHelper.ParameterToString(utteranceId)}/health", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowHealthUtterance>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowVersionEntityListing> GetFlowVersionsAsync(string flowId, int? pageNumber = null, int? pageSize = null, bool? deleted = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId, nameof(flowId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();
        if (pageNumber.HasValue)
        {
            queryParams.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (deleted.HasValue)
        {
            queryParams.Add(new("deleted", UriHelper.ParameterToString(deleted.Value)));
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/flows/{UriHelper.ParameterToString(flowId)}/versions", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowVersionEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowEntityListing> GetFlowsAsync(IEnumerable<string> types = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> ids = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, string lockedByClientId = null, string secure = null, bool? deleted = null, bool? includeSchemas = null, string publishedAfter = null, string publishedBefore = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (types is not null)
        {
            foreach (var t in types)
            {
                queryParameters.Add(new("type", UriHelper.ParameterToString(t)));
            }
        }

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParameters.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParameters.Add(new("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParameters.Add(new("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (ids is not null)
        {
            foreach (var id in ids)
            {
                queryParameters.Add(new("id", UriHelper.ParameterToString(id)));
            }
        }

        if (!string.IsNullOrEmpty(name))
        {
            queryParameters.Add(new("name", UriHelper.ParameterToString(name)));
        }

        if (!string.IsNullOrEmpty(description))
        {
            queryParameters.Add(new("description", UriHelper.ParameterToString(description)));
        }

        if (!string.IsNullOrEmpty(nameOrDescription))
        {
            queryParameters.Add(new("nameOrDescription", UriHelper.ParameterToString(nameOrDescription)));
        }

        if (!string.IsNullOrEmpty(publishVersionId))
        {
            queryParameters.Add(new("publishVersionId", UriHelper.ParameterToString(publishVersionId)));
        }

        if (!string.IsNullOrEmpty(editableBy))
        {
            queryParameters.Add(new("editableBy", UriHelper.ParameterToString(editableBy)));
        }

        if (!string.IsNullOrEmpty(lockedBy))
        {
            queryParameters.Add(new("lockedBy", UriHelper.ParameterToString(lockedBy)));
        }

        if (!string.IsNullOrEmpty(lockedByClientId))
        {
            queryParameters.Add(new("lockedByClientId", UriHelper.ParameterToString(lockedByClientId)));
        }

        if (!string.IsNullOrEmpty(secure))
        {
            queryParameters.Add(new("secure", UriHelper.ParameterToString(secure)));
        }

        if (deleted.HasValue)
        {
            queryParameters.Add(new("deleted", UriHelper.ParameterToString(deleted.Value)));
        }

        if (includeSchemas.HasValue)
        {
            queryParameters.Add(new("includeSchemas", UriHelper.ParameterToString(includeSchemas.Value)));
        }

        if (!string.IsNullOrEmpty(publishedAfter))
        {
            queryParameters.Add(new("publishedAfter", UriHelper.ParameterToString(publishedAfter)));
        }

        if (!string.IsNullOrEmpty(publishedBefore))
        {
            queryParameters.Add(new("publishedBefore", UriHelper.ParameterToString(publishedBefore)));
        }

        if (divisionIds is not null)
        {
            foreach (var divisionId in divisionIds)
            {
                queryParameters.Add(new("divisionId", UriHelper.ParameterToString(divisionId)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/flows", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<DataTable> GetFlowsDatatableAsync(string datatableId, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(datatableId, nameof(datatableId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();
        if (!string.IsNullOrEmpty(expand))
        {
            queryParams.Add(new("expand", UriHelper.ParameterToString(expand)));
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/flows/datatables/{Uri.EscapeDataString(datatableId)}", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataTable>(_options.JsonSerializerOptions, cancellationToken)!;
    }


    public async Task<DataTableExportJob> GetFlowsDatatableExportJobAsync(string dataTableId, string exportJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dataTableId, nameof(dataTableId));

        ArgumentException.ThrowIfNullOrEmpty(exportJobId, nameof(exportJobId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/flows/datatables/{Uri.EscapeDataString(dataTableId)}/export/jobs/{Uri.EscapeDataString(exportJobId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataTableExportJob>(_options.JsonSerializerOptions, cancellationToken)!;
    }


    public async Task<DataTableImportJob> GetFlowsDatatableImportJobAsync(string dataTableId, string importJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dataTableId, nameof(dataTableId));

        ArgumentException.ThrowIfNullOrEmpty(importJobId, nameof(importJobId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"/api/v2/flows/datatables/{Uri.EscapeDataString(dataTableId)}/import/jobs/{Uri.EscapeDataString(importJobId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataTableImportJob>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<DataTableImportEntityListing> GetFlowsDatatableImportJobsAsync(string dataTableId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dataTableId, nameof(dataTableId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();
        if (pageNumber.HasValue)
        {
            queryParameters.Add(new KeyValuePair<string, string>("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }
        if (pageSize.HasValue)
        {
            queryParameters.Add(new KeyValuePair<string, string>("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        var path = $"/api/v2/flows/datatables/{Uri.EscapeDataString(dataTableId)}/import/jobs";

        var url = QueryHelpers.AddQueryString(path, queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataTableImportEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }


    public async Task<Dictionary<string, object>> GetFlowsDatatableRowAsync(string dataTableId, string rowId, bool? showBrief = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dataTableId, nameof(dataTableId));

        ArgumentException.ThrowIfNullOrEmpty(rowId, nameof(rowId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();
        if (showBrief.HasValue)
        {
            queryParameters.Add(new KeyValuePair<string, string>("showbrief", UriHelper.ParameterToString(showBrief.Value)));
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/flows/datatables/{Uri.EscapeDataString(dataTableId)}/rows/{Uri.EscapeDataString(rowId)}", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Dictionary<string, object>>(_options.JsonSerializerOptions, cancellationToken);
    }


    public async Task<DataTableRowEntityListing> GetFlowsDatatableRowsAsync(string dataTableId, int? pageNumber = null, int? pageSize = null, bool? showBrief = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dataTableId, nameof(dataTableId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var singleParams = new Dictionary<string, object>
        {
            ["pageNumber"] = pageNumber,
            ["pageSize"] = pageSize,
            ["showbrief"] = showBrief,
            ["sortOrder"] = sortOrder
        };

        var queryParameters = new List<KeyValuePair<string, string>>();

        foreach (var keyValue in singleParams)
        {
            if (keyValue.Value is not null)
            {
                queryParameters.Add(new KeyValuePair<string, string>(keyValue.Key, UriHelper.ParameterToString(keyValue.Value)));
            }
        }

        var path = $"/api/v2/flows/datatables/{Uri.EscapeDataString(dataTableId)}/rows";

        var url = QueryHelpers.AddQueryString(path, queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataTableRowEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }


    public async Task<DataTablesDomainEntityListing> GetFlowsDatatablesAsync(string expand = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> divisionIds = null, string name = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var singleParams = new Dictionary<string, object>
        {
            ["expand"] = expand,
            ["pageNumber"] = pageNumber,
            ["pageSize"] = pageSize,
            ["sortBy"] = sortBy,
            ["sortOrder"] = sortOrder,
            ["name"] = name
        };

        var queryParameters = new List<KeyValuePair<string, string>>();

        foreach (var keyValues in singleParams)
        {
            if (keyValues.Value is not null)
            {
                queryParameters.Add(new KeyValuePair<string, string>(keyValues.Key, UriHelper.ParameterToString(keyValues.Value)));
            }
        }

        if (divisionIds is not null)
        {
            foreach (var divisionId in divisionIds)
            {
                queryParameters.Add(new KeyValuePair<string, string>("divisionId", UriHelper.ParameterToString(divisionId)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/flows/datatables", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataTablesDomainEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<DataTable> GetFlowsDatatablesDivisionViewAsync(string datatableId, string expand = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        ArgumentException.ThrowIfNullOrEmpty("parameterName");

        var singleParams = new Dictionary<string, object>
        {
            ["expand"] = expand
        };

        var queryParameters = new List<KeyValuePair<string, string>>();

        foreach (var valuepairs in singleParams)
        {
            if (valuepairs.Value is not null)
            {
                queryParameters.Add(new KeyValuePair<string, string>(valuepairs.Key, UriHelper.ParameterToString(valuepairs.Value)));
            }
        }

        var path = $"/api/v2/flows/datatables/divisionviews/{Uri.EscapeDataString(datatableId)}";

        var url = QueryHelpers.AddQueryString(path, queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataTable>(_options.JsonSerializerOptions, cancellationToken)!;
    }


    public async Task<DataTablesDomainEntityListing> GetFlowsDatatablesDivisionViewsAsync(string expand = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> divisionIds = null, string name = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var singleValueParams = new Dictionary<string, object>
        {
            ["expand"] = expand,
            ["pageNumber"] = pageNumber,
            ["pageSize"] = pageSize,
            ["sortBy"] = sortBy,
            ["sortOrder"] = sortOrder,
            ["name"] = name
        };

        var queryParameters = new List<KeyValuePair<string, string>>();

        foreach (var (key, value) in singleValueParams)
        {
            if (value is not null)
            {
                queryParameters.Add(new KeyValuePair<string, string>(key, UriHelper.ParameterToString(value)));
            }
        }

        if (divisionIds is not null)
        {
            foreach (var divisionId in divisionIds)
            {
                queryParameters.Add(new KeyValuePair<string, string>("divisionId", UriHelper.ParameterToString(divisionId)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/flows/datatables/divisionviews", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataTablesDomainEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }


    public async Task<FlowDivisionViewEntityListing> GetFlowsDivisionViewsAsync(IEnumerable<string> types = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> ids = null, string name = null, string publishVersionId = null, string publishedAfter = null, string publishedBefore = null, IEnumerable<string> divisionIds = null, bool? includeSchemas = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var singleValueParams = new Dictionary<string, object>
        {
            ["pageNumber"] = pageNumber,
            ["pageSize"] = pageSize,
            ["sortBy"] = sortBy,
            ["sortOrder"] = sortOrder,
            ["name"] = name,
            ["publishVersionId"] = publishVersionId,
            ["publishedAfter"] = publishedAfter,
            ["publishedBefore"] = publishedBefore,
            ["includeSchemas"] = includeSchemas
        };

        var queryParameters = new List<KeyValuePair<string, string>>();

        foreach (var (key, value) in singleValueParams)
        {
            if (value is not null)
            {
                queryParameters.Add(new KeyValuePair<string, string>(key, UriHelper.ParameterToString(value)));
            }
        }

        if (types is not null)
        {
            foreach (var type in types)
            {
                queryParameters.Add(new KeyValuePair<string, string>("type", UriHelper.ParameterToString(type)));
            }
        }

        if (ids is not null)
        {
            foreach (var id in ids)
            {
                queryParameters.Add(new KeyValuePair<string, string>("id", UriHelper.ParameterToString(id)));
            }
        }

        if (divisionIds is not null)
        {
            foreach (var divIDs in divisionIds)
            {
                queryParameters.Add(new KeyValuePair<string, string>("divisionId", UriHelper.ParameterToString(divIDs)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/flows/divisionviews", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowDivisionViewEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FlowRuntimeExecution> GetFlowsExecutionAsync(string flowExecutionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowExecutionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/flows/executions/{UriHelper.ParameterToString(flowExecutionId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowRuntimeExecution>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<ArchitectExportJobStateResponse> GetFlowsExportJobAsync(string jobId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (expand is not null)
        {
            foreach (var expanded in expand)
            {
                queryParameters.Add(new KeyValuePair<string, string>("expand", UriHelper.ParameterToString(expanded)));
            }
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/flows/export/jobs/{UriHelper.ParameterToString(jobId)}", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ArchitectExportJobStateResponse>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<GetFlowExecutionDataJobResult> GetFlowsInstanceAsync(string instanceId, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(instanceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var path = $"/api/v2/flows/instances/{UriHelper.ParameterToString(instanceId)}";

        var queryParams = new List<KeyValuePair<string, string>>();

        if (!string.IsNullOrEmpty(expand))
        {
            queryParams.Add(new KeyValuePair<string, string>("expand", UriHelper.ParameterToString(expand)));
        }

        var url = QueryHelpers.AddQueryString(path, queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GetFlowExecutionDataJobResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GetFlowExecutionDataJobResult> GetFlowsInstancesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"/api/v2/flows/instances/jobs/{UriHelper.ParameterToString(jobId)}";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GetFlowExecutionDataJobResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FlowsQueryCriteriaResponse> GetFlowsInstancesQueryCapabilitiesAsync(string expand = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (!string.IsNullOrEmpty(expand))
        {
            queryParameters.Add(new KeyValuePair<string, string>("expand", UriHelper.ParameterToString(expand)));
        }

        var url = QueryHelpers.AddQueryString("/api/v2/flows/instances/querycapabilities", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowsQueryCriteriaResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ExecutionDataFlowSettingsResponse> GetFlowsInstancesSettingsExecutionDataAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("/api/v2/flows/instances/settings/executiondata", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExecutionDataFlowSettingsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FlowSettingsResponseEntityListing> GetFlowsInstancesSettingsLoglevelsAsync(IEnumerable<string> expand = null, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParameters.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (expand is not null)
        {
            foreach (var e in expand)
            {
                queryParameters.Add(new("expand", UriHelper.ParameterToString(e)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/flows/instances/settings/loglevels", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowSettingsResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FlowLogLevelCharacteristicsDefinitions> GetFlowsInstancesSettingsLoglevelsCharacteristicsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "/api/v2/flows/instances/settings/loglevels/characteristics";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowLogLevelCharacteristicsDefinitions>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FlowSettingsResponse> GetFlowsInstancesSettingsLoglevelsDefaultAsync(IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (expand is not null)
        {
            foreach (var expaned in expand)
            {
                queryParameters.Add(new KeyValuePair<string, string>("expand", UriHelper.ParameterToString(expaned)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/flows/instances/settings/loglevels/default", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowSettingsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ArchitectJobStateResponse> GetFlowsJobAsync(string jobId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId, nameof(jobId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParams = new List<KeyValuePair<string, string>>();
        if (expand is not null)
        {
            foreach (var expaned in expand)
            {
                queryParams.Add(new KeyValuePair<string, string>("expand", UriHelper.ParameterToString(expaned)));
            }
        }

        var url = QueryHelpers.AddQueryString($"/api/v2/flows/jobs/{UriHelper.ParameterToString(jobId)}", queryParams);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ArchitectJobStateResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FlowMilestone> GetFlowsMilestoneAsync(string milestoneId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(milestoneId, nameof(milestoneId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"/api/v2/flows/milestones/{UriHelper.ParameterToString(milestoneId)}";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowMilestone>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowMilestoneListing> GetFlowsMilestonesAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> ids = null, string name = null, string description = null, string nameOrDescription = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParameters.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParameters.Add(new("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParameters.Add(new("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (ids is not null)
        {
            foreach (var id in ids)
            {
                queryParameters.Add(new("id", UriHelper.ParameterToString(id)));
            }
        }

        if (!string.IsNullOrEmpty(name))
        {
            queryParameters.Add(new("name", UriHelper.ParameterToString(name)));
        }

        if (!string.IsNullOrEmpty(description))
        {
            queryParameters.Add(new("description", UriHelper.ParameterToString(description)));
        }

        if (!string.IsNullOrEmpty(nameOrDescription))
        {
            queryParameters.Add(new("nameOrDescription", UriHelper.ParameterToString(nameOrDescription)));
        }

        if (divisionIds is not null)
        {
            foreach (var div in divisionIds)
            {
                queryParameters.Add(new("divisionId", UriHelper.ParameterToString(div)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/flows/milestones", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowMilestoneListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowMilestoneDivisionViewEntityListing> GetFlowsMilestonesDivisionViewsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> ids = null, string name = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParameters.Add(new("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParameters.Add(new("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParameters.Add(new("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (ids is not null)
        {
            foreach (var id in ids)
            {
                queryParameters.Add(new("id", UriHelper.ParameterToString(id)));
            }
        }

        if (!string.IsNullOrEmpty(name))
        {
            queryParameters.Add(new("name", UriHelper.ParameterToString(name)));
        }

        if (divisionIds is not null)
        {
            foreach (var divisionId in divisionIds)
            {
                queryParameters.Add(new("divisionId", UriHelper.ParameterToString(divisionId)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/flows/milestones/divisionviews", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowMilestoneDivisionViewEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowOutcome> GetFlowsOutcomeAsync(string flowOutcomeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowOutcomeId, nameof(flowOutcomeId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"/api/v2/flows/outcomes/{UriHelper.ParameterToString(flowOutcomeId)}";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowOutcome>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowOutcomeListing> GetFlowsOutcomesAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> ids = null, string name = null, string description = null, string nameOrDescription = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new KeyValuePair<string, string>("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParameters.Add(new KeyValuePair<string, string>("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParameters.Add(new KeyValuePair<string, string>("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParameters.Add(new KeyValuePair<string, string>("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (ids != null)
        {
            foreach (var id in ids)
            {
                queryParameters.Add(new KeyValuePair<string, string>("id", UriHelper.ParameterToString(id)));
            }
        }

        if (!string.IsNullOrEmpty(name))
        {
            queryParameters.Add(new KeyValuePair<string, string>("name", UriHelper.ParameterToString(name)));
        }

        if (!string.IsNullOrEmpty(description))
        {
            queryParameters.Add(new KeyValuePair<string, string>("description", UriHelper.ParameterToString(description)));
        }

        if (!string.IsNullOrEmpty(nameOrDescription))
        {
            queryParameters.Add(new KeyValuePair<string, string>("nameOrDescription", UriHelper.ParameterToString(nameOrDescription)));
        }

        if (divisionIds != null)
        {
            foreach (var div in divisionIds)
            {
                queryParameters.Add(new KeyValuePair<string, string>("divisionId", UriHelper.ParameterToString(div)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/flows/outcomes", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowOutcomeListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowOutcomeDivisionViewEntityListing> GetFlowsOutcomesDivisionViewsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, IEnumerable<string> ids = null, string name = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new KeyValuePair<string, string>("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParameters.Add(new KeyValuePair<string, string>("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParameters.Add(new KeyValuePair<string, string>("sortBy", UriHelper.ParameterToString(sortBy)));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParameters.Add(new KeyValuePair<string, string>("sortOrder", UriHelper.ParameterToString(sortOrder)));
        }

        if (ids != null)
        {
            foreach (var id in ids)
            {
                queryParameters.Add(new KeyValuePair<string, string>("id", UriHelper.ParameterToString(id)));
            }
        }

        if (!string.IsNullOrEmpty(name))
        {
            queryParameters.Add(new KeyValuePair<string, string>("name", UriHelper.ParameterToString(name)));
        }

        if (divisionIds != null)
        {
            foreach (var div in divisionIds)
            {
                queryParameters.Add(new KeyValuePair<string, string>("divisionId", UriHelper.ParameterToString(div)));
            }
        }

        var url = QueryHelpers.AddQueryString("/api/v2/flows/outcomes/divisionviews", queryParameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowOutcomeDivisionViewEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Grammar> PatchArchitectGrammarAsync(string grammarId, Grammar body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(grammarId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"/api/v2/architect/grammars/{UriHelper.ParameterToString(grammarId)}";

        var response = await client.PatchAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Grammar>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<GrammarLanguage> PatchArchitectGrammarLanguageAsync(string grammarId, string languageCode, GrammarLanguageUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        ArgumentException.ThrowIfNullOrEmpty(grammarId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"/api/v2/architect/grammars/{UriHelper.ParameterToString(grammarId)}/languages/{UriHelper.ParameterToString(languageCode)}";

        var response = await client.PatchAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GrammarLanguage>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<ExecutionDataFlowSettingsResponse> PatchFlowsInstancesSettingsExecutiondataAsync(ExecutionDataSettingsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "/api/v2/flows/instances/settings/executiondata";

        var response = await client.PatchAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExecutionDataFlowSettingsResponse>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<object> CreateArchitectDependencytrackingBuildAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/architect/dependencytracking/build", _options.JsonSerializerOptions, cancellationToken: cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<object>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<EmergencyGroup> CreateArchitectEmergencyGroupsAsync(EmergencyGroup body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/architect/emergencygroups", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmergencyGroup>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<UploadUrlResponse> CreateArchitectGrammarLanguageFilesDtmfAsync(string grammarId, string languageCode, GrammarFileUploadRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(grammarId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/grammars/{UriHelper.ParameterToString(grammarId)}/languages/{UriHelper.ParameterToString(languageCode)}/files/dtmf";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UploadUrlResponse>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<UploadUrlResponse> CreateArchitectGrammarLanguageFilesVoiceAsync(string grammarId, string languageCode, GrammarFileUploadRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(grammarId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/grammars/{UriHelper.ParameterToString(grammarId)}/languages/{UriHelper.ParameterToString(languageCode)}/files/voice";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UploadUrlResponse>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<GrammarLanguage> CreateArchitectGrammarLanguagesAsync(string grammarId, GrammarLanguage body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(grammarId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/grammars/{UriHelper.ParameterToString(grammarId)}/languages";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GrammarLanguage>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Grammar> CreateArchitectGrammarsAsync(Grammar body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/architect/grammars";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Grammar>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<IVR> CreateArchitectIvrsAsync(IVR body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/architect/ivrs";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IVR>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Operation> CreateArchitectPromptHistoryAsync(string promptId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/prompts/{UriHelper.ParameterToString(promptId)}/history";

        var response = await client.PostAsJsonAsync(url, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Operation>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<PromptAssetUpload> CreateArchitectPromptResourceUploadsAsync(string promptId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/prompts/{UriHelper.ParameterToString(promptId)}/resources/{UriHelper.ParameterToString(languageCode)}/uploads";

        var response = await client.PostAsJsonAsync(url, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PromptAssetUpload>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<PromptAsset> CreateArchitectPromptResourcesAsync(string promptId, PromptAssetCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/prompts/{UriHelper.ParameterToString(promptId)}/resources";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PromptAsset>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Prompt> CreateArchitectPromptsAsync(Prompt body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/architect/prompts";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Prompt>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<ScheduleGroup> CreateArchitectScheduleGroupsAsync(ScheduleGroup body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/architect/schedulegroups";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScheduleGroup>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Schedule> CreateArchitectSchedulesAsync(Schedule body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/architect/schedules";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Schedule>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Operation> CreateArchitectSystempromptHistoryAsync(string promptId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/systemprompts/{UriHelper.ParameterToString(promptId)}/history";

        var response = await client.PostAsJsonAsync(url, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Operation>(_options.JsonSerializerOptions, cancellationToken)!;
    }


    public async Task<PromptAssetUpload> CreateArchitectSystempromptResourceUploadsAsync(string promptId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/systemprompts/{UriHelper.ParameterToString(promptId)}/resources/{UriHelper.ParameterToString(languageCode)}/uploads";

        var response = await client.PostAsJsonAsync(url, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PromptAssetUpload>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<SystemPromptAsset> CreateArchitectSystempromptResourcesAsync(string promptId, SystemPromptAsset body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/systemprompts/{UriHelper.ParameterToString(promptId)}/resources";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SystemPromptAsset>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Operation> CreateFlowHistoryAsync(string flowId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/flows/{UriHelper.ParameterToString(flowId)}/history";

        var response = await client.PostAsJsonAsync<object>(url, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Operation>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowSettingsResponse> CreateFlowInstancesSettingsLoglevelsAsync(string flowId, FlowLogLevelRequest body, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (expand is not null)
        {
            foreach (var e in expand)
            {
                queryParameters.Add(new("expand", UriHelper.ParameterToString(e)));
            }
        }

        var url = QueryHelpers.AddQueryString($"api/v2/flows/{UriHelper.ParameterToString(flowId)}/instances/settings/loglevels", queryParameters);

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowSettingsResponse>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowVersion> CreateFlowVersionsAsync(string flowId, object body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/flows/{UriHelper.ParameterToString(flowId)}/versions";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowVersion>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Flow> CreateFlowsAsync(Flow body, string language = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows";

        if (!string.IsNullOrEmpty(language))
        {
            url = QueryHelpers.AddQueryString(url, "language", UriHelper.ParameterToString(language));
        }

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Flow>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Operation> CreateFlowsActionsCheckinAsync(string flow, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flow);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/actions/checkin";

        var response = await client.PostAsJsonAsync(url, flow, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Operation>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Flow> CreateFlowsActionsCheckoutAsync(string flow, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flow);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/actions/checkout";

        var response = await client.PostAsJsonAsync(url, flow, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Flow>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Flow> CreateFlowsActionsDeactivateAsync(string flow, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flow);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/actions/deactivate";

        var response = await client.PostAsJsonAsync(url, flow, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Flow>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Operation> CreateFlowsActionsPublishAsync(string flow, string version = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flow);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/actions/publish";

        var payload = new Dictionary<string, string>
        {
            ["flow"] = flow
        };

        if (version is not null)
        {
            payload["version"] = version;
        }

        var response = await client.PostAsJsonAsync(url, payload, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Operation>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Flow> CreateFlowsActionsRevertAsync(string flow, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flow);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/actions/revert";

        var response = await client.PostAsJsonAsync(url, flow, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Flow>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Flow> CreateFlowsActionsUnlockAsync(string flow, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flow);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/actions/unlock";

        var response = await client.PostAsJsonAsync(url, flow, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Flow>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<DataTableExportJob> CreateFlowsDatatableExportJobsAsync(string datatableId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(datatableId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/flows/datatables/{UriHelper.ParameterToString(datatableId)}/export/jobs";

        var response = await client.PostAsJsonAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataTableExportJob>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<DataTableImportJob> CreateFlowsDatatableImportJobsAsync(string datatableId, DataTableImportJob body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(datatableId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/flows/datatables/{UriHelper.ParameterToString(datatableId)}/import/jobs";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataTableImportJob>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Dictionary<string, object>> CreateFlowsDatatableRowsAsync(string datatableId, object dataTableRow, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(datatableId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/flows/datatables/{UriHelper.ParameterToString(datatableId)}/rows";

        var response = await client.PostAsJsonAsync(url, dataTableRow, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Dictionary<string, object>>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<DataTable> CreateFlowsDatatablesAsync(DataTable body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/datatables";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataTable>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowExecutionLaunchResponse> CreateFlowsExecutionsAsync(FlowExecutionLaunchRequest flowLaunchRequest, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(flowLaunchRequest, nameof(flowLaunchRequest));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/executions";

        var response = await client.PostAsJsonAsync(
            url, flowLaunchRequest, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowExecutionLaunchResponse>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<RegisterArchitectExportJobResponse> CreateFlowsExportJobsAsync(RegisterArchitectExportJob body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/export/jobs";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RegisterArchitectExportJobResponse>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<GetFlowExecutionDataJobResult> CreateFlowsInstancesJobsAsync(ExecutionDataRequest body, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/instances/jobs";

        if (!string.IsNullOrEmpty(expand))
        {
            url = QueryHelpers.AddQueryString(url, "expand", UriHelper.ParameterToString(expand));
        }

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GetFlowExecutionDataJobResult>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowResultEntityListing> CreateFlowsInstancesQueryAsync(CriteriaQuery body, bool? indexOnly = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body, nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/instances/query";

        var queryParams = new List<KeyValuePair<string, string>>();

        if (indexOnly.HasValue)
        {
            queryParams.Add(new KeyValuePair<string, string>(
                "indexOnly",
                UriHelper.ParameterToString(indexOnly.Value)
            ));
        }

        if (pageSize.HasValue)
        {
            queryParams.Add(new KeyValuePair<string, string>(
                "pageSize",
                UriHelper.ParameterToString(pageSize.Value)
            ));
        }

        if (queryParams.Any())
        {
            url = QueryHelpers.AddQueryString(url, queryParams);
        }

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowResultEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<RegisterArchitectJobResponse> CreateFlowsJobsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/jobs";

        var response = await client.PostAsJsonAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RegisterArchitectJobResponse>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowMilestone> CreateFlowsMilestonesAsync(FlowMilestone body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/milestones";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowMilestone>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowOutcome> CreateFlowsOutcomesAsync(FlowOutcome body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/outcomes";

        var response = await client.PostAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowOutcome>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<EmergencyGroup> UpdateArchitectEmergencygroupAsync(string emergencyGroupId, EmergencyGroup body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(emergencyGroupId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/emergencygroups/{UriHelper.ParameterToString(emergencyGroupId)}";

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmergencyGroup>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<IVR> UpdateArchitectIvrAsync(string ivrId, IVR body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(ivrId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/ivrs/{UriHelper.ParameterToString(ivrId)}";

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IVR>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<IdentityResolutionConfig> UpdateArchitectIvrIdentityresolutionAsync(string ivrId, IdentityResolutionConfig body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(ivrId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/ivrs/{UriHelper.ParameterToString(ivrId)}/identityresolution";

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IdentityResolutionConfig>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Prompt> UpdateArchitectPromptAsync(string promptId, Prompt body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/prompts/{UriHelper.ParameterToString(promptId)}";

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Prompt>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<PromptAsset> UpdateArchitectPromptResourceAsync(string promptId, string languageCode, PromptAsset body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/prompts/{UriHelper.ParameterToString(promptId)}/resources/{UriHelper.ParameterToString(languageCode)}";

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PromptAsset>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Schedule> UpdateArchitectScheduleAsync(string scheduleId, Schedule body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/schedules/{UriHelper.ParameterToString(scheduleId)}";

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Schedule>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<ScheduleGroup> UpdateArchitectScheduleGroupAsync(string scheduleGroupId, ScheduleGroup body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scheduleGroupId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/schedulegroups/{UriHelper.ParameterToString(scheduleGroupId)}";

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScheduleGroup>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<SystemPromptAsset> UpdateArchitectSystemPromptResourceAsync(string promptId, string languageCode, SystemPromptAsset body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(promptId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/architect/systemprompts/{UriHelper.ParameterToString(promptId)}/resources/{UriHelper.ParameterToString(languageCode)}";

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SystemPromptAsset>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Flow> UpdateFlowAsync(string flowId, Flow body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/flows/{UriHelper.ParameterToString(flowId)}";

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Flow>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowSettingsResponse> UpdateFlowInstancesSettingsLoglevelsAsync(string flowId, FlowLogLevelRequest body, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/flows/{UriHelper.ParameterToString(flowId)}/instances/settings/loglevels";

        if (expand?.Count > 0)
        {
            var Select = expand.Select(e => ("expand", UriHelper.ParameterToString(e)));
            url = QueryHelpers.AddQueryString(url, (IDictionary<string, string>)Select);
        }

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowSettingsResponse>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<DataTable> UpdateFlowsDatatableAsync(string datatableId, DataTable body, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(datatableId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/flows/datatables/{UriHelper.ParameterToString(datatableId)}";

        if (!string.IsNullOrEmpty(expand))
        {
            url = QueryHelpers.AddQueryString(url, "expand", UriHelper.ParameterToString(expand));
        }

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataTable>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Dictionary<string, object>> UpdateFlowsDatatableRowAsync(string datatableId, string rowId, object body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(datatableId);

        ArgumentException.ThrowIfNullOrEmpty(rowId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/flows/datatables/{UriHelper.ParameterToString(datatableId)}/rows/{UriHelper.ParameterToString(rowId)}";

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Dictionary<string, object>>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowSettingsResponse> UpdateFlowsInstancesSettingsLoglevelsDefaultAsync(FlowLogLevelRequest body, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/flows/instances/settings/loglevels/default";

        if (expand?.Count > 0)
        {
            var qs = string.Join("&", expand.Select(e => $"expand={UriHelper.ParameterToString(e)}"));
            url += "?" + qs;
        }

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowSettingsResponse>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<FlowMilestone> UpdateFlowsMilestoneAsync(string milestoneId, FlowMilestone body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(milestoneId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/flows/milestones/{UriHelper.ParameterToString(milestoneId)}";

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowMilestone>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<Operation> UpdateFlowsOutcomeAsync(string flowOutcomeId, FlowOutcome body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(flowOutcomeId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/flows/outcomes/{UriHelper.ParameterToString(flowOutcomeId)}";

        var response = await client.PutAsJsonAsync(url, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Operation>(_options.JsonSerializerOptions, cancellationToken)!;
    }

}
