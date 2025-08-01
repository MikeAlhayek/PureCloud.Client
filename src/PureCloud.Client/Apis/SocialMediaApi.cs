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

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteMessageAsync(string messageId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(messageId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/socialmedia/messages/{Uri.EscapeDataString(messageId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
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

        return response.IsSuccessStatusCode;
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

        return response.IsSuccessStatusCode;
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

        return response.IsSuccessStatusCode;
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

        return response.IsSuccessStatusCode;
    }
}