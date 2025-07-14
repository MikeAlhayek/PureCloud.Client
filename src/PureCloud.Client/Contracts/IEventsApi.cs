using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IEventsApi
{
    Task<BatchEventResponse> CreateEventsConversationsAsync(BatchConversationEventRequest body, CancellationToken cancellationToken = default);

    Task<BatchEventResponse> CreateEventsUsersPresenceAsync(BatchUserPresenceEventRequest body, CancellationToken cancellationToken = default);

    Task<BatchEventResponse> CreateEventsUsersRoutingstatusAsync(BatchUserRoutingStatusEventRequest body, CancellationToken cancellationToken = default);
}
