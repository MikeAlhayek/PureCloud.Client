using System.Collections.Specialized;
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
}