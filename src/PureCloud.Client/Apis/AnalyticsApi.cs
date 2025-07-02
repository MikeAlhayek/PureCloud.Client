using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;
using PureCloud.Client.Models.Analytics;

namespace PureCloud.Client.Apis;

public class AnalyticsApi : IAnalyticsApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public AnalyticsApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    // delete methods
    public async Task<bool> DeleteAnalyticsConversationsDetailsJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/analytics/conversations/details/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAnalyticsUsersDetailsJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/analytics/users/details/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }
    //delete methods

    // get methods
    public async Task<AsyncQueryStatus> GetAnalyticsActionsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/analytics/actions/aggregates/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ActionAsyncAggregateQueryResponse> GetAnalyticsActionsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/actions/aggregates/jobs/{jobId}/results";

        if (!string.IsNullOrEmpty(cursor))
        {
            url += $"?cursor={Uri.EscapeDataString(cursor)}";
        }

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsAgentStateAgentResponse> GetAnalyticsAgentStatusAsync(string userId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/analytics/agents/{userId}/status", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsAgentStateAgentResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsAgentcopilotsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/analytics/agentcopilots/aggregates/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AgentCopilotAsyncAggregateQueryResponse> GetAnalyticsAgentcopilotsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/agentcopilots/aggregates/jobs/{jobId}/results";

        if (!string.IsNullOrEmpty(cursor))
        {
            url += $"?cursor={Uri.EscapeDataString(cursor)}";
        }

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentCopilotAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ReportingTurnsResponse> GetAnalyticsBotflowDivisionsReportingturnsAsync(
    string botFlowId,
    string after = null,
    string pageSize = null,
    string interval = null,
    string actionId = null,
    string sessionId = null,
    string language = null,
    string askActionResults = null,
    CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<string>();
        if (!string.IsNullOrEmpty(after)) { query.Add($"after={Uri.EscapeDataString(after)}"); }
        if (!string.IsNullOrEmpty(pageSize)) { query.Add($"pageSize={Uri.EscapeDataString(pageSize)}"); }
        if (!string.IsNullOrEmpty(interval)) { query.Add($"interval={Uri.EscapeDataString(interval)}"); }
        if (!string.IsNullOrEmpty(actionId)) { query.Add($"actionId={Uri.EscapeDataString(actionId)}"); }
        if (!string.IsNullOrEmpty(sessionId)) { query.Add($"sessionId={Uri.EscapeDataString(sessionId)}"); }
        if (!string.IsNullOrEmpty(language)) { query.Add($"language={Uri.EscapeDataString(language)}"); }
        if (!string.IsNullOrEmpty(askActionResults)) { query.Add($"askActionResults={Uri.EscapeDataString(askActionResults)}"); }

        var url = $"api/v2/analytics/botflows/{botFlowId}/divisions/reportingturns";
        if (query.Count > 0)
        {
            url += "?" + string.Join("&", query);
        }

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ReportingTurnsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ReportingTurnsResponse> GetAnalyticsBotflowReportingturnsAsync(
    string botFlowId,
    string after = null,
    string pageSize = null,
    string interval = null,
    string actionId = null,
    string sessionId = null,
    string language = null,
    string askActionResults = null,
    CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<string>();
        if (!string.IsNullOrEmpty(after)) { query.Add($"after={Uri.EscapeDataString(after)}"); }
        if (!string.IsNullOrEmpty(pageSize)) { query.Add($"pageSize={Uri.EscapeDataString(pageSize)}"); }
        if (!string.IsNullOrEmpty(interval)) { query.Add($"interval={Uri.EscapeDataString(interval)}"); }
        if (!string.IsNullOrEmpty(actionId)) { query.Add($"actionId={Uri.EscapeDataString(actionId)}"); }
        if (!string.IsNullOrEmpty(sessionId)) { query.Add($"sessionId={Uri.EscapeDataString(sessionId)}"); }
        if (!string.IsNullOrEmpty(language)) { query.Add($"language={Uri.EscapeDataString(language)}"); }
        if (!string.IsNullOrEmpty(askActionResults)) { query.Add($"askActionResults={Uri.EscapeDataString(askActionResults)}"); }

        var url = $"api/v2/analytics/botflows/{botFlowId}/reportingturns";

        if (query.Count > 0)
        {
            url += "?" + string.Join("&", query);
        }
        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ReportingTurnsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SessionsResponse> GetAnalyticsBotflowSessionsAsync(
    string botFlowId,
    string after = null,
    string pageSize = null,
    string interval = null,
    string botResultCategories = null,
    string endLanguage = null,
    CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<string>();

        if (!string.IsNullOrEmpty(after)) { query.Add($"after={Uri.EscapeDataString(after)}"); }
        if (!string.IsNullOrEmpty(pageSize)) { query.Add($"pageSize={Uri.EscapeDataString(pageSize)}"); }
        if (!string.IsNullOrEmpty(interval)) { query.Add($"interval={Uri.EscapeDataString(interval)}"); }
        if (!string.IsNullOrEmpty(botResultCategories)) { query.Add($"botResultCategories={Uri.EscapeDataString(botResultCategories)}"); }
        if (!string.IsNullOrEmpty(endLanguage)) { query.Add($"endLanguage={Uri.EscapeDataString(endLanguage)}"); }

        var url = $"api/v2/analytics/botflows/{botFlowId}/sessions";

        if (query.Count > 0)
        {
            url += "?" + string.Join("&", query);
        }

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SessionsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsBotsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/bots/aggregates/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await client.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BotAsyncAggregateQueryResponse> GetAnalyticsBotsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/bots/aggregates/jobs/{Uri.EscapeDataString(jobId)}/results";

        if (!string.IsNullOrEmpty(cursor))
        {
            url += $"?cursor={Uri.EscapeDataString(cursor)}";
        }

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BotAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsConversationWithoutAttributes> GetAnalyticsConversationDetailsAsync(string conversationId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/conversations/{Uri.EscapeDataString(conversationId)}/details";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsConversationWithoutAttributes>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsConversationsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/conversations/aggregates/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ConversationAsyncAggregateQueryResponse> GetAnalyticsConversationsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/conversations/aggregates/jobs/{Uri.EscapeDataString(jobId)}/results";

        if (!string.IsNullOrEmpty(cursor))
        {
            url += $"?cursor={Uri.EscapeDataString(cursor)}";
        }

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ConversationAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsConversationWithoutAttributesMultiGetResponse> GetAnalyticsConversationsDetailsAsync(List<string> id = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<string>();

        if (id != null && id.Count > 0)
        {
            // Add each id as a separate query parameter: id=xxx&id=yyy
            query.AddRange(id.Select(i => $"id={Uri.EscapeDataString(i)}"));
        }

        var url = "api/v2/analytics/conversations/details";

        if (query.Count > 0)
        {
            url += "?" + string.Join("&", query);
        }
        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsConversationWithoutAttributesMultiGetResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsConversationsDetailsJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/conversations/details/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsConversationAsyncQueryResponse> GetAnalyticsConversationsDetailsJobResultsAsync(string jobId, string cursor = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<string>();

        if (!string.IsNullOrEmpty(cursor))
        {
            query.Add($"cursor={Uri.EscapeDataString(cursor)}");
        }
        if (pageSize.HasValue)
        {
            query.Add($"pageSize={pageSize.Value}");
        }
        var url = $"api/v2/analytics/conversations/details/jobs/{Uri.EscapeDataString(jobId)}/results";

        if (query.Count > 0)
        {
            url += "?" + string.Join("&", query);
        }
        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsConversationAsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataAvailabilityResponse> GetAnalyticsConversationsDetailsJobsAvailabilityAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/analytics/conversations/details/jobs/availability";

        var response = await client.GetAsync(url, cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync(cancellationToken);

            throw new Exception($"Error retrieving data: {content}");
        }

        return await response.Content.ReadFromJsonAsync<DataAvailabilityResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsDataRetentionResponse> GetAnalyticsDataretentionSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = "api/v2/analytics/dataretention/settings";

        var response = await client.GetAsync(url, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            throw new Exception($"Error retrieving data: {content}");
        }

        return await response.Content.ReadFromJsonAsync<AnalyticsDataRetentionResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsEvaluationsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/evaluations/aggregates/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await client.GetAsync(url, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            throw new Exception($"Error retrieving data: {content}");
        }

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationAsyncAggregateQueryResponse> GetAnalyticsEvaluationsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<string>();
        if (!string.IsNullOrEmpty(cursor))
        {
            query.Add($"cursor={Uri.EscapeDataString(cursor)}");
        }

        var url = $"api/v2/analytics/evaluations/aggregates/jobs/{Uri.EscapeDataString(jobId)}/results";

        var response = await client.GetAsync(url, cancellationToken);

        return await response.Content.ReadFromJsonAsync<EvaluationAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsFlowexecutionsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/flowexecutions/aggregates/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await client.GetAsync(url, cancellationToken);

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FlowExecutionAsyncAggregateQueryResponse> GetAnalyticsFlowexecutionsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(jobId))
        {
            return null;
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/flowexecutions/aggregates/jobs/{Uri.EscapeDataString(jobId)}/results";
        if (!string.IsNullOrEmpty(cursor))
        {
            url += $"?cursor={Uri.EscapeDataString(cursor)}";
        }

        var response = await client.GetAsync(url, cancellationToken);

        return await response.Content.ReadFromJsonAsync<FlowExecutionAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsFlowsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/flows/aggregates/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await client.GetAsync(url, cancellationToken);

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FlowAsyncAggregateQueryResponse> GetAnalyticsFlowsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(jobId))
        {
            return null;
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/flows/aggregates/jobs/{Uri.EscapeDataString(jobId)}/results";
        if (!string.IsNullOrEmpty(cursor))
        {
            url += $"?cursor={Uri.EscapeDataString(cursor)}";
        }

        var response = await client.GetAsync(url, cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<FlowAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsJourneysAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/journeys/aggregates/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await client.GetAsync(url, cancellationToken);

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<JourneyAsyncAggregateQueryResponse> GetAnalyticsJourneysAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/journeys/aggregates/jobs/{Uri.EscapeDataString(jobId)}/results";

        if (!string.IsNullOrEmpty(cursor))
        {
            url += $"?cursor={Uri.EscapeDataString(cursor)}";
        }

        var response = await client.GetAsync(url, cancellationToken);

        return await response.Content.ReadFromJsonAsync<JourneyAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsKnowledgeAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/knowledge/aggregates/jobs/{Uri.EscapeDataString(jobId)}";

        var response = await client.GetAsync(url, cancellationToken);

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<KnowledgeAsyncAggregateQueryResponse> GetAnalyticsKnowledgeAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/knowledge/aggregates/jobs/{Uri.EscapeDataString(jobId)}/results";

        if (!string.IsNullOrEmpty(cursor))
        {
            url += $"?cursor={Uri.EscapeDataString(cursor)}";
        }

        var response = await client.GetAsync(url, cancellationToken);

        return await response.Content.ReadFromJsonAsync<KnowledgeAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DashboardUser> GetAnalyticsReportingDashboardsUserAsync(string userId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var url = $"api/v2/analytics/reporting/dashboards/users/{Uri.EscapeDataString(userId)}";

        var response = await client.GetAsync(url, cancellationToken);

        return await response.Content.ReadFromJsonAsync<DashboardUser>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DashboardUserListing> GetAnalyticsReportingDashboardsUsersAsync(
    string sortBy = null,
    int? pageNumber = null,
    int? pageSize = null,
    List<string> id = null,
    string state = null,
    bool? deletedOnly = null,
    CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new List<string>();
        if (!string.IsNullOrEmpty(sortBy))
        {
            query.Add($"sortBy={Uri.EscapeDataString(sortBy)}");
        }
        if (pageNumber.HasValue)
        {
            query.Add($"pageNumber={pageNumber.Value}");
        }
        if (pageSize.HasValue)
        {
            query.Add($"pageSize={pageSize.Value}");
        }
        if (id != null && id.Count > 0)
        {
            query.AddRange(id.Select(i => $"id={Uri.EscapeDataString(i)}"));
        }
        if (!string.IsNullOrEmpty(state))
        {
            query.Add($"state={Uri.EscapeDataString(state)}");
        }
        if (deletedOnly.HasValue)
        {
            query.Add($"deletedOnly={deletedOnly.Value.ToString().ToLowerInvariant()}");
        }

        var url = "api/v2/analytics/reporting/dashboards/users";
        if (query.Count > 0)
        {
            url += "?" + string.Join("&", query);
        }

        var response = await client.GetAsync(url, cancellationToken);

        return await response.Content.ReadFromJsonAsync<DashboardUserListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ReportingExportJobListing> GetAnalyticsReportingExportsAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/analytics/reporting/exports";

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (pageNumber.HasValue)
        {
            queryParameters.Add(new KeyValuePair<string, string>("pageNumber", UriHelper.ParameterToString(pageNumber.Value)));
        }

        if (pageSize.HasValue)
        {
            queryParameters.Add(new KeyValuePair<string, string>("pageSize", UriHelper.ParameterToString(pageSize.Value)));
        }

        uri = QueryHelpers.AddQueryString(uri, queryParameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ReportingExportJobListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ReportingExportMetadataJobListing> GetAnalyticsReportingExportsMetadataAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/analytics/reporting/exports/metadata";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ReportingExportMetadataJobListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DashboardConfigurationListing> GetAnalyticsReportingSettingsDashboardsQueryAsync(
        string dashboardType,
        string dashboardAccessFilter,
        string name = null,
        string dashboardState = null,
        string sortBy = null,
        int? pageNumber = null,
        int? pageSize = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dashboardType);

        ArgumentException.ThrowIfNullOrEmpty(dashboardAccessFilter);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (name != null)
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        parameters.Add("dashboardType", UriHelper.ParameterToString(dashboardType));

        if (dashboardState != null)
        {
            parameters.Add("dashboardState", UriHelper.ParameterToString(dashboardState));
        }

        parameters.Add("dashboardAccessFilter", UriHelper.ParameterToString(dashboardAccessFilter));

        if (sortBy != null)
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        var requestUri = UriHelper.GetUri($"api/v2/analytics/reporting/settings/dashboards/query", parameters);

        var response = await client.GetAsync(requestUri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DashboardConfigurationListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DashboardConfigurationListing> GetAnalyticsReportingSettingsUserDashboardsAsync(
        string userId,
        string sortBy = null,
        int? pageNumber = null,
        int? pageSize = null,
        bool? publicOnly = null,
        bool? favoriteOnly = null,
        bool? deletedOnly = null,
        string name = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var paramMap = new Dictionary<string, object>
        {
            { "sortBy",       sortBy       },
            { "pageNumber",   pageNumber   },
            { "pageSize",     pageSize     },
            { "publicOnly",   publicOnly   },
            { "favoriteOnly", favoriteOnly },
            { "deletedOnly",  deletedOnly  },
            { "name",         name         }
        };

        foreach (var (key, value) in paramMap)
        {
            if (value is not null)
            {
                parameters.Add(key, UriHelper.ParameterToString(value));
            }
        }

        var requestUri = UriHelper.GetUri($"api/v2/analytics/reporting/settings/users/{userId}/dashboards", parameters);

        var response = await client.GetAsync(requestUri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DashboardConfigurationListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsResolutionsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/analytics/resolutions/aggregates/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ResolutionAsyncAggregateQueryResponse> GetAnalyticsResolutionsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();
        if (cursor != null)
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var requestUri = UriHelper.GetUri($"api/v2/analytics/resolutions/aggregates/jobs/{jobId}/results", parameters);

        var response = await client.GetAsync(requestUri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ResolutionAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsSummariesAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/analytics/summaries/aggregates/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SummaryAsyncAggregateQueryResponse> GetAnalyticsSummariesAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();
        if (cursor != null)
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var requestUri = UriHelper.GetUri($"api/v2/analytics/summaries/aggregates/jobs/{jobId}/results", parameters);

        var response = await client.GetAsync(requestUri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SummaryAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsSurveysAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/analytics/surveys/aggregates/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SurveyAsyncAggregateQueryResponse> GetAnalyticsSurveysAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();
        if (cursor != null)
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var requestUri = UriHelper.GetUri($"api/v2/analytics/surveys/aggregates/jobs/{jobId}/results", parameters);

        var response = await client.GetAsync(requestUri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SurveyAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsTaskmanagementAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/analytics/taskmanagement/aggregates/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TaskManagementAsyncAggregateQueryResponse> GetAnalyticsTaskmanagementAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();
        if (cursor != null)
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var requestUri = UriHelper.GetUri($"api/v2/analytics/taskmanagement/aggregates/jobs/{jobId}/results", parameters);

        var response = await client.GetAsync(requestUri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TaskManagementAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsTranscriptsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/analytics/transcripts/aggregates/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TranscriptAsyncAggregateQueryResponse> GetAnalyticsTranscriptsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();
        if (cursor != null)
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var requestUri = UriHelper.GetUri($"api/v2/analytics/transcripts/aggregates/jobs/{jobId}/results", parameters);

        var response = await client.GetAsync(requestUri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TranscriptAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsUsersAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/analytics/users/aggregates/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserAsyncAggregateQueryResponse> GetAnalyticsUsersAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();
        if (cursor != null)
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var requestUri = UriHelper.GetUri($"api/v2/analytics/users/aggregates/jobs/{jobId}/results", parameters);

        var response = await client.GetAsync(requestUri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsUsersDetailsJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/analytics/users/details/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsUserDetailsAsyncQueryResponse> GetAnalyticsUsersDetailsJobResultsAsync(string jobId, string cursor = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();
        var paramMap = new Dictionary<string, object>
        {
            { "cursor",   cursor   },
            { "pageSize", pageSize }
        };

        foreach (var (key, value) in paramMap)
        {
            if (value is not null)
            {
                parameters.Add(key, UriHelper.ParameterToString(value));
            }
        }

        var requestUri = UriHelper.GetUri($"api/v2/analytics/users/details/jobs/{jobId}/results", parameters);

        var response = await client.GetAsync(requestUri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsUserDetailsAsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DataAvailabilityResponse> GetAnalyticsUsersDetailsJobsAvailabilityAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/analytics/users/details/jobs/availability", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataAvailabilityResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsReportingSettings> PatchAnalyticsReportingSettingsAsync(AnalyticsReportingSettings body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync("api/v2/analytics/reporting/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsReportingSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsActionsAggregatesJobsAsync(ActionAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/actions/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ActionAggregateQueryResponse> CreateAnalyticsActionsAggregatesQueryAsync(ActionAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/actions/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActionAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsAgentcopilotsAggregatesJobsAsync(AgentCopilotAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/agentcopilots/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AgentCopilotAggregateQueryResponse> CreateAnalyticsAgentcopilotsAggregatesQueryAsync(AgentCopilotAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/agentcopilots/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentCopilotAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsAgentStateCountsResponse> CreateAnalyticsAgentsStatusCountsAsync(AgentStateCountsRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/agents/status/counts", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsAgentStateCountsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsAgentStateQueryResponse> CreateAnalyticsAgentsStatusQueryAsync(AgentStateQueryRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/agents/status/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsAgentStateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsBotsAggregatesJobsAsync(BotAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/bots/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BotAggregateQueryResponse> CreateAnalyticsBotsAggregatesQueryAsync(BotAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/bots/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BotAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<PropertyIndexRequest> CreateAnalyticsConversationDetailsPropertiesAsync(string conversationId, PropertyIndexRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/analytics/conversations/{conversationId}/details/properties", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PropertyIndexRequest>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ConversationActivityResponse> CreateAnalyticsConversationsActivityQueryAsync(ConversationActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var paramMap = new Dictionary<string, object>
        {
            { "pageSize",   pageSize   },
            { "pageNumber", pageNumber }
        };

        foreach (var (key, value) in paramMap)
        {
            if (value is not null)
            {
                parameters.Add(key, UriHelper.ParameterToString(value));
            }
        }

        var requestUri = UriHelper.GetUri("api/v2/analytics/conversations/activity/query", parameters);

        var response = await client.PostAsJsonAsync(requestUri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ConversationActivityResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsConversationsAggregatesJobsAsync(ConversationAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/conversations/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ConversationAggregateQueryResponse> CreateAnalyticsConversationsAggregatesQueryAsync(ConversationAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/conversations/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ConversationAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsConversationsDetailsJobsAsync(AsyncConversationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/conversations/details/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsConversationQueryResponse> CreateAnalyticsConversationsDetailsQueryAsync(ConversationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/conversations/details/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsConversationQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsConversationWithoutAttributesMultiGetResponse> CreateAnalyticsConversationsTranscriptsQueryAsync(TranscriptConversationDetailSearchRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/conversations/transcripts/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsConversationWithoutAttributesMultiGetResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsEvaluationsAggregatesJobsAsync(EvaluationAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/evaluations/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationAggregateQueryResponse> CreateAnalyticsEvaluationsAggregatesQueryAsync(EvaluationAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/evaluations/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsFlowexecutionsAggregatesJobsAsync(FlowExecutionAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/flowexecutions/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FlowExecutionAggregateQueryResponse> CreateAnalyticsFlowexecutionsAggregatesQueryAsync(FlowExecutionAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/flowexecutions/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowExecutionAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FlowActivityResponse> CreateAnalyticsFlowsActivityQueryAsync(FlowActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var paramMap = new Dictionary<string, object>
        {
            { "pageSize",   pageSize   },
            { "pageNumber", pageNumber }
        };

        foreach (var (key, value) in paramMap)
        {
            if (value is not null)
            {
                parameters.Add(key, UriHelper.ParameterToString(value));
            }
        }

        var requestUri = UriHelper.GetUri("api/v2/analytics/flows/activity/query", parameters);

        var response = await client.PostAsJsonAsync(requestUri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowActivityResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsFlowsAggregatesJobsAsync(FlowAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/flows/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FlowAggregateQueryResponse> CreateAnalyticsFlowsAggregatesQueryAsync(FlowAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/flows/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<FlowObservationQueryResponse> CreateAnalyticsFlowsObservationsQueryAsync(FlowObservationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/flows/observations/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FlowObservationQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsJourneysAggregatesJobsAsync(JourneyAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/journeys/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<JourneyAggregateQueryResponse> CreateAnalyticsJourneysAggregatesQueryAsync(JourneyAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/journeys/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JourneyAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsKnowledgeAggregatesJobsAsync(KnowledgeAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/knowledge/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<KnowledgeAggregateQueryResponse> CreateAnalyticsKnowledgeAggregatesQueryAsync(KnowledgeAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/knowledge/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<QueueObservationQueryResponse> CreateAnalyticsQueuesObservationsQueryAsync(QueueObservationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/queues/observations/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QueueObservationQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<RateLimitAggregateQueryResponse> CreateAnalyticsRatelimitsAggregatesQueryAsync(RateLimitAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/ratelimits/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RateLimitAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<object> CreateAnalyticsReportingDashboardsUsersBulkRemoveAsync(IList<string> body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/reporting/dashboards/users/bulk/remove", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<object>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ReportingExportJobResponse> CreateAnalyticsReportingExportsAsync(ReportingExportJobRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/reporting/exports", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ReportingExportJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<object> CreateAnalyticsReportingSettingsDashboardsBulkRemoveAsync(DashboardConfigurationBulkRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/reporting/settings/dashboards/bulk/remove", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<object>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DashboardConfigurationListing> CreateAnalyticsReportingSettingsDashboardsQueryAsync(DashboardConfigurationQueryRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/reporting/settings/dashboards/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DashboardConfigurationListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsResolutionsAggregatesJobsAsync(ResolutionAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/resolutions/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ResolutionAggregateQueryResponse> CreateAnalyticsResolutionsAggregatesQueryAsync(ResolutionAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/resolutions/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ResolutionAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<RoutingActivityResponse> CreateAnalyticsRoutingActivityQueryAsync(RoutingActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var requestUri = UriHelper.GetUri("api/v2/analytics/routing/activity/query", parameters);

        var response = await client.PostAsJsonAsync(requestUri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RoutingActivityResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsSummariesAggregatesJobsAsync(SummaryAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/summaries/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SummaryAggregateQueryResponse> CreateAnalyticsSummariesAggregatesQueryAsync(SummaryAggregationQuery body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/summaries/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SummaryAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsSurveysAggregatesJobsAsync(SurveyAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/surveys/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SurveyAggregateQueryResponse> CreateAnalyticsSurveysAggregatesQueryAsync(SurveyAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/surveys/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SurveyAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsTaskmanagementAggregatesJobsAsync(TaskManagementAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/taskmanagement/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TaskManagementAggregateQueryResponse> CreateAnalyticsTaskmanagementAggregatesQueryAsync(TaskManagementAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/taskmanagement/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TaskManagementAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TeamActivityResponse> CreateAnalyticsTeamsActivityQueryAsync(TeamActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();
        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }
        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var requestUri = UriHelper.GetUri("api/v2/analytics/teams/activity/query", parameters);

        var response = await client.PostAsJsonAsync(requestUri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TeamActivityResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsTranscriptsAggregatesJobsAsync(TranscriptAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/transcripts/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TranscriptAggregateQueryResponse> CreateAnalyticsTranscriptsAggregatesQueryAsync(TranscriptAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/transcripts/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TranscriptAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserActivityResponse> CreateAnalyticsUsersActivityQueryAsync(UserActivityQuery body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(nameof(body));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();
        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }
        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var requestUri = UriHelper.GetUri("api/v2/analytics/users/activity/query", parameters);

        var response = await client.PostAsJsonAsync(requestUri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserActivityResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsUsersAggregatesJobsAsync(UserAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/users/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserAggregateQueryResponse> CreateAnalyticsUsersAggregatesQueryAsync(UserAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/users/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryResponse> CreateAnalyticsUsersDetailsJobsAsync(AsyncUserDetailsQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/users/details/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsUserDetailsQueryResponse> CreateAnalyticsUsersDetailsQueryAsync(UserDetailsQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/users/details/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsUserDetailsQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<UserObservationQueryResponse> CreateAnalyticsUsersObservationsQueryAsync(UserObservationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/analytics/users/observations/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserObservationQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AnalyticsDataRetentionResponse> UpdateAnalyticsDataRetentionSettingsAsync(UpdateAnalyticsDataRetentionRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/analytics/dataretention/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AnalyticsDataRetentionResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

}
