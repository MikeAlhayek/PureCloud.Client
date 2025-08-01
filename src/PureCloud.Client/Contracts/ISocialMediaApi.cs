using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ISocialMediaApi
{
    /// <summary>
    /// Get status for async query for social media aggregates
    /// </summary>
    Task<AsyncQueryStatus> GetAnalyticsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query for social media aggregates asynchronously
    /// </summary>
    Task<AsyncQueryResponse> CreateAnalyticsAggregatesJobAsync(SocialMediaAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get status for async query for social media messages job
    /// </summary>
    Task<AsyncQueryStatus> GetAnalyticsMessagesJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Fetch a page of results for an async social media messages query
    /// </summary>
    Task<SocialMediaAsyncDetailQueryResponse> GetAnalyticsMessagesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query for social media messages asynchronously
    /// </summary>
    Task<AsyncQueryResponse> CreateAnalyticsMessagesJobAsync(SocialMediaAsyncDetailQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an escalation rule.
    /// </summary>
    Task<bool> DeleteEscalationRuleAsync(string escalationRuleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a social media message.
    /// </summary>
    Task<bool> DeleteMessageAsync(string messageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a social topic.
    /// </summary>
    Task<bool> DeleteTopicAsync(string topicId, bool? hardDelete = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a Facebook data ingestion rule.
    /// </summary>
    Task<bool> DeleteTopicDataIngestionRuleFacebookAsync(string topicId, string facebookIngestionRuleId, bool? hardDelete = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a open data ingestion rule.
    /// </summary>
    Task<bool> DeleteTopicDataIngestionRuleOpenAsync(string topicId, string openId, bool? hardDelete = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a X (formally Twitter) data ingestion rule.
    /// </summary>
    Task<bool> DeleteTopicDataIngestionRuleTwitterAsync(string topicId, string twitterIngestionRuleId, bool? hardDelete = null, CancellationToken cancellationToken = default);
}