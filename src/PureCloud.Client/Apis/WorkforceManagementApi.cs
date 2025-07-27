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
    public async Task DeleteBusinessunitAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteBusinessunitActivitycodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes/{activityCodeId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteBusinessunitPlanninggroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups/{planningGroupId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteBusinessunitSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(runId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteBusinessunitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(serviceGoalTemplateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates/{serviceGoalTemplateId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteBusinessunitStaffinggroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(staffingGroupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups/{staffingGroupId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteBusinessunitTimeofflimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits/{timeOffLimitId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteBusinessunitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans/{timeOffPlanId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteBusinessunitWeekScheduleAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteBusinessunitWeekShorttermforecastAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteBusinessunitWorkplanbidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteBusinessunitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteCalendarUrlIcsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/calendar/url/ics", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteManagementunitAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/{timeOffLimitId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans/{timeOffPlanId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteManagementunitWorkplanAsync(string managementUnitId, string workPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations/{workPlanRotationId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAdherenceAsync(List<string> userId, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/adherence", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAdherenceExplanationAsync(string explanationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(explanationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/adherence/explanations/{explanationId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAdherenceExplanationsJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/adherence/explanations/jobs/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAdherenceHistoricalBulkJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/adherence/historical/bulk/jobs/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAdherenceHistoricalJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/adherence/historical/jobs/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAgentAdherenceExplanationAsync(string agentId, string explanationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentException.ThrowIfNullOrEmpty(explanationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agents/{agentId}/adherence/explanations/{explanationId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAgentManagementunitAsync(string agentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agents/{agentId}/managementunit", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAgentsMeManagementunitAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agents/me/managementunit", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAlternativeshiftsOffersJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/offers/jobs/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAlternativeshiftsOffersSearchJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/offers/search/jobs/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAlternativeshiftsSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/settings", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAlternativeshiftsTradeAsync(string tradeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(tradeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/trades/{tradeId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAlternativeshiftsTradesAsync(bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/trades", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAlternativeshiftsTradesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/trades/jobs/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetAlternativeshiftsTradesStateJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/trades/state/jobs/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitAsync(string businessUnitId, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(expand);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitActivitycodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes/{activityCodeId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitActivitycodesAsync(string businessUnitId, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitActivityplanAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/{activityPlanId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitActivityplanRunsJobAsync(string businessUnitId, string activityPlanId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/{activityPlanId}/runs/jobs/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitActivityplansAsync(string businessUnitId, string state, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(state);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitActivityplansJobsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/jobs", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitAlternativeshiftsSettingsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/settings", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitAlternativeshiftsTradeAsync(string businessUnitId, string tradeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(tradeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/trades/{tradeId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitAlternativeshiftsTradesSearchJobAsync(string businessUnitId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/trades/search/jobs/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitIntradayPlanninggroupsAsync(string businessUnitId, string date, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(date);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/intraday/planninggroups", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitMainforecastContinuousforecastSessionAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/mainforecast/continuousforecast/session", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitMainforecastContinuousforecastSessionSessionIdAsync(string businessUnitId, string sessionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/mainforecast/continuousforecast/session/{sessionId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitMainforecastContinuousforecastSessionSessionIdSnapshotSnapshotIdAsync(string businessUnitId, string sessionId, string snapshotId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(sessionId);
        ArgumentException.ThrowIfNullOrEmpty(snapshotId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/mainforecast/continuousforecast/session/{sessionId}/snapshot/{snapshotId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitManagementunitsAsync(string businessUnitId, string feature, string divisionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(feature);
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/managementunits", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitPlanninggroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups/{planningGroupId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitPlanninggroupsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(runId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitSchedulingRunResultAsync(string businessUnitId, string runId, List<string> managementUnitIds, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(runId);
        ArgumentNullException.ThrowIfNull(managementUnitIds);
        ArgumentNullException.ThrowIfNull(expand);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId}/result", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitSchedulingRunsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(serviceGoalTemplateId);
        ArgumentNullException.ThrowIfNull(expand);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates/{serviceGoalTemplateId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitServicegoaltemplatesAsync(string businessUnitId, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(expand);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitStaffinggroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(staffingGroupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups/{staffingGroupId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitStaffinggroupsAsync(string businessUnitId, string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitTimeofflimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits/{timeOffLimitId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitTimeofflimitsAsync(string businessUnitId, string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans/{timeOffPlanId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitTimeoffplansAsync(string businessUnitId, string managementUnitId, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWeekScheduleAsync(string businessUnitId, string weekId, string scheduleId, string expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(expand);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWeekScheduleGenerationresultsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/generationresults", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWeekScheduleHeadcountforecastAsync(string businessUnitId, string weekId, string scheduleId, bool? forceDownload = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/headcountforecast", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWeekScheduleHistoryAgentAsync(string businessUnitId, string weekId, string scheduleId, string agentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(agentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/history/agents/{agentId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWeekSchedulePerformancepredictionsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/performancepredictions", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWeekSchedulePerformancepredictionsRecalculationAsync(string businessUnitId, string weekId, string scheduleId, string recalculationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(recalculationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/performancepredictions/recalculations/{recalculationId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWeekSchedulesAsync(string businessUnitId, string weekId, string expand, bool? includeOnlyPublished = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(expand);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWeekShorttermforecastAsync(string businessUnitId, string weekDateId, string forecastId, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);
        ArgumentNullException.ThrowIfNull(expand);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWeekShorttermforecastDataAsync(string businessUnitId, string weekDateId, string forecastId, int? weekNumber = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/data", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWeekShorttermforecastGenerationresultsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/generationresults", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWeekShorttermforecastLongtermforecastdataAsync(string businessUnitId, string weekDateId, string forecastId, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/longtermforecastdata", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWeekShorttermforecastPlanninggroupsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/planninggroups", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWeekShorttermforecastStaffingrequirementAsync(string businessUnitId, string weekDateId, string forecastId, List<string> weekNumbers, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);
        ArgumentNullException.ThrowIfNull(weekNumbers);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/staffingrequirement", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWeekShorttermforecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWorkplanbidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWorkplanbidGroupPreferencesAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId}/preferences", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWorkplanbidGroupsSummaryAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/summary", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitWorkplanbidsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitsAsync(string feature, string divisionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(feature);
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetBusinessunitsDivisionviewsAsync(List<string> divisionId, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(divisionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/divisionviews", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetCalendarDataIcsAsync(string calendarId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(calendarId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/calendar/data/ics", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetCalendarUrlIcsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/calendar/url/ics", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetHistoricaldataBulkRemoveJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/historicaldata/bulk/remove/jobs/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetHistoricaldataBulkRemoveJobsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/historicaldata/bulk/remove/jobs", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetHistoricaldataDeletejobAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/historicaldata/deletejob", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetHistoricaldataImportstatusAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/historicaldata/importstatus", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetHistoricaldataImportstatusJobIdAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/historicaldata/importstatus/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetIntegrationsHrisAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/integrations/hris", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetIntegrationsHrisTimeofftypesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/integrations/hris/timeofftypes/jobs/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitAsync(string managementUnitId, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(expand);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitActivitycodesAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/activitycodes", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitAdherenceAsync(string managementUnitId, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/adherence", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitAgentAsync(string managementUnitId, string agentId, List<string> expand, bool? excludeCapabilities = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentNullException.ThrowIfNull(expand);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/{agentId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitAgentShifttradesAsync(string managementUnitId, string agentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(agentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/{agentId}/shifttrades", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitShifttradesMatchedAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/shifttrades/matched", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitShifttradesUsersAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/shifttrades/users", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/{timeOffLimitId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitTimeofflimitsAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans/{timeOffPlanId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitTimeoffplansAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitUserTimeoffrequestAsync(string managementUnitId, string userId, string timeOffRequestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/{timeOffRequestId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitUserTimeoffrequestTimeofflimitsAsync(string managementUnitId, string userId, string timeOffRequestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/{timeOffRequestId}/timeofflimits", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitUserTimeoffrequestsAsync(string managementUnitId, string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitUsersAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/users", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitWeekScheduleAsync(string managementUnitId, string weekId, string scheduleId, string expand, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(expand);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitWeekSchedulesAsync(string managementUnitId, string weekId, string earliestWeekDate, string latestWeekDate, bool? includeOnlyPublished = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(earliestWeekDate);
        ArgumentException.ThrowIfNullOrEmpty(latestWeekDate);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitWeekShifttradesAsync(string managementUnitId, string weekDateId, bool? evaluateMatches = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitWorkplanAsync(string managementUnitId, string workPlanId, List<string> includeOnly, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);
        ArgumentNullException.ThrowIfNull(includeOnly);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations/{workPlanRotationId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitWorkplanrotationsAsync(string managementUnitId, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(expand);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitWorkplansAsync(string managementUnitId, List<string> expand, List<string> exclude, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(expand);
        ArgumentNullException.ThrowIfNull(exclude);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitsAsync(string expand, string feature, string divisionId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(expand);
        ArgumentException.ThrowIfNullOrEmpty(feature);
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetManagementunitsDivisionviewsAsync(List<string> divisionId, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(divisionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/divisionviews", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetNotificationsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/notifications", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetSchedulingjobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/schedulingjobs/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetShifttradesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/shifttrades", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetShrinkageJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/shrinkage/jobs/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetTimeoffbalanceJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeoffbalance/jobs/{jobId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetTimeoffrequestAsync(string timeOffRequestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetTimeoffrequestWaitlistpositionsAsync(string timeOffRequestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}/waitlistpositions", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetTimeoffrequestsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeoffrequests", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetUserWorkplanbidranksAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/users/{userId}/workplanbidranks", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetWorkplanbidPreferencesAsync(string bidId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(bidId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/workplanbids/{bidId}/preferences", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetWorkplanbidWorkplansAsync(string bidId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(bidId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/workplanbids/{bidId}/workplans", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task GetWorkplanbidsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/workplanbids", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateAgentAdherenceExplanationAsync(string agentId, string explanationId, UpdateAdherenceExplanationStatusRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentException.ThrowIfNullOrEmpty(explanationId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agents/{agentId}/adherence/explanations/{explanationId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateAlternativeshiftsTradeAsync(string tradeId, AgentUpdateAlternativeShiftTradeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(tradeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/trades/{tradeId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateAlternativeshiftsTradesStateJobsAsync(AdminBulkUpdateAlternativeShiftTradeStateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/trades/state/jobs", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateBusinessunitAsync(string businessUnitId, UpdateBusinessUnitRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateBusinessunitActivitycodeAsync(string businessUnitId, string activityCodeId, UpdateActivityCodeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes/{activityCodeId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateBusinessunitActivityplanAsync(string businessUnitId, string activityPlanId, UpdateActivityPlanRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/{activityPlanId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateBusinessunitAlternativeshiftsSettingsAsync(string businessUnitId, UpdateAlternativeShiftBuSettingsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/settings", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateBusinessunitPlanninggroupAsync(string businessUnitId, string planningGroupId, UpdatePlanningGroupRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups/{planningGroupId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateBusinessunitSchedulingRunAsync(string businessUnitId, string runId, PatchBuScheduleRunRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(runId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateBusinessunitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, UpdateServiceGoalTemplate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(serviceGoalTemplateId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates/{serviceGoalTemplateId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateBusinessunitStaffinggroupAsync(string businessUnitId, string staffingGroupId, UpdateStaffingGroupRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(staffingGroupId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups/{staffingGroupId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateBusinessunitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, BuUpdateTimeOffPlanRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans/{timeOffPlanId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateBusinessunitWorkplanbidAsync(string businessUnitId, string bidId, UpdateWorkPlanBid body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateBusinessunitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, WorkPlanBidGroupUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateBusinessunitWorkplanbidGroupPreferencesAsync(string businessUnitId, string bidId, string bidGroupId, AgentsBidAssignedWorkPlanOverrideRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId}/preferences", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateManagementunitAsync(string managementUnitId, UpdateManagementUnitRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateManagementunitAgentsAsync(string managementUnitId, UpdateMuAgentsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/agents", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateManagementunitAgentsWorkplansBulkAsync(string managementUnitId, UpdateMuAgentWorkPlansBatchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/workplans/bulk", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, UpdateTimeOffLimitRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/{timeOffLimitId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, UpdateTimeOffPlanRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans/{timeOffPlanId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateManagementunitTimeoffrequestUserIntegrationstatusAsync(string managementUnitId, string timeOffRequestId, string userId, SetTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests/{timeOffRequestId}/users/{userId}/integrationstatus", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateManagementunitUserTimeoffrequestAsync(string managementUnitId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/{timeOffRequestId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateManagementunitWeekShifttradeAsync(string managementUnitId, string weekDateId, string tradeId, PatchShiftTradeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(tradeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/{tradeId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateManagementunitWorkplanAsync(string managementUnitId, string workPlanId, string validationMode, WorkPlan body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);
        ArgumentException.ThrowIfNullOrEmpty(validationMode);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, UpdateWorkPlanRotationRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations/{workPlanRotationId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateTimeoffrequestAsync(string timeOffRequestId, AgentTimeOffRequestPatch body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateUserWorkplanbidranksAsync(string userId, WorkPlanBidRanks body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/users/{userId}/workplanbidranks", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateUsersWorkplanbidranksBulkAsync(List<WorkPlanBidRanks> body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/users/workplanbidranks/bulk", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateWorkplanbidPreferencesAsync(string bidId, UpdateAgentWorkPlanBiddingPreference body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/workplanbids/{bidId}/preferences", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateAdherenceExplanationsAsync(AddAdherenceExplanationAgentRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/adherence/explanations", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateAdherenceExplanationsQueryAsync(AgentQueryAdherenceExplanationsRequest body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/adherence/explanations/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateAdherenceHistoricalAsync(WfmHistoricalAdherenceQueryForUsers body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/adherence/historical", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateAdherenceHistoricalBulkAsync(WfmHistoricalAdherenceBulkQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/adherence/historical/bulk", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateAgentAdherenceExplanationsAsync(string agentId, AddAdherenceExplanationAdminRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agents/{agentId}/adherence/explanations", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateAgentAdherenceExplanationsQueryAsync(string agentId, AgentQueryAdherenceExplanationsRequest body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agents/{agentId}/adherence/explanations/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateAgentsAsync(MoveAgentsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agents", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateAgentsIntegrationsHrisQueryAsync(QueryAgentsIntegrationsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agents/integrations/hris/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateAgentsMePossibleworkshiftsAsync(AgentPossibleWorkShiftsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agents/me/possibleworkshifts", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateAgentschedulesMineAsync(BuGetCurrentAgentScheduleRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agentschedules/mine", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateAlternativeshiftsOffersJobsAsync(AlternativeShiftOffersRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/offers/jobs", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateAlternativeshiftsOffersSearchJobsAsync(AlternativeShiftSearchOffersRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/offers/search/jobs", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateAlternativeshiftsTradesAsync(CreateAlternativeShiftTradeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/trades", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitActivitycodesAsync(string businessUnitId, CreateActivityCodeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitActivityplanRunsJobsAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/{activityPlanId}/runs/jobs", null);

        var response = await client.PostAsync(uri, null, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitActivityplansAsync(string businessUnitId, CreateActivityPlanRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitAdherenceExplanationsQueryAsync(string businessUnitId, BuQueryAdherenceExplanationsRequest body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/adherence/explanations/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitAgentschedulesSearchAsync(string businessUnitId, BuSearchAgentSchedulesRequest body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/agentschedules/search", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitAlternativeshiftsTradesSearchAsync(string businessUnitId, SearchAlternativeShiftTradesRequest body, bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/trades/search", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitIntradayAsync(string businessUnitId, IntradayPlanningGroupRequest body, bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/intraday", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitPlanninggroupsAsync(string businessUnitId, CreatePlanningGroupRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitServicegoaltemplatesAsync(string businessUnitId, CreateServiceGoalTemplate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitStaffinggroupsAsync(string businessUnitId, CreateStaffingGroupRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitStaffinggroupsQueryAsync(string businessUnitId, QueryUserStaffingGroupListRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitTimeofflimitsAsync(string businessUnitId, BuCreateTimeOffLimitRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitTimeofflimitsValuesQueryAsync(string businessUnitId, QueryTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits/values/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitTimeoffplansAsync(string businessUnitId, BuCreateTimeOffPlanRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekScheduleAgentschedulesQueryAsync(string businessUnitId, string weekId, string scheduleId, BuQueryAgentSchedulesRequest body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/agentschedules/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekScheduleCopyAsync(string businessUnitId, string weekId, string scheduleId, BuCopyScheduleRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/copy", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekSchedulePerformancepredictionsRecalculationsAsync(string businessUnitId, string weekId, string scheduleId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/performancepredictions/recalculations", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekSchedulePerformancepredictionsRecalculationsUploadurlAsync(string businessUnitId, string weekId, string scheduleId, UploadUrlRequestBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/performancepredictions/recalculations/uploadurl", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekScheduleRescheduleAsync(string businessUnitId, string weekId, string scheduleId, BuRescheduleRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/reschedule", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekScheduleUpdateAsync(string businessUnitId, string weekId, string scheduleId, ProcessScheduleUpdateUploadRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/update", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekScheduleUpdateUploadurlAsync(string businessUnitId, string weekId, string scheduleId, UploadUrlRequestBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/update/uploadurl", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekSchedulesAsync(string businessUnitId, string weekId, BuCreateBlankScheduleRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekSchedulesGenerateAsync(string businessUnitId, string weekId, BuGenerateScheduleRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/generate", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekSchedulesImportAsync(string businessUnitId, string weekId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/import", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekSchedulesImportUploadurlAsync(string businessUnitId, string weekId, UploadUrlRequestBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/import/uploadurl", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekShorttermforecastCopyAsync(string businessUnitId, string weekDateId, string forecastId, CopyBuForecastRequest body, bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/copy", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekShorttermforecastsGenerateAsync(string businessUnitId, string weekDateId, GenerateBuForecastRequest body, bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/generate", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekShorttermforecastsImportAsync(string businessUnitId, string weekDateId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/import", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWeekShorttermforecastsImportUploadurlAsync(string businessUnitId, string weekDateId, UploadUrlRequestBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/import/uploadurl", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWorkplanbidCopyAsync(string businessUnitId, string bidId, CopyWorkPlanBid body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/copy", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWorkplanbidGroupsAsync(string businessUnitId, string bidId, WorkPlanBidGroupCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitWorkplanbidsAsync(string businessUnitId, CreateWorkPlanBid body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateBusinessunitsAsync(CreateBusinessUnitRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateCalendarUrlIcsAsync(string language, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(language);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/calendar/url/ics", null);

        var response = await client.PostAsync(uri, null, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateHistoricaldataBulkRemoveJobsAsync(HistoricalImportDeleteFilesJobRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/historicaldata/bulk/remove/jobs", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateHistoricaldataDeletejobAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/historicaldata/deletejob", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateHistoricaldataValidateAsync(ValidationServiceRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/historicaldata/validate", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateIntegrationsHriTimeofftypesJobsAsync(string hrisIntegrationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(hrisIntegrationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/integrations/hris/{hrisIntegrationId}/timeofftypes/jobs", null);

        var response = await client.PostAsync(uri, null, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitAgentsWorkplansQueryAsync(string managementUnitId, GetAgentsWorkPlansRequest body, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/workplans/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitAgentschedulesSearchAsync(string managementUnitId, BuSearchAgentSchedulesRequest body, bool? forceAsync = null, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/agentschedules/search", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitHistoricaladherencequeryAsync(string managementUnitId, WfmHistoricalAdherenceQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/historicaladherencequery", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitMoveAsync(string managementUnitId, MoveManagementUnitRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/move", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitSchedulesSearchAsync(string managementUnitId, UserListScheduleRequestBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/schedules/search", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitShrinkageJobsAsync(string managementUnitId, WfmHistoricalShrinkageRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/shrinkage/jobs", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitTimeofflimitsAsync(string managementUnitId, CreateTimeOffLimitRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitTimeofflimitsValuesQueryAsync(string managementUnitId, QueryTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/values/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitTimeoffplansAsync(string managementUnitId, CreateTimeOffPlanRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitTimeoffrequestsAsync(string managementUnitId, CreateAdminTimeOffRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitTimeoffrequestsIntegrationstatusQueryAsync(string managementUnitId, QueryTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests/integrationstatus/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitTimeoffrequestsQueryAsync(string managementUnitId, TimeOffRequestQueryBody body, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitTimeoffrequestsWaitlistpositionsQueryAsync(string managementUnitId, QueryWaitlistPositionsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests/waitlistpositions/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitUserTimeoffbalanceJobsAsync(string managementUnitId, string userId, TimeOffBalanceRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffbalance/jobs", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitUserTimeoffrequestTimeoffbalanceJobsAsync(string managementUnitId, string userId, string timeOffRequestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/{timeOffRequestId}/timeoffbalance/jobs", null);

        var response = await client.PostAsync(uri, null, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitUserTimeoffrequestsEstimateAsync(string managementUnitId, string userId, EstimateAvailableTimeOffRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/estimate", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitWeekShifttradeMatchAsync(string managementUnitId, string weekDateId, string tradeId, MatchShiftTradeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(tradeId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/{tradeId}/match", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitWeekShifttradesAsync(string managementUnitId, string weekDateId, AddShiftTradeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitWeekShifttradesSearchAsync(string managementUnitId, string weekDateId, SearchShiftTradesRequest body, bool? forceDownloadService = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/search", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitWeekShifttradesStateBulkAsync(string managementUnitId, string weekDateId, BulkShiftTradeStateUpdateRequest body, bool? forceAsync = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/state/bulk", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitWorkplanCopyAsync(string managementUnitId, string workPlanId, CopyWorkPlan body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}/copy", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitWorkplanValidateAsync(string managementUnitId, string workPlanId, List<string> expand, WorkPlanValidationRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);
        ArgumentNullException.ThrowIfNull(expand);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}/validate", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitWorkplanrotationCopyAsync(string managementUnitId, string workPlanRotationId, CopyWorkPlanRotationRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations/{workPlanRotationId}/copy", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitWorkplanrotationsAsync(string managementUnitId, AddWorkPlanRotationRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitWorkplansAsync(string managementUnitId, string validationMode, CreateWorkPlan body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(validationMode);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateManagementunitsAsync(CreateManagementUnitApiRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateNotificationsUpdateAsync(UpdateNotificationsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/notifications/update", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateSchedulesAsync(CurrentUserScheduleRequestBody body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/schedules", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateTeamAdherenceHistoricalAsync(string teamId, WfmHistoricalAdherenceQueryForTeams body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(teamId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/teams/{teamId}/adherence/historical", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateTeamShrinkageJobsAsync(string teamId, WfmHistoricalShrinkageTeamsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(teamId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/teams/{teamId}/shrinkage/jobs", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateTimeoffbalanceJobsAsync(TimeOffBalanceRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeoffbalance/jobs", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateTimeofflimitsAvailableQueryAsync(AvailableTimeOffRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeofflimits/available/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateTimeoffrequestsAsync(CreateAgentTimeOffRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeoffrequests", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateTimeoffrequestsEstimateAsync(EstimateAvailableTimeOffRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeoffrequests/estimate", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task CreateTimeoffrequestsIntegrationstatusQueryAsync(CurrentUserTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeoffrequests/integrationstatus/query", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateAgentIntegrationsHrisAsync(string agentId, AgentIntegrationsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agents/{agentId}/integrations/hris", null);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateBusinessunitTimeofflimitValuesAsync(string businessUnitId, string timeOffLimitId, BuSetTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits/{timeOffLimitId}/values", null);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task UpdateManagementunitTimeofflimitValuesAsync(string managementUnitId, string timeOffLimitId, SetTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/{timeOffLimitId}/values", null);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}