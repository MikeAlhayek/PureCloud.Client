using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ISocialMediaApi
{
    /// <summary>
    /// Get status for async query for social media aggregates
    /// </summary>
    /// <param name="jobId">Job ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<AsyncQueryStatus> GetAnalyticsAggregatesJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query for social media aggregates asynchronously
    /// </summary>
    /// <param name="body">Query request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<AsyncQueryResponse> CreateAnalyticsAggregatesJobAsync(SocialMediaAsyncAggregationQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get status for async query for social media messages job
    /// </summary>
    /// <param name="jobId">Job ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<AsyncQueryStatus> GetAnalyticsMessagesJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Fetch a page of results for an async social media messages query
    /// </summary>
    /// <param name="jobId">Job ID</param>
    /// <param name="cursor">Cursor for pagination</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<SocialMediaAsyncDetailQueryResponse> GetAnalyticsMessagesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query for social media messages asynchronously
    /// </summary>
    /// <param name="body">Query request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<AsyncQueryResponse> CreateAnalyticsMessagesJobAsync(SocialMediaAsyncDetailQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an escalation rule.
    /// </summary>
    /// <param name="escalationRuleId">Escalation rule ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteEscalationRuleAsync(string escalationRuleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a social media message.
    /// </summary>
    /// <param name="messageId">Message ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteMessageAsync(string messageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a social topic.
    /// </summary>
    /// <param name="topicId">Topic ID</param>
    /// <param name="hardDelete">Hard delete flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteTopicAsync(string topicId, bool? hardDelete = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a Facebook data ingestion rule.
    /// </summary>
    /// <param name="topicId">Topic ID</param>
    /// <param name="facebookIngestionRuleId">Facebook ingestion rule ID</param>
    /// <param name="hardDelete">Hard delete flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteTopicDataIngestionRuleFacebookAsync(string topicId, string facebookIngestionRuleId, bool? hardDelete = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a open data ingestion rule.
    /// </summary>
    /// <param name="topicId">Topic ID</param>
    /// <param name="openId">Open ingestion rule ID</param>
    /// <param name="hardDelete">Hard delete flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteTopicDataIngestionRuleOpenAsync(string topicId, string openId, bool? hardDelete = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a X (formally Twitter) data ingestion rule.
    /// </summary>
    /// <param name="topicId">Topic ID</param>
    /// <param name="twitterIngestionRuleId">Twitter ingestion rule ID</param>
    /// <param name="hardDelete">Hard delete flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteTopicDataIngestionRuleTwitterAsync(string topicId, string twitterIngestionRuleId, bool? hardDelete = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Fetch a page of results for an async social media aggregates query
    /// </summary>
    /// <param name="jobId">Job ID</param>
    /// <param name="cursor">Cursor for pagination</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<SocialMediaAsyncAggregateQueryResponse> GetAnalyticsAggregatesJobResultsAsync(string jobId, string cursor = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an escalation rule
    /// </summary>
    /// <param name="escalationRuleId">Escalation rule ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EscalationRuleResponse> GetEscalationRuleAsync(string escalationRuleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of escalation rules
    /// </summary>
    /// <param name="divisionId">Division ID</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<SocialEscalationResponseEntityListing> GetEscalationRulesAsync(string divisionId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a social topic
    /// </summary>
    /// <param name="topicId">Topic ID</param>
    /// <param name="includeDeleted">Include deleted flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<SocialTopicResponse> GetTopicAsync(string topicId, bool? includeDeleted = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of social topics
    /// </summary>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="divisionIds">Division IDs</param>
    /// <param name="includeDeleted">Include deleted flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<SocialTopicResponseEntityListing> GetTopicsAsync(int? pageNumber = null, int? pageSize = null, IEnumerable<string> divisionIds = null, bool? includeDeleted = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of data ingestion rules for a social topic
    /// </summary>
    /// <param name="topicId">Topic ID</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="includeDeleted">Include deleted flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DataIngestionRuleResponseEntityListing> GetTopicDataIngestionRulesAsync(string topicId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Facebook data ingestion rule
    /// </summary>
    /// <param name="topicId">Topic ID</param>
    /// <param name="facebookIngestionRuleId">Facebook ingestion rule ID</param>
    /// <param name="includeDeleted">Include deleted flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<FacebookDataIngestionRuleResponse> GetTopicDataIngestionRuleFacebookAsync(string topicId, string facebookIngestionRuleId, bool? includeDeleted = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an open data ingestion rule
    /// </summary>
    /// <param name="topicId">Topic ID</param>
    /// <param name="openId">Open ingestion rule ID</param>
    /// <param name="includeDeleted">Include deleted flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<OpenDataIngestionRuleResponse> GetTopicDataIngestionRuleOpenAsync(string topicId, string openId, bool? includeDeleted = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a Twitter data ingestion rule
    /// </summary>
    /// <param name="topicId">Topic ID</param>
    /// <param name="twitterIngestionRuleId">Twitter ingestion rule ID</param>
    /// <param name="includeDeleted">Include deleted flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TwitterDataIngestionRuleResponse> GetTopicDataIngestionRuleTwitterAsync(string topicId, string twitterIngestionRuleId, bool? includeDeleted = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Facebook data ingestion rule versions
    /// </summary>
    /// <param name="topicId">Topic ID</param>
    /// <param name="facebookIngestionRuleId">Facebook ingestion rule ID</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="includeDeleted">Include deleted flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<FacebookDataIngestionRuleVersionResponseEntityListing> GetTopicDataIngestionRuleFacebookVersionsAsync(string topicId, string facebookIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get open data ingestion rule versions
    /// </summary>
    /// <param name="topicId">Topic ID</param>
    /// <param name="openId">Open ingestion rule ID</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="includeDeleted">Include deleted flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<OpenDataIngestionRuleVersionResponseEntityListing> GetTopicDataIngestionRuleOpenVersionsAsync(string topicId, string openId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Twitter data ingestion rule versions
    /// </summary>
    /// <param name="topicId">Topic ID</param>
    /// <param name="twitterIngestionRuleId">Twitter ingestion rule ID</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="includeDeleted">Include deleted flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TwitterDataIngestionRuleVersionResponseEntityListing> GetTopicDataIngestionRuleTwitterVersionsAsync(string topicId, string twitterIngestionRuleId, int? pageNumber = null, int? pageSize = null, bool? includeDeleted = null, CancellationToken cancellationToken = default);
}
