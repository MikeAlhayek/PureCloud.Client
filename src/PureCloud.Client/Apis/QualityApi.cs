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
}