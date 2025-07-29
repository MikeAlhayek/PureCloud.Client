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

        if (feature != null)
        {
            parameters.Add("feature", UriHelper.ParameterToString(feature));
        }

        if (divisionId != null)
        {
            parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
        }

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/businessunits", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BusinessUnitResponse> GetBusinessUnitAsync(string businessUnitId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteBusinessUnitAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteManagementUnitAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitAsync(string managementUnitId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null, CancellationToken cancellationToken = default)
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

        if (expand != null)
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (feature != null)
        {
            parameters.Add("feature", UriHelper.ParameterToString(feature));
        }

        if (divisionId != null)
        {
            parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
        }

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/managementunits", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAdherenceAsync(List<string> userId, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(userId);

        var parameters = new NameValueCollection();

        foreach (var id in userId)
        {
            parameters.Add("userId", id);
        }

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/adherence", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetWorkPlansAsync(string managementUnitId, IEnumerable<string> expands = null, List<string> exclude = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        if (exclude != null)
        {
            foreach (var item in exclude)
            {
                parameters.Add("exclude", item);
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplans", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateWorkPlanAsync(string managementUnitId, string body, string validationMode = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (validationMode != null)
        {
            parameters.Add("validationMode", UriHelper.ParameterToString(validationMode));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplans", parameters);

        var content = new StringContent(body, System.Text.Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(uri, content, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetMyManagementUnitAsync(CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/agents/me/managementunit";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActivityCodeContainer> GetActivityCodesAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activitycodes";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityCodeContainer>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActivityCode> CreateActivityCodeAsync(string businessUnitId, CreateActivityCodeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activitycodes";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityCode>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteActivityCodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activitycodes/{Uri.EscapeDataString(activityCodeId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
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

        if (expand != null)
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuScheduleListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetScheduleAsync(string businessUnitId, string weekId, string scheduleId, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteScheduleAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetForecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteForecastAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> CreateTimeOffRequestAsync(string managementUnitId, CreateAdminTimeOffRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffrequests";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeletePlanningGroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/planninggroups/{Uri.EscapeDataString(planningGroupId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetPlanningGroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/planninggroups/{Uri.EscapeDataString(planningGroupId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetPlanningGroupsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/planninggroups";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetActivityPlanAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans/{Uri.EscapeDataString(activityPlanId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetActivityPlansAsync(string businessUnitId, string state = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var parameters = new NameValueCollection();

        if (state != null)
        {
            parameters.Add("state", UriHelper.ParameterToString(state));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetActivityPlanJobsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans/jobs";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetActivityPlanRunJobAsync(string businessUnitId, string activityPlanId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans/{Uri.EscapeDataString(activityPlanId)}/runs/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteServiceGoalTemplateAsync(string businessUnitId, string serviceGoalTemplateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(serviceGoalTemplateId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/servicegoaltemplates/{Uri.EscapeDataString(serviceGoalTemplateId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteStaffingGroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(staffingGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/staffinggroups/{Uri.EscapeDataString(staffingGroupId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWorkPlanAsync(string managementUnitId, string workPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplans/{Uri.EscapeDataString(workPlanId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWorkPlanRotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplanrotations/{Uri.EscapeDataString(workPlanRotationId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetAdherenceExplanationAsync(string explanationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(explanationId);

        var uri = $"api/v2/workforcemanagement/adherence/explanations/{Uri.EscapeDataString(explanationId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAdherenceExplanationsJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/adherence/explanations/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAdherenceHistoricalBulkJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/adherence/historical/bulk/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAdherenceHistoricalJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/adherence/historical/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAgentAdherenceExplanationAsync(string agentId, string explanationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentException.ThrowIfNullOrEmpty(explanationId);

        var uri = $"api/v2/workforcemanagement/agents/{Uri.EscapeDataString(agentId)}/adherence/explanations/{Uri.EscapeDataString(explanationId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAgentManagementUnitAsync(string agentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);

        var uri = $"api/v2/workforcemanagement/agents/{Uri.EscapeDataString(agentId)}/managementunit";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTimeOffLimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeofflimits/{Uri.EscapeDataString(timeOffLimitId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTimeOffPlanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffplans/{Uri.EscapeDataString(timeOffPlanId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetAlternativeShiftsSettingsAsync(CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/alternativeshifts/settings";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAlternativeShiftsTradeAsync(string tradeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(tradeId);

        var uri = $"api/v2/workforcemanagement/alternativeshifts/trades/{Uri.EscapeDataString(tradeId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAlternativeShiftsTradesAsync(bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (forceAsync.HasValue)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync.Value));
        }

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/alternativeshifts/trades", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAlternativeShiftsTradesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/alternativeshifts/trades/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAlternativeShiftsOffersJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/alternativeshifts/offers/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitAlternativeShiftsSettingsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/alternativeshifts/settings";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitAlternativeShiftsTradeAsync(string businessUnitId, string tradeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(tradeId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/alternativeshifts/trades/{Uri.EscapeDataString(tradeId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitAlternativeShiftsTradesSearchJobAsync(string businessUnitId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/alternativeshifts/trades/search/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWorkPlanBidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/workplanbids/{Uri.EscapeDataString(bidId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWorkPlanBidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/workplanbids/{Uri.EscapeDataString(bidId)}/groups/{Uri.EscapeDataString(bidGroupId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitIntradayPlanningGroupsAsync(string businessUnitId, string date, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(date);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/intraday/planninggroups?date={Uri.EscapeDataString(date)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitManagementUnitsAsync(string businessUnitId, string feature = null, string divisionId = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var parameters = new NameValueCollection();

        if (feature != null)
        {
            parameters.Add("feature", UriHelper.ParameterToString(feature));
        }

        if (divisionId != null)
        {
            parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/managementunits", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteCalendarUrlIcsAsync(CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/calendar/url/ics";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteBusinessUnitTimeOffLimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/timeofflimits/{Uri.EscapeDataString(timeOffLimitId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteBusinessUnitTimeOffPlanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/timeoffplans/{Uri.EscapeDataString(timeOffPlanId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(runId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/scheduling/runs/{Uri.EscapeDataString(runId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> CreateAdherenceExplanationAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/adherence/explanations";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> QueryAdherenceExplanationsAsync(string body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var parameters = new NameValueCollection();

        if (forceAsync.HasValue)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync.Value));
        }

        if (forceDownloadService.HasValue)
        {
            parameters.Add("forceDownloadService", UriHelper.ParameterToString(forceDownloadService.Value));
        }

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/adherence/explanations/query", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateAdherenceHistoricalAsync(string body = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/adherence/historical";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateAdherenceHistoricalBulkAsync(string body = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/adherence/historical/bulk";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateAgentAdherenceExplanationAsync(string agentId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/agents/{Uri.EscapeDataString(agentId)}/adherence/explanations";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateActivityPlanAsync(string businessUnitId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateActivityPlanRunJobAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans/{Uri.EscapeDataString(activityPlanId)}/runs/jobs";

        var response = await _httpClient.PostAsync(uri, null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateAlternativeShiftTradeAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/alternativeshifts/trades";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateAlternativeShiftOffersJobAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/alternativeshifts/offers/jobs";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> SearchAlternativeShiftOffersAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/alternativeshifts/offers/search/jobs";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> SearchBusinessUnitAlternativeShiftTradesAsync(string businessUnitId, string body, bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var parameters = new NameValueCollection();

        if (forceAsync.HasValue)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/alternativeshifts/trades/search", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> SearchBusinessUnitAgentSchedulesAsync(string businessUnitId, string body = null, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var parameters = new NameValueCollection();

        if (forceAsync.HasValue)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync.Value));
        }

        if (forceDownloadService.HasValue)
        {
            parameters.Add("forceDownloadService", UriHelper.ParameterToString(forceDownloadService.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/agentschedules/search", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateBusinessUnitIntradayAsync(string businessUnitId, string body = null, bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var parameters = new NameValueCollection();

        if (forceAsync.HasValue)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/intraday", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> MoveAgentsAsync(string body = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/agents";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> QueryAgentsIntegrationsAsync(string body = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/agents/integrations/hris/query";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAgentsPossibleWorkShiftsAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/agents/me/possibleworkshifts";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetMyAgentScheduleAsync(string body = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/agentschedules/mine";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateAgentAdherenceExplanationAsync(string agentId, string explanationId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentException.ThrowIfNullOrEmpty(explanationId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/agents/{Uri.EscapeDataString(agentId)}/adherence/explanations/{Uri.EscapeDataString(explanationId)}";

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateAlternativeShiftTradeAsync(string tradeId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(tradeId);

        var uri = $"api/v2/workforcemanagement/alternativeshifts/trades/{Uri.EscapeDataString(tradeId)}";

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BusinessUnitResponse> UpdateBusinessUnitAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}";

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActivityCode> UpdateActivityCodeAsync(string businessUnitId, string activityCodeId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activitycodes/{Uri.EscapeDataString(activityCodeId)}";

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityCode>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateActivityPlanAsync(string businessUnitId, string activityPlanId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans/{Uri.EscapeDataString(activityPlanId)}";

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdatePlanningGroupAsync(string businessUnitId, string planningGroupId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/planninggroups/{Uri.EscapeDataString(planningGroupId)}";

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task UpdateSchedulingRunAsync(string businessUnitId, string runId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(runId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/scheduling/runs/{Uri.EscapeDataString(runId)}";

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<string> UpdateServiceGoalTemplateAsync(string businessUnitId, string serviceGoalTemplateId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(serviceGoalTemplateId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/servicegoaltemplates/{Uri.EscapeDataString(serviceGoalTemplateId)}";

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateStaffingGroupAsync(string businessUnitId, string staffingGroupId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(staffingGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/staffinggroups/{Uri.EscapeDataString(staffingGroupId)}";

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateWorkPlanAsync(string managementUnitId, string workPlanId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplans/{Uri.EscapeDataString(workPlanId)}";

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateTimeOffPlanAsync(string managementUnitId, string timeOffPlanId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffplans/{Uri.EscapeDataString(timeOffPlanId)}";

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitActivityCodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activitycodes/{Uri.EscapeDataString(activityCodeId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetWorkPlanAsync(string managementUnitId, string workPlanId, IEnumerable<string> includeOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);

        var parameters = new NameValueCollection();

        if (includeOnly != null)
        {
            foreach (var include in includeOnly)
            {
                parameters.Add("includeOnly", UriHelper.ParameterToString(include));
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplans/{Uri.EscapeDataString(workPlanId)}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetWorkPlanRotationsAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplanrotations";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetWorkPlanRotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplanrotations/{Uri.EscapeDataString(workPlanRotationId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeOffLimitsAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeofflimits";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeOffLimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeofflimits/{Uri.EscapeDataString(timeOffLimitId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeOffPlansAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffplans";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeOffPlanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffplans/{Uri.EscapeDataString(timeOffPlanId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetShortTermForecastAsync(string businessUnitId, string weekDateId, string forecastId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", UriHelper.ParameterToString(expand));
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetShortTermForecastDataAsync(string businessUnitId, string weekDateId, string forecastId, int? weekNumber = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var parameters = new NameValueCollection();

        if (weekNumber.HasValue)
        {
            parameters.Add("weekNumber", UriHelper.ParameterToString(weekNumber.Value));
        }

        if (forceDownloadService.HasValue)
        {
            parameters.Add("forceDownloadService", UriHelper.ParameterToString(forceDownloadService.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}/data", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetShortTermForecastGenerationResultsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}/generationresults";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetShortTermForecastPlanningGroupsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}/planninggroups";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetShortTermForecastStaffingRequirementAsync(string businessUnitId, string weekDateId, string forecastId, IEnumerable<string> weekNumbers = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var parameters = new NameValueCollection();

        if (weekNumbers != null)
        {
            foreach (var weekNumber in weekNumbers)
            {
                parameters.Add("weekNumbers", UriHelper.ParameterToString(weekNumber));
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}/staffingrequirement", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetShortTermForecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetScheduleHeadcountForecastAsync(string businessUnitId, string weekId, string scheduleId, bool? forceDownload = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var parameters = new NameValueCollection();

        if (forceDownload.HasValue)
        {
            parameters.Add("forceDownload", UriHelper.ParameterToString(forceDownload.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/headcountforecast", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeOffRequestsAsync(string managementUnitId, bool? recentlyReviewed = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();

        if (recentlyReviewed.HasValue)
        {
            parameters.Add("recentlyReviewed", UriHelper.ParameterToString(recentlyReviewed.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffrequests", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeOffRequestAsync(string managementUnitId, string timeOffRequestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffrequests/{Uri.EscapeDataString(timeOffRequestId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateShortTermForecastAsync(string businessUnitId, string weekDateId, string body, bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var parameters = new NameValueCollection();

        if (forceAsync.HasValue)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GenerateShortTermForecastAsync(string businessUnitId, string weekDateId, string forecastId, string body, bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var parameters = new NameValueCollection();

        if (forceAsync.HasValue)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}/generate", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CopyShortTermForecastAsync(string businessUnitId, string weekDateId, string forecastId, string body, bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var parameters = new NameValueCollection();

        if (forceAsync.HasValue)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}/copy", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateShortTermForecastAsync(string businessUnitId, string weekDateId, string forecastId, string body, bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var parameters = new NameValueCollection();

        if (forceAsync.HasValue)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}", parameters);

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateTimeOffRequestsAsync(string managementUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffrequests";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateTimeOffRequestAsync(string managementUnitId, string timeOffRequestId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffrequests/{Uri.EscapeDataString(timeOffRequestId)}";

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetNotificationSubscriptionsAsync(CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/notifications/subscriptions";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateNotificationSubscriptionAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/notifications/subscriptions";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteNotificationSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(subscriptionId);

        var uri = $"api/v2/workforcemanagement/notifications/subscriptions/{Uri.EscapeDataString(subscriptionId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitSettingsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/settings";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateBusinessUnitSettingsAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/settings";

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetScheduleGenerationResultsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/generationresults";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetScheduleHistoryAgentAsync(string businessUnitId, string weekId, string scheduleId, string agentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(agentId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/history/agents/{Uri.EscapeDataString(agentId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetSchedulePerformancePredictionsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/performancepredictions";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetSchedulePerformancePredictionsRecalculationAsync(string businessUnitId, string weekId, string scheduleId, string recalculationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(recalculationId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/performancepredictions/recalculations/{Uri.EscapeDataString(recalculationId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitScheduleAsync(string managementUnitId, string weekId, string scheduleId, string expand = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (forceDownloadService.HasValue)
        {
            parameters.Add("forceDownloadService", UriHelper.ParameterToString(forceDownloadService.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> QueryScheduleAgentSchedulesAsync(string businessUnitId, string weekId, string scheduleId, string body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var parameters = new NameValueCollection();

        if (forceAsync.HasValue)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync.Value));
        }

        if (forceDownloadService.HasValue)
        {
            parameters.Add("forceDownloadService", UriHelper.ParameterToString(forceDownloadService.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/agentschedules/query", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CopyScheduleAsync(string businessUnitId, string weekId, string scheduleId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/copy";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateSchedulePerformancePredictionsRecalculationAsync(string businessUnitId, string weekId, string scheduleId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/performancepredictions/recalculations";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateSchedulePerformancePredictionsRecalculationUploadUrlAsync(string businessUnitId, string weekId, string scheduleId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/performancepredictions/recalculations/uploadurl";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> RescheduleAsync(string businessUnitId, string weekId, string scheduleId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/reschedule";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateScheduleAsync(string businessUnitId, string weekId, string scheduleId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/update";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateScheduleUpdateUploadUrlAsync(string businessUnitId, string weekId, string scheduleId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/update/uploadurl";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> SearchManagementUnitAgentSchedulesAsync(string managementUnitId, string body = null, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();

        if (forceAsync.HasValue)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync.Value));
        }

        if (forceDownloadService.HasValue)
        {
            parameters.Add("forceDownloadService", UriHelper.ParameterToString(forceDownloadService.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/agentschedules/search", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetUsersAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expands = null, string feature = null, string state = null, string divisionId = null, CancellationToken cancellationToken = default)
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

        if (sortBy != null)
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", UriHelper.ParameterToString(expand));
            }
        }

        if (feature != null)
        {
            parameters.Add("feature", UriHelper.ParameterToString(feature));
        }

        if (state != null)
        {
            parameters.Add("state", UriHelper.ParameterToString(state));
        }

        if (divisionId != null)
        {
            parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
        }

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/users", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetUserAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var uri = $"api/v2/workforcemanagement/users/{Uri.EscapeDataString(userId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetCalendarUrlIcsAsync(CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/calendar/url/ics";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateCalendarUrlIcsAsync(string body = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/calendar/url/ics";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeZonesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/timezones", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeZoneAsync(string timeZoneId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(timeZoneId);

        var uri = $"api/v2/workforcemanagement/timezones/{Uri.EscapeDataString(timeZoneId)}";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }
}
