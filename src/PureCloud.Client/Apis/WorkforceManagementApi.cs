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

    public async Task DeleteBusinessunitAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteBusinessunitActivitycodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes/{activityCodeId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteBusinessunitPlanninggroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups/{planningGroupId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteBusinessunitSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(runId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteBusinessunitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(serviceGoalTemplateId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates/{serviceGoalTemplateId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteBusinessunitStaffinggroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(staffingGroupId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups/{staffingGroupId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteBusinessunitTimeofflimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits/{timeOffLimitId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteBusinessunitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans/{timeOffPlanId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task<BuAsyncScheduleResponse> DeleteBusinessunitWeekScheduleAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuAsyncScheduleResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task DeleteBusinessunitWeekShorttermforecastAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteBusinessunitWorkplanbidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteBusinessunitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteCalendarUrlIcsAsync(CancellationToken cancellationToken = default)
    {

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/calendar/url/ics", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteManagementunitAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/{timeOffLimitId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans/{timeOffPlanId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteManagementunitWorkplanAsync(string managementUnitId, string workPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task DeleteManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations/{workPlanRotationId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task<AdherenceExplanationResponse> GetAdherenceExplanationAsync(string explanationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(explanationId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/adherence/explanations/{explanationId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AdherenceExplanationResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AdherenceExplanationJob> GetAdherenceExplanationsJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/adherence/explanations/jobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AdherenceExplanationJob>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WfmHistoricalAdherenceBulkResponse> GetAdherenceHistoricalBulkJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/adherence/historical/bulk/jobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WfmHistoricalAdherenceBulkResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WfmHistoricalAdherenceResponse> GetAdherenceHistoricalJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/adherence/historical/jobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WfmHistoricalAdherenceResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AdherenceExplanationResponse> GetAgentAdherenceExplanationAsync(string agentId, string explanationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentException.ThrowIfNullOrEmpty(explanationId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/agents/{agentId}/adherence/explanations/{explanationId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AdherenceExplanationResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AgentManagementUnitReference> GetAgentManagementunitAsync(string agentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/agents/{agentId}/managementunit", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentManagementUnitReference>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AgentManagementUnitReference> GetAgentsMeManagementunitAsync(CancellationToken cancellationToken = default)
    {

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agents/me/managementunit", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentManagementUnitReference>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AlternativeShiftJobResponse> GetAlternativeshiftsOffersJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/alternativeshifts/offers/jobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlternativeShiftJobResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AlternativeShiftJobResponse> GetAlternativeshiftsOffersSearchJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/alternativeshifts/offers/search/jobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlternativeShiftJobResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AlternativeShiftBuSettingsResponse> GetAlternativeshiftsSettingsAsync(CancellationToken cancellationToken = default)
    {

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/settings", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlternativeShiftBuSettingsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AlternativeShiftTradeResponse> GetAlternativeshiftsTradeAsync(string tradeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(tradeId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/alternativeshifts/trades/{tradeId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlternativeShiftTradeResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ListAlternativeShiftTradesResponse> GetAlternativeshiftsTradesAsync(bool? forceAsync, CancellationToken cancellationToken = default)
    {

        var parameters = new NameValueCollection();
        if (forceAsync != null) parameters.Add("forceAsync", forceAsync.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/alternativeshifts/trades", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ListAlternativeShiftTradesResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AlternativeShiftJobResponse> GetAlternativeshiftsTradesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/alternativeshifts/trades/jobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlternativeShiftJobResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AlternativeShiftJobResponse> GetAlternativeshiftsTradesStateJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/alternativeshifts/trades/state/jobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlternativeShiftJobResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BusinessUnitResponse> GetBusinessunitAsync(string businessUnitId, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(expand);

        var parameters = new NameValueCollection();
        if (expand != null) parameters.Add("expand", expand.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BusinessUnitActivityCode> GetBusinessunitActivitycodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes/{activityCodeId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitActivityCode>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BusinessUnitActivityCodeListing> GetBusinessunitActivitycodesAsync(string businessUnitId, bool? forceDownloadService, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var parameters = new NameValueCollection();
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitActivityCodeListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ActivityPlanResponse> GetBusinessunitActivityplanAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/{activityPlanId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityPlanResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ActivityPlanRunJobResponse> GetBusinessunitActivityplanRunsJobAsync(string businessUnitId, string activityPlanId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/{activityPlanId}/runs/jobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityPlanRunJobResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ActivityPlanListing> GetBusinessunitActivityplansAsync(string businessUnitId, string state, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(state);

        var parameters = new NameValueCollection();
        if (state != null) parameters.Add("state", state.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityPlanListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ActivityPlanJobListing> GetBusinessunitActivityplansJobsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/jobs", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityPlanJobListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AlternativeShiftBuSettingsResponse> GetBusinessunitAlternativeshiftsSettingsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/settings", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlternativeShiftBuSettingsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AlternativeShiftTradeResponse> GetBusinessunitAlternativeshiftsTradeAsync(string businessUnitId, string tradeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(tradeId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/trades/{tradeId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlternativeShiftTradeResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuAlternativeShiftJobResponse> GetBusinessunitAlternativeshiftsTradesSearchJobAsync(string businessUnitId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/trades/search/jobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuAlternativeShiftJobResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WfmIntradayPlanningGroupListing> GetBusinessunitIntradayPlanninggroupsAsync(string businessUnitId, string date, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(date);

        var parameters = new NameValueCollection();
        if (date != null) parameters.Add("date", date.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/intraday/planninggroups", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WfmIntradayPlanningGroupListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ContinuousForecastGetSessionResponse> GetBusinessunitMainforecastContinuousforecastSessionAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/mainforecast/continuousforecast/session", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContinuousForecastGetSessionResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ContinuousForecastSessionResponse> GetBusinessunitMainforecastContinuousforecastSessionSessionIdAsync(string businessUnitId, string sessionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/mainforecast/continuousforecast/session/{sessionId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContinuousForecastSessionResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ContinuousForecastSnapshotResponse> GetBusinessunitMainforecastContinuousforecastSessionSessionIdSnapshotSnapshotIdAsync(string businessUnitId, string sessionId, string snapshotId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(sessionId);
        ArgumentException.ThrowIfNullOrEmpty(snapshotId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/mainforecast/continuousforecast/session/{sessionId}/snapshot/{snapshotId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ContinuousForecastSnapshotResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ManagementUnitListing> GetBusinessunitManagementunitsAsync(string businessUnitId, string feature, string divisionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(feature);
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        var parameters = new NameValueCollection();
        if (feature != null) parameters.Add("feature", feature.ToString());
        if (divisionId != null) parameters.Add("divisionId", divisionId.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/managementunits", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ManagementUnitListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<PlanningGroup> GetBusinessunitPlanninggroupAsync(string businessUnitId, string planningGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups/{planningGroupId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PlanningGroup>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<PlanningGroupList> GetBusinessunitPlanninggroupsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PlanningGroupList>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuScheduleRun> GetBusinessunitSchedulingRunAsync(string businessUnitId, string runId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(runId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuScheduleRun>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuRescheduleResult> GetBusinessunitSchedulingRunResultAsync(string businessUnitId, string runId, List<string> managementUnitIds, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(runId);
        ArgumentNullException.ThrowIfNull(managementUnitIds);
        ArgumentNullException.ThrowIfNull(expand);

        var parameters = new NameValueCollection();
        if (managementUnitIds != null) parameters.Add("managementUnitIds", managementUnitIds.ToString());
        if (expand != null) parameters.Add("expand", expand.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId}/result", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuRescheduleResult>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuScheduleRunListing> GetBusinessunitSchedulingRunsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuScheduleRunListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ServiceGoalTemplate> GetBusinessunitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(serviceGoalTemplateId);
        ArgumentNullException.ThrowIfNull(expand);

        var parameters = new NameValueCollection();
        if (expand != null) parameters.Add("expand", expand.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates/{serviceGoalTemplateId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ServiceGoalTemplate>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ServiceGoalTemplateList> GetBusinessunitServicegoaltemplatesAsync(string businessUnitId, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(expand);

        var parameters = new NameValueCollection();
        if (expand != null) parameters.Add("expand", expand.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ServiceGoalTemplateList>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<StaffingGroupResponse> GetBusinessunitStaffinggroupAsync(string businessUnitId, string staffingGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(staffingGroupId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups/{staffingGroupId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<StaffingGroupResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<StaffingGroupListing> GetBusinessunitStaffinggroupsAsync(string businessUnitId, string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();
        if (managementUnitId != null) parameters.Add("managementUnitId", managementUnitId.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<StaffingGroupListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuTimeOffLimitResponse> GetBusinessunitTimeofflimitAsync(string businessUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits/{timeOffLimitId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuTimeOffLimitResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuTimeOffLimitListing> GetBusinessunitTimeofflimitsAsync(string businessUnitId, string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();
        if (managementUnitId != null) parameters.Add("managementUnitId", managementUnitId.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuTimeOffLimitListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuTimeOffPlanResponse> GetBusinessunitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans/{timeOffPlanId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuTimeOffPlanResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuTimeOffPlanListing> GetBusinessunitTimeoffplansAsync(string businessUnitId, string managementUnitId, bool? forceDownloadService, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();
        if (managementUnitId != null) parameters.Add("managementUnitId", managementUnitId.ToString());
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuTimeOffPlanListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuScheduleMetadata> GetBusinessunitWeekScheduleAsync(string businessUnitId, string weekId, string scheduleId, string expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(expand);

        var parameters = new NameValueCollection();
        if (expand != null) parameters.Add("expand", expand.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuScheduleMetadata>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ScheduleGenerationResult> GetBusinessunitWeekScheduleGenerationresultsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/generationresults", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScheduleGenerationResult>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuHeadcountForecastResponse> GetBusinessunitWeekScheduleHeadcountforecastAsync(string businessUnitId, string weekId, string scheduleId, bool? forceDownload, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var parameters = new NameValueCollection();
        if (forceDownload != null) parameters.Add("forceDownload", forceDownload.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/headcountforecast", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuHeadcountForecastResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuAgentScheduleHistoryResponse> GetBusinessunitWeekScheduleHistoryAgentAsync(string businessUnitId, string weekId, string scheduleId, string agentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(agentId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/history/agents/{agentId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuAgentScheduleHistoryResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<PerformancePredictionResponse> GetBusinessunitWeekSchedulePerformancepredictionsAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/performancepredictions", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PerformancePredictionResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<PerformancePredictionRecalculationResponse> GetBusinessunitWeekSchedulePerformancepredictionsRecalculationAsync(string businessUnitId, string weekId, string scheduleId, string recalculationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(recalculationId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/performancepredictions/recalculations/{recalculationId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PerformancePredictionRecalculationResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuScheduleListing> GetBusinessunitWeekSchedulesAsync(string businessUnitId, string weekId, bool? includeOnlyPublished, string expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(expand);

        var parameters = new NameValueCollection();
        if (includeOnlyPublished != null) parameters.Add("includeOnlyPublished", includeOnlyPublished.ToString());
        if (expand != null) parameters.Add("expand", expand.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuScheduleListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuShortTermForecast> GetBusinessunitWeekShorttermforecastAsync(string businessUnitId, string weekDateId, string forecastId, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);
        ArgumentNullException.ThrowIfNull(expand);

        var parameters = new NameValueCollection();
        if (expand != null) parameters.Add("expand", expand.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuShortTermForecast>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuForecastResultResponse> GetBusinessunitWeekShorttermforecastDataAsync(string businessUnitId, string weekDateId, string forecastId, int? weekNumber, bool? forceDownloadService, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var parameters = new NameValueCollection();
        if (weekNumber != null) parameters.Add("weekNumber", weekNumber.ToString());
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/data", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuForecastResultResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuForecastGenerationResult> GetBusinessunitWeekShorttermforecastGenerationresultsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/generationresults", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuForecastGenerationResult>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<LongTermForecastResultResponse> GetBusinessunitWeekShorttermforecastLongtermforecastdataAsync(string businessUnitId, string weekDateId, string forecastId, bool? forceDownloadService, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var parameters = new NameValueCollection();
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/longtermforecastdata", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LongTermForecastResultResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ForecastPlanningGroupsResponse> GetBusinessunitWeekShorttermforecastPlanninggroupsAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/planninggroups", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ForecastPlanningGroupsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuForecastStaffingRequirementsResultResponse> GetBusinessunitWeekShorttermforecastStaffingrequirementAsync(string businessUnitId, string weekDateId, string forecastId, List<string> weekNumbers, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);
        ArgumentNullException.ThrowIfNull(weekNumbers);

        var parameters = new NameValueCollection();
        if (weekNumbers != null) parameters.Add("weekNumbers", weekNumbers.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/staffingrequirement", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuForecastStaffingRequirementsResultResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuShortTermForecastListing> GetBusinessunitWeekShorttermforecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuShortTermForecastListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanBid> GetBusinessunitWorkplanbidAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanBid>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanBidGroupResponse> GetBusinessunitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanBidGroupResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AdminAgentWorkPlanPreferenceResponse> GetBusinessunitWorkplanbidGroupPreferencesAsync(string businessUnitId, string bidId, string bidGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId}/preferences", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AdminAgentWorkPlanPreferenceResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanBidGroupSummaryList> GetBusinessunitWorkplanbidGroupsSummaryAsync(string businessUnitId, string bidId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/summary", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanBidGroupSummaryList>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanBidListResponse> GetBusinessunitWorkplanbidsAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanBidListResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BusinessUnitListing> GetBusinessunitsAsync(string feature, string divisionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(feature);
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        var parameters = new NameValueCollection();
        if (feature != null) parameters.Add("feature", feature.ToString());
        if (divisionId != null) parameters.Add("divisionId", divisionId.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BusinessUnitListing> GetBusinessunitsDivisionviewsAsync(List<string> divisionId, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(divisionId);

        var parameters = new NameValueCollection();
        if (divisionId != null) parameters.Add("divisionId", divisionId.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/divisionviews", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<string> GetCalendarDataIcsAsync(string calendarId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(calendarId);

        var parameters = new NameValueCollection();
        if (calendarId != null) parameters.Add("calendarId", calendarId.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/calendar/data/ics", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<string>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<CalendarUrlResponse> GetCalendarUrlIcsAsync(CancellationToken cancellationToken = default)
    {

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/calendar/url/ics", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CalendarUrlResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<HistoricalImportDeleteFilesJobResponse> GetHistoricaldataBulkRemoveJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/historicaldata/bulk/remove/jobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<HistoricalImportDeleteFilesJobResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<HistoricalImportOverallDeleteStatusResponse> GetHistoricaldataBulkRemoveJobsAsync(CancellationToken cancellationToken = default)
    {

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/historicaldata/bulk/remove/jobs", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<HistoricalImportOverallDeleteStatusResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<HistoricalImportDeleteJobResponse> GetHistoricaldataDeletejobAsync(CancellationToken cancellationToken = default)
    {

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/historicaldata/deletejob", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<HistoricalImportDeleteJobResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<HistoricalImportStatusListing> GetHistoricaldataImportstatusAsync(CancellationToken cancellationToken = default)
    {

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/historicaldata/importstatus", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<HistoricalImportStatusListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<HistoricalImportStatusJobResponse> GetHistoricaldataImportstatusJobIdAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/historicaldata/importstatus/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<HistoricalImportStatusJobResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WfmIntegrationListing> GetIntegrationsHrisAsync(CancellationToken cancellationToken = default)
    {

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/integrations/hris", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WfmIntegrationListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<HrisTimeOffTypesJobResponse> GetIntegrationsHrisTimeofftypesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/integrations/hris/timeofftypes/jobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<HrisTimeOffTypesJobResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ManagementUnit> GetManagementunitAsync(string managementUnitId, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(expand);

        var parameters = new NameValueCollection();
        if (expand != null) parameters.Add("expand", expand.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ManagementUnit>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ActivityCodeContainer> GetManagementunitActivitycodesAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/activitycodes", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityCodeContainer>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<UserScheduleAdherenceListing> GetManagementunitAdherenceAsync(string managementUnitId, bool? forceDownloadService, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/adherence", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserScheduleAdherenceListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WfmAgent> GetManagementunitAgentAsync(string managementUnitId, string agentId, bool? excludeCapabilities, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentNullException.ThrowIfNull(expand);

        var parameters = new NameValueCollection();
        if (excludeCapabilities != null) parameters.Add("excludeCapabilities", excludeCapabilities.ToString());
        if (expand != null) parameters.Add("expand", expand.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/{agentId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WfmAgent>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ShiftTradeListResponse> GetManagementunitAgentShifttradesAsync(string managementUnitId, string agentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(agentId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/{agentId}/shifttrades", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ShiftTradeListResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ShiftTradeMatchesSummaryResponse> GetManagementunitShifttradesMatchedAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/shifttrades/matched", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ShiftTradeMatchesSummaryResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WfmUserEntityListing> GetManagementunitShifttradesUsersAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/shifttrades/users", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WfmUserEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffLimit> GetManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/{timeOffLimitId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffLimit>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffLimitListing> GetManagementunitTimeofflimitsAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffLimitListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffPlan> GetManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans/{timeOffPlanId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffPlan>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffPlanListing> GetManagementunitTimeoffplansAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffPlanListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffRequestResponse> GetManagementunitUserTimeoffrequestAsync(string managementUnitId, string userId, string timeOffRequestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/{timeOffRequestId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffRequestResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<QueryTimeOffLimitValuesResponse> GetManagementunitUserTimeoffrequestTimeofflimitsAsync(string managementUnitId, string userId, string timeOffRequestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/{timeOffRequestId}/timeofflimits", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QueryTimeOffLimitValuesResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffRequestList> GetManagementunitUserTimeoffrequestsAsync(string managementUnitId, string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffRequestList>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WfmUserEntityListing> GetManagementunitUsersAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/users", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WfmUserEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WeekScheduleResponse> GetManagementunitWeekScheduleAsync(string managementUnitId, string weekId, string scheduleId, string expand, bool? forceDownloadService, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentException.ThrowIfNullOrEmpty(expand);

        var parameters = new NameValueCollection();
        if (expand != null) parameters.Add("expand", expand.ToString());
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WeekScheduleResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WeekScheduleListResponse> GetManagementunitWeekSchedulesAsync(string managementUnitId, string weekId, bool? includeOnlyPublished, string earliestWeekDate, string latestWeekDate, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(earliestWeekDate);
        ArgumentException.ThrowIfNullOrEmpty(latestWeekDate);

        var parameters = new NameValueCollection();
        if (includeOnlyPublished != null) parameters.Add("includeOnlyPublished", includeOnlyPublished.ToString());
        if (earliestWeekDate != null) parameters.Add("earliestWeekDate", earliestWeekDate.ToString());
        if (latestWeekDate != null) parameters.Add("latestWeekDate", latestWeekDate.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WeekScheduleListResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WeekShiftTradeListResponse> GetManagementunitWeekShifttradesAsync(string managementUnitId, string weekDateId, bool? evaluateMatches, bool? forceDownloadService, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);

        var parameters = new NameValueCollection();
        if (evaluateMatches != null) parameters.Add("evaluateMatches", evaluateMatches.ToString());
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WeekShiftTradeListResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlan> GetManagementunitWorkplanAsync(string managementUnitId, string workPlanId, List<string> includeOnly, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);
        ArgumentNullException.ThrowIfNull(includeOnly);

        var parameters = new NameValueCollection();
        if (includeOnly != null) parameters.Add("includeOnly", includeOnly.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlan>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanRotationResponse> GetManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations/{workPlanRotationId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanRotationResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanRotationListResponse> GetManagementunitWorkplanrotationsAsync(string managementUnitId, List<string> expand, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(expand);

        var parameters = new NameValueCollection();
        if (expand != null) parameters.Add("expand", expand.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanRotationListResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanListResponse> GetManagementunitWorkplansAsync(string managementUnitId, List<string> expand, List<string> exclude, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(expand);
        ArgumentNullException.ThrowIfNull(exclude);

        var parameters = new NameValueCollection();
        if (expand != null) parameters.Add("expand", expand.ToString());
        if (exclude != null) parameters.Add("exclude", exclude.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanListResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ManagementUnitListing> GetManagementunitsAsync(int? pageSize, int? pageNumber, string expand, string feature, string divisionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(expand);
        ArgumentException.ThrowIfNullOrEmpty(feature);
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        var parameters = new NameValueCollection();
        if (pageSize != null) parameters.Add("pageSize", pageSize.ToString());
        if (pageNumber != null) parameters.Add("pageNumber", pageNumber.ToString());
        if (expand != null) parameters.Add("expand", expand.ToString());
        if (feature != null) parameters.Add("feature", feature.ToString());
        if (divisionId != null) parameters.Add("divisionId", divisionId.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ManagementUnitListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ManagementUnitListing> GetManagementunitsDivisionviewsAsync(List<string> divisionId, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(divisionId);

        var parameters = new NameValueCollection();
        if (divisionId != null) parameters.Add("divisionId", divisionId.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/divisionviews", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ManagementUnitListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<NotificationsResponse> GetNotificationsAsync(CancellationToken cancellationToken = default)
    {

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/notifications", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NotificationsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<SchedulingStatusResponse> GetSchedulingjobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/schedulingjobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SchedulingStatusResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ShiftTradeListResponse> GetShifttradesAsync(CancellationToken cancellationToken = default)
    {

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/shifttrades", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ShiftTradeListResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WfmHistoricalShrinkageResponse> GetShrinkageJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/shrinkage/jobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WfmHistoricalShrinkageResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffBalanceJobResponse> GetTimeoffbalanceJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/timeoffbalance/jobs/{jobId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffBalanceJobResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffRequestResponse> GetTimeoffrequestAsync(string timeOffRequestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffRequestResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WaitlistPositionListing> GetTimeoffrequestWaitlistpositionsAsync(string timeOffRequestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}/waitlistpositions", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WaitlistPositionListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffRequestList> GetTimeoffrequestsAsync(CancellationToken cancellationToken = default)
    {

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeoffrequests", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffRequestList>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanBidRanks> GetUserWorkplanbidranksAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/users/{userId}/workplanbidranks", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanBidRanks>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AgentWorkPlanBiddingPreferenceResponse> GetWorkplanbidPreferencesAsync(string bidId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(bidId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/workplanbids/{bidId}/preferences", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentWorkPlanBiddingPreferenceResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AgentWorkPlanListResponse> GetWorkplanbidWorkplansAsync(string bidId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(bidId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/workplanbids/{bidId}/workplans", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentWorkPlanListResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AgentWorkPlanBids> GetWorkplanbidsAsync(CancellationToken cancellationToken = default)
    {

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/workplanbids", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentWorkPlanBids>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AdherenceExplanationAsyncResponse> UpdateAgentAdherenceExplanationAsync(string agentId, string explanationId, UpdateAdherenceExplanationStatusRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentException.ThrowIfNullOrEmpty(explanationId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/agents/{agentId}/adherence/explanations/{explanationId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AdherenceExplanationAsyncResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AlternativeShiftTradeResponse> UpdateAlternativeshiftsTradeAsync(string tradeId, AgentUpdateAlternativeShiftTradeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(tradeId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/alternativeshifts/trades/{tradeId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlternativeShiftTradeResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AlternativeShiftAsyncResponse> UpdateAlternativeshiftsTradesStateJobsAsync(AdminBulkUpdateAlternativeShiftTradeStateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/trades/state/jobs", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlternativeShiftAsyncResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BusinessUnitResponse> UpdateBusinessunitAsync(string businessUnitId, UpdateBusinessUnitRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BusinessUnitActivityCode> UpdateBusinessunitActivitycodeAsync(string businessUnitId, string activityCodeId, UpdateActivityCodeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes/{activityCodeId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitActivityCode>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ActivityPlanResponse> UpdateBusinessunitActivityplanAsync(string businessUnitId, string activityPlanId, UpdateActivityPlanRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/{activityPlanId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityPlanResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AlternativeShiftBuSettingsResponse> UpdateBusinessunitAlternativeshiftsSettingsAsync(string businessUnitId, UpdateAlternativeShiftBuSettingsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/settings", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlternativeShiftBuSettingsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<PlanningGroup> UpdateBusinessunitPlanninggroupAsync(string businessUnitId, string planningGroupId, UpdatePlanningGroupRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(planningGroupId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups/{planningGroupId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PlanningGroup>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task UpdateBusinessunitSchedulingRunAsync(string businessUnitId, string runId, PatchBuScheduleRunRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(runId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task<ServiceGoalTemplate> UpdateBusinessunitServicegoaltemplateAsync(string businessUnitId, string serviceGoalTemplateId, UpdateServiceGoalTemplate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(serviceGoalTemplateId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates/{serviceGoalTemplateId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ServiceGoalTemplate>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<StaffingGroupResponse> UpdateBusinessunitStaffinggroupAsync(string businessUnitId, string staffingGroupId, UpdateStaffingGroupRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(staffingGroupId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups/{staffingGroupId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<StaffingGroupResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuTimeOffPlanResponse> UpdateBusinessunitTimeoffplanAsync(string businessUnitId, string timeOffPlanId, BuUpdateTimeOffPlanRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans/{timeOffPlanId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuTimeOffPlanResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanBid> UpdateBusinessunitWorkplanbidAsync(string businessUnitId, string bidId, UpdateWorkPlanBid body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanBid>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanBidGroupResponse> UpdateBusinessunitWorkplanbidGroupAsync(string businessUnitId, string bidId, string bidGroupId, WorkPlanBidGroupUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanBidGroupResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AdminAgentWorkPlanPreferenceResponse> UpdateBusinessunitWorkplanbidGroupPreferencesAsync(string businessUnitId, string bidId, string bidGroupId, AgentsBidAssignedWorkPlanOverrideRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentException.ThrowIfNullOrEmpty(bidGroupId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId}/preferences", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AdminAgentWorkPlanPreferenceResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ManagementUnit> UpdateManagementunitAsync(string managementUnitId, UpdateManagementUnitRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ManagementUnit>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task UpdateManagementunitAgentsAsync(string managementUnitId, UpdateMuAgentsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/agents", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />

    public async Task<UpdateMuAgentWorkPlansBatchResponse> UpdateManagementunitAgentsWorkplansBulkAsync(string managementUnitId, UpdateMuAgentWorkPlansBatchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/workplans/bulk", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UpdateMuAgentWorkPlansBatchResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffLimit> UpdateManagementunitTimeofflimitAsync(string managementUnitId, string timeOffLimitId, UpdateTimeOffLimitRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/{timeOffLimitId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffLimit>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffPlan> UpdateManagementunitTimeoffplanAsync(string managementUnitId, string timeOffPlanId, UpdateTimeOffPlanRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffPlanId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans/{timeOffPlanId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffPlan>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<UserTimeOffIntegrationStatusResponse> UpdateManagementunitTimeoffrequestUserIntegrationstatusAsync(string managementUnitId, string timeOffRequestId, string userId, SetTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests/{timeOffRequestId}/users/{userId}/integrationstatus", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserTimeOffIntegrationStatusResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffRequestResponse> UpdateManagementunitUserTimeoffrequestAsync(string managementUnitId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/{timeOffRequestId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffRequestResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ShiftTradeResponse> UpdateManagementunitWeekShifttradeAsync(string managementUnitId, string weekDateId, string tradeId, PatchShiftTradeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(tradeId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/{tradeId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ShiftTradeResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlan> UpdateManagementunitWorkplanAsync(string managementUnitId, string workPlanId, string validationMode, WorkPlan body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);
        ArgumentException.ThrowIfNullOrEmpty(validationMode);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (validationMode != null) parameters.Add("validationMode", validationMode.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}", parameters);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlan>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanRotationResponse> UpdateManagementunitWorkplanrotationAsync(string managementUnitId, string workPlanRotationId, UpdateWorkPlanRotationRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations/{workPlanRotationId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanRotationResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffRequestResponse> UpdateTimeoffrequestAsync(string timeOffRequestId, AgentTimeOffRequestPatch body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffRequestResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanBidRanks> UpdateUserWorkplanbidranksAsync(string userId, WorkPlanBidRanks body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/users/{userId}/workplanbidranks", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanBidRanks>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<EntityListing> UpdateUsersWorkplanbidranksBulkAsync(List<WorkPlanBidRanks> body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/users/workplanbidranks/bulk", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AgentWorkPlanBiddingPreferenceResponse> UpdateWorkplanbidPreferencesAsync(string bidId, UpdateAgentWorkPlanBiddingPreference body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/workplanbids/{bidId}/preferences", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentWorkPlanBiddingPreferenceResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AdherenceExplanationAsyncResponse> CreateAdherenceExplanationsAsync(AddAdherenceExplanationAgentRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/adherence/explanations", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AdherenceExplanationAsyncResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<QueryAdherenceExplanationsResponse> CreateAdherenceExplanationsQueryAsync(AgentQueryAdherenceExplanationsRequest body, bool? forceAsync, bool? forceDownloadService, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (forceAsync != null) parameters.Add("forceAsync", forceAsync.ToString());
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/adherence/explanations/query", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QueryAdherenceExplanationsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WfmHistoricalAdherenceResponse> CreateAdherenceHistoricalAsync(WfmHistoricalAdherenceQueryForUsers body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/adherence/historical", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WfmHistoricalAdherenceResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WfmHistoricalAdherenceBulkResponse> CreateAdherenceHistoricalBulkAsync(WfmHistoricalAdherenceBulkQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/adherence/historical/bulk", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WfmHistoricalAdherenceBulkResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AdherenceExplanationAsyncResponse> CreateAgentAdherenceExplanationsAsync(string agentId, AddAdherenceExplanationAdminRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/agents/{agentId}/adherence/explanations", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AdherenceExplanationAsyncResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AgentQueryAdherenceExplanationsResponse> CreateAgentAdherenceExplanationsQueryAsync(string agentId, AgentQueryAdherenceExplanationsRequest body, bool? forceAsync, bool? forceDownloadService, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (forceAsync != null) parameters.Add("forceAsync", forceAsync.ToString());
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/agents/{agentId}/adherence/explanations/query", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentQueryAdherenceExplanationsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<MoveAgentsResponse> CreateAgentsAsync(MoveAgentsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agents", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MoveAgentsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AgentsIntegrationsListing> CreateAgentsIntegrationsHrisQueryAsync(QueryAgentsIntegrationsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agents/integrations/hris/query", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentsIntegrationsListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AgentPossibleWorkShiftsResponse> CreateAgentsMePossibleworkshiftsAsync(AgentPossibleWorkShiftsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agents/me/possibleworkshifts", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentPossibleWorkShiftsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuCurrentAgentScheduleSearchResponse> CreateAgentschedulesMineAsync(BuGetCurrentAgentScheduleRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/agentschedules/mine", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuCurrentAgentScheduleSearchResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AlternativeShiftAsyncResponse> CreateAlternativeshiftsOffersJobsAsync(AlternativeShiftOffersRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/offers/jobs", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlternativeShiftAsyncResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AlternativeShiftAsyncResponse> CreateAlternativeshiftsOffersSearchJobsAsync(AlternativeShiftSearchOffersRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/offers/search/jobs", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlternativeShiftAsyncResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AlternativeShiftTradeResponse> CreateAlternativeshiftsTradesAsync(CreateAlternativeShiftTradeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/alternativeshifts/trades", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlternativeShiftTradeResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BusinessUnitActivityCode> CreateBusinessunitActivitycodesAsync(string businessUnitId, CreateActivityCodeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitActivityCode>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ActivityPlanJobResponse> CreateBusinessunitActivityplanRunsJobsAsync(string businessUnitId, string activityPlanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityPlanId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/{activityPlanId}/runs/jobs", null);

        var response = await _httpClient.PostAsync(uri, null, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityPlanJobResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ActivityPlanResponse> CreateBusinessunitActivityplansAsync(string businessUnitId, CreateActivityPlanRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityPlanResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuQueryAdherenceExplanationsResponse> CreateBusinessunitAdherenceExplanationsQueryAsync(string businessUnitId, BuQueryAdherenceExplanationsRequest body, bool? forceAsync, bool? forceDownloadService, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (forceAsync != null) parameters.Add("forceAsync", forceAsync.ToString());
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/adherence/explanations/query", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuQueryAdherenceExplanationsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuAsyncAgentSchedulesSearchResponse> CreateBusinessunitAgentschedulesSearchAsync(string businessUnitId, bool? forceAsync, bool? forceDownloadService, BuSearchAgentSchedulesRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (forceAsync != null) parameters.Add("forceAsync", forceAsync.ToString());
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/agentschedules/search", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuAsyncAgentSchedulesSearchResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuListAlternativeShiftTradesResponse> CreateBusinessunitAlternativeshiftsTradesSearchAsync(string businessUnitId, SearchAlternativeShiftTradesRequest body, bool? forceAsync, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (forceAsync != null) parameters.Add("forceAsync", forceAsync.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/trades/search", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuListAlternativeShiftTradesResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AsyncIntradayResponse> CreateBusinessunitIntradayAsync(string businessUnitId, bool? forceAsync, IntradayPlanningGroupRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (forceAsync != null) parameters.Add("forceAsync", forceAsync.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/intraday", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncIntradayResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<PlanningGroup> CreateBusinessunitPlanninggroupsAsync(string businessUnitId, CreatePlanningGroupRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PlanningGroup>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ServiceGoalTemplate> CreateBusinessunitServicegoaltemplatesAsync(string businessUnitId, CreateServiceGoalTemplate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ServiceGoalTemplate>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<StaffingGroupResponse> CreateBusinessunitStaffinggroupsAsync(string businessUnitId, CreateStaffingGroupRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<StaffingGroupResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<UserStaffingGroupListing> CreateBusinessunitStaffinggroupsQueryAsync(string businessUnitId, QueryUserStaffingGroupListRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups/query", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserStaffingGroupListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuTimeOffLimitResponse> CreateBusinessunitTimeofflimitsAsync(string businessUnitId, BuCreateTimeOffLimitRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuTimeOffLimitResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuTimeOffLimitValuesResponse> CreateBusinessunitTimeofflimitsValuesQueryAsync(string businessUnitId, QueryTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits/values/query", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuTimeOffLimitValuesResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuTimeOffPlanResponse> CreateBusinessunitTimeoffplansAsync(string businessUnitId, BuCreateTimeOffPlanRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuTimeOffPlanResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuAsyncAgentSchedulesQueryResponse> CreateBusinessunitWeekScheduleAgentschedulesQueryAsync(string businessUnitId, string weekId, string scheduleId, BuQueryAgentSchedulesRequest body, bool? forceAsync, bool? forceDownloadService, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (forceAsync != null) parameters.Add("forceAsync", forceAsync.ToString());
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/agentschedules/query", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuAsyncAgentSchedulesQueryResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuAsyncScheduleResponse> CreateBusinessunitWeekScheduleCopyAsync(string businessUnitId, string weekId, string scheduleId, BuCopyScheduleRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/copy", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuAsyncScheduleResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<PerformancePredictionRecalculationResponse> CreateBusinessunitWeekSchedulePerformancepredictionsRecalculationsAsync(string businessUnitId, string weekId, string scheduleId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/performancepredictions/recalculations", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PerformancePredictionRecalculationResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<PerformancePredictionRecalculationUploadResponse> CreateBusinessunitWeekSchedulePerformancepredictionsRecalculationsUploadurlAsync(string businessUnitId, string weekId, string scheduleId, UploadUrlRequestBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/performancepredictions/recalculations/uploadurl", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PerformancePredictionRecalculationUploadResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuAsyncScheduleRunResponse> CreateBusinessunitWeekScheduleRescheduleAsync(string businessUnitId, string weekId, string scheduleId, BuRescheduleRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/reschedule", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuAsyncScheduleRunResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuAsyncScheduleResponse> CreateBusinessunitWeekScheduleUpdateAsync(string businessUnitId, string weekId, string scheduleId, ProcessScheduleUpdateUploadRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/update", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuAsyncScheduleResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<UpdateScheduleUploadResponse> CreateBusinessunitWeekScheduleUpdateUploadurlAsync(string businessUnitId, string weekId, string scheduleId, UploadUrlRequestBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/update/uploadurl", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UpdateScheduleUploadResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuScheduleMetadata> CreateBusinessunitWeekSchedulesAsync(string businessUnitId, string weekId, BuCreateBlankScheduleRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuScheduleMetadata>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuAsyncScheduleRunResponse> CreateBusinessunitWeekSchedulesGenerateAsync(string businessUnitId, string weekId, BuGenerateScheduleRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/generate", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuAsyncScheduleRunResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ScheduleUploadProcessingResponse> CreateBusinessunitWeekSchedulesImportAsync(string businessUnitId, string weekId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/import", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScheduleUploadProcessingResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ImportScheduleUploadResponse> CreateBusinessunitWeekSchedulesImportUploadurlAsync(string businessUnitId, string weekId, UploadUrlRequestBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/import/uploadurl", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ImportScheduleUploadResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AsyncForecastOperationResult> CreateBusinessunitWeekShorttermforecastCopyAsync(string businessUnitId, string weekDateId, string forecastId, CopyBuForecastRequest body, bool? forceAsync, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (forceAsync != null) parameters.Add("forceAsync", forceAsync.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/copy", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncForecastOperationResult>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AsyncForecastOperationResult> CreateBusinessunitWeekShorttermforecastsGenerateAsync(string businessUnitId, string weekDateId, GenerateBuForecastRequest body, bool? forceAsync, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (forceAsync != null) parameters.Add("forceAsync", forceAsync.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/generate", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncForecastOperationResult>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ImportForecastResponse> CreateBusinessunitWeekShorttermforecastsImportAsync(string businessUnitId, string weekDateId, WfmProcessUploadRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/import", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ImportForecastResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ImportForecastUploadResponse> CreateBusinessunitWeekShorttermforecastsImportUploadurlAsync(string businessUnitId, string weekDateId, UploadUrlRequestBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/import/uploadurl", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ImportForecastUploadResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanBid> CreateBusinessunitWorkplanbidCopyAsync(string businessUnitId, string bidId, CopyWorkPlanBid body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/copy", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanBid>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanBidGroupResponse> CreateBusinessunitWorkplanbidGroupsAsync(string businessUnitId, string bidId, WorkPlanBidGroupCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(bidId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanBidGroupResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanBid> CreateBusinessunitWorkplanbidsAsync(string businessUnitId, CreateWorkPlanBid body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanBid>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BusinessUnitResponse> CreateBusinessunitsAsync(CreateBusinessUnitRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/businessunits", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<CalendarUrlResponse> CreateCalendarUrlIcsAsync(string language, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(language);

        var parameters = new NameValueCollection();
        if (language != null) parameters.Add("language", language.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/calendar/url/ics", parameters);

        var response = await _httpClient.PostAsync(uri, null, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CalendarUrlResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<HistoricalImportDeleteFilesJobResponse> CreateHistoricaldataBulkRemoveJobsAsync(HistoricalImportDeleteFilesJobRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/historicaldata/bulk/remove/jobs", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<HistoricalImportDeleteFilesJobResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<HistoricalImportDeleteJobResponse> CreateHistoricaldataDeletejobAsync(CancellationToken cancellationToken = default)
    {

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/historicaldata/deletejob", null);

        var response = await _httpClient.PostAsync(uri, null, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<HistoricalImportDeleteJobResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ValidationServiceAsyncResponse> CreateHistoricaldataValidateAsync(ValidationServiceRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/historicaldata/validate", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ValidationServiceAsyncResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<HrisTimeOffTypesResponse> CreateIntegrationsHriTimeofftypesJobsAsync(string hrisIntegrationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(hrisIntegrationId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/integrations/hris/{hrisIntegrationId}/timeofftypes/jobs", null);

        var response = await _httpClient.PostAsync(uri, null, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<HrisTimeOffTypesResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AgentsWorkPlansResponse> CreateManagementunitAgentsWorkplansQueryAsync(string managementUnitId, bool? forceDownloadService, GetAgentsWorkPlansRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/workplans/query", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentsWorkPlansResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BuAsyncAgentSchedulesSearchResponse> CreateManagementunitAgentschedulesSearchAsync(string managementUnitId, bool? forceAsync, bool? forceDownloadService, BuSearchAgentSchedulesRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (forceAsync != null) parameters.Add("forceAsync", forceAsync.ToString());
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/agentschedules/search", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuAsyncAgentSchedulesSearchResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WfmHistoricalAdherenceResponse> CreateManagementunitHistoricaladherencequeryAsync(string managementUnitId, WfmHistoricalAdherenceQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/historicaladherencequery", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WfmHistoricalAdherenceResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<MoveManagementUnitResponse> CreateManagementunitMoveAsync(string managementUnitId, MoveManagementUnitRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/move", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MoveManagementUnitResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<UserScheduleContainer> CreateManagementunitSchedulesSearchAsync(string managementUnitId, UserListScheduleRequestBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/schedules/search", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserScheduleContainer>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WfmHistoricalShrinkageResponse> CreateManagementunitShrinkageJobsAsync(string managementUnitId, WfmHistoricalShrinkageRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/shrinkage/jobs", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WfmHistoricalShrinkageResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffLimit> CreateManagementunitTimeofflimitsAsync(string managementUnitId, CreateTimeOffLimitRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffLimit>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<QueryTimeOffLimitValuesResponse> CreateManagementunitTimeofflimitsValuesQueryAsync(string managementUnitId, QueryTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/values/query", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QueryTimeOffLimitValuesResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffPlan> CreateManagementunitTimeoffplansAsync(string managementUnitId, CreateTimeOffPlanRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffPlan>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffRequestList> CreateManagementunitTimeoffrequestsAsync(string managementUnitId, CreateAdminTimeOffRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffRequestList>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<UserTimeOffIntegrationStatusResponseListing> CreateManagementunitTimeoffrequestsIntegrationstatusQueryAsync(string managementUnitId, QueryTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests/integrationstatus/query", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserTimeOffIntegrationStatusResponseListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffRequestListing> CreateManagementunitTimeoffrequestsQueryAsync(string managementUnitId, bool? forceDownloadService, TimeOffRequestQueryBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests/query", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffRequestListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WaitlistPositionListing> CreateManagementunitTimeoffrequestsWaitlistpositionsQueryAsync(string managementUnitId, QueryWaitlistPositionsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests/waitlistpositions/query", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WaitlistPositionListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffBalancesResponse> CreateManagementunitUserTimeoffbalanceJobsAsync(string managementUnitId, string userId, TimeOffBalanceRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffbalance/jobs", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffBalancesResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffBalancesResponse> CreateManagementunitUserTimeoffrequestTimeoffbalanceJobsAsync(string managementUnitId, string userId, string timeOffRequestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffRequestId);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/{timeOffRequestId}/timeoffbalance/jobs", null);

        var response = await _httpClient.PostAsync(uri, null, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffBalancesResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<EstimateAvailableTimeOffResponse> CreateManagementunitUserTimeoffrequestsEstimateAsync(string managementUnitId, string userId, EstimateAvailableTimeOffRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/estimate", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EstimateAvailableTimeOffResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<MatchShiftTradeResponse> CreateManagementunitWeekShifttradeMatchAsync(string managementUnitId, string weekDateId, string tradeId, MatchShiftTradeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(tradeId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/{tradeId}/match", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MatchShiftTradeResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ShiftTradeResponse> CreateManagementunitWeekShifttradesAsync(string managementUnitId, string weekDateId, AddShiftTradeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ShiftTradeResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<SearchShiftTradesResponse> CreateManagementunitWeekShifttradesSearchAsync(string managementUnitId, string weekDateId, SearchShiftTradesRequest body, bool? forceDownloadService, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (forceDownloadService != null) parameters.Add("forceDownloadService", forceDownloadService.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/search", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SearchShiftTradesResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<BulkUpdateShiftTradeStateResponse> CreateManagementunitWeekShifttradesStateBulkAsync(string managementUnitId, string weekDateId, BulkShiftTradeStateUpdateRequest body, bool? forceAsync, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (forceAsync != null) parameters.Add("forceAsync", forceAsync.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/state/bulk", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkUpdateShiftTradeStateResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlan> CreateManagementunitWorkplanCopyAsync(string managementUnitId, string workPlanId, CopyWorkPlan body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}/copy", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlan>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ValidateWorkPlanResponse> CreateManagementunitWorkplanValidateAsync(string managementUnitId, string workPlanId, List<string> expand, WorkPlanValidationRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanId);
        ArgumentNullException.ThrowIfNull(expand);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (expand != null) parameters.Add("expand", expand.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}/validate", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ValidateWorkPlanResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanRotationResponse> CreateManagementunitWorkplanrotationCopyAsync(string managementUnitId, string workPlanRotationId, CopyWorkPlanRotationRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(workPlanRotationId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations/{workPlanRotationId}/copy", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanRotationResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlanRotationResponse> CreateManagementunitWorkplanrotationsAsync(string managementUnitId, AddWorkPlanRotationRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlanRotationResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WorkPlan> CreateManagementunitWorkplansAsync(string managementUnitId, string validationMode, CreateWorkPlan body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(validationMode);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (validationMode != null) parameters.Add("validationMode", validationMode.ToString());

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkPlan>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ManagementUnit> CreateManagementunitsAsync(CreateManagementUnitApiRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/managementunits", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ManagementUnit>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<UpdateNotificationsResponse> CreateNotificationsUpdateAsync(UpdateNotificationsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/notifications/update", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UpdateNotificationsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<UserScheduleContainer> CreateSchedulesAsync(CurrentUserScheduleRequestBody body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/schedules", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserScheduleContainer>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WfmHistoricalAdherenceResponse> CreateTeamAdherenceHistoricalAsync(string teamId, WfmHistoricalAdherenceQueryForTeams body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(teamId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/teams/{teamId}/adherence/historical", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WfmHistoricalAdherenceResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<WfmHistoricalShrinkageResponse> CreateTeamShrinkageJobsAsync(string teamId, WfmHistoricalShrinkageTeamsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(teamId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/teams/{teamId}/shrinkage/jobs", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WfmHistoricalShrinkageResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffBalancesResponse> CreateTimeoffbalanceJobsAsync(TimeOffBalanceRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeoffbalance/jobs", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffBalancesResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<AvailableTimeOffResponse> CreateTimeofflimitsAvailableQueryAsync(AvailableTimeOffRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeofflimits/available/query", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AvailableTimeOffResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffRequestResponse> CreateTimeoffrequestsAsync(CreateAgentTimeOffRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeoffrequests", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffRequestResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<EstimateAvailableTimeOffResponse> CreateTimeoffrequestsEstimateAsync(EstimateAvailableTimeOffRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeoffrequests/estimate", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EstimateAvailableTimeOffResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffIntegrationStatusResponseListing> CreateTimeoffrequestsIntegrationstatusQueryAsync(CurrentUserTimeOffIntegrationStatusRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/workforcemanagement/timeoffrequests/integrationstatus/query", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffIntegrationStatusResponseListing>(_options, cancellationToken);
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

    /// <inheritdoc />

    public async Task<BuTimeOffLimitResponse> UpdateBusinessunitTimeofflimitValuesAsync(string businessUnitId, string timeOffLimitId, BuSetTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits/{timeOffLimitId}/values", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuTimeOffLimitResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeOffLimit> UpdateManagementunitTimeofflimitValuesAsync(string managementUnitId, string timeOffLimitId, SetTimeOffLimitValuesRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentException.ThrowIfNullOrEmpty(timeOffLimitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/{timeOffLimitId}/values", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeOffLimit>(_options, cancellationToken);
    }
}
