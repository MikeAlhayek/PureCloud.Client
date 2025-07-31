using System.Collections.Specialized;
using System.Linq;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public sealed class RecordingApi : IRecordingApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public RecordingApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<Recording> GetConversationRecordingAsync(string conversationId, string recordingId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, IEnumerable<string> mediaFormats = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(recordingId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(formatId))
        {
            parameters.Add("formatId", UriHelper.ParameterToString(formatId));
        }

        if (!string.IsNullOrEmpty(emailFormatId))
        {
            parameters.Add("emailFormatId", UriHelper.ParameterToString(emailFormatId));
        }

        if (!string.IsNullOrEmpty(chatFormatId))
        {
            parameters.Add("chatFormatId", UriHelper.ParameterToString(chatFormatId));
        }

        if (!string.IsNullOrEmpty(messageFormatId))
        {
            parameters.Add("messageFormatId", UriHelper.ParameterToString(messageFormatId));
        }

        if (download.HasValue)
        {
            parameters.Add("download", UriHelper.ParameterToString(download.Value));
        }

        if (!string.IsNullOrEmpty(fileName))
        {
            parameters.Add("fileName", UriHelper.ParameterToString(fileName));
        }

        if (!string.IsNullOrEmpty(locale))
        {
            parameters.Add("locale", UriHelper.ParameterToString(locale));
        }

        if (mediaFormats != null)
        {
            foreach (var mediaFormat in mediaFormats)
            {
                parameters.Add("mediaFormats", UriHelper.ParameterToString(mediaFormat));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/conversations/{conversationId}/recordings/{recordingId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Recording>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<IEnumerable<Annotation>> GetConversationRecordingAnnotationsAsync(string conversationId, string recordingId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(recordingId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IEnumerable<Annotation>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task DeleteConversationRecordingAnnotationAsync(string conversationId, string recordingId, string annotationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(recordingId);
        ArgumentException.ThrowIfNullOrEmpty(annotationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<IEnumerable<Recording>> GetConversationRecordingsAsync(string conversationId, int? maxWaitMs = null, string formatId = null, IEnumerable<string> mediaFormats = null, string locale = null, bool? includePauseAnnotationsForScreenRecordings = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

        var parameters = new NameValueCollection();

        if (maxWaitMs.HasValue)
        {
            parameters.Add("maxWaitMs", UriHelper.ParameterToString(maxWaitMs.Value));
        }

        if (!string.IsNullOrEmpty(formatId))
        {
            parameters.Add("formatId", UriHelper.ParameterToString(formatId));
        }

        if (mediaFormats != null)
        {
            foreach (var mediaFormat in mediaFormats)
            {
                parameters.Add("mediaFormats", UriHelper.ParameterToString(mediaFormat));
            }
        }

        if (!string.IsNullOrEmpty(locale))
        {
            parameters.Add("locale", UriHelper.ParameterToString(locale));
        }

        if (includePauseAnnotationsForScreenRecordings.HasValue)
        {
            parameters.Add("includePauseAnnotationsForScreenRecordings", UriHelper.ParameterToString(includePauseAnnotationsForScreenRecordings.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/conversations/{conversationId}/recordings", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IEnumerable<Recording>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<OrphanRecordingListing> GetOrphanrecordingsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null, string media = null, CancellationToken cancellationToken = default)
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

        if (hasConversation.HasValue)
        {
            parameters.Add("hasConversation", UriHelper.ParameterToString(hasConversation.Value));
        }

        if (!string.IsNullOrEmpty(media))
        {
            parameters.Add("media", UriHelper.ParameterToString(media));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/orphanrecordings", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrphanRecordingListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<OrphanRecording> DeleteOrphanrecordingAsync(string orphanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(orphanId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/orphanrecordings/{orphanId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrphanRecording>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BatchDownloadJobStatusResult> GetRecordingBatchrequestAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/recording/batchrequests/{jobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BatchDownloadJobStatusResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BatchDownloadJobSubmissionResult> CreateRecordingBatchrequestAsync(BatchDownloadJobSubmission body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/recording/batchrequests", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BatchDownloadJobSubmissionResult>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<Annotation> GetConversationRecordingAnnotationAsync(string conversationId, string recordingId, string annotationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(recordingId);
        ArgumentException.ThrowIfNullOrEmpty(annotationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/conversations/{Uri.EscapeDataString(conversationId)}/recordings/{Uri.EscapeDataString(recordingId)}/annotations/{Uri.EscapeDataString(annotationId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Annotation>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<Annotation> CreateConversationRecordingAnnotationAsync(string conversationId, string recordingId, Annotation body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(recordingId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/conversations/{Uri.EscapeDataString(conversationId)}/recordings/{Uri.EscapeDataString(recordingId)}/annotations", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Annotation>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<Annotation> UpdateConversationRecordingAnnotationAsync(string conversationId, string recordingId, string annotationId, Annotation body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(recordingId);
        ArgumentException.ThrowIfNullOrEmpty(annotationId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/conversations/{Uri.EscapeDataString(conversationId)}/recordings/{Uri.EscapeDataString(recordingId)}/annotations/{Uri.EscapeDataString(annotationId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Annotation>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<bool> DeleteRecordingCrossplatformMediaretentionpoliciesAsync(string ids, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(ids);

        var parameters = new NameValueCollection();
        parameters.Add("ids", UriHelper.ParameterToString(ids));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/recording/crossplatform/mediaretentionpolicies", parameters);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc>
    public async Task<bool> DeleteRecordingCrossplatformMediaretentionpolicyAsync(string policyId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(policyId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/recording/crossplatform/mediaretentionpolicies/{Uri.EscapeDataString(policyId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc>
    public async Task<bool> DeleteRecordingJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/recording/jobs/{Uri.EscapeDataString(jobId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc>
    public async Task<bool> DeleteRecordingMediaretentionpoliciesAsync(string ids, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(ids);

        var parameters = new NameValueCollection();
        parameters.Add("ids", UriHelper.ParameterToString(ids));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/recording/mediaretentionpolicies", parameters);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc>
    public async Task<bool> DeleteRecordingMediaretentionpolicyAsync(string policyId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(policyId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/recording/mediaretentionpolicies/{Uri.EscapeDataString(policyId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc>
    public async Task<OrphanRecording> GetOrphanrecordingAsync(string orphanId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(orphanId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/orphanrecordings/{Uri.EscapeDataString(orphanId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrphanRecording>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<Recording> GetOrphanrecordingMediaAsync(string orphanId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, IEnumerable<string> mediaFormats = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(orphanId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(formatId))
        {
            parameters.Add("formatId", UriHelper.ParameterToString(formatId));
        }

        if (!string.IsNullOrEmpty(emailFormatId))
        {
            parameters.Add("emailFormatId", UriHelper.ParameterToString(emailFormatId));
        }

        if (!string.IsNullOrEmpty(chatFormatId))
        {
            parameters.Add("chatFormatId", UriHelper.ParameterToString(chatFormatId));
        }

        if (!string.IsNullOrEmpty(messageFormatId))
        {
            parameters.Add("messageFormatId", UriHelper.ParameterToString(messageFormatId));
        }

        if (download.HasValue)
        {
            parameters.Add("download", UriHelper.ParameterToString(download.Value));
        }

        if (!string.IsNullOrEmpty(fileName))
        {
            parameters.Add("fileName", UriHelper.ParameterToString(fileName));
        }

        if (!string.IsNullOrEmpty(locale))
        {
            parameters.Add("locale", UriHelper.ParameterToString(locale));
        }

        if (mediaFormats != null)
        {
            foreach (var mediaFormat in mediaFormats)
            {
                parameters.Add("mediaFormats", UriHelper.ParameterToString(mediaFormat));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/orphanrecordings/{Uri.EscapeDataString(orphanId)}/media", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Recording>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<PolicyEntityListing> GetRecordingCrossplatformMediaretentionpoliciesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (enabled.HasValue)
        {
            parameters.Add("enabled", UriHelper.ParameterToString(enabled.Value));
        }

        if (summary.HasValue)
        {
            parameters.Add("summary", UriHelper.ParameterToString(summary.Value));
        }

        if (hasErrors.HasValue)
        {
            parameters.Add("hasErrors", UriHelper.ParameterToString(hasErrors.Value));
        }

        if (deleteDaysThreshold.HasValue)
        {
            parameters.Add("deleteDaysThreshold", UriHelper.ParameterToString(deleteDaysThreshold.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/recording/crossplatform/mediaretentionpolicies", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PolicyEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<CrossPlatformPolicy> GetRecordingCrossplatformMediaretentionpolicyAsync(string policyId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(policyId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/recording/crossplatform/mediaretentionpolicies/{Uri.EscapeDataString(policyId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CrossPlatformPolicy>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<RecordingJob> GetRecordingJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/recording/jobs/{Uri.EscapeDataString(jobId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecordingJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<FailedRecordingEntityListing> GetRecordingJobFailedrecordingsAsync(string jobId, int? pageSize = null, int? pageNumber = null, bool? includeTotal = null, string cursor = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (includeTotal.HasValue)
        {
            parameters.Add("includeTotal", UriHelper.ParameterToString(includeTotal.Value));
        }

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/recording/jobs/{Uri.EscapeDataString(jobId)}/failedrecordings", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FailedRecordingEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<RecordingJobEntityListing> GetRecordingJobsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string state = null, bool? showOnlyMyJobs = null, string jobType = null, bool? includeTotal = null, string cursor = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(state))
        {
            parameters.Add("state", UriHelper.ParameterToString(state));
        }

        if (showOnlyMyJobs.HasValue)
        {
            parameters.Add("showOnlyMyJobs", UriHelper.ParameterToString(showOnlyMyJobs.Value));
        }

        if (!string.IsNullOrEmpty(jobType))
        {
            parameters.Add("jobType", UriHelper.ParameterToString(jobType));
        }

        if (includeTotal.HasValue)
        {
            parameters.Add("includeTotal", UriHelper.ParameterToString(includeTotal.Value));
        }

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/recording/jobs", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecordingJobEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<RecordingEncryptionConfiguration> GetRecordingKeyconfigurationAsync(string keyConfigurationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(keyConfigurationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/recording/keyconfigurations/{Uri.EscapeDataString(keyConfigurationId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecordingEncryptionConfiguration>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<RecordingEncryptionConfigurationListing> GetRecordingKeyconfigurationsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/recording/keyconfigurations", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecordingEncryptionConfigurationListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<PolicyEntityListing> GetRecordingMediaretentionpoliciesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (enabled.HasValue)
        {
            parameters.Add("enabled", UriHelper.ParameterToString(enabled.Value));
        }

        if (summary.HasValue)
        {
            parameters.Add("summary", UriHelper.ParameterToString(summary.Value));
        }

        if (hasErrors.HasValue)
        {
            parameters.Add("hasErrors", UriHelper.ParameterToString(hasErrors.Value));
        }

        if (deleteDaysThreshold.HasValue)
        {
            parameters.Add("deleteDaysThreshold", UriHelper.ParameterToString(deleteDaysThreshold.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/recording/mediaretentionpolicies", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PolicyEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<Policy> GetRecordingMediaretentionpolicyAsync(string policyId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(policyId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/recording/mediaretentionpolicies/{Uri.EscapeDataString(policyId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Policy>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<EncryptionKeyEntityListing> GetRecordingRecordingkeysAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/recording/recordingkeys", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EncryptionKeyEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<KeyRotationSchedule> GetRecordingRecordingkeysRotationscheduleAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/recording/recordingkeys/rotationschedule", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KeyRotationSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<RecordingSettings> GetRecordingSettingsAsync(bool? createDefault = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (createDefault.HasValue)
        {
            parameters.Add("createDefault", UriHelper.ParameterToString(createDefault.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/recording/settings", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecordingSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<RecordingUploadReport> GetRecordingUploadsReportAsync(string reportId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(reportId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/recording/uploads/reports/{Uri.EscapeDataString(reportId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecordingUploadReport>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<RecordingRetentionCursorEntityListing> GetRecordingsRetentionQueryAsync(int? retentionThresholdDays, string cursor = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (retentionThresholdDays.HasValue)
        {
            parameters.Add("retentionThresholdDays", UriHelper.ParameterToString(retentionThresholdDays.Value));
        }

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/recordings/retention/query", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecordingRetentionCursorEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<ScreenRecordingActiveSessions> GetRecordingsScreensessionsDetailsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/recordings/screensessions/details", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScreenRecordingActiveSessions>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<CrossPlatformPolicy> UpdateRecordingCrossplatformMediaretentionpolicyAsync(string policyId, CrossPlatformPolicy body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(policyId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/recording/crossplatform/mediaretentionpolicies/{Uri.EscapeDataString(policyId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CrossPlatformPolicy>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<Policy> UpdateRecordingMediaretentionpolicyAsync(string policyId, Policy body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(policyId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/recording/mediaretentionpolicies/{Uri.EscapeDataString(policyId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Policy>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<CrossPlatformPolicy> CreateRecordingCrossplatformMediaretentionpolicyAsync(CrossPlatformPolicy body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/recording/crossplatform/mediaretentionpolicies", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CrossPlatformPolicy>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<RecordingJob> CreateRecordingJobAsync(RecordingJobsQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/recording/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecordingJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<RecordingEncryptionConfiguration> CreateRecordingKeyconfigurationAsync(RecordingEncryptionConfiguration body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/recording/keyconfigurations", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecordingEncryptionConfiguration>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<RecordingEncryptionConfiguration> ValidateRecordingKeyconfigurationAsync(RecordingEncryptionConfiguration body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/recording/keyconfigurations/validate", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecordingEncryptionConfiguration>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<EncryptionKey> CreateRecordingRecordingkeysAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/recording/recordingkeys", (object)null, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EncryptionKey>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<Policy> CreateRecordingMediaretentionpolicyAsync(Policy body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/recording/mediaretentionpolicies", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Policy>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<IEnumerable<RecordingMetadata>> GetConversationRecordingmetadataAsync(string conversationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/conversations/{Uri.EscapeDataString(conversationId)}/recordingmetadata", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IEnumerable<RecordingMetadata>>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<RecordingUploadReport> CreateRecordingUploadsReportAsync(RecordingUploadReportRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/recording/uploads/reports", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecordingUploadReport>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<IEnumerable<AddressableEntityRef>> CreateRecordingsDeletionprotectionAsync(string conversationIds, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationIds);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var body = new { conversationIds = conversationIds.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(id => id.Trim()).ToArray() };

        var response = await client.PostAsJsonAsync("api/v2/recordings/deletionprotection", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IEnumerable<AddressableEntityRef>>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<IEnumerable<AddressableEntityRef>> UpdateRecordingsDeletionprotectionAsync(bool? protect = null, string conversationIds = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (protect.HasValue)
        {
            parameters.Add("protect", UriHelper.ParameterToString(protect.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/recordings/deletionprotection", parameters);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IEnumerable<AddressableEntityRef>>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<Recording> UpdateConversationRecordingAsync(string conversationId, string recordingId, Recording body, bool? clearExport = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(recordingId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (clearExport.HasValue)
        {
            parameters.Add("clearExport", UriHelper.ParameterToString(clearExport.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/conversations/{Uri.EscapeDataString(conversationId)}/recordings/{Uri.EscapeDataString(recordingId)}", parameters);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Recording>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<CrossPlatformPolicy> ReplaceRecordingCrossplatformMediaretentionpolicyAsync(string policyId, CrossPlatformPolicy body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(policyId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/recording/crossplatform/mediaretentionpolicies/{Uri.EscapeDataString(policyId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CrossPlatformPolicy>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<RecordingJob> UpdateRecordingJobAsync(string jobId, ExecuteRecordingJobsQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/recording/jobs/{Uri.EscapeDataString(jobId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecordingJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<RecordingEncryptionConfiguration> ReplaceRecordingKeyconfigurationAsync(string keyConfigurationId, RecordingEncryptionConfiguration body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(keyConfigurationId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/recording/keyconfigurations/{Uri.EscapeDataString(keyConfigurationId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecordingEncryptionConfiguration>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<Policy> ReplaceRecordingMediaretentionpolicyAsync(string policyId, Policy body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(policyId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/recording/mediaretentionpolicies/{Uri.EscapeDataString(policyId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Policy>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<KeyRotationSchedule> UpdateRecordingRecordingkeysRotationscheduleAsync(KeyRotationSchedule body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/recording/recordingkeys/rotationschedule", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KeyRotationSchedule>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc>
    public async Task<RecordingSettings> UpdateRecordingSettingsAsync(RecordingSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/recording/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<RecordingSettings>(_options.JsonSerializerOptions, cancellationToken);
    }
}