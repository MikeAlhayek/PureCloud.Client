using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IProcessAutomationApi
{
    /// <summary>
    /// Delete a Trigger
    /// </summary>
    /// <param name="triggerId">triggerId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task of bool indicating success</returns>
    Task<bool> DeleteTriggerAsync(string triggerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a single Trigger matching id
    /// </summary>
    /// <param name="triggerId">triggerId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task of Trigger</returns>
    Task<Trigger> GetTriggerAsync(string triggerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves all triggers, optionally filtered by query parameters.
    /// </summary>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="topicName">Topic name(s). Separated by commas (optional)</param>
    /// <param name="enabled">Boolean indicating desired enabled state of triggers (optional)</param>
    /// <param name="hasDelayBy">Boolean to filter based on delayBySeconds being set in triggers. Default returns all, true returns only those with delayBySeconds set, false returns those without delayBySeconds set. (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task of TriggerEntityListing</returns>
    Task<TriggerEntityListing> GetTriggersAsync(string before = null, string after = null, string pageSize = null, string topicName = null, bool? enabled = null, bool? hasDelayBy = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get topics available for organization
    /// </summary>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task of TopicCursorEntityListing</returns>
    Task<TopicCursorEntityListing> GetTriggersTopicsAsync(string before = null, string after = null, string pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Test the matching of a Trigger based on provided event body
    /// </summary>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">eventBody (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task of TestModeResults</returns>
    Task<TestModeResults> CreateTriggerTestAsync(string triggerId, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a Trigger
    /// </summary>
    /// <param name="body">Input used to create a Trigger.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task of Trigger</returns>
    Task<Trigger> CreateTriggerAsync(CreateTriggerRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Test the matching of all organization Triggers on given topic using provided event body
    /// </summary>
    /// <param name="topicName">topicName</param>
    /// <param name="body">eventBody (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task of TestModeEventResults</returns>
    Task<TestModeEventResults> CreateTriggersTopicTestAsync(string topicName, string body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Trigger
    /// </summary>
    /// <param name="triggerId">triggerId</param>
    /// <param name="body">Input to update Trigger. (topicName cannot be updated, a new trigger must be created to use a new topicName)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task of Trigger</returns>
    Task<Trigger> UpdateTriggerAsync(string triggerId, UpdateTriggerRequest body, CancellationToken cancellationToken = default);
}