using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IProcessAutomationApi
{
    Task<bool> DeleteTriggerAsync(string triggerId, CancellationToken cancellationToken = default);

    Task<Trigger> GetTriggerAsync(string triggerId, CancellationToken cancellationToken = default);

    Task<TriggerEntityListing> GetTriggersAsync(string before = null, string after = null, string pageSize = null, string topicName = null, bool? enabled = null, bool? hasDelayBy = null, CancellationToken cancellationToken = default);

    Task<TopicCursorEntityListing> GetTriggersTopicsAsync(string before = null, string after = null, string pageSize = null, CancellationToken cancellationToken = default);

    Task<TestModeResults> CreateTriggerTestAsync(string triggerId, string body = null, CancellationToken cancellationToken = default);

    Task<Trigger> CreateTriggerAsync(CreateTriggerRequest body, CancellationToken cancellationToken = default);

    Task<TestModeEventResults> CreateTriggersTopicTestAsync(string topicName, string body = null, CancellationToken cancellationToken = default);

    Task<Trigger> UpdateTriggerAsync(string triggerId, UpdateTriggerRequest body, CancellationToken cancellationToken = default);
}