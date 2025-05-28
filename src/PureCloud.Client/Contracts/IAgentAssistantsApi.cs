using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IAgentAssistantsApi
{
    // GET methods
    Task<Assistant> GetAssistantAsync(string assistantId, string expand = null, CancellationToken cancellationToken = default);

    Task<AssistantQueue> GetAssistantQueueAsync(string assistantId, string queueId, string expand = null, CancellationToken cancellationToken = default);

    Task<AssistantQueueListing> GetAssistantQueuesAsync(string assistantId, string before = null, string after = null, string pageSize = null, string expand = null, CancellationToken cancellationToken = default);

    Task<AssistantListing> GetAssistantsAsync(string before = null, string after = null, string limit = null, string pageSize = null, string name = null, CancellationToken cancellationToken = default);

    Task<AssistantQueueListing> GetAssistantsQueuesAsync(string before = "", string after = "", string pageSize = "", string queueIds = "", string expand = "", CancellationToken cancellationToken = default);

    // PATCH methods
    Task<Assistant> PatchAssistantAsync(string assistantId, Assistant body, CancellationToken cancellationToken = default);

    Task<AssistantQueueListing> PatchAssistantQueuesAsync(string assistantId, List<AssistantQueue> body, CancellationToken cancellationToken = default);

    // PUT method
    Task<AssistantQueue> PutAssistantQueueAsync(string assistantId, string queueId, AssistantQueue body, CancellationToken cancellationToken = default);

    // POST method
    Task<Assistant> PostAssistantsAsync(Assistant body, CancellationToken cancellationToken = default);

    // DELETE methods
    Task<bool> DeleteAssistantAsync(string assistantId, CancellationToken cancellationToken = default);

    Task<bool> DeleteAssistantQueueAsync(string assistantId, string queueId, CancellationToken cancellationToken = default);

    Task<bool> DeleteAssistantQueuesAsync(string assistantId, string queueIds = null, CancellationToken cancellationToken = default);
}
