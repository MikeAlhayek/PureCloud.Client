using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class SocialMediaApi : ISocialMediaApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public SocialMediaApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<AsyncQueryStatus> GetAnalyticsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/analytics/aggregates/jobs/{Uri.EscapeDataString(jobId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AsyncQueryResponse> CreateAnalyticsAggregatesJobAsync(SocialMediaAsyncAggregationQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/socialmedia/analytics/aggregates/jobs", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AsyncQueryStatus> GetAnalyticsMessagesJobAsync(string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/analytics/messages/jobs/{Uri.EscapeDataString(jobId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SocialMediaAsyncDetailQueryResponse> GetAnalyticsMessagesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/analytics/messages/jobs/{Uri.EscapeDataString(jobId)}/results", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SocialMediaAsyncDetailQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AsyncQueryResponse> CreateAnalyticsMessagesJobAsync(SocialMediaAsyncDetailQuery body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/socialmedia/analytics/messages/jobs", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AsyncQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteEscalationRuleAsync(string escalationRuleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(escalationRuleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/socialmedia/escalationrules/{Uri.EscapeDataString(escalationRuleId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteMessageAsync(string messageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/socialmedia/messages/{Uri.EscapeDataString(messageId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTopicAsync(string topicId, bool? hardDelete = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);

        var parameters = new NameValueCollection();

        if (hardDelete.HasValue)
        {
            parameters.Add("hardDelete", UriHelper.ParameterToString(hardDelete.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/topics/{Uri.EscapeDataString(topicId)}", parameters);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTopicDataIngestionRuleFacebookAsync(string topicId, string facebookIngestionRuleId, bool? hardDelete = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);
        ArgumentException.ThrowIfNullOrEmpty(facebookIngestionRuleId);

        var parameters = new NameValueCollection();

        if (hardDelete.HasValue)
        {
            parameters.Add("hardDelete", UriHelper.ParameterToString(hardDelete.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/topics/{Uri.EscapeDataString(topicId)}/dataingestionrules/facebook/{Uri.EscapeDataString(facebookIngestionRuleId)}", parameters);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTopicDataIngestionRuleOpenAsync(string topicId, string openId, bool? hardDelete = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);
        ArgumentException.ThrowIfNullOrEmpty(openId);

        var parameters = new NameValueCollection();

        if (hardDelete.HasValue)
        {
            parameters.Add("hardDelete", UriHelper.ParameterToString(hardDelete.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/topics/{Uri.EscapeDataString(topicId)}/dataingestionrules/open/{Uri.EscapeDataString(openId)}", parameters);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTopicDataIngestionRuleTwitterAsync(string topicId, string twitterIngestionRuleId, bool? hardDelete = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);
        ArgumentException.ThrowIfNullOrEmpty(twitterIngestionRuleId);

        var parameters = new NameValueCollection();

        if (hardDelete.HasValue)
        {
            parameters.Add("hardDelete", UriHelper.ParameterToString(hardDelete.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/topics/{Uri.EscapeDataString(topicId)}/dataingestionrules/twitter/{Uri.EscapeDataString(twitterIngestionRuleId)}", parameters);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<SocialMediaAsyncAggregateQueryResponse> GetAnalyticsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(cursor))
        {
            parameters.Add("cursor", UriHelper.ParameterToString(cursor));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/analytics/aggregates/jobs/{Uri.EscapeDataString(jobId)}/results", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SocialMediaAsyncAggregateQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EscalationRuleResponse> GetEscalationRuleAsync(string escalationRuleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(escalationRuleId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/escalationrules/{Uri.EscapeDataString(escalationRuleId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EscalationRuleResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SocialEscalationResponseEntityListing> GetEscalationRulesAsync(string divisionId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        var parameters = new NameValueCollection();

        parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/socialmedia/escalationrules", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SocialEscalationResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SocialTopicResponse> GetTopicAsync(string topicId, bool? includeDeleted = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);

        var parameters = new NameValueCollection();

        if (includeDeleted.HasValue)
        {
            parameters.Add("includeDeleted", UriHelper.ParameterToString(includeDeleted.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/topics/{Uri.EscapeDataString(topicId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SocialTopicResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SocialTopicResponseEntityListing> GetTopicsAsync(int? pageNumber = null, int? pageSize = null, IEnumerable<string> divisionIds = null, bool? includeDeleted = null, CancellationToken cancellationToken = default)
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

        if (divisionIds != null)
        {
            foreach (var divisionId in divisionIds)
            {
                parameters.Add("divisionIds", UriHelper.ParameterToString(divisionId));
            }
        }

        if (includeDeleted.HasValue)
        {
            parameters.Add("includeDeleted", UriHelper.ParameterToString(includeDeleted.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/socialmedia/topics", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SocialTopicResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataIngestionRuleResponseEntityListing> GetTopicDataIngestionRulesAsync(string topicId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (includeDeleted.HasValue)
        {
            parameters.Add("includeDeleted", UriHelper.ParameterToString(includeDeleted.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/topics/{Uri.EscapeDataString(topicId)}/dataingestionrules", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataIngestionRuleResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<FacebookDataIngestionRuleResponse> GetTopicDataIngestionRuleFacebookAsync(string topicId, string facebookIngestionRuleId, bool? includeDeleted = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);
        ArgumentException.ThrowIfNullOrEmpty(facebookIngestionRuleId);

        var parameters = new NameValueCollection();

        if (includeDeleted.HasValue)
        {
            parameters.Add("includeDeleted", UriHelper.ParameterToString(includeDeleted.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/topics/{Uri.EscapeDataString(topicId)}/dataingestionrules/facebook/{Uri.EscapeDataString(facebookIngestionRuleId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FacebookDataIngestionRuleResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OpenDataIngestionRuleResponse> GetTopicDataIngestionRuleOpenAsync(string topicId, string openId, bool? includeDeleted = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);
        ArgumentException.ThrowIfNullOrEmpty(openId);

        var parameters = new NameValueCollection();

        if (includeDeleted.HasValue)
        {
            parameters.Add("includeDeleted", UriHelper.ParameterToString(includeDeleted.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/topics/{Uri.EscapeDataString(topicId)}/dataingestionrules/open/{Uri.EscapeDataString(openId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OpenDataIngestionRuleResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TwitterDataIngestionRuleResponse> GetTopicDataIngestionRuleTwitterAsync(string topicId, string twitterIngestionRuleId, bool? includeDeleted = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);
        ArgumentException.ThrowIfNullOrEmpty(twitterIngestionRuleId);

        var parameters = new NameValueCollection();

        if (includeDeleted.HasValue)
        {
            parameters.Add("includeDeleted", UriHelper.ParameterToString(includeDeleted.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/topics/{Uri.EscapeDataString(topicId)}/dataingestionrules/twitter/{Uri.EscapeDataString(twitterIngestionRuleId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TwitterDataIngestionRuleResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<FacebookDataIngestionRuleVersionResponseEntityListing> GetTopicDataIngestionRuleFacebookVersionsAsync(string topicId, string facebookIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);
        ArgumentException.ThrowIfNullOrEmpty(facebookIngestionRuleId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (includeDeleted.HasValue)
        {
            parameters.Add("includeDeleted", UriHelper.ParameterToString(includeDeleted.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/topics/{Uri.EscapeDataString(topicId)}/dataingestionrules/facebook/{Uri.EscapeDataString(facebookIngestionRuleId)}/versions", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<FacebookDataIngestionRuleVersionResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OpenDataIngestionRuleVersionResponseEntityListing> GetTopicDataIngestionRuleOpenVersionsAsync(string topicId, string openId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);
        ArgumentException.ThrowIfNullOrEmpty(openId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (includeDeleted.HasValue)
        {
            parameters.Add("includeDeleted", UriHelper.ParameterToString(includeDeleted.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/topics/{Uri.EscapeDataString(topicId)}/dataingestionrules/open/{Uri.EscapeDataString(openId)}/versions", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OpenDataIngestionRuleVersionResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TwitterDataIngestionRuleVersionResponseEntityListing> GetTopicDataIngestionRuleTwitterVersionsAsync(string topicId, string twitterIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(topicId);
        ArgumentException.ThrowIfNullOrEmpty(twitterIngestionRuleId);

        var parameters = new NameValueCollection();

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (includeDeleted.HasValue)
        {
            parameters.Add("includeDeleted", UriHelper.ParameterToString(includeDeleted.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/socialmedia/topics/{Uri.EscapeDataString(topicId)}/dataingestionrules/twitter/{Uri.EscapeDataString(twitterIngestionRuleId)}/versions", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TwitterDataIngestionRuleVersionResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }
}
