using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

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
    public async Task<NluDomain> GetLanguageUnderstandingDomainAsync(string domainId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/domains/{domainId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomain>(_options.JsonSerializerOptions, cancellationToken);
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

        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/domains/{domainId}/feedback", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluFeedbackListing>(_options.JsonSerializerOptions, cancellationToken);
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

        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomainVersion>(_options.JsonSerializerOptions, cancellationToken);
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

        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/domains/{domainId}/versions", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomainVersionListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Miner> GetLanguageUnderstandingMinerAsync(string minerId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);

        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/miners/{minerId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Miner>(_options.JsonSerializerOptions, cancellationToken);
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
    public async Task<NluDomain> CreateLanguageUnderstandingDomainAsync(NluDomain body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/languageunderstanding/domains", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomain>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluFeedbackResponse> CreateLanguageUnderstandingDomainFeedbackAsync(string domainId, NluFeedbackRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/domains/{domainId}/feedback", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluFeedbackResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Miner> CreateLanguageUnderstandingMinerAsync(Miner body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/languageunderstanding/miners", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Miner>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NluDomain> UpdateLanguageUnderstandingDomainAsync(string domainId, NluDomain body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/domains/{domainId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<NluDomain>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteLanguageUnderstandingDomainAsync(string domainId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(domainId);

        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/domains/{domainId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task DeleteLanguageUnderstandingMinerAsync(string minerId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(minerId);

        var uri = UriHelper.GetUri($"/api/v2/languageunderstanding/miners/{minerId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}