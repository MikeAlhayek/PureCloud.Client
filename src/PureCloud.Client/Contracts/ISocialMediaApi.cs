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
    /// Query for social media messages asynchronously
    /// </summary>
    Task<AsyncQueryResponse> CreateAnalyticsMessagesJobAsync(SocialMediaAsyncDetailQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a social topic.
    /// </summary>
    Task DeleteTopicAsync(string topicId, CancellationToken cancellationToken = default);
}