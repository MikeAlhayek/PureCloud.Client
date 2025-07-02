using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IAgentAssistantsApi
{
    Task<Assistant> GetAssistantAsync(string assistantId, string expand = null, CancellationToken cancellationToken = default);

    Task<AssistantQueue> GetAssistantQueueAsync(string assistantId, string queueId, string expand = null, CancellationToken cancellationToken = default);

    Task<AssistantQueueListing> GetAssistantQueuesAsync(string assistantId, string before = null, string after = null, string pageSize = null, string expand = null, CancellationToken cancellationToken = default);

    Task<AssistantListing> GetAssistantsAsync(string before = null, string after = null, string limit = null, string pageSize = null, string name = null, CancellationToken cancellationToken = default);

    Task<AssistantQueueListing> GetAssistantsQueuesAsync(string before = "", string after = "", string pageSize = "", string queueIds = "", string expand = "", CancellationToken cancellationToken = default);

    Task<Assistant> UpdateAssistantAsync(string assistantId, Assistant body, CancellationToken cancellationToken = default);

    Task<AssistantQueueListing> UpdateAssistantQueuesAsync(string assistantId, List<AssistantQueue> body, CancellationToken cancellationToken = default);

    Task<AssistantQueue> UpdateAssistantQueueAsync(string assistantId, string queueId, AssistantQueue body, CancellationToken cancellationToken = default);

    Task<Assistant> CreateAssistantsAsync(Assistant body, CancellationToken cancellationToken = default);

    Task<bool> DeleteAssistantAsync(string assistantId, CancellationToken cancellationToken = default);

    Task<bool> DeleteAssistantQueueAsync(string assistantId, string queueId, CancellationToken cancellationToken = default);

    Task<bool> DeleteAssistantQueuesAsync(string assistantId, string queueIds = null, CancellationToken cancellationToken = default);
}
