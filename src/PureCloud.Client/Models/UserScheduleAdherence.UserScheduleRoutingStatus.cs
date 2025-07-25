namespace PureCloud.Client.Models;

/// <summary>
/// Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue
/// </summary>
public enum UserScheduleRoutingStatus
{
    OffQueue,
    Idle,
    Interacting,
    NotResponding,
    Communicating
}