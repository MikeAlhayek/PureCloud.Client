using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;
using PureCloud.Client.Models.Organizations;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class LanguageUnderstandingApi : ILanguageUnderstandingApi
{
    private readonly HttpClient _httpClient;
    private readonly PureCloudJsonSerializerOptions _options;

    public LanguageUnderstandingApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteLanguageUnderstandingDomainAsync(string domainId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var response = await _httpClient.DeleteAsync($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}", cancellationToken);
        
        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteLanguageUnderstandingDomainFeedbackAsync(string domainId, string feedbackId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentException.ThrowIfNullOrEmpty(feedbackId);

        var response = await _httpClient.DeleteAsync($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}/feedback/{Uri.EscapeDataString(feedbackId)}", cancellationToken);
        
        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteLanguageUnderstandingDomainVersionAsync(string domainId, string domainVersionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentException.ThrowIfNullOrEmpty(domainVersionId);

        var response = await _httpClient.DeleteAsync($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}/versions/{Uri.EscapeDataString(domainVersionId)}", cancellationToken);
        
        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteLanguageUnderstandingMinerAsync(string minerId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);

        var response = await _httpClient.DeleteAsync($"/api/v2/languageunderstanding/miners/{Uri.EscapeDataString(minerId)}", cancellationToken);
        
        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteLanguageUnderstandingMinerDraftAsync(string minerId, string draftId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);
        ArgumentException.ThrowIfNullOrEmpty(draftId);

        var response = await _httpClient.DeleteAsync($"/api/v2/languageunderstanding/miners/{Uri.EscapeDataString(minerId)}/drafts/{Uri.EscapeDataString(draftId)}", cancellationToken);
        
        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<NluDomain> GetLanguageUnderstandingDomainAsync(string domainId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var response = await _httpClient.GetAsync($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}", cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomain>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluFeedbackListing> GetLanguageUnderstandingDomainFeedbackAsync(string domainId, string intentName = null, string assessment = null, string dateStart = null, string dateEnd = null, bool? includeDeleted = null, string language = null, int? pageNumber = null, int? pageSize = null, bool? enableCursorPagination = null, bool? includeTrainingUtterances = null, string after = null, IEnumerable<string> fields = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var parameters = new NameValueCollection();
        if (!string.IsNullOrEmpty(intentName))
        {
            parameters.Add("intentName", UriHelper.ParameterToString(intentName));
        }


        if (!string.IsNullOrEmpty(assessment))
        {
            parameters.Add("assessment", UriHelper.ParameterToString(assessment));
        }


        if (!string.IsNullOrEmpty(dateStart))
        {
            parameters.Add("dateStart", UriHelper.ParameterToString(dateStart));
        }


        if (!string.IsNullOrEmpty(dateEnd))
        {
            parameters.Add("dateEnd", UriHelper.ParameterToString(dateEnd));
        }

        if (includeDeleted.HasValue)
        {
            parameters.Add("includeDeleted", UriHelper.ParameterToString(includeDeleted.Value));
        }

        if (!string.IsNullOrEmpty(language))
        {
            parameters.Add("language", UriHelper.ParameterToString(language));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (enableCursorPagination.HasValue)
        {
            parameters.Add("enableCursorPagination", UriHelper.ParameterToString(enableCursorPagination.Value));
        }

        if (includeTrainingUtterances.HasValue)
        {
            parameters.Add("includeTrainingUtterances", UriHelper.ParameterToString(includeTrainingUtterances.Value));
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (fields != null)
        {
            parameters.Add("fields", UriHelper.ParameterToString(fields));
        }


        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}/feedback", parameters);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluFeedbackListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluFeedbackResponse> GetLanguageUnderstandingDomainFeedbackByIdAsync(string domainId, string feedbackId, IEnumerable<string> fields = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentException.ThrowIfNullOrEmpty(feedbackId);

        var parameters = new NameValueCollection();
        if (fields != null)
        {
            parameters.Add("fields", UriHelper.ParameterToString(fields));
        }


        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}/feedback/{Uri.EscapeDataString(feedbackId)}", parameters);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluFeedbackResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluDomainVersion> GetLanguageUnderstandingDomainVersionAsync(string domainId, string domainVersionId, bool? includeUtterances = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentException.ThrowIfNullOrEmpty(domainVersionId);

        var parameters = new NameValueCollection();
        if (includeUtterances.HasValue)
        {
            parameters.Add("includeUtterances", UriHelper.ParameterToString(includeUtterances.Value));
        }


        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}/versions/{Uri.EscapeDataString(domainVersionId)}", parameters);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomainVersion>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluDomainVersionQualityReport> GetLanguageUnderstandingDomainVersionReportAsync(string domainId, string domainVersionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentException.ThrowIfNullOrEmpty(domainVersionId);

        var response = await _httpClient.GetAsync($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}/versions/{Uri.EscapeDataString(domainVersionId)}/report", cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomainVersionQualityReport>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluDomainVersionListing> GetLanguageUnderstandingDomainVersionsAsync(string domainId, bool? includeUtterances = null, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var parameters = new NameValueCollection();
        if (includeUtterances.HasValue)
        {
            parameters.Add("includeUtterances", UriHelper.ParameterToString(includeUtterances.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }


        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}/versions", parameters);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomainVersionListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluDomainListing> GetLanguageUnderstandingDomainsAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
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


        var uri = UriHelper.GetUri("/api/v2/languageunderstanding/domains", parameters);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomainListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Miner> GetLanguageUnderstandingMinerAsync(string minerId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);

        var response = await _httpClient.GetAsync($"/api/v2/languageunderstanding/miners/{Uri.EscapeDataString(minerId)}", cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Miner>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Draft> GetLanguageUnderstandingMinerDraftAsync(string minerId, string draftId, string draftIntentId = null, string draftTopicId = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);
        ArgumentException.ThrowIfNullOrEmpty(draftId);

        var parameters = new NameValueCollection();
        if (!string.IsNullOrEmpty(draftIntentId))
        {
            parameters.Add("draftIntentId", UriHelper.ParameterToString(draftIntentId));
        }

        if (!string.IsNullOrEmpty(draftTopicId))
        {
            parameters.Add("draftTopicId", UriHelper.ParameterToString(draftTopicId));
        }


        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/miners/{Uri.EscapeDataString(minerId)}/drafts/{Uri.EscapeDataString(draftId)}", parameters);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Draft>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DraftListing> GetLanguageUnderstandingMinerDraftsAsync(string minerId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);

        var response = await _httpClient.GetAsync($"/api/v2/languageunderstanding/miners/{Uri.EscapeDataString(minerId)}/drafts", cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DraftListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<MinerIntent> GetLanguageUnderstandingMinerIntentAsync(string minerId, string intentId, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);
        ArgumentException.ThrowIfNullOrEmpty(intentId);

        var parameters = new NameValueCollection();
        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }


        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/miners/{Uri.EscapeDataString(minerId)}/intents/{Uri.EscapeDataString(intentId)}", parameters);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MinerIntent>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<MinedIntentsListing> GetLanguageUnderstandingMinerIntentsAsync(string minerId, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);

        var parameters = new NameValueCollection();
        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }


        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/miners/{Uri.EscapeDataString(minerId)}/intents", parameters);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MinedIntentsListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<MinerTopic> GetLanguageUnderstandingMinerTopicAsync(string minerId, string topicId, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);
        ArgumentException.ThrowIfNullOrEmpty(topicId);

        var parameters = new NameValueCollection();
        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }


        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/miners/{Uri.EscapeDataString(minerId)}/topics/{Uri.EscapeDataString(topicId)}", parameters);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MinerTopic>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<MinerTopicPhrase> GetLanguageUnderstandingMinerTopicPhraseAsync(string minerId, string topicId, string phraseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);
        ArgumentException.ThrowIfNullOrEmpty(topicId);
        ArgumentException.ThrowIfNullOrEmpty(phraseId);

        var response = await _httpClient.GetAsync($"/api/v2/languageunderstanding/miners/{Uri.EscapeDataString(minerId)}/topics/{Uri.EscapeDataString(topicId)}/phrases/{Uri.EscapeDataString(phraseId)}", cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MinerTopicPhrase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<MinerTopicsListing> GetLanguageUnderstandingMinerTopicsAsync(string minerId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);

        var response = await _httpClient.GetAsync($"/api/v2/languageunderstanding/miners/{Uri.EscapeDataString(minerId)}/topics", cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MinerTopicsListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<MinerListing> GetLanguageUnderstandingMinersAsync(string minerType = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();
        if (!string.IsNullOrEmpty(minerType))
        {
            parameters.Add("minerType", UriHelper.ParameterToString(minerType));
        }


        var uri = UriHelper.GetUri("/api/v2/languageunderstanding/miners", parameters);
        var response = await _httpClient.GetAsync(uri, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<MinerListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluOrganization> GetLanguageUnderstandingSettingsAsync(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("/api/v2/languageunderstanding/settings", cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluOrganization>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluDomain> UpdateLanguageUnderstandingDomainAsync(string domainId, NluDomain body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PatchAsJsonAsync($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}", body, _options.JsonSerializerOptions, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomain>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Draft> UpdateLanguageUnderstandingMinerDraftAsync(string minerId, string draftId, DraftRequest body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);
        ArgumentException.ThrowIfNullOrEmpty(draftId);

        var response = await _httpClient.PatchAsJsonAsync($"/api/v2/languageunderstanding/miners/{Uri.EscapeDataString(minerId)}/drafts/{Uri.EscapeDataString(draftId)}", body, _options.JsonSerializerOptions, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Draft>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluFeedbackResponse> CreateLanguageUnderstandingDomainFeedbackAsync(string domainId, NluFeedbackRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}/feedback", body, _options.JsonSerializerOptions, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluFeedbackResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluDetectionResponse> CreateLanguageUnderstandingDomainVersionDetectAsync(string domainId, string domainVersionId, NluDetectionRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentException.ThrowIfNullOrEmpty(domainVersionId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}/versions/{Uri.EscapeDataString(domainVersionId)}/detect", body, _options.JsonSerializerOptions, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDetectionResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluDomainVersion> CreateLanguageUnderstandingDomainVersionPublishAsync(string domainId, string domainVersionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentException.ThrowIfNullOrEmpty(domainVersionId);

        var response = await _httpClient.PostAsync($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}/versions/{Uri.EscapeDataString(domainVersionId)}/publish", null, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomainVersion>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluDomainVersionTrainingResponse> CreateLanguageUnderstandingDomainVersionTrainAsync(string domainId, string domainVersionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentException.ThrowIfNullOrEmpty(domainVersionId);

        var response = await _httpClient.PostAsync($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}/versions/{Uri.EscapeDataString(domainVersionId)}/train", null, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomainVersionTrainingResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluDomainVersion> CreateLanguageUnderstandingDomainVersionsAsync(string domainId, NluDomainVersion body, bool? includeUtterances = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();
        if (includeUtterances.HasValue)
        {
            parameters.Add("includeUtterances", UriHelper.ParameterToString(includeUtterances.Value));
        }


        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}/versions", parameters);
        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomainVersion>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluDomain> CreateLanguageUnderstandingDomainsAsync(NluDomain body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync("/api/v2/languageunderstanding/domains", body, _options.JsonSerializerOptions, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomain>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Draft> CreateLanguageUnderstandingMinerDraftsAsync(string minerId, Draft body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync($"/api/v2/languageunderstanding/miners/{Uri.EscapeDataString(minerId)}/drafts", body, _options.JsonSerializerOptions, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Draft>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Miner> CreateLanguageUnderstandingMinerExecuteAsync(string minerId, MinerExecuteRequest body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);

        var response = await _httpClient.PostAsJsonAsync($"/api/v2/languageunderstanding/miners/{Uri.EscapeDataString(minerId)}/execute", body, _options.JsonSerializerOptions, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Miner>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Miner> CreateLanguageUnderstandingMinersAsync(Miner body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync("/api/v2/languageunderstanding/miners", body, _options.JsonSerializerOptions, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Miner>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluDomainVersion> UpdateLanguageUnderstandingDomainVersionAsync(string domainId, string domainVersionId, NluDomainVersion body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentException.ThrowIfNullOrEmpty(domainVersionId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PutAsJsonAsync($"/api/v2/languageunderstanding/domains/{Uri.EscapeDataString(domainId)}/versions/{Uri.EscapeDataString(domainVersionId)}", body, _options.JsonSerializerOptions, cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomainVersion>(_options.JsonSerializerOptions, cancellationToken);
    }
}
