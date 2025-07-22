using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public sealed class JourneyApi : IJourneyApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public JourneyApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task DeleteJourneyActionmapAsync(string actionMapId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionMapId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/journey/actionmaps/{actionMapId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteJourneyActiontemplateAsync(string actionTemplateId, bool? hardDelete = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionTemplateId);

        var parameters = new NameValueCollection();

        if (hardDelete.HasValue)
        {
            parameters.Add("hardDelete", UriHelper.ParameterToString(hardDelete.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/journey/actiontemplates/{actionTemplateId}", parameters);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteJourneyOutcomeAsync(string outcomeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(outcomeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/journey/outcomes/{outcomeId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteJourneyOutcomesPredictorAsync(string predictorId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(predictorId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/journey/outcomes/predictors/{predictorId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteJourneySegmentAsync(string segmentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(segmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/journey/segments/{segmentId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteJourneyViewAsync(string viewId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/journey/views/{viewId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<JourneyViewSchedule> DeleteJourneyViewSchedulesAsync(string viewId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/journey/views/{viewId}/schedules", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AsyncQueryStatus> GetAnalyticsJourneysAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/analytics/journeys/aggregates/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyAsyncAggregateQueryResponse> GetAnalyticsJourneysAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/analytics/journeys/aggregates/jobs/{jobId}/results", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SessionListing> GetExternalcontactsContactJourneySessionsAsync(string contactId, string pageSize = null, string after = null, bool? includeMerged = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(contactId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (includeMerged.HasValue)
        {
            parameters.Add("includeMerged", UriHelper.ParameterToString(includeMerged.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/externalcontacts/contacts/{contactId}/journey/sessions", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SessionListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActionMap> GetJourneyActionmapAsync(string actionMapId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionMapId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/actionmaps/{actionMapId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionMap>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActionMapListing> GetJourneyActionmapsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string filterField = null, string filterValue = null, IEnumerable<string> actionMapIds = null, IEnumerable<string> queryFields = null, string queryValue = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(filterField))
        {
            parameters.Add("filterField", UriHelper.ParameterToString(filterField));
        }

        if (!string.IsNullOrEmpty(filterValue))
        {
            parameters.Add("filterValue", UriHelper.ParameterToString(filterValue));
        }

        if (actionMapIds != null)
        {
            foreach (var value in actionMapIds)
            {
                parameters.Add("actionMapIds", UriHelper.ParameterToString(value));
            }
        }

        if (queryFields != null)
        {
            foreach (var value in queryFields)
            {
                parameters.Add("queryFields", UriHelper.ParameterToString(value));
            }
        }

        if (!string.IsNullOrEmpty(queryValue))
        {
            parameters.Add("queryValue", UriHelper.ParameterToString(queryValue));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/journey/actionmaps", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionMapListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetJourneyActionmapsEstimatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/actionmaps/estimates/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<string>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActionMapEstimateResult> GetJourneyActionmapsEstimatesJobResultsAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/actionmaps/estimates/jobs/{jobId}/results", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionMapEstimateResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActionTarget> GetJourneyActiontargetAsync(string actionTargetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionTargetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/actiontargets/{actionTargetId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionTarget>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActionTargetListing> GetJourneyActiontargetsAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
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

        var uri = UriHelper.GetUri("api/v2/journey/actiontargets", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionTargetListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActionTemplate> GetJourneyActiontemplateAsync(string actionTemplateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionTemplateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/actiontemplates/{actionTemplateId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionTemplate>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActionTemplateListing> GetJourneyActiontemplatesAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string mediaType = null, string state = null, IEnumerable<string> queryFields = null, string queryValue = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(mediaType))
        {
            parameters.Add("mediaType", UriHelper.ParameterToString(mediaType));
        }

        if (!string.IsNullOrEmpty(state))
        {
            parameters.Add("state", UriHelper.ParameterToString(state));
        }

        if (queryFields != null)
        {
            foreach (var value in queryFields)
            {
                parameters.Add("queryFields", UriHelper.ParameterToString(value));
            }
        }

        if (!string.IsNullOrEmpty(queryValue))
        {
            parameters.Add("queryValue", UriHelper.ParameterToString(queryValue));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/journey/actiontemplates", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionTemplateListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DeploymentPing> GetJourneyDeploymentCustomerPingAsync(string deploymentId, string customerCookieId, string dl = null, string dt = null, string appNamespace = null, string sessionId = null, long? sinceLastBeaconMilliseconds = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);
        ArgumentException.ThrowIfNullOrEmpty(customerCookieId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(dl))
        {
            parameters.Add("dl", UriHelper.ParameterToString(dl));
        }

        if (!string.IsNullOrEmpty(dt))
        {
            parameters.Add("dt", UriHelper.ParameterToString(dt));
        }

        if (!string.IsNullOrEmpty(appNamespace))
        {
            parameters.Add("appNamespace", UriHelper.ParameterToString(appNamespace));
        }

        if (!string.IsNullOrEmpty(sessionId))
        {
            parameters.Add("sessionId", UriHelper.ParameterToString(sessionId));
        }

        if (sinceLastBeaconMilliseconds.HasValue)
        {
            parameters.Add("sinceLastBeaconMilliseconds", UriHelper.ParameterToString(sinceLastBeaconMilliseconds.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/journey/deployments/{deploymentId}/customers/{customerCookieId}/ping", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DeploymentPing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Outcome> GetJourneyOutcomeAsync(string outcomeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(outcomeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/outcomes/{outcomeId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Outcome>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OutcomeListing> GetJourneyOutcomesAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, IEnumerable<string> outcomeIds = null, IEnumerable<string> queryFields = null, string queryValue = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (outcomeIds != null)
        {
            foreach (var value in outcomeIds)
            {
                parameters.Add("outcomeIds", UriHelper.ParameterToString(value));
            }
        }

        if (queryFields != null)
        {
            foreach (var value in queryFields)
            {
                parameters.Add("queryFields", UriHelper.ParameterToString(value));
            }
        }

        if (!string.IsNullOrEmpty(queryValue))
        {
            parameters.Add("queryValue", UriHelper.ParameterToString(queryValue));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/journey/outcomes", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutcomeListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OutcomeAttributionJobStateResponse> GetJourneyOutcomesAttributionsJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/outcomes/attributions/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutcomeAttributionJobStateResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OutcomeAttributionResponseListing> GetJourneyOutcomesAttributionsJobResultsAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/outcomes/attributions/jobs/{jobId}/results", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutcomeAttributionResponseListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OutcomePredictor> GetJourneyOutcomesPredictorAsync(string predictorId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(predictorId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/outcomes/predictors/{predictorId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutcomePredictor>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OutcomePredictorListing> GetJourneyOutcomesPredictorsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/journey/outcomes/predictors", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutcomePredictorListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneySegment> GetJourneySegmentAsync(string segmentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(segmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/segments/{segmentId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneySegment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SegmentListing> GetJourneySegmentsAsync(string sortBy = null, int? pageSize = null, int? pageNumber = null, bool? isActive = null, IEnumerable<string> segmentIds = null, IEnumerable<string> queryFields = null, string queryValue = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (isActive.HasValue)
        {
            parameters.Add("isActive", UriHelper.ParameterToString(isActive.Value));
        }

        if (segmentIds != null)
        {
            foreach (var value in segmentIds)
            {
                parameters.Add("segmentIds", UriHelper.ParameterToString(value));
            }
        }

        if (queryFields != null)
        {
            foreach (var value in queryFields)
            {
                parameters.Add("queryFields", UriHelper.ParameterToString(value));
            }
        }

        if (!string.IsNullOrEmpty(queryValue))
        {
            parameters.Add("queryValue", UriHelper.ParameterToString(queryValue));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/journey/segments", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SegmentListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Session> GetJourneySessionAsync(string sessionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/sessions/{sessionId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Session>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EventListing> GetJourneySessionEventsAsync(string sessionId, string pageSize = null, string after = null, string eventType = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (!string.IsNullOrEmpty(eventType))
        {
            parameters.Add("eventType", UriHelper.ParameterToString(eventType));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/journey/sessions/{sessionId}/events", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EventListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OutcomeScoresResult> GetJourneySessionOutcomescoresAsync(string sessionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/sessions/{sessionId}/outcomescores", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutcomeScoresResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyView> GetJourneyViewAsync(string viewId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/views/{viewId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyView>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyViewSchedule> GetJourneyViewSchedulesAsync(string viewId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/views/{viewId}/schedules", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyView> GetJourneyViewVersionAsync(string viewId, string versionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);
        ArgumentException.ThrowIfNullOrEmpty(versionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/views/{viewId}/versions/{versionId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyView>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyViewChart> GetJourneyViewVersionChartAsync(string viewId, string journeyViewVersion, string chartId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);
        ArgumentException.ThrowIfNullOrEmpty(journeyViewVersion);
        ArgumentException.ThrowIfNullOrEmpty(chartId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/views/{viewId}/versions/{journeyViewVersion}/charts/{chartId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewChart>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyViewChart> GetJourneyViewVersionChartVersionAsync(string viewId, string journeyViewVersion, string chartId, string chartVersion, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);
        ArgumentException.ThrowIfNullOrEmpty(journeyViewVersion);
        ArgumentException.ThrowIfNullOrEmpty(chartId);
        ArgumentException.ThrowIfNullOrEmpty(chartVersion);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/views/{viewId}/versions/{journeyViewVersion}/charts/{chartId}/versions/{chartVersion}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewChart>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyViewJob> GetJourneyViewVersionJobAsync(string viewId, string journeyVersionId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);
        ArgumentException.ThrowIfNullOrEmpty(journeyVersionId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyViewResult> GetJourneyViewVersionJobResultsAsync(string viewId, string journeyViewVersion, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);
        ArgumentException.ThrowIfNullOrEmpty(journeyViewVersion);
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/views/{viewId}/versions/{journeyViewVersion}/jobs/{jobId}/results", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyViewChartResult> GetJourneyViewVersionJobResultsChartAsync(string viewId, string journeyVersionId, string jobId, string chartId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);
        ArgumentException.ThrowIfNullOrEmpty(journeyVersionId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);
        ArgumentException.ThrowIfNullOrEmpty(chartId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs/{jobId}/results/charts/{chartId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewChartResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyViewJob> GetJourneyViewVersionJobsLatestAsync(string viewId, string journeyVersionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);
        ArgumentException.ThrowIfNullOrEmpty(journeyVersionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs/latest", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyViewListing> GetJourneyViewsAsync(int? pageNumber = null, int? pageSize = null, string nameOrCreatedBy = null, string expand = null, string id = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(nameOrCreatedBy))
        {
            parameters.Add("nameOrCreatedBy", UriHelper.ParameterToString(nameOrCreatedBy));
        }

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (!string.IsNullOrEmpty(id))
        {
            parameters.Add("id", UriHelper.ParameterToString(id));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/journey/views", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataRange> GetJourneyViewsDataDetailsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/journey/views/data/details", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataRange>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyEventDefinition> GetJourneyViewsEventdefinitionAsync(string eventDefinitionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(eventDefinitionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/journey/views/eventdefinitions/{eventDefinitionId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyEventDefinition>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyEventDefinitionListing> GetJourneyViewsEventdefinitionsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/journey/views/eventdefinitions", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyEventDefinitionListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyViewJobListing> GetJourneyViewsJobsAsync(int? pageNumber = null, int? pageSize = null, string interval = null, string statuses = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(interval))
        {
            parameters.Add("interval", UriHelper.ParameterToString(interval));
        }

        if (!string.IsNullOrEmpty(statuses))
        {
            parameters.Add("statuses", UriHelper.ParameterToString(statuses));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/journey/views/jobs", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewJobListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyViewScheduleListing> GetJourneyViewsSchedulesAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
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

        var uri = UriHelper.GetUri("api/v2/journey/views/schedules", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewScheduleListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActionMap> PatchJourneyActionmapAsync(string actionMapId, PatchActionMap body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionMapId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/journey/actionmaps/{actionMapId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionMap>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActionTarget> PatchJourneyActiontargetAsync(string actionTargetId, PatchActionTarget body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionTargetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/journey/actiontargets/{actionTargetId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionTarget>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActionTemplate> PatchJourneyActiontemplateAsync(string actionTemplateId, PatchActionTemplate body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(actionTemplateId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/journey/actiontemplates/{actionTemplateId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionTemplate>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Outcome> PatchJourneyOutcomeAsync(string outcomeId, PatchOutcome body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(outcomeId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/journey/outcomes/{outcomeId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Outcome>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneySegment> PatchJourneySegmentAsync(string segmentId, PatchSegment body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(segmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/journey/segments/{segmentId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneySegment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyViewJob> PatchJourneyViewVersionJobAsync(string viewId, string journeyVersionId, string jobId, JourneyViewJob body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);
        ArgumentException.ThrowIfNullOrEmpty(journeyVersionId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs/{jobId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AsyncQueryResponse> CreateAnalyticsJourneysAggregatesJobsAsync(JourneyAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/journeys/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyAggregateQueryResponse> CreateAnalyticsJourneysAggregatesQueryAsync(JourneyAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/journeys/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActionMap> CreateJourneyActionmapsAsync(ActionMap body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/journey/actionmaps", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionMap>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EstimateJobAsyncResponse> CreateJourneyActionmapsEstimatesJobsAsync(ActionMapEstimateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/journey/actionmaps/estimates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EstimateJobAsyncResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActionTemplate> CreateJourneyActiontemplatesAsync(ActionTemplate body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/journey/actiontemplates", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionTemplate>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task CreateJourneyDeploymentActioneventAsync(string deploymentId, ActionEventRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/journey/deployments/{deploymentId}/actionevent", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<AppEventResponse> CreateJourneyDeploymentAppeventsAsync(string deploymentId, AppEventRequest body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/journey/deployments/{deploymentId}/appevents", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AppEventResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<WebEventResponse> CreateJourneyDeploymentWebeventsAsync(string deploymentId, WebEventRequest body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/journey/deployments/{deploymentId}/webevents", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebEventResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<FlowPaths> CreateJourneyFlowsPathsQueryAsync(FlowPathsQuery body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/journey/flows/paths/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowPaths>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Outcome> CreateJourneyOutcomesAsync(OutcomeRequest body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/journey/outcomes", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Outcome>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OutcomeAttributionAsyncResponse> CreateJourneyOutcomesAttributionsJobsAsync(OutcomeAttributionListing body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/journey/outcomes/attributions/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutcomeAttributionAsyncResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OutcomePredictor> CreateJourneyOutcomesPredictorsAsync(OutcomePredictorRequest body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/journey/outcomes/predictors", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OutcomePredictor>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneySegment> CreateJourneySegmentsAsync(JourneySegmentRequest body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/journey/segments", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneySegment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyViewSchedule> CreateJourneyViewSchedulesAsync(string viewId, JourneyViewSchedule body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/journey/views/{viewId}/schedules", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyViewJob> CreateJourneyViewVersionJobsAsync(string viewId, string journeyVersionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);
        ArgumentException.ThrowIfNullOrEmpty(journeyVersionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs", null, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyView> CreateJourneyViewVersionsAsync(string viewId, JourneyView body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/journey/views/{viewId}/versions", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyView>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyView> CreateJourneyViewsAsync(JourneyView body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/journey/views", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyView>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EntityListing> CreateJourneyViewsEncodingsValidateAsync(IEnumerable<Label> body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/journey/views/encodings/validate", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyViewSchedule> UpdateJourneyViewSchedulesAsync(string viewId, JourneyViewSchedule body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/journey/views/{viewId}/schedules", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyViewSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JourneyView> UpdateJourneyViewVersionAsync(string viewId, string versionId, JourneyView body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(viewId);
        ArgumentException.ThrowIfNullOrEmpty(versionId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/journey/views/{viewId}/versions/{versionId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyView>(_options.JsonSerializerOptions, cancellationToken);
    }
}