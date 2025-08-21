using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class SpeechTextAnalyticsApi : ISpeechTextAnalyticsApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public SpeechTextAnalyticsApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteSpeechTextAnalyticsCategoryAsync(string categoryId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(categoryId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/speechandtextanalytics/categories/{Uri.EscapeDataString(categoryId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteSpeechTextAnalyticsDictionaryFeedbackAsync(string dictionaryFeedbackId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dictionaryFeedbackId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/speechandtextanalytics/dictionaryfeedback/{Uri.EscapeDataString(dictionaryFeedbackId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<DeleteProgramResponse> DeleteSpeechTextAnalyticsProgramAsync(string programId, bool? forceDelete = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(programId);

        var parameters = new NameValueCollection();

        if (forceDelete.HasValue)
        {
            parameters.Add("forceDelete", UriHelper.ParameterToString(forceDelete.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/speechandtextanalytics/programs/{Uri.EscapeDataString(programId)}", parameters);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DeleteProgramResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteSpeechTextAnalyticsSentimentFeedbackAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/speechandtextanalytics/sentimentfeedback", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteSpeechTextAnalyticsSentimentFeedbackByIdAsync(string sentimentFeedbackId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sentimentFeedbackId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/speechandtextanalytics/sentimentfeedback/{Uri.EscapeDataString(sentimentFeedbackId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteSpeechTextAnalyticsTopicAsync(string topicId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/speechandtextanalytics/topics/{Uri.EscapeDataString(topicId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<CategoriesEntityListing> GetSpeechTextAnalyticsCategoriesAsync(int? pageSize = null, int? pageNumber = null, string name = null, string sortOrder = null, string sortBy = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("ids", UriHelper.ParameterToString(id));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/speechandtextanalytics/categories", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CategoriesEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<StaCategory> GetSpeechTextAnalyticsCategoryAsync(string categoryId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(categoryId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/speechandtextanalytics/categories/{Uri.EscapeDataString(categoryId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<StaCategory>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ConversationMetrics> GetSpeechTextAnalyticsConversationAsync(string conversationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/speechandtextanalytics/conversations/{Uri.EscapeDataString(conversationId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ConversationMetrics>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ConversationCategoriesEntityListing> GetSpeechTextAnalyticsConversationCategoriesAsync(string conversationId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

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

        var uri = UriHelper.GetUri($"api/v2/speechandtextanalytics/conversations/{Uri.EscapeDataString(conversationId)}/categories", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ConversationCategoriesEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TranscriptUrl> GetSpeechTextAnalyticsConversationCommunicationTranscriptUrlAsync(string conversationId, string communicationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(communicationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/speechandtextanalytics/conversations/{Uri.EscapeDataString(conversationId)}/communications/{Uri.EscapeDataString(communicationId)}/transcripturl", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TranscriptUrl>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TranscriptUrls> GetSpeechTextAnalyticsConversationCommunicationTranscriptUrlsAsync(string conversationId, string communicationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);
        ArgumentException.ThrowIfNullOrEmpty(communicationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/speechandtextanalytics/conversations/{Uri.EscapeDataString(conversationId)}/communications/{Uri.EscapeDataString(communicationId)}/transcripturls", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TranscriptUrls>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SpeechTextAnalyticsConversationSummaryListing> GetSpeechTextAnalyticsConversationSummariesAsync(string conversationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/speechandtextanalytics/conversations/{Uri.EscapeDataString(conversationId)}/summaries", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SpeechTextAnalyticsConversationSummaryListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DictionaryFeedbackEntityListing> GetSpeechTextAnalyticsDictionaryFeedbackAsync(string dialect = null, string nextPage = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(dialect))
        {
            parameters.Add("dialect", UriHelper.ParameterToString(dialect));
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/speechandtextanalytics/dictionaryfeedback", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DictionaryFeedbackEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DictionaryFeedback> GetSpeechTextAnalyticsDictionaryFeedbackByIdAsync(string dictionaryFeedbackId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dictionaryFeedbackId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/speechandtextanalytics/dictionaryfeedback/{Uri.EscapeDataString(dictionaryFeedbackId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DictionaryFeedback>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Program> GetSpeechTextAnalyticsProgramAsync(string programId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(programId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/speechandtextanalytics/programs/{Uri.EscapeDataString(programId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Program>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ProgramMappings> GetSpeechTextAnalyticsProgramMappingsAsync(string programId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(programId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/speechandtextanalytics/programs/{Uri.EscapeDataString(programId)}/mappings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ProgramMappings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ProgramInsightsSettings> GetSpeechTextAnalyticsProgramSettingsInsightsAsync(string programId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(programId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/speechandtextanalytics/programs/{Uri.EscapeDataString(programId)}/settings/insights", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ProgramInsightsSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ProgramTranscriptionEngines> GetSpeechTextAnalyticsProgramTranscriptionEnginesAsync(string programId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(programId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/speechandtextanalytics/programs/{Uri.EscapeDataString(programId)}/transcriptionengines", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ProgramTranscriptionEngines>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ProgramsEntityListing> GetSpeechTextAnalyticsProgramsAsync(string nextPage = null, int? pageSize = null, string state = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(state))
        {
            parameters.Add("state", UriHelper.ParameterToString(state));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/speechandtextanalytics/programs", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ProgramsEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GeneralProgramJob> GetSpeechTextAnalyticsProgramsGeneralJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/speechandtextanalytics/programs/general/jobs/{Uri.EscapeDataString(jobId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GeneralProgramJob>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ProgramsMappingsEntityListing> GetSpeechTextAnalyticsProgramsMappingsAsync(string nextPage = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/speechandtextanalytics/programs/mappings", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ProgramsMappingsEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ProgramJob> GetSpeechTextAnalyticsProgramsPublishJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/speechandtextanalytics/programs/publishjobs/{Uri.EscapeDataString(jobId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ProgramJob>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ProgramInsightsSettingsEntityListing> GetSpeechTextAnalyticsProgramsSettingsInsightsAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> programIds = null, CancellationToken cancellationToken = default)
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

        if (programIds != null)
        {
            foreach (var programId in programIds)
            {
                parameters.Add("programIds", UriHelper.ParameterToString(programId));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/speechandtextanalytics/programs/settings/insights", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ProgramInsightsSettingsEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SupportedDialectsEntityListing> GetSpeechTextAnalyticsProgramsTranscriptionEnginesDialectsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/speechandtextanalytics/programs/transcriptionengines/dialects", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SupportedDialectsEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UnpublishedProgramsEntityListing> GetSpeechTextAnalyticsProgramsUnpublishedAsync(string nextPage = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/speechandtextanalytics/programs/unpublished", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UnpublishedProgramsEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EntityListing> GetSpeechTextAnalyticsSentimentDialectsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/speechandtextanalytics/sentiment/dialects", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SentimentFeedbackEntityListing> GetSpeechTextAnalyticsSentimentFeedbackAsync(string dialect = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(dialect))
        {
            parameters.Add("dialect", UriHelper.ParameterToString(dialect));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/speechandtextanalytics/sentimentfeedback", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SentimentFeedbackEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SpeechTextAnalyticsSettingsResponse> GetSpeechTextAnalyticsSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/speechandtextanalytics/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SpeechTextAnalyticsSettingsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Topic> GetSpeechTextAnalyticsTopicAsync(string topicId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/speechandtextanalytics/topics/{Uri.EscapeDataString(topicId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Topic>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TopicsEntityListing> GetSpeechTextAnalyticsTopicsAsync(string nextPage = null, int? pageSize = null, string state = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> dialects = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(state))
        {
            parameters.Add("state", UriHelper.ParameterToString(state));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("ids", UriHelper.ParameterToString(id));
            }
        }

        if (dialects != null)
        {
            foreach (var dialect in dialects)
            {
                parameters.Add("dialects", UriHelper.ParameterToString(dialect));
            }
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/speechandtextanalytics/topics", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TopicsEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EntityListing> GetSpeechTextAnalyticsTopicsDialectsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/speechandtextanalytics/topics/dialects", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GeneralTopicsEntityListing> GetSpeechTextAnalyticsTopicsGeneralAsync(string dialect = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(dialect))
        {
            parameters.Add("dialect", UriHelper.ParameterToString(dialect));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/speechandtextanalytics/topics/general", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GeneralTopicsEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UnifiedGeneralTopicEntityListing> GetSpeechTextAnalyticsTopicsGeneralStatusAsync(string dialect = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(dialect))
        {
            parameters.Add("dialect", UriHelper.ParameterToString(dialect));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/speechandtextanalytics/topics/general/status", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UnifiedGeneralTopicEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TopicJob> GetSpeechTextAnalyticsTopicsPublishJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/speechandtextanalytics/topics/publishjobs/{Uri.EscapeDataString(jobId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TopicJob>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CommunicationTranslationList> GetSpeechTextAnalyticsTranslationsLanguageConversationAsync(string languageId, string conversationId, string communicationId = null, string recordingId = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(languageId);
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(communicationId))
        {
            parameters.Add("communicationId", UriHelper.ParameterToString(communicationId));
        }

        if (!string.IsNullOrEmpty(recordingId))
        {
            parameters.Add("recordingId", UriHelper.ParameterToString(recordingId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/speechandtextanalytics/translations/{Uri.EscapeDataString(languageId)}/conversations/{Uri.EscapeDataString(conversationId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CommunicationTranslationList>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TranslateSupportedLanguageList> GetSpeechTextAnalyticsTranslationsLanguagesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/speechandtextanalytics/translations/languages", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TranslateSupportedLanguageList>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SpeechTextAnalyticsSettingsResponse> UpdateSpeechTextAnalyticsSettingsAsync(SpeechTextAnalyticsSettingsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync("api/v2/speechandtextanalytics/settings", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SpeechTextAnalyticsSettingsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<StaCategory> CreateSpeechTextAnalyticsCategoryAsync(CategoryRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/speechandtextanalytics/categories", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<StaCategory>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DictionaryFeedback> CreateSpeechTextAnalyticsDictionaryFeedbackAsync(DictionaryFeedback body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/speechandtextanalytics/dictionaryfeedback", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DictionaryFeedback>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Program> CreateSpeechTextAnalyticsProgramAsync(ProgramRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/speechandtextanalytics/programs", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Program>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GeneralProgramJob> CreateSpeechTextAnalyticsProgramsGeneralJobAsync(GeneralProgramJobRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/speechandtextanalytics/programs/general/jobs", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GeneralProgramJob>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ProgramJob> CreateSpeechTextAnalyticsProgramsPublishJobAsync(ProgramJobRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/speechandtextanalytics/programs/publishjobs", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ProgramJob>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SentimentFeedback> CreateSpeechTextAnalyticsSentimentFeedbackAsync(SentimentFeedback body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/speechandtextanalytics/sentimentfeedback", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SentimentFeedback>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Topic> CreateSpeechTextAnalyticsTopicAsync(TopicRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/speechandtextanalytics/topics", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Topic>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TopicJob> CreateSpeechTextAnalyticsTopicsPublishJobAsync(TopicJobRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/speechandtextanalytics/topics/publishjobs", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TopicJob>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<JsonSearchResponse> CreateSpeechTextAnalyticsTranscriptsSearchAsync(TranscriptSearchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/speechandtextanalytics/transcripts/search", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JsonSearchResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<StaCategory> UpdateSpeechTextAnalyticsCategoryAsync(string categoryId, CategoryRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(categoryId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/speechandtextanalytics/categories/{Uri.EscapeDataString(categoryId)}", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<StaCategory>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DictionaryFeedback> UpdateSpeechTextAnalyticsDictionaryFeedbackAsync(string dictionaryFeedbackId, DictionaryFeedback body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(dictionaryFeedbackId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/speechandtextanalytics/dictionaryfeedback/{Uri.EscapeDataString(dictionaryFeedbackId)}", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DictionaryFeedback>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Program> UpdateSpeechTextAnalyticsProgramAsync(string programId, ProgramRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(programId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/speechandtextanalytics/programs/{Uri.EscapeDataString(programId)}", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Program>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ProgramMappings> UpdateSpeechTextAnalyticsProgramMappingsAsync(string programId, ProgramMappingsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(programId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/speechandtextanalytics/programs/{Uri.EscapeDataString(programId)}/mappings", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ProgramMappings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ProgramInsightsSettings> UpdateSpeechTextAnalyticsProgramSettingsInsightsAsync(string programId, InsightsSettingsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(programId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/speechandtextanalytics/programs/{Uri.EscapeDataString(programId)}/settings/insights", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ProgramInsightsSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ProgramTranscriptionEngines> UpdateSpeechTextAnalyticsProgramTranscriptionEnginesAsync(string programId, TranscriptionEnginesRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(programId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/speechandtextanalytics/programs/{Uri.EscapeDataString(programId)}/transcriptionengines", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ProgramTranscriptionEngines>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SpeechTextAnalyticsSettingsResponse> UpdateSpeechTextAnalyticsSettingsFullAsync(SpeechTextAnalyticsSettingsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/speechandtextanalytics/settings", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SpeechTextAnalyticsSettingsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Topic> UpdateSpeechTextAnalyticsTopicAsync(string topicId, TopicRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/speechandtextanalytics/topics/{Uri.EscapeDataString(topicId)}", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Topic>(_options, cancellationToken);
    }
}
