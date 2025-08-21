using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class WorkforceManagementApi : IWorkforceManagementApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public WorkforceManagementApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/businessunits", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitListing>(_options.JsonSerializerOptions, cancellationToken);
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteBusinessUnitAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}";

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteManagementUnitAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}";

        var response = await client.DeleteAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAdherenceAsync(IEnumerable<string> userId, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(userId);

        var parameters = new NameValueCollection();

        foreach (var id in userId)
        {
            parameters.Add("userId", id);
        }

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/adherence", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetWorkPlansAsync(string managementUnitId, IEnumerable<string> expands = null, IEnumerable<string> exclude = null, CancellationToken cancellationToken = default)
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync(uri, content, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetMyManagementUnitAsync(CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/agents/me/managementunit";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActivityCodeContainer> GetActivityCodesAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activitycodes";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityCodeContainer>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActivityCode> CreateActivityCodeAsync(string businessUnitId, CreateActivityCodeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activitycodes";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityCode>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteActivityCodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activitycodes/{Uri.EscapeDataString(activityCodeId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuScheduleListing>(_options.JsonSerializerOptions, cancellationToken);
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetForecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> CreateTimeOffRequestAsync(string managementUnitId, CreateAdminTimeOffRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffrequests";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeletePlanningGroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/planninggroups/{Uri.EscapeDataString(planningGroupId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetPlanningGroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/planninggroups/{Uri.EscapeDataString(planningGroupId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetPlanningGroupsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/planninggroups";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetActivityPlanAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans/{Uri.EscapeDataString(activityPlanId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetActivityPlanJobsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans/jobs";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteServiceGoalTemplateAsync(string businessUnitId, string serviceGoalTemplateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(serviceGoalTemplateId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/servicegoaltemplates/{Uri.EscapeDataString(serviceGoalTemplateId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteStaffingGroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(staffingGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/staffinggroups/{Uri.EscapeDataString(staffingGroupId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWorkPlanAsync(string managementUnitId, string workPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplans/{Uri.EscapeDataString(workPlanId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWorkPlanRotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplanrotations/{Uri.EscapeDataString(workPlanRotationId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetAdherenceExplanationAsync(string explanationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(explanationId);

        var uri = $"api/v2/workforcemanagement/adherence/explanations/{Uri.EscapeDataString(explanationId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAdherenceExplanationsJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/adherence/explanations/jobs/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAdherenceHistoricalBulkJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/adherence/historical/bulk/jobs/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAdherenceHistoricalJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/adherence/historical/jobs/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAgentAdherenceExplanationAsync(string agentId, string explanationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentException.ThrowIfNullOrEmpty(explanationId);

        var uri = $"api/v2/workforcemanagement/agents/{Uri.EscapeDataString(agentId)}/adherence/explanations/{Uri.EscapeDataString(explanationId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAgentManagementUnitAsync(string agentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);

        var uri = $"api/v2/workforcemanagement/agents/{Uri.EscapeDataString(agentId)}/managementunit";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTimeOffLimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeofflimits/{Uri.EscapeDataString(timeOffLimitId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTimeOffPlanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffplans/{Uri.EscapeDataString(timeOffPlanId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetAlternativeShiftsSettingsAsync(CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/alternativeshifts/settings";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAlternativeShiftsTradeAsync(string tradeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(tradeId);

        var uri = $"api/v2/workforcemanagement/alternativeshifts/trades/{Uri.EscapeDataString(tradeId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAlternativeShiftsTradesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/alternativeshifts/trades/jobs/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAlternativeShiftsOffersJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/alternativeshifts/offers/jobs/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitAlternativeShiftsSettingsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/alternativeshifts/settings";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitAlternativeShiftsTradeAsync(string businessUnitId, string tradeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(tradeId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/alternativeshifts/trades/{Uri.EscapeDataString(tradeId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitAlternativeShiftsTradesSearchJobAsync(string businessUnitId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/alternativeshifts/trades/search/jobs/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWorkPlanBidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/workplanbids/{Uri.EscapeDataString(bidId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteWorkPlanBidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/workplanbids/{Uri.EscapeDataString(bidId)}/groups/{Uri.EscapeDataString(bidGroupId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitIntradayPlanningGroupsAsync(string businessUnitId, string date, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(date);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/intraday/planninggroups?date={Uri.EscapeDataString(date)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteCalendarUrlIcsAsync(CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/calendar/url/ics";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteBusinessUnitTimeOffLimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/timeofflimits/{Uri.EscapeDataString(timeOffLimitId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteBusinessUnitTimeOffPlanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/timeoffplans/{Uri.EscapeDataString(timeOffPlanId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(runId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/scheduling/runs/{Uri.EscapeDataString(runId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> CreateAdherenceExplanationAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/adherence/explanations";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateAdherenceHistoricalAsync(string body = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/adherence/historical";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateAdherenceHistoricalBulkAsync(string body = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/adherence/historical/bulk";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateAgentAdherenceExplanationAsync(string agentId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/agents/{Uri.EscapeDataString(agentId)}/adherence/explanations";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateActivityPlanAsync(string businessUnitId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateActivityPlanRunJobAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans/{Uri.EscapeDataString(activityPlanId)}/runs/jobs";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync(uri, null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateAlternativeShiftTradeAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/alternativeshifts/trades";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateAlternativeShiftOffersJobAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/alternativeshifts/offers/jobs";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> SearchAlternativeShiftOffersAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/alternativeshifts/offers/search/jobs";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> MoveAgentsAsync(string body = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/agents";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> QueryAgentsIntegrationsAsync(string body = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/agents/integrations/hris/query";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAgentsPossibleWorkShiftsAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/agents/me/possibleworkshifts";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetMyAgentScheduleAsync(string body = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/agentschedules/mine";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateAlternativeShiftTradeAsync(string tradeId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(tradeId);

        var uri = $"api/v2/workforcemanagement/alternativeshifts/trades/{Uri.EscapeDataString(tradeId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BusinessUnitResponse> UpdateBusinessUnitAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActivityCode> UpdateActivityCodeAsync(string businessUnitId, string activityCodeId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activitycodes/{Uri.EscapeDataString(activityCodeId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityCode>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateActivityPlanAsync(string businessUnitId, string activityPlanId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans/{Uri.EscapeDataString(activityPlanId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdatePlanningGroupAsync(string businessUnitId, string planningGroupId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/planninggroups/{Uri.EscapeDataString(planningGroupId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task UpdateSchedulingRunAsync(string businessUnitId, string runId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(runId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/scheduling/runs/{Uri.EscapeDataString(runId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<string> UpdateServiceGoalTemplateAsync(string businessUnitId, string serviceGoalTemplateId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(serviceGoalTemplateId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/servicegoaltemplates/{Uri.EscapeDataString(serviceGoalTemplateId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateStaffingGroupAsync(string businessUnitId, string staffingGroupId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(staffingGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/staffinggroups/{Uri.EscapeDataString(staffingGroupId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateWorkPlanAsync(string managementUnitId, string workPlanId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplans/{Uri.EscapeDataString(workPlanId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateTimeOffPlanAsync(string managementUnitId, string timeOffPlanId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffplans/{Uri.EscapeDataString(timeOffPlanId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitActivityCodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activitycodes/{Uri.EscapeDataString(activityCodeId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetWorkPlanRotationsAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplanrotations";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetWorkPlanRotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplanrotations/{Uri.EscapeDataString(workPlanRotationId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeOffLimitsAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeofflimits";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeOffLimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeofflimits/{Uri.EscapeDataString(timeOffLimitId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeOffPlansAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffplans";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeOffPlanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffplans/{Uri.EscapeDataString(timeOffPlanId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetShortTermForecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeOffRequestAsync(string managementUnitId, string timeOffRequestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffrequests/{Uri.EscapeDataString(timeOffRequestId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateTimeOffRequestsAsync(string managementUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffrequests";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateTimeOffRequestAsync(string managementUnitId, string timeOffRequestId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffrequests/{Uri.EscapeDataString(timeOffRequestId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetNotificationSubscriptionsAsync(CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/notifications/subscriptions";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateNotificationSubscriptionAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/notifications/subscriptions";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteNotificationSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(subscriptionId);

        var uri = $"api/v2/workforcemanagement/notifications/subscriptions/{Uri.EscapeDataString(subscriptionId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitSettingsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/settings";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateBusinessUnitSettingsAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/settings";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetUserAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var uri = $"api/v2/workforcemanagement/users/{Uri.EscapeDataString(userId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetCalendarUrlIcsAsync(CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/calendar/url/ics";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateCalendarUrlIcsAsync(string body = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/calendar/url/ics";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeZoneAsync(string timeZoneId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(timeZoneId);

        var uri = $"api/v2/workforcemanagement/timezones/{Uri.EscapeDataString(timeZoneId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitsDivisionViewsAsync(IEnumerable<string> divisionId = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (divisionId != null)
        {
            foreach (var item in divisionId)
            {
                parameters.Add("divisionId", UriHelper.ParameterToString(item));
            }
        }

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/businessunits/divisionviews", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitActivityPlansAsync(string businessUnitId, string state = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var parameters = new NameValueCollection();

        if (state != null)
        {
            parameters.Add("state", UriHelper.ParameterToString(state));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitActivityPlanJobsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans/jobs";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitActivityPlanRunJobAsync(string businessUnitId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activityplans/runs/jobs/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitPlanningGroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/planninggroups/{Uri.EscapeDataString(planningGroupId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitServiceGoalTemplateAsync(string businessUnitId, string serviceGoalTemplateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(serviceGoalTemplateId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/servicegoaltemplates/{Uri.EscapeDataString(serviceGoalTemplateId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitServiceGoalTemplatesAsync(string businessUnitId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/servicegoaltemplates", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitStaffingGroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(staffingGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/staffinggroups/{Uri.EscapeDataString(staffingGroupId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitStaffingGroupsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/staffinggroups";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitTimeOffLimitsAsync(string businessUnitId, string managementUnitId = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var parameters = new NameValueCollection();

        if (managementUnitId != null)
        {
            parameters.Add("managementUnitId", UriHelper.ParameterToString(managementUnitId));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/timeofflimits", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitTimeOffLimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/timeofflimits/{Uri.EscapeDataString(timeOffLimitId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitTimeOffPlansAsync(string businessUnitId, string managementUnitId = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var parameters = new NameValueCollection();

        if (managementUnitId != null)
        {
            parameters.Add("managementUnitId", UriHelper.ParameterToString(managementUnitId));
        }

        if (forceDownloadService != null)
        {
            parameters.Add("forceDownloadService", UriHelper.ParameterToString(forceDownloadService));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/timeoffplans", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitTimeOffPlanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/timeoffplans/{Uri.EscapeDataString(timeOffPlanId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitWeekSchedulesAsync(string businessUnitId, string weekId, bool? includeOnlyPublished = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);

        var parameters = new NameValueCollection();

        if (includeOnlyPublished != null)
        {
            parameters.Add("includeOnlyPublished", UriHelper.ParameterToString(includeOnlyPublished));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitWeekScheduleAsync(string businessUnitId, string weekId, string scheduleId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitWeekScheduleGenerationResultsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/generationresults";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitWeekShortTermForecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitWeekShortTermForecastAsync(string businessUnitId, string weekDateId, string forecastId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitWeekShortTermForecastDataAsync(string businessUnitId, string weekDateId, string forecastId, int? weekNumber = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var parameters = new NameValueCollection();

        if (weekNumber != null)
        {
            parameters.Add("weekNumber", UriHelper.ParameterToString(weekNumber));
        }

        if (forceDownloadService != null)
        {
            parameters.Add("forceDownloadService", UriHelper.ParameterToString(forceDownloadService));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}/data", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitWeekShortTermForecastGenerationResultsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}/generationresults";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitWeekShortTermForecastPlanningGroupsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}/planninggroups";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitWeekShortTermForecastStaffingRequirementAsync(string businessUnitId, string weekDateId, string forecastId, IEnumerable<string> weekNumbers = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var parameters = new NameValueCollection();

        if (weekNumbers != null)
        {
            foreach (var item in weekNumbers)
            {
                parameters.Add("weekNumbers", UriHelper.ParameterToString(item));
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}/staffingrequirement", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitWorkPlanBidsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/workplanbids";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitWorkPlanBidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/workplanbids/{Uri.EscapeDataString(bidId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitWorkPlanBidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/workplanbids/{Uri.EscapeDataString(bidId)}/groups/{Uri.EscapeDataString(bidGroupId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitWorkPlanBidGroupSummaryAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/workplanbids/{Uri.EscapeDataString(bidId)}/groups/{Uri.EscapeDataString(bidGroupId)}/summary";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitWorkPlanBidGroupPreferencesAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/workplanbids/{Uri.EscapeDataString(bidId)}/groups/{Uri.EscapeDataString(bidGroupId)}/preferences";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitWorkPlansAsync(string managementUnitId, IEnumerable<string> expand = null, IEnumerable<string> exclude = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (exclude != null)
        {
            foreach (var item in exclude)
            {
                parameters.Add("exclude", UriHelper.ParameterToString(item));
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplans", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitWorkPlanAsync(string managementUnitId, string workPlanId, IEnumerable<string> includeOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);

        var parameters = new NameValueCollection();

        if (includeOnly != null)
        {
            foreach (var item in includeOnly)
            {
                parameters.Add("includeOnly", UriHelper.ParameterToString(item));
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplans/{Uri.EscapeDataString(workPlanId)}", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitWorkPlanRotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplanrotations/{Uri.EscapeDataString(workPlanRotationId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitSchedulesAsync(string managementUnitId, bool? includeOnlyPublished = null, string earliestWeekDate = null, string latestWeekDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();

        if (includeOnlyPublished != null)
        {
            parameters.Add("includeOnlyPublished", UriHelper.ParameterToString(includeOnlyPublished));
        }

        if (earliestWeekDate != null)
        {
            parameters.Add("earliestWeekDate", UriHelper.ParameterToString(earliestWeekDate));
        }

        if (latestWeekDate != null)
        {
            parameters.Add("latestWeekDate", UriHelper.ParameterToString(latestWeekDate));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/schedules", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitTimeOffRequestsAsync(string managementUnitId, bool? recentlyReviewed = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();

        if (recentlyReviewed != null)
        {
            parameters.Add("recentlyReviewed", UriHelper.ParameterToString(recentlyReviewed));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffrequests", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitTimeOffRequestAsync(string managementUnitId, string timeOffRequestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffrequests/{Uri.EscapeDataString(timeOffRequestId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateBusinessUnitServiceGoalTemplateAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/servicegoaltemplates";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateBusinessUnitStaffingGroupAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/staffinggroups";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateBusinessUnitTimeOffLimitAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/timeofflimits";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateBusinessUnitTimeOffPlanAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/timeoffplans";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateBusinessUnitWeekScheduleAsync(string businessUnitId, string weekId, string body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var parameters = new NameValueCollection();

        if (forceAsync != null)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync));
        }

        if (forceDownloadService != null)
        {
            parameters.Add("forceDownloadService", UriHelper.ParameterToString(forceDownloadService));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateBusinessUnitWeekScheduleCopyAsync(string businessUnitId, string weekId, string scheduleId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/copy";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateBusinessUnitWeekScheduleRescheduleAsync(string businessUnitId, string weekId, string scheduleId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}/reschedule";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateBusinessUnitWorkPlanBidAsync(string businessUnitId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/workplanbids";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateBusinessUnitWorkPlanBidGroupAsync(string businessUnitId, string bidId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/workplanbids/{Uri.EscapeDataString(bidId)}/groups";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateManagementUnitAsync(string body = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/managementunits";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateManagementUnitTimeOffLimitAsync(string managementUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeofflimits";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateManagementUnitTimeOffPlanAsync(string managementUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffplans";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateManagementUnitWorkPlanRotationAsync(string managementUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplanrotations";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateManagementUnitWorkPlanAsync(string managementUnitId, string body, string validationMode = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var parameters = new NameValueCollection();

        if (validationMode != null)
        {
            parameters.Add("validationMode", UriHelper.ParameterToString(validationMode));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplans", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateSchedulesAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/schedules";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateTimeOffBalanceJobAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/timeoffbalance/jobs";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateTimeOffLimitsAvailableQueryAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/timeofflimits/available/query";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateTimeOffRequestsEstimateAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/timeoffrequests/estimate";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateTimeOffRequestsIntegrationStatusQueryAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/timeoffrequests/integrationstatus/query";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateTeamAdherenceHistoricalAsync(string teamId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(teamId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/teams/{Uri.EscapeDataString(teamId)}/adherence/historical";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateTeamShrinkageJobAsync(string teamId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(teamId);

        var uri = $"api/v2/workforcemanagement/teams/{Uri.EscapeDataString(teamId)}/shrinkage/jobs";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateAgentIntegrationsHrisAsync(string agentId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/agents/{Uri.EscapeDataString(agentId)}/integrations/hris";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateBusinessUnitTimeOffLimitValuesAsync(string businessUnitId, string timeOffLimitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/timeofflimits/{Uri.EscapeDataString(timeOffLimitId)}/values";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateManagementUnitTimeOffLimitValuesAsync(string managementUnitId, string timeOffLimitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeofflimits/{Uri.EscapeDataString(timeOffLimitId)}/values";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> ValidateManagementUnitWorkPlanAsync(string managementUnitId, string workPlanId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplans/{Uri.EscapeDataString(workPlanId)}/validate";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CopyManagementUnitWorkPlanAsync(string managementUnitId, string workPlanId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplans/{Uri.EscapeDataString(workPlanId)}/copy";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CopyManagementUnitWorkPlanRotationAsync(string managementUnitId, string workPlanRotationId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplanrotations/{Uri.EscapeDataString(workPlanRotationId)}/copy";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateAgentsAsync(string body = null, CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/agents";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> QueryAgentAdherenceExplanationsAsync(string agentId, string body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var parameters = new NameValueCollection();

        if (forceAsync != null)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync));
        }

        if (forceDownloadService != null)
        {
            parameters.Add("forceDownloadService", UriHelper.ParameterToString(forceDownloadService));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/agents/{Uri.EscapeDataString(agentId)}/adherence/explanations/query", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> QueryAgentsIntegrationsHrisAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/agents/integrations/hris/query";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateNotificationsAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/notifications/update";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAlternativeShiftsOffersSearchJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/alternativeshifts/offers/search/jobs/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAlternativeShiftsTradesStateJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/alternativeshifts/trades/state/jobs/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetCalendarDataIcsAsync(string calendarId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(calendarId);

        var uri = $"api/v2/workforcemanagement/calendar/data/{Uri.EscapeDataString(calendarId)}/ics";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetHistoricalDataBulkRemoveJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/historicaldata/bulk/remove/jobs/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetHistoricalDataBulkRemoveJobsAsync(CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/historicaldata/bulk/remove/jobs";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetHistoricalDataDeleteJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/historicaldata/deletejob/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetHistoricalDataImportStatusAsync(CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/historicaldata/importstatus";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitActivityCodesAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/activitycodes";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitActivityCodeAsync(string managementUnitId, string activityCodeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/activitycodes/{Uri.EscapeDataString(activityCodeId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitIntradayQueuesAsync(string managementUnitId, string date, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(date);

        var parameters = new NameValueCollection();
        parameters.Add("date", UriHelper.ParameterToString(date));

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/intraday/queues", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitIntradayQueueAsync(string managementUnitId, string queueId, string date, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(queueId);
        ArgumentException.ThrowIfNullOrEmpty(date);

        var parameters = new NameValueCollection();
        parameters.Add("date", UriHelper.ParameterToString(date));

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/intraday/queues/{Uri.EscapeDataString(queueId)}", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitSettingsAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/settings";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitShiftTradesMatchedAsync(string managementUnitId, string tradeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(tradeId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/shifttrades/{Uri.EscapeDataString(tradeId)}/matched";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitShiftTradesUsersAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/shifttrades/users";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitUserTimeOffRequestsAsync(string managementUnitId, string userId, bool? recentlyReviewed = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var parameters = new NameValueCollection();

        if (recentlyReviewed != null)
        {
            parameters.Add("recentlyReviewed", UriHelper.ParameterToString(recentlyReviewed));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/users/{Uri.EscapeDataString(userId)}/timeoffrequests", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitUserTimeOffRequestAsync(string managementUnitId, string userId, string timeOffRequestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/users/{Uri.EscapeDataString(userId)}/timeoffrequests/{Uri.EscapeDataString(timeOffRequestId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitWeekScheduleAsync(string managementUnitId, string weekId, string scheduleId, string expand = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (forceDownloadService != null)
        {
            parameters.Add("forceDownloadService", UriHelper.ParameterToString(forceDownloadService));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitWeekShiftTradesAsync(string managementUnitId, string weekDateId, bool? evaluateMatches = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);

        var parameters = new NameValueCollection();

        if (evaluateMatches != null)
        {
            parameters.Add("evaluateMatches", UriHelper.ParameterToString(evaluateMatches));
        }

        if (forceDownloadService != null)
        {
            parameters.Add("forceDownloadService", UriHelper.ParameterToString(forceDownloadService));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shifttrades", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitWeekShiftTradeAsync(string managementUnitId, string weekDateId, string tradeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(tradeId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shifttrades/{Uri.EscapeDataString(tradeId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateManagementUnitActivityCodeAsync(string managementUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/activitycodes";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateManagementUnitActivityCodeAsync(string managementUnitId, string activityCodeId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/activitycodes/{Uri.EscapeDataString(activityCodeId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteManagementUnitActivityCodeAsync(string managementUnitId, string activityCodeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/activitycodes/{Uri.EscapeDataString(activityCodeId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> UpdateManagementUnitSettingsAsync(string managementUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/settings";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateManagementUnitTimeOffRequestAsync(string managementUnitId, string userId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/users/{Uri.EscapeDataString(userId)}/timeoffrequests";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateManagementUnitWeekShiftTradeAsync(string managementUnitId, string weekDateId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shifttrades";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> SearchManagementUnitWeekShiftTradesAsync(string managementUnitId, string weekDateId, string body, bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var parameters = new NameValueCollection();

        if (forceAsync != null)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shifttrades/search", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateManagementUnitWeekShiftTradeStateBulkAsync(string managementUnitId, string weekDateId, string body, bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var parameters = new NameValueCollection();

        if (forceAsync != null)
        {
            parameters.Add("forceAsync", UriHelper.ParameterToString(forceAsync));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shifttrades/state/bulk", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetHistoricalDataImportStatusJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/historicaldata/importstatus/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetIntegrationsHrisTimeOffTypesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/integrations/hris/timeofftypes/jobs/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetShrinkageJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/shrinkage/jobs/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetTimeOffBalanceJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = $"api/v2/workforcemanagement/timeoffbalance/jobs/{Uri.EscapeDataString(jobId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateBusinessUnitAlternativeShiftsSettingsAsync(string businessUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/alternativeshifts/settings";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateAlternativeShiftsTradesStateJobsAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/alternativeshifts/trades/state/jobs";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateHistoricalDataDeleteJobAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/historicaldata/deletejob";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateHistoricalDataBulkRemoveJobAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/historicaldata/bulk/remove";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateIntegrationsHrisTimeOffTypesJobAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/integrations/hris/timeofftypes/jobs";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateShrinkageJobAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/shrinkage/jobs";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateTimeOffRequestsAsync(string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = "api/v2/workforcemanagement/timeoffrequests";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateBusinessUnitSchedulingRunAsync(string businessUnitId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/scheduling/runs";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(runId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/scheduling/runs/{Uri.EscapeDataString(runId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitSchedulingRunsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/scheduling/runs";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateBusinessUnitPlanningGroupAsync(string businessUnitId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/planninggroups";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitSourcePlanningGroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/sourceplanninggroups/{Uri.EscapeDataString(planningGroupId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitSourcePlanningGroupsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/sourceplanninggroups";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateBusinessUnitSourcePlanningGroupAsync(string businessUnitId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/sourceplanninggroups";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateBusinessUnitSourcePlanningGroupAsync(string businessUnitId, string planningGroupId, string body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);
        ArgumentException.ThrowIfNullOrEmpty(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/sourceplanninggroups/{Uri.EscapeDataString(planningGroupId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteBusinessUnitSourcePlanningGroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/sourceplanninggroups/{Uri.EscapeDataString(planningGroupId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitWeekSchedulesAsync(string managementUnitId, string weekId, bool? includeOnlyPublished = null, string earliestWeekDate = null, string latestWeekDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);

        var parameters = new NameValueCollection();

        if (includeOnlyPublished != null)
        {
            parameters.Add("includeOnlyPublished", UriHelper.ParameterToString(includeOnlyPublished));
        }

        if (earliestWeekDate != null)
        {
            parameters.Add("earliestWeekDate", UriHelper.ParameterToString(earliestWeekDate));
        }

        if (latestWeekDate != null)
        {
            parameters.Add("latestWeekDate", UriHelper.ParameterToString(latestWeekDate));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules", parameters);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateManagementUnitWorkPlanRotationAsync(string managementUnitId, string workPlanRotationId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplanrotations/{Uri.EscapeDataString(workPlanRotationId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateManagementUnitAsync(string managementUnitId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> UpdateManagementUnitTimeOffRequestAsync(string managementUnitId, string userId, string timeOffRequestId, string body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/users/{Uri.EscapeDataString(userId)}/timeoffrequests/{Uri.EscapeDataString(timeOffRequestId)}";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync(uri, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetBusinessUnitMainForecastContinuousForecastSessionAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/mainforecast/continuousforecast/session";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }
}

