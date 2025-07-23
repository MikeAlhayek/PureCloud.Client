using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

/// <summary>
/// OperationalEventsApi interface
/// </summary>
public interface IOperationalEventsApi
{
    /// <summary>
    /// Get an operational event definition by its id
    /// </summary>
    /// <param name="eventDefinitionId">EventDefinition id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EventDefinition</returns>
    Task<EventDefinition> GetUsageEventsDefinitionAsync(string eventDefinitionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all operational event definitions
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EventDefinitionListing</returns>
    Task<EventDefinitionListing> GetUsageEventsDefinitionsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get aggregates for operational events in a timeframe.
    /// </summary>
    /// <param name="body">EventAggregatesQueryRequest</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EventAggregatesResponse</returns>
    Task<EventAggregatesResponse> CreateUsageEventsAggregatesQueryAsync(EventAggregatesQueryRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query operational events in a timeframe.
    /// </summary>
    /// <param name="body">EventQueryRequest</param>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned.</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned.</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EventQueryResponse</returns>
    Task<EventQueryResponse> CreateUsageEventsQueryAsync(EventQueryRequest body, string before = null, string after = null, string pageSize = null, CancellationToken cancellationToken = default);
}