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
    public async Task<BusinessUnitListing> GetBusinessUnitsAsync(string feature = null, string divisionId = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(feature))
        {
            parameters.Add("feature", UriHelper.ParameterToString(feature));
        }

        if (!string.IsNullOrEmpty(divisionId))
        {
            parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
        }

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/businessunits", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BusinessUnitResponse> GetBusinessUnitAsync(string businessUnitId, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var parameters = new NameValueCollection();

        if (expand != null && expand.Any())
        {
            parameters.Add("expand", string.Join(",", expand));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{businessUnitId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteBusinessUnitAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{businessUnitId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<ManagementUnitListing> GetManagementUnitsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (!string.IsNullOrEmpty(feature))
        {
            parameters.Add("feature", UriHelper.ParameterToString(feature));
        }

        if (!string.IsNullOrEmpty(divisionId))
        {
            parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
        }

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/managementunits", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ManagementUnitListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ManagementUnit> GetManagementUnitAsync(string managementUnitId, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();

        if (expand != null && expand.Any())
        {
            parameters.Add("expand", string.Join(",", expand));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{managementUnitId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ManagementUnit>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteManagementUnitAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{managementUnitId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<List<UserScheduleAdherence>> GetAdherenceAsync(List<string> userId, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(userId);

        var parameters = new NameValueCollection();

        if (userId.Any())
        {
            foreach (var id in userId)
            {
                parameters.Add("userId", UriHelper.ParameterToString(id));
            }
        }

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/adherence", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<UserScheduleAdherence>>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AdherenceExplanationResponse> GetAdherenceExplanationAsync(string explanationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(explanationId);

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/adherence/explanations/{explanationId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AdherenceExplanationResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AdherenceExplanationAsyncResponse> CreateAdherenceExplanationAsync(string agentId, AddAdherenceExplanationAdminRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/agents/{agentId}/adherence/explanations", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AdherenceExplanationAsyncResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WorkPlanListResponse> GetWorkPlansAsync(string managementUnitId, List<string> expand = null, List<string> exclude = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();

        if (expand != null && expand.Any())
        {
            parameters.Add("expand", string.Join(",", expand));
        }

        if (exclude != null && exclude.Any())
        {
            parameters.Add("exclude", string.Join(",", exclude));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanListResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WorkPlan> GetWorkPlanAsync(string managementUnitId, string workPlanId, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);

        var parameters = new NameValueCollection();

        if (expand != null && expand.Any())
        {
            parameters.Add("expand", string.Join(",", expand));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlan>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WorkPlan> CreateWorkPlanAsync(string managementUnitId, CreateWorkPlan body, string validationMode = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(validationMode))
        {
            parameters.Add("validationMode", UriHelper.ParameterToString(validationMode));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlan>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WorkPlan> UpdateWorkPlanAsync(string managementUnitId, string workPlanId, WorkPlan body, string validationMode = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(validationMode))
        {
            parameters.Add("validationMode", UriHelper.ParameterToString(validationMode));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}", parameters);

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlan>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteWorkPlanAsync(string managementUnitId, string workPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<BuScheduleListing> GetSchedulesAsync(string businessUnitId, string weekId, bool? includeOnlyPublished = null, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);

        var parameters = new NameValueCollection();

        if (includeOnlyPublished.HasValue)
        {
            parameters.Add("includeOnlyPublished", UriHelper.ParameterToString(includeOnlyPublished.Value));
        }

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuScheduleListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BuScheduleMetadata> GetScheduleAsync(string businessUnitId, string weekId, string scheduleId, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuScheduleMetadata>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BuAsyncScheduleResponse> DeleteScheduleAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuAsyncScheduleResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BuShortTermForecastListing> GetForecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuShortTermForecastListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BuShortTermForecast> GetForecastAsync(string businessUnitId, string weekDateId, string forecastId, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var parameters = new NameValueCollection();

        if (expand != null && expand.Any())
        {
            parameters.Add("expand", string.Join(",", expand));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuShortTermForecast>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteForecastAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<AsyncForecastOperationResult> CreateForecastAsync(string businessUnitId, string weekDateId, GenerateBuForecastRequest body, bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (forceAsync.HasValue)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/generate", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncForecastOperationResult>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TimeOffRequestList> GetTimeOffRequestsAsync(string managementUnitId, bool? forceDownloadService = null, TimeOffRequestQueryBody body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();

        if (forceDownloadService.HasValue)
        {
            parameters.Add("forceDownloadService", UriHelper.ParameterToString(forceDownloadService.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests/query", parameters);

        var response = body != null
            ? await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken)
            : await _httpClient.PostAsJsonAsync(uri, new { }, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffRequestList>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TimeOffRequestResponse> CreateTimeOffRequestAsync(string managementUnitId, CreateAdminTimeOffRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffRequestResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActivityCodeContainer> GetActivityCodesAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityCodeContainer>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActivityCode> CreateActivityCodeAsync(string businessUnitId, CreateActivityCodeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityCode>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteActivityCodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes/{activityCodeId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}