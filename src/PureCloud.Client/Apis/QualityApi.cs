using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public sealed class QualityApi : IQualityApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public QualityApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<AgentActivityEntityListing> GetQualityAgentsActivityAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, IEnumerable<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null, string agentTeamId = null, string formContextId = null, string userState = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (expand?.Any() == true)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        if (startTime.HasValue)
        {
            parameters.Add("startTime", UriHelper.ParameterToString(startTime.Value));
        }

        if (endTime.HasValue)
        {
            parameters.Add("endTime", UriHelper.ParameterToString(endTime.Value));
        }

        if (agentUserId?.Any() == true)
        {
            foreach (var item in agentUserId)
            {
                parameters.Add("agentUserId", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(evaluatorUserId))
        {
            parameters.Add("evaluatorUserId", UriHelper.ParameterToString(evaluatorUserId));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(group))
        {
            parameters.Add("group", UriHelper.ParameterToString(group));
        }

        if (!string.IsNullOrEmpty(agentTeamId))
        {
            parameters.Add("agentTeamId", UriHelper.ParameterToString(agentTeamId));
        }

        if (!string.IsNullOrEmpty(formContextId))
        {
            parameters.Add("formContextId", UriHelper.ParameterToString(formContextId));
        }

        if (!string.IsNullOrEmpty(userState))
        {
            parameters.Add("userState", UriHelper.ParameterToString(userState));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/agents/activity", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentActivityEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Calibration> GetQualityCalibrationAsync(string calibrationId, string calibratorId = null, string conversationId = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(calibrationId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(calibratorId))
        {
            parameters.Add("calibratorId", UriHelper.ParameterToString(calibratorId));
        }

        if (!string.IsNullOrEmpty(conversationId))
        {
            parameters.Add("conversationId", UriHelper.ParameterToString(conversationId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/calibrations/{calibrationId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Calibration>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationResponse> GetQualityConversationEvaluationAsync(string conversationId, string evaluationId, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(evaluationId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationFormResponse> GetQualityFormsEvaluationAsync(string formId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/quality/forms/evaluations/{formId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationFormResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Survey> GetQualitySurveyAsync(string surveyId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(surveyId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/quality/surveys/{surveyId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Survey>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Calibration> CreateQualityCalibrationAsync(string calibratorId, CalibrationCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(calibratorId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        parameters.Add("calibratorId", UriHelper.ParameterToString(calibratorId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/calibrations", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Calibration>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationResponse> CreateQualityConversationEvaluationAsync(string conversationId, EvaluationCreateBody body, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/conversations/{conversationId}/evaluations", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationFormResponse> CreateQualityFormsEvaluationAsync(EvaluationForm body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/quality/forms/evaluations", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationFormResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationFormResponse> UpdateQualityFormsEvaluationAsync(string formId, EvaluationForm body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/quality/forms/evaluations/{formId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationFormResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SurveyForm> UpdateQualityFormsSurveyAsync(string formId, SurveyForm body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/quality/forms/surveys/{formId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SurveyForm>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Calibration> DeleteQualityCalibrationAsync(string calibrationId, string calibratorId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(calibrationId);
        ArgumentException.ThrowIfNullOrEmpty(calibratorId);

        var parameters = new NameValueCollection();
        parameters.Add("calibratorId", UriHelper.ParameterToString(calibratorId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/calibrations/{calibrationId}", parameters);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Calibration>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationResponse> DeleteQualityConversationEvaluationAsync(string conversationId, string evaluationId, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(evaluationId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}", parameters);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> GetAnalyticsEvaluationsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/analytics/evaluations/aggregates/jobs/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationAsyncAggregateQueryResponse> GetAnalyticsEvaluationsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/analytics/evaluations/aggregates/jobs/{jobId}/results", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
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

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/analytics/surveys/aggregates/jobs/{jobId}/results", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SurveyAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CalibrationEntityListing> GetQualityCalibrationsAsync(string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(calibratorId);

        var parameters = new NameValueCollection();
        parameters.Add("calibratorId", UriHelper.ParameterToString(calibratorId));

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (expand != null)
        {
            foreach (var expandItem in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(expandItem));
            }
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        if (!string.IsNullOrEmpty(conversationId))
        {
            parameters.Add("conversationId", UriHelper.ParameterToString(conversationId));
        }

        if (startTime.HasValue)
        {
            parameters.Add("startTime", UriHelper.ParameterToString(startTime.Value));
        }

        if (endTime.HasValue)
        {
            parameters.Add("endTime", UriHelper.ParameterToString(endTime.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/calibrations", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CalibrationEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<QualityAuditQueryExecutionStatusResponse> GetQualityConversationsAuditsQueryTransactionIdAsync(string transactionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(transactionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/quality/conversations/audits/query/{Uri.EscapeDataString(transactionId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QualityAuditQueryExecutionStatusResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<QualityAuditQueryExecutionResultsResponse> GetQualityConversationsAuditsQueryTransactionIdResultsAsync(string transactionId, string cursor = null, int? pageSize = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(transactionId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (expand != null)
        {
            foreach (var expandItem in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(expandItem));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/conversations/audits/query/{Uri.EscapeDataString(transactionId)}/results", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QualityAuditQueryExecutionResultsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationEntityListing> GetQualityEvaluationsQueryAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> expand = null, string previousPage = null, string conversationId = null, string agentUserId = null, string agentTeamId = null, string evaluatorUserId = null, string assigneeUserId = null, string queueId = null, string startTime = null, string endTime = null, string formContextId = null, IEnumerable<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null, string sortOrder = null, bool? includeDeletedUsers = null, CancellationToken cancellationToken = default)
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
            foreach (var expandItem in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(expandItem));
            }
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        if (!string.IsNullOrEmpty(conversationId))
        {
            parameters.Add("conversationId", UriHelper.ParameterToString(conversationId));
        }

        if (!string.IsNullOrEmpty(agentUserId))
        {
            parameters.Add("agentUserId", UriHelper.ParameterToString(agentUserId));
        }

        if (!string.IsNullOrEmpty(agentTeamId))
        {
            parameters.Add("agentTeamId", UriHelper.ParameterToString(agentTeamId));
        }

        if (!string.IsNullOrEmpty(evaluatorUserId))
        {
            parameters.Add("evaluatorUserId", UriHelper.ParameterToString(evaluatorUserId));
        }

        if (!string.IsNullOrEmpty(assigneeUserId))
        {
            parameters.Add("assigneeUserId", UriHelper.ParameterToString(assigneeUserId));
        }

        if (!string.IsNullOrEmpty(queueId))
        {
            parameters.Add("queueId", UriHelper.ParameterToString(queueId));
        }

        if (!string.IsNullOrEmpty(startTime))
        {
            parameters.Add("startTime", UriHelper.ParameterToString(startTime));
        }

        if (!string.IsNullOrEmpty(endTime))
        {
            parameters.Add("endTime", UriHelper.ParameterToString(endTime));
        }

        if (!string.IsNullOrEmpty(formContextId))
        {
            parameters.Add("formContextId", UriHelper.ParameterToString(formContextId));
        }

        if (evaluationState != null)
        {
            foreach (var state in evaluationState)
            {
                parameters.Add("evaluationState", UriHelper.ParameterToString(state));
            }
        }

        if (isReleased.HasValue)
        {
            parameters.Add("isReleased", UriHelper.ParameterToString(isReleased.Value));
        }

        if (agentHasRead.HasValue)
        {
            parameters.Add("agentHasRead", UriHelper.ParameterToString(agentHasRead.Value));
        }

        if (expandAnswerTotalScores.HasValue)
        {
            parameters.Add("expandAnswerTotalScores", UriHelper.ParameterToString(expandAnswerTotalScores.Value));
        }

        if (maximum.HasValue)
        {
            parameters.Add("maximum", UriHelper.ParameterToString(maximum.Value));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (includeDeletedUsers.HasValue)
        {
            parameters.Add("includeDeletedUsers", UriHelper.ParameterToString(includeDeletedUsers.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/evaluations/query", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> DeleteQualityFormAsync(string formId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/quality/forms/{formId}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteQualityFormsEvaluationAsync(string formId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/quality/forms/evaluations/{formId}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteQualityFormsSurveyAsync(string formId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/quality/forms/surveys/{formId}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    public async Task<AgentActivityEntityListing> GetQualityEvaluatorsActivityAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, IEnumerable<string> permission = null, string group = null, string agentTeamId = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (expand != null)
        {
            foreach (var expandItem in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(expandItem));
            }
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        if (startTime.HasValue)
        {
            parameters.Add("startTime", UriHelper.ParameterToString(startTime.Value));
        }

        if (endTime.HasValue)
        {
            parameters.Add("endTime", UriHelper.ParameterToString(endTime.Value));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (permission != null)
        {
            foreach (var permissionItem in permission)
            {
                parameters.Add("permission", UriHelper.ParameterToString(permissionItem));
            }
        }

        if (!string.IsNullOrEmpty(group))
        {
            parameters.Add("group", UriHelper.ParameterToString(group));
        }

        if (!string.IsNullOrEmpty(agentTeamId))
        {
            parameters.Add("agentTeamId", UriHelper.ParameterToString(agentTeamId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/evaluators/activity", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AgentActivityEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationForm> GetQualityFormAsync(string formId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/quality/forms/{formId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationForm>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationFormResponseEntityListing> GetQualityFormVersionsAsync(string formId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/forms/{formId}/versions", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationFormResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationFormResponseEntityListing> GetQualityFormsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/forms", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationFormResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationFormResponseEntityListing> GetQualityFormsEvaluationVersionsAsync(string formId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/forms/evaluations/{formId}/versions", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationFormResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationFormResponseEntityListing> GetQualityFormsEvaluationsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/forms/evaluations", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationFormResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SurveyForm> GetQualityFormsSurveyAsync(string formId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/quality/forms/surveys/{formId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SurveyForm>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SurveyFormEntityListing> GetQualityFormsSurveysAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/forms/surveys", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SurveyFormEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SurveyFormEntityListing> GetQualityFormsSurveysBulkAsync(IEnumerable<string> ids, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(ids);

        var parameters = new NameValueCollection();

        foreach (var id in ids)
        {
            parameters.Add("id", UriHelper.ParameterToString(id));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/forms/surveys/bulk", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SurveyFormEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SurveyFormEntityListing> GetQualityFormsSurveyVersionsAsync(string formId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/forms/surveys/{formId}/versions", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SurveyFormEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationForm> GetQualityPublishedformAsync(string formId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/quality/publishedforms/{formId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationForm>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationFormResponseEntityListing> GetQualityPublishedformsAsync(int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (onlyLatestPerContext.HasValue)
        {
            parameters.Add("onlyLatestPerContext", UriHelper.ParameterToString(onlyLatestPerContext.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/publishedforms", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationFormResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationFormResponse> GetQualityPublishedformsEvaluationAsync(string formId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/quality/publishedforms/evaluations/{formId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationFormResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationFormResponseEntityListing> GetQualityPublishedformsEvaluationsAsync(int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (onlyLatestPerContext.HasValue)
        {
            parameters.Add("onlyLatestPerContext", UriHelper.ParameterToString(onlyLatestPerContext.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/publishedforms/evaluations", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationFormResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SurveyForm> GetQualityPublishedformsSurveyAsync(string formId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/quality/publishedforms/surveys/{formId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SurveyForm>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SurveyFormEntityListing> GetQualityPublishedformsSurveysAsync(int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestEnabledPerContext = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (onlyLatestEnabledPerContext.HasValue)
        {
            parameters.Add("onlyLatestEnabledPerContext", UriHelper.ParameterToString(onlyLatestEnabledPerContext.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/publishedforms/surveys", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SurveyFormEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ScorableSurvey> GetQualitySurveysScorableAsync(string customerSurveyUrl, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(customerSurveyUrl);

        var parameters = new NameValueCollection();
        parameters.Add("customerSurveyUrl", UriHelper.ParameterToString(customerSurveyUrl));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/surveys/scorable", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScorableSurvey>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> CreateAnalyticsEvaluationsAggregatesJobAsync(EvaluationAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/analytics/evaluations/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationAggregateQueryResponse> CreateAnalyticsEvaluationsAggregatesQueryAsync(EvaluationAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/analytics/evaluations/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AsyncQueryStatus> CreateAnalyticsSurveysAggregatesJobAsync(SurveyAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/analytics/surveys/aggregates/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SurveyAggregateQueryResponse> CreateAnalyticsSurveysAggregatesQueryAsync(SurveyAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/analytics/surveys/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SurveyAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<QualityAuditQueryExecutionStatusResponse> CreateQualityConversationsAuditsQueryAsync(QMAuditQueryRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/quality/conversations/audits/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QualityAuditQueryExecutionStatusResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationAggregateQueryResponse> CreateQualityEvaluationsAggregatesQueryMeAsync(EvaluationAggregationQueryMe body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/quality/evaluations/aggregates/query/me", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationScoringSet> CreateQualityEvaluationsScoringAsync(EvaluationFormAndScoringSet body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/quality/evaluations/scoring", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationScoringSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationFormResponse> CreateQualityFormsAsync(EvaluationForm body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/quality/forms", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationFormResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SurveyForm> CreateQualityFormsSurveysAsync(SurveyForm body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/quality/forms/surveys", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SurveyForm>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationFormResponse> CreateQualityPublishedformsAsync(PublishForm body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/quality/publishedforms", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationFormResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationFormResponse> CreateQualityPublishedformsEvaluationsAsync(PublishForm body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/quality/publishedforms/evaluations", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationFormResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SurveyForm> CreateQualityPublishedformsSurveysAsync(PublishForm body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/quality/publishedforms/surveys", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SurveyForm>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SurveyScoringSet> CreateQualitySurveysScoringAsync(SurveyFormAndScoringSet body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/quality/surveys/scoring", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SurveyScoringSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Calibration> UpdateQualityCalibrationAsync(string calibrationId, Calibration body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(calibrationId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/quality/calibrations/{calibrationId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Calibration>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationResponse> UpdateQualityConversationEvaluationAsync(string conversationId, string evaluationId, Evaluation body, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(evaluationId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}", parameters);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EvaluationFormResponse> UpdateQualityFormAsync(string formId, EvaluationForm body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/quality/forms/{formId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EvaluationFormResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AiScoringSettings> UpdateQualityFormsEvaluationAiscoringSettingsAsync(string formId, AiScoringSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(formId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/quality/forms/evaluations/{formId}/aiscoringsettings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AiScoringSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ScorableSurvey> UpdateQualitySurveysScorableAsync(string customerSurveyUrl, ScorableSurvey body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(customerSurveyUrl);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        parameters.Add("customerSurveyUrl", UriHelper.ParameterToString(customerSurveyUrl));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/quality/surveys/scorable", parameters);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScorableSurvey>(_options.JsonSerializerOptions, cancellationToken);
    }
}