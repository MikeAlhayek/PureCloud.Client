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
public sealed class LearningApi : ILearningApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public LearningApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteLearningAssignmentAsync(string assignmentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(assignmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/learning/assignments/{Uri.EscapeDataString(assignmentId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteLearningModuleAsync(string moduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(moduleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/learning/modules/{Uri.EscapeDataString(moduleId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<LearningAssignment> GetLearningAssignmentAsync(string assignmentId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(assignmentId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var item in expands)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/learning/assignments/{Uri.EscapeDataString(assignmentId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningAssignmentStep> GetLearningAssignmentStepAsync(string assignmentId, string stepId, string shareableContentObjectId = null, string defaultShareableContentObject = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(assignmentId);
        ArgumentException.ThrowIfNullOrEmpty(stepId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(shareableContentObjectId))
        {
            parameters.Add("shareableContentObjectId", shareableContentObjectId);
        }

        if (!string.IsNullOrEmpty(defaultShareableContentObject))
        {
            parameters.Add("defaultShareableContentObject", defaultShareableContentObject);
        }

        if (expands != null)
        {
            foreach (var item in expands)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/learning/assignments/{Uri.EscapeDataString(assignmentId)}/steps/{Uri.EscapeDataString(stepId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignmentStep>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningAssignmentsDomainEntity> GetLearningAssignmentsAsync(string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string pass = null, float? minPercentageScore = null, float? maxPercentageScore = null, string sortOrder = null, string sortBy = null, IEnumerable<string> userId = null, IEnumerable<string> types = null, IEnumerable<string> states = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(moduleId))
        {
            parameters.Add("moduleId", moduleId);
        }

        if (!string.IsNullOrEmpty(interval))
        {
            parameters.Add("interval", interval);
        }

        if (!string.IsNullOrEmpty(completionInterval))
        {
            parameters.Add("completionInterval", completionInterval);
        }

        if (!string.IsNullOrEmpty(overdue))
        {
            parameters.Add("overdue", overdue);
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(pass))
        {
            parameters.Add("pass", pass);
        }

        if (minPercentageScore.HasValue)
        {
            parameters.Add("minPercentageScore", minPercentageScore.Value.ToString());
        }

        if (maxPercentageScore.HasValue)
        {
            parameters.Add("maxPercentageScore", maxPercentageScore.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (userId != null)
        {
            foreach (var id in userId)
            {
                parameters.Add("userId", UriHelper.ParameterToString(id));
            }
        }

        if (types != null)
        {
            foreach (var type in types)
            {
                parameters.Add("types", UriHelper.ParameterToString(type));
            }
        }

        if (states != null)
        {
            foreach (var state in states)
            {
                parameters.Add("states", UriHelper.ParameterToString(state));
            }
        }

        if (expands != null)
        {
            foreach (var item in expands)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/learning/assignments", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignmentsDomainEntity>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningAssignmentsDomainEntity> GetLearningAssignmentsMeAsync(string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string pass = null, float? minPercentageScore = null, float? maxPercentageScore = null, string sortOrder = null, string sortBy = null, IEnumerable<string> types = null, IEnumerable<string> states = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(moduleId))
        {
            parameters.Add("moduleId", moduleId);
        }

        if (!string.IsNullOrEmpty(interval))
        {
            parameters.Add("interval", interval);
        }

        if (!string.IsNullOrEmpty(completionInterval))
        {
            parameters.Add("completionInterval", completionInterval);
        }

        if (!string.IsNullOrEmpty(overdue))
        {
            parameters.Add("overdue", overdue);
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(pass))
        {
            parameters.Add("pass", pass);
        }

        if (minPercentageScore.HasValue)
        {
            parameters.Add("minPercentageScore", minPercentageScore.Value.ToString());
        }

        if (maxPercentageScore.HasValue)
        {
            parameters.Add("maxPercentageScore", maxPercentageScore.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (types != null)
        {
            foreach (var type in types)
            {
                parameters.Add("types", UriHelper.ParameterToString(type));
            }
        }

        if (states != null)
        {
            foreach (var state in states)
            {
                parameters.Add("states", UriHelper.ParameterToString(state));
            }
        }

        if (expands != null)
        {
            foreach (var item in expands)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/learning/assignments/me", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignmentsDomainEntity>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningModule> GetLearningModuleAsync(string moduleId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(moduleId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var item in expands)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/learning/modules/{Uri.EscapeDataString(moduleId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModule>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningModuleJobResponse> GetLearningModuleJobAsync(string moduleId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(moduleId);
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/learning/modules/{Uri.EscapeDataString(moduleId)}/jobs/{Uri.EscapeDataString(jobId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModuleJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningModulePreviewGetResponse> GetLearningModulePreviewAsync(string moduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(moduleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/learning/modules/{Uri.EscapeDataString(moduleId)}/preview", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModulePreviewGetResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningModuleRule> GetLearningModuleRuleAsync(string moduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(moduleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/learning/modules/{Uri.EscapeDataString(moduleId)}/rule", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModuleRule>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningModule> GetLearningModuleVersionAsync(string moduleId, string versionId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(moduleId);
        ArgumentException.ThrowIfNullOrEmpty(versionId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var item in expands)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/learning/modules/{Uri.EscapeDataString(moduleId)}/versions/{Uri.EscapeDataString(versionId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModule>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningModulesDomainEntityListing> GetLearningModulesAsync(bool? isArchived = null, IEnumerable<string> types = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string searchTerm = null, IEnumerable<string> expands = null, string isPublished = null, IEnumerable<string> statuses = null, IEnumerable<string> externalIds = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (isArchived.HasValue)
        {
            parameters.Add("isArchived", isArchived.Value.ToString().ToLower());
        }

        if (types != null)
        {
            foreach (var type in types)
            {
                parameters.Add("types", UriHelper.ParameterToString(type));
            }
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(searchTerm))
        {
            parameters.Add("searchTerm", searchTerm);
        }

        if (expands != null)
        {
            foreach (var item in expands)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(isPublished))
        {
            parameters.Add("isPublished", isPublished);
        }

        if (statuses != null)
        {
            foreach (var status in statuses)
            {
                parameters.Add("statuses", UriHelper.ParameterToString(status));
            }
        }

        if (externalIds != null)
        {
            foreach (var externalId in externalIds)
            {
                parameters.Add("externalIds", UriHelper.ParameterToString(externalId));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/learning/modules", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModulesDomainEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AssignedLearningModuleDomainEntityListing> GetLearningModulesAssignmentsAsync(IEnumerable<string> userIds, int? pageSize = null, int? pageNumber = null, string searchTerm = null, string overdue = null, IEnumerable<string> assignmentStates = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(userIds);

        var parameters = new NameValueCollection();

        foreach (var userId in userIds)
        {
            parameters.Add("userIds", UriHelper.ParameterToString(userId));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (!string.IsNullOrEmpty(searchTerm))
        {
            parameters.Add("searchTerm", searchTerm);
        }

        if (!string.IsNullOrEmpty(overdue))
        {
            parameters.Add("overdue", overdue);
        }

        if (assignmentStates != null)
        {
            foreach (var state in assignmentStates)
            {
                parameters.Add("assignmentStates", UriHelper.ParameterToString(state));
            }
        }

        if (expands != null)
        {
            foreach (var item in expands)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/learning/modules/assignments", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AssignedLearningModuleDomainEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningModuleCoverArtResponse> GetLearningModulesCoverartCoverArtIdAsync(string coverArtId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(coverArtId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/learning/modules/coverart/{Uri.EscapeDataString(coverArtId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModuleCoverArtResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningScormResponse> GetLearningScormScormIdAsync(string scormId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(scormId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/learning/scorm/{Uri.EscapeDataString(scormId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningScormResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningAssignment> UpdateLearningAssignmentAsync(string assignmentId, LearningAssignmentUpdate body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(assignmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/learning/assignments/{Uri.EscapeDataString(assignmentId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningAssignment> UpdateLearningAssignmentRescheduleAsync(string assignmentId, LearningAssignmentReschedule body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(assignmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/learning/assignments/{Uri.EscapeDataString(assignmentId)}/reschedule", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningAssignmentStep> UpdateLearningAssignmentStepAsync(string assignmentId, string stepId, LearningAssignmentStep body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(assignmentId);
        ArgumentException.ThrowIfNullOrEmpty(stepId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/learning/assignments/{Uri.EscapeDataString(assignmentId)}/steps/{Uri.EscapeDataString(stepId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignmentStep>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningAssignment> UpdateLearningModuleUserAssignmentsAsync(string moduleId, string userId, LearningAssignmentExternalUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(moduleId);
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/learning/modules/{Uri.EscapeDataString(moduleId)}/users/{Uri.EscapeDataString(userId)}/assignments", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AssessmentScoringSet> CreateLearningAssessmentsScoringAsync(LearningAssessmentScoringRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/learning/assessments/scoring", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AssessmentScoringSet>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningAssignment> CreateLearningAssignmentReassignAsync(string assignmentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(assignmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/learning/assignments/{Uri.EscapeDataString(assignmentId)}/reassign", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningAssignment> CreateLearningAssignmentResetAsync(string assignmentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(assignmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsync($"api/v2/learning/assignments/{Uri.EscapeDataString(assignmentId)}/reset", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningAssignment> CreateLearningAssignmentAsync(LearningAssignmentCreate body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/learning/assignments", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningAssignmentAggregateResponse> CreateLearningAssignmentsAggregatesQueryAsync(LearningAssignmentAggregateParam body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/learning/assignments/aggregates/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignmentAggregateResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningAssignmentBulkAddResponse> CreateLearningAssignmentsBulkaddAsync(IEnumerable<LearningAssignmentItem> body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/learning/assignments/bulkadd", body?.ToArray(), _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignmentBulkAddResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningAssignmentBulkRemoveResponse> CreateLearningAssignmentsBulkremoveAsync(IEnumerable<string> body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/learning/assignments/bulkremove", body?.ToArray(), _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignmentBulkRemoveResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningModuleJobResponse> CreateLearningModuleJobsAsync(string moduleId, LearningModuleJobRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(moduleId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/learning/modules/{Uri.EscapeDataString(moduleId)}/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModuleJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningModulePublishResponse> CreateLearningModulePublishAsync(string moduleId, LearningModulePublishRequest body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(moduleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/learning/modules/{Uri.EscapeDataString(moduleId)}/publish", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModulePublishResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningModule> CreateLearningModuleAsync(LearningModuleRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/learning/modules", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModule>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningAssignmentUserListing> CreateLearningRulesQueryAsync(int? pageSize, int? pageNumber, LearningAssignmentUserQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/learning/rules/query", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignmentUserListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningScheduleSlotsQueryResponse> CreateLearningScheduleslotsQueryAsync(LearningScheduleSlotsQueryRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/learning/scheduleslots/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningScheduleSlotsQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningScormUploadResponse> CreateLearningScormAsync(LearningScormUploadRequest body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/learning/scorm", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningScormUploadResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningModule> UpdateLearningModuleAsync(string moduleId, LearningModuleRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(moduleId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/learning/modules/{Uri.EscapeDataString(moduleId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModule>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningModulePreviewUpdateResponse> UpdateLearningModulePreviewAsync(string moduleId, LearningModulePreviewUpdateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(moduleId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/learning/modules/{Uri.EscapeDataString(moduleId)}/preview", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModulePreviewUpdateResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LearningModuleRule> UpdateLearningModuleRuleAsync(string moduleId, LearningModuleRule body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(moduleId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/learning/modules/{Uri.EscapeDataString(moduleId)}/rule", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModuleRule>(_options.JsonSerializerOptions, cancellationToken);
    }
}
